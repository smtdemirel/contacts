<h1>Console Telefon Rehberi Uygulaması</h1>


Uygulamanın özellikleri aşağıdaki gibidir.



<h4>1) Telefon Numarası Kaydet</h4>
<h4>2) Telefon Numarası Sil</h4>
<h4>3) Telefon Numarası Güncelle</h4>
<h4>4) Rehber Listeleme</h4> 
<h4>5) Rehberde Arama</h4>


<h3>Açıklama:</h3>


<h5>Başlangıç olarak 5 kişinin numarası varsayılan olarak eklidir.</h5>

<h5>Uygulama ilk başladığında kullanıcıya yapmak istediği işlem seçtirilir.</h5>


  Lütfen yapmak istediğiniz işlemi seçiniz :) 
  *******************************************
  (1) Yeni Numara Kaydetmek
  (2) Varolan Numarayı Silmek
  (3) Varolan Numarayı Güncelleme
  (4) Rehberi Listelemek
  (5) Rehberde Arama Yapmak﻿


# (1) Yeni Numara Kaydetmek


 Lütfen isim giriniz             : 
 Lütfen soyisim giriniz          :
 Lütfen telefon numarası giriniz :
 
 
# (2) Var olan Numarayı Silmek


İsim ve soy isime göre arama yapılması yeterlidir.



  Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:


Kullanıcıdan alınan girdi doğrultusunda rehberde bir kişi bulunamazsa:



  Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.
  * Silmeyi sonlandırmak için : (1)
  * Yeniden denemek için      : (2)


Rehberde uygun veri bulunursa:



  {} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)
Not: Rehber uygun kriterlere uygun birden fazla kişi bulunursa ilk bulunan silinmeli.


# (3) Varolan Numarayı Güncelleme


 Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:


Kullanıcıdan alınan girdi doğrultusunda rehberde bir kişi bulunamazsa:



 Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.
 * Güncellemeyi sonlandırmak için    : (1)
 * Yeniden denemek için              : (2)


Rehberde uygun veri bulunursa güncelleme işlemi gerçekleştirilir.



Not: Rehber uygun kriterlere uygun birden fazla kişi bulunursa ilk bulunan silinmeli.


# (4) Rehberi Listelemek


Tüm rehber aşağıdaki formatta console'a listelenir.



  Telefon Rehberi
  **********************************************
  isim: {}
  Soyisim: {}
  Telefon Numarası: {}
  - 
  isim: {}
  Soyisim: {}
  Telefon Numarası: {}
  .
  .


# (5) Rehberde Arama Yapmak


 Arama yapmak istediğiniz tipi seçiniz.
 **********************************************
 
 İsim veya soyisime göre arama yapmak için: (1)
 Telefon numarasına göre arama yapmak için: (2)


Arama sonucuna göre bulunan veriler aşağıdaki formatta gösterilmeli.



 Arama Sonuçlarınız:
 **********************************************
 isim: {}
 Soyisim: {}
 Telefon Numarası: {}
 - 
 isim: {}
 Soyisim: {}
 Telefon Numarası: {}
 .
 .
