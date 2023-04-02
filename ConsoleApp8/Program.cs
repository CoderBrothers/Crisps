using ConsoleApp8;

ConsoleApp8.Crackers crackers = new ConsoleApp8.Crackers();
crackers.Buy();
crackers.About();
ConsoleApp8.Crackers crackers1 = new ConsoleApp8.Crackers("Гренки", 255, 49, "Бекон");
crackers1.Buy();
crackers1.About();
Console.WriteLine(ConsoleApp8.Crackers.Counter);
ConsoleApp8.Crackers.GetCount();