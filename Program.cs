// See https://aka.ms/new-console-template for more information

// Task 1
int a = 5;
int b = 7;
Console.WriteLine(a);
Console.WriteLine(b);
int c = a;
a = b;
b = c;
Console.WriteLine(a);
Console.WriteLine(b);

int a1 = 5;
int b1 = 7;
Console.WriteLine(a1);
Console.WriteLine(b1);
a1 = a1 ^ b1;
b1 = a1 ^ b1;
a1 = a1 ^ b1;
Console.WriteLine(a1);
Console.WriteLine(b1);

//Task 2

int year = 2000;
Console.WriteLine((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0));