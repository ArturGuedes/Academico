using Modelo;
using Controle;
using Dados;
using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
//using Visao;
//using System.Threading.Tasks;
//using System.Linq;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;


namespace Visao
{
    public partial class Principal : UI.wForm
    {
        public Principal()
        {
            InitializeComponent();
            //CtrlLogin.log = true; // ----------------------
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //CARREGAR_DADOS();
            UI.wAlert.Show("" + new Conexao().criarBancoDeDados(), 2000);
            new DaoHospital().SelectAll();
         
            CreateGrid();
            CreateMap("", "", "-43.16287994384766", "-22.967244600986852", "-42.99121856689454", "-22.85039271274732");

            pContainer.Panel2Collapsed = true;
            UpdateAll("");
        }

        // Dados
        public void CARREGAR_DADOS()
        {
            Hospital h = new Hospital();
            h.id = 1;
            h.nome = "Hospital Icaraí";
            h.contato = "+55 (21) 3176-5000";
            h.endereco = "Marquês de Paraná, nº 233";
            h.cidade = "Niterói - RJ";
            h.Lat = "-22.894448824205256";
            h.Lon = "-43.112872838974";
            h.embTop = "-43.11468333005906";
            h.embLeft = "-22.895363058901275";
            h.embRight = "-43.111062347888954";
            h.embBotton = "-22.89353705427823";

            h.neurologia = true;
            h.cardiologia = true;
            h.cirurgiaGeral = true;
            h.pediatria = true;
            h.ginecologia = true;
            h.ortopedia = true;

            CtrlHospital.Add(h.id, h);


            Hospital h1 = new Hospital();
            h1.id = 2;
            h1.nome = "Hospital Universitário Antonio Pedro";
            h1.contato = "+55 (21) 2629-9000";
            h1.endereco = "Marquês de Paraná, nº 303";
            h1.cidade = "Niterói - RJ";
            h1.Lat = "-22.895459423821134";
            h1.Lon = "-43.11190456151962";
            h1.embTop = "-43.113245666027076";
            h1.embLeft = "-22.896371180829142";
            h1.embRight = "-43.11056345701218";
            h1.embBotton = "-22.894545189774483";

            h1.bucoFacial = true;
            h1.clinicaMedica = true; 
            h1.neurologia = true;
            h1.cardiologia = true;
            h1.cirurgiaGeral = true;
            h1.pediatria = true;
            h1.ortopedia = true;
            h1.odontologia = true;
            h1.pneumologia = true;
            h1.hematologia = true;
            h1.vascular = true;

            CtrlHospital.Add(h1.id, h1);


            Hospital h2 = new Hospital();
            h2.id = 3;
            h2.nome = "Hospital de Clínicas de Niterói";
            h2.contato = "+55 (21) 2729-1000";
            h2.endereco = "Rua La Salle, nº 12";
            h2.cidade = "Niterói - RJ";
            h2.Lat = "-22.894652674367105";
            h2.Lon = "-43.1155925989151";
            h2.embTop = "-43.11740309000015";
            h2.embLeft = "-22.89556567224318";
            h2.embRight = "-43.113782107830055";
            h2.embBotton = "-22.89373967034709";

            h2.urologia = true;
            h2.cirurgiaGeral = true;
            h2.clinicaMedica = true;
            h2.nefrologia = true;
            h2.neurologia = true;
            h2.cardiologia = true;
            h2.pediatria = true;
            h2.ginecologia = true;
            h2.ortopedia = true;
            h1.vascular = true;

            CtrlHospital.Add(h2.id, h2);


            Hospital h3 = new Hospital();
            h3.id = 4;
            h3.nome = "Hospital de Clínicas Alameda";
            h3.contato = "+55 (21) 3578-3636";
            h3.endereco = "Alameda São Boaventura, nº 321";
            h3.cidade = "Niterói - RJ";
            h3.Lat = "-22.880435553602478";
            h3.Lon = "-43.101736307144165";
            h3.embTop = "-43.103377819061286";
            h3.embLeft = "-22.88221478293622";
            h3.embRight = "-43.10008943080903";
            h3.embBotton = "-22.878661243352443";

            h3.urologia = true;
            h3.cirurgiaGeral = true;
            h3.clinicaMedica = true;
            h3.cardiologia = true;
            h3.ginecologia = true;
            h3.ortopedia = true;
            h3.cirusgiaPlastica = true;

            CtrlHospital.Add(h3.id, h3);
        }

        // Funções
        #region Funções

