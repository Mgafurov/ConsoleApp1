/*using System;

class Program
{
    static void Main()
    {
        string fullName = "Гафуров Малик";
        int age = 21;
        string email = "poseydon100500@gmail.com";
        double programmerScore = 55.5;
        double mathScore = 50.5;
        double physicScore = 54.3;
        Console.WriteLine($"ФИО: {fullName}, \nВозраст: {age}, \nEmail:{email}, \nБаллы по программированию: {programmerScore}, \nБаллы по математике: {mathScore}, \nБаллы по физике: {physicScore}");
        Console.ReadKey();
    }
}*/

using System;

class Program
{
    static void Main()
    {
        string fullName = "Гафуров Малик";
        int age = 21;
        string email = "poseydon100500@gmail.com";
        double programmerScore = 55.5;
        double mathScore = 50.5;
        double physicScore = 54.3;

        double totalScore = programmerScore + mathScore + physicScore;
        double averageScore = totalScore / 3;
        Console.WriteLine($"ФИО: {fullName}.\nВозраст: {age}. \nEmail: {email}. \nБаллы по программированию: {programmerScore}. \nБаллы по математике: {mathScore}. \nБаллы по физике: {physicScore}. \nСумма всех баллов: {totalScore}. \nСредний балл: {averageScore}");
        Console.ReadKey();
    }
}