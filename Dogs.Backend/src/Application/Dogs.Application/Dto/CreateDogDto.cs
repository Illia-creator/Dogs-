using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogs.Application.Dto
{
    public class CreateDogDto
    {
        public int DogId { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public double TailLenght { get; set; }
        public double Weight { get; set; }
    }
}
