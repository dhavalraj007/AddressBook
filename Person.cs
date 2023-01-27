namespace MyApp
{
    [Serializable]
    class Person
    {
        public string firstname{get;set;}
        public string lastname { get;set;}
        public string address{get;set;}
        public string city{get;set;}
        public string state{get;set;}
        public string zip{get;set;}
        public string phone{get;set;}
        public string email{get;set;}

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