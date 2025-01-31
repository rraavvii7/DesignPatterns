
using System.Xml;
using DesignPatterns.Structural.AdapterDesignPattern.Adaptee;
using DesignPatterns.Structural.AdapterDesignPattern.Target;
using Newtonsoft.Json;

namespace DesignPatterns.Structural.AdapterDesignPattern.Adaptor
{
    public class CompanyAdaptor : CompanyManager, ICompany
    {
        public override string GetAllCompanies()
        {
            var xmlCompanies =  base.GetAllCompanies();
            var xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(xmlCompanies);
            var jsonCompanies = JsonConvert.SerializeObject(xmlDocument, Newtonsoft.Json.Formatting.Indented);
            return jsonCompanies;
        }
    }
}
