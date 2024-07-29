
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

            #region Generic Collections - List (Methods)

            #region Add, Insert, AsReadOnly
            //List<int> Numbers = new List<int>(5) { 1, 3, 4, 5 };

            //Numbers.Add(1);
            //Numbers.AddRange([2, 3, 4]); 
            //Numbers.Insert(0, 100);

            //IReadOnlyList<int> readOnlyNumbers = Numbers.AsReadOnly(); 
            #endregion

            #region BinarySearch
            //int index = Numbers.BinarySearch(2);

            //Console.WriteLine(index);

            //List<Employee> employees = new List<Employee>()
            //{
            //    new Employee (10, "Ahmed", 2_000),
            //    new Employee (20, "Omar", 3_000),
            //    new Employee (30, "Nadia", 8_000),
            //};

            //employees.Sort(new EmployeeComparer());

            //int index = employees.BinarySearch(new Employee() { Salary = 8_000 });

            //index = employees.BinarySearch(new Employee() { Name = "Omar" }, new EmployeeComparer());

            //index = employees.BinarySearch(1, 2, new Employee() { Name = "Omar" }, new EmployeeComparer());

            //Console.WriteLine($"Index = {index}"); 
            #endregion

            #region Clear

            //List<int> Numbers = new List<int>(5) { 1, 3, 4, 5 };
            //Numbers.Clear(); 
            #endregion

            #region ConvertAll
            //List<int> Numbers = new List<int>(5) { 1, 3, 4, 5 };

            //List<long> NewNumbers = Numbers.ConvertAll<long>(delegate (int N)
            //{
            //    N += 100;
            //    return N;
            //});

            //List<long> NewNumbers = Numbers.ConvertAll<long>(
            //    N => { N += 100; return N; });

            //// To Return Only
            //List<long> NewNumbers02 = Numbers.ConvertAll<long>(N => N);

            //foreach (int i in NewNumbers)
            //    Console.WriteLine(i); 
            #endregion

            #region CopyTo
            //List<int> Numbers = new List<int>(5) { 1, 2, 3, 4, 5 };


            //int[] Arr = new int[10];
            //Numbers.CopyTo(Arr);
            //Numbers.CopyTo(Arr,4);
            //Numbers.CopyTo(2,Arr, 4,3);

            //foreach (int i in Arr)
            //    Console.WriteLine(i); 
            #endregion

            #region Find, FindAll, FindIndex, FindLast, FindLastIndex

            //List<int> Numbers = new List<int>(5) { 1, 2, 3, 4, 5 };

            //int EvenNumber = Numbers.Find((N) => N % 2 == 0);
            //int EvenNumber01 = Numbers.FindLast((N) => N % 2 == 0);
            //int[] EvenNumbers = Numbers.FindAll((N) => N % 2 == 0).ToArray();
            //int index = Numbers.FindIndex(N => N % 2 == 0);


            //Console.WriteLine($"Even Number = {EvenNumber01}");
            //Console.WriteLine($"index = {index}"); 
            #endregion

            #region Exists, TrueForAll

            //List<int> Numbers = new List<int>(5) { 1, 2, 3, 4, 5 };

            //bool IsExist = Numbers.Exists(N => N%2 == 0);
            //Console.WriteLine(IsExist);

            //bool AllEven = Numbers.TrueForAll(N => N%2 == 0);
            //Console.WriteLine(AllEven);

            #endregion

            #region IndexOf

            //List<int> Numbers = new List<int>(5) { 1, 2, 3, 5, 5 };

            //Console.WriteLine(Numbers.IndexOf(5));

            #endregion

            #endregion

            #region Generic Collections - LinkedList

            //LinkedList<int> Numbers = new LinkedList<int>();

            //LinkedListNode<int> FirstNode = Numbers.AddFirst(1);
            //LinkedListNode<int> ThirdNode = Numbers.AddLast(3);

            //LinkedListNode<int> SecondNode = Numbers.AddAfter(FirstNode, 2);

            //Console.WriteLine(FirstNode.Next.Value);
            #endregion

            #region Generic Collections - Stack

            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);  
            //stack.Push(3);


            //Console.WriteLine(stack.Pop());  // 3
            //Console.WriteLine(stack.Pop());  // 2
            //Console.WriteLine(stack.Pop());  // 1
            //Console.WriteLine(stack.TryPop(out int value));  // No Exception will be Thrown

            //Console.WriteLine(stack.Peek());
            //Console.WriteLine(stack.TryPeek(out int value));

            #endregion



        }
    }
}
