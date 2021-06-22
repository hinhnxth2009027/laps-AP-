namespace lap7
{
    public class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }
        public override string ToString()
        {
            return $"Name : {Name} \t Age : {Age} \t Salaray : {Salary} ";
        }
    }
}