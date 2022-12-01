using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalproj
{
    public class Animals
    {
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder($"Pet number = {PetNumber}\n");
            sb.AppendLine($"Type of Pet = {PetType}");
            sb.AppendLine($"Price of pet = {PetPrice}");
            sb.AppendLine($"Breed of pet = {PetBreed}");
            return sb.ToString();
        }
        public Animals()
        {
            throw new System.NotImplementedException();
        }


        [DisplayName("Pet #")]
        public double PetNumber { get; set; }


        [DisplayName("Pet Type")]
        public double PetType { get; set; }


        [DisplayName("Pet Breed")]
        public double PetBreed { get; set; }



        [DisplayName("Pet Price")]
        public double PetPrice { get; set; }



        public Animals(double petType, double petNumber, double petPrice, double petBreed)
        {
            PetNumber = petNumber;
            PetType = petType;
            PetPrice = petPrice;
            PetBreed = petBreed;
        }
    }
}
