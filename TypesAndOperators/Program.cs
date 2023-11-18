// See https://aka.ms/new-console-template for more information
//========6 LESSON==========
/*
    //This message is murrr

    Console.WriteLine("Hello, World!");

        Console.WriteLine("It's a nice day!");

        const int MINUTES_IN_HOUR = 60;

    string name;
    name = "Martin";
    Console.WriteLine(name);

    name = "Martin2";
    Console.WriteLine(name);

    //ЛИТЕРАЛЫ
    //логические
    Console.WriteLine(true);
    Console.WriteLine(false);
    //целочисленные
    Console.WriteLine(-10);
    Console.WriteLine(0);
    Console.WriteLine(10);
    Console.WriteLine(0b0100100);
    //вещественные
    Console.WriteLine(1.24);
    Console.WriteLine(1.24F); //число с дробной точкой
    //символьные (только один символ)
    Console.WriteLine('H');
    //null
    //Console.WriteLine(null);

    Console.WriteLine("It's a \t nice day!"); //добавляет знак табуляции
    Console.WriteLine("It's a \n nice day!"); //перевод на новую строчку
    Console.WriteLine("It's a \\ nice day!"); //чтобы вывести слеш, нужно поставить два

    bool flag = true;
    flag = false;

    sbyte sb = 100;

    float a = 3.14F;
    float a1 = 3.14f;

    decimal c = 1005.5M;
    decimal c1 = 1005.5m;

    //неявная типизация
    var d = 10;
    var d1 = 10.2F;
    var d2 = 'D';

    int j;
    j = 20;

    var j1 = 20;
    
    Console.WriteLine("Добро пожаловать в C#");
    Console.Write("Надеюсь, Вы ");
    Console.Write("постигнете нюансы в C#! \n");
    Console.WriteLine("И все будет супер гуд!");
    
    int j;
    j = 20;

    Console.WriteLine("J = " + j);

    string name = "Tom";
    int age = 21;
    double height = 1.7;
    Console.WriteLine($"Имя: {name} Возраст: {age} Рост: {height}");
    Console.WriteLine("Имя: {0} Возраст: {2} Рост: {1}", name, height, age);

    string tst = "djfjf";
    tst = null;

    Console.WriteLine("Введите свое имечко:");
    string? name = Console.ReadLine();
    Console.WriteLine($"Ваше имечко: {name}");

    Console.WriteLine("Введите свой возраст:");
    string? age_str = Console.ReadLine();
    int age = Convert.ToInt32(age_str);
    Console.WriteLine($"Ваш возраст: {age}");
*/
//=============7 LESSON==================
/*
double x = 10.0;
double z = x % 4;
Console.WriteLine($"Результат: {z}");

int x1 = 5;
int z1 = ++x1;
Console.WriteLine($"{x1} - {z1}");

int a = 8;
int b = 6;
int c = a += b -= 5;
Console.WriteLine(c);

//Преобразование базовых типов данных

byte a = 4;
int b = a + 70;
Console.WriteLine(b);

byte a = 4;
byte b = a + 70;
Console.WriteLine(b); //ошибка, потому что 70 считается int


byte a = 4;
byte result = (byte)(a + 70);
Console.WriteLine(result);

bool c;
int a = 10;
int b = 20;
c = a == b;
Console.WriteLine(c);

bool x1 = (5 > 6) | (4 < 6); //логическое сложение  (ИЛИ)
Console.WriteLine(x1);

bool x2 = (5 > 6) & (4 < 6); //логическое умножение  (И)
Console.WriteLine(x2);

bool a = true;
bool b = !a;
Console.WriteLine(b); //логическое отрицание

if (условие)
{
}
else
{
}
*/

/*
//Решение нашей задачи
//Подготовка данных
bool isWhiteBreadFresh = true;
ushort whiteBreadPrice = 150;
ushort butterPrice = 230;
ushort milkPrice = 170;
float milkFatPercentage = 1.2F;
ushort icecreamPrice = 350;

Console.Write("Введите начальную сумму: ");
string? sumString = Console.ReadLine();
short sum = Convert.ToInt16(sumString);

if (sum > 0)
{
    if (!isWhiteBreadFresh)
    {
        Console.WriteLine("Батон не свежий");
    }
    else if (sum >= whiteBreadPrice)
    {
        sum = Convert.ToInt16(sum - whiteBreadPrice);
        Console.WriteLine($"Купили свежий батон по цене {whiteBreadPrice}");
    }
    else
    {
        Console.WriteLine("На батон денег не хватает");
    }

    sum = (short)(sum - butterPrice);

    if (milkFatPercentage == 1.2F)
    {
        sum = Convert.ToInt16(sum - milkPrice);
    }

    if (sum >= icecreamPrice)
    {
        sum = Convert.ToInt16(sum - icecreamPrice);
    }

    Console.WriteLine($"Остаток суммы: {sum}");
}
else
{
    Console.WriteLine("Сумма не может быть меньше 0");
}
*/
    //============конец задачи про магазин=============

/*
bool a = true;
bool b = false;
string name1 = "Tom1";
string name2 = "Tom2";

if ( !(name1.Equals(name2) & b))
{
    Console.WriteLine("Верно");
}
else
{
    Console.WriteLine("Неверно");
}


int x = 10;
int y = 20;
int z;
if (x < y)
{
    z = x + y;
}
else
{
    z = x - y;
}
Console.WriteLine(z);

z = x < y ? x + y : x - y; //если первое true, то выполняет блок 2, если false, то блок 3
Console.WriteLine(z);



int x = 6;
if (x == 1)
{
    Console.WriteLine("1");
} else if (x == 2)
{
    Console.WriteLine("2");
}
else
{
    Console.WriteLine("не соответствует условиям");
}

switch (x)
{
    case 1:
        Console.WriteLine("1");
        break;
    case 2:
        Console.WriteLine("2");
        break;
    default: //если ни один из описанных кейсов не подошел
        Console.WriteLine("не соответствует условиям");
        break; //конец выполнения этого кейса
}

string name = "Tom";
switch (name)
{
    case "Alex":
        Console.WriteLine("Alex");
        break;
    default: //если ни один из описанных кейсов не подошел
        Console.WriteLine("не соответствует условиям");
        break; //конец выполнения этого кейса
}


//для boolean switch практически не используется, т.к. два варианта всего и нет смысла делать эту конструкцию


Console.WriteLine(DoOperation(6));

int DoOperation(int x)
{
    switch (x)
    {
        case 1:
            return 1;
        case 2:
            return 2;
        default:
            return 0; //для этого метода всегда должен быть return, поэтому дефолтное значение обязательно
    }
}

int DoOperation1(int x)
{
    int result = x switch
    {
        1 => 1,
        2 => 2,
        _ => 0
    };
    

    return result;
}

int DoOperation2(int x) => x switch
{
    1 => 1,
    2 => 2,
    _ => 0
};
*/