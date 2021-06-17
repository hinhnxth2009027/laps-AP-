namespace lap5Ex2
{
    public class UniversityTeacher:SeniorLecture
    {
        public int EnglishSkill { get; set; }
        public override double CalculateSalary()
        {
            var salary = 49999 + Experience * 4999 + EnglishSkill * 1000;
            if (IsSeniorLecturer && salary < 60000)
            {
                throw new AmountException("giang vien cao cap phari co muc luong tu 60000", PersonName);
            }
            return salary;
        }

        public override double CalculateBonus()
        {
            var bonus = 4999 + Experience * 1999;
            if (bonus > 10000)
            {
                throw new AmountException("tien thuong khong duoc qua 10000", PersonName);
            }
            return bonus;
        }
    }
}