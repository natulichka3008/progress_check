﻿Console.Write("введите количество элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());
string[] stringArray = new string[m];
void array(string[] stringArray)
{
  for (int i = 0; i < stringArray.Length; i++)
  {
    Console.WriteLine($"введите {i + 1}элеиент массива");
    stringArray[i] = Console.ReadLine()!;
  }
}
string[] symbol(string[] stringArray)
{
  int n = 0;
  for (int i = 0; i < stringArray.Length; i++)
  {
    if (stringArray[i].Length <= 3)
      n++;
  }
  string[] result = new string[n];
  int j = 0;
  for (int i = 0; i < stringArray.Length; i++)
  {
    if (stringArray[i].Length <= 3)
    {
      result[j] = stringArray[i];
      j++;
    }
  }
  return result;
}
void printA(string[] stringArray)
{
  Console.Write("[");
  for (int i = 0; i < stringArray.Length; i++)
  {
    Console.Write($"{stringArray[i]}");
    Console.Write("  ");
  }
  Console.Write("]");
}
array(stringArray);
printA(symbol(stringArray));
