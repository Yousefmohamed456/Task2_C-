using System;
using System.Runtime.Intrinsics.X86;


namespace Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Problem1
            // Declare two integer variables
            int x = 10;
            int y = 20;

            /*
               Calculate the sum of x and y
               and store the result in the sum variable.
            */
            int sum = x + y;

            // Display the result on the console
            Console.WriteLine(sum);
            //Ctrl + K, Ctrl + C to comment and Ctrl +K, Ctrl +U to uncomment 
            #endregion
            #region Problem2
            //Errors:
            /*
            "10" is a string, but x is declared as int.
            console should be Console because C# is case-sensitive.
            y has not been declared.
            */

            //Correct code:
            //int x = 10;
            //int y = 20;
            //console.writeline(x + y);
            //Question
            /*
                 Runtime error → program crashes/ stops;int result = 10 / 0;

                 Logical error → program runs but gives the wrong answer;
                 Using x - y when the program should calculate x + y
            */
            #endregion
            #region Problem3
            //string fullName = "youssef Mohamed";
            //int age = 20;
            //decimal monthlySalary = 15000.00m;
            //bool isStudent = true;
            //Question: Why is it important to follow naming conventions such as PascalCase in C#?
            //Naming conventions make code easier to read, understand, and maintain.
            //They also help developers quickly recognize what a variable, method, or class represents. 
            #endregion
            #region Problem4
                    class Student
        {
            public string Name;
        }

        Student student1 = new Student();
        student1.Name = "Ahmed";
                    
                    Student student2 = student1;

        // Change the object through student2
        student2.Name = "Mohamed";
                    
                    Console.WriteLine(student1.Name);
                    Console.WriteLine(student2.Name);

                    //Question:
                          //    Value Types
                          //Store the actual value.
                          //Usually allocated on the stack when they are local variables.
                          //Copying creates a separate copy of the value.
                          //Examples: int, double, bool, struct.
                    
                          //Reference Types
                          //Store a reference / address to an object.
                          //Objects are generally allocated on the heap.
                          //Copying copies the reference, so both variables can point to the same object.
                          //Examples: class, string, array. 
	#endregion
            #region Problem5
		    //int x = 15;
            //int y = 4;
            
            //Console.WriteLine("Sum: " + (x + y));
            //Console.WriteLine("Difference: " + (x - y));
            //Console.WriteLine("Product: " + (x* y));
            //Console.WriteLine("Division: " + (x / y));
            //Console.WriteLine("Remainder: " + (x % y));
            //Question: 
                 //Output:2;
                 //The % operator returns the remainder of division.
                 //with a remainder of 2, because 7 is larger than 2. 
	#endregion
            #region Problem6
		            //int number = 20;

            //   if (number > 10 && number % 2 == 0)
            //   {
            //       Console.WriteLine("The number is greater than 10 and even.");
            //   }
            //   else
            //   {
            //       Console.WriteLine("The number does not meet both conditions.");
            //   }
            //Question:
               //2. Difference between && and &

                 //&& (Logical AND):
                 //Used with Boolean conditions.Both conditions must be true.
                 //It also uses short-circuit evaluation,
                 //meaning it may skip the second condition if the first is false.

                 //& (Bitwise AND):
                 //Performs an AND operation on the individual bits of integer values.
                 //It can also be used with bool, but unlike &&, it evaluates both operands. 
	#endregion
            #region Problem7
		            //Console.Write("Enter a double number: ");
            //double number = double.Parse(Console.ReadLine());
            
            //// Implicit casting
            //int integerNumber = 10;
            //double implicitResult = integerNumber;
            
            //// Explicit casting
            //int explicitResult = (int)number;
            
            //Console.WriteLine("Implicit casting result: " + implicitResult);
            //Console.WriteLine("Explicit casting result: " + explicitResult);

            //2. Why is explicit casting required?
              //A double can store decimal values and has a larger range than an int.
              //Converting a double to an int may cause loss of the decimal part. 
	#endregion
            #region Problem8
		                   //Console.Write("Enter your age: ");
                   
                   //string input = Console.ReadLine();
                   //        int age = int.Parse(input);
                   
                   //if (age > 0)
                   //{
                   //    Console.WriteLine("Valid age.");
                   //}
                   //else
                   //{
                   //    Console.WriteLine("Invalid age.");
                   //}

                   //Question: how can you handle it

                   //try
                   //{
                   //    Console.Write("Enter your age: ");
                   //    string input = Console.ReadLine();
                   
                   //        int age = int.Parse(input);
                   
                   //    if (age > 0)
                   //        Console.WriteLine("Valid age.");
                   //    else
                   //        Console.WriteLine("Invalid age.");
                   //}
                   //catch (FormatException)
                   //{
                   //    Console.WriteLine("Please enter a valid number."); 
	#endregion
            #region Problem9
        //int x = 5;

        //Prefix: increments first, then uses the value
        //int prefix = ++x;
        //Console.WriteLine("Prefix: " + prefix);

        // Reset x
        //x = 5;

        //// Postfix: uses the value first, then increments
        //int postfix = x++;
        //Console.WriteLine("Postfix: " + postfix);

        //Console.WriteLine("Final x: " + x);

        //Question:

        //++x → increases x from 5 to 6, then uses 6.
        //x++ → uses the current value 6, then increases x to 7.
        //Therefore, y = 6 + 6 = 12.
        //Final value of x is 7.

        //Answer:
        //x = 7
        //y = 12

        //Prefix ++x: increment first, then use the value.
        //Postfix x++: use the value first, then increment. 
        #endregion
    }
}

