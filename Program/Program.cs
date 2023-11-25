// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.


string[] originalArray={"Hello", "2", "world", ":-)", ":-("};
//string[] originalArray={"1234", "1567", "-2", "computer science"};
//string[] originalArray={"Russia", "Denmark", "Kazan"};

int extremeLength=3;

int CountElementInNewArray(string[]array, int length)
{
    int count=0;
    for(int i=0; i<array.Length; i++)
    {
        if(array[i].Length<=length)
        {
            count++;
        } 
    }
    return count;
}

string[] FillArray(string[]array, int length, int count)
{
    int index=0;
    string[] resultArray= new string[count];
    for(int i=0; i<array.Length; i++)
    {
        if(array[i].Length<=length)
        {
            resultArray[index]=array[i];
            index++;
        }
    }
    return resultArray;
}

void PrintArray(string[]array)
{
    for(int i=0; i<array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

PrintArray(FillArray(originalArray, extremeLength, CountElementInNewArray (originalArray, extremeLength)));
