/* Напишите программу, которая на вход принимает координаты
двух точек и находит расстояние между ними в 2D пространстве
А(3,6); В(2,1) ->5,09
А(7,-5); В(1,-1) ->7,21 */

/*System.Console.WriteLine(Math.Pow(3, 4));  возведение числа 3 в степень 4
System.Console.WriteLine(Math.Sqrt(9));  взятие квадратного корня числа
System.Console.WriteLine(Math.Round(temp, 2)) это округление до 2 в примере*/

int[] aCoordinate = new int[2];
Console.WriteLine("Enter the first point of X: ");
aCoordinate[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the first point of Y: ");
aCoordinate[1] = Convert.ToInt32(Console.ReadLine());
int[] bCoordinate = new int[2];
Console.WriteLine("Enter the first point of X: ");
bCoordinate[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the first point of Y: ");
bCoordinate[1] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Math.Round(Math.Sqrt(Math.Pow((bCoordinate[0] - aCoordinate[0]), 2) + Math.Pow((bCoordinate[1] - aCoordinate[1]),2)),3));
/* 1
int[] array = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
int[] array = new int[5];
for(int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
}
for(int i = 0; i < array.Length; i++)
{
    System.Console.Write(array[i] + " ");
} */
/* 2
int[] array = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
for(int i = 0; i < array.Length; i++)
{
    System.Console.Write(array[i] + " ");
} 
// "12 11 10 67 -90" -> {"12", "11", "10", "67", "-90"} -> {12,11,10,67,-90} 
//  переводит строки в массив строк и далее в массив чисел (int[] array = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse))*/
