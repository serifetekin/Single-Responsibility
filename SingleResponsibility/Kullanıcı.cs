using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    partial class Kullanıcı // gelişime kapalı geliştirmek için yeni bir class yazmak gerekir.
    {
        public int Id;
        public string Adi;
        public string Soyadi;
        public string KullaniciAdi;
        public string Parola;

    }
    class CRUD
    {
        public void Ekle(Kullanıcı k)
        {
            Console.WriteLine(k.Adi + " " + k.Soyadi + " kaydı eklendi.");
        }

        public void Guncelle(Kullanıcı k)
        {
            Console.WriteLine(k.Id + " refnolu kayıt " + k.Adi + " " + k.Soyadi + " olarak güncellendi");
        }

        public void Sil(Kullanıcı k)
        {
            Console.WriteLine(k.Id + " refnolu kullanıcı silindi");
        }

        public Kullanıcı Getir(int id)
        {
            Kullanıcı k = new Kullanıcı() { Id = id, KullaniciAdi = "Şerife", Parola = "Tekin", Adi = "Şerife", Soyadi = "Tekin" };
            Console.WriteLine(id+ "refnolu kayıt bulundu.");
            return k;
        }
    }

    class KullanıcıAuthentication
    {
        public bool ChechUser(string kullaniciadi, string parola)
        {
            Console.WriteLine(kullaniciadi + " " + parola + "ile giriş yapıldı");
            return true;
        }

        public void Logout(int id)
        {
            Console.WriteLine(id + " refnolu kullanıcı sstemden çıktı");
        }
    }
}
