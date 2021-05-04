using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace WebAtrio
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ReadXml();
        }

        private void ReadXml()
        {
            XmlDocument document = null;
            XmlNodeList nodeList = null;
            string path = VirtualPathUtility.ToAbsolute("~/App_Data/libraries.xml");

            try
            {
                document = new XmlDocument();
                document.Load(@"C:\Users\fredd\source\Test\WebAtrio\App_Data\libraries.xml");

                //-- 1) Retourner tous les éléments book
                nodeList = document.SelectNodes("/library/book");

                //-- 2) Retourner tous les éléments title ayant comme parent un élément book avec un attribut type égal à roman
                nodeList = document.SelectNodes("/library/book[@type='roman']/title");

                //-- 3) Retourner le nombre d'éléments book ayant un attribut type égal à bd
                nodeList = document.SelectNodes("/library/book[@type='bd']");

                //-- 4) Que renvoie la requête XPath suivante :  / library / library / ancestor - or - self::library
                nodeList = document.SelectNodes("/library/library/ancestor-or-self::library"); //-- Renvoie le première fille et derniere fille du noeud racine library
            }
            catch (Exception ex)
            {
            }
        }
    }
}