using System;



//Console.WriteLine("Hello, World!");
//1  sbyte, byte, short, ushort, int, uint, long,
//   ulong, float, double, and decimal
//sbyte
Console.WriteLine($"Number of bytes for int is {sizeof(sbyte)}"); 
Console.WriteLine($"Minimum value for in is {sbyte.MinValue}"); 
Console.WriteLine($"Maximum value for in is {sbyte.MaxValue}");
// byte
Console.WriteLine($"Number of bytes for int is {sizeof(byte)}");
Console.WriteLine($"Minimum value for in is {byte.MinValue}");
Console.WriteLine($"Maximum value for in is {byte.MaxValue}");

// short
Console.WriteLine($"Number of bytes for int is {sizeof(short)}");
Console.WriteLine($"Minimum value for in is {short.MinValue}");
Console.WriteLine($"Maximum value for in is {short.MaxValue}");

// ushort
Console.WriteLine($"Number of bytes for int is {sizeof(ushort)}");
Console.WriteLine($"Minimum value for in is {ushort.MinValue}");
Console.WriteLine($"Maximum value for in is {ushort.MaxValue}");

//int
Console.WriteLine($"Number of bytes for int is {sizeof(int)}");
Console.WriteLine($"Minimum value for in is {int.MinValue}");
Console.WriteLine($"Maxmum value for in is {int.MaxValue}");

//uint
Console.WriteLine($"Number of bytes for int is {sizeof(uint)}");
Console.WriteLine($"Minimum value for in is {uint.MinValue}");
Console.WriteLine($"Maximum value for in is {uint.MaxValue}");

//long
Console.WriteLine($"Number of bytes for int is {sizeof(long)}");
Console.WriteLine($"Minium value for in is {long.MinValue}");
Console.WriteLine($"Maximum value for in is {long.MaxValue}");

//ulong
Console.WriteLine($"Number of bytes for int is {sizeof(ulong)}");
Console.WriteLine($"Minium value for in is {ulong.MinValue}");
Console.WriteLine($"Maximum value for in is {ulong.MaxValue}");

// float
Console.WriteLine($"Number of bytes for int is {sizeof(float)}");
Console.WriteLine($"Minium value for in is {float.MinValue}");
Console.WriteLine($"Maximum value for in is {float.MaxValue}");

//double
Console.WriteLine($"Number of bytes for int is {sizeof(double)}");
Console.WriteLine($"Minium value for in is {double.MinValue}");
Console.WriteLine($"Maximum value for in is {double.MaxValue}");

//decimal
Console.WriteLine($"Number of bytes for int is {sizeof(decimal)}");
Console.WriteLine($"Minium value for in is {decimal.MinValue}");
Console.WriteLine($"Maximum value for in is {decimal.MaxValue}");

//2 
/*
 * public void ConvertDate(uint century) { 
    uint year = century * 100; 
    uint days = year * 365 + 24 * century;
    uint hours = days * 24; uint minutes = hours * 60;
    uint seconds = minutes * 60; 
    ulong milliseconds = Convert.ToUInt64(seconds) * 1000;
    ulong microseconds = milliseconds * 1000;
    ulong nanoseconds = microseconds * 1000;
    Console.WriteLine($"{century} centuries = {year} years = {days} days = {hours} hours = {minutes} minutes = {seconds} second $"= { milliseconds} miliseconds = { microseconds} microseconds = { nanoseconds} nanoseconds");
        }
*/
// FizzBuzz
/*
for (int i = 1; i <= 100; i++) {
if (i % 3 == 0 && i % 5 == 0) {
Console.WriteLine("FizzBuzz");
}else if (i % 3 == 0) {
Console.WriteLine("Fizz");
} else if (i % 5 == 0) {
Console.WriteLine("Buzz");
} else {
Console.WriteLine(i);
}
}
*/

/* 2. it never end
int max = 500; 
for (byte i = 0; i < max; i++) 
{ 
    Console.WriteLine(i); 
}
correct:
int max = 500;
for (int i = 0; i < max; i++)
{
    Console.WriteLine(i);
}
*/

/*

            int a = 0;
            int b = 0;
            int c = 0;
            int l = 1; int rows = 0;

            Console.Write("Enter number of rows:\t");
            rows = Convert.ToInt16(Console.ReadLine());

            for (a = 1; a <= rows; a++)
            {
                for (b = 10; b >= a; b--)
                {
                    Console.Write(" ");
                }

                for (c = 1; c <= l; c++)
                {
                    Console.Write("*");
                }
                l = l + 2;
                Console.WriteLine();
            }

            Console.Read();

        }
    }
}
*/
/*  Generates a random number between 1 and 3
 int correctNumber = new Random().Next(3) + 1; 
Console.Write("Please enter a number between 1 and 3 => "); 
int guessedNumber = Convert.ToInt32(Console.ReadLine()); 
if (correctNumber == guessedNumber) 
{ 
Console.WriteLine("You got the correct answer!"); 
} 
else if (correctNumber < 1 || correctNumber > 3) 
{ 
Console.WriteLine("You guess was outside of the range"); 
} 
else if (correctNumber < guessedNumber) 
{ Console.WriteLine("A little bit too high."); 
} 
else 
{ Console.WriteLine("A little bit too low."); }
*/

/*  Write a simple program that defines a variable representing a birth date and calculates
how many days old the person with that birth date is currently.
Console.Write("Please enter the year you were born => "); 
int year = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Please enter the month you were born => "); 
int month = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Please enter the day you were born => "); 
int day = Convert.ToInt32(Console.ReadLine()); 
DateTime DateOfBirth = new DateTime(year, month, day); 
double diff = (DateTime.Today - DateOfBirth).TotalDays;
Console.WriteLine($"You have been lived for {diff} days!"); 
int daysToNextAnniversary = Convert.ToInt32(10000 - (diff % 10000));
Console.WriteLine($"There are {daysToNextAnniversary} days left to your next Anniversary");
*/

/* Greeting
DateTime moment = DateTime.Now;
int hour = moment.Hour; 
if (hour < 12)
{ 
    Console.WriteLine("Good Morning!"); 
}
else if (hour >= 12 && hour < 17) { 
    Console.WriteLine("Good Afternoon!"); 
} 
else if (hour >= 17 && hour < 21) { 
    Console.WriteLine("Good Evening!"); 
} 
else { Console.WriteLine("Good Night!"); 
} 
*/

/* Write a program that prints the result of counting up to 24 using four different increments.
First, count by 1s, then by 2s, by 3s, and finally by 4s.

for (int i = 1; i <= 4; i++) { 
    int res = 0;
    int target;
    while (res <= target) 
    { 
        Console.Write($"{res} "); res = res + i; 
    } 
    Console.WriteLine(); 
}
*/
