using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Windows.Forms;

namespace Ticketing_Stub
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        ArrayList user_tickets = new ArrayList();

        private void Form2_Load(object sender, EventArgs e)
        {
            user_tickets = API.GetUserTickets();
            if (user_tickets.Count > 0 && user_tickets != null)
            {
                foreach (JToken ticket in user_tickets)
                {
                    string time = ticket["ts"].ToString();
                    currentTicketsListBox.Items.Add(time);
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void expandButton_Click(object sender, EventArgs e)
        {
            foreach (JToken ticket in user_tickets)
            {
                string time = ticket["ts"].ToString();
                string selected = currentTicketsListBox.GetItemText(currentTicketsListBox.SelectedItem);
                if (time == selected)
                {
                    string msg = ticket["msg"].ToString();
                    ticketOutputTextBox.Text = msg.Replace("\n", Environment.NewLine);
                }
            }
        }
    }
}
