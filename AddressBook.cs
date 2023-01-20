namespace MyApp
{
    //add,edit,delete
    class AddressBook
    {
        Dictionary<string,Person> name2Person;

        public AddressBook()
        {
            name2Person = new Dictionary<string,Person>();
        }

        public void AddPerson(Person p)
        {
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

        public override string ToString()
        {
            string ret = "";
            foreach(var kvp in name2Person)
            {
                ret+= "\n\n---------------------\n"+ kvp.Value.ToString();
            }
            return ret;
        }
    }
}