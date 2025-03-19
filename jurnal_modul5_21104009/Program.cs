// Class untuk menjumlahkan 2 angka dengan tipe data yang dapat berubah karena menggunakan Generics
class Penjumlahan
{
    public T JumlahTigaAngka<T>(T a, T b, T c) where T : struct
    {
        dynamic total = a;
        total += b;
        total += c;
        return total;
    }
}

class Program
{
    static void Main()
    {
        // Membuat object penjumlahan
        Penjumlahan penjumlahan = new Penjumlahan();

        // Deklarasi angka 1 sampai 3
        long angka1 = 21;
        long angka2 = 10;
        long angka3 = 40;

        // memanggil fungsi dari object penjumlahan dan menyimpannya di variable hasil
        long hasil = penjumlahan.JumlahTigaAngka(angka1, angka2, angka3);
        
        //mencetak hasil menggunakan string concatenation
        Console.WriteLine($"Hasil Penjumlahan: {hasil}");
    }
}