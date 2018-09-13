using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Visao;
using Controle;

namespace Visao
{
    public partial class AddHospital : UI.wForm
    {
        public static int _id;

        public AddHospital()
        {
            InitializeComponent();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Hospital h = new Hospital();
                h.id = Convert.ToInt16(cbId.Text);
                h.nome = txtNome.Text;
                h.endereco = txtEndereco.Text;
                h.cidade = txtCidade.Text;
                h.contato = txtContato.Text;

                h.Lat = txtLat.Text;
                h.Lon = txtLong.Text;

                h.embTop = txtTop.Text;
                h.embLeft = txtLeft.Text;
                h.embRight = txtRight.Text;
                h.embBotton = txtBottom.Text;

                if (ckbBuco.Checked) h.bucoFacial = true;
                if (ckbCardio.Checked) h.cardiologia = true;
                if (ckbCirGeral.Checked) h.cirurgiaGeral = true;
                if (ckbCirPlastica.Checked) h.cirusgiaPlastica = true;
                if (ckbClinica.Checked) h.clinicaMedica = true;
                if (ckbGinec.Checked) h.ginecologia = true;
                if (ckbHema.Checked) h.hematologia = true;
                if (ckbNefro.Checked) h.nefrologia = true;
                if (ckbNeuro.Checked) h.neurologia = true;
                if (ckbOdonto.Checked) h.odontologia = true;
                if (ckbOrto.Checked) h.ortopedia = true;
                if (ckbPedi.Checked) h.pediatria = true;
                if (ckbPneu.Checked) h.pneumologia = true;
                if (ckbUro.Checked) h.urologia = true;
                if (ckbVas.Checked) h.vascular = true;

                //CtrlHospital.Add(h.id, h);
                new Dados.DaoHospital().AddUpdate(h);
                new Dados.DaoHospital().SelectAll();
                this.Close();
            }
            catch (Exception ex)
            {
                UI.wAlert.Show("ERRO: " + ex, 2000);
            }
        }

        private void AddHospital_Load(object sender, EventArgs e)
        {
            int max = 0;
            foreach (Hospital i in CtrlHospital.ListaHospital.Values)
            {
                cbId.Items.Add(i.id);
                if (i.id >= max)
                {
                    max = i.id + 1;
                }
            }
            cbId.Items.Add(max);
            cbId.SelectedItem = max;
        }

        private void cbId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((int)cbId.SelectedItem == CtrlHospital.ListaHospital.Count + 1)
            {
                btnAdicionar.Text = "Adicionar";
            }
            else
            {
                btnAdicionar.Text = "Atualizar";
            }

            
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtCidade.Text = "";
            txtContato.Text = "";
            txtLat.Text = "";
            txtLong.Text = "";
            txtTop.Text = "";
            txtLeft.Text = "";
            txtRight.Text = "";
            txtBottom.Text = "";
            ckbBuco.Checked = false;
            ckbCardio.Checked = false;
            ckbCirGeral.Checked = false;
            ckbCirPlastica.Checked = false;
            ckbClinica.Checked = false;
            ckbGinec.Checked = false;
            ckbHema.Checked = false;
            ckbNefro.Checked = false;
            ckbNeuro.Checked = false;
            ckbOdonto.Checked = false;
            ckbOrto.Checked = false;
            ckbPedi.Checked = false;
            ckbPneu.Checked = false;
            ckbUro.Checked = false;
            ckbVas.Checked = false;


            foreach (Hospital i in CtrlHospital.ListaHospital.Values)
            {
                if (i.id == (int)cbId.SelectedItem)
                {
                    txtNome.Text = i.nome;
                    txtEndereco.Text = i.endereco;
                    txtCidade.Text = i.cidade;
                    txtContato.Text = i.contato;
                    txtLat.Text = i.Lat;
                    txtLong.Text = i.Lon;
                    txtTop.Text = i.embTop;
                    txtLeft.Text = i.embLeft;
                    txtRight.Text = i.embRight;
                    txtBottom.Text = i.embBotton;

                    if (i.bucoFacial){ ckbBuco.Checked = true; }
                    if (i.cardiologia) { ckbCardio.Checked = true; }
                    if (i.cirurgiaGeral) { ckbCirGeral.Checked = true;}
                    if (i.cirusgiaPlastica) { ckbCirPlastica.Checked = true;}
                    if (i.clinicaMedica) { ckbClinica.Checked = true;}
                    if (i.ginecologia) { ckbGinec.Checked = true;}
                    if (i.hematologia) { ckbHema.Checked = true;}
                    if (i.nefrologia) { ckbNefro.Checked = true;}
                    if (i.neurologia) { ckbNeuro.Checked = true;}
                    if (i.odontologia) { ckbOdonto.Checked = true;}
                    if (i.ortopedia) { ckbOrto.Checked = true;}
                    if (i.pediatria) { ckbPedi.Checked = true;}
                    if (i.pneumologia) { ckbPneu.Checked = true;}
                    if (i.urologia) { ckbUro.Checked = true;}
                    if (i.vascular) { ckbVas.Checked = true;}
                }
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
