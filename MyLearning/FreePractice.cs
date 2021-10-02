using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FreePractice
{
    public class FreePractice
    {
        //    public class Dog
        //    {
        //        static int a, b;
        //        public static void bark()
        //        {
        //            Console.WriteLine("Woof");
        //        }

        //        public void nonstat()
        //        {
        //            Console.WriteLine("nonstatic");
        //        }
        //    }
        //    public class Cat
        //    {
        //        static int c, d;
        //    }
        //    static void Main(string[] args)
        //    {
        //        //int[] array = { 3, 4 };
        //        ////array[0] = 1;
        //        ////array[1] = 2;
        //        //Console.WriteLine(array[0]);
        //        //Console.Read();
        //        //Dog d = new Dog();
        //        Dog.bark();
        //    }

        public int Method1(int a , int b)
        {
            return 0;
        }

        public int Method1(double a, int b)
        {
            return 0;
        }

        class Base
        {
            public Base()
            {
                Console.WriteLine("Base");
            }

            public Base(string msg)
            {
                Console.WriteLine(msg);
            }
            public virtual void Method()
            {
                Console.WriteLine("BaseMethod");
            }
            public virtual void Method1()
            {
                Console.WriteLine("BaseMethod1");
            }
        }
        class Derived : Base
        {
            public Derived(int i) : base("abc")
            {
                Console.WriteLine("Derived" + i);
            }
            public override void Method()
            {
                Console.WriteLine("DerivedMethod");
                base.Method();
            }
        }

        //class Derived1: Derived
        //{
        //    public Derived1(int i) : base(i)
        //    {
        //        Console.WriteLine("Derived1");
        //    }
        //public override void Method()
        //{
        //    Console.WriteLine("Derived1Method");
        //}
        //}
        #region
        public class generic<T>
        {
            internal string Name
            {
                get { return Name; }
                private set { Name = "ABC"; }
            }

            public int Age { get; set; } = 10;


            int counter = 0;
            T[] array = new T[100];
            public void pushintoarray(T i)
            {
                array[counter++] = i;
            }
            public void getarray(int i)
            {
                Console.WriteLine(array[i]);
            }
            public generic()
            {
                Console.WriteLine("Hi Generic Constructor");
            }
        }

        static class StaticClass
        {
            public static int Method()
            {
                return 10;
            }
        }

        sealed class PrivateorProtectedConstructor
        {
            public PrivateorProtectedConstructor()
            {
                Console.WriteLine("Hi");
            }
        }

        public interface AbstractClass
        {
            void AbstractClass1();
        }
#endregion
        public delegate void HelloDelegate(string message);

        public static void Mansi(string a, string b, double c, int d)
        {
            Console.WriteLine("{0}, {1}, {2}");
            Console.WriteLine("{0}, {1}, {2:C1}, {2:F1}", a, b, c, c);
        }

        public static void Main(string[] args)
        {
            Mansi("A", "B", 12.34, 5);

            #region Main (string[] args) test
            Console.WriteLine("Hi {0}, {0}, {0}", "a");
            #endregion

            #region null string test
           
            //string test1 = null;
            //if (test1.Contains("e"))
            //{
            //    Console.WriteLine("1");
            //}
            //else if (test1.Contains("bc"))
            //{
            //    Console.WriteLine("2");
            //}
            #endregion

            //Console.WriteLine(args.Length);
            //string a1 = null;
            //Console.WriteLine(a1);
            //Console.WriteLine(args);
            //Derived obj = new Derived(5);
            //obj.Method();
            //Base obj1 = new Derived(6);
            //obj1.Method();
            //PrivateorProtectedConstructor cs = new PrivateorProtectedConstructor();
            //generic<int> g1 = new generic<int>();
            //g1.getarray(1);
            //g1.pushintoarray(10);
            //g1.pushintoarray(20);
            //g1.getarray(1);
            //g1.getarray(2);
            //g1.getarray(99);
            Base A = new Base();
            Base B = new Derived(1);
            Derived C = new Derived(1);
            A.Method();
            B.Method();
            C.Method();
            Derived d = new Derived(2);
            d.Method();
            Derived e = new Derived(3);
            e.Method();



            //Derived C = new Base();

            //HelloDelegate hello = new HelloDelegate(
            //                                    delegate(string Msg) 
            //                                    {
            //                                        Console.WriteLine(Msg);
            //                                    }
            //                                       );
            //hello.Invoke("Sample Message");

            //HelloDelegate hello = msg => Console.WriteLine(msg);
            //hello("sample message");

            //Func<int, double> CalculateAreaOfCircle = rad => 3.14 * rad * rad;
            //CalculateAreaOfCircle(4);

            //Action<string> hello = msg => Console.WriteLine(msg);
            //hello("sample Message");

            //Predicate<string> CheckGreaterThan5 = str => str.Length > 5;
            //Console.WriteLine(CheckGreaterThan5("Shiv123"));

            // Application of Delegates

            //List<string> list = new List<string>();
            //list.Add("Amit");
            //list.Add("Subhash");
            //list.Add("Anita");
            //list.Add("Parveen");

            //string output = list.Find(CheckGreaterThan5);
            //Console.WriteLine(output);

            // Jagged Array and 2-D Array
            int[][] a = { new int[] { 1, 2, 3, 4 } };
            int[,] b = { { 1, 2 }, { 3, 4 } };
            Console.WriteLine(a[0][1]);
            Console.WriteLine(b[1, 1]);

            // Expression Trees
            // (10 + 20) - (5 + 3)
            BinaryExpression b1 = Expression.MakeBinary(ExpressionType.Add, Expression.Constant(10), Expression.Constant(20));
            BinaryExpression b2 = Expression.MakeBinary(ExpressionType.Add, Expression.Constant(5), Expression.Constant(3));
            BinaryExpression b3 = Expression.MakeBinary(ExpressionType.Subtract, b1, b2);
            int result = Expression.Lambda<Func<int>>(b3).Compile()();

            //
            Dictionary<int, int> dict = new Dictionary<int, int>() { {1, 2}, {2, 3} };
            Console.WriteLine(dict[1]);

            // Lambda expression are also used in LINQ queries
        }
        
        //public static void Main()
        //{
        //    Console.WriteLine();
        //}

        //public static void Main(int[] args)
        //{
        //    Console.WriteLine(args);
        //}

        //public static void Hello(string msg)
        //{
        //    Console.WriteLine(msg);
        //}
    }
}