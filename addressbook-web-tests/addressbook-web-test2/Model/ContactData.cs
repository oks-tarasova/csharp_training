using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
     public class ContactData
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

