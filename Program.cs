// Console.WriteLine("Hello, World!");
// Console.WriteLine("my name is kartika");
// Console.WriteLine("i'm from pulgaon");
// Console.WriteLine("my mother name is chanda");
// Console.WriteLine("my father name is krushnarao");
// Console.WriteLine("i completed my masters in computer science");
//*******************************************************************************
// string name = "kartika";
// int birthdate = 13; 
// Console.WriteLine(name);
// Console.WriteLine(birthdate);        

// //*****************************************************************************
// string name ="kartika";
// int age =20;
// string city ="pune";

// Console.WriteLine("my name is"+name);
// Console.WriteLine("my age is"+age);
// Console.WriteLine("my city name is"+city);

//*********************************************************************************
//simple calculator

// int a = 25;
// int b = 10;
// int addition = a+b;
// int subtraction =a-b;
// int multiplication= a*b;
// int division=a/b;
// Console.WriteLine("addition" +addition);
// Console.WriteLine("subtraction"+ subtraction);
// Console.WriteLine("multiplication"+multiplication);
// Console.WriteLine("division"+division);

//************************************************************************************
//Square of given number

// Console.Write("Enter the number");
// int number= Convert.ToInt32(Console.ReadLine());
// int square = number * number;
// Console.WriteLine("the square of given number is " + square);

//*************************************************************************************
//Check whether the number is even or odd
// Console.Write("Enter the number");
// int num = Convert.ToInt32( Console.ReadLine());
//  if(num%2==0)
//  {
//     Console.WriteLine("the given number is even number");
//  }
//  else
//  {
//     Console.WriteLine("the given number is a odd number");
//  }

//**************************************************************************************
//Find the largest number
// Console.Write("Enter the number1");
// int num1=Convert.ToInt32(Console.ReadLine());

// Console.Write("Enter the Number 2");
// int num2=Convert.ToInt32(Console.ReadLine());

// if(num1 > num2)
// {
//     Console.WriteLine("the number is larger" +num1);
// }
// else if(num2> num1)
// {
//     Console.WriteLine("the number is larger" + num2);
// }
// else{
//     Console.WriteLine("Both numbers are equal");
// }
//****************************************************************
//find the smallest number
// Console.Write("enter number 1");
// int num1=Convert.ToInt32(Console.ReadLine());
// Console.Write("enter number 2");
// int num2=Convert.ToInt32(Console.ReadLine());
// if(num1<num2){
//     Console.WriteLine("number1 is smaller");
// }
// else if(num2<num1){
//     Console.WriteLine("number2 is smaller");
// }
// else{
//     Console.WriteLine("both number are same");
// }
//***************************************************************************
//find the largest number between 3 numbers
/*Console.WriteLine("Enter number 1 ");
int num1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number 2 ");
int num2= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number 3");
int num3=Convert.ToInt32(Console.ReadLine());
if(num1>num2 && num1>num3){
Console.WriteLine("number 1 is largest");
}
else if(num2>num1 && num2>num3)
{
    Console.WriteLine("number 2 is largest");
}
else{
    Console.WriteLine("number 3 is largest");
}*/

