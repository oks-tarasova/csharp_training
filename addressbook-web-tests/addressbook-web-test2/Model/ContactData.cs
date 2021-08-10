using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
     public class ContactData: IEquatable<ContactData>, IComparable<ContactData>

    {
        private string middlename = "";
        private string nickname = "";
       // private byte photo;
        private string title = "";
        private string company = "";
        private string address = "";
        private int telephone;
        private string home = "";
        private string mobile = "";
        private string work = "";
        private string fax = "";
        private string Email = "";
        private string Email2 = "";
        private string Email3 = "";
        private string homepage = "";
      //  private DateTime birthday;
      //  private DateTime anniversary;
      //  private List<GroupData> group;
        private string secondaryaddress = "";
        private string secondaryhome = "";
        private string secondarynotes = "";


        public ContactData(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }

        public bool Equals(ContactData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return false;
            }
            if (Object.ReferenceEquals(Firstname, other.Firstname))
            {
                return true;
            }
            if (Object.ReferenceEquals(Lastname, other.Lastname))
            {
                return true;
            }
             return Firstname == other.Firstname && Lastname == other.Lastname;
        }

       public int GetHashCode(string firstname, string lastname)
       {
            return GetHashCode(firstname, lastname);
       }

        public override string ToString()
        {
            return "full name=" + Firstname + Lastname;
        }

        public int CompareTo(ContactData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return 1;
            }
            if (Lastname.CompareTo(other.Lastname) == 0)
            {
                return Firstname.CompareTo(other.Firstname);
            }
            return Lastname.CompareTo(other.Lastname);
        }


        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Id { get; set; }

    }
}

