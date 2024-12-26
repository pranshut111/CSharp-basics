using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Prog1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //linked list 
            linkedlist.LinkedList<int> list = new linkedlist.LinkedList<int>();

            list.Insert(20);
            list.Insert(20);
            list.Insert(30);

            Console.WriteLine("Linked List:");
            list.Display();

            Console.WriteLine("\nRemoving 20:");
            list.Remove(20);
            list.Display();

            Console.WriteLine("\nAdding 40:");
            list.Insert(40);
            list.Display();





            // Prog :  write a program to print the largest number
            //   largest.largest1();

            // Prog : Factorial 
            //factorial.fact();

            //Prog : fibonacci seriess
            //fibonacci.fibbonacci();


            //prog : Prime number code
            //Primenum.prime();

            //prog : Reverse a string 
            // Reversestr.reverseString();

            //prog : sum od digits 
            //Sumofnum.sumOfnumber();

            //prog : Print a Table of  anyy number
            //Table.table();

            ///prog : swap two number without using 3rd variable 
            //  Swap.swap();


            //prog : sum of all numbers  of AARRAY
            // Sumofarr.sumARR();


            //prog : Largest number from the aarray
            // Arrlargest.arrLargest();

            //prog : Smallest from the array
            //Arrsmallest.arrSmallest();

            // prog  : reverse an array 
            //ArrReverse.rrReverse();

            //prog : sort arr in decending order 
            //SortingarrDes.sortingDsc();


            //prog: sorting array in ascending order 
            //SortingarrAsc.sortingAsc();


            //prog : find leap year
            //Leapyear.leapYear();

            //prog : merge two array 
            // mergeArray.merge();

            //prog : counnt number of vowels 
            //CountVowels.countVowels();

            //prog : add of two numbers
            //int a = add.add1();
            //Console.WriteLine(a);

            //prog : string length
            //Strlen.strLen();

            //prog  : pallindrone string 
            //Pallindrone.pallindroneStr();

            //prog : to find GCD
            //Gcd.gcd();

            //prog : string to int 
            //StrtoInt.strToint();

            //prog  : second largest from the array 
            //secLargeinarr.secondLargest();

            //prog : avg of array 
            //Avgarr.avgArray();

            //prog : simple calculator 
            // Simplecalc.simpleCalculator();

            //prog : print number from 1 to 10
            // forLoop.printFor();

            //prog : perfect number 
            //Perfectnum.perfectNumber();

            //prog : count number of words
            //countwords.CountWords();

            //prog : Ascii value of character 
            // Asciivalue.asciiValue();

            //prog: square of number 
            //Squareofnumber.squareOfnumber();

            //prog  : celscius to faranite 
            //CtoFarnite.ctofarnite();

            //// prog : Area of a Rectangle
            //rectangle.areaRectangle();

            ////prog :  Perimeter of a Rectangle
            //rectangle.perimeterRectangle();

            ////prog : Generate Random Number Between 1 and 100
            //Randomnum.randomNO();

            //// prog : Check if a Number is an Armstrong Number
            //Armstrong.armStrong();

            //// prog : Simple While Loop to Print Numbers 1 to 10
            // Printwhile.printWhile();

            //// pprog : Find LCM of Two Numbers
            //lcm.Lcm();

            ////prog :  Check if a Number is a Perfect Square
            //Perfectnum.perfectNum();

            //// prog : Print the Current Date and Time
            //Datetime.datetime();


            ////prog : Do-While Loop Example
            //doWhile.dowhile();

            ////prog : Sum of the First n Natural Numbers
            // sumN.sumNnatural();

            //// prog:  Decimal to Binary Conversion
            //  decTobin.decTObin();


            // prog : Prime Numbers Up to a Given Number
            // printprime.printPrime();



            Console.ReadLine();

        }
    }
}
