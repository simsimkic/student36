/***********************************************************************
 * Module:  GuestPatient.cs
 * Purpose: Definition of the Class Secretary.GuestPatient
 ***********************************************************************/

using System;

namespace Model.Secretary
{
    [Serializable]
    public class GuestPatient
    {
        // Izmenio sam imena atributa tako da pocinju malim slovom.
        private String name;
        private String surname;
        private System.DateTime beginTime;
        private System.DateTime endTime;
        // Izmenio sam tip atributa id iz "long" u "Guid".
        private Guid id;
        private String contactPhone;
        private System.DateTime dateOfBirth;

        // Dodao sam svojstva koja odgovaraju poljima.
        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public String Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public DateTime BeginTime
        {
            get { return beginTime; }
            set { beginTime = value; }
        }

        public DateTime EndTime
        {
            get { return endTime; }
            set { endTime = value; }
        }

        public Guid ID
        {
            get { return id; }
            set { id = value; }
        }

        public String ContactPhone
        {
            get { return contactPhone; }
            set { contactPhone = value; }
        }

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public GuestPatient() {}

        public GuestPatient(String name, String surname, DateTime beginTime, DateTime endTime, Guid id, String contactPhone,
            DateTime dateOfBirth)
        {
            this.Name = name;
            this.Surname = surname;
            this.BeginTime = beginTime;
            this.EndTime = endTime;
            this.ID = id;
            this.ContactPhone = contactPhone;
            this.DateOfBirth = dateOfBirth;
        }

        public GuestPatient(GuestPatient gp)
        {
            this.Name = gp.Name;
            this.Surname = gp.Surname;
            this.BeginTime = gp.BeginTime;
            this.EndTime = gp.EndTime;
            this.ID = gp.ID;
            this.ContactPhone = gp.ContactPhone;
            this.DateOfBirth = gp.DateOfBirth;
        }
    }
}