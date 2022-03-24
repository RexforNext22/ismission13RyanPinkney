// Author: Ryan Pinkney
// This is the models for the bowler table

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ismission13RyanPinkney.Models
{
    public class Bowler
    {
        // Primary key attribute
        [Key]
        [Required]
        public int BowlerID { get; set; } //If there is only a get, then it is a read-only

        // Bowler first name attribute
        public string BowlerFirstName { get; set; }

        // Bowler last name attribute
        public string BowlerLastName { get; set; }

        // Bowler middle init attribute
        public string BowlerMiddleInit { get; set; }

        // Bowler address attribute
        public string BowlerAddress { get; set; }

        // Bowler City Attribute
        public string BowlerCity { get; set; }

        // Bowler state attribute
        public string BowlerState { get; set; }

        // Bowler zip attribute
        public string BowlerZip { get; set; }

        // Bowler phone attribute
        public string BowlerPhoneNumber { get; set; }


        // Team foreign key relationship
        [ForeignKey("Team")]
        public int TeamID { get; set; }
        public Team Team { get; set; }



    }
}
