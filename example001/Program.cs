﻿void CheckKoord(int x, int y)
{
    if (x > 0 && y > 0) Console.WriteLine("это четверть №1");
    else if (x > 0 && y < 0) Console.WriteLine("это четверть №2");
    else if (x < 0 && y > 0) Console.WriteLine("это четверть №3");
    else if (x < 0 && y < 0) Console.WriteLine("это четверть №4");
    else Console.WriteLine("точка находится на координатной оси: ");
}


string CheckKoord2(int x, int y)
{
    string res;
    if (x > 0 && y > 0) res = "это четверть №1";
    else if (x > 0 && y < 0) res ="это четверть №2";         
    else if (x < 0 && y > 0) res = "это четверть №3";
    else if (x < 0 && y < 0) res = "это четверть №4";
    else res = "точка находится на координатной оси: ";
    return res;
}



try
{
    Console.WriteLine("Введите координату x");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите координату y");
    int y = Convert.ToInt32(Console.ReadLine());
    CheckKoord(x, y); 
    Console.WriteLine(CheckKoord2(x, y));
}
catch
{
    Console.WriteLine("Надо было вводить именно целые числа!");

}