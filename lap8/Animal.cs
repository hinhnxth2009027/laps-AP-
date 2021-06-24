using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace lap8
{
    public abstract class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Dob { get; set; }

        public override string ToString()
        {
            return $"Animal information id : {Id} name : {Name} dob : {Dob}";
        }
        public abstract void speak();
    }

    public class Dog : Animal
    {
        public override void speak()
        {
            Console.WriteLine("gaau gaau !!!");
        }
    }

    public class Cat : Animal
    {
        public override void speak()
        {
            Console.WriteLine("mew~ mew~ !!!");
        }
    }

    public class AnimalGeneric<T> where T:Animal
    {
        private List<T> Animals = new List<T>();

        public void Add(T obj)
        {
            Animals.Add(obj);    
        }
        
        
        
        public void Remove(int i)
        {
            Animals.RemoveAt(i);    
        }



        public void ShowInformation()
        {
            foreach (var animal in Animals)
            {
                Console.WriteLine(animal.ToString());
                animal.speak();
            }
        }
        
        
    }
}