using System;

namespace GettersAnd_Setters
{
    class Program
    {
        class Person
        {
            string name;
            int age;
            string gender;
            string idCode;

            public Person(string _name, string _gender, int _age, string _idCode)
            {
                name = _name;
                Gender = _gender;
                age = _age;
                IdCode = _idCode;
            }

            public string Name
            {
                get { return name; }
            }
            public string Gender
            {
                get { return gender; }
                set
                {
                    if (value == "male" || value == "female")
                    {
                        gender = value;
                    }
                    else
                    {
                        gender = "undefined unicorn";
                    }
                }
            }
            public  void ChangeName(string newName)
            {
                name = newName;
            }public string IdCode
            {
                get { return idCode; }
                set
                {
                    if(value.Length == 11)
                    {
                        idCode = value;
                    }
                    else
                    {
                        idCode = "underfined";
                    }
                }
            }
            public void ChangeIdCode(string newCode)
            {
                idCode = newCode;
            }
        }    

        
        
        static void Main(string[] args)
        {
            Person newPerson = new Person("Harry Potter", "gmail", 35, "50405100223");
            Console.WriteLine(newPerson.Name);
            Console.WriteLine(newPerson.Gender);
            Console.WriteLine(newPerson.IdCode);

            newPerson.ChangeName("Harry Potter");
            newPerson.ChangeIdCode("12345");
            Console.WriteLine(newPerson.Name);
            Console.WriteLine(newPerson.IdCode);
            //Console.WriteLine(newPerson.age);
            //newPerson.Name = "Harriette Plotter";
            //newPerson.Gender = "female";
            //newPerson.age = 21;
            //Console.WriteLine(newPerson.Name);
            //Console.WriteLine(newPerson.age);
            //Console.WriteLine(newPerson.Gender);








        }
    }
}
