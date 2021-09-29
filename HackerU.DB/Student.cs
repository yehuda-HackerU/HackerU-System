using System;
using System.Collections.Generic;

namespace HackerU.DB
{
    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime DOB { get; set; }
        public string City { get; set; }
        public List<Cuorse> Courses { set; get; } = new List<Cuorse>();
        public int AmuontToPay { get; set; }
        public int AmuontPaid { get; set; } = 0;

        public Student(int id, string firstName, string lastName, string phoneNumber, string email, DateTime dob, string city, List<Cuorse> courses, int amuontToPay, int amuontPaid)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
            DOB = dob;
            City = city;
            Courses = courses;
            AmuontToPay = amuontToPay;
            AmuontPaid = amuontPaid;
        }


        /// <summary>
        /// !!!!! temp !!!!!
        /// </summary>
        
        public Student(int iD, string firstName, string lastName, string phoneNumber, string email, DateTime dOB, string city)
        {
            ID = iD;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
            DOB = dOB;
            City = city;
        }
    }
}
