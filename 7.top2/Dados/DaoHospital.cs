using Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    public class DaoHospital
    {
        SqlCeConnection con = new SqlCeConnection(Conexao._path);

        public Dictionary<int, Hospital> SelectAll()
        {
            Controle.CtrlHospital.ListaHospital.Clear();
            Dictionary<int, Hospital> ListaHospital = new Dictionary<int, Hospital>();
            con.Open();

            string str = "SELECT * FROM Hospital";
            SqlCeCommand cmd = new SqlCeCommand(str, con);

            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Hospital h = new Hospital();
                h.id = (int)reader["id"];
                h.nome = (String)reader["nome"];
                h.endereco = (String)reader["endereco"];
                h.cidade = (String)reader["cidade"];
                h.contato = (String)reader["contato"];

                h.Lat = (String)reader["Lat"];
                h.Lon = (String)reader["Lon"];
                h.embTop = (String)reader["embTop"];
                h.embLeft = (String)reader["embLeft"];
                h.embRight = (String)reader["embRight"];
                h.embBotton = (String)reader["embBotton"];

                h.bucoFacial = (bool)reader["bucoFacial"];
                h.cardiologia = (bool)reader["cardiologia"];
                h.cirurgiaGeral = (bool)reader["cirurgiaGeral"];
                h.cirusgiaPlastica = (bool)reader["cirusgiaPlastica"];
                h.clinicaMedica = (bool)reader["clinicaMedica"];
                h.ginecologia = (bool)reader["ginecologia"];
                h.hematologia = (bool)reader["hematologia"];
                h.nefrologia = (bool)reader["nefrologia"];
                h.neurologia = (bool)reader["neurologia"];
                h.odontologia = (bool)reader["odontologia"];
                h.ortopedia = (bool)reader["ortopedia"];
                h.pediatria = (bool)reader["pediatria"];
                h.pneumologia = (bool)reader["pneumologia"];
                h.urologia = (bool)reader["urologia"];
                h.vascular = (bool)reader["vascular"];

                Controle.CtrlHospital.ListaHospital.Add((int)reader["id"], h);
            }


            con.Close();

            return ListaHospital;

        }

        public void AddUpdate(Hospital h)
        {
            con.Open();

            string str = "SELECT * FROM Hospital";
            SqlCeCommand cmd = new SqlCeCommand(str, con);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if ((int)reader["id"] == h.id)
                {
                    str = "UPDATE Hospital SET " +
                        "id = " + h.id + "," +
                        "nome = '" + h.nome + "'," +
                        "endereco = '" + h.endereco + "'," +
                        "cidade = '" + h.cidade + "'," +
                        "contato = '" + h.contato + "'," +
                        "Lat = '" + h.Lat + "'," +
                        "Lon = '" + h.Lon + "'," +
                        "embTop = '" + h.embTop + "'," +
                        "embLeft = '" + h.embLeft + "'," +
                        "embRight = '" + h.embRight + "'," +
                        "embBotton = '" + h.embBotton + "'," +
                        "bucoFacial = '" + h.bucoFacial + "'," +
                        "cardiologia = '" + h.cardiologia + "'," +
                        "cirurgiaGeral = '" + h.cirurgiaGeral + "'," +
                        "cirusgiaPlastica = '" + h.cirusgiaPlastica + "'," +
                        "clinicaMedica = '" + h.clinicaMedica + "'," +
                        "ginecologia = '" + h.ginecologia + "'," +
                        "hematologia = '" + h.hematologia + "'," +
                        "nefrologia = '" + h.nefrologia + "'," +
                        "neurologia = '" + h.neurologia + "'," +
                        "odontologia = '" + h.odontologia + "'," +
                        "ortopedia = '" + h.ortopedia + "'," +
                        "pediatria = '" + h.pediatria + "'," +
                        "pneumologia = '" + h.pneumologia + "'," +
                        "urologia = '" + h.urologia + "'," +
                        "vascular = '" + h.vascular + "' " +
                        "WHERE id=" + h.id;
                    cmd = new SqlCeCommand(str, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return;
                }
            }

            str = "INSERT INTO Hospital VALUES (" +
                        h.id + ",'" +
                        h.nome + "','" +
                        h.endereco + "','" +
                        h.cidade + "','" +
                        h.contato + "','" +
                        h.Lat + "','" +
                        h.Lon + "','" +
                        h.embTop + "','" +
                        h.embLeft + "','" +
                        h.embRight + "','" +
                        h.embBotton + "','" +
                        h.bucoFacial + "','" +
                        h.cardiologia + "','" +
                        h.cirurgiaGeral + "','" +
                        h.cirusgiaPlastica + "','" +
                        h.clinicaMedica + "','" +
                        h.ginecologia + "','" +
                        h.hematologia + "','" +
                        h.nefrologia + "','" +
                        h.neurologia + "','" +
                        h.odontologia + "','" +
                        h.ortopedia + "','" +
                        h.pediatria + "','" +
                        h.pneumologia + "','" +
                        h.urologia + "','" +
                        h.vascular + "');";
            cmd = new SqlCeCommand(str, con);
            cmd.ExecuteNonQuery();

            con.Close();
        }

        public void Del(int id)
        {
            con.Open();
            String str = "DELETE FROM Hospital WHERE id=" + id;
            SqlCeCommand cmd = new SqlCeCommand(str, con);
            cmd.ExecuteNonQuery();
            con.Close();
            SelectAll();
        }
    }
}
