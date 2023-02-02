// Задача: Написать программу, которая из имеющегося массива строк
// формирует массив из строк, длинна которых меньше либо равна 3 
// символа. Первоначальный массив можно ввести с клавиатуры, либо 
//задать на старте выполнения алгоритма. При решении не 
//рекомендуется пользоваться кол лекциями, лучше обойтись массивами.
//["htllo", "2", "world", ":-"] -> ["2",":-"]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


Console.Write("Введите количество элементов массива: ");
int elementsCount = int.Parse(Console.ReadLine());
string[] myArray = new string[elementsCount];
string[] newArray = new string[myArray.Length];

void Main()
{
  for (int i = 0; i < myArray.Length; i++)
  {
    Console.Write($"Введите элемент массива {i}:  ");
    myArray[i] = Console.ReadLine();
  }
  Console.Write("Вывод массива: ");
}

void SecondArray(string[] myArray, string[] newArray)
{
  int count = 0;
  for (int i = 0; i < myArray.Length; i++)
  {
    if (myArray[i].Length <= 3)
    {
      newArray[count] = myArray[i];
      count++;
    }
  }
  System.Console.Write("Вывод нового массива:\t");
}

void PrintArray(string[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write($"{array[i]} ");
  }
  Console.WriteLine();
  Console.WriteLine();
}
Main();
PrintArray(myArray);
SecondArray(myArray, newArray);
PrintArray(newArray);
