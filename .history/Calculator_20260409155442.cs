class Calculator
{
    static void Main(string[] args)
    {
        int a = 10;
        int b = 6;

        // Tugas 4: Melengkapi fungsi Main
        Console.WriteLine("Hasil Penambahan: {0} + {1} = {2}", a, b, Penambahan(a, b));
        Console.WriteLine("Hasil Pengurangan: {0} - {1} = {2}", a, b, Pengurangan(a, b));

        Console.WriteLine("\nTekan sembarang key untuk keluar");
        Console.ReadKey();
    }
    static int Penambahan(int a, int b)
    {
        // Tugas 2: Menambahkan fungsi Penambahan
        return a + b;
    }
    static int Pengurangan(int a, int b)
    {
        // Tugas 3: Menambahkan fungsi Pengurangan
        return a - b;
    }
}

