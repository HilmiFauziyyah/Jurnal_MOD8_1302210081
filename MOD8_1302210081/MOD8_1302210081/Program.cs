public class program
{
    public static void Main(string[] args)
    {
        BankTransferConfig bankconfig = new BankTransferConfig();
        int transfer;
        string methods;
        string confirmation;

        for(int i = 0; i < 2; i++)
        {
            if (bankconfig.config.lang == "en")
            {
                Console.WriteLine("“Please insert the amount of money to transfer:");
                transfer = Convert.ToInt32(Console.ReadLine());
                if(transfer <= bankconfig.config.transfer.threshold)
                {
                    Console.WriteLine("Tranfers fee = " + bankconfig.config.transfer.high_fee);
                    Console.WriteLine("Total amount = " + (transfer + bankconfig.config.transfer.low_fee));
                }else if (transfer > bankconfig.config.transfer.threshold){
                    Console.WriteLine("Tranfers fee = " + bankconfig.config.transfer.high_fee);
                    Console.WriteLine("Total amount = " + (transfer + bankconfig.config.transfer.low_fee));
                }
                Console.WriteLine("Select transfer method:");
                Console.WriteLine("1. " + bankconfig.config.methods[0]);
                Console.WriteLine("2. " + bankconfig.config.methods[1]);
                Console.WriteLine("3. " + bankconfig.config.methods[2]);
                Console.WriteLine("4. " + bankconfig.config.methods[3]);
                Console.WriteLine();
                methods = Console.ReadLine();

                Console.Write("\nPlease type yes to confirm the transaction:");
                confirmation = Console.ReadLine();
                Console.WriteLine();
                if(confirmation == "yes")
                {
                    Console.WriteLine("The transfer is completed");
                }
                else
                {
                    Console.WriteLine("Transfer is cancelled");
                }

            }
            else if (bankconfig.config.lang == "id")
            {
                Console.WriteLine("Masukan Jumlah Uang Yang akan Di Transfer : ");
                transfer = Convert.ToInt32(Console.ReadLine());
                if (transfer <= bankconfig.config.transfer.threshold)
                {
                    Console.WriteLine("Biaya Transfer = " + bankconfig.config.transfer.low_fee);
                    Console.WriteLine("Total Biaya : " + (transfer + bankconfig.config.transfer.low_fee));
                }else if (transfer > bankconfig.config.transfer.threshold)
                {
                    Console.WriteLine("Biaya Transfer = " + bankconfig.config.transfer.high_fee);
                    Console.WriteLine("Total Biaya : " + (transfer + bankconfig.config.transfer.high_fee));
                }
                Console.WriteLine("\nKetik ya untuk mengkonfirmasi transaksi:");
                Console.WriteLine("1. " + bankconfig.config.methods[0]);
                Console.WriteLine("2. " + bankconfig.config.methods[1]);
                Console.WriteLine("3. " + bankconfig.config.methods[2]);
                Console.WriteLine("4. " + bankconfig.config.methods[3]);
                Console.WriteLine();
                methods = Console.ReadLine();

                Console.WriteLine("\nketik ya untuk mengkonfirmasi transaksi : ");
                confirmation = Console.ReadLine();
                Console.WriteLine();
                if (confirmation == "ya")
                {
                    Console.WriteLine("Proses transfer berhasil");
                }
                else
                {
                    Console.WriteLine("Transfer dibatalkan");
                }
            }
            Console.WriteLine() ;
            bankconfig.Ubah();
        }
    }
}
