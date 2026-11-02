Console.WriteLine("Masukkan tarif per jam ");
Int32 tarifPerJam = Int32.Parse(Console.ReadLine()!);

Console.WriteLine("Masukkan lama penggunaan ");
Int32 lamaPenggunaan = Int32.Parse(Console.ReadLine()!);

Int32 totalbiaya = tarifPerJam * lamaPenggunaan;

Console.WriteLine($"Total biaya = {totalbiaya}");