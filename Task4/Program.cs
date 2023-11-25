Console.Write("Enter even number N: ");
int N = Convert.ToInt32(Console.ReadLine());
/*
int copyN = N;

int count = 0;

while(copyN > 0)
{
      copyN /= 10;
      count++;
}

int d = 1;
for(int i = 0; i < count -1; i++)
      d *= 10;
while (N > 9)
{
      Console.Write(N / d + ",");
      N %= d;
      d/=10;
}
Console.Write(N);*/

string str = N.ToString();
char[] c = str.ToCharArray();
System.Console.WriteLine(string.Join(", ", c));

//Console.WriteLine(N.ToString().Length);
