namespace TelefonRehberi
{
    //Bu kısımda Telefon Rehberimizdeki her bir kişi için isim, soyisim ve numara değişkenleri sabit olduğu için bir telefon rehberi modeli oluşturarak hepsinde kullanmalarını sağladık
    public class NumberModel
    {
        //Bir Consturucter yardımıyla değişkinlerimizin atamasını gerçekleştirdik
        public NumberModel(string name, string surname, string number)
        {
            this.Name = name;
            this.Surname = surname; 
            this.Number = number;
        }
        //Normalde değişkenlerimizi private yapmamız daha doğru olurdu fakat get ve set özelliğimizin görüntülenmesi için değişkenlerimizi public yaptım
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Number { get; set; }
    }
}
