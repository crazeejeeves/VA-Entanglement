using System;
using System.Xml;
using System.Diagnostics;

namespace entanglement.Plugin.App.Elite
{
    public class BindingParser
    {
        private static readonly string xpBindableRule = @"//*[Primary]";
        private static readonly string xpKeyNodes = @"Primary | Secondary";

        public BindingParser()
        {
        }

        public void ProcessSource(string srcPath)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(srcPath);

            XmlNodeList bindingList = doc.SelectNodes(xpBindableRule);
            foreach(XmlNode command in bindingList)
            {
                Debug.WriteLine(
                "<Command Include=\"true\">" +
                    "<SourceName>" + command.Name + "</SourceName>" +
                    "<FriendlyName>" + command.Name + "</FriendlyName>" +
                "</Command>");


                //XmlNodeList keyList = command.SelectNodes(xpKeyNodes);
                //foreach(XmlNode key in keyList)
                //{
                //    Debug.WriteLine(key.Name + " :: " + key.Attributes["Key"].Value);
                //}
            }

        }
    }
}


//XmlDocument xmlDoc = new XmlDocument();
//xmlDoc.Load("http://rss.cnn.com/rss/edition_world.rss");
//XmlNodeList titleNodes = xmlDoc.SelectNodes("//rss/channel/item/title");
//foreach(XmlNode titleNode in titleNodes)
//    Console.WriteLine(titleNode.InnerText);            
