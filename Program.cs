// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.WriteLine ("Введите координату Х");
int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine (x);

Console.WriteLine ("Введите координату Y");
int y = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine (y);

if (x>0&& y>0)
{
    Console.WriteLine ("Точка с координатами " + (x) + ";" + (y) +  " находится в первой четвери");
}
if (x>0&& y<0)
{
    Console.WriteLine ("Точка с координатами " + (x) + ";" + (y) +  " находится в четвертой четвери");
}
if (x<0&& y>0)
{
    Console.WriteLine ("Точка с координатами " + (x) + ";" + (y) +  " находится во второй четвери");
}
if (x<0&& y<0)
{
    Console.WriteLine ("Точка с координатами " + (x) + ";" + (y) +  " находится в третьей четвери");
}
