using modul8_1302220018;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        BankTransferConfig config = new BankTransferConfig().readData();
        int total_transfer = 0, fee = 0, total_amount = 0, choice;

        if (config.lang == "en")
        {
            Console.WriteLine("Please insert the amount of money to transfer: ");
            total_transfer = int.Parse(Console.ReadLine());
        } else
        {
            Console.WriteLine("Masukkan jumlah uang yang akan di-transfer: ");
            total_transfer = int.Parse(Console.ReadLine());
        }

        if(total_transfer <= config.transfer.threshold)
        {
            fee = config.transfer.low_fee;
        } else if (total_transfer > config.transfer.threshold)
        {
            fee = config.transfer.high_fee;
        }

        total_amount = fee + total_transfer;

        if (config.lang == "en")
        {
            Console.WriteLine("Transfer fee = " + fee);
            Console.WriteLine("Total amount = " + total_amount);
        }
        else
        {
            Console.WriteLine("Biaya transfer = " + fee);
            Console.WriteLine("Total biaya = " + total_amount);
        }

        

        for (int i = 0; i < config.methods.Length; i++)
        {
            int j = i + 1;
            Console.WriteLine(j + ". " + config.methods[i]);
        }
        Console.WriteLine(config.lang == "en" ? "Select transfer method: " : "Pilih metode transfer: ");
        choice = int.Parse(Console.ReadLine());

        Console.WriteLine(config.lang == "en" ? "Please type " + config.confirmation.en + " to confirm the transaction:" : "Ketik "+ config.confirmation.id +" untuk mengkonfirmasi transaksi:");
        string pilih = Console.ReadLine();

        if (pilih == "ya" || pilih == "yes")
        {
            Console.WriteLine(config.lang == "en" ? "The transfer is completed" : "Proses transfer berhasil");
        } else
        {
            Console.WriteLine(config.lang == "en" ? "Transfer is cancelled" : "Transfer dibatalkan");
        }




    }
}
