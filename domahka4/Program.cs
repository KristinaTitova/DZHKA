// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int i = 1;

while (i<=numberA) 
{
    if (i%2 == 0)
    {
         Console.Write(" " + i + " ");
    }
   i++;
}