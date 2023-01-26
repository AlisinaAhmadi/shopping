using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;


namespace test_selenumtes
{


    [TestClass]
    public class UnitTest1

    {

        private static string _location { get; set; } = "../webDriver";
        private static string _url = "http://http://127.0.0.1:5500//";
        private static shoppingDriver _driver = new shoppingDriver(_location);
        private static WebDriverWait _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
        private object shoppingId;

        [TestMethod]
        public void GetAllTest()
        {
            _driver.Navigate().GoToUrl(_url);

            var actual = _wait.Until(d => d.FindElement(By.XPath("//*[@id=\"app\"]/table/tbody/tr[2]/td[2]")));
            Assert.AreEqual("name", actual.Text);

            Thread.Sleep(5000);

            //_driver.Close();

        }
        [TestMethod]
        public void DeleteTest()
        {
            _driver.Navigate().GoToUrl(_url);
            Thread.Sleep(5000);

            var deleteButton = _driver.FindElement(By.XPath("//*[@id=\"app\"]/table/tbody/tr[2]/td[5]/button"));
            deleteButton.Click();

            var webcamId = _driver.FindElement(By.XPath("//*[@id=\"app\"]/table/tbody/tr[2]/td[1]"));
            Assert.AreEqual("2", shoppingId.ToString);

            Thread.Sleep(5000);

        }
    }
}