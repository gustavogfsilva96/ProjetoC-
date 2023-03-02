using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace tela_17_08
{
    public partial class cadaluno : Form
    {
        int x;
        public cadaluno()
        {
            InitializeComponent();
            button3.BackColor = Color.LightGray;
            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=?????;uid=root;pwd=\"?????\";";
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from alunos;", cnn);
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    string[] row =
                        {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4),
                        reader.GetString(5),
                        reader.GetString(6),
                    };
                    var linha_listview = new ListViewItem(row);
                    listView2.Items.Add(linha_listview);
                }
            }
            finally { }
            cnn.Close();
            try
            {
                cnn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from crsos;", cnn);
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    string[] row =
                        {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4),
                        reader.GetString(5),
                        reader.GetString(6),
                    };
                    var linha_listview = new ListViewItem(row);
                    listView1.Items.Add(linha_listview);
                }
            }

            finally { }

            cnn.Close();
        }

        private void lb_escot4_Click(object sender, EventArgs e)
        {

        }

        private void tb_t5idade_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_t4cadastro_Click(object sender, EventArgs e)
        {

        }

        private void bt_fechart4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tela4_Load(object sender, EventArgs e)
        {

        }

        private void bt_cadastraraluno_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Confirmar cadastro?", "Confimação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string connetionString = null;
                MySqlConnection cnn;
                connetionString = "server=localhost;database=?????;uid=root;pwd=\"?????\";";
                cnn = new MySqlConnection(connetionString);
                if (x == 2)
                {
                    button2.Enabled = true;
                    button1.Enabled = true;
                    if (tb_nomeal.Text != "")
                    {
                        string cod = "Id";
                        string[] row = { cod, tb_nomeal.Text, comboBox1.Text, tb_contato.Text, tb_idadeal.Text, tb_cep.Text, tb_ncep.Text };
                        var listViewItemal = new ListViewItem(row);
                        listView2.Items.Add(listViewItemal);

                        try
                        {
                            cnn.Open();
                            MySqlCommand cmd = new MySqlCommand("INSERT INTO alunos (id, nome,escolariedade,contato,idade,cep,numero ) VALUES (DEFAULT,'" + tb_nomeal.Text + "', '" + comboBox1.Text + "', '" + tb_contato.Text + "', " + tb_idadeal.Text + ", '" + tb_cep.Text + "', '" + tb_ncep.Text + "');", cnn);
                            cmd.ExecuteNonQuery();
                            cnn.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        finally { }
                        cnn.Close();
                        tb_nomeal.Text = "";
                        tb_idadeal.Text = "";
                        tb_contato.Text = "";
                        comboBox1.Text = "";
                        tb_cep.Text = "";
                        tb_ncep.Text = "";
                        MessageBox.Show("Aluno cadastrado! Atualize a lista");
                    }
                }
                else
                {
                    bt_cadastraraluno.Enabled = false;
                    bt_editaraluno.Enabled = false;
                    bt_confirmaedite.Enabled = false;
                    bt_excluiraluno.Enabled = false;
                    bt_cance.Enabled = false;
                    button1.Enabled = false;
                    button2.Enabled = false;
                }
            if (x == 1)
            {
                button2.Enabled = false;
                button1.Enabled = false;
                if (tb_nomeal.Text != "")
                {
                    string cod = "Id";
                    string[] row = { cod, tb_nomeal.Text, tb_idadeal.Text, tb_contato.Text, tb_ncep.Text, tb_cep.Text, comboBox1.Text };
                    var listViewItemal = new ListViewItem(row);
                    listView1.Items.Add(listViewItemal);
                    try
                    {
                        cnn.Open();
                        MySqlCommand cmd = new MySqlCommand("INSERT INTO crsos (id, nome,vagas,valor,idade,carga_horaria,escolariedade ) VALUES (DEFAULT,'" + tb_nomeal.Text + "', '" + tb_idadeal.Text + "', '" + tb_contato.Text + "', " + tb_ncep.Text + ", '" + tb_cep.Text + "', '" + comboBox1.Text + "');", cnn);
                        cmd.ExecuteNonQuery();
                        cnn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally { }
                    cnn.Close();
                    tb_nomeal.Text = "";
                    tb_idadeal.Text = "";
                    tb_contato.Text = "";
                    comboBox1.Text = "";
                    tb_cep.Text = "";
                    tb_ncep.Text = "";
                    MessageBox.Show("Curso cadastrado! Atualize a lista");
                }
            }
                    else
                    {
                        bt_cadastraraluno.Enabled = false;
                        bt_editaraluno.Enabled = false;
                        bt_confirmaedite.Enabled = false;
                        bt_excluiraluno.Enabled = false;
                        bt_cance.Enabled = false;
                        button1.Enabled = false;
                        button2.Enabled = false;
                    }
                bt_cadastraraluno.Enabled = false;
                bt_editaraluno.Enabled = false;
                bt_confirmaedite.Enabled = false;
                bt_excluiraluno.Enabled = false;
                bt_cance.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.BackColor = Color.LightGreen;
            }
    }      

        private void bt_editaraluno_Click(object sender, EventArgs e)
        {
            if (x == 1)
            {
                int aluno = listView1.SelectedIndices[0];
                tb_nomeal.Text = listView1.Items[aluno].SubItems[1].Text;
                tb_idadeal.Text = listView1.Items[aluno].SubItems[2].Text;
                tb_contato.Text = listView1.Items[aluno].SubItems[3].Text;
                comboBox1.Text = listView1.Items[aluno].SubItems[6].Text;
                tb_cep.Text = listView1.Items[aluno].SubItems[5].Text;
                tb_ncep.Text = listView1.Items[aluno].SubItems[4].Text;
            }
            if(x==2)
            {
                int aluno = listView2.SelectedIndices[0];
                tb_nomeal.Text = listView2.Items[aluno].SubItems[1].Text;
                tb_idadeal.Text = listView2.Items[aluno].SubItems[4].Text;
                tb_contato.Text = listView2.Items[aluno].SubItems[3].Text;
                comboBox1.Text = listView2.Items[aluno].SubItems[2].Text;
                tb_cep.Text = listView2.Items[aluno].SubItems[5].Text;
                tb_ncep.Text = listView2.Items[aluno].SubItems[6].Text;
            }

            bt_cadastraraluno.Enabled = false;
            bt_editaraluno.Enabled = false;
            bt_confirmaedite.Enabled = true;
            bt_excluiraluno.Enabled = false;
            bt_cance.Enabled = true;

        }

        private void bt_excluiraluno_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Confirma exclusão?", "Confimação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string connetionString = null;
                MySqlConnection cnn;
                connetionString = "server=localhost;database=?????;uid=root;pwd=\"??????\";";
                cnn = new MySqlConnection(connetionString);
                if (x == 1)
                {
                    int exc = listView1.SelectedIndices[0];
                    if (exc >= 0)
                    {
                        try
                        {
                            cnn.Open();

                            MySqlCommand cmd = new MySqlCommand("DELETE  FROM alunos_has_crsos WHERE crsos_id = " + listView1.Items[exc].SubItems[0].Text + " ;", cnn);
                            cmd.ExecuteNonQuery();
                            cnn.Close();
                            
                            cnn.Open();

                            MySqlCommand cmdd = new MySqlCommand("DELETE  FROM crsos WHERE id = " + listView1.Items[exc].SubItems[0].Text + " ;", cnn);
                            cmdd.ExecuteNonQuery();
                            cnn.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                    MessageBox.Show("Registro apagado! Atualize a lista");
                }
                if (x == 2)
                {
                    int exc = listView2.SelectedIndices[0];
                    if (exc >= 0)
                    {
                        try
                        {
                            cnn.Open();
                            MySqlCommand cmd = new MySqlCommand("DELETE  FROM alunos_has_crsos WHERE alunos_id = " + listView2.Items[exc].SubItems[0].Text + " ;", cnn);
                            cmd.ExecuteNonQuery();
                            cnn.Close();

                            cnn.Open();
                            MySqlCommand cmdd = new MySqlCommand("DELETE  FROM alunos WHERE id = " + listView2.Items[exc].SubItems[0].Text + " ;", cnn);
                            cmdd.ExecuteNonQuery();
                            cnn.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                    MessageBox.Show("Registro apagado! Atualize a lista");
                }
                bt_cadastraraluno.Enabled = false;
                bt_editaraluno.Enabled = false;
                bt_confirmaedite.Enabled = false;
                bt_excluiraluno.Enabled = false;
                bt_cance.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.BackColor = Color.LightGreen;
            }
        }

        private void bt_confirmaedite_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Confirma edição?", "Confimação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string connetionString = null;
                MySqlConnection cnn;
                connetionString = "server=localhost;database=?????;uid=root;pwd=\"?????\";";
                cnn = new MySqlConnection(connetionString);
                if (x == 1)
                {
                    int exc = listView1.SelectedIndices[0];
                    if (exc >= 0)
                    {

                        int aluno = listView1.SelectedIndices[0];

                        listView1.Items[aluno].SubItems[1].Text = tb_nomeal.Text;
                        listView1.Items[aluno].SubItems[2].Text = tb_idadeal.Text;
                        listView1.Items[aluno].SubItems[3].Text = tb_contato.Text;
                        listView1.Items[aluno].SubItems[6].Text = comboBox1.Text;
                        listView1.Items[aluno].SubItems[5].Text = tb_cep.Text;
                        listView1.Items[aluno].SubItems[4].Text = tb_ncep.Text;
                        try
                        {
                            cnn.Open();
                            MySqlCommand cmd = new MySqlCommand("UPDATE crsos SET nome = '" + tb_nomeal.Text + "',vagas = '" + tb_idadeal.Text + "',valor = '" + tb_contato.Text + "',idade = " + tb_ncep.Text + ",carga_horaria = '" + tb_cep.Text + "',escolariedade = '" + comboBox1.Text + "'WHERE id = " + listView1.Items[exc].SubItems[0].Text + ";", cnn);
                            cmd.ExecuteNonQuery();
                            cnn.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                }
                if (x == 2)
                {
                    int exc = listView2.SelectedIndices[0];
                    if (exc >= 0)
                    {
                        int aluno = listView2.SelectedIndices[0];

                        listView2.Items[aluno].SubItems[1].Text = tb_nomeal.Text;
                        listView2.Items[aluno].SubItems[4].Text = tb_idadeal.Text;
                        listView2.Items[aluno].SubItems[3].Text = tb_contato.Text;
                        listView2.Items[aluno].SubItems[2].Text = comboBox1.Text;
                        listView2.Items[aluno].SubItems[5].Text = tb_cep.Text;
                        listView2.Items[aluno].SubItems[6].Text = tb_ncep.Text;
                        try
                        {
                            cnn.Open();
                            MySqlCommand cmd = new MySqlCommand("UPDATE alunos SET nome = '" + tb_nomeal.Text + "',escolariedade = '" + comboBox1.Text + "',contato = '" + tb_contato.Text + "',idade = " + tb_idadeal.Text + ",cep = '" + tb_cep.Text + "',numero = '" + tb_ncep.Text + "' WHERE id = " + listView2.Items[exc].SubItems[0].Text + ";", cnn);
                            cmd.ExecuteNonQuery();
                            cnn.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                }
            }
            tb_nomeal.Text = "";
            tb_idadeal.Text = "";
            tb_contato.Text = "";
            comboBox1.Text = "";
            tb_cep.Text = "";
            tb_ncep.Text = "";

            MessageBox.Show("Registro editado com sucesso! Atualize a lista");

            bt_cadastraraluno.Enabled = false;
            bt_editaraluno.Enabled = false;
            bt_confirmaedite.Enabled = false;
            bt_excluiraluno.Enabled = false;
            bt_cance.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.BackColor = Color.LightGreen;
        }
        private void bt_cance_Click(object sender, EventArgs e)
        {
            tb_nomeal.Text = "";
            tb_idadeal.Text = "";
            tb_contato.Text = "";
            comboBox1.Text = "";
            tb_cep.Text = "";
            tb_ncep.Text = "";
            bt_cadastraraluno.Enabled = false;
            bt_editaraluno.Enabled = false;
            bt_confirmaedite.Enabled = false;
            bt_excluiraluno.Enabled = false;
            bt_cance.Enabled = false;
            button1.Enabled = true;
            button2.Enabled = true;
            MessageBox.Show("Opção cancelada! Atualize a lista");
            button3.BackColor = Color.LightGreen;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count < 0)
            {
                bt_excluiraluno.Enabled = false;
                bt_editaraluno.Enabled = false;
                bt_cance.Enabled = false;
            }
            else
            {
                bt_editaraluno.Enabled = true;
                bt_excluiraluno.Enabled = true;
                bt_cance.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lb_nome.Text = "Curso";
            lb_idade.Text = "Vagas";
            lb_contato.Text = "Valor";
            lb_numero.Text = "Idade";
            lb_cep.Text = "Carga Horaria";
            x = 1;
            button2.Enabled = false;
            button1.Enabled = false;
            bt_cance.Enabled = true;
            bt_cadastraraluno.Enabled = true;
            listView2.Enabled = false;
            listView1.Enabled = true;
            button3.BackColor = Color.LightGray;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lb_nome.Text = "Nome";
            lb_idade.Text = "Idade";
            lb_contato.Text = "Contato";
            lb_numero.Text = "N°";
            lb_cep.Text = "CEP";
            x = 2;
            button2.Enabled = false;
            button1.Enabled = false;
            bt_cance.Enabled = true;
            bt_cadastraraluno.Enabled = true;
            listView1.Enabled = false;
            listView2.Enabled = true;
            button3.BackColor = Color.LightGray;
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView2.SelectedIndices.Count < 0)
            {
                bt_excluiraluno.Enabled = false;
                bt_editaraluno.Enabled = false;
                bt_cance.Enabled = false;
            }
            else
            {
                bt_editaraluno.Enabled = true;
                bt_excluiraluno.Enabled = true;
                bt_cance.Enabled = true;
            }
        }

        private void bt_cadcursoal_Click(object sender, EventArgs e)
        {
            Cadastro_Aluno_Curso cadcursoall = new Cadastro_Aluno_Curso();
            cadcursoall.ShowDialog();
            cadcursoall.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView2.Items.Clear();
            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=BDProjeto;uid=root;pwd=\"@90409945xX\";";
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from alunos;", cnn);
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string[] row =
                        {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4),
                        reader.GetString(5),
                        reader.GetString(6),
                    };
                    var linha_listview = new ListViewItem(row);
                    listView2.Items.Add(linha_listview);
                }
            }
            finally { }
            cnn.Close();
            try
            {
                cnn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from crsos;", cnn);
                cmd.ExecuteNonQuery();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4),
                        reader.GetString(5),
                        reader.GetString(6),
                    };
                    var linha_listview = new ListViewItem(row);
                    listView1.Items.Add(linha_listview);
                }
            }
            finally { }
            cnn.Close();
            button1.Enabled = true;
            button2.Enabled = true;
            button3.BackColor = Color.LightGray;
        }
    }
}