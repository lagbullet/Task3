using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleApp
{
    class Boy : Human
    {
        private int _Age;
        private string _Birthdate;
        private int _Height;

        public override string Birthdate { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }

        public Boy(string surname, string firstname, string patronymic,string birthdate, int age, int  height) : base(surname, firstname, patronymic)
        {
            Age = age;
            Birthdate= birthdate;
            Height = height;
        }
        public override void Show()
        {
            Console.WriteLine("Surname - {0}, Firstname - {1}, Patronymic - {2}, Age - {3}", SurName, FirstName, Patronymic, Age);
        }

        public void Talk()
        {
            Console.WriteLine("Hello, my name is {0} and I was born in {1}", FirstName, Birthdate);
        }
    }
}
