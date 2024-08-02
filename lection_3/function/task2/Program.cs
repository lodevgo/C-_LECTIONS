// int value = 10;
// int Square(int value)
// {
//     int result = value * value;
//     return result:
// }

// int a = 5; 
// int b = 10;
// int c = 15; 
// int d = 2;
// int result = (a * b) / (c + d);
// System.Console.WriteLine(result);

// при создании функции в скобках параметры
double CalculateFormula(int a, int b, int c, int d)
{
    // в данном случае нужно чтобы хотя бы один из операндов имел вещественный тип данных
    double numenator = a * b;
    int denomenator = c + d;
    double result = numenator / denomenator;
    return result;
}

// синтаксис запуска функции
// имя функции и в скобках передаваемые аргументы 
// если функция не имеет входных параметров, то просто будут пустые скобки
// при запуске функции в скобках аргументы

double result = CalculateFormula(1, 2, 3, 4);

System.Console.WriteLine(result);


