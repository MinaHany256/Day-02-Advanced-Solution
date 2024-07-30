using System.Collections;

namespace Assignment_Collection
{
    internal class Program
    {
        #region 3.Given a Queue, implement a function to reverse the elements of a queue using a stack.
        //public static Queue<int> ReverseQueue(Queue<int> queue)
        //{
        //    Stack<int> result = new Stack<int>();

        //    for (int i = 0; i < queue.Count; i++)
        //        result.Push(queue.Dequeue());

        //    for (int i = 0; i <= result.Count; i++)
        //        queue.Enqueue(result.Pop());

        //    return queue;

        //} 
        #endregion

        #region 4.Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.
        //public static bool IsBalanced(string input)
        //{
        //    Stack<char> stack = new Stack<char>();

        //    foreach (char c in input)
        //    {
        //        if (c == '(' || c == '{' || c == '[')
        //            stack.Push(c);

        //        else if (c == ')' || c == '}' || c == ']')
        //        {
        //            if (stack.Count == 0)
        //                return false;

        //            char top = stack.Pop();

        //            if (
        //                   c == ')' && top != '('
        //                || c == '}' && top != '{' 
        //                || c == ']' && top != '['
        //               )
        //                return false;
        //        }
        //    }

        //    return stack.Count == 0;
        //} 
        #endregion

        #region 5.Given an array, implement a function to remove duplicate elements from an array.
        //public static int[] RemoveDuplicated(int[] Arr)
        //{
        //    List<int> list = new List<int>();

        //    foreach (int i in Arr)
        //    {
        //        if(!list.Contains(i))
        //            list.Add(i);
        //    }

        //    return list.ToArray();
        //} 
        #endregion

        #region 6.Given an array list , implement a function to remove all odd numbers from it

        //public static ArrayList RemoveOddNumbers(ArrayList list)
        //{
        //    ArrayList result = new ArrayList();

        //    foreach (int i in list)
        //    {
        //        if (!(i % 2 == 1))
        //            result.Add(i);
        //    }
        //    return result;
        //}

        #endregion

        #region 8.Create a function that pushes a series of integers onto a stack. Then, search for a target integer in the stack. If the target is found, print a message indicating that the target was found how many elements were checked before finding the target (“Target was found successfully and the count = 5”). If the target is not found, print a message indicating that the target was not found(“Target was not found”).

        //public static Stack<int> PushNumbersInStack(int[] Numbers)
        //{
        //    Stack<int> stack = new Stack<int>();

        //    foreach (int number in Numbers)
        //        stack.Push(number);

        //    return stack;
        //}

        //public static void SearchForNumbersInStack(Stack<int> stack, int Target)
        //{
        //    int Counter = 0;

        //    foreach (int number in stack)
        //    {
        //        Counter++;
        //        if (number == Target)
        //        {
        //            Console.WriteLine($"Target was found successfully and the count = {Counter}");
        //            return;
        //        }
        //    }

        //    Console.WriteLine($"Target was not found");
        //}

        #endregion

        #region 10.Given an ArrayList of integers and a target sum, find if there is a contiguous sub list that sums up to the target.

        //public static ArrayList? FindContigousSubList(ArrayList list, int Target)
        //{
        //    int count = list.Count;

        //    int Sum = 0;

        //    for (int i = 0; i < count; i++)
        //    {
        //        Sum = 0;

        //        for (int j = i; j < count; j++)
        //        {
        //            Sum += (int)list[j];

        //            if (Target == Sum)
        //            {
        //                ArrayList SubList = new ArrayList();
        //                for (int k = i; k <= j; k++)
        //                {
        //                    SubList.Add((int)list[k]);
        //                }

        //                return SubList;
        //            }
        //        }

        //    }

        //    return null;


        //}

        #endregion

        #region 11.Given a queue reverse first K elements of a queue, keeping the remaining elements in the same order 

        //public static Queue<int> ReverseFirstKElementsInQueue(Queue<int> queue, int K)
        //{
        //    Stack<int> stack = new Stack<int>();

        //    for (int i = 0; i < K; i++)
        //        stack.Push(queue.Dequeue());

        //    while (stack.Count > 0)
        //        queue.Enqueue(stack.Pop());

        //    int Remaining = queue.Count - K;
        //    for (int i = 0; i < Remaining; i++)
        //        queue.Enqueue(queue.Dequeue());

        //    return queue;
        //}

        #endregion


