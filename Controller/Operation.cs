using System;

namespace TelefonRehberi
{
    //Operation adlı sınıfımızda 5 Temel işlemimiz olan:
    //Telefon Numarası Kaydet, Telefon Numarası Sil, Telefon Numarası Güncelle, Rehber Listeleme(A-Z, Z-A seçimli), Rehberde Arama işlemlerini gerçekleştiriyorum.
    public static class Operation
    {
        //Giriş Karşılamalarını Basan Fonksiyonumuz
        public static void StartPrint()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz:)");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak﻿");
            Console.WriteLine("*******************************************");
            Console.WriteLine("Çıkmak İçin 1-5 Dışında Her Hangi Bir Şey Girmeniz Yeterlidir.");
        }
        //Girilen Sayının 1-5 arasında olup olmadığı kontrolu
        public static bool ControlNumber(int number)
        {
            if(number >= 1 && number<= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        //Telefon Rehberini Listeleyen Fonksiyonumuz
        public static void PrintNumberList()
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("**********************************************");
            for (int i = 0; i < PhoneListModel.PhoneNumberList.Count; i++)
            {
                Console.WriteLine("isim: {0}", PhoneListModel.PhoneNumberList[i].Name);
                Console.WriteLine("Soyisim: {0}", PhoneListModel.PhoneNumberList[i].Surname);
                Console.WriteLine("Telefon Numarası: {0}", PhoneListModel.PhoneNumberList[i].Number);
                Console.WriteLine("-");
            }
        }
        //Rehbere Yeni Bir Kullanıcı Kaydeden Fonksiyonumuz
        public static void SaveNumber()
        {
            Console.WriteLine("Lütfen isim giriniz:");
            string name = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz:");
            string surname = Console.ReadLine();
            Console.WriteLine("Lütfen telefon numarası giriniz :");
            string number = Console.ReadLine();
            PhoneListModel.PhoneNumberList.Add(new NumberModel(name, surname, number));
        }
        //Rehberde Mevcut Olan bir Kullanıcıyı Silen Fonksiyonumuz
        public static void DeleteNumber()
        {
            Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            int check = 0;
            string name = Console.ReadLine();
            foreach (var item in PhoneListModel.PhoneNumberList)
            {
                if(item.Name.ToLower() == name.ToLower() || item.Surname.ToLower() == name.ToLower())
                {
                    Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", name);
                    char control = char.Parse(Console.ReadLine());
                    if(control == 'y')
                    {
                        int deleteIndex = PhoneListModel.PhoneNumberList.IndexOf(item);
                        PhoneListModel.PhoneNumberList.RemoveAt(deleteIndex);
                        check++;
                        Console.WriteLine("Silme Onayı Başarılı, Çıkılıyor...");
                        break;
                    }
                    else
                    {
                        check++;
                        Console.WriteLine("Silme Onayı Başarısız, Çıkılıyor...");
                        break;
                    }

                }
            }
            if (check == 0)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");
                int selection = int.Parse(Console.ReadLine());
                if (selection == 2)
                {
                    while (selection == 2)
                    {
                        Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                        name = Console.ReadLine();
                        foreach (var item2 in PhoneListModel.PhoneNumberList)
                        {
                            
                            if (item2.Name.ToLower() == name.ToLower() || item2.Surname.ToLower() == name.ToLower())
                            {
                                Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)", name);
                                char control = char.Parse(Console.ReadLine());
                                if (control == 'y')
                                {
                                    int deleteIndex = PhoneListModel.PhoneNumberList.IndexOf(item2);
                                    PhoneListModel.PhoneNumberList.RemoveAt(deleteIndex);
                                    check++;
                                    selection = 3;
                                    Console.WriteLine("Silme Onayı Başarılı, Çıkılıyor...");
                                    break;
                                }
                                else
                                {
                                    check++;
                                    selection = 3;
                                    Console.WriteLine("Silme Onayı Başarısız, Çıkılıyor...");
                                    break;
                                }
                            }
                        }
                        if (check == 0)
                            {
                            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                                Console.WriteLine("* Yeniden denemek için      : (2)");
                                selection = int.Parse(Console.ReadLine());
                            }
                    }
                }
            }
        }
        //Belirtilen Özellikde Rehberde Arama Yapan Fonksiyonumuz
        public static void SearchNumber()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("***********************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            int select = int.Parse(Console.ReadLine());
            if(select == 1)
            {
                Console.WriteLine("Lütfen arama yapmak istediğiniz kişinin adını ya da soyadını giriniz:");
                string name = Console.ReadLine();
                foreach (var item in PhoneListModel.PhoneNumberList)
                {
                    if (item.Name.ToLower() == name.ToLower() || item.Surname.ToLower() == name.ToLower())
                    {
                        Console.WriteLine("isim: {0}", item.Name);
                        Console.WriteLine("Soyisim: {0}", item.Surname);
                        Console.WriteLine("Telefon Numarası: {0}", item.Number);
                        Console.WriteLine("-");
                    }
                }
                Console.WriteLine("Arama İşlemi Bitti, Çıkılıyor...");
            }
            else if(select == 2)
            {
                Console.WriteLine("Lütfen arama yapmak istediğiniz kişinin telefon numarasını giriniz:");
                string no = Console.ReadLine();
                foreach (var item in PhoneListModel.PhoneNumberList)
                {
                    if (item.Number == no)
                    {
                        Console.WriteLine("isim: {0}", item.Name);
                        Console.WriteLine("Soyisim: {0}", item.Surname);
                        Console.WriteLine("Telefon Numarası: {0}", item.Number);
                        Console.WriteLine("-");
                    }
                }
                Console.WriteLine("Arama İşlemi Bitti, Çıkılıyor...");
            }
            else
            {
                Console.WriteLine("Hatalı Seçim, Çıkılıyor...");
            }
            

        }
        //Belirtilen Özellikde Kişi Bulunursa Numarasını Güncelleyen Fonksiyonumuz
        public static void UpdateNumber()
        {
            Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
            string name = Console.ReadLine();
            int count = PhoneListModel.PhoneNumberList.Count;
            int updateControl = 0;
            //Foreach Kullanamıyoruz, çünkü hangi indeks de iş yapıyorsak orayı bilmemiz lazım, çünkü güncelleme yapacağız :).
            for (var i = 0; i < count; i++)
            {
                if(PhoneListModel.PhoneNumberList[i].Name.ToLower() == name.ToLower() || PhoneListModel.PhoneNumberList[i].Surname.ToLower() == name.ToLower())
                {
                    Console.WriteLine("Kişi Bulundu ve Telefon Numarası: {0}",PhoneListModel.PhoneNumberList[i].Number);
                    Console.WriteLine("Lütfen güncellemek istediğiniz telefon numarasını giriniz...");
                    string newNumber = Console.ReadLine();
                    PhoneListModel.PhoneNumberList[i].Number = newNumber;
                    Console.WriteLine("Telefon Numarası Güncellemesi Başarılı, Çıkılıyor...");
                    updateControl++;
                    break;
                }
            }
            if(updateControl == 0)
            {
                Console.WriteLine("Telefon Numarası Güncellemesi Başarısız, Çıkılıyor...");
            }
        }
    }
}
