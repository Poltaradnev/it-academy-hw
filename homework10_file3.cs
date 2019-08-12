using System;
namespace homework10_File3
{
    class Passanger
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PassportNumber { get; set; }

        public Passanger() { }

        public Passanger(string firstName, string lastName, string passportNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PassportNumber = passportNumber;
        }

    }
}