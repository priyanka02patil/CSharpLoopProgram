using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LoopProgram1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num = 152;
            //int rem ,sum = 0;
            //int temp = num;

            //while(num > 0)
            //{
            //    rem = num % 10;
            //    sum = sum + (rem * rem * rem);
            //    num = num / 10;
            //}
            //if(temp == sum)
            //{
            //    Console.WriteLine("Armstrong Number");
            //}
            //else
            //{
            //    Console.WriteLine("Not Armstrong Number");
            //}

            //int num = 121;
            //int rem, rev = 0, temp = num;

            //while (num > 0)
            //{
            //    rem = num % 10;
            //    rev = (rev * 10) + rem;
            //    num = num / 10;
            //}
            //if (rev == temp)
            //{
            //    Console.WriteLine("number is pallindrome");
            //}
            //else
            //{
            //    Console.WriteLine("Not pallindrome");
            //}


            /*
             temp, no=121
             sum=0
                 no>0       rem=no%10      rev=(rev*10)+rem      no=no/10
                 121>0        1=121%10         1 = (0*10)+1              121/10  -> 12
                  12>0         2 =12%10        12 = (1*10)+2             12/10   -> 1
                  1>0           1=1%10         121=(12*10)+1              1/10  -> 0
                  0>0
             */


            //1.Write a C# program to check whether a year is leap year or not  


            //int year = 2020;

            //if (year % 4 == 0 && (year%100!=0 || year%400==0))
            //{
            //    Console.WriteLine(year + " This year is leap year");
            //}
            //else
            //{
            //    Console.WriteLine(year + " This Year is not a leap year");
            //}

            //2.Write a C# program to check whether a number is divisible by 5 and 11 or not  


            //int num = 55;

            //if(num%5==0 && num % 11 == 0)
            //{
            //    Console.WriteLine(num + " Yes this number is divisible by 5 and 11");
            //}
            //else
            //{
            //    Console.WriteLine(num + " No this number is not divisible by 5 and 11");
            //}


            //3.Write a C# program to find maximum between three numbers  


            //int num1 = 72 ,num2 = 15 ,num3 = 7;

            //if(num1>num2 && num1 > num3)
            //{
            //    Console.WriteLine(num1 + " num1 is maximum");
            //}
            //else if(num2>num1 && num2 > num3)
            //{
            //    Console.WriteLine(num2 + " num2 is maximum");
            //}
            //else
            //{
            //    Console.WriteLine(num3 + " num3 is maximum");
            //}

            //4.Write a C# program to input any alphabet and check whether it is vowel or consonant

            //char ch = 'O';

            //if(ch=='a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            //{
            //    Console.WriteLine(ch + " This character is Vowel");
            //}
            //else
            //{
            //    Console.WriteLine(ch + " This character is Consonent");
            //}

            //5.Write a C# program to create Simple Calculator

            //Console.WriteLine("Enter number1");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter number2");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter operator : + - * / %");
            //char ch = Convert.ToChar(Console.ReadLine());
            //int result;

            //if(ch == '+')
            //{
            //    result = num1 + num2;
            //    Console.WriteLine("Addition of number is : " + result);
            //}
            //else if(ch =='-')
            //{
            //    result = num1 - num2;
            //    Console.WriteLine("Substraction of number is : " + result);
            //}
            //else if (ch == '*')
            //{
            //    result = num1 * num2;
            //    Console.WriteLine("Multiplication of number is : " + result);
            //}
            //else if (ch == '/')
            //{
            //    result = num1 / num2;
            //    Console.WriteLine("Division of number is : " + result);
            //}
            //else if (ch == '%')
            //{
            //    result = num1 % num2;
            //    Console.WriteLine("Modulus of number is : " + result);
            //}



            // 7.Write a C# program to input any character and check whether it is alphabet, digit or special character  

            //char ch = '$';

            //if(ch >='a' && ch <='z' || ch >='A' && ch <= 'Z')
            //{
            //    Console.WriteLine(ch + " This character is an Alplhabet");
            //}
            //else if(ch >='0' && ch <='9')
            //{
            //    Console.WriteLine(ch + " This character is digit");
            //}
            //else
            //{
            //    Console.WriteLine(ch + " This is a special Character");
            //}

            //8.Write a C# program to check whether a number is even or odd


            //int num = 12;

            //if (num % 2 == 0)
            //{
            //    Console.WriteLine(num + " Number is Even");
            //}
            //else
            //{
            //    Console.WriteLine(num + " Number is Odd");
            //}

            // 9.Write a C# program print total number of days in a month  


            //string month = "february";
            //int year = 2020;

            //if(month == "february" && (year%4==0 && (year%100!=0 || year%400==0)))
            //{
            //    Console.WriteLine(month + " this month in " + year +" have 29 days");
            //}
            //else if (month=="february" && !(year % 4 == 0 && (year % 100 != 0 || year % 400 == 0)))
            //{
            //    Console.WriteLine(month + " this month in " + year + " have 28 days");
            //}
            //else if (month == "january" || month == "march" || month == "may" || month == "jully" || month == "august" || month == "october" || month == "december")
            //{
            //    Console.WriteLine(month + " this month have 31 days");
            //}
            //else
            //{
            //    Console.WriteLine(month + " this month have 30 days");
            //}

            //10.Write a C# program to input basic salary of an employee and calculate its  
            //Gross salary according to following: Basic Salary <= 10000 : HRA = 20 %, DA = 80 % Basic Salary <= 20000 : HRA = 25 %,
            //DA = 90% Basic Salary >20000 : HRA = 30%, DA = 95%  

            //double salary = 30000;
            //double hra, da, gross;

            //if(salary <= 10000)
            //{
            //    hra = salary * 0.20;
            //    da = salary * 0.80;
            //    gross = salary + hra + da;
            //    Console.WriteLine(gross+ " this is gross salaray for salary less than 10000");
            //}
            //else if(salary <=20000)
            //{
            //    hra = salary * 0.25;
            //    da = salary * 0.90;
            //    gross = salary + hra + da;
            //    Console.WriteLine(gross + " this is gross salaray for salary less than 20000");
            //}
            //else if(salary > 20000)
            //{
            //    hra = salary * 0.30;
            //    da = salary * 0.95;
            //    gross = salary + hra + da;
            //    Console.WriteLine(gross + " this is gross salaray for salary greater than 20000");
            //}


            // looping assignment

            // 1.Display numbers from 1 to 100.

            //for(int i = 1; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //}

            // 2.Display all even numbers from 1 to 100.

            //for (int i = 1; i <= 100; i++)
            //{
            //    if(i%2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            // 3.Display all odd numbers from 200 to 300.

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            // 4.Display the seventh element between 400 to 500(both numbers excluded).

            //int count = 0;
            //for (int i = 401; i < 500; i++)
            //{
            //    count++;
            //    if (count == 7)
            //    {
            //        Console.WriteLine(i);
            //        count = count - 7;
            //    }
            //}

            // 5.Find the first 10 even numbers. 

            //int i=1 , evencount=0;

            //while (i> 0)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //        evencount++;
            //    }
            //    if(evencount == 10)
            //    {
            //        break;
            //    }
            //    i++;
            //}

            // 6.Find all prime numbers < 100.


            //for(int i = 1; i < 100; i++)
            //{
            //    int count = 0;
            //    for (int j = i; j >=1; j--)
            //    {
            //        if (i % j == 0)
            //        {
            //            count++;
            //        }
            //    }
            //    if(count == 2)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //7.Calculate factorial of a number. 

            //int num = 5;
            //int fact = 1;
            //for(int i = 1; i <= num; i++)
            //{
            //    fact = fact * i;
            //}

            //Console.WriteLine("factorial of " + num + " is = " + fact );


            //8.Count the number of digits in any number. 

            //int num = 1234;
            //int digit;
            //int count = 0;

            //for(int i=num; i > 0; i = i / 10)
            //{
            //    digit = i % 10;
            //    count++;
            //}
            //Console.WriteLine(count);

            11.Generate Fibonacci series. 0,1, 1, 2, 3, 5,8..... k.where k<n . n is entered by user

            Console.WriteLine("enter limit : ");
            int n = Convert.ToInt32(Console.ReadLine());

            int n1 = 0, n2 = 1, n3;

            Console.Write("fibonacci series : " + n1 + " " + n2);

            for (int i = 2; i < n; i++)
            {
                n3 = n1 + n2;
                Console.Write(" " + n3 + " ");
                n1 = n2;
                n2 = n3;//fibo code
            }

            //2.Find the sum of all digits of a number. 

            //int num = 1234;
            //int sum = 0 , digit;

            //for(int i = num; i > 0; i = i / 10)
            //{
            //    digit = i % 10;
            //    sum = sum + digit;
            //}
            //Console.WriteLine(sum);

            //14.check no is automorphic or not input n = 25 output Automorphic as 25 * 25 = 625

            //int num = 25 ,result,temp;

            //result = num * num;//625

            //temp = result % 100;//

            //if (num == temp)
            //{
            //    Console.WriteLine("number is automorphic");
            //}
            //else
            //{
            //    Console.WriteLine("not automorphic");
            //}










































        }
    }
}
