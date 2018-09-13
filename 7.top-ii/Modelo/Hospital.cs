using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Hospital
    {
        public int id { get; set; }
        public String nome { get; set; }
        public String endereco { get; set; }
        public String cidade { get; set; }
        public String contato { get; set; }
        // Coordenadas
        public String Lat { get; set; }
        public String Lon { get; set; }
        public String embTop { get; set; }
        public String embLeft { get; set; }
        public String embRight { get; set; }
        public String embBotton { get; set; }
        // Ambulatórios
        public bool bucoFacial { get; set; }
        public bool cardiologia { get; set; }
        public bool cirurgiaGeral { get; set; }
        public bool cirusgiaPlastica { get; set; }
        public bool clinicaMedica { get; set; }
        public bool ginecologia { get; set; }
        public bool hematologia { get; set; }
        public bool nefrologia { get; set; }
        public bool neurologia { get; set; }
        public bool odontologia { get; set; }
        public bool ortopedia { get; set; }
        public bool pediatria { get; set; }
        public bool pneumologia { get; set; }
        public bool urologia { get; set; }
        public bool vascular { get; set; }
    }
}
