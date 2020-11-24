using AniVetNetwork.Data.Models.Enums;

namespace AniVetNetwork.Data.Models
{
    public class PetProfile
    {
        public PetProfile()
        {
        }

        public int Id { get; set; }

        public virtual Pet Pet { get; set; }

        public int PetId { get; set; }

        public string Diagnose { get; set; }

        public string Recipe { get; set; }

        public string Treatment { get; set; }

        public TreatmentStatus TreatmentStatus { get; set; }

        public string VeterinaryComment { get; set; }

        // TODO: Veterinary ID
    }
}
