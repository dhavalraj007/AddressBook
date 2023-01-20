namespace MyApp
{
    class Person
    {
        public string firstname,lastname,address,city,state,zip,phone,email;

        public Person(string firstname, string lastname, string address, string city, string state, string zip, string phone, string email)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phone = phone;
            this.email = email;
        }

        public override string ToString()
        {
            return nameof(firstname)+": "+firstname+"\n"+nameof(lastname)+": "+lastname+"\n"+nameof(address)+": "+address+"\n"+nameof(city)+": "+city+"\n"+nameof(state)+": "+state+"\n"+nameof(zip)+": "+zip+"\n"+nameof(phone)+": "+phone+"\n"+nameof(email)+": "+email+"\n";
        }
    }
}