        private void CreateMap(String lat, String lon, String eT, String eL, String eR, String eB)
        {
            webView.Navigate(
                        "https://www.openstreetmap.org/export/embed.html?bbox=" +
                        eT + "%2C" +
                        eL + "%2C" +
                        eR + "%2C" +
                        eB + "&amp;layer=mapnik&amp;marker=" +
                        lat + "%2C" +
                        lon
                        );
        }
        private void CreateGrid() 
        {
            gridView.ColumnCount = 2;
            gridView.RowHeadersWidth = 20;
            gridView.Columns[0].Name = "id";
            gridView.Columns[0].Width = 30;
            gridView.Columns[1].Name = "Hospital";
            gridView.Columns[1].Width = 250;
            //Colunas de dados adicionais [OCULTAS]
            for (int i = 2; i < 11; i++)
			{
                gridView.Columns.Add("" + i, "" + i);
                gridView.Columns[i].Visible = false;
			}
            //Colunas de Ambulatórios
            for (int i = 0; i < 15; i++)
            {
                DataGridViewCheckBoxColumn col = new DataGridViewCheckBoxColumn();
                gridView.Columns.Add(col);
                col.Name = CtrlHospital.Ambulatorios[i];
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                col.SortMode = DataGridViewColumnSortMode.Automatic;
            }
        }
        private void CreateCard(String id, String no, String en, String ci, String co) 
        {
            pCard.Visible = true;
            lblInfo.Text = "Informações#" + id;
            lblNome.Text = no;
            lblContato.Text = co;
            lblEndereco.Text = en + ", " + ci;
        }
        private void UpdateLogin()
        {
            bool logado;
            if (CtrlLogin.log)
            {
                logado = true;
                itemLogin.Text = CtrlLogin.getUser();
            }
            else
            {
                logado = false;
                itemLogin.Text = "Login";
            }

            itemCadastrar.Enabled = logado;
            itemRemover.Enabled = logado;           
            itemSair.Visible = logado;
            pEditar.Visible = logado;
        }      
        private void UpdateAll(String filtro)
        {
            gridView.Rows.Clear();

            int flag = 0;

            foreach (Hospital i in CtrlHospital.ListaHospital.Values)
            {
                if (i.nome.Contains(filtro))
                {
                    if (flag == 0)
                    {
                        CreateCard(
                            i.id.ToString(),
                            i.nome,
                            i.endereco,
                            i.cidade,
                            i.contato
                        );
                        CreateMap(
                            i.Lat,
                            i.Lon,
                            i.embTop,
                            i.embLeft,
                            i.embRight,
                            i.embBotton
                        );
                    }
                    flag++;
                    
                    gridView.Rows.Add(
                        i.id,
                        i.nome,
                        // -- Ocultas
                        i.endereco,
                        i.cidade,
                        i.contato,
                        i.Lat,
                        i.Lon,
                        i.embTop,
                        i.embLeft,
                        i.embRight,
                        i.embBotton,
                        // --
                        i.bucoFacial,
                        i.cardiologia,
                        i.cirurgiaGeral,
                        i.cirusgiaPlastica,
                        i.clinicaMedica,
                        i.ginecologia,
                        i.hematologia,
                        i.nefrologia,
                        i.neurologia,
                        i.odontologia,
                        i.ortopedia,
                        i.pediatria,
                        i.pneumologia,
                        i.urologia,
                        i.vascular
                    );
                }
                txtPesquisar.AutoCompleteCustomSource.Add(i.nome);
            }
        }

        // Janelas
       
        private void ShowLogin()
        {
            UI.wForm login = new Visao.Login();
            login.ShowDialog();
        }
        private void ShowCadastrarHospital()
        {
            UI.wForm f = new Visao.AddHospital();
            f.ShowDialog();
            UpdateAll("");
        }
        private void ShowPrint(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int id = gridView.SelectedRows[0].Index;
            StringBuilder doc = new StringBuilder();
            StringWriter w = new StringWriter(doc);

            // Documento
            w.WriteLine("Hospital: " + Convert.ToString(gridView.Rows[id].Cells[1].Value));
            w.WriteLine("Endereço: " + Convert.ToString(gridView.Rows[id].Cells[2].Value));
            w.WriteLine("Cidade:   " + Convert.ToString(gridView.Rows[id].Cells[3].Value));
            w.WriteLine("Contanto: " + Convert.ToString(gridView.Rows[id].Cells[4].Value));
            w.WriteLine();
            w.WriteLine();
            w.WriteLine("Geolocalização: " + Convert.ToString(gridView.Rows[id].Cells[9].Value) + ", " + Convert.ToString(gridView.Rows[id].Cells[10].Value));
            w.WriteLine();
            w.WriteLine();
            w.WriteLine("Ambulatório(s) existente(s):");
            w.WriteLine();
            for (int i = 0; i < 15; i++) { if (Convert.ToBoolean(gridView.Rows[id].Cells[i + 11].Value)) w.WriteLine(" • " + CtrlHospital.Ambulatorios[i]); }
            w.WriteLine();
            w.WriteLine("------------------------------------------------------------------------------------");
            w.WriteLine(String.Format("Data / Hora da impressão: {0} ", DateTime.Now.ToString()));
            w.Close();

            // Página
            float margemEsquerda = e.MarginBounds.Left;
            float margemTopo = e.MarginBounds.Top;
            float posicaoY = 0;
            Font fonteImpressao = new Font("Arial", 13);
            posicaoY = margemTopo + fonteImpressao.GetHeight(e.Graphics);
            e.HasMorePages = false;
            e.Graphics.DrawString(
                doc.ToString(),
                fonteImpressao,
                Brushes.Black,
                margemEsquerda,
                posicaoY,
                new StringFormat()
                );
        }

