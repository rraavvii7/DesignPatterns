
using System.Xml.Serialization;

namespace DesignPatterns.Structural.AdapterDesignPattern.Adaptee
{
    [Serializable]
    public class Company
    {
        public Company()
        {

        }

        public Company(int Id, string name)
        {
            ID = Id;
            Name = name;
        }
        [XmlAttribute]
        public int ID { get; set; }
        [XmlAttribute]
        public string Name { get; set; }
    }
}
