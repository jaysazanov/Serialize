using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialize
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Serial
    {
        [XmlElement(Namespace = "http://planetakino.ua/odessa/ua/showtimes/xml/")]
        public string ItemName;
        [XmlElement(DataType = "movies")]
        public string movies;
        [XmlElement(DataType = "movie")]
        public string movie;
        [XmlElement(DataType = "title")]
    } 
}
