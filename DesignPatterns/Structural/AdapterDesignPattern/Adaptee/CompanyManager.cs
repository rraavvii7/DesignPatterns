
using System.Xml;
using System.Xml.Serialization;

namespace DesignPatterns.Structural.AdapterDesignPattern.Adaptee
{
    public class CompanyManager
    {
        private List<Company> _companies;
        public CompanyManager()
        {
            _companies = new List<Company>
            {
                new Company(1, "Infosys Limited"),
                new Company(2, "Ernst & Young"),
                new Company(3, "Honeywell"),
                new Company(4, "Schneider Electric"),
            };
        }

        public virtual string GetAllCompanies()
        {
            var emptyNamespaces = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });
            var serializer = new XmlSerializer(_companies.GetType());
            var setting = new XmlWriterSettings() { Indent = true, OmitXmlDeclaration = true };
            using (var stream = new StringWriter())
            using (var writer = XmlWriter.Create(stream, setting))
            {
                serializer.Serialize(writer, _companies, emptyNamespaces);
                return stream.ToString();
            }
        }
    }
}