//*********************************************************************************
//positive and negative number
// Console.Write("Enter a number");
// int num= Convert.ToInt32(Console.ReadLine());
// if(num>0){
//     Console.WriteLine("It is a positive number");
// }
// else if(num<0){
//     Console.WriteLine("It is a negative number");
// }
// else{
//     Console.WriteLine("The number is zero");
// }
//***********************************************************************************
//find the second largest number
// Console.Write("Enter number 1");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter Number 2");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter Number 3");
// int num3 = Convert.ToInt32(Console.ReadLine());
// if ((num1>num2 && num1<num3 )||(num1<num2 && num1>num3)) {
//     Console.WriteLine("number 1 is second largest number");
// }
// else if ((num2>num1 && num2<num3) || (num2<num1 && num2>num3)){
//     Console.WriteLine("number 2 is second largest number");
// }
// else{
//     Console.WriteLine("number 3 is second largest number");
// }
//**************************************************************************************
//check whether the number is divisible by 3 & 5 
// Console.Write("Enter number 1");
// int num1= Convert.ToInt32(Console.ReadLine());
// if(num1%3==0 && num1%5==0){
//     Console.WriteLine("number is divisible by 3 & 5");
// }
// else if(num1%3==0){
//     Console.WriteLine("Number is Divisible by 3");
// }
// else if(num1 %5 ==0){
//     Console.WriteLine("Number is Divisible by 5");
// }
// else{
//     Console.WriteLine("Number is not divisble by 3 and 5");
// }
//*******************************************************************************************
//wap to check person is eligible for voting or not
// Console.Write("Enter age");
// int age = Convert.ToInt32(Console.ReadLine());
// if(age>=18){
//     Console.WriteLine("the person is eligible for voting");
// }
// else{
//     Console.WriteLine("this person is not eligible for votting");
// }
//***************************************************************************************************
//program that shows grading system
// Console.Write("Enter Your Marks");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num>=90 && num<=100)
// {
//     Console.WriteLine("Grade A");
// }
// else if(num>=75 && num<89){
//     Console.WriteLine("Grade B");
// }
// else if(num>=60 && num<=74){
//     Console.WriteLine("Grade C");
// }
// else if(num>=40 && num<=59){
//     Console.WriteLine("Grade D");
// }
// else{
//     Console.WriteLine("FAIL");  
// }
//**********************************************************************************************************
//Electicity unit usage 
// Console.Write("Enter your Electricity Units");
// int num= Convert.ToInt32(Console.ReadLine());
// if(num>=0 && num<=100){
//     Console.WriteLine("Low Usage");
// }
// else if (num>=101 && num<=300){
//     Console.WriteLine("Medium Usage");
// }
// else{
//     Console.WriteLine("High Usage");

// }
//*************************************************************************************************************
//Find largest of 4 numbers
// Console.Write("Enter number 1");
// int num1=Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number 2");
// int num2=Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number 3");
// int num3 =Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter Number 4");
// int num4 = Convert.ToInt32(Console.ReadLine());
// if(num1>num2 && num1>num3 &&num1>num4){
// Console.WriteLine("num1 is largest number");
// }
// else if(num2>num1 && num2>num3 && num2>num4){
// Console.WriteLine("num2 is the largest number");
// }
// else if(num3>num1 && num3>num2 && num3>num4){
// Console.WriteLine("num3 is the largest number");
// }
// else if(num4>num1 && num4>num3 && num4>num3){
// Console.WriteLine("num4 is the largest number");
// }
// else{
//     Console.WriteLine("numbers are same");
// }
//**********************************************************************************

//***************************************Switch***************************************
//Check whether its weeks days or not
// Console.Write("Enter number from 1-7");
// int day=Convert.ToInt32(Console.ReadLine());
// switch (day)
// {
//  case 1:
//  Console.WriteLine("Monday") ;
//  break;
//  case 2:
//  Console.WriteLine("Tuesday") ;
//  break;
//   case 3;
//  Console.WriteLine("Wednesday");
//  break;
//  case 4:
//  Console.WriteLine("Thursday");
//  break;
//  case 5:
//  Console.WriteLine("Friday");
//break;
//  case 6:
//  Console.WriteLine("Saturday");
//  break;
//  case 7:
//  Console.WriteLine("Sunday");
//  break;

//     default:
//     Console.WriteLine("Invalid day");
//     break;

