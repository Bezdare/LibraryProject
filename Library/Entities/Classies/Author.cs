namespace Entities.Classies
{
    public class Authors
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Middlname { get; private set; }
        
        public Authors( string name)
        {
            Name = name;
            Surname = string.Empty;
            Middlname = string.Empty;
        }
        
        public Authors( string name, string surname)
        {
            Name = name;
            Surname = surname;
            Middlname = string.Empty;
        }
        
        public Authors( string name, string surname, string middlname)
        {
            Name = name;
            Surname = surname;
            Middlname = middlname;
        }

        public bool NameIsEmpty => Name == string.Empty;
        public bool SurnameIsEmpty => Surname == string.Empty;
        public bool MiddlnameIsEmpty => Middlname == string.Empty;

        public bool AuthorIsEmpty => NameIsEmpty && SurnameIsEmpty && MiddlnameIsEmpty;

        public override string ToString()
        {
            if(SurnameIsEmpty && MiddlnameIsEmpty)
                return $"{Name}";
            
            if(MiddlnameIsEmpty)
                return $"{Name} {Surname}";
            
            if(SurnameIsEmpty)
                return $"{Name} {Middlname}";
            
            return $"{Name} {Surname} {Middlname}";
        }
    }
}