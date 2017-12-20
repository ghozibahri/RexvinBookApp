using System;
using System.Collections.Generic;
using System.Text;

namespace RexvinBooking.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User() { }
        public User(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;

        }

        public bool CheckInformation()
        {
            if (this.Username == null && this.Password == null)
            {
                return false;
            }
            else if(this.Username == ("") || this.Password == null)
            {
                return false;
            }
            else if (this.Username == null || this.Password == (""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
