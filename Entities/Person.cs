using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InOutApi.Entities
{
    public class Person
    {
        [Key]
        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Speciality { get; set; }

        public List<string> MobileList { get; set; }

        public string Email { get; set; }

        public List<Event> EventList { get; set; }

        public Person()
        {
        }

        public Person(string id, string firstname, string lastname, string speciality, List<string> mobileList, string email, List<Event> eventList)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            Speciality = speciality;
            MobileList = mobileList;
            Email = email;
            EventList = eventList;
        }
    }
}
