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


        }
    }
}
