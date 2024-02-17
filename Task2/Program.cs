using System.Diagnostics;

int EvenCount(int n)
{
    int even = 0;
    for (int i = n; i > 0; i/=10)
    {
        if(i%2==0) even++;
    }
    return even;
}


int OddCount(int n)
{
    int odd = 0;
    for (int i = n; i > 0; i/=10)
    {
        if(i%2!=0) odd++;
    }
    return odd;
}

int DigitCount(int n)
{
    int digit = 0;
    for (int i = n; i > 0; i/=10)
    {
         digit++;
    }
    return digit;
}

int SumDigit(int n)
{
    int sum = 0;
    for (int i = n; i > 0; i/=10)
    {
         sum+=i%10;
    }
    return sum;
}
int n = int.Parse(Console.ReadLine());

System.Console.WriteLine($"Even: {EvenCount(n)}");
System.Console.WriteLine($"Odd: {OddCount(n)}");
System.Console.WriteLine($"Digit: {DigitCount(n)}");
System.Console.WriteLine($"Sum: {SumDigit(n)}");