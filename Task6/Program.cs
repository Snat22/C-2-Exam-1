void Swap(ref int a, ref int b)
{
    int c = 0;
    c = a;
    a = b;
    b = c;

    System.Console.WriteLine($"{a} {b}"); 
}
System.Console.WriteLine("Write 2 number for refence : ");
System.Console.Write("First Number: ");
int a = int.Parse(Console.ReadLine());
System.Console.Write("Second Number: ");
int b = int.Parse(Console.ReadLine());
System.Console.WriteLine();
System.Console.WriteLine("Number After Refenrece : ");
Swap(ref a ,ref  b);
// Raqamxoi badi Refrence kardan
System.Console.Write(a);
System.Console.Write(" ");
System.Console.WriteLine(b);