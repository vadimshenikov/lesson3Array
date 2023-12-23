using System;
internal class Program
{
    static int[] fillArray(int countElement = 10)
    {
        int[] arrayFill = new int[countElement];
        Random rand = new Random();
        for (int i = 1; i < countElement; i++)
            {
                arrayFill[i] = rand.Next(0, 100);
            }
        return arrayFill;
    }
    static double[] fillArrayDouble(int countElement = 10)
    {
        double[] arrayFill = new double[countElement];
        Random rand = new Random();
        for (int i = 0; i < countElement; i++)
            {
                arrayFill[i] = rand.NextDouble() * 100;
            }
        return arrayFill;
    }
    
    static void printArrayDouble(double[] arr)
    {
        for(int i = 0; i < arr.GetLength(0); i++)
        {   
            Console.WriteLine(arr[i]);
        }
    }

    static double getMaxMinElementDouble(double[] arr, bool maxMin) //maxMin==true -это поиск максимального, maxMin==false -это поиск минимального
    {
        double element = arr[0];
        for(int i = 1; i < arr.GetLength(0); i++)
        {   
            if(element < arr[i] && maxMin == true) //поиск максимального значения
            {
                element = arr[i];
            }
            else if(element > arr[i] && maxMin == false) //поиск минимального значения
            {
                element = arr[i];
            }
        }
        return element;
    }
    static void printArray(int[] arr){
        for(int i = 0; i < arr.GetLength(0); i++){   
            Console.WriteLine(arr[i]);
        }
    }
    static int GetCountElement(int[] arr) //расчет задачи 1
    {
        int count = 0;
        for(int i = 0; i < arr.GetLength(0); i++){
            if(arr[i] >= 20 && arr[i] <= 90){
                count ++;
            }
        }
        return count;
    }

    static int GetCountEvenNum(int[] arr){ //расчет задачи 2
        int count = 0;
        for(int i = 0; i < arr.GetLength(0); i++){
            if(arr[i] % 2 == 0){ //проверка на четность числа
                count++;
            }
        }
        return count;
    }
    private static void Main(string[] args)
    {
        //Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, 
        //значения которых лежат в отрезке [20,90].
        Console.WriteLine(GetCountElement(fillArray(10)));
        //Задача 2: Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.
        Console.WriteLine(GetCountEvenNum(fillArray(10)));
        //Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. 
        //Найдите разницу между максимальным и минимальным элементов массива.
        
 
        double[] arr = fillArrayDouble();
        printArrayDouble(arr);
        Console.WriteLine("---");
        Console.WriteLine(getMaxMinElementDouble(arr, true));
        Console.WriteLine(getMaxMinElementDouble(arr, false));
    }
}