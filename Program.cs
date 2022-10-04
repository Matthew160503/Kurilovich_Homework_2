// Задание 10
/*
Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine()!);
if ((num >= 100) && (num <1000)){
    int num1 = num / 100;
    int num3 = num % 10; 
    int result = (num - num1 * 100 - num3) / 10;
    Console.WriteLine($"Вторая цифра заданного числа равна {result}");       
} else {
    Console.WriteLine("Ввели неверное число!");
}
*/

//Задание 13
/*
int num = new Random().Next(100000);
Console.WriteLine($"Рандомное число = {num}");
if (num < 100){
    Console.WriteLine("Третьей цифры в числе нет");    
} else if ((num >= 100) && (num <1000)){
    int res = num % 10;
    Console.WriteLine($"Третья цифра заданного числа = {res}");        
} else if ((num >= 1000) && (num <10000)){
    int res = (num % 100) / 10;
    Console.WriteLine($"Третья цифра заданного числа = {res}");        
} else if ((num >= 10000) && (num <100000)){
    int res = (num % 1000) / 100;
    Console.WriteLine($"Третья цифра заданного числа = {res}");        
}
*/

// Задание 15
/*
Console.Write("Введите день недели: ");
int day = int.Parse(Console.ReadLine()!);
if ((day < 1) || (day > 7)){
    Console.Write("Введён несуществующий день недели!");    
} else {
    switch (day)
    {
        case 1 : Console.WriteLine("Понедельник, рабочий день :(");
        break;
        case 2 : Console.WriteLine("Вторник, рабочий день :(");
        break;
        case 3 : Console.WriteLine("Среда, рабочий день :(");
        break;
        case 4 : Console.WriteLine("Четверг, рабочий день :(");
        break;
        case 5 : Console.WriteLine("Пятница, рабочий день :(");
        break;
        case 6 : Console.WriteLine("Суббота, ура, выходной :)");
        break;
        case 7 : Console.WriteLine("Воскресение, ура, выходной :)");
        break;
        
    }
}
*/