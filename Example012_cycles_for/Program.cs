// Циклы не толко While есть еще for

// string Method4(int count, string text)
// {
//     string result = string.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;    
//     }
//     return result;
// }

// string res = Method4(10, "Rus-");

// Console.WriteLine(res);

//Использование цикла в цикле

// Таблица умножения

/* for (int i = 2; i <=10; i++)
{
    for (int j = 2; j <=10 ; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}
*/
//==== Работа с текстом
//Дан текст. В тексте нужно все пробелы заменить черточками, маленькие буквы "к" заменить большими "К", а большие "C" маленькими "c"
/*
string text = "– Я думаю, – сказать князь, улыбаясь, – что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";
// string s = "qwerty"
//             01234
//s[3] //

string Replace(string text, char oldValue, char newValue)
{
  string result = String.Empty;

  int length = text.Length;

  for (int i = 0; i < length; i++)
  {
    if (text[i] == oldValue) result = result + $"{newValue}";
    else result = result + $"{text[i]}";
   
  }


  return result;
}

string newText = Replace(text,' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText,'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText,'с', 'С');
Console.WriteLine(newText);
*/