        static void Main(string[] args)
        {
            #region 1.Given an array  consists of  numbers with size N and number of queries, in each query you will be given an integer X, and you should print how many numbers in array that is greater than  X.

            //Console.Write("Please Enter Size of The Array : ");
            //int.TryParse(Console.ReadLine(), out int ArrSize);

            //Console.Write("Please Enter Number of Queries : ");
            //int.TryParse(Console.ReadLine(), out int NoOfQueries);


            //List<int> list = new List<int>(ArrSize);

            //Console.Write("Please Enter The Array : ");
            //for (int i = 0; i < NoOfQueries; i++)
            //     list.Add(int.Parse(Console.ReadLine() ?? "0"));


            //int Counter = 0;


            //for (int i = 0; i < NoOfQueries; i++)
            //{
            //    int.TryParse(Console.ReadLine(),out int Query);
            //    for (int j = 0; j < list.Count; j++)
            //    {
            //        if (Query < list[j])
            //            Counter++;
            //    }

            //    Console.WriteLine($"{Counter} Numbers in the List Greater Than {Query}");
            //    Counter = 0;
            //}

            #endregion

            #region 2.Given a number N and an array of N numbers. Determine if it's palindrome or not.

            //Console.Write("Please Enter Size of The Array : ");
            //int.TryParse(Console.ReadLine(), out int ArrSize);


            //List<int> list = new List<int>(ArrSize);

            //Console.WriteLine("Please Enter The Array : ");
            //for (int i = 0; i < ArrSize; i++)
            //    list.Add(int.Parse(Console.ReadLine() ?? "0"));


            //bool flag = true;


            //for (int i = 0; i < list.Count / 2; i++)
            //{
            //    if (list[i] != list[list.Count - i - 1])
            //    {
            //        flag = false;
            //        break;
            //    }
            //}

            //if (flag == true)
            //    Console.WriteLine("is Plaindrome");
            //else
            //    Console.WriteLine("Not PlainDrome");

            #endregion

            #region 3.Given a Queue, implement a function to reverse the elements of a queue using a stack.

            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue = ReverseQueue(queue);

            //foreach (int i in queue)
            //    Console.WriteLine(i);

            #endregion

            #region 4.Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.

            //Console.Write("Enter a STring of parentheses: ");
            //string input = Console.ReadLine() ?? "";
            //bool isBalanced = IsBalanced(input);
            //Console.WriteLine(isBalanced);


            #endregion

            #region 5.Given an array, implement a function to remove duplicate elements from an array.

            //int[] Arr = [1, 2, 2, 3, 4, 4, 5];

            //int[] ResultArr = RemoveDuplicated(Arr);

            //foreach (int i in ResultArr)
            //    Console.WriteLine(i);

            #endregion

            #region 6.Given an array list , implement a function to remove all odd numbers from it.

            //ArrayList Arr = new ArrayList() { 1, 2, 3, 4, 5 };

            //ArrayList result = RemoveOddNumbers(Arr);

            //foreach (int i in result) 
            //    Console.WriteLine(i);

            #endregion

            #region 7.Implement a queue that can hold different data types. 

            //Queue queue = new Queue();
            //queue.Enqueue(1);
            //queue.Enqueue("Apple");
            //queue.Enqueue(5.28);

            //foreach (var item in queue) 
            //    Console.WriteLine(item);

            #endregion

            #region 8.Create a function that pushes a series of integers onto a stack. Then, search for a target integer in the stack. If the target is found, print a message indicating that the target was found how many elements were checked before finding the target (“Target was found successfully and the count = 5”). If the target is not found, print a message indicating that the target was not found(“Target was not found”).

            //int[] Numbers = [1, 2, 3, 4, 5];

            //Stack<int> stack = PushNumbersInStack(Numbers);

            //Console.Write("Enter a Target To Search : ");
            //int.TryParse(Console.ReadLine(), out int Target);

            //SearchForNumbersInStack(stack, Target);


            #endregion

            #region 9.Given two arrays, find their intersection. Each element in the result should appear as many times as it shows in both arrays.

            //int[] Arr01 = [1, 2, 3, 4, 4];
            //int[] Arr02 = [10, 4, 4];

            //List<int> list = new List<int>();

            //for (int i = 0; i < Arr01.Length; i++)
            //{
            //    for (int j = 0; j < Arr02.Length; j++)
            //    {
            //        if (Arr01[i] == Arr02[j])
            //        {
            //            list.Add(Arr01[i]);
            //            Arr02[j] = int.MinValue; 
            //            break;
            //        }
            //    }
            //}

            //foreach (int i in list)
            //    Console.Write($" {i} ");

            #endregion

            #region 10.Given an ArrayList of integers and a target sum, find if there is a contiguous sub list that sums up to the target.

            //ArrayList list = new ArrayList() { 1, 2, 3, 7, 5 };

            //ArrayList? Result = FindContigousSubList (list, 12);

            //if (Result != null)
            //{
            //    foreach (int i in Result)
            //        Console.Write($" {i} ");
            //}
            //else
            //    Console.WriteLine("No contiguous");

            #endregion

            #region 11.Given a queue reverse first K elements of a queue, keeping the remaining elements in the same order 

            //Queue<int> queue = new Queue<int>([1, 2, 3, 4, 5]);

            //Queue<int> ResultQueue =  ReverseFirstKElementsInQueue(queue,3);

            //foreach (int i in ResultQueue)
            //    Console.Write($" {i} ");
            //Console.WriteLine();

            #endregion


        }
    }
}
