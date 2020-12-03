using Imgur.API;
using Imgur.API.Authentication.Impl;
using Imgur.API.Endpoints.Impl;
using Imgur.API.Models;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Ticketing_Stub
{
    public class Imgur
    {
        public static string IMGUR_CLIENT_ID;
        public static string IMGUR_CLIENT_SECRET;
        public static string IMGUR_SCREENSHOT_PATH { get; set; }

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

        public static async Task postImageToImgur(string imagePath)
        {
            try
            {
                var client = new ImgurClient(Imgur.IMGUR_CLIENT_ID, Imgur.IMGUR_CLIENT_SECRET);
                var endpoint = new ImageEndpoint(client);
                IImage image;
                using (var fs = new FileStream(imagePath, FileMode.Open))
                {
                    image = await endpoint.UploadImageStreamAsync(fs);
                }
                IMAGE_URL = image.Link;
            }
            catch (ImgurException imgurEx)
            {
                IMAGE_URL = imgurEx.Message;
            }
        }
    }
}
