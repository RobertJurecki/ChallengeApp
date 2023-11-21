namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void TestMin()
        {
            // arrange
            var employee = new Employee("Hans", "Klos");
            employee.AddGrade(1);
            employee.AddGrade(3);
            employee.AddGrade(8);


            // act
            var statistics = employee.GetStatistic();

            // assert
            Assert.AreEqual(1, statistics.Min);
        }
        [Test]
        public void TestMax()
        {
            // arrange
            var employee = new Employee("Hans", "Klos");
            employee.AddGrade(1);
            employee.AddGrade(3);
            employee.AddGrade(8);

            // act
            var statistics = employee.GetStatistic();

            // assert
            Assert.AreEqual(8, statistics.Max);
        }
        [Test]
        public void TestAverage()
        {
            // arrange
            var employee = new Employee("Hans", "Klos");
            employee.AddGrade(1);
            employee.AddGrade(3);
            employee.AddGrade(8);

            // act
            var statistics = employee.GetStatistic();

            // assert
            Assert.AreEqual(4, statistics.Average);
        }
    }
}