using System;

namespace _5_Д.з_Алиф
{
    class Program
    {
        static void Main(string[] args)
        {
            //pop
            string[] last = new string[] { "C++", "C#", "C" };
            string laststr = ArrayHelper.Pop(ref last);
            Console.WriteLine(laststr);


            int[] lasti = new int[] { 1, 2, 3, 4, 5 };
            int lastint = ArrayHelper.Pop(ref lasti);
            Console.WriteLine(lastint);


            double[] lastd = new double[] { 1.1, 2.2, 3.3, 4.4, 5.5 };
            double lastdbl = ArrayHelper.Pop(ref lastd);
            Console.WriteLine(lastdbl);

            decimal[] lastdec = new decimal[] { 5.505m, 4.404m, 3.303m, 2.202m, 1.101m };
            decimal lastdcm = ArrayHelper.Pop(ref lastdec);
            Console.WriteLine(lastdcm);

            float[] lastf = new float[] { 5.5f, 4.4f, 3.3f, 2.2f, 1.1f };
            float lastflt = ArrayHelper.Pop(ref lastf);
            Console.WriteLine(lastflt);


            //Push
            string[] addlast = new string[] { "C++", "C#", "C" };
            int addstrpush = ArrayHelper.Push(ref addlast, "Java");
            Console.WriteLine($"Push string:  {addstrpush}");


            int[] lastipush = new int[] { 1, 2, 3, 4, 5 };
            int lastintpush = ArrayHelper.Push(ref lastipush, 6);
            Console.WriteLine($"Push int: {lastintpush}");


            double[] lastdpush = new double[] { 1.1, 2.2, 3.3, 4.4, 5.5 };
            double lastdblpush = ArrayHelper.Push(ref lastdpush, 6.6);
            Console.WriteLine($"Push double: {lastdblpush}");


            decimal[] lastdecpush = new decimal[] { 5.505m, 4.404m, 3.303m, 2.202m, 1.101m };
            decimal lastdecimalpush = ArrayHelper.Push(ref lastdecpush, 0.101m);
            Console.WriteLine($"Push decimal: {lastdecimalpush}");


            float[] lastflpush = new float[] { 5.5f, 4.4f, 3.3f, 2.2f, 1.1f };
            float lstflp = ArrayHelper.Push(ref lastflpush, 0.1f);
            Console.WriteLine($"Push decimal: {lstflp}");


            //Shift

            string[] firststrelm = new string[] { "C++", "C#", "C" };
            string felemnt = ArrayHelper.Shift(ref firststrelm);
            Console.WriteLine($"Shift str: {felemnt}");


            int[] firstintelm = new int[] { 1, 2, 3, 4, 5 };
            int felementint = ArrayHelper.Shift(ref firstintelm);
            Console.WriteLine($"Shift int: {felementint}");


            double[] firstdblelemn = new double[] { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6 };
            double fdblelemnt = ArrayHelper.Shift(ref firstdblelemn);
            Console.WriteLine($"Shift double: {fdblelemnt}");

            decimal[] firstdcmelem = new decimal[] { 5.505m, 4.404m, 3.303m, 2.202m, 1.101m };
            decimal firstdcelem = ArrayHelper.Shift(ref firstdcmelem);
            Console.WriteLine($"Shift decimal: {firstdcelem}");


            float[] fisrtflelem = new float[] { 5.5f, 4.4f, 3.3f, 2.2f, 1.1f };
            float firstflrelem = ArrayHelper.Shift(ref fisrtflelem);
            Console.WriteLine($"Shift float: {firstflrelem}");



            //UnShift

            string[] newarray = new string[] { "C++", "C#", "C" };
            int newelemstr = ArrayHelper.UnShift(ref newarray, "C");
            Console.WriteLine($"Unshift string: {newelemstr}");

            int[] arrayint = new int[] { 1, 2, 3, 4, 5 };
            int newelemint = ArrayHelper.UnShift(ref arrayint, 6);
            Console.WriteLine($"Unshift int: {newelemint}");


            double[] arraydouble = new double[] { 1.1, 2.2, 3.3, 4.4, 5.5 };
            double newelemdbl = ArrayHelper.UnShift(ref arraydouble, 6.6);
            Console.WriteLine($"Unshift double {newelemdbl}");


            decimal[] arraydecimal = new decimal[] { 5.505m, 4.404m, 3.303m, 2.202m, 1.101m };
            decimal newelembl = ArrayHelper.UnShift(ref arraydecimal, 0.101m);
            Console.WriteLine($"Unshift decimal: {newelembl}");

            float[] arrayfloat = new float[] { 5.5f, 4.4f, 3.3f, 2.2f, 1.1f };
            float newelemfloat = ArrayHelper.UnShift(ref arrayfloat, 0.1f);
            Console.WriteLine($"Unshift float: {newelemfloat}");
            Console.ReadLine();
        }



    }


    public static class ArrayHelper
    {
        public static string Pop(ref string[] last)
        {
            string laststr = last[last.Length - 1];
            Array.Resize(ref last, last.Length - 1);

            return laststr;
        }

