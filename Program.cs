// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// Примеры:
// ["Hello", "2", "world", ":-)"] → [“2”, “:-)”]
// ["1234", "1567", "-2", "computer science"] → [“-2”]
// ["Russia", "Denmark", "Kazan"] → []

string [] array = {"Hello", "2", "world", ":-)"};
int count = 0;


PrintArray(array);
LengthNewArray(array);
string [] arrayNew = new string [count];
RemakeArray(array, arrayNew);
PrintArray(arrayNew);


void PrintArray (string [] array)
{
    string sep = " ";
    Console.Write ("[");
    for (int i =0; i<array.Length; i++)
    {
        Console.Write(sep + array[i]);
        sep = ", ";
    }
    Console.WriteLine($" ]");
}

int LengthNewArray(string [] array)
{
    
    for (int i =0; i<array.Length; i++)
    {
        if (array[i].Length<=3)
        {
            count++;
        }
    }
    return count;
}

void RemakeArray(string [] array,string [] arrayNew)
{
    
    int j =0;
    for (int i =0; i<array.Length; i++)
    {
        if (array[i].Length<=3)
        {
            arrayNew[j] = array[i];
            j++;
        }
    }
}