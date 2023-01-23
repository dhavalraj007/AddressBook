using System.Security.Cryptography;

namespace MyApp
{
    //add,edit,delete
    class AddressBook
    {
        Dictionary<string,Person> name2Person;
        public string name;
        public AddressBook(string name)
        {
            this.name = name;
            name2Person = new Dictionary<string,Person>();
        }

        public void AddPerson(Person p)
        {
            if(name2Person.ContainsKey(p.firstname+p.lastname))
            {
                throw new Exception("person already exists");
            }
            name2Person[p.firstname+p.lastname] = p;
        }

        public void DeletePerson(string firstname,string lastname)
        {
            name2Person.Remove(firstname+lastname);
        }

        public Person? SearchPerson(string firstname,string lastname)
        {
            if(name2Person.ContainsKey(firstname+lastname))
                return name2Person[firstname+lastname];
            else
                return null;
        }

        public void EditPerson(string firstname,string lastname)
        {
            Person? p  = SearchPerson(firstname,lastname);
            if(p is null)
            {
                System.Console.WriteLine($"Not found! : Can't find Person with name {firstname} {lastname}.");
                return;
            }

            System.Console.WriteLine($"found a Person with name {firstname} {lastname}.");
            System.Console.WriteLine("Enter what do you want to edit.");
            string? toedit = Console.ReadLine();
            while(toedit is null)
            {
                System.Console.WriteLine("Enter what do you want to edit.");
                toedit = Console.ReadLine();
            }
            System.Console.WriteLine($"Enter the new data for {toedit}");
            string? newData = Console.ReadLine();
            if(newData is null)
                newData = "";
            switch(toedit)
            {
                case nameof(p.firstname):
                    name2Person.Remove(p.firstname+p.lastname);
                    p.firstname = newData;
                    name2Person[p.firstname+p.lastname] = p;
                    break;
                case nameof(p.lastname):
                    name2Person.Remove(p.firstname+p.lastname);
                    p.lastname= newData;
                    name2Person[p.firstname+p.lastname] = p;
                    break;
                case nameof(p.address):
                    p.address= newData;
                    break;
                case nameof(p.state):
                    p.state = newData;
                    break;
                case nameof(p.city):
                    p.city= newData;
                    break;
                case nameof(p.zip):
                    p.zip= newData;
                    break;
                case nameof(p.phone):
                    p.phone= newData;
                    break;
                case nameof(p.email):
                    p.email= newData;
                    break;
            }
            System.Console.WriteLine("Updated!");
        }

        public void displayByCity(string city)
        {
            Console.WriteLine("Persons with city = "+city + " in book: "+name+"\n---------------");
            foreach(var p in name2Person)
            {
                if(p.Value.city==city)
                {
                    Console.WriteLine(p.Value.ToString());
                }
            }
        }

        public IEnumerable<Person> SearchByCity(string fname,string city)
        {
            IEnumerable<Person> p = from kvp in name2Person
                                    where kvp.Value.city == city && kvp.Value.firstname==fname
                                    select kvp.Value;
            return p;
        }

        public IEnumerable<Person> GetAllPersons()
        {
            return name2Person.Values;
        }

        public override string ToString()
        {
            string ret = "------------------\n\t"+name+"\n--------------------";
            foreach(var kvp in name2Person)
            {
                ret+= "\n\n---------------------\n"+ kvp.Value.ToString();
            }
            return ret;
        }
    }

    class AddressBookSystem
    {
        Dictionary<string, AddressBook> name2book;
        public AddressBookSystem() { 
            name2book = new Dictionary<string, AddressBook>();
        }

        public void AddBook(AddressBook ab)
        {
            name2book[ab.name] = ab;
        }

        public void displayByCity(string city)
        {
            foreach(var kvp in name2book)
            {
                kvp.Value.displayByCity(city);
            }
        }

        public void SearchByCity(string fname,string city)
        {
            Console.WriteLine($"Persons with firstname = {fname} and city = {city} \n---------------");
            foreach(var kvp in name2book)
            {
                foreach(Person p in kvp.Value.SearchByCity(fname,city))
                {
                    Console.WriteLine(p.ToString());
                }
            }
        }

        public int CountByCity(string city)
        {
            int c = (from book in name2book.Values
                     from person in book.GetAllPersons()
                     where person.city == city
                     select person).Count();
            return c;
        }
    }
}