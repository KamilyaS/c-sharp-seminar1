/* Напишите программу, которая на вход принимает число N
и выдает таблицу квадратов чисел от 1 до N
5 -> 1,4,9,16,25
2 -> 1,4 */

/* Console.WriteLine("Enter number");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;

while (i<= number)
{
    System.Console.WriteLine(Math.Pow(i, 2));
    i++;
}
*/

Console.WriteLine("Enter number");
int number = Convert.ToInt32(Console.ReadLine());

for( int i = 1; i <= number; i++ )
{
    System.Console.Write(Math.Pow(i, 2) + " ");
}