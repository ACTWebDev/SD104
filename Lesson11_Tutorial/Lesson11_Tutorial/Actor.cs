using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace Lesson11_Tutorial
{
    class Actor
    {
        [Key]
        public int actor_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public DateTime last_update { get; set; }

        public Actor(string first_name, string last_name)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.last_update = DateTime.Now;
        }


    }
}





