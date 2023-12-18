﻿using System.ComponentModel.DataAnnotations.Schema;

namespace CV_Project_Group2.Models
{
    public class Address
    {
        public int Id { get; set; }

        public string Address_name { get; set; }

        public string Address_Number { get; set;}

        public string Address_City { get; set; }

        public string Adress_postcode { get; set; }

        public int UserName { get; set; }
        [ForeignKey(nameof(UserName))]
        public virtual User User { get; set; }
    }
}
