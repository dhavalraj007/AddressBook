namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("John","wick","121,Mill Neck,Long Island,NY","Long Island","New York","12345","1235566","Johnwick@gmail.com");
            Person p2 = new Person("james","wick","122,Mill Neck,Long Island,NY","Long Island","New York","12345","1235566","Johnwick@gmail.com");
            AddressBook ab = new AddressBook();
            ab.AddPerson(p1);
            ab.AddPerson(p2);
            System.Console.WriteLine(ab.ToString());
            System.Console.WriteLine("Deleting james wick");
            ab.DeletePerson("james","wick");
            System.Console.WriteLine(ab.ToString());
            System.Console.WriteLine("For editing :\nEnter firstname");
            string fs = Console.ReadLine();
            System.Console.WriteLine("Enter lastname");
            string ls = Console.ReadLine();
            ab.EditPerson(fs,ls);

            System.Console.WriteLine("\n\n updated address book");
            System.Console.WriteLine(ab.ToString());
            
        }
    }
}
