/***********************************************************************
 * Module:  User.cs
 * Purpose: Definition of the Class User
 ***********************************************************************/

using System;
using System.ComponentModel;

namespace Model.User
{
   public abstract class User
   {
      public Address address;
      public Contact contact;
      public Notification[] notifications;   //nije odradjeno!!!
   
      protected String name;
      protected String surname;
      protected System.DateTime dateOfBirth;
      protected String jmbg;
      protected String password;

        public Address Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
                OnPropertyChanged("Address");
            }
        }

        public Contact Contact
        {
            get
            {
                return contact;
            }
            set
            {
                contact = value;
                OnPropertyChanged("Contact");
            }
        }

        public String Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
                OnPropertyChanged("UserId");
            }
        }

        public String Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
                OnPropertyChanged("Surname");
            }
        }

        public System.DateTime DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }
            set
            {
                dateOfBirth = value;
                OnPropertyChanged("Surname");
            }
        }

        public String Jmbg
        {
            get
            {
                return jmbg;
            }
            set
            {
                jmbg = value;
                OnPropertyChanged("Jmbg");
            }
        }

        public String Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
                OnPropertyChanged("Password");
            }
        }


        #region INotifyPropertyChanged Members  

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}