using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        // Me
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            // Başvuran bilgilerini değerlendirme
            //
            // Eğer bu şekilde tanımlanırsa, bütün başvurular konutkredisi olarak hesaplanır
            // KonutKrediManager konutKrediManager = new KonutKrediManager();
            // konutKrediManager.Hesapla();

            // Bu şekilde parametre alırsak, bütün problemi çözmüş oluyoruz. 
            krediManager.Hesapla();
            loggerService.Log();
        }
        // Bu şekilde liste ile girdi olarak tanımlarsak, 1 tanede olsa 100 tane de olsa girdi, problem yaşamıyoruz.
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
