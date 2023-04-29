// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат
//  точек в этой четверти (x и y).

// 1 : x > 0 И y > 0

Console.WriteLine("Введите координату X:");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y:");
int y = int.Parse(Console.ReadLine());

if (x != 0 && y != 0)
{
  if (x > 0 && y > 0)
  {
    Console.WriteLine("Четверть 1");
  }
  else if (x < 0 && y > 0)
  {
    Console.WriteLine("Четверть 2");
  }
  else if (x < 0 && y < 0)
  {
    Console.WriteLine("Четверть 3");
  }
  else if (x > 0 && y < 0)
  {
    Console.WriteLine("Четверть 4");
  }
}
else
{
  Console.WriteLine(" x или y равны нулю!");
}