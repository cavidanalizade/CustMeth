using System;


namespace PersonTask
{
    internal class Person
    {


        private string fullName;
        public string FullName
        {
            get { return fullName; }
            set
            {
                if (IsValidFullName(value))
                {
                    fullName = value;
                }
                else
                {
                    Console.WriteLine("FulName minimum 2 sozden ibaret olmalidir ve boyuk herfle baslamalidir."); 
                }
            }
        }

        public int Age { get; set; }
        public string PhoneNumber { get; set; }

        private bool IsValidFullName(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName))
            {
                return false;
            }

            string[] nameParts = fullName.Split(' ');
            if (nameParts.Length < 2)
            {
                return false;
            }

            foreach (string namePart in nameParts)
            {
                if (string.IsNullOrWhiteSpace(namePart) || !char.IsUpper(namePart[0]))
                {
                    return false;
                }
            }

            return true;
        }

        public Person(string Fullname , string PhoneNumber , int Age)
        {
            this.FullName = Fullname;
            this.Age = Age;
            this.PhoneNumber = PhoneNumber;
            
        }
    }

}

