using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignStack
{
    class Program
    {
    static void Main()
        {
            string welcome = "Welcome! This is a LISP example project. Add, remove and clear from a stack. The following commands:";
            string options = "--------Options--------\n       Add: 'a'\n       Remove: 'r'\n       Clear: 'c'\n       Stack List: 's'\n       Quit: 'q'\n--------Options--------";
            var stack = new Stack();
            int stackCount = 0;

            ConsoleSpace.Spacing(welcome, options);

            while (true)
            {
                try
                {
                    switch (Console.ReadLine().ToLower())
                    {
                        case "a":
                            Console.Clear();
                            ConsoleSpace.Spacing(welcome, options);
                            stack.Push(stackCount++);
                            Console.WriteLine($"Current stack count is: {stack.StackCount()}");
                            break;

                        case "r":
                            Console.Clear();
                            ConsoleSpace.Spacing(welcome, options);
                            stack.Pop();
                            Console.WriteLine($"Current stack count is: {stack.StackCount()}");
                            break;

                        case "c":
                            Console.Clear();
                            ConsoleSpace.Spacing(welcome, options);
                            stack.Clear();
                            Console.WriteLine($"Current stack count is: {stack.StackCount()}");
                            break;

                        case "s":
                            Console.Clear();
                            ConsoleSpace.Spacing(welcome, options);
                            Console.WriteLine($"Current stack:");
                            stack.StackDisplay();
                            break;

                        case "q":
                        return;

                        default:
                                Console.Clear();
                                ConsoleSpace.Spacing(welcome, options);
                                Console.WriteLine("Please input a valid option.");
                            break;
                    }
                }
                catch (InvalidOperationException)
                {
                    Console.Clear();
                    ConsoleSpace.Spacing(welcome, options);
                    Console.WriteLine("There is nothing in the stack.");
                }
            }
        }
    }
}