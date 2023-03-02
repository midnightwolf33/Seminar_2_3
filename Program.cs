Console.WriteLine("Введите число от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day < 8)
{
   if (day==6 || day==7)
   {
    Console.WriteLine("УРА, ВЫХОДНОЙ");
   }
   else
   {
    System.Console.WriteLine("Увы - Раобчий день");
   }
}
else
{
    System.Console.WriteLine("Нет такого дня недели");
}