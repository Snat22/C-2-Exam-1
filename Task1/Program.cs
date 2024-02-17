            System.Console.Write("Write size for massive: ");
            int n = int.Parse(Console.ReadLine());
            int [] arr = new int[n];
            System.Console.Write("Write Element for massive: ");
            for (int i = 0; i < n; i++) {
                  arr[i] = Convert.ToInt32(Console.ReadLine());
              }
              System.Console.WriteLine("Write index for remove element in massive:");
            int k = int.Parse(Console.ReadLine());
            for (int i = k; i < arr.Length - 1; i++) {
            arr[i] = arr[i + 1];
            }
            for (int i = 0; i < arr.Length - 1; i++) {
            Console.Write(arr[i] + " "); 
            }