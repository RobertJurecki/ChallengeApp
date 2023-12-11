namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        public EmployeeInMemory(string name, string surname)
            : base(name, surname)
        {
        }

        public override void AddGrade(float grade)
        {
            throw new NotImplementedException();
        }

        public override void AddGrade(double grade)
        {
            float result = (float)grade;
            this.AddGrade(result);
        }

        public override void AddGrade(int grade)
        {
            float result = grade;
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

        public override void AddGrade(long grade)
        {
            float result = grade;
            this.AddGrade(result);
        }

        public override Statistics GetStatistic()
        {
            throw new NotImplementedException();
        }
    }
}
