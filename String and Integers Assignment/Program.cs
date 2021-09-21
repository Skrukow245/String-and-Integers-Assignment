using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            List<int> nums = new List<int>(new int[] { 10, 12, 14 });          //int list
            Console.WriteLine("Enter a number");
            int x = int.Parse(Console.ReadLine());              //user input
            string zero = (nums[0] / x).ToString();             //dividing list by user input
            Console.WriteLine(zero);
            string one = (nums[1] / x).ToString();
            Console.WriteLine(one);
            string two = (nums[2] / x).ToString();
            Console.WriteLine(two);
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);            //incorrect format input error
        }
        catch (DivideByZeroException ex)              //can't divide by 0 error
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);             //general exception error
        }
        Console.WriteLine("Program has emerged from the try/catch block and has continued.");






        Console.ReadLine();
    }
}