// }
//************************************************************************************
//check whether its month name or not
/*Console.Write("Enter number 1-12");
int month=Convert.ToInt32(Console.ReadLine());

switch(month)
{
case 1:
Console.WriteLine("January");
break;
case 2:
Console.WriteLine("february");
break;
case 3:
Console.WriteLine("march");
break;
case 4:
Console.WriteLine("april");
break;
case 5:
Console.WriteLine("may");
break;
case 6:
Console.WriteLine("june");
break;
case 7:
Console.WriteLine("july");
break;
case 8:
Console.WriteLine("august");
break;
case 9:
Console.WriteLine("september");
break;
case 10:
Console.WriteLine("october");
break;
case 11:
Console.WriteLine("november");
break;
case 12:
Console.WriteLine("december");
break;

default:
Console.WriteLine("invalid month");
break;
}*/
//**********************************************************************
//Write a program that displays food items
/*
Console.Write("Enter your choice");
int food=Convert.ToInt32(Console.ReadLine());
switch (food)
{
   case 1:
   Console.WriteLine("You selected pizza");
   break;
   case 2:
   Console.WriteLine("You Selected burger");
   break;
   case 3:
   Console.WriteLine("You selected noodles");
   break;
   case 4:
   Console.WriteLine("You selected manchurian");
   break;
   case 5:
   Console.WriteLine("Thank You");
   break;

    default:
    Console.WriteLine("please enter your choice");
    break;

}*/
//********************************************************************************
//write code to perform add, subtract,multiply,division
/*
Console.WriteLine("Enter first number");
int num1 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number");
int num2 =Convert.ToInt32(Console.ReadLine());
Console.Write("enter operator (+,-,*,/): ");
char op =Convert.ToChar(Console.ReadLine());


switch (op)
{
    case '+' :
    Console.WriteLine(num1+num2);
    //add
   break;
   case '-':
   Console.WriteLine(num1-num2);
   //subtract
   break;
   case '*' :
   Console.WriteLine(num1*num2);
   //multiply
   break;
   case '/':
   Console.WriteLine(num1/num2);
   //divide
   break;
    default:
    Console.WriteLine("please enter number");
    break;
}*/
//*******************************************************************
//**************************************while loop************************************
//print number in descending order
/*using System; 
class Program{
    static void Main()
    {
        int i=10;
        while(i>=1){
            Console.WriteLine(i);
            i--;
        }
    }
}*/
//*****************************************************************************
//print number in ascending order
/*using System;
class Program{
    static void Main()
    {
        int i=1;
        while(i<=10){
            Console.WriteLine(i);
            i++;
        }
    }
}*/
//********************************************************************************
//check number is even
/*using System;
class Program{
    static void Main()
    {
        int i=2;
        while(i<=20){
            if(i%2==0)
            {
Console.WriteLine(i);
            }
i++;

        }
    }
}*/
//********************************************************************************************
//for odd numbers
/*using System;
class Program{
    static void Main(){
int i=1;
while (i<=20)
{
    if(i%2!=0){
        Console.WriteLine(i);
    }
    i++;
}
    
}
}*/
//*******************************************************************************************
//table of 5
/*using System;
class Program{
    static void Main(){
        int i=1;
        while (i<=10)
        {
         Console.WriteLine(5*i);
         i++;
        }
        
    }

}*/
//*********************************************************************************************
//table of 6
// using System;
// class Program{
// static void Main(){
//     int i=1;
//     while (i<=10)
//     {
//         Console.WriteLine(6*i);
//         i++;
//     }
    
