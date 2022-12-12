// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу 
// кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

//методы
int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
void WriteTable(int N)
{
    int i = 1;
    while (i <= N)
    {
        Console.Write(i * i * i + ", ");
        i++;
    }
}

int number = EnterData("Введите число: ");
WriteTable(number);
