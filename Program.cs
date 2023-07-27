
using System;
using static System.Console;
Clear();

string[] array1 = {"hello", "2", "world", ":-)"};
string[] array2 = {"1234", "1567", "-2", "computer science"};
string[] array3 = {"Russia", "Denmark", "Kazan"};

string[][] matrix = new string[][] {array1, array2, array3};


for (int i = 0; i < matrix.Length; i++)
{
    Write("[");
    PrintArray(matrix[i]);
    Write("]");

    Write(" -> ");

    Write("[");
    int length_array = GetLengthArray(GetArrayLimitLength(matrix[i]));
    PrintArray(GetResArray(GetArrayLimitLength(matrix[i]), length_array));
    WriteLine("]");
}


string[] GetArrayLimitLength(string[] arr)
{
    string[] res = new string[arr.Length];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
            {
                res[j] = arr[i];
                j++;
            }
    }
    return res;
}


int GetLengthArray(string[] arr)
{
    int cnt = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] != null) cnt++;
    }
    return cnt;
}


string[] GetResArray(string[] arr, int length)
{
    string[] res = new string[length];
    for (int i = 0; i < length; i++) 
    {
        res[i] = arr[i];
    }
    return res;
}


void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Write($"{arr[i]}");
        if (i != arr.Length - 1) Write(", ");
    }
}


// Дополнительный вариант решения задачи
// string[] ChangeArray(string[] array)
// {
    //создаем экземпляр класса List<string>
    // List<string> list = new List<string>();
    // проходимся по list   
    // foreach (string s in array)
    // {
        // if (s.Length<=3)
        // {
            //добвляем в list s
            // list.Add(s);
        // }
    // }
    //возвращем string[] из list
    // return list.ToArray();
// }


// void ShowArray(string[] array)
// {
    // foreach (string a in array)
    // {
        // Console.Write($"\"{a}\" ");
    // }
// }


// string[] people = new string[] { "Hello", "2", "world", ":-)" };

// string[] aasd = ChangeArray(people);

// ShowArray(aasd);