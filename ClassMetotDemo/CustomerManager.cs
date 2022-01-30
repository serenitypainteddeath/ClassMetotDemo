using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class CustomerManager
    {


        public void MusteriEkle(Customer musteriler)
        {
            Console.WriteLine("Müşteri Eklendi!\nEklenen Kişi: "+musteriler.FirstName+" "+musteriler.LastName + "\n\n");
        }


        public void MusteriSil(Customer musteriler)
        {
            Console.WriteLine("Müşteri Silindi!\nSilinen Kişi: " + musteriler.FirstName + " " + musteriler.LastName + "\n\n");
        }


        public void MusteriListele(Customer[] musteriler)
        {
            int a = 1;
            foreach (Customer musteri in musteriler)
            {
                Console.WriteLine(a++ + ". KİŞİ" + "\nMüşteri ID: " + musteri.ID + "\nMüşteri Adı: " + musteri.FirstName + "\nMüşteri Soyadı: " + musteri.LastName + "\nKart Numarası: " + musteri.CardNumber + "\n\n");
            }
        }

     
    }
}
