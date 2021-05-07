using System;
 
class MainClass {
public static void Main (string[] args) {
Console.WriteLine("This is how to write to the console");
 
Console.WriteLine("\n ---------------------------------- \n");
//basic sequence
int firstnumber = 23;
int secondnumber = 3;
Console.WriteLine("The first number is " + firstnumber);
Console.WriteLine("The second number is " + secondnumber);
 
int num3 = firstnumber * secondnumber;
Console.WriteLine("23 * 3 = " + num3);
 
Console.WriteLine("\n ---------------------------------- \n");
 
//Selection
if(secondnumber > firstnumber){
Console.WriteLine("secondnumber is biggerthan firstnumber");
}
else
{
Console.WriteLine("firstnumber is bigger than secondnumber");
}
 
Console.WriteLine("\n ---------------------------------- \n");
//Iteration
int[] number = {1,4,2,5,4,3};
Console.WriteLine("The seond value in the array is: " + number[1] + "\n The last forth is " + number[3]);
 
for (int i = 0; i < number.Length; i++)
{
Console.WriteLine("Element " + i + " In the array: " + number[i]);
}
Console.WriteLine("\n ---------------------------------- \n");
}
}
