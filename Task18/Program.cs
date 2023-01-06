/*Задача 18: Напишите программу, которая по
заданному номеру четверти, показывает диапазон
возможных координат точек в этой четверти (x и y).*/


/*Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(x, y);
string result = quarter > 0
                ? $"Указанные координаты соответствуют четверти -> {quarter}"
                : "Введены некорректные координаты";
Console.WriteLine(result);
int Quarter(int xc, int yc)
{
    if (xc > 0 && yc > 0) return 1;       //x>0 ; y>0
    if (xc < 0 && yc > 0) return 2;       //x<0 ; y>0
    if (xc < 0 && yc < 0) return 3;       //x<0 ; y<0
    if (xc > 0 && yc < 0) return 4;       //x>0 ; y<0
    return 0;
}*/


Console.WriteLine("Введите четверть");
string quaret = Console.ReadLine();
string quaret1="x>0 ; y>0";
string quaret2="x>0 ; y>0";
string quaret3="x>0 ; y>0";
string quaret4="x>0 ; y>0";

string result = Coordinates(quaret);          
Console.WriteLine(result);

string Coordinates(string quaretX)
{
    if(quaretX=="1") return quaret1;
    if(quaretX=="2") return quaret2;
    if(quaretX=="3") return quaret3;
    if(quaretX=="4") return quaret4;
    return "введите корректоно номер четверти";
}

