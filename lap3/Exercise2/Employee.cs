namespace lap3.Exercise2
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public long Sin { get; set; }
        public double Salary { get; set; }


        public Employee(string firstName, string lastName, string address, long sin, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Sin = sin;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Name : {this.FirstName} {this.LastName} \t Address : {this.Address} \t Sin : {this.Sin} \t Salary : {this.Salary} \t ";
        }
    }
}