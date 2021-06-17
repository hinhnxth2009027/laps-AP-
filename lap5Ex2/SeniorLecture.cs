namespace lap5Ex2
{
    public abstract class SeniorLecture
    {
        public string PersonName { get; set; }
        public bool IsSeniorLecturer { get; set; }
        public int Experience { get; set; }

        public abstract double CalculateSalary();
        public abstract double CalculateBonus();
    }
}