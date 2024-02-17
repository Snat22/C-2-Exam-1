          
         int Sum(int num)
        {
            if (num < 10) return num;
            else return num % 10 + Sum(num / 10);
        }
            System.Console.Write("sumDigit(");
            int num = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine();
            Console.WriteLine(+Sum(num));
