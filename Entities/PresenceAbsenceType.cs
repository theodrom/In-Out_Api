﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InOutApi.Entities
{
    public class PresenceAbsenceType
    {
        //[ForeignKey("PersonId")]
        //public Person Person { get; set; }
        //public string PersonId { get; set; }

        [Key]
        public string Id { get; set; }

        public string Name { get; set; }

        public bool IsLongTerm { get; set; }

        public PresenceAbsenceType()
        {
        }

        public PresenceAbsenceType(string id, string name, bool isLongTerm)
        {
            Id = id;
            Name = name;
            IsLongTerm = isLongTerm;
        }
    }
}
