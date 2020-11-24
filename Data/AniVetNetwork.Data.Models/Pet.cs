using AniVetNetwork.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AniVetNetwork.Data.Models
{
    public class Pet
    {
        public Pet()
        {
        }

        public virtual ApplicationUser User { get; set; }

        public string UserId { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }
        /* Type could be  Mammal, Bird, Fish etc.*/

        public AnimalClass AnimalClass { get; set; }

        public string Breed { get; set; }

        public int Weight { get; set; }

    }
}
