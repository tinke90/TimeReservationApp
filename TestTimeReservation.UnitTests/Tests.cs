using System;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TimeReservationApp;

namespace TestTimeReservation.UnitTests {

    [TestClass]
    public class TranslateTests
    {

        [TestMethod]
        public void Translate_FINNISH_ReturnTrue()
        {

            Translate.ApplicationLanguage = "FINNISH";

            string word = "Sulje";

            var result = Translate.Language(word);

            Assert.IsTrue(result.Equals("Sulje"));
        
        }

        [TestMethod]
        public void TranslateWord_ENGLISH_ReturnTrue()
        {

            Translate.ApplicationLanguage = "ENGLISH";

            string word = "Sulje";

            var result = Translate.Language(word);

            Assert.IsTrue(result.Equals("Close"));
        
        }

        [TestMethod]
        public void ChangeLangauge_FINNISH_ReturnTrue()
        {

            Translate.ApplicationLanguage = "FINNISH";

            var result = Translate.ApplicationLanguage;

            Assert.IsTrue(result.Equals("FINNISH"));
        
        }


        [TestMethod]
        public void ChangeLangauge_ENGLISH_ReturnTrue()
        {

            Translate.ApplicationLanguage = "ENGLISH";

            var result = Translate.ApplicationLanguage;

            Assert.IsTrue(result.Equals("ENGLISH"));

        }

    }

    [TestClass]
    public class n_TimeTests
    {

        [TestMethod]
        public void CurrentDate_ReturnTrue()
        {

            var currentDate = n_Time.GetCurrentDate;

            Assert.IsTrue(DateTime.Now.ToString().Contains(currentDate));

        }

        [TestMethod]
        public void CurrentTime_ReturnTrue()
        {

            var currentTime = n_Time.GetCurrentDate;

            Assert.IsTrue(DateTime.Now.ToString().Contains(currentTime));

        }

    }


    [TestClass]
    public class LoginControllerTest
    {


        [TestMethod]
        public void UserDetailsDoNotMatch_ReturnFalse()
        {

            string[] passwords = { "Asdf", "aSdf", "asDf", "asdF", "ASDF", "AsdF", "aSDf", "aSDF", "ASDf" };

            foreach(string pwd in passwords) {

                var result = Check.ConfirmLogin("tinke", pwd);

                Assert.IsFalse(result);

            }

        }

        [TestMethod]
        public void UserDetailsMatch_ReturnTrue()
        {

            var result = Check.ConfirmLogin("tinke","asdf");

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void Create_NewUser_ReturnTrue()
        {

            /*SQLite.UpdateData("INSERT INTO Profile ('USERNAME','PASSWORD', 'EMAIL', 'PHONE', 'LAST_ACTIVE'," +
                "'FIRSTNAME', 'LASTNAME', 'BIRTHDATE') VALUES ('tinke', 'test123', '-', '-', 'True', '-', '-', '-' )");
            */

            var profiles = SQLite.FetchData("SELECT * FROM Profile");

            Assert.IsTrue(profiles.Count > 0);

        }

    }


    [TestClass]
    public class Tests 
    {

        [TestMethod]
        public void AnyCharacters_Exists_ReturnFalse()
        {
            string[] nums = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };

            foreach(string num in nums) {

                var result = Check.IfContainsChars(num);

                Assert.IsFalse(result);

            }
        }



        [TestMethod]
        public void AllCharacters_Exists_ReturnTrue()
        {

            string[] chars = {"A", "B", "C", "D", "E", "F", "G", "H", "I",
            "J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z","Å","Ä","Ö"};

            foreach(string ch in chars) {
            
                var result = Check.IfContainsChars(ch);

                Assert.IsTrue(result);

            }
        }



        [TestMethod]
        public void IfEmptyOrNull_TextIsEmpty_ReturnTrue() 
        {

            TextBox text = new TextBox();
            text.Text = "";

            TextBox[] texts = { text };
            var text_is_empty = Check.IfEmptyOrNull(texts);


            Assert.IsTrue(text_is_empty);

        }



        [TestMethod]
        public void IfEmptyOrNull_TextIsNotEmpty_ReturnFalse()
        {

            TextBox text, text2, text3;
            text = new TextBox();
            text2 = new TextBox();
            text3 = new TextBox();

            text.Text = "asdf";
            text2.Text = "asdf";
            text3.Text = "asdf";

            TextBox[] texts = { text, text2, text3};
            var text_is_not_empty = Check.IfEmptyOrNull(texts);


            Assert.IsFalse(text_is_not_empty);

        }
    }
}
