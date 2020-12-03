using System.Windows.Forms;
using System.Xml;

namespace Ticketing_Stub
{
    public class Imgur
    {
        public static string IMGUR_CLIENT_ID;
        public static string IMGUR_CLIENT_SECRET;

        public static void ConfigImgur()
        {
            string path = Application.StartupPath + "\\Resources\\Config.xml";
            MessageBox.Show(path);
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlElement root = doc.DocumentElement;
            XmlNode id = root.SelectSingleNode("ImgurClientID");
            XmlNode secret = root.SelectSingleNode("ImgurClientSecret");
            string idString = id.InnerText;
            string secretString = secret.InnerText;
            MessageBox.Show(idString + "\n" + secretString);
        }
    }
}
