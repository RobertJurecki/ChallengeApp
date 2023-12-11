namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string filename = "grades.txt";

        public EmployeeInFile(string name, string surname)
            : base(name, surname)
        {

        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(filename))
                {
                    writer.WriteLine(grade);
                }
            }
            else
            {
                throw new Exception("invalid grade value");
            }
        }
        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else if (char.TryParse(grade, out char resultChar))
            {
                AddGrade(resultChar);
            }
            else
            {
                throw new Exception("String in not float");
            }

        }

        public override void AddGrade(int grade)
        {
            float result = grade;
            this.AddGrade(result);
        }
        public override void AddGrade(long grade)
        {
            float result = grade;
            this.AddGrade(result);
        }
        public override void AddGrade(double grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }

        public override void AddGrade(char grade)
        {
            if (char.IsDigit(grade))
            {
                float result = (float)(grade - '0');
                this.AddGrade(result);
            }
            switch (grade)
            {
                case 'A':
                case 'a':
                    AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    AddGrade(20);
                    break;
                default:
                    throw new Exception("Niedopuszczalna litera");
            }
        }

        public override Statistics GetStatistic()
        {
            var gradesFromFile = this.ReadGradesFromFile();
            var result = this.CountStatistic(gradesFromFile);
            return result;
        }

        private List<float> ReadGradesFromFile()
    {
        var grades = new List<float>();
        if (File.Exists($"{filename}"))
        {
            using (var reader = File.OpenText($"{filename}"))
            {
                var line = reader.ReadLine();
                while (line != null)
                {
                    var number = float.Parse(line);
                    grades.Add(number);
                    line = reader.ReadLine();
                }
            }
        }
        return grades;
    }
        private Statistics CountStatistic(List<float> grades)
        {
            var statistic = new Statistics();
            statistic.Average = 0;
            statistic.Max = float.MinValue;
            statistic.Min = float.MaxValue;

            foreach (var grade in grades)
            {
                if (grade >= 0)
                {
                    statistic.Max = Math.Max(statistic.Max, grade);
                    statistic.Min = Math.Min(statistic.Min, grade);
                    statistic.Average += grade;
                }
            }
            statistic.Average /= grades.Count;

            switch (statistic.Average)
            {
                case var average when average >= 80:
                    statistic.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistic.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistic.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistic.AverageLetter = 'D';
                    break;
                default:
                    statistic.AverageLetter = 'E';
                    break;
            }

            return statistic;
        }
    }
}
