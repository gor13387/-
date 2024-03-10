// Выводим список команд для пользователя
        Commands();

        // Инициализируем массив и запрашиваем команду у пользователя
        string[] array = new string[] { };
        string fromUser = ReadInput("Введите команду: ");

        // Обработка команды пользователя и заполнение массива соответствующими данными
        switch (fromUser)
        {
            case "1":
                array = new string[] { "Hello", "2", "world", ":-)" };
                break;
            case "2":
                array = new string[] { "1234", "1567", "-2", "computer science" };
                break;
            case "3":
                array = new string[] { "Russia", "Denmark", "Kazan" };
                break;
            default:
                Console.WriteLine($"{fromUser} - Такой команды нет");
                break;
        }

        // Подсчет количества элементов, удовлетворяющих условию длины <= 3
        int lenNewArray = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3) lenNewArray++;
        }

        // Создание нового массива и заполнение его элементами, удовлетворяющими условию
        string[] newArray = new string[lenNewArray];
        int idx = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                newArray[idx] = array[i];
                idx++;
            }
        }

        


