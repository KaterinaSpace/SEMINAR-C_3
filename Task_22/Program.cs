//Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу квадратов чисел от 1 до N.

//  5 -> 1, 4, 9, 16, 25.    //1 вариант
//  2 -> 1,4
//  for (int i = 0; i < 10; i += 2)
//  {
//    Console.Write(i + ", ");
//  }

//  Console.WriteLine();   //это  для того чтоб второй вариат тоже вышел в терминале



//  int counter = 0;   //2 вариант
//  while (counter < 10)
//  {
//    Console.Write(counter + ", ");
//    counter = counter + 2;
//  }


// double sqr = Math.Pow(100, 3);
// Console.WriteLine(sqr);


Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine()!);

for (int i = 1; i < num; i++)
{
    Console.Write(Math.Pow(i, 2) + ",");
}
Console.Write(num*num);
