using System;
using System.Security.Permissions;

namespace lap3.Exercise1
{
    public class Atom
    {
        public int AtomicNumber { get; set; }
        public string AtomicSymbol { get; set; }
        public string AtomicFullname { get; set; }
        public double AtomicWeight { get; set; }

        public void ToString()
        {
            Console.WriteLine($"||\t {AtomicNumber} \t||\t {AtomicSymbol} \t||\t {AtomicFullname} \t||\t {AtomicWeight} \t||");
        }
    }
}