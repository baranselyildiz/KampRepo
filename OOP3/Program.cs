using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            // IhtiyacKrediManager yerine IKrediManager da tanımlayabiliriz. Çünkü ref olarak tutar.
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKrediManager = new EsnafKredisiManager();

            ILoggerService databaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            // Aşağıdaki listeli örnek ile çıktılar karışmamısı için commentledik.
            basvuruManager.BasvuruYap(esnafKrediManager, smsLoggerService);

            
            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager , konutKrediManager};
            // basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            
        }
    }
}
