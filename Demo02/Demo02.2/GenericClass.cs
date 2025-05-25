using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02._2
{
    // Generic: Tong quat, chung chung...
    // Generic Class: Mot class voi kieu du lieu tong quat
    // Cach dung: them <T> dang sau, T: Type

    // Constraint: Rang buoc
    // Cach dung: Them where T: {Dieu kien rang buoc} vao sau <T>
    // where T : struct
    // Bat buoc T la kieu so (Tham tri)
    // where T : class
    // Bat buoc T la kieu tham chieu (Reference type)
    // where T : new()
    // Bat buoc T phai co constructor khong tham so (Rong, Mac Dinh)
    public class GenericClass<T> where T : new()
    {
        public T Value { get; set; }
        public T GetValue() 
        { 
            return Value; 
        }
        // Theo bang chu cai: T U V W X Y Z
        // Generic method
        public T Print<U>(U note)
        {
            Console.WriteLine(note);
            return Value;
        }
    }
}
