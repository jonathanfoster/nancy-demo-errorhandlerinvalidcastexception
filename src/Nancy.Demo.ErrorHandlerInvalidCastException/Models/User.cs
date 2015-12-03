namespace Nancy.Demo.ErrorHandling.Models
{
    using System;

    public class User
    {
        public User() :
            this(null, null)
        {
        }

        public User(string firstName, string lastName)
        {
            throw new Exception();

            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}