using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewPresenterApp.Models
{
    internal class PetModel
    {
        //Fields
        private int id;
        private string name;
        private string type;
        private string colour;

        //Properties = Validatoions
        public int Id 
        {
            get { return id; } 
            set { id = value; } 
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Type 
        {
            get { return Type; }
            set { Type = value; }
        }


        public string Colour 
        {
            get { return Colour; }
            set { Colour = value; }
        }

    }
}
