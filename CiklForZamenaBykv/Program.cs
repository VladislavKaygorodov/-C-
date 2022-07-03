//* Работа с текстом
//ДАн текст в нем нужно все пробелы заменить на черточки
//маленькие буквы "к" заменить большими К
//большие С заменить на маленькие с 

string text = "-Я думаю, сказал князь, улыбаясь, - что,"
            +"Ежели бы вас послали вместо нашего милого Винценгероде,"
            +"вы бы взяли приступом согласие прусского короля."
            +"Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty; //инициализация пустой строки
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '_');

Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(text, 'к', 'К');

Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(text, 'с', 'С');

Console.WriteLine(newText);
Console.WriteLine();