        #endregion

        //Eventos

        #region Pesquisar

        private void txtPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UpdateAll(txtPesquisar.Text);
            }
        }
        private void txtPesquisar_Enter(object sender, EventArgs e)
        {
            if (txtPesquisar.Text == "Pesquisar")
            {
                txtPesquisar.Text = "";
            } 
        }
        private void txtPesquisar_Leave(object sender, EventArgs e)
        {
            if (txtPesquisar.Text == "")
            {
                txtPesquisar.Text = "Pesquisar";
                UpdateAll("");
            }
        }

        #endregion

        #region Botões

        private void btnMapaView_Click(object sender, EventArgs e)
        {
            pContainer.Panel2Collapsed = true;
        }
        private void btnListView_Click(object sender, EventArgs e)
        {
            pContainer.Panel1Collapsed = true;
        }
        private void btbSplit_Click(object sender, EventArgs e)
        {
            pContainer.Panel1Collapsed = false;
            pContainer.Panel2Collapsed = false;
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ShowCadastrarHospital();
        }
        private void btnRemover_Click(object sender, EventArgs e)
        {
            int id = gridView.SelectedRows[0].Index;
            if (MessageBox.Show("Deseja remover: " + Convert.ToString(gridView.Rows[id].Cells[1].Value) + "?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //CtrlHospital.Del((int)gridView.Rows[id].Cells[0].Value);
                new Dados.DaoHospital().Del((int)gridView.Rows[id].Cells[0].Value);
                UpdateAll("");
            }
        }

        #endregion

        #region Itens de Menu

        private void itemMapaView_Click(object sender, EventArgs e)
        {
            pContainer.Panel2Collapsed = true;
        }
        private void itemGridView_Click(object sender, EventArgs e)
        {
            pContainer.Panel1Collapsed = true;
        }
        private void itemSplit_Click(object sender, EventArgs e)
        {
            pContainer.Panel1Collapsed = false;
            pContainer.Panel2Collapsed = false;
        }
        private void itemLogin_Click(object sender, EventArgs e)
        {
            ShowLogin();
            UpdateLogin();
        }
        private void itemSair_Click(object sender, EventArgs e)
        {
            CtrlLogin.log = false;
            UpdateLogin();
        }
        private void itemCadastrar_Click(object sender, EventArgs e)
        {
            ShowCadastrarHospital();
        }
        private void itemRemover_Click(object sender, EventArgs e)
        {
            int id = gridView.SelectedRows[0].Index;
            if (MessageBox.Show("Deseja remover: " + Convert.ToString(gridView.Rows[id].Cells[1].Value) + "?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CtrlHospital.Del((int)gridView.Rows[id].Cells[0].Value);
                UpdateAll("");
            }
        }
        private void itemImprimir_Click(object sender, EventArgs e)
        {
            if (Print.ShowDialog() == DialogResult.OK)
            {
                Document.Print();
            }
        }
        private void itemSalvar_Click(object sender, EventArgs e)
        {
            Save.Title = "Salvar Arquivo Texto";
            Save.Filter = "Arquivo de texto | *.txt";
            Save.FilterIndex = 0;
            Save.FileName = "backup_" + DateTime.Now.ToString("ddMMyyyy_HHmmss");
            Save.RestoreDirectory = true;

            if (Save.ShowDialog() == DialogResult.OK)
            {
                DaoBackup.SaveAll(new FileStream(Save.FileName, FileMode.Create));
            }
        }
        private void itemAbrir_Click(object sender, EventArgs e)
        {
            Open.Title = "Open Text File";
            Open.Filter = "TXT files|*.txt";
            if (Open.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(Open.FileName.ToString());
                DaoBackup.carregarTxt(Open.FileName.ToString());
                UpdateAll("");
               // DaoBackup.carregarTxt(new StreamReader(Open.FileName));
            }
        }

        private void itemInformacoes_Click(object sender, EventArgs e)
        {
            UI.wAlert.Show("Diretório do banco de dados:\n" + Application.StartupPath + @"\" + Conexao.BD_name + ".sdf", 0);
        }


        #endregion

        private void gridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = gridView.SelectedRows[0].Index;

            CreateCard(
                Convert.ToString(gridView.Rows[id].Cells[0].Value),
                Convert.ToString(gridView.Rows[id].Cells[1].Value),
                Convert.ToString(gridView.Rows[id].Cells[2].Value),
                Convert.ToString(gridView.Rows[id].Cells[3].Value),
                Convert.ToString(gridView.Rows[id].Cells[4].Value)
            );

            CreateMap(
                Convert.ToString(gridView.Rows[id].Cells[5].Value),
                Convert.ToString(gridView.Rows[id].Cells[6].Value),
                Convert.ToString(gridView.Rows[id].Cells[7].Value),
                Convert.ToString(gridView.Rows[id].Cells[8].Value),
                Convert.ToString(gridView.Rows[id].Cells[9].Value),
                Convert.ToString(gridView.Rows[id].Cells[10].Value)
            );
        }




    }
}
