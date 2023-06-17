/*Напишите программу которая на входе принимает трехзначное число, а на выходе выводит последнюю цифру числа
456 ->6
782 ->2
918 ->8 */

    Console.WriteLine ("Add number: ");
    int numberA = Math.Abs(Convert.ToInt32(Console.ReadLine()));
if  (numberA >99 && numberA < 1000)
{ 
    numberA = numberA %10;
    Console.WriteLine("Last number" + numberA);
}
else 
{
    Console.WriteLine("Add number from 1 to 999");
}

