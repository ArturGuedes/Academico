using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dados
{
    public class Conexao
    {
        public static String BD_name = "BancoDados";
        static String BD_pass = "123";
        public static String _path = @"Data Source=" + Application.StartupPath + @"\" + BD_name + ".sdf;Password=" + BD_pass;

        SqlCeConnection con = new SqlCeConnection(_path);

        public String criarBancoDeDados()
        {
            if (File.Exists(Application.StartupPath + @"\" + BD_name + ".sdf"))
            {
                return "Carregando...";
            }

            SqlCeEngine eng = new SqlCeEngine(_path);
            eng.CreateDatabase();

            con.Open();

            String str = "CREATE TABLE Hospital (" +
                            "id         INT NOT NULL PRIMARY KEY," +
                            "nome       NVARCHAR(100)," +
                            "endereco   NVARCHAR(100)," +
                            "cidade     NVARCHAR(100)," +
                            "contato    NVARCHAR(100)," +
                            // Coordenadas
                            "Lat        NVARCHAR(100)," +
                            "Lon        NVARCHAR(100)," +
                            "embTop     NVARCHAR(100)," +
                            "embLeft    NVARCHAR(100)," +
                            "embRight   NVARCHAR(100)," +
                            "embBotton  NVARCHAR(100)," +
                            // Ambulatórios
                            "bucoFacial BIT," +
                            "cardiologia BIT," +
                            "cirurgiaGeral BIT," +
                            "cirusgiaPlastica BIT," +
                            "clinicaMedica BIT," +
                            "ginecologia BIT," +
                            "hematologia BIT," +
                            "nefrologia BIT," +
                            "neurologia BIT," +
                            "odontologia BIT," +
                            "ortopedia BIT," +
                            "pediatria BIT," +
                            "pneumologia BIT," +
                            "urologia BIT," +
                            "vascular BIT" +
                            ")";
            SqlCeCommand cmd = new SqlCeCommand(str, con);

            cmd.ExecuteNonQuery();

            con.Close();

            CargaInicial();

            return "Novo banco de dados criado";
        }

        //Carga de dados de exemplo
        #region Inicial

        private void CargaInicial()
        {
            con.Open();

            String str = "INSERT INTO Hospital VALUES (1,'Hospital Icarai','Marquês de Parana; nº 233','Niterói - RJ','+55 (21) 3176-5000','-22.894448824205256','-43.112872838974','-43.11468333005906','-22.895363058901275','-43.111062347888954','-22.89353705427823','False','True','True','False','False','True','False','False','True','False','True','True','False','False','False');";
            SqlCeCommand cmd = new SqlCeCommand(str, con);
            cmd.ExecuteNonQuery();

            str = "INSERT INTO Hospital VALUES (2,'Hospital Universitário Antonio Pedro','Marquês de Paranánº 303','Niterói - RJ','+55 (21)2629-9000','-22.895459423821134','-43.11190456151962','-43.113245666027076','-22.896371180829142','-43.11056345701218','-22.894545189774483','True','True','True','False','True','False','True','False','True','True','True','True','True','False','True');";
            cmd = new SqlCeCommand(str, con);
            cmd.ExecuteNonQuery();

            str = "INSERT INTO Hospital VALUES (3,'Hospital de Clínicas de Niterói','Rua La Salle nº 12','Niterói - RJ','+55 (21) 2729-1000','-22.894652674367105','-43.1155925989151','-43.11740309000015','-22.89556567224318','-43.113782107830055','-22.89373967034709','False','True','True','False','True','True','False','True','True','False','True','True','False','True','False');";
            cmd = new SqlCeCommand(str, con);
            cmd.ExecuteNonQuery();

            str = "INSERT INTO Hospital VALUES (4,'Hospital de Clínicas Alameda','Alameda São Boaventura nº 321','Niterói - RJ','+55 (21) 3578-3636','-22.880435553602478','-43.101736307144165','-43.103377819061286','-22.88221478293622','-43.10008943080903','-22.878661243352443','False','True','True','True','True','True','False','False','False','False','True','False','False','True','False');";
            cmd = new SqlCeCommand(str, con);
            cmd.ExecuteNonQuery();

            con.Close();
        }

        #endregion
    }
}
