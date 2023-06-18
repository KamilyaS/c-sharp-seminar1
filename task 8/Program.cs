/* Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит
остаток от деления
34, 5 -> не кратно, остаток 4
16, 4 -> кратно*/

Console.WriteLine("Add number 1");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Add number 2");
int numberB = Convert.ToInt32(Console.ReadLine());

if(numberA % numberB == 0)
{
    Console.WriteLine("Numbers are multiples");
}
else 
{
    Console.WriteLine("Numbers are not multiples. Remainder of the division" + numberA % numberB); //Числа не кратные остаток от деления:..
}