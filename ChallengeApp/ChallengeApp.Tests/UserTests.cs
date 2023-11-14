using System.Reflection.Metadata;

namespace ChallengeApp.Tests
{
    public class UserTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void WhenUserCollectTwoSetOfPoints_ShouldCorrectSumAsResult()
        {
            // arrange
            var user = new User("Adam", "adad123");
            user.AddScore(5);
            user.AddScore(6);

            // act
            var result = user.Result;

            //assert

            Assert.AreEqual(11, result);
        }
        [Test]
        public void WhenUserCollectTwoSetOfPoints_ShouldCorrectSumAsResult1()
        {
            // arrange
            var user = new User("Adam", "adad123");
            user.AddScore(5);
            user.AddScore(2);

            // act
            var result = user.Result;

            //assert

            Assert.AreEqual(7, result);
        }
        [Test]
        public void WhenUserCollectWithUemnyPunktSetOfPoints_ShouldNotCorrectSumAsResult__()
        {
            // arrange
            var user = new User("Adam", "adad123");
            user.AddScore(5);
            user.AddScore(-6);

            // act
            var result = user.Result;

            //assert

            Assert.AreEqual(-1, result);
        }
    }

}