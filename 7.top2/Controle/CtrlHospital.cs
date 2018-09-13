using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controle
{
    public class CtrlHospital
    {
        public static Dictionary<int, Hospital> ListaHospital = new Dictionary<int,Hospital>();
        public static int tamListaHospital = 0;

        public static String[] Ambulatorios = {
                                        "Buco-Facial", 
                                        "Cardiologia", 
                                        "Cirurgia Geral", 
                                        "Cirusgia Plastica", 
                                        "Clinica Medica", 
                                        "Ginecologia", 
                                        "Hematologia", 
                                        "Nefrologia", 
                                        "Neurologia", 
                                        "Odontologia", 
                                        "Ortopedia", 
                                        "Pediatria", 
                                        "Pneumologia", 
                                        "Urologia", 
                                        "Vascular"
                                    };

        // Adiciona Hospital em ListaHospital com verificação
        public static void Add(int id, Hospital h)
        {
            if (!ListaHospital.ContainsKey(id))
            {
                ListaHospital.Add(id, h);
                tamListaHospital++;
            }
            else
            {
                ListaHospital[id] = h;
            }
        }

        // Remove Hospital de ListaHospital com base no id
        public static void Del(int id)
        {
            if (ListaHospital.ContainsKey(id))
            {
                ListaHospital.Remove(id);
                tamListaHospital--;
            }
        }
    }
}
