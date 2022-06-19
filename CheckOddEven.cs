using System;

class CheckOddEven
{
int num = 0 ;
double sum_even = 0 ;
double sum_odd = 0 ;

static void get_even (int[] numbers , int num)
 {
// checking if a number is even

if (num % 2 = 0)
   {
Console.WriteLine(1) ;
     }
// checking if a number is odd
else if (num % 2 = 1)
 {
Console.WriteLine(0) ;
        }
// Main Method

public static void Main()
 {
Int [] numbers = new int[num] ;
int i ;
Console.Write("Enter the numbers you want to check :") ;
num = Convert.ToInt32 (Console.ReadLine()) ;

for( i = 0 ; i < num ; i++)
 {
numbers[i] = Convert.ToInt32(Console.ReadLine()) ;
     }
Console.WriteLine("{0} is an Even number", numbers[i]);
num ++;
sum_even = sum_even + numbers[i] ;
Console.WriteLine("{1} is an Odd number", numbers[i]);
num ++;
sum_odd = sum_odd + numbers[i] ;
       }
Console.WriteLine("There is a total of " + num + " even numbers and their sum
is " + sum_even + "\n There is a total of "+ num + " odd numbers and their sum
is " + sum_odd ) ;
        }
get_even(numbers , num) ;
    }
 }