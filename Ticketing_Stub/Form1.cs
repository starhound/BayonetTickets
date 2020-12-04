using System;
using System.DirectoryServices.AccountManagement;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ticketing_Stub
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Clears the main form of all values entered
        /// </summary>
        /// 
        public void ClearIssue()
        {
            //clear input values
            issueTextBox.Text = "";
            screenShotLabel.Text = "";
            Imgur.IMGUR_SCREENSHOT_PATH = null;
            generalComboBox.SelectedIndex = 0;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearIssue();
        }

        bool DetermineComboBoxes()
        {
            //bug fix for 1.9.2
            if (generalComboBox.SelectedIndex == 0 && issueTextBox.Text.Length == 0)
            {
                MessageBox.Show("Please select a general and specific issue or enter in a description of your problem.");
                return false;
            }
            //if general is picked
            if (generalComboBox.SelectedIndex != 0)
            {
                //specific not selected
                if (specificComboBox.SelectedIndex == 0)
                {
                    //no text entered
                    if (issueTextBox.Text.Length == 0)
                    {
                        MessageBox.Show("Please select a specific issue or enter in a description of your problem.");
                        return false;
                    }
                }
            }
            //no general
            if (generalComboBox.SelectedIndex == 0)
            {
                //no specific
                if (specificComboBox.SelectedIndex == -1)
                {
                    //no issue text
                    if (issueTextBox.Text.Length == 0)
                    {
                        MessageBox.Show("Please select a general issue and a specific issue, or describe your problem in the text box provided.");
                        return false;
                    }
                }
            }
            return true;
        }

        private async void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                string general = "";
                string specific = "";

                if (generalComboBox.SelectedIndex != -1)
                    general = generalComboBox.Text;
                if (specificComboBox.SelectedIndex != -1)
                    specific = specificComboBox.Text;

                bool ComboBoxesCheck = DetermineComboBoxes();
                if (!ComboBoxesCheck)
                    return;

                string issue = "\n";

                if (general.Length > 0)
                    issue += "(General Issue) " + general + "\n";

                if (specific.Length > 0)
                    issue += "(Specific Issue) " + specific + "\n";

                if (issueTextBox.Text.Length > 0)
                    issue += issueTextBox.Text;

                //grab some user info (AD email, user name, host name, ip addr)
                string email = UserPrincipal.Current.EmailAddress;
                string user_name = Environment.UserName;
                string host_name = Dns.GetHostName();
                string ip_address = "";

                //grab local ip address
                var host = Dns.GetHostEntry(host_name);
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        ip_address = ip.ToString();
                        break;
                    }
                }

                //if we couldnt find ip addr
                if (ip_address.Length == 0)
                    ip_address = "UNKNOWN";

                //check for file uploading
                string image_path = Imgur.IMGUR_SCREENSHOT_PATH;
                if (image_path != null)
                {
                    await Imgur.postImageToImgur(image_path);
                }
                else
                {
                    Imgur.IMAGE_URL = "None uploaded";
                }

                //begin formulation of ticket string
                string ticket = "User_Name: " + user_name + "\n";
                ticket += "User_Email: " + email + "\n";
                ticket += "Host_Name: " + host_name + "\n";
                ticket += "IP_Address: " + ip_address + "\n";
                ticket += "Image_URL: " + Imgur.IMAGE_URL + "\n";
                ticket += "Status: *Active*" + "\n";
                ticket += "Issue: " + issue + "\n";

                API.submitTicket(ticket, host_name);

                ClearIssue();

                MessageBox.Show("Ticket submitted to IT Department! A member of the team will be with you shortly.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured: please contact IT staff directly. \n\nERROR:" + ex.Message);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var searchForm = new Form2();
            searchForm.Show();
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            if(screenShotLabel.Text.Length > 0)
            {
                screenShotLabel.Text = "Screen Shot Already Captured!";
                return;
            }

            DateTime time = DateTime.Now;
            string fileName = Environment.UserName + "_" + time.ToString("MM-dd-yyyy_hh-mm-ss") + ".jpeg";
            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            if (!Directory.Exists(path + "\\TicketScreenShots"))
            {
                Directory.CreateDirectory(path + "\\TicketScreenShots");
            }

            string imagePath = path + "\\TicketScreenShots\\" + fileName;
            int screenLeft = SystemInformation.VirtualScreen.Left;
            int screenTop = SystemInformation.VirtualScreen.Top;
            int screenWidth = SystemInformation.VirtualScreen.Width;
            int screenHeight = SystemInformation.VirtualScreen.Height;

            using (Bitmap bmp = new Bitmap(screenWidth, screenHeight))
            {
                // Draw the screenshot into our bitmap.
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    g.CopyFromScreen(screenLeft, screenTop, 0, 0, bmp.Size);
                }

                // Do something with the Bitmap here, like save it to a file:
                bmp.Save(imagePath, ImageFormat.Jpeg);
            }

            screenShotLabel.Text = "Screen shot taken!";
            Imgur.IMGUR_SCREENSHOT_PATH = imagePath;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            generalComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            specificComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            generalComboBox.DataSource = ComboItem.GeneralIssues();
            generalComboBox.DisplayMember = Text;
            specificComboBox.DisplayMember = Text;
            string app = "Bayonet IT Tickets Program";
            string version = File.ReadAllText(Application.StartupPath + "\\Version.txt");
            this.Text = app + " " + version;
            Task.Run(() => Imgur.ConfigImgur());
            Task.Run(() => API.ConfigureAPI());
        }

        private void generalComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            specificComboBox.SelectedIndex = -1;
            string name = generalComboBox.Text;
            if (name.Equals(-1) || name.Equals(" "))
            {
                specificComboBox.DataSource = ComboItem.Blank();
                return;
            }
            specificComboBox.DataSource = ComboItem.SpecificIssues(name);
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            string help = "To submit a ticket to the IT department you must have a Bayonet Chat account.";
            help += Environment.NewLine;
            help += Environment.NewLine;
            help += "Please select a common and specific issue from the drop down menus. If your issue cannot be found from the general menus, please describe your problem in the Issue text field.";
            help += Environment.NewLine;
            help += Environment.NewLine;
            help += "If you would like to upload a screen shot of the issue you are having please click the Take ScreenShot button.";
            help += Environment.NewLine;
            help += Environment.NewLine;
            help += "Once you have filled out all the desired information please click the Submit button to send a ticket to the IT department.";
            help += Environment.NewLine;
            help += Environment.NewLine;
            help += "To view open tickets you have with the IT department, please press the Search button.";
            help += Environment.NewLine;
            help += Environment.NewLine;
            help += "To clear this program, press the Clear button.";
            MessageBox.Show(help);
        }
    }
}
