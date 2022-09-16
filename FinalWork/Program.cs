/*Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами. */

string[] arrayFirst =  {"hello", "2", "world", ":-)", "5"};
int countFirst = CountStringLessThreeChar(arrayFirst);

string[] arraySecond = {"1234", "1567", "-2", "computer science", "gold king"};
int countSecond  = CountStringLessThreeChar(arraySecond);

string[] arrayThird = {"Russia", "Denmark", "Belarus", "Kazan"};
int countThird = CountStringLessThreeChar(arrayThird);

string[] resultFirst =  FillResultArray(arrayFirst,countFirst);
string[] resultSecond = FillResultArray(arraySecond,countSecond);
string[] resultThird = FillResultArray(arrayThird, countThird);

PrintArray(resultFirst);
PrintArray(resultSecond);
PrintArray(resultThird);

void PrintArray(string[] array) 
    {

        for (int i = 0; i < array.Length; i++)
            {
                if (i != array.Length - 1) Console.Write($"{array[i]}, ");
                else Console.Write($"{array[i]}.");
            }
        Console.WriteLine();
    }

int CountStringLessThreeChar(string[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length < 4) count++;
            }
        return count;
    }

string[] FillResultArray(string[] array, int count)
    {
        string[] result = new string[count];
        for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length < 4)
                    {
                        result[result.Length - count] = array[i];
                        count--;
                    }
            }
        return result;
    }

