/*Напишите программу которая на входе принимает трехзначное число, а на выходе выводит последнюю цифру числа
456 ->6
782 ->2
918 ->8 */

Console.WriteLine ("Add number: ");
int numberA = Convert.ToInt32(Console.ReadLine());
numberA = numberA %10;
Console.Write(numberA);
