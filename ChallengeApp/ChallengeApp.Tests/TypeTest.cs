

namespace ChallengeApp.Tests
{
    public class TypeTest
    {
        [Test]
        public void GdyMamyTypReferencyjnyToPorownanieZmiennychMusiBycIncorrect()
        {
            // arrange
            var user1 = GetUser("Adam", "123" );
            var user2 = GetUser("Adam", "123");
            // act
            //tu nic nie bedzie 
            //assert
            Assert.AreEqual(user1, user2);
        }
        private User GetUser(string name, string pass) 
        {
            return new User(name, pass);
            
        }
        [Test]
        public void GdyMamyTypWartosciowyIntegerToPorownanieRoznychLiczbMusiBycIncorrectResult()
        {
            // arrange
            int number1 = 1;
            var number2 = 2;
            // act
            //tu nic nie bedzie 
            //assert
            Assert.AreEqual(number1, number2);
        }
        [Test]
        public void GdyMamyTypWartosciowyDoubleToPorownanieRownychSobieLiczbMusiBycCorrectResult()
        {
            // arrange
            double dnumber1 = 1.2345;
            double  dnumber2 = 1.2345;
            // act
            //tu nic nie bedzie 
            //assert
            Assert.AreEqual(dnumber1, dnumber2);
        }
        [Test]
        public void GdyMamyTypStringHybrydowyToPorownanieRownychSobieLiczbMusiBycCorrectResult()
        {
            // arrange
            var user1 = GetUser("Adam", "123");
            var user2 = GetUser("Adam", "1234");
            // act
            //tu nic nie bedzie 
            //assert
            Assert.AreEqual(user1.Login, user2.Login);
        }
    }
}
