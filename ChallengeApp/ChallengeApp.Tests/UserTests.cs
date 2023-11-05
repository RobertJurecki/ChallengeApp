namespace ChallengeApp.Tests
{
    public class Tests
    {   
        [Test]
        public void WhenUserCollectPositiveScores_ShouldCorrectResult()
        { 
            // arrange
            var user = new User("Hans", "qwert123");
            user.AddScore(5);
            user.AddScore(6);
            user.AddScore(4);
            user.AddScore(2);
            user.AddScore(3);

            // act
            var result = user.Result;

            // assert
            Assert.AreEqual(20, result);
        }
        [Test]
        public void WhenUserCollectNegativeScores_ShouldCorrectResult()
        {
            // arrange
            var user = new User("Janek", "asdf567");
            user.AddScore(3);
            user.AddScore(4);
            user.AddScore(-4);
            user.AddScore(-2);
            user.AddScore(3);

            // act
            var result = user.Result;

            // assert
            Assert.AreEqual(4, result);
        }
    }
}