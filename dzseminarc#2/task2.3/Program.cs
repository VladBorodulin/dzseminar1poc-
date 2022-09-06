/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

Console.Write("Введи цифру, обозначающую день недели: ");
int Numday = Convert.ToInt32(Console.ReadLine());

void DayWeek (int Numday) 
{
  if (Numday == 6 || Numday == 7) 
  {
    Console.WriteLine("выходной");
  }
  else 
  {
    Console.WriteLine("не выходной");
  }
}

DayWeek(Numday);
