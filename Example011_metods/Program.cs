// Виды методов
// Вид 1

/* void Method1()
{
    Console.WriteLine("Автор ...");
}
Method1(); */

// Вид 2

/* void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2("Текст сообщения");
Method2(msg:"Текст сообщения");
 */
/*
void Method21(string msg, int count)
{
   int i = 0;
   while (i < count)
   {
       Console.WriteLine(msg);
       i++;
   }
}
//Method21(msg:"Текст",count:4);
Method21(count:4, msg:"Новый Текст");
*/
//Вид 3 что-то возвращает но не принимает
/*
int Method3()
{
    return DateTime.Now.Year;


}
int year = Method3();
Console.WriteLine(year);
*/
//Вид 4

/* string Method4(int count, string text)
{
    int i = 0;
    string result = string.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }

    return result;
}


string res = Method4(10, "Rus-");

Console.WriteLine(res);
 */

 


