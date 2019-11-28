using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InOutApi.Entities
{
    public class Event
    {
        //[ForeignKey("PersonId")]
        //public Person Person { get; set; }
        //public string PersonId { get; set; }

        [Key]
        public string Id { get; set; }

        public string Name { get; set; }

        public Event()
        {

        }

        public Event(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
