namespace ChallangeApp
{
    public class Employee
    {
        private int age;
        private List<int> pointsEmployee = new List<int>();

        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.age = age;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public int Points
        {
            get
            {
                return this.pointsEmployee.Sum();
            }
        }


        public void AddPoints(int number)
        {
            this.pointsEmployee.Add(number);
        }
    }
}
