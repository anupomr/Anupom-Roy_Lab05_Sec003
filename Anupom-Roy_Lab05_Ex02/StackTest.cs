using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anupom_Roy_Lab05_Ex02
{
    class StackTest
    {
        // create arrays of doubles and ints
        private static double[] doubleElements =
           {1.1, 2.2, 3.3, 4.4, 5.5, 6.6};
        private static int[] intElements =
           {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11};
        private static char[] charElements = { 'S', 'K', 'A', 'U', 'P', 'K', 'A' };

        private static Stack<double> doubleStack; // stack stores doubles
        private static Stack<int> intStack; // stack stores ints  
        private static Stack<char> charStak;
        static void Main(string[] args)
        {
            doubleStack = new Stack<double>(5); // stack of doubles
            intStack = new Stack<int>(10); // stack of ints
            charStak = new Stack<char>(6);

            TestPushDouble(); // push doubles onto doubleStack
            TestPopDouble(); // pop doubles from doubleStack
            TestPushInt(); // push ints onto intStack
            TestPopInt(); // pop ints from intStack
            TestPushChar();
            TestPopChar();
        }
        private static void TestPushDouble()
        {
            // push elements onto stack
            try
            {
                Console.WriteLine("\nPushing elements onto doubleStack");

                // push elements onto stack
                foreach (var element in doubleElements)
                {
                    Console.Write($"{element:F1} ");
                    doubleStack.Push(element); // push onto doubleStack
                }
            }
            catch (FullStackException exception)
            {
                Console.Error.WriteLine($"\nMessage: {exception.Message}");
                // Console.Error.WriteLine(exception.StackTrace);
            }
        }

        // test Pop method with doubleStack
        private static void TestPopDouble()
        {
            // pop elements from stack
            try
            {
                Console.WriteLine("\nPopping elements from doubleStack");

                double popValue; // store element removed from stack

                // remove all elements from stack
                while (true)
                {
                    popValue = doubleStack.Pop(); // pop from doubleStack
                    Console.Write($"{popValue:F1} ");
                }
            }
            catch (EmptyStackException exception)
            {
                Console.Error.WriteLine($"\nMessage: {exception.Message}");
                // Console.Error.WriteLine(exception.StackTrace);
            }
        }

        // test Push method with intStack
        private static void TestPushInt()
        {
            // push elements onto stack
            try
            {
                Console.WriteLine("\nPushing elements onto intStack");

                // push elements onto stack
                foreach (var element in intElements)
                {
                    Console.Write($"{element} ");
                    intStack.Push(element); // push onto intStack
                }
            }
            catch (FullStackException exception)
            {
                Console.Error.WriteLine($"\nMessage: {exception.Message}");
                // Console.Error.WriteLine(exception.StackTrace);
            }
        }

        // test Pop method with intStack
        private static void TestPopInt()
        {
            // pop elements from stack
            try
            {
                Console.WriteLine("\nPopping elements from intStack");

                int popValue; // store element removed from stack

                // remove all elements from stack
                while (true)
                {
                    popValue = charStak.Pop(); // pop from intStack
                    Console.Write($"{popValue:F1} ");
                }
            }
            catch (EmptyStackException exception)
            {
                Console.Error.WriteLine($"\nMessage: {exception.Message}");
                //Console.Error.WriteLine(exception.StackTrace);
            }
        }

        // test Push method with intStack
        private static void TestPushChar()
        {
            // push elements onto stack
            try
            {
                Console.WriteLine("\nPushing elements onto intStack");

                // push elements onto stack
                foreach (var element in charElements)
                {
                    Console.Write($"{element} ");
                    charStak.Push(element); // push onto intStack
                }
            }
            catch (FullStackException exception)
            {
                Console.Error.WriteLine($"\nMessage: {exception.Message}");
                //Console.Error.WriteLine(exception.StackTrace);
            }
        }

        // test Pop method with intStack
        private static void TestPopChar()
        {
            // pop elements from stack
            try
            {
                Console.WriteLine("\nPopping elements from intStack");

                char popValue; // store element removed from stack

                // remove all elements from stack
                while (true)
                {
                    popValue = charStak.Pop(); // pop from intStack
                    Console.Write($"{popValue:F1} ");
                }
            }
            catch (EmptyStackException exception)
            {
                Console.Error.WriteLine($"\nMessage: {exception.Message}");
                // Console.Error.WriteLine(exception.StackTrace);
            }
        }

    }
}
