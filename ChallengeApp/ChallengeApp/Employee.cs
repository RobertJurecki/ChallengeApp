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
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid grade value");
            }    
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
               this.AddGrade(result);
            }
            else
            {
                Console.WriteLine("String in not float");
            }
        }

        public void AddGrade(long grade)
        {
            var value = (float)grade;
            this.AddGrade(value);
        }

        public void AddGrade(double grade)
        {
            var value = (float)grade;
            this.AddGrade(value);
        }

        public void AddGrade(int grade)
        {
            var value = grade;
            this.AddGrade(value);
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
