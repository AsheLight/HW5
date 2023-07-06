//Task 34

Random random = new Random();
        int[] numbers = new int[10]; 

        
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(100, 1000); 
        }

        int evenCount = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                evenCount++;
            }
        }

 Console.WriteLine("Количество четных чисел в массиве: " + evenCount);

//Task 36
Random random = new Random();

       
        int size = 10;

        
        int[] array = new int[size];

       
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(100); 
        }

        Console.WriteLine("Массив:");
        for (int i = 0; i < size; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();


        int sum = 0;
        for (int i = 1; i < size; i += 2)
        {
            sum += array[i];
        }


        Console.WriteLine("Сумма элементов на нечетных позициях: " + sum);

        Console.ReadLine();
    
//Task 38

        double[] numbers = { 1.2, 3.4, 5.6, 7.8, 9.0 };

        
        double min = numbers[0];
        double max = numbers[0];

        
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }

            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

       
        double diff = max - min;

        
        Console.WriteLine("Разница между максимальным и минимальным элементами: " + diff);
    