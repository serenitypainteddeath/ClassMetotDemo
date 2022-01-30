using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Customer musteri1 = new Customer();
            musteri1.ID = 1;
            musteri1.FirstName = "Erdem";
            musteri1.LastName = "Kaplan";
            musteri1.Adress = "ANKARA";
            musteri1.CardNumber = 123456789;

            Customer musteri2 = new Customer();
            musteri2.ID = 2;
            musteri2.FirstName = "Ekrem";
            musteri2.LastName = "Özdemir";
            musteri2.Adress = "İSTANBUL";
            musteri2.CardNumber = 987654321;

            Customer[] musteriler = new Customer[] { musteri1, musteri2 };

            CustomerManager musteriManager = new CustomerManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriSil(musteri2);
            musteriManager.MusteriListele(musteriler);
        }
    }
}