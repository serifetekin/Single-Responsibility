using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility.Klasik
{
    class Kullanıcı
    {
        public int Id;
        public string Adi;
        public string Soyadi;
        string KullaniciAdi;
        string Parola;

        public void Ekle(string adi, string soyadi)
        {
            KullaniciAdi = adi;
            Soyadi = soyadi;
            Console.WriteLine(adi + " " + soyadi + " kaydı eklendi.");
        }

        public void Guncelle(int id, string adi, string soyadi)
        {
            KullaniciAdi = adi;
            Soyadi = soyadi;
            Console.WriteLine(id + " refnolu kayıt " + adi + " " + soyadi + " olarak güncellendi");
        }

         public void Sil(int id)
        {
            Console.WriteLine(id + " refnolu kullanıcı silindi");
        }

         public Kullanıcı Getir(int id)
        {
            Kullanıcı k = new Kullanıcı() { Id = id, KullaniciAdi = "Şerife", Parola = "Tekin", Adi = "Şerife", Soyadi = "Tekin" };
            Console.WriteLine(k.KullaniciAdi + " " + k.Parola + "kullanıcı bulundu");
            return k;
        }

        public bool ChechUser(string kullaniciadi, string parola)
        {
            KullaniciAdi = kullaniciadi;
            Parola = parola;

            Console.WriteLine(KullaniciAdi + " " + Parola + "ile giriş yapıldı");
            return true;
        }

        public void Logout(int id)
        {
            Console.WriteLine(id + " refnolu kullanıcı sstemden çıktı");
        }
    }
}
