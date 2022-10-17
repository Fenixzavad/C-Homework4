// Напишите программу, которая задаёт массив из 8 случайных элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 7, 8

 int [] WriteArray()
 {
 int [] array = new int [8];
 
 for(int i = 0; i < array.Length; i++)
 {
    array[i] = new Random().Next(0,30);
    System.Console.Write($" {array [i]}");
 }
 return array;
 }

int [] answer = WriteArray();
  