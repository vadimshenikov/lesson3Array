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
    static void printArray(int[] arr){
        for(int i = 1; i < arr.GetLength(0); i++){   
            Console.WriteLine(arr[i]);
        }
    }
    static int GetCountElement(int[] arr)
    {
        int count = 0;
        for(int i = 0; i < arr.GetLength(0); i++){
            if(arr[i] >= 20 && arr[i] <= 90){
                count ++;
            }
        }
        return count;
    }
    private static void Main(string[] args)
    {
        Console.WriteLine(GetCountElement(fillArray(10)));
    }
}