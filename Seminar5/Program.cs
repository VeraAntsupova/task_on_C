// // Задача 37. Найдите произведение пар числе в одномерном массиве. 
// Парой считаем первый и послдений элемент, второй и предпоследний и тд.
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array [i] = new Random().Next(0, 11);
}


void ReleaseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2 + array.Length % 2; i++)
    Console.WriteLine($"{array[i] * array[array.Length - i - 1]} ");      
}        
    

    Console.Clear();
    Console.Write("Введите кол-во элементов массива: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[n];
    InputArray(array);
    Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]");
    ReleaseArray(array);
   
           
 