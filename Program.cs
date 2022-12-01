// Программа, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

Console.Clear();
Console.WriteLine("Введите массив строк через пробел: ");
string userString = Console.ReadLine();

string[] arrayWords = new string[userString.Split(' ').Length];

arrayWords = userString.Split(' ');

string[] arraySmallWords = StringSmallWords(arrayWords);
Console.WriteLine("Массив из строк Вашего массива, длина которых меньше или равна 3:");
PrintString(arraySmallWords);

string[] StringSmallWords(string[] str) //Метод, формирующий новый массив со строками, длина которых < 4
{
    string[] smallWords = new string[str.Length];
    int count = 0;
    for(int i = 0; i < str.Length; i++)
    {
        if (str[i].Length < 4)          //Предполагается, что пользователь вводит массив из стров без "", 
        {                               //иначе в условии ставим "< 6"
           smallWords[count] = str[i];
           count++;
        }
    }
    return smallWords;
}


void PrintString(string[] str)          //Метод, которые выводит массив на печать
{
    for(int i = 0; i < str.Length; i++)
    {
        Console.Write(str[i] + ' ');
    }
}