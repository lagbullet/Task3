using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleApp
{
    class Human
    {
        private string _SurName;
        private string _FirstName;
        private string _Patronymic;
        private string _Birthdate;

        public virtual string Birthdate { get; set; }
        public string SurName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }

        public Human(string surname, string firstname, string patronymic)
        {
            SurName = surname;
            FirstName = firstname;
            Patronymic = patronymic;
        }

        public virtual void Show()
        {
            Console.WriteLine("Surname - {0}, Firstname - {1}, Patronymic - {2}", SurName, FirstName, Patronymic);
        }

        
    }
}
