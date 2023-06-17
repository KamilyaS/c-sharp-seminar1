// Напишите программу которая будет выдавать день недели по заданному номеру

Console.WriteLine("Add number day of week: ");

int DayWeek = Convert.ToInt32(Console.ReadLine());

if (DayWeek == 1) 
    Console.WriteLine("Monday");
else if (DayWeek == 2) 
    Console.WriteLine("Tuesday");
else if (DayWeek == 3) 
    Console.WriteLine("Wednesday");
else if (DayWeek == 4) 
    Console.WriteLine("Thursday");
else if (DayWeek == 5) 
    Console.WriteLine("Friday");
else if (DayWeek == 6) 
    Console.WriteLine("Saturday");
else if (DayWeek == 7) 
    Console.WriteLine("Sunday");
else Console.WriteLine("False");
