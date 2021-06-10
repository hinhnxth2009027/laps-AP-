using System;
using System.Collections.Generic;

namespace lap3.Exercise2
{
    public class Exercise2Menu
    {
        private List<Employee> _employees = new List<Employee>();
        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("Chọn 1 để thêm mới nhân viên");
                Console.WriteLine("Chọn 2 để xem danh sách nhân viên");
                Console.WriteLine("Chọn 3 để tính tiền thưởng của nhân viên");
                Console.WriteLine("Chọn 0 để thoát");
                var choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    default:
                        Console.WriteLine("vui lòng nhập từ 0 - 3");
                        break;
                    case 1:
                        CreateEmployee();
                        break
                        ;
                    case 2:
                        DisplayList();
                        Console.WriteLine("\n");
                        break
                            ;
                    case 3:
                        SetBonus();
                        break
                            ;
                    case 0:
                        Console.WriteLine("Bye bye");
                        break
                            ;
                }
                if (choice == 0)
                {
                    break;
                }
            }
        }

        public void CreateEmployee()
        {
            Console.WriteLine("vui lòng nhập FirstName");
            var FirstName = Console.ReadLine();
            Console.WriteLine("vui lòng nhập LastName");
            var LastName = Console.ReadLine();
            Console.WriteLine("vui lòng nhập Address");
            var Address = Console.ReadLine();
            Console.WriteLine("vui lòng nhập Sin");
            var Sin = long.Parse(Console.ReadLine());
            Console.WriteLine("vui lòng nhập Salary");
            var Salary = double.Parse(Console.ReadLine());
            var _employee = new Employee(FirstName , LastName,Address,Sin,Salary);
            _employees.Add(_employee);
            Console.WriteLine("Thêm mới thành công\n");
        }

        public void DisplayList()
        {
            Console.WriteLine("============================================================================");
            int a = 0;
            foreach (var employee in _employees)
            {
                a++;
                Console.WriteLine($"|| {a} || \t "+employee.ToString());
            }

            Console.WriteLine("============================================================================");
        }



        public void SetBonus()
        {
            DisplayList();
            Console.WriteLine($"chọn theo số thứ tự từ 1 - > {_employees.Count}");
            int choice = int.Parse(Console.ReadLine());
            if (choice <= 0 || choice >_employees.Count)
            {
                Console.WriteLine($"Vui lòng chọn trong khoảng từ 1 - > {_employees.Count}\n");
            }
            else
            {
                var employee = _employees[choice-1];
                Console.WriteLine($"Vui lòng nhập % thưởng của nhân viên {employee.FirstName} {employee.LastName}");
                double percentage = double.Parse(Console.ReadLine());
                Console.WriteLine($"Tiền thưởng của {employee.FirstName} {employee.LastName} là : {percentage*employee.Salary}");
            }
        }
        
    }
}