using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC1toUC12
{
    public class AddressBook
    {

        public string FirstName;
        public string LastName;
        public string Address;
        public int Zipcode;
        public string state;
        public string phonenumber;
        public string email;
        //uc1
        public AddressBook(string firstName, string lastName, string address, int zipcode, string State, string Phonenumber, string Email)
        {

            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Zipcode = zipcode;

            state = State;
            phonenumber = Phonenumber;
            email = Email;


        }





    }

    //uc6
    public class AdressBook2
    {
        public string FirstName;
        public string LastName;
        public string Address;
        public int Zipcode;
        public string state;
        public string phonenumber;
        public string email;

        public AdressBook2(string firstName, string lastName, string address, int zipcode, string State, string Phonenumber, string Email)
        {

            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Zipcode = zipcode;

            state = State;
            phonenumber = Phonenumber;
            email = Email;


        }





    }

}