        public static int Pop(ref int[] last)
        {
            int lastint = last[last.Length - 1];
            Array.Resize(ref last, last.Length - 1);
            return lastint;
        }

        public static double Pop(ref double[] last)
        {
            double lastdbl = last[last.Length - 1];
            Array.Resize(ref last, last.Length - 1);
            return lastdbl;
        }

        public static decimal Pop(ref decimal[] last)
        {
            decimal lastdcm = last[last.Length - 1];
            Array.Resize(ref last, last.Length - 1);
            return lastdcm;
        }

        public static float Pop(ref float[] last)
        {
            float lastflt = last[last.Length - 1];
            Array.Resize(ref last, last.Length - 1);
            return lastflt;
        }

        //--------------------------------------------------

        public static int Push(ref string[] addlast, string newaddlast)
        {

            Array.Resize(ref addlast, addlast.Length + 1);
            addlast[addlast.Length - 1] = newaddlast;
            return addlast.Length - 1;
        }

        public static int Push(ref int[] addlast, int newelement)
        {
            Array.Resize(ref addlast, addlast.Length + 1);
            return addlast.Length - 1;
        }

        public static double Push(ref double[] addlist, double addnewelement)
        {
            Array.Resize(ref addlist, addlist.Length + 1);
            return addlist.Length - 1;
        }

        public static decimal Push(ref decimal[] addlist, decimal newadddec)
        {
            Array.Resize(ref addlist, addlist.Length + 1);
            return addlist.Length - 1;
        }


        public static float Push(ref float[] addlist, float newaddflt)
        {
            Array.Resize(ref addlist, addlist.Length + 1);
            return addlist.Length - 1;
        }


        //-----------------------------------------------

        public static string Shift(ref string[] firstelement)
        {
            string first = firstelement[0];
            for (int i = 0; i < firstelement.Length - 1; i++)
            {
                firstelement[i] = firstelement[i + 1];
            }
            Array.Resize(ref firstelement, firstelement.Length - 1);
            return first;
        }

        public static int Shift(ref int[] firstelement)
        {
            int first = firstelement[0];
            for (int i = 0; i < firstelement.Length - 1; i++)
            {
                firstelement[i] = firstelement[i + 1];
            }
            Array.Resize(ref firstelement, firstelement.Length - 1);
            return first;
        }

        public static double Shift(ref double[] firstelement)
        {
            double first = firstelement[0];
            for (int i = 0; i < firstelement.Length - 1; i++)
            {
                firstelement[i] = firstelement[i + 1];
            }
            Array.Resize(ref firstelement, firstelement.Length - 1);
            return first;
        }

        public static decimal Shift(ref decimal[] firstelement)
        {
            decimal first = firstelement[0];
            for (int i = 0; i < firstelement.Length - 1; i++)
            {
                firstelement[i] = firstelement[i + 1];
            }
            Array.Resize(ref firstelement, firstelement.Length - 1);
            return first;
        }
        public static float Shift(ref float[] firstelement)
        {
            float first = firstelement[0];
            for (int i = 0; i < firstelement.Length - 1; i++)
            {
                firstelement[i] = firstelement[i + 1];
            }
            Array.Resize(ref firstelement, firstelement.Length - 1);
            return first;
        }

        //------------------------------------------------------------




        public static int UnShift(ref string[] newaddelement, string aelemnt)
        {
            Array.Resize(ref newaddelement, newaddelement.Length + 1);
            for (int i = newaddelement.Length - 1; i >= 1; i--)
            {
                newaddelement[i] = newaddelement[i - 1];
            }
            newaddelement[0] = aelemnt;
            return newaddelement.Length - 1;
        }


        public static int UnShift(ref int[] newaddelement, int aelemnt)
        {
            Array.Resize(ref newaddelement, newaddelement.Length + 1);
            for (int i = newaddelement.Length - 1; i >= 1; i--)
            {
                newaddelement[i] = newaddelement[i - 1];
            }
            newaddelement[0] = aelemnt;
            return newaddelement.Length - 1;
        }


        public static double UnShift(ref double[] newaddelement, double aelemnt)
        {
            Array.Resize(ref newaddelement, newaddelement.Length + 1);
            for (int i = newaddelement.Length - 1; i >= 1; i--)
            {
                newaddelement[i] = newaddelement[i - 1];
            }
            newaddelement[0] = aelemnt;
            return newaddelement.Length - 1;
        }


        public static decimal UnShift(ref decimal[] newaddelement, decimal aelemnt)
        {
            Array.Resize(ref newaddelement, newaddelement.Length + 1);
            for (int i = newaddelement.Length - 1; i >= 1; i--)
            {
                newaddelement[i] = newaddelement[i - 1];
            }
            newaddelement[0] = aelemnt;
            return newaddelement.Length - 1;
        }

        public static float UnShift(ref float[] newaddelement, float aelemnt)
        {
            Array.Resize(ref newaddelement, newaddelement.Length + 1);
            for (int i = newaddelement.Length - 1; i >= 1; i--)
            {
                newaddelement[i] = newaddelement[i - 1];
            }
            newaddelement[0] = aelemnt;
            return newaddelement.Length - 1;
        }
    }
}


