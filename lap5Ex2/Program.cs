namespace lap5Ex2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var teacherFptApTech = new TeacherFptApTech()
            {
                PersonName = "LKH",
                IsSeniorLecturer = true,
                Experience = 7,
            };
            teacherFptApTech.CalculateSalary();
        }
    }
}