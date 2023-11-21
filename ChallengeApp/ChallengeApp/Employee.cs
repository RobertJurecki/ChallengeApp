namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surame)
        {
            this.Name = name;
            this.Surame = surame;
        }

        public string Name { get; private set; }

        public string Surame { get; private set; }

        public void AddGrade(float grade)
        {
            this.grades.Add(grade);
        }
        public Statistics GetStatistic()
        {
            var statistic = new Statistics();
            statistic.Average = 0;
            statistic.Max = float.MinValue;
            statistic.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistic.Max = Math.Max(statistic.Max, grade);
                statistic.Min = Math.Min(statistic.Min, grade);
                statistic.Average += grade;
            }

            statistic.Average /= this.grades.Count;



            return statistic;
        }
    }
}
