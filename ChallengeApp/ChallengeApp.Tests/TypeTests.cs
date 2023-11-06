namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void ComperingTwoIntReturnDiferent()
        {
            // arrange
            int number1 = 1;
            int number2 = 2;

            // act

            // assert
            Assert.AreNotEqual(number1, number2);

        }
        [Test]
        public void ComperingTwoString()
        {
            // arrange
            string name1 = "Janek";
            string name2 = "Janek";

            // act

            // assert
            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void GetUserShouldReturnDiferent()
        {
            // arrange
            var user1 = GetUser("Adam");
            var user2 = GetUser("Adam");

            // act

            // assert
            Assert.AreNotEqual(user1, user2);
        }

        private User GetUser(string name)
        {
            return new User(name);
        }
    }
}