using Demo02._1;

namespace Demo02._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericClass<int> intClass = new GenericClass<int>();
            intClass.Value = 1;
            Console.WriteLine(intClass.GetValue());
            intClass.Print("Hello");

            GenericClass<double> doubleClass = new GenericClass<double>();
            doubleClass.Value = 1.1;

            //GenericClass<string> stringClass = new GenericClass<string>();
            //stringClass.Value = "Chi em rot";

            dynamic a = new { Name = "Thuy Tien", Address = "Vong lao ly" };
            GenericClass<object> objectClass = new GenericClass<object>();
            objectClass.Value = a;

            Employee e = new Employee();
            GenericClass<Employee> employeeClass = new GenericClass<Employee>();
            employeeClass.Value = e;

            Console.WriteLine("Love you pac pac");
            Console.WriteLine("Love Love Love");
        }
    }
}
