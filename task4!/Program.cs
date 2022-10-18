// Напишите программу, которая из массива случайных чисел. Ищет второй максимум (число меньше максимального элемента, но больше всех остальных). Постарайтесь сделать одним циклом
// [1, 3, 5, 6, 6, 4] -> 5

 int [] WriteArray()
 {
 int [] array = new int [6];
 
 for(int i = 0; i < array.Length; i++)
 {
    array[i] = new Random().Next(0,10);
    System.Console.Write($" {array [i]}");
 }
 return array;
 }

int [] answer = WriteArray();

int SecondMax(int [] array)
{   int max= array[0];
    int max2= array [1];
    for(int i=1; i < array.Length;)
    {
        if(max > array [1])
        {
            max2 = array[1];
        }
        else 
        {
            max=max2;
            max = array[1];
            i++;
        }
        if (max < array[i])
        {
            max2 = max;
            max = array[i];
        }
        else
        {
            array [i] = max2;
        }
    }
    return max2;

}
int value =SecondMax(array[i]);
System.Console.WriteLine($"Второй максимум алгоритма {value}");