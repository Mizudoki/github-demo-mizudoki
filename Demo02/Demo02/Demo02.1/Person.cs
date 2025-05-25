using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02._1
{
    // Truu tuong Abstraction
    // abstract: Class co tu khoa nay se khong the khoi tao (khong the new() duoc)
    // tuc la khong the tao instance(mot the hien) cua lop do
    public abstract class Person
    {
        public string PID { get; set; } // So CCCD
        // abstract: Khong the viet than ham
        // bat buoc lop con ke thua no phai tu viet
        public abstract void Speak(); // Chi khai bao, khong viet noi dung
        // virtual: Bat buoc phai viet than ham
        // Lop con khong bat buoc phai viet lai
        // tu khoa virtual de biet la ham nay co the duoc viet lai (override)
        public virtual void Work()
        {
            Console.WriteLine("Person is speaking ...");
        }
    }
}
