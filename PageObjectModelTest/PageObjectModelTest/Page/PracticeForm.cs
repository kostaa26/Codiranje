
using OpenQA.Selenium;

namespace PageObjectModelTest.Page
{
    public class PracticeForm
    {
        private IWebDriver driver = WebDriver.Driver.Instance;

        public IWebElement FirstName => driver.FindElement(By.Id("firstName"));

        public IWebElement LastName => driver.FindElement(By.Id("lastName"));

        public IWebElement Email => driver.FindElement(By.Id("userEmail"));

        public IWebElement Gender => driver.FindElement(By.Id("gender-radio-1"));

        public IWebElement Phone => driver.FindElement(By.Id("userNumber"));

        public IWebElement Subject => driver.FindElement(By.Id("subjectsContainer"));

        public IWebElement Hobiis => driver.FindElement(By.Id("hobbies-checkbox-1"));

        public IWebElement Button => driver.FindElement(By.Id("submit"));

        public void EnterName(string name)
        {
            FirstName.SendKeys(name);
        }
        public void EnterLastName(string name)
        {
            LastName.SendKeys(name);
        }
        public void EnterEmail(string name)
        {
            Email.SendKeys(name);
        }
        public void SelectGender()
        {
            Gender.Click();
        }
        public void EnterPhone(string number)
        {
            Phone.SendKeys(number);
        }
        public void EnterSubject(string name)
        {
            Subject.Click();
            Subject.SendKeys(name);

        }
        public void SelectHobiis()
        {
            Hobiis.Click();
        }
        public void SelectButton()
        {
            Button.Click();
        }

        internal void EnterFirstName(string v)
        {
            throw new NotImplementedException();
        }
    }
}
