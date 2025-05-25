using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02._1
{
    // Class Mangager se ke thua class Employee
    public class Manager : Employee, IWork, IPayable
    {
        // (Abstract) class:
        // Is a: Manager "is a" Employee

        // Interface:
        // Can do: Manager "can do" work, Manager "can do" pay
        public string Email { get; set; }

        // Lop con se co tat ca thuoc tinh, phuong thuc cua lop cha
        public Manager() 
        { 
        }

        // base: Dung de chi lop cha(lop co so), giong super ben Java
        public Manager(int id, string name) : base(id, name)
        {
        }

        public Manager(int id, string name, string address, int age) : base(id, name, address, age)
        {
        }

        public Manager(int id, string name, string address, int age, string email) : base(id, name, address, age)
        {
            Email = email;
        }

        public override string ToString()
        => $"Id: {Id} - Name: {Name} - Address: {Address} - Age: {Age}"
            + $"- Email: {Email}";

        public void Pay()
        {
            throw new NotImplementedException();
        }
    }
}
