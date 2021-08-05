using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
     public class ContactData: IEquatable<ContactData>, IComparable<ContactData>

    {
        private string firstname;
        private string lastname;
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
            this.firstname = firstname;
            this.lastname = lastname;
        }

        public bool Equals(ContactData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return false;
            }
            if (Object.ReferenceEquals(firstname, other.firstname))
            {
                return true;
            }
            if (Object.ReferenceEquals(lastname, other.lastname))
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
            if (lastname.CompareTo(other.lastname) == 0)
            {
                return firstname.CompareTo(other.firstname);
            }
            return lastname.CompareTo(other.lastname);
        }


        public string Firstname
        {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }
        public string Lastname
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname= value;
            }
        }
       
    }
}

