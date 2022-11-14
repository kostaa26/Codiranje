using NUnit.Framework;
using PageObjectModelTest.Helper;
using PageObjectModelTest.Page;

namespace PageObjectModelTest
{
    public class Tests:Base
    {
        PracticeForm form;
        

        [Test]
        public void Test1()
        {
            form = new PracticeForm();
            form.EnterFirstName("Kosta");
            form.EnterLastName("Blagojevic");
            form.EnterEmail("nemammejl@.com");
            form.SelectGender();
            form.EnterPhone("1957436857");
            form.EnterSubject("Math");
            form.SelectHobiis();
            form.SelectButton();
            
        }
    }
}