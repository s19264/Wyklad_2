using System;

namespace Wyklad_2
{
    public class Student {
        public string LastName{ get; set; }
        
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set {
                if (value == null)
                {
                    throw new ArgumentException("wartosc jest nullem");
                }
                firstName = value;
            }
        }



    }

    class Program
    {
        
        static void Main(string[] args)
        
        {
            Student st = new Student();
            
            st.FirstName = "Jan";
            st.LastName = "Kowalski";

            Uczen ucz = new Uczen();
            ucz.Imie = "Tomek";
            ucz.Nazwisko = "Nowak";

            dynamic age = 10;
            age = "Jhon";
            age = true;






            Console.WriteLine("elmo"); 
        
        }
    }
}
