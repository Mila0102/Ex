//Вид 1, ничего не возвращают и ничего не принимают
void Method1()
{
    Console.WriteLine("Автор...");
}
//как вызываются такого рода методы
Method1();

//Вид 2, ничего не возвращают, но могут принимать 
//какие-то аргументы
void Method2 (string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения");
void Method21 (string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++; //инкримент-увеличение счетчика на 1
        //декримент - уменьшение на 1
    }
}
Method21(msg: "Текст", 4); //сколько раз текст должен 
//появиться на экране, какому аргументу будет
//присвоено значение
Method21(count: 4, msg: "новый текст");

//Вид 3, методы, которые что-то возвращают, но
//ничего не принимают
int Method3()
{
    return DateTime.Year;
}

int year = Method3();//сюда положен результат работы
//этого метода
Console.WriteLine(year);

//Вид 4, методы, которые что-то принимают и 
//что-то возвращают
string Method4(int count, string text) //строка С
//друг за другом компоновать count раз
{
int i = 0;
string result = String.Empty ;   //переменная, в которую мы
//будет заносить результат

while (i < count)
{
    result = result + text
    i++;
}
return result;

}
string res = Method4(10, "asdf"); //последовательность
//текста будет 10 раз
Console.WriteLine(res);


