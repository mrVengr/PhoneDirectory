using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PhoneDirectory.Models
{

    public class Member
    {
        #region Fields
        //private static List<Member> members;
        //public static List<Member> Members
        //{
        //    get
        //    {
        //        return members;
        //    }
        //    set
        //    {
        //        members = value;
        //    }
        //}

        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        private string surname;
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }

        private string phoneNumber;
        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
                phoneNumber = value;
            }
        }

        private string adress;
        public string Adress
        {
            get
            {
                return adress;
            }
            set
            {
                adress = value;
            }
        }

        private string email;
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        private Guid id;
        [Key]
        public Guid Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        #endregion
        public Member()
        { }
        public Member(string _Name, string _Surname, string _Number, string _Adress, string _Email)
        {
            Name = _Name;
            Surname = _Surname;
            PhoneNumber = _Number;
            Adress = _Adress;
            Email = _Email;
            Id = Guid.NewGuid();
        }
        public Member(string _Name, string _Surname, string _Number)
        {
            Name = _Name;
            Surname = _Surname;
            PhoneNumber = _Number;
            Adress = "--";
            Email = "--";
            Id = Guid.NewGuid();
        }
    }
}