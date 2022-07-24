

// Hometask #4
// 1. "Hello World" ✅
// 2. Value type & Reference type ✅
// 3. Static method ✅
// 4. ref, out, in ✅
// 5. Boxing & Unboxing ✅
// * read about static constructor

using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = 4.54;
            Singleton si = Singleton.GetInstance(age);



            Console.WriteLine("Initial Age: " + age);
            PossiblyUpdateAge(ref age);
            Console.WriteLine("Ref Change Age: " + age);
            HaveToUpdateAge(out age);
            Console.WriteLine("Out Change Age: " + age);
            ShowUpdatedAge(in age);
            Console.WriteLine("In Change Age: " + age);
            Console.WriteLine("In Change Age: " + age);


            object obj = BoxingMethod(5);
            Console.WriteLine(obj);
            int intEx = UnboxingMethod(5);
            Console.WriteLine(obj);
        }

        static void PossiblyUpdateAge(ref double age)
        {
            age = age + 0.0000001; // Could possibly be without setting age
        }
        static void HaveToUpdateAge(out double age)
        {
            age = 2; // Could possibly be without setting age
        }
        static void ShowUpdatedAge(in double age)
        {
            Console.WriteLine(age);
        }

        static Object BoxingMethod(int i)
        {
            object o = i;
            return o;
        }

        static int UnboxingMethod(object i)
        {
            int o = (int)i;
            return o;
        }
    }

    class Singleton
    {
        private static Singleton instance;

        private Singleton(double age)
        {
            Console.WriteLine("Hello World. You're " + age + " billion years old");
        }

        public static Singleton GetInstance(double age)
        {
            if (instance == null)
            {
                instance = new Singleton(age);
            }
            return instance;
        }
    }
}