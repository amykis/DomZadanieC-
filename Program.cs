// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись  
// исключительно массивами.

// Примеры^
//  ["Hello", "2", "world", "":-)"] → ["2", ":-)"]  
//  ["1234", "1567", "-2", "computer science"] → ["-2"]  
//  ["Russia", "Denmark", "Kazan"] → []


// Очищаем консоль
Console.Clear();

// Вывод массива в консоль
void PrintArray(string[] array){
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]}");
        if (i < array.Length - 1){
            Console.Write($", ");
        }
    }
    Console.Write(" ]");
}

// Проверяем элементы массива длинна которых меньше или равна 3. Считаем количество элементов
int LengthNewArray(string[] array){
    int count = 0;
    for (int i = 0; i < array.Length; i++){
        if (array[i].Length <= 3 ){
            count++;
        }
    }
    return count;
}

// Создаем новый массив из элементов длинна которых меньше или равна 3
string[] ReturnResultArray(int count, string[] arrayString){
    string[] array = new string[count];
    count = 0;
    for (int i = 0; i < arrayString.Length; i++){
        if (arrayString[i].Length <= 3 ){
            array[count] = arrayString[i];
            count++;
        }
    }
    return array;
}

//  Создаем массив
string[] arrayString = new string[] {"Russia", "Denmark", "Kazan"};
PrintArray(arrayString);
int count = LengthNewArray(arrayString);
string[] arrayResultString = ReturnResultArray(count, arrayString);
Console.WriteLine();
PrintArray(arrayResultString);
