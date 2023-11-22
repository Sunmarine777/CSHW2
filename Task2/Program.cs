Console.WriteLine("Enter number <> 0 for X: ");
int X = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number <> 0 for Y: ");
int Y = Convert.ToInt32(Console.ReadLine());

if (X > 0 && Y > 0)
      {Console.WriteLine("Quoter 1");
return;}

if (X < 0 && Y > 0)
      {Console.WriteLine("Quater 2");
return;}

if (X < 0 && Y < 0)
      {Console.WriteLine("Quater 3");
return;}

else
      Console.WriteLine("Quater 4");