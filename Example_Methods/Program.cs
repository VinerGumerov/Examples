/*
//Дан текст. В тексте все пробелы нужно заменить черточками,
//маленькие буквы "к" заменить большими "К",
//а большие "С" заменить маленькими "с".

string text = "-Я думаю, - сказал князь, улыбаясь,- что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы, вы дадите мне чаю?";

//string s ="qwerty"
//           0123
// s[3]  // r

string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'c', 'C');
Console.WriteLine(newText);
Console.WriteLine();
*/

int[] arr = {1,5,4,3,2,6,7,1,1};
void printArray(int[] array)
{
    int count = array.Length;


    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
} 

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i+1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

printArray(arr);
SelectionSort(arr);
printArray(arr);