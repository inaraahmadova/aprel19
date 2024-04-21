
using aprel19.Models;
using System.Text.RegularExpressions;

namespace aprel19
{
    delegate bool NumberDel(int number);
    delegate bool StringDel(string str);
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student=new Student("Inara",false,false);
            Lion lion = new Lion();
            if(student.IsPlagiated || student.IsHelpedToPlagiate)
            {
                lion.Parcalamaq(student);
            }
            else { Console.WriteLine("kocurmeyib ve komek etmeyib"); }



            //Wolf wolf = new Wolf( true, 3);
            //Elephant elephant = new Elephant( 4000, false);

            //wolf.Hunt(elephant);

            //Console.WriteLine("Elephant's HP: " + elephant.HP);

            //Meat meat = new Meat(500,Meat.MeatType.Beef);
            //Grass grass = new Grass("Grass", 50);

            //ZooCage<Wolf, Grass> zooCage = new ZooCage<Wolf, Grass>();
            //zooCage.Animal = wolf;
            //zooCage.Food = grass;

            //Console.WriteLine("Animal: " + zooCage.Animal.GetType().Name);
            //Console.WriteLine("Food: " + zooCage.Food.GetType().Name);


            //ZooCage<Elephant, Meat> zooCage1 = new ZooCage<Elephant, Meat>();
            //zooCage1.Animal = elephant;
            //zooCage1.Food = meat;
            //Console.WriteLine("Animal:" + zooCage1.Animal.GetType().Name);
            //Console.WriteLine("Food: " + zooCage1.Food.GetType().Name);









            //NumberDel func = IsEven;
            //Console.WriteLine(func(5));
            //func += IsPrime;
            //func += IsDivide3;
            //Console.WriteLine(IsEven(4));
            //Console.WriteLine(IsPrime(4));
            //Console.WriteLine(IsDivide3(4));
            // Find("salam", delegate (string str)
            // {
            //     return true;
            // });


            // Group ab106 = new("AB106");
            // Group ab105 = new("AB105");

            // List<Student> students = new();
            // students.Add(new Student("Ibrahim", "Khushmandi", 20, 200, ab106));
            // students.Add(new Student("Garib", "Garibzada", 20, 300, ab106));
            // students.Add(new Student("Shahin", "Alizada", 20, 400, ab105));
            // students.Add(new Student("Nurlan", "Abbasov", 19, 160, ab106));

            // students.FindAll(s => s.Group == ab106)
            // .ForEach(s => Console.WriteLine(s.Id + " " + s.Name));
            //students.FindAll(s => s.Credits > 300)
            //.ForEach(s => Console.WriteLine(s.Id +" "+ s.Name));
            //students.ForEach(s=> Console.WriteLine(s.Name +" "+s.Surname));
            //students.FindAll(s=>s.Name.ToLower().Contains("b"))
            // .ForEach(s=> Console.WriteLine(s.Id +" " + s.Name));
            // foreach(Student s in students.OrderBy(s => s.Credits))
            //     {
            //     Console.WriteLine(s.Id + " " + s.Name);
            // }


        }
        //static void Find(string str,StringDel func)
        //{
        //    if(func (str))
        //    {
        //        Console.WriteLine("Sert odenilir");
        //    }
        //    else { Console.WriteLine("sert odenilmir"); }
        //}
        //static bool HasUpper(string str)
        //{
        //    foreach (var item in str)
        //    {
        //        if (Char.IsUpper(item))
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
        //static bool HasLower(string str)
        //{
        //    foreach (var item in str)
        //    {
        //        if (Char.IsUpper(item))
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        //static bool IsEven(int num) 
        //{ 
        //    return num % 2 == 0;
        //}
        //static bool IsPrime(int num)
        //{
        //    if (IsEven(num)) return false;
        //    for (int i = 3; i < num*num; i+=2) 
        //    {
        //        if(num%i == 0)
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}
        //static bool IsDivide3(int num)
        //{
        //    return num % 3 == 0;
        //}




        //class GenericList<T>
        //{
        //    T[] _arr;
        //    public int Capacity { get; set; } = 5;
        //    public int Count { get; private set; } = 0;
        //    public GenericList()
        //    {
        //        _arr = new T[Capacity];
        //    }
        //    public GenericList(int capacity)
        //    {
        //        Capacity = capacity;
        //        _arr = new T[Capacity];
        //    }
        //    public GenericList(T[] arr, int capacity = 5)
        //    {
        //        Capacity = capacity;
        //        _arr = arr;
        //        Count = arr.Length;
        //    }
        //    public void Add(T value)
        //    {
        //        if (_arr.Length == Count)
        //        {
        //            Array.Resize(ref _arr, Count + Capacity);
        //        }
        //        _arr[Count] = value;
        //        Count++;
        //    }
        //    public void GetElements()
        //    {
        //        for (int i = 0; i < Count; i++)
        //        {
        //            Console.WriteLine(_arr[i]);
        //        }
        //    }
        //    public bool Any(Predicate<T> pred)
        //    {
        //        for (int i = 0; i < Count; i++)
        //        {
        //            if (pred(_arr[i]))
        //            {
        //                return true;
        //            }
        //        }
        //        return false;
        //    }
        //    public bool All(Predicate<T> pred)
        //    {
        //        for (int i = 0; i < Count; i++)
        //        {
        //            if (!pred(_arr[i])) return false;
        //        }
        //        return true;
        //    }
        //    public IEnumerable<T> FindAll(Predicate<T> pred)
        //    {
        //        for (int i = 0; i < Count; i++)
        //        {
        //            if (pred(_arr[i]))
        //                yield return _arr[i];
        //        }
        //    }

        //}



    }
}
