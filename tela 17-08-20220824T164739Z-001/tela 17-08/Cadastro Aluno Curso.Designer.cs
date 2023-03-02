namespace tela_17_08
{
    partial class Cadastro_Aluno_Curso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.codal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nomeal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.codcurso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nomecurso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView3 = new System.Windows.Forms.ListView();
            this.codalu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.codigocurso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nomealuno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nomecursoo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bt_cadcursoal = new System.Windows.Forms.Button();
            this.bt_fechart4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codal,
            this.nomeal,
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 30);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(230, 362);
            this.listView1.TabIndex = 0;
            this.listView1.TabStop = false;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // codal
            // 
            this.codal.Text = "Id";
            this.codal.Width = 21;
            // 
            // nomeal
            // 
            this.nomeal.Text = "Aluno";
            this.nomeal.Width = 89;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Idade";
            this.columnHeader1.Width = 37;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Escolariedade";
            this.columnHeader2.Width = 79;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codcurso,
            this.nomecurso,
            this.columnHeader3,
            this.columnHeader4});
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(248, 30);
            this.listView2.MultiSelect = false;
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(230, 362);
            this.listView2.TabIndex = 1;
            this.listView2.TabStop = false;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // codcurso
            // 
            this.codcurso.Text = "Id";
            this.codcurso.Width = 23;
            // 
            // nomecurso
            // 
            this.nomecurso.Text = "Curso";
            this.nomecurso.Width = 86;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Idade";
            this.columnHeader3.Width = 37;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Escolariedade";
            this.columnHeader4.Width = 79;
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codalu,
            this.codigocurso,
            this.nomealuno,
            this.nomecursoo});
            this.listView3.FullRowSelect = true;
            this.listView3.GridLines = true;
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(484, 30);
            this.listView3.MultiSelect = false;
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(304, 362);
            this.listView3.TabIndex = 2;
            this.listView3.TabStop = false;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            this.listView3.SelectedIndexChanged += new System.EventHandler(this.listView3_SelectedIndexChanged);
            // 
            // codalu
            // 
            this.codalu.Text = "Id_Aluno";
            this.codalu.Width = 43;
            // 
            // codigocurso
            // 
            this.codigocurso.DisplayIndex = 2;
            this.codigocurso.Text = "Id_Curso";
            this.codigocurso.Width = 43;
            // 
            // nomealuno
            // 
            this.nomealuno.DisplayIndex = 1;
            this.nomealuno.Text = "Aluno";
            this.nomealuno.Width = 104;
            // 
            // nomecursoo
            // 
            this.nomecursoo.Text = "Curso";
            this.nomecursoo.Width = 110;
            // 
            // bt_cadcursoal
            // 
            this.bt_cadcursoal.Enabled = false;
            this.bt_cadcursoal.Location = new System.Drawing.Point(30, 400);
            this.bt_cadcursoal.Name = "bt_cadcursoal";
            this.bt_cadcursoal.Size = new System.Drawing.Size(186, 40);
            this.bt_cadcursoal.TabIndex = 36;
            this.bt_cadcursoal.TabStop = false;
            this.bt_cadcursoal.Text = "Matricular";
            this.bt_cadcursoal.UseVisualStyleBackColor = true;
            this.bt_cadcursoal.Click += new System.EventHandler(this.bt_cadcursoal_Click);
            // 
            // bt_fechart4
            // 
            this.bt_fechart4.Location = new System.Drawing.Point(671, 398);
            this.bt_fechart4.Name = "bt_fechart4";
            this.bt_fechart4.Size = new System.Drawing.Size(117, 40);
            this.bt_fechart4.TabIndex = 37;
            this.bt_fechart4.TabStop = false;
            this.bt_fechart4.Text = "Voltar";
            this.bt_fechart4.UseVisualStyleBackColor = true;
            this.bt_fechart4.Click += new System.EventHandler(this.bt_fechart4_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(453, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 40);
            this.button1.TabIndex = 38;
            this.button1.TabStop = false;
            this.button1.Text = "Cancelar Matricula";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(275, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 40);
            this.button2.TabIndex = 39;
            this.button2.TabStop = false;
            this.button2.Text = "Atualizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Cadastro_Aluno_Curso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_fechart4);
            this.Controls.Add(this.bt_cadcursoal);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Name = "Cadastro_Aluno_Curso";
            this.Text = "Matriculas";
            this.Load += new System.EventHandler(this.Cadastro_Aluno_Curso_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader codal;
        private System.Windows.Forms.ColumnHeader nomeal;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader codcurso;
        private System.Windows.Forms.ColumnHeader nomecurso;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader codalu;
        private System.Windows.Forms.ColumnHeader nomealuno;
        private System.Windows.Forms.Button bt_cadcursoal;
        private System.Windows.Forms.ColumnHeader codigocurso;
        private System.Windows.Forms.ColumnHeader nomecursoo;
        private System.Windows.Forms.Button bt_fechart4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button2;
    }
}