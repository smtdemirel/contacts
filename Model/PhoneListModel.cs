using System.Collections.Generic;

namespace TelefonRehberi
{
    //Bir veri tabanı kullanmadığım için her yerden ulaşılabilmesi gereken bir Rehbere ihtiyacım vardı. Bu amaçla static bir obje tanımlayarak referansı ile her yerde kullanabildim.
    public static class PhoneListModel
    {
        public static List<NumberModel> PhoneNumberList = new List<NumberModel>();
    }
}
