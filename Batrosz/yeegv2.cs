using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Account
    {
        private string emailAddress;
        private string name;

        public string getEmailAddress()
        {
            return "email";
        }

        public string getName()
        {
            return "nazwa";
        }

        public void setEmailAddress(string aemailAddress)
        {
            this.emailAddress = aemailAddress;
        }

        public void setName(string aname)
        {
            this.name = aname;
        }
    }
    class contact
    {
        private string emailAddress;
        private string faxNumber;
        public string name;
        private string primaryContactMethod;
        public string getEmailAddress()
        {
            return "email";
        }
        public string getFaxNumber()
        {
            return "fax";
        }
        public string getName()
        {
            return "name";
        }
        public string getPrimaryContactMethod()
        {
            return "primaryContactMethod";
        }
        public void setEmailAddress(string aemailAddress)
        {
            this.emailAddress = aemailAddress;
        }
        public void setFaxNumber(string afaxNumber)
        {
            this.faxNumber = afaxNumber;
        }
        public void setName(string aname)
        {
            this.name = aname;
        }
        public void setPrimaryContactMethod(string aprimaryContactMethod)
        {
            this.primaryContactMethod = aprimaryContactMethod;
        }

    }
    class AddressBook
    {
        private string name;
        private contact contact;

        public contact getContact()
        {
            return contact;
        }
        public contact getContacts()
        {
            return contact;
        }
        public string getName()
        {
            return name;
        }
        public void insertContact(contact aname)
        {
            
        }
        public void setName(string aname)
        {
            this.name = aname;
        }
    }
    class contactBook
    {
        private string name;

        public string getName()
        {
            return name;
        }
        public void setName(string aname)
        {
            this.name = aname;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
