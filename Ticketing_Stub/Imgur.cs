using System.Windows.Forms;
using System.Xml;

namespace Ticketing_Stub
{
    public class Imgur
    {
        public static string IMGUR_CLIENT_ID;
        public static string IMGUR_CLIENT_SECRET;

        public static string IMAGE_URL { get; set; }

        public static void ConfigImgur()
        {
            string path = Application.StartupPath + "\\Config.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlElement root = doc.DocumentElement;
            XmlNode id = root.SelectSingleNode("ImgurClientID");
            XmlNode secret = root.SelectSingleNode("ImgurClientSecret");
            string idString = id.InnerText;
            string secretString = secret.InnerText;
            IMGUR_CLIENT_ID = idString;
            IMGUR_CLIENT_SECRET = secretString;
        }
    }
}
