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

//  Создаем массив
string[] arrayString = new string[] {"Hello", "2", "world", ":-)"};
PrintArray(arrayString);

int count = LengthNewArray(arrayString);
Console.WriteLine();
Console.Write(count);

