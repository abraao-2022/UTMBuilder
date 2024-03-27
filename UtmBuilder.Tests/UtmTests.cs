using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtmBuilder.Core;
using UtmBuilder.Core.ValueObjects;

namespace UtmBuilder.Tests
{
    [TestClass]
    public class UtmTests
    {
        private const string Result = "https://balta.io/" +
                                       "?utm_source=src" +
                                       "&utm_medium=med" +
                                       "&utm_campaign=nme" +
                                       "&utm_id=id" +
                                       "&utm_term=term" +
                                       "&utm_content=content";

        private readonly Url _url = new("https://balta.io/");
        private readonly Campaign _campaign = new("src", "med", "nme", "id", "term", "content");

        [TestMethod]
        public void Deve_retornar_uma_url_do_utm()
        {
            var utm = new Utm(_url, _campaign);
            
            Assert.AreEqual(Result, utm.ToString());
        }
        
        [TestMethod]
        public void Deve_retornar_um_utm_da_url()
        {
            Utm utm = Result;
            
            Assert.AreEqual("https://balta.io/", utm.Url.Address);
            Assert.AreEqual("src", utm.Campaign.Source);
            Assert.AreEqual("med", utm.Campaign.Medium);
            Assert.AreEqual("nme", utm.Campaign.Name);
            Assert.AreEqual("id", utm.Campaign.Id);
            Assert.AreEqual("term", utm.Campaign.Term);
            Assert.AreEqual("content", utm.Campaign.Content);
        }
    }
}