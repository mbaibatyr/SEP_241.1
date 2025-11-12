namespace MyConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyFunction.Start();
            //Console.WriteLine("Введите имя");
            //var st = Console.ReadLine();
            //Console.WriteLine("Привет " + st);
            //Console.WriteLine($"Привет {st} - 123");
            //Console.WriteLine(string.Format("Привет {0} - {1}", st, "123"));

            //int zero = 0;
            //float res = 10 / zero;
            //Array array = new Array();
            //array.MyArray1();            

            MyClass myClass = new MyClass();
            myClass.Name = "Test";
            myClass.Description = "DDD";
            myClass.GetData();

            MyClass myClass2 = new MyClass("Test", "DDD");
            myClass2.GetData();
        }
    }

    public class Array
    {
        public void MyArray1()
        {
            int[] ar1 = new int[5] { 1,2,3,4,5};
            int[] ar2 = { 1, 2, 3, 4, 5, 6 };
            int[] ar3 = new [] { 1, 2, 3, 4, 5, 6 };
            
            var ar4 = new string[5];
            var ar5 = new[] { 1, 2, 3, 4, 5, 6 };

            //for (int i = 0; i < ar1.Length; i++)
            //{
            //    Console.Write(ar1[i]);
            //}

            //int k = 0;
            //while (k < ar1.Length)
            //{
            //    Console.Write(ar1[k]);
            //}

            int k = 0;
            int[] arInt = new int[3];
            while (true)
            {
                if (k >= 3)
                    break;
                Console.Write("Введите число: ");
                string st = Console.ReadLine();
                arInt[k] = int.Parse(st);
                k++;
            }
            int cnt1 = 0;
            int cnt2 = 0;
            for (int i = 0; i < arInt.Length; i++)
            {
                if (arInt[i] % 2 == 0)
                    cnt1++;
                else
                    cnt2++;
            }
            Console.WriteLine($"{cnt1} - {cnt2}");



        }
    }

    class Data
    {
        public double perimeter { set; get; }
        public double diameter { set; get; }
        public double square { set; get; }
        public double volume { set; get; }
        public string name { set; get; }
    }
    class MyFunction
    {        
        public static void Start()
        {
            string s = "111";
            string st = "";
            F3(s, out st);
            Console.WriteLine(st);
        }
        public static void F1(string st)
        {
            st += "222";
            Console.WriteLine(st);
        }

        public static void F2(ref string st)
        {
            st += "222";
            Console.WriteLine(st);
        }

        public static void F3(string s, out string st)
        {
            st = s + "222";
            Console.WriteLine(st);
        }

        public static double[] F4(double r)
        {
            double[] result = new double[4];
            result[0] = r;
            result[1] = r;
            result[2] = r;
            result[3] = r;
            return result;
        }

        public static Data F5(double r)
        {
            return new Data 
            { 
                diameter = r,
                square = r,
                volume = r,
                perimeter = r,
                name = "name"
            };
        }

    }

}