// }
// }
//******************************************************************************
//table of 7
/*using System;
class Program{
    static void Main(){
        int i=1;
        while (i<=10)
        {
           Console.WriteLine(7*i) ;
           i++;
        }
    }
}*/
//******************************************************************************
//sum of all numbers 1 to 10 output 55
/*using System;
class Program
{
    static void Main(){
        int i=1;
         int sum=0;
while (i<=10)
{
 sum=sum+i;
 i++;   
}
Console.WriteLine("sum" +sum) ;
    }
}*/
//*******************************************************************************
//simply print number from 1to 10
/*using System;
class Program{
    static void Main(){
        int i=1;
        while (i<=10)
        {
         Console.WriteLine(i); 
         i++;
        }
    }
}*/
//*********************************************************************************
//************************************for loop*************************************
//print numbers from 1 to 10
/*using System;
class Program{
    static void Main(){

    for (int i = 1; i <=10; i++)
    {
      Console.WriteLine(i);
    }
}
}*/
//**********************************************************************************
//print numbers 10-1
/*using System;
class Program{
    static void Main(){
        for (int i = 10; i >=1; i--)
        {
        Console.WriteLine(i);   
        }
    }
}*/
//********************************************************************************
//print even numbers using for loop
/*using System;
class Program{
    static void Main(){
        for( int i=2; i<=10; i+=2)
        {
            if(i%2==0){
            Console.WriteLine(i);
            }
        }
    }
}*/
//********************************************************************************
//print odd numbers
/*using System;
class Program{
    static void Main(){
        for (int i = 1; i<=10; i++)
        {
         if(i%2!=0)   {
            Console.WriteLine(i);
         }
        }
    }
}*/
//************************************************************************
//print table of 5 using for loop
/*using System;
class Program{
    static void Main(){
        for (int i =1; i<=10 ; i++)
        {
         Console.WriteLine(5*i); 
        }
    }
}*/
//************************************************************************
//table of 6 using for loop
/*using System;
class Program
{
    static void Main(){
    for (int i = 1; i<=6; i++)
    {
        Console.WriteLine(6*i);
    }
}
}*/
//*******************************************************************************
//sum of numbers 1-10
/*using System;
class Program{
    static void Main(){
        int sum=0;
        for(int i=1;i<=10;i++){
         sum= sum+i;
        }
        Console.WriteLine(sum);
    }
}*/
//********************************************************************************
//count even numbers
/*using System;
class Program{
    static void Main(){
        int count =0;
        for (int i = 1; i <=20; i++)
        {
          if(i%2==0) {
            count++;
          } 
        }
        Console.WriteLine(count);
    }
}*/
//************************************************************************************
//count odd numbers
/*using System;
class Program{
    static void Main(){
        int count=0;
        for (int i = 1; i<=20; i++)
        {
           if(i%2!=0) {
            count++;
           }
          
        }
         Console.WriteLine(count);
    }
}*/
//**************************************************************************************
//find largest max 1-20
/*using System;
class Program{
    static void Main(){
        int max=0;
        for (int i = 1; i<=20; i++)
        {
          if(i>max) {
            max=i;
          } 
        }
        Console.WriteLine(max);
    }
}*/
//*************************************************************************************
//find smallest number
/*using System;
class Program{
    static void Main(){
        int min=1;
        for (int i = 1; i<=20; i++)
        {
         if(i<min) {
            min=i;
         } 
        
        }
         Console.WriteLine(min);
    }
}*/
//************************************************************************************
//factorial of 5
/*using System;
class Program{
    static void Main(){
        int fact =1;
        for (int i = 1; i<=5; i++)
        {
          fact=fact*i;  
        }
        Console.WriteLine(fact);
    }
}*/
//*********************************************************************************
//factorial of 7 
/*using System;
class Program{
    static void Main(){
        int fact=1;
        for (int i = 1; i<=7; i++)
        {
           fact=fact*i; 
        }
        Console.WriteLine(fact);
    }   
}*/
//************************************************************************************
//print square of numbers from 1-10
/*using System;
class Program{
    static void Main(){
        for (int i = 1; i<=10; i++)
        {
           Console.WriteLine(i*i) ;
        }
    }
}*/
//*************************************************************************************
//square of numbers 1-20
/*using System;
class Program{
    static void Main(){
        for (int i = 1; i<=20; i++)
        {
           Console.WriteLine(i*i);
        }
    }
}*/
//***********************************************************************************
//print table of 3 from 1-20
/*using System;
class Program{
    static void Main(){
        for (int i = 1; i<=20; i++)
        {
          if (i%3==0)
          {
            Console.WriteLine(i);
          }  
        }
    }
}*/
//***********************************************************************************
//table of 5 from 1-20
using System;
class Program
{
    static void Main(){
        for (int i = 1; i<=20; i++)
        {
          if(i%5==0)  {
          Console.WriteLine(i);  
          }
        }
        
    }
}



























