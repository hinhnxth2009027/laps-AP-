using System;

namespace lap5Ex2
{
    public class TeacherFptApTech:SeniorLecture
    {
        public override double CalculateSalary()
        {
            var salary = 29999 + Experience * 4999;
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