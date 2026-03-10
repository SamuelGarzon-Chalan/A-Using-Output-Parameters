using System.ComponentModel;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a number :");
       int number = int.Parse(Console.ReadLine());
       GetSquareAndCube(number, out int square, out int cube);
    }
    static void GetSquareAndCube(int number, out int square, out int cube)
    {
        square = number * number;
        cube = number * number * number;
        Console.WriteLine($"Square of {number} is : {square}");
        Console.WriteLine($"Cube of {number} is : {cube}");
    }
}

//Write a C# extension method named IsEven() for the int type that checks whether a number is even.

//The method should return true if the number is even and false otherwise.
//Use this method in Main() to check if a user-provided number is even or odd.

//Hint:
//Define a static class for the extension method.
//The method should be static and use this int as a parameter.
//Call it like a normal method on an int value (e.g., number.IsEven()