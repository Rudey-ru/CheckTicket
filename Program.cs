using System;

namespace LuckyTicket
{
    class Program
    {
        static void Main(string[] args)
        {

            CheckYourLuck check = new CheckYourLuck();

            while (true)
            {
                Console.Write("Please, enter your ticket number: ");
                string tickNum = Console.ReadLine();
                check.Check(tickNum);
            }
        } 
    }

    class CheckYourLuck
    {
        public void Check(string ticket)
        {
            // This method allows you to determine whether the ticket is lucky or not.

            void Calk(int[] arr)
            {
                int middle = ticket.Length / 2;
                int firstRes = 0;
                int secondRes = 0;

                for (int i = 0; i < middle; i++)
                {
                    firstRes += arr[i];
                }

                for (int i = arr.Length - 1; i >= middle; i--)
                {
                    secondRes += arr[i];
                }

                if (firstRes == secondRes)
                {
                    Console.WriteLine("Your ticket is lucky");
                }
                else
                {
                    Console.WriteLine("Your ticket is not lucky");
                }
            }

            //This method converts entered string to arrays of numbers

            int[] ConvertStringToArray(string ticket)
            {
                int[] arr = new int[ticket.Length];

                for (int i = 0; i < ticket.Length; i++)
                {
                    arr[i] = Convert.ToInt32(ticket.Substring(i, 1));
                }
                return arr;
            }

            // This method add 0 at the beginning of the ticket number

            static int[] Insert(int[] array)
            {
                int[] NewArr = new int[array.Length + 1];

                NewArr[0] = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    NewArr[i + 1] = array[i];
                }
                return NewArr;
            }

            int[] newArr = ConvertStringToArray(ticket);

            if (ticket.Length < 4 || ticket.Length > 8)
            {
                Console.WriteLine("The ticket number must be 4 to 8 digits long.");
            }
            else
            {
                if (ticket.Length % 2 != 0)
                {
                    Insert(newArr);
                    Calk(newArr);
                }
                else
                {
                    Calk(newArr);
                }
            }
        }
    }
}
