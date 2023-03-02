using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace tela_17_08
{
    public partial class Cadastro_Aluno_Curso : Form
    {
        public Cadastro_Aluno_Curso()
        {
            InitializeComponent();

            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=?????;uid=root;pwd=\"?????\";";
            cnn = new MySqlConnection(connetionString);
            try
            {
                cnn.Open();
                MySqlCommand cmd = new MySqlCommand("select id, nome, idade, escolariedade from crsos;", cnn);
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
                    };
                    var linha_listview = new ListViewItem(row);
                    listView2.Items.Add(linha_listview);
                }
            }
            finally { }

            try
            {
                connetionString = "server=localhost;database=?????;uid=root;pwd=\"?????\";";
                cnn = new MySqlConnection(connetionString);
                cnn.Open();
                MySqlCommand cmd = new MySqlCommand("select id, nome, idade, escolariedade from alunos;", cnn);
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

                    };
                    var linha_listview = new ListViewItem(row);
                    listView1.Items.Add(linha_listview);
                }
            }
            finally { }

            try
            {
                connetionString = "server=localhost;database=??????;uid=root;pwd=\"??????\";";
                cnn = new MySqlConnection(connetionString);
                try
                {
                    cnn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT alunos_id, a.nome as aluno,  crsos_id, c.nome as curso from alunos_has_crsos AS ac\r\nINNER JOIN alunos as a ON a.id = ac.alunos_id\r\nINNER JOIN crsos as c ON c.id = ac.crsos_id", cnn);
                    cmd.ExecuteNonQuery();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {

                        string[] row =
                            {
                        reader.GetString(0),
                        reader.GetString(2),
                        reader.GetString(1),
                        reader.GetString(3),

                    };
                        var linha_listview = new ListViewItem(row);
                        listView3.Items.Add(linha_listview);
                    }
                }
                finally { }
                cnn.Close();
            }
            finally { }
            cnn.Close();
        }

        private void bt_cadcursoal_Click(object sender, EventArgs e)
        {
            int codaluno = listView1.SelectedIndices[0];
            int codcurso = listView2.SelectedIndices[0];
            if (Int32.Parse(listView1.Items[codaluno].SubItems[2].Text) >= Int32.Parse(listView2.Items[codcurso].SubItems[2].Text))
            {
                if (listView1.Items[codaluno].SubItems[3].Text == listView2.Items[codcurso].SubItems[3].Text || listView1.Items[codaluno].SubItems[3].Text == "Medio Completo")
                {
                        string[] row = { listView1.Items[codaluno].SubItems[0].Text, listView2.Items[codcurso].SubItems[0].Text, listView1.Items[codaluno].SubItems[1].Text, listView2.Items[codcurso].SubItems[1].Text };
                        var listViewItemal = new ListViewItem(row);
                        listView3.Items.Add(listViewItemal);
                        string connetionString = null;
                        MySqlConnection cnn;
                        connetionString = "server=localhost;database=?????;uid=root;pwd=\"??????\";";
                        cnn = new MySqlConnection(connetionString);
                        try
                        {
                            cnn.Open();
                            MySqlCommand cmd = new MySqlCommand("INSERT INTO alunos_has_crsos (alunos_id, crsos_id) VALUES (" + listView1.Items[codaluno].SubItems[0].Text + "," + listView2.Items[codcurso].SubItems[0].Text + ");", cnn);
                            cmd.ExecuteNonQuery();
                            cnn.Close();
                            MessageBox.Show("Aluno cadastrado com sucesso!");
                        }
                        catch
                        {
                            button2.Enabled = true;
                            MessageBox.Show("Aluno ja cadastrado no curso! Atualize a lista");
                            button2.BackColor = Color.LightGreen;
                        }
                        finally { }
                        cnn.Close();
                    }
                else
                {
                    MessageBox.Show("Aluno não atende aos requisitos!");
                }
            }
            else
            {
                MessageBox.Show("Aluno não atende aos requisitos!");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((listView1.SelectedIndices.Count <= 0) || (listView2.SelectedIndices.Count <= 0))
            {
                bt_cadcursoal.Enabled = false;
            }
            else
            {
                bt_cadcursoal.Enabled = true;
            }
        }

        private void bt_fechart4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Confirma exclusão?", "Confimação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int exc = listView3.SelectedIndices[0];
                if (exc >= 0)
                {
                    string connetionString = null;
                    MySqlConnection cnn;
                    connetionString = "server=localhost;database=??????;uid=root;pwd=\"??????\";";
                    cnn = new MySqlConnection(connetionString);
                    try
                    {
                        cnn.Open();
                        MySqlCommand cmd = new MySqlCommand("delete from alunos_has_crsos WHERE alunos_id =" + listView3.Items[exc].SubItems[0].Text + " and crsos_id =" + listView3.Items[exc].SubItems[1].Text +";", cnn);
                        MessageBox.Show("Cadastro cancelado com sucesso! Atualize a lista");
                        cmd.ExecuteNonQuery();
                        cnn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    finally { }
                    cnn.Close();
                }
            }
            button2.Enabled = true;
            bt_cadcursoal.Enabled = false;
            button1.Enabled = false;
            button2.BackColor = Color.LightGreen;
        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView3.SelectedIndices.Count <= 0)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((listView1.SelectedIndices.Count <= 0) || (listView2.SelectedIndices.Count <= 0))
            {
                bt_cadcursoal.Enabled = false;
            }
            else
            {
                bt_cadcursoal.Enabled = true;
            }
        }

        private void Cadastro_Aluno_Curso_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView3.Items.Clear();
            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=??????;uid=root;pwd=\"??????\";";
            cnn = new MySqlConnection(connetionString);
            try
            {
                connetionString = "server=localhost;database=??????;uid=root;pwd=\"??????\";";
                cnn = new MySqlConnection(connetionString);
                try
                {
                    cnn.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT alunos_id, a.nome as aluno,  crsos_id, c.nome as curso from alunos_has_crsos AS ac\r\nINNER JOIN alunos as a ON a.id = ac.alunos_id\r\nINNER JOIN crsos as c ON c.id = ac.crsos_id", cnn);
                    cmd.ExecuteNonQuery();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {

                        string[] row =
                            {
                        reader.GetString(0),
                        reader.GetString(2),
                        reader.GetString(1),
                        reader.GetString(3),

                    };
                        var linha_listview = new ListViewItem(row);
                        listView3.Items.Add(linha_listview);
                    }
                }
                finally { }
                cnn.Close();
            }
            finally { }
            cnn.Close();
            bt_cadcursoal.Enabled = true;
            button2.BackColor = Color.LightGray;
        }
    }
}
