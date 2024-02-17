
void IncrementArrayElements(ref int[] arr, ref int n)
{

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] += n;
    }

}
System.Console.Write("Write Size your Massive : ");
int c = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Write Number for Add : ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Write Element for Massive : ");
int[] arr = new int[c] ;
for (int i = 0; i < arr.Length; i++)
{
    arr[i]= Convert.ToInt32(Console.ReadLine()); 
}
IncrementArrayElements(ref arr, ref n);

foreach (var it in arr)
{
    System.Console.Write(it + " ");
}
