using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controle;
using Modelo;
using System.Windows.Forms;

namespace Dados
{
    public class DaoBackup
    {
        private static String separador = ";";

        public static void SaveAll(FileStream f)
        {
            StreamWriter escrita = new StreamWriter(f);
            foreach (Hospital i in CtrlHospital.ListaHospital.Values)
            {
                escrita.WriteLine(
                    i.id + separador +
                    i.nome + separador +
                    i.endereco + separador +
                    i.cidade + separador +
                    i.contato + separador +
                    i.Lat + separador +
                    i.Lon + separador +
                    i.embTop + separador +
                    i.embLeft + separador +
                    i.embRight + separador +
                    i.embBotton + separador +
                    i.bucoFacial + separador +
                    i.cardiologia + separador +
                    i.cirurgiaGeral + separador +
                    i.cirusgiaPlastica + separador +
                    i.clinicaMedica + separador +
                    i.ginecologia + separador +
                    i.hematologia + separador +
                    i.nefrologia + separador +
                    i.neurologia + separador +
                    i.odontologia + separador +
                    i.ortopedia + separador +
                    i.pediatria + separador +
                    i.pneumologia + separador +
                    i.urologia + separador +
                    i.vascular
                    );
            }
            escrita.Close();
        }

        public static void carregarTxt(String _path)
        {
            try
            {
                StreamReader leitor = new StreamReader(_path);
                Dictionary<int, Hospital> lista = new Dictionary<int, Hospital>();

                char[] separadorLinhas = { '\n' };
                char[] separadorColunas = { ';' };

                String arquivo = leitor.ReadToEnd();
                String[] linhas = arquivo.Split(separadorLinhas);

                for (int i = 0; i < linhas.Length - 1; i++)
                {
                    String[] col = linhas[i].Split(separadorColunas);

                    Hospital h = new Hospital();

                    h.id = int.Parse(col[0]); 
                    h.nome = col[1];
                    h.endereco = col[2];
                    h.cidade = col[3];
                    h.contato = col[4];
                    h.Lat = col[5];
                    h.Lon = col[6];
                    h.embTop = col[7];
                    h.embLeft = col[8];
                    h.embRight = col[9];
                    h.embBotton = col[10];
                    h.bucoFacial = Convert.ToBoolean(col[11]);
                    h.cardiologia = Convert.ToBoolean(col[12]);
                    h.cirurgiaGeral = Convert.ToBoolean(col[13]);
                    h.cirusgiaPlastica = Convert.ToBoolean(col[14]);
                    h.clinicaMedica = Convert.ToBoolean(col[15]);
                    h.ginecologia = Convert.ToBoolean(col[16]);
                    h.hematologia = Convert.ToBoolean(col[17]);
                    h.nefrologia = Convert.ToBoolean(col[18]);
                    h.neurologia = Convert.ToBoolean(col[19]);
                    h.odontologia = Convert.ToBoolean(col[20]);
                    h.ortopedia = Convert.ToBoolean(col[21]);
                    h.pediatria = Convert.ToBoolean(col[22]);
                    h.pneumologia = Convert.ToBoolean(col[23]);
                    h.urologia = Convert.ToBoolean(col[24]);
                    h.vascular = Convert.ToBoolean(col[25]);

                    lista.Add(h.id, h);
                }

                CtrlHospital.ListaHospital.Clear();
                CtrlHospital.ListaHospital = lista;
            }
            catch (Exception e)
            {
                MessageBox.Show(""+e);
            }
        }
    }
}
