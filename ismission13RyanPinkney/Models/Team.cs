// Author Ryan Pinkney
// This is the team models

using System;
using System.ComponentModel.DataAnnotations;

namespace ismission13RyanPinkney.Models
{
    public class Team
    {

        // Primary key
        [Key]
        [Required]

        public int TeamID { get; set; }

        // Attribute for the team name
        public string TeamName { get; set; }

        // Attribute for the Captin ID
        public int CaptainID { get; set; }

    }
}
