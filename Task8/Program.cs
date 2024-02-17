   string repeatStr(int n, string s)
    {
        
     String result = ""; 
  for (int i = 1; i < n; i++)
   {
   result +=  s;
  }
  return result;
      }

      int n = int.Parse(Console.ReadLine());
      string s = Convert.ToString(Console.ReadLine());
      System.Console.WriteLine(repeatStr(n,s));


      