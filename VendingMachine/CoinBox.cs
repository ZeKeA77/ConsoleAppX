using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class CoinBox
    {
        public int AvailableFunds { get; set; }
        Menu menu = new Menu();

        public void MoneyDeposited(int fundsDeposited)
        {
            
            switch (fundsDeposited)
            {
                case (1):
                    AvailableFunds += 1;
                    break;
                case (5):
                    AvailableFunds += 5;
                    break;
                case (10):
                    AvailableFunds += 10;
                    break;
                case (20):
                    AvailableFunds += 20;
                    break;
                case (50):
                    AvailableFunds += 50;
                    break;
                case (100):
                    AvailableFunds += 100;
                    break;
                case (500):
                    AvailableFunds += 500;
                    break;
                case (1000):
                    AvailableFunds += 1000;
                    break;
                default:
                    menu.MenuChoice("WrongFunds");
                    break;

            }

        }

        public void FundsToReturn()
        {

            int count1000;
            int count500;
            int count100;
            int count50;
            int count20;
            int count10;
            int count5;
            int count1;
            string retur = "";

            Console.WriteLine($"\t\tPengar i retur: {AvailableFunds}");

            count1000 = AvailableFunds / 1000;
            if (count1000 != 0) { if (count1000 <= 1) { retur = count1000 + " tusenlapp "; } else { retur = count1000 + " tusenlappar "; } }
            AvailableFunds = AvailableFunds - count1000 * 1000;

            count500 = AvailableFunds / 500;
            if (count500 != 0) { if (count500 <= 1) { retur += count500 + " femhundralapp "; } else { retur += count500 + " femhundralappar "; } }
            AvailableFunds = AvailableFunds - count500 * 500;

            count100 = AvailableFunds / 100;
            if (count100 != 0) { if (count100 <= 1) { retur += count100 + " hundralapp "; } else { retur += count100 + " hundralappar "; } }
            AvailableFunds = AvailableFunds - count100 * 100;

            count50 = AvailableFunds / 50;
            if (count50 != 0) { if (count50 <= 1) { retur += count50 + " femtilapp "; } else { retur += count50 + " femtilappar "; } }
            AvailableFunds = AvailableFunds - count50 * 50;

            count20 = AvailableFunds / 20;
            if (count20 != 0) { if (count20 <= 1) { retur += count20 + " tjugolapp "; } else { retur += count20 + " tjugolappar "; } }
            AvailableFunds = AvailableFunds - count20 * 20;

            count10 = AvailableFunds / 10;
            if (count10 != 0) { if (count10 <= 1) { retur += count10 + " tiokrona "; } else { retur += count10 + " tiokronor "; } }
            AvailableFunds = AvailableFunds - count10 * 10;

            count5 = AvailableFunds / 5;
            if (count5 != 0) { if (count5 <= 1) { retur += count5 + " femkrona "; } else { retur += count5 + " femkronor "; } }
            AvailableFunds = AvailableFunds - count5 * 5;

            count1 = AvailableFunds / 1;
            if (count1 != 0) { if (count1 <= 1) { retur += count1 + " enkrona "; } else { retur += count1 + " enkronor "; } }
            AvailableFunds = AvailableFunds - count1 * 1;

            Console.WriteLine($"\t\tValörer: {retur.ToString()}");
        }
    }
}
