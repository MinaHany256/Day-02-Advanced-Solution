
using System.Collections;

//using System.Collections.Generic;

namespace Demo_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Non-Generic Collections - ArrayList

            //ArrayList Numbers = new ArrayList();

            //Console.WriteLine($"Count = {Numbers.Count} , Capacity = {Numbers.Capacity}");

            //Numbers.Add(1);
            //Numbers.Add(2);
            //Numbers.AddRange(new int[] {3,4});

            ////ArrayList NumbersX = new ArrayList(5);  // Capacity = 5  


            //Numbers.Add(5);

            //Console.WriteLine($"Count = {Numbers.Count} , Capacity = {Numbers.Capacity}");


            //Numbers.TrimToSize();  // Free | Delete | Release Unused Bytes

            //Console.WriteLine("---- After Trimming ----");
            //Console.WriteLine($"Count = {Numbers.Count} , Capacity = {Numbers.Capacity}");


            //ArrayList Numbers = new ArrayList() { 1, 2, 3 };

            //Numbers.Add(1);
            //Numbers.Add(2);
            //Numbers.Add(3);

            //ArrayList Numbers02 = new ArrayList(4) { 1, 2, 3, 4 };
            //ArrayList Numbers = new ArrayList(Numbers02); // Second Paramter

            //ArrayList Numbers = new ArrayList(5) { 1, 2, 3, 4, 5};

            //Console.WriteLine($"Count = {Numbers.Count} , Capacity = {Numbers.Capacity}");


            //for (int i = 6; i <= 21; i++)
            //{
            //    Numbers.Add(i);
            //}

            //Console.WriteLine($"Count = {Numbers.Count} , Capacity = {Numbers.Capacity}");

            //ArrayList Numbers = new ArrayList(5);

            //Numbers.Add(1);  // Boxing, Casting From int[ValueType] to Object[ReferenceType]

            #endregion


            #region Generic Collections - List

            //List<int> Numbers = new List<int>();
            //Console.WriteLine($"Count = {Numbers.Count} , Capacity = {Numbers.Capacity}");

            //Numbers.Add( 1 );
            //Numbers.AddRange([2, 3, 4]);
            //Numbers.Add(5);
            //Numbers.TrimExcess();
            //Console.WriteLine($"Count = {Numbers.Count} , Capacity = {Numbers.Capacity}");


            //List<int> Numbers = new List<int>(5) { 1, 2, 3, 4 };

            //Numbers[0] = 100;  // Can use Indexer to Update
            ////Numbers[4] = 5;    // Can't use Indexer to Add

            //for (int i = 0; i < Numbers.Count; i++)
            //{
            //    Console.WriteLine(Numbers[i]); // Can use Indexer to Print
            //}

            //Console.WriteLine($"Count = {Numbers.Count} , Capacity = {Numbers.Capacity}");


            //List<int> Numbers = new List<int>(5) { 1, 2, 3, 4, 5 };

            //Numbers.EnsureCapacity(21);

            //for (int i = 6; i <= 21; i++)
            //{
            //    Numbers.Add(i);
            //}

            //Console.WriteLine($"Count = {Numbers.Count} , Capacity = {Numbers.Capacity}");



            #endregion

        }
    }
}
