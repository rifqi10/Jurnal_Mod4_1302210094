public class KodeBuah
{
    public string getKodeBuah(string name)
    {
        switch (name) 
        {
            case "Apel":
                return "A00";
            case "Aprikot":
                return "B00";
            case "Alpukat":
                return "C00";
            case "Pisang":
                return "D00";
            case "Paprika":
                return "E00";
            case "Blackberry":
                return "F00";
            case "Ceri":
                return "H00";
            case "Kelapa":
                return "I00";
            case "Jagung":
                return "J00";
            case "Kurma":
                return "K00";
            case "Durian":
                return "L00";
            case "Anggur":
                return "M00";
            case "Melon":
                return "N00";
            case "Semangka":
                return "O00";
            default:
                return "Kode buah tidak ditemukan";
        }
    }
}

public class Program 
{
    static void Main()
    {
        KodeBuah kode = new KodeBuah();

        Console.WriteLine("| Nama Buah\t\t| Kode Buah |");
        Console.WriteLine("--------------------------------------");

        Console.WriteLine($"| Apel\t\t\t| {kode.getKodeBuah("Apel")}\t|");
        Console.WriteLine($"| Aprikot\t\t| {kode.getKodeBuah("Aprikot")}\t|");
        Console.WriteLine($"| Alpukat\t\t| {kode.getKodeBuah("Alpukat")}\t|");
        Console.WriteLine($"| Pisang\t\t| {kode.getKodeBuah("Pisang")}\t|");
        Console.WriteLine($"| Paprika\t\t| {kode.getKodeBuah("Paprika")}\t|");
        Console.WriteLine($"| Blackberry\t\t| {kode.getKodeBuah("Blackberry")}\t|");
        Console.WriteLine($"| Ceri\t\t\t| {kode.getKodeBuah("Ceri")}\t|");
        Console.WriteLine($"| Kelapa\t\t| {kode.getKodeBuah("Kelapa")}\t|");
        Console.WriteLine($"| Jagung\t\t| {kode.getKodeBuah("Jagung")}\t|");
        Console.WriteLine($"| Kurma\t\t\t| {kode.getKodeBuah("Kurma")}\t|");
        Console.WriteLine($"| Durian\t\t| {kode.getKodeBuah("Durian")}\t|");
        Console.WriteLine($"| Anggur\t\t| {kode.getKodeBuah("Anggur")}\t|");
        Console.WriteLine($"| Melon\t\t\t| {kode.getKodeBuah("Melon")}\t|");
        Console.WriteLine($"| Semangka\t\t| {kode.getKodeBuah("Semangka")}\t|");

        Console.WriteLine("--------------------------------------");
    }
}
    
    