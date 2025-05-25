namespace Demo02._1
{
    internal class Program
    {
        // in : thay doi bien thanh kieu readonly, khong cho phep thay doi gia tri
        //static void DoSomeThing(in int n)
        //{
        //    //n = 100;  // khong duoc phep
        //    int a = n; // ok
        //    Console.WriteLine("Trong ham, n = " + n);
        //}

        // out : thay doi bien thanh kieu tham chieu, cho phep thay doi gia tri
        // out: bat buoc phai thay doi gia gia tri cua bien(phai gan gia tri cho bien)
        //static void DoSomeThingOut(out int n)
        //{
        //    n = 100; // bat buoc
        //    Console.WriteLine("Trong ham, n = " + n);
        //}

        // ref: thay doi bien thanh kieu tham chieu
        // ref: khong bat buoc phai gan gia tri cho bien
        // nen bat buoc bien phai co gia tri khi vao ham
        //static void DoSomeThingRef(ref int m)
        //{
        //    //m = 100; // khong bat buoc
        //    Console.WriteLine("Trong ham, m = " + m);
        //}

        //static void Main(string[] args)
        //{
        //    //int n = 10; // khong bat buoc phai khoi tao gia tri cho bien
        //    //int n; // khai bao bien khong khoi tao gia tri moi khong bi loi, neu khai bao trong inline thi khoi can dong nay nua
        //    //DoSomeThingOut(out int n); // out: ho tro khai bao inline
        //    //Console.WriteLine("Ngoai ham, n = " + n);

        //    //int m; // khong duoc
        //    int m = 10; // bat buoc phai khoi tao gia tri cho bien
        //    DoSomeThingRef(ref m);
        //    Console.WriteLine("Ngoai ham, m = " + m);
        //}

        // params: Gom nhom nhung bien co cung kieu du lieu de dua vao mang
        //static int Sum(params int[] a) // javascript: rest parameter ...
        //{
        //    int sum = 0;
        //    for (int i = 0; i < a.Length; i++)
        //    {
        //        sum += a[i];
        //    }
        //    return sum;
        //}

        //static void Main(string[] args)
        //{
        //    int[] a = { 1, -1, 2, -2, 3, -4, 2 };
        //    Console.WriteLine(Sum(a));
        //    Console.WriteLine(Sum(1, 2, 3, 4, 5));
        //}


        // 1. viet ham tinh ca min va max cua mang so nguyen
        // yeu cau: su dung out hoac ref
        // static void MinAndMax(int[] a, out min, out max)


        // 2. viet ham tinh tong cac so nguyen to trong mang
        // yeu cau: su dung params
        // static int SumPrime(params int[] a)

        //static void MinAndMax(int[] a, out int min, out int max)
        //{
        //    min = a[0];
        //    max = a[0];
        //    for (int i = 0; i < a.Length; i++)
        //    {
        //        int temp = a[i];
        //        if (temp >= max)
        //        {
        //            max = temp; // alt + mui ten len xuong de chuyen code len xuong
        //        }
        //        else if (temp <= min)
        //        {
        //            min = temp;
        //        }
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    int[] a = { 1, -1, 2, -2, 3, -4, 2 };
        //    MinAndMax(a, out int min, out int max);
        //    Console.WriteLine($"Min = {min} Max = {max}");
        //}

        //static void Main(string[] args)
        //{
        //    //Employee e1 = new Employee();
        //    //e1.Id = 1;
        //    //e1.Name = "Nguyen Van A";
        //    Employee e1 = new Employee(1, "AN", "HCM", 21); // overload
        //    Employee e2 = new Employee(2, "KHANG", "HCM", 21); // overload
        //    Employee e3 = new Employee(3, "CANH", "HCM", 21); // overload
        //    Employee e4 = new Employee(4, "DUONG", "HCM", 21); // overload
        //    Employee e5 = new Employee(5, "CUONG", "HCM", 21); // overload
        //    Employee e6 = new Employee(6, "BUOI", "HCM", 21); // overload
        //    //Console.WriteLine(e1.ToString());
        //    //Console.WriteLine(e2); // mac dinh goi ham tostring()
        //    //Console.WriteLine(e3); // mac dinh goi ham tostring()
        //    //Console.WriteLine(e4); // mac dinh goi ham tostring()
        //    //Console.WriteLine(e5); // mac dinh goi ham tostring()
        //    //Console.WriteLine(e6); // mac dinh goi ham tostring()

        //    int[] a = { 1, -1, 2, -2, 3, -4, 2 };
        //    //for (int i = 0; i < a.Length; i++)
        //    //{
        //    //    Console.Write(a[i]);
        //    //}
        //    Console.WriteLine(string.Join('\n', a));
        //    string name = "Nguyen Van A";
        //    var b = name.Split(' ');
        //}

        static void Main(string[] args)
        {
            Manager m1 = new Manager();
            m1.Id = 1;
            m1.Name = "Thuy Tien";
            m1.Address = "Vong lao ly";
            m1.Age = 21;
            Manager m2 = new Manager()
            {
                Id = 2,
                Name = "Quang Linh",
                Address = "Phong ke ben",
                Age = 22
            };
            Manager m3 = new Manager(3, "Hang Du Muc", "Ke ben 2 phong kia", 23, "kera@chiemrot.com");
            Console.WriteLine(m3);
            //Person per1 = new Person(); // khong duoc
            Employee e1 = new Employee(1, "An", "HCM", 21);
            e1.PID = "123456789";

            e1.Speak();
            Developer d1 = new Developer();
            d1.Speak();
        }

    }
}
