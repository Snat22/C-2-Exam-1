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
System.Console.WriteLine($"The sum of the digits of the number {n} is : {SumDigit(n)}");