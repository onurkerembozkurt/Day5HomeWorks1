using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Customer
    {
        //Field oluyor burasıda
        private string _firstName;
       
        //public string FirstName;// bu get alma oluyor yani set de hazırlama yeni set etme .




        //Property aşağıda yaptıgımız şey
        
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        //prop içinde ki get ve set getleme ve setlemeye işe yarar mesala program cs de 

       
        
    }
}
/*
 * //Field oluyor burasıda
        private string _firstName;

 *    public string FirstName { 
            get 
            {
                return "Mr."+_firstName;
            } 
            set 
            {
                _firstName = value;
            } 
        }
 * 
 * normalde diyelim şirket bize kişilerin önüe mr eklememizi istedi ve biz bu mantıkla ekleyebiliriz
 * o yüzden böylece get set in mantıgını da anlamış olduk 
 * fakat c# v3 sonrası sadece prop oluşturmak yeterli sonra gerekli ise içine yukarıdaki gibi girme yaparız
 * 
 */