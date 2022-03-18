using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Collections;
namespace UC1toUC12;

class Program
{
    static void Main(string[] args)
    {
        List<AddressBook> listperson = new List<AddressBook>();
        //uc6
        List<AdressBook2> listPerson = new List<AdressBook2>();
        Hashtable h = new Hashtable();
        

        //uc2
        AddRecords(listperson);
        //uc3
        editName(listperson);
        //uc4
        deletename(listperson);
        //uc5
        addmultipleName(listperson);
        //uc6
        UniqueName(h);
        AddRecord(listPerson); uniquename(h);


    }

    //uc2
    private static void AddRecords(List<AddressBook> listperson)
    {
        listperson.Add(new AddressBook("SAM", "Rogers", "Main ave,Dayton", 555555, "California", "6537388926", "sam@gmail.com"));
        listperson.Add(new AddressBook("Jhon", "Rogers", "Main Streetnewyork", 555566, "Florida", "6537388920", "jhon@gmail.com"));
        listperson.Add(new AddressBook("Smith", "Rogers", "12 Main street New York", 556564, "LosAnglas", "6537388926", "smaith@gmail.com"));
        listperson.Add(new AddressBook("SAM", "Rogers", "Main ave,Dayton", 555555, "California", "6537388926", "sam@gmail.com"));
        listperson.Add(new AddressBook("Elon", "Musk", "Main Street NewYork", 5656565, "Wasighton", "6537388926", "Elon@gmail.com"));
        listperson.Add(new AddressBook("Elon", "Musk", "Main Street NewYork", 5656565, "Wasighton", "6537388926", "Elon@gmail.com"));
    }

    //uc3

    private static void editName(List<AddressBook> listperson)
    {
        if (listperson.Any(e => e.FirstName == "Smith"))
        {

            //editing contacts
            listperson.Add(new AddressBook("Den", "Smith", "Main Street NewYork", 5656565, "Wasighton", "6537388926", "Elon@gmail.com"));

        }


    }

    //uc4

    private static void deletename(List<AddressBook> listperson)
    {

        listperson.Remove(new AddressBook("Jhon", "Rogers", "Main Streetnewyork", 555566, "Florida", "6537388920", "jhon@gmail.com"));

    }

    //uc5
    private static void addmultipleName(List<AddressBook> listperson)
    {
        for (int i = 0; i < 2; i++)
        {
            listperson.Add(new AddressBook("Elon", "Musk", "Main Street NewYork", 5656565, "Wasighton", "6537388926", "Elon@gmail.com"));
            listperson.Add(new AddressBook("Jhon", "Rogers", "Main Streetnewyork", 555566, "Florida", "6537388920", "jhon@gmail.com"));
        }
    }



    //uc6

    private static void UniqueName(Hashtable h)
    {
        h.Add(1, new AddressBook("SAM", "Rogers", "Main ave,Dayton", 555555, "California", "6537388926", "sam@gmail.com"));
        h.Add(2, new AddressBook("Jhon", "Rogers", "Main Streetnewyork", 555566, "Florida", "6537388920", "jhon@gmail.com"));
        h.Add(3, new AddressBook("Smith", "Rogers", "12 Main street New York", 556564, "LosAnglas", "6537388926", "smaith@gmail.com"));
        h.Add(4, new AddressBook("Elon", "Musk", "Main Street NewYork", 5656565, "Wasighton", "6537388926", "Elon@gmail.com"));
    }


    private static void AddRecord(List<AdressBook2> listPerson)
    {
        listPerson.Add(new AdressBook2("Nrav", "Rogers", "Main ave,Dayton", 555555, "California", "6537388926", "sam@gmail.com"));
        listPerson.Add(new AdressBook2("Pawan", "Rogers", "Main Streetnewyork", 555566, "Florida", "6537388920", "jhon@gmail.com"));
        listPerson.Add(new AdressBook2("Suraj", "Rogers", "12 Main street New York", 556564, "LosAnglas", "6537388926", "smaith@gmail.com"));
        listPerson.Add(new AdressBook2("Saha", "Rogers", "Main ave,Dayton", 555555, "California", "6537388926", "sam@gmail.com"));
        listPerson.Add(new AdressBook2("Shrey", "Musk", "Main Street NewYork", 5656565, "Wasighton", "6537388926", "Elon@gmail.com"));
        listPerson.Add(new AdressBook2("Mentor", "Codi", "Main Street NewYork", 5656565, "Wasighton", "6537388926", "Elon@gmail.com"));
    }



    private static void uniquename(Hashtable h)
    {
        h.Add(5, new AdressBook2("Nrav", "Rogers", "Main ave,Dayton", 555555, "California", "6537388926", "sam@gmail.com"));
        h.Add(6, new AdressBook2("Pawan", "Rogers", "Main Streetnewyork", 555566, "Florida", "6537388920", "jhon@gmail.com"));

        h.Add(7, new AdressBook2("Suraj", "Rogers", "12 Main street New York", 556564, "LosAnglas", "6537388926", "smaith@gmail.com"));
        h.Add(8, new AdressBook2("Saha", "Rogers", "Main ave,Dayton", 555555, "California", "6537388926", "sam@gmail.com"));
        h.Add(9, new AdressBook2("Shrey", "Musk", "Main Street NewYork", 5656565, "Wasighton", "6537388926", "Elon@gmail.com"));
        h.Add(10, new AdressBook2("Mentor", "Codi", "Main Street NewYork", 5656565, "Wasighton", "6537388926", "Elon@gmail.com"));


        //uc7
        if (h.ContainsKey(10))
        {
            Console.WriteLine(true);
        }
        else { Console.WriteLine(false); }


        //uc8

        //using city and state
        if (h.ContainsValue("California"))
        {
            Console.WriteLine(true);
        }


        else { Console.WriteLine(false); }
        //city
        if (h.Contains("Main ave,Dayton"))
        {
            Console.WriteLine(true);
        }
        else { Console.WriteLine(false); }

        //uc10
        Console.WriteLine(h.Count);

        




    }
    //uc11
    public static void sort(List<AdressBook2> listPerson)
    {
        listPerson.Sort().ToString();
    }





}









