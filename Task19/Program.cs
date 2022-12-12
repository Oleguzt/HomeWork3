// Напишите программу, которая принимает на вход пятизначное число и 
//проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

//методы
string EnterData(string text)
{
    Console.Write(text);
    string number = Console.ReadLine();
    return number;
}
void IsPalindrom(string number)
{
    if (number.Length == 5)
    {
        if(number[0] == number[4] & number[1] == number[3])
        {
            Console.WriteLine($"Число {number} является палиндромом.");
        }
        else{Console.WriteLine($"Число {number} не является палиндромом.");}
    }
    
    else{Console.WriteLine($"Число {number} не является пятизначным.");}
    
}

string palindrom = string.Empty;
//вывод
palindrom = EnterData("Введите пятизначное число: ");
IsPalindrom(palindrom);

