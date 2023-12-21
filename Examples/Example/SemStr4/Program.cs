// Считать строку с консоли, состоящую из латинских 
// букв в нижнем регистре. Выяснить, сколько среди 
// введённых букв гласных.

string GetString()
{
Console.Write("Введите строку:  ");
string str = Console.ReadLine();
return str;
}

int CountGlas(string str)
{
    int count = 0;
    for (int i = 0; i < str.Length; i++)
     {
      if(IsVowel(str[i]))
       {
        count++;
       }
     }
     return count;
}

bool IsVowel(char c)
{
    string vowel = "aeouy";
    return vowel.Contains(c);//возвращает bool если элемент есть
    
}
string str = GetString();
int vowel = CountGlas(str);
Console.WriteLine($"Количество гласных {vowel}");
