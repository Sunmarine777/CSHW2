Console.WriteLine("Enter any integer number from 10 to 99: ");
int number = Convert.ToInt32(Console.ReadLine());
int a = number / 10;
int b = number % 10;

if (number >= 10 && number <= 99 && a > b)
    { 
      Console.WriteLine(a);
    }
 
if (number >= 10 && number <= 99 && a < b)
    { 
      Console.WriteLine(b);
    }
    
if (number >= 10 && number <= 99 && a == b)
    { 
      Console.WriteLine(a);
    }
else
Console.WriteLine("Not match conditions");