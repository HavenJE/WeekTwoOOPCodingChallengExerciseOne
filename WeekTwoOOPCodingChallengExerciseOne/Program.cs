
// Exercise 1 

// Create a program named Reverse3 whose Main() method declares three integers names firstInt, middleInt and lastInt. Assign values to the variables,
// display them and then pass them to a method that accepts them as reference variables. The method places the first value in the lastInt,
// and places the last value in the firstInt variable. In the Main() method, display the three variables again demonstrating that their positions have
// been reversed.

// Steps to write the program

// Tasks:

// Main() method

// Declare and assign values for 3 variables: firstInt, middleInt and lastInt
// Display the values of the three variables
// Call Reverse() to reverse values of the first and the last numbers
// Display values of the variables after reversing

// using System.Diagnostics.Metrics;
// using System.Runtime.Intrinsics.X86;
// Reverse() method

// Parameters: a, b, c (Note: as we want to retain the new value after conducting the reverse, we need to use ref parameters here)
// Reverse values of a and c. Use a temp variable: temp = a; a = c; c = temp;

class Program
{
    static void Main()
    {
        int firstInt = 1;
        int secondInt = 2;
        int thirdInt = 3;
        Console.WriteLine("{0}, {1}, {2}", firstInt, secondInt, thirdInt);
        Reverse(ref firstInt, ref secondInt, ref thirdInt);
        Console.WriteLine("{0}, {1}, {2}", firstInt, secondInt, thirdInt);
    }

    public static void Reverse(ref int a, ref int b, ref int c)
    {
      int temp = a;
        a = c;
        c = temp;


    }


}