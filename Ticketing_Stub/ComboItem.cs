using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;

namespace Ticketing_Stub
{
    class ComboItem
    {
        public int ID { get; set; }
        public string Text { get; set; }

        public ComboItem(int id, string text)
        {
            ID = id;
            Text = text;
        }

        public static XmlDocument GetIssuesXML()
        {
            string path = Application.StartupPath + "\\Issues.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            return doc;
        }

        public static XmlNode GetIssuesNodeList()
        {
            XmlDocument doc = GetIssuesXML();
            XmlNode node = doc.SelectSingleNode("/issues");
            return node;
        }

        public static XmlNode GetSpecificIssueNode(string type)
        {
            string path = Application.StartupPath + "\\Issues.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            XmlElement root = doc.DocumentElement;
            XmlNodeList node = root.GetElementsByTagName(type);
            return node[0];
        }

        public static IList<ComboItem> Blank()
        {
            return new List<ComboItem>() { new ComboItem(0, " ") };
        }

        public static IList<ComboItem> GeneralIssues()
        {
            IList<ComboItem> items = new List<ComboItem>();
            items.Add(new ComboItem(0, " "));
            int count = 1;
            foreach (XmlNode node in GetIssuesNodeList())
            {
                ComboItem item = new ComboItem(count, node.Name);
                count++;
                items.Add(item);
            }
            return items;
        }

        public static IList<ComboItem> SpecificIssues(string type)
        {
            IList<ComboItem> items = new List<ComboItem>();
            items.Add(new ComboItem(0, " "));
            if (type.Equals(null) || type.Equals(" "))
                return items;

            int count = 1;
            foreach (XmlElement element in GetSpecificIssueNode(type))
            {
                items.Add(new ComboItem(count, element.InnerText));
                count++;
            }
            return items;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}