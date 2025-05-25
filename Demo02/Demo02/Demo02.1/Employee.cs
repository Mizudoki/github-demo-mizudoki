using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02._1
{
    //OOP
    public class Employee : Person
        // Employee ke thua Person co 1 abstract method la Speak()
        // nen bat buoc phai tu viet lai(override), neu khong se bi loi
    {
        public override void Speak()
        {
            Console.WriteLine("Employee is speaking...");
        }

        public override void Work()
        {
            Console.WriteLine("Employee is working...");
        }

        private int _id; // field
        private string _name; // field


        // automatic property
        // snippet: prop

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        //Constructor
        //Snippet: ctor
        public Employee()
        {

        }

        // Constructor gom 2 tham so id va name
        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Employee(int id, string name, string address, int age)
        {
            Id = id;
            Name = name;
            Address = address;
            Age = age;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Id: {Id} - Name: {Name} - Address: {Address} - Age: {Age}");
        }

        // ToString()
        // Override
        //public override string ToString()
        //{
        //    return $"Id: {Id} - Name: {Name} - Address: {Address} - Age: {Age}";
        //}

        public override string ToString() => $"Id: {Id} - Name: {Name} - Address: {Address} - Age: {Age}"; // expression-bodied
        // lamba expression => cua expression-bodied


        //public int Id // fully property
        //{
        //    get
        //    {
        //        return _id; // property
        //    }
        //    set
        //    {
        //        _id = value; // property
        //    }
        //}
        // snippet: propfull

        //private int _name;

        //public string Name
        //{
        //    get { return _name; }
        //    set { _name = value; }
        //}


        //public int GetId() // method
        //{
        //    return _id;
        //}

        //public void SetId(int id) // method
        //{
        //    _id = id;
        //    //this._id = id; // this: tham chieu toi bien instance
        //}

        //public int GetName() // method
        //{
        //    return _name;
        //}

        //public void SetName(string name) // method
        //{
        //    _name = name;
        //}
    }
}
