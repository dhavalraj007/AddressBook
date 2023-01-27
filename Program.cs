namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("john","wick","121,Mill Neck,Long Island,NY","Long Island","New York","12345","1235566","Johnwick@gmail.com");
            Person p2 = new Person("james","wick","022,Mill Neck,Long Island,NY","small Island","New Jersey","012932","1235566","Johnwick@gmail.com");
            Person pp = new Person("Sherlock", "wicks", "21,some", "London", "England", "2131", "1323214", "sherlockwicks@gmail.com");
            AddressBook ab = new AddressBook("Book 1");
            ab.AddPerson(p1);
            ab.AddPerson(pp);
            ab.AddPerson(p2);
            //System.Console.WriteLine(ab.ToString());

            Person p3 = new Person("Sherlock", "holmes", "221B,Backer street", "London", "England", "562718", "930130431", "benb@gnail.com");
            Person p4 = new Person("John", "watson", "221A,Macker street", "London", "England", "1232123", "540130431", "benb1@gnail.com");
            AddressBook ab2 = new AddressBook("Book 2");
            ab2.AddPerson(p3);
            ab2.AddPerson(p4);
            //Console.WriteLine(ab2.ToString());

            //uc6
            AddressBookSystem abs = new AddressBookSystem();
            abs.AddBook(ab);
            abs.AddBook(ab2);
            //uc8
            /*  abs.displayByCity("London");
              //uc9
              abs.SearchByCity("Sherlock", "London");
              //uc10
              Console.WriteLine("Count of person with city=London is " + abs.CountByCity("London"));*/

            //uc11,12
            ab.SortByFieldPrint(nameof(Person.firstname));
            ab.SortByFieldPrint(nameof(Person.lastname));
            ab.SortByFieldPrint(nameof(Person.city));
            ab.SortByFieldPrint(nameof(Person.state));
            ab.SortByFieldPrint(nameof(Person.zip));
            //ab.SortByFieldPrint("address");

            //uc13
            ab.SerializeObject("C:\\dev\\Training\\Day1\\Sandbox\\AddressBook\\object.txt");
            AddressBook ds = AddressBook.DeserializeObject("C:\\dev\\Training\\Day1\\Sandbox\\AddressBook\\object.txt");
            Console.WriteLine(ds.ToString());

            //uc14
            ab2.SerializePersonsToCSV("C:\\dev\\Training\\Day1\\Sandbox\\AddressBook\\Persons.csv");
            AddressBook csvAb = new AddressBook("CSV Ab");
            csvAb.LoadPersonsFromCSV("C:\\dev\\Training\\Day1\\Sandbox\\AddressBook\\Persons.csv");
            Console.WriteLine(csvAb.ToString());

            //uc15
            ab.SerializeToJson("C:\\dev\\Training\\Day1\\Sandbox\\AddressBook\\JSONobject.json");
            AddressBook jsonAb = AddressBook.DeserializeFromJson("C:\\dev\\Training\\Day1\\Sandbox\\AddressBook\\JSONobject.json");
            Console.WriteLine(jsonAb.ToString());

        }
    }
}
