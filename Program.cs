namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("John","wick","121,Mill Neck,Long Island,NY","Long Island","New York","12345","1235566","Johnwick@gmail.com");
            Person p2 = new Person("james","wick","122,Mill Neck,Long Island,NY","Long Island","New York","12345","1235566","Johnwick@gmail.com");
            Person pp = new Person("Sherlock", "wicks", "21,some", "London", "England", "2131", "1323214", "sherlockwicks@gmail.com");
            AddressBook ab = new AddressBook("Book 1");
            ab.AddPerson(p1);
            ab.AddPerson(p2);
            ab.AddPerson(pp);
            System.Console.WriteLine(ab.ToString());

            Person p3 = new Person("Sherlock", "holmes", "221B,Backer street", "London", "England", "1233", "930130431", "benb@gnail.com");
            Person p4 = new Person("John", "watson", "221A,Macker street", "London", "England", "1232123", "540130431", "benb1@gnail.com");
            AddressBook ab2 = new AddressBook("Book 2");
            ab2.AddPerson(p3);
            ab2.AddPerson(p4);
            Console.WriteLine(ab2.ToString());

            //uc6
            AddressBookSystem abs = new AddressBookSystem();
            abs.AddBook(ab);
            abs.AddBook(ab2);
            //uc8
            abs.displayByCity("London");
            //uc9
            abs.SearchByCity("Sherlock", "London");
            //uc10
            Console.WriteLine("Count of person with city=London is " + abs.CountByCity("London"));
        }
    }
}
