﻿using System;
using lap4.entity;
using lap4.entity.SubClassForEmployee;

namespace lap4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var student = new Student()
            {
                Name = "nguyen xuan hjnh",
                PhoneNumber = "0987987789",
                Email = "hjnh@gmail.com",
                Program = "ADSE"
            };
            Console.WriteLine(student.ToString());

            var staff = new Staff
            {
                Name = "nguyen xuan hjnh 2",
                PhoneNumber = "0987987789 2",
                Email = "hjnh@gmail.com 2",
                Title = "nhan vien thu ngan",
                Salary = 800,
                Department = "ke toan",
                DateHired = 4
            };
            Console.WriteLine(staff.ToString());
            Console.WriteLine($"thuong cua {staff.Name} là : {staff.CalculateBonus()}");
            Console.WriteLine($"tuan nghi cua {staff.Name} là : {staff.CalculateVacation()}");
            
            var faculty = new Faculty()
            {
                Name = "hoang dac phuong",
                PhoneNumber = "0987987789",
                Email = "phuong@gmail.com",
                OfficeHours = "7h - 16h30",
                Salary = 700,
                DateHired = 5,
                Rank = 1,
                Department = "to tu nhien"
            };
            Console.WriteLine(faculty.ToString());
            Console.WriteLine($"thuong cua {faculty.Name} là : {faculty.CalculateBonus()}");
            Console.WriteLine($"tuan nghi cua {faculty.Name} là : {faculty.CalculateVacation()}");
        }
    }
}