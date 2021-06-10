using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml;

namespace lap3.Exercise1
{
    public class Exercise1Menu
    {
        private List<Atom> _atoms = new List<Atom>();
        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine(".1 để thêm mới");
                Console.WriteLine(".2 để hiển thị");
                Console.WriteLine(".0 để thoát chương trình");
                var choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    default:
                        Console.WriteLine("vui lòng chọn từ 0 - 2");
                        break;
                    case 1:
                        CreateAtom();
                        break;
                    case 2:
                        Display();
                        break;
                    case 0:
                        Console.WriteLine("Bye bye");
                        break;
                }

                if (choice == 0)
                {
                    break;
                }
            }
        }

        public void CreateAtom()
        {
            Console.WriteLine("Nhập vào Atom Number :");
            var AtomicNumber = int.Parse(Console.ReadLine());
            if (AtomicNumber > 0)
            {
                Console.WriteLine("Nhập vào Atom Symbol :");
                var AtomicSymbol = Console.ReadLine();
                Console.WriteLine("Nhập vào Atom Fullname :");
                var AtomicFullname = Console.ReadLine();
                Console.WriteLine("Nhập vào Atom Weight :");
                var AtomicWeight = float.Parse(Console.ReadLine());
                if (_atoms.Count > 10)
                {
                    Console.WriteLine("Bạn chỉ có thể tạo tối đa 10 nguyên tử");
                }
                else
                {
                    _atoms.Add(new Atom()
                    {
                        AtomicNumber = AtomicNumber,
                        AtomicFullname = AtomicFullname,
                        AtomicSymbol = AtomicSymbol,
                        AtomicWeight = AtomicWeight
                    });
                }    
            }
            else
            {
                Console.WriteLine("No Sym Name Weight");
            }
            
        }

        

        public void Display()
        {
            foreach (var atom in _atoms)
            {
                Console.WriteLine($"||==============================================================||");
                atom.ToString();
            }
            Console.WriteLine($"||==============================================================||");
        }
    }
}