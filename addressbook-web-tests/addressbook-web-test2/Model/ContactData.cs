using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

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
        private string homepage = "";
      //  private DateTime birthday;
      //  private DateTime anniversary;
      //  private List<GroupData> group;
        private string secondaryaddress = "";
        private string secondaryhome = "";
        private string secondarynotes = "";
        private string allPhones;
        private string allEmails;

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

        public string Address { get; set; }
        public string HomePhone { get; set; }
        public string MobilePhone { get; set; }
        public string WorkPhone { get; set; }
        public string Email { get; set; }
        public string Email2 { get; set; }
        public string Email3 { get; set; }

        public string AllPhones
        {
            get 
            {
                if(allPhones !=null)
                {
                    return allPhones;
                }
                else
                {
                    return (CleanUp(HomePhone) + CleanUp(MobilePhone) + CleanUp(WorkPhone)).Trim();
                }
            }
            set {
                allPhones = value;
            }
        }

        private string CleanUp(string data)
        {
            if ( data == null || data == "")
            {
                return "";
            }
            return Regex.Replace(data, "[ -()]", "") + "\r\n";
        }

        public string AllEmails
        {
            get
            {
                if (allEmails != null)
                {
                    return allEmails;
                }
                else
                {
                    return CleanUp(Email) + CleanUp(Email2) + CleanUp(Email3).Trim();
                }
            }
            set
            {
                allEmails = value;
            }
        }

    }
}

