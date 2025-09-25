
        List<int> list = new List<int>() { 1, 0, 5, -4, 5, 10, -80, 24, 0, -4, 100, 24, 45, 6, -1 };


        int max = list[0];
        for (int i = 1; i < list.Count; i++)
        {
            if (list[i] > max)
            {
                max = list[i];
            }
        }
        Console.WriteLine("Максимум = " + max);

        for (int i = 0; i < list.Count; i++)
        {
            for (int j = list.Count - 1; j > i; j--)
            {
                if (list[i] == list[j])
                {
                    list.RemoveAt(j);
                }
            }
        }

        Console.WriteLine("После удаления дубликатов:");
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        for (int i = 0; i < list.Count - 1; i++)
        {
            for (int j = 0; j < list.Count - 1 - i; j++)
            {
                if (list[j] > list[j + 1])
                {
                    int t = list[j];
                    list[j] = list[j + 1];
                    list[j + 1] = t;
                }
            }
        }

        Console.WriteLine("После сортировки:");
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] < 0)
            {
                list[i] = 0;
            }
        }

        Console.WriteLine("После замены :");
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
    
