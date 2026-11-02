Console.WriteLine("7500");
Int32 tarifPerJam = Int32.Parse(Console.ReadLine()!);

Console.WriteLine("4");
Int32 lamaPenggunaan = Int32.Parse(Console.ReadLine()!);

Int32 totalbiaya = tarifPerJam * lamaPenggunaan;

Console.WriteLine($"Total biaya = {totalbiaya}");