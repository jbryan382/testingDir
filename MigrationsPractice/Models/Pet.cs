using System;

namespace MigrationsPractice.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ArrivalDate { get; set; } = DateTime.Now;
        public int PossibleAdoptionVisits { get; set; } = 0;
        public int NumberOfTimesFed { get; set; }
        
    }
}