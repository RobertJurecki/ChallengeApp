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
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public void AddGrade(double grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public void AddGrade(int grade)
        {
            float gradeAsFloat = grade;
            this.AddGrade(gradeAsFloat);
        }

        public Statistics GetStatisticWithForEach()
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
        public Statistics GetStatisticWithFor()
        {
            var statistic = new Statistics();
            statistic.Average = 0;
            statistic.Max = float.MinValue;
            statistic.Min = float.MaxValue;

            for (var i = 0; i < this.grades.Count; i++)
            {
                statistic.Max = Math.Max(statistic.Max, grades[i]);
                statistic.Min = Math.Min(statistic.Min, grades[i]);
                statistic.Average += grades[i];
            }

            statistic.Average /= this.grades.Count;
            return statistic;
        }
        public Statistics GetStatisticWithDoWhile()
        {
            var statistic = new Statistics();
            statistic.Average = 0;
            statistic.Max = float.MinValue;
            statistic.Min = float.MaxValue;

            var i = 0;
            do
            {
                statistic.Max = Math.Max(statistic.Max, grades[i]);
                statistic.Min = Math.Min(statistic.Min, grades[i]);
                statistic.Average += grades[i];
                i++;
            }
            while (i < this.grades.Count);
            statistic.Average /= this.grades.Count;
            return statistic;
        }
        public Statistics GetStatisticWithWhile()
        {
            var statistic = new Statistics();
            statistic.Average = 0;
            statistic.Max = float.MinValue;
            statistic.Min = float.MaxValue;

            var i = 0;

            while (i < this.grades.Count);
            {
                statistic.Max = Math.Max(statistic.Max, grades[i]);
                statistic.Min = Math.Min(statistic.Min, grades[i]);
                statistic.Average += grades[i];
                i++;
            }

            statistic.Average /= this.grades.Count;
            return statistic;
        }
    }
}