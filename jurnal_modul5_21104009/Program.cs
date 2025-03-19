class SimpleDataBase<T>
{
    // Inisialisasi Properties
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        // Membuat List kosong saat pembuatan instance SimpleDataBase
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    // Fungsi untuk menambahkan data ke dalam list menggunakan waktu sekarang
    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    // Fungsi untuk menampilkan semua data
    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine("Data " + (i + 1) + " Berisi " + storedData[i] + " disimpan pada waktu " + inputDates[i]);
        }
    }
}
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
        
        SimpleDataBase<long> database = new SimpleDataBase<long>();
        database.AddNewData(angka1);
        database.AddNewData(angka2);
        database.AddNewData(angka3);
        
        database.PrintAllData();
    }
}