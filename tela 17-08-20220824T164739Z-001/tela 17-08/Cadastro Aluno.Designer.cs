namespace tela_17_08
{
    partial class cadaluno
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
            this.tb_contato = new System.Windows.Forms.TextBox();
            this.tb_idadeal = new System.Windows.Forms.TextBox();
            this.tb_nomeal = new System.Windows.Forms.TextBox();
            this.bt_fechart4 = new System.Windows.Forms.Button();
            this.lb_cargat4 = new System.Windows.Forms.Label();
            this.lb_contato = new System.Windows.Forms.Label();
            this.lb_idade = new System.Windows.Forms.Label();
            this.lb_nome = new System.Windows.Forms.Label();
            this.bt_excluiraluno = new System.Windows.Forms.Button();
            this.bt_editaraluno = new System.Windows.Forms.Button();
            this.bt_cadastraraluno = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.codview = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nomeview = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.idadeview = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contatoview = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.escolariedadeview = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tb_cep = new System.Windows.Forms.TextBox();
            this.lb_cep = new System.Windows.Forms.Label();
            this.bt_confirmaedite = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bt_cance = new System.Windows.Forms.Button();
            this.lb_numero = new System.Windows.Forms.Label();
            this.tb_ncep = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bt_cadcursoal = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_contato
            // 
            this.tb_contato.Location = new System.Drawing.Point(8, 237);
            this.tb_contato.Name = "tb_contato";
            this.tb_contato.Size = new System.Drawing.Size(300, 20);
            this.tb_contato.TabIndex = 2;
            // 
            // tb_idadeal
            // 
            this.tb_idadeal.Location = new System.Drawing.Point(8, 172);
            this.tb_idadeal.Name = "tb_idadeal";
            this.tb_idadeal.Size = new System.Drawing.Size(300, 20);
            this.tb_idadeal.TabIndex = 1;
            this.tb_idadeal.TextChanged += new System.EventHandler(this.tb_t5idade_TextChanged);
            // 
            // tb_nomeal
            // 
            this.tb_nomeal.Location = new System.Drawing.Point(8, 107);
            this.tb_nomeal.Name = "tb_nomeal";
            this.tb_nomeal.Size = new System.Drawing.Size(300, 20);
            this.tb_nomeal.TabIndex = 0;
            // 
            // bt_fechart4
            // 
            this.bt_fechart4.BackColor = System.Drawing.Color.Brown;
            this.bt_fechart4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_fechart4.Location = new System.Drawing.Point(682, 206);
            this.bt_fechart4.Name = "bt_fechart4";
            this.bt_fechart4.Size = new System.Drawing.Size(117, 40);
            this.bt_fechart4.TabIndex = 24;
            this.bt_fechart4.TabStop = false;
            this.bt_fechart4.Text = "Fechar";
            this.bt_fechart4.UseVisualStyleBackColor = false;
            this.bt_fechart4.Click += new System.EventHandler(this.bt_fechart4_Click);
            // 
            // lb_cargat4
            // 
            this.lb_cargat4.AutoSize = true;
            this.lb_cargat4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cargat4.Location = new System.Drawing.Point(3, 272);
            this.lb_cargat4.Name = "lb_cargat4";
            this.lb_cargat4.Size = new System.Drawing.Size(169, 29);
            this.lb_cargat4.TabIndex = 23;
            this.lb_cargat4.Text = "Escolariedade";
            // 
            // lb_contato
            // 
            this.lb_contato.AutoSize = true;
            this.lb_contato.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_contato.Location = new System.Drawing.Point(3, 205);
            this.lb_contato.Name = "lb_contato";
            this.lb_contato.Size = new System.Drawing.Size(96, 29);
            this.lb_contato.TabIndex = 22;
            this.lb_contato.Text = "Contato";
            // 
            // lb_idade
            // 
            this.lb_idade.AutoSize = true;
            this.lb_idade.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_idade.Location = new System.Drawing.Point(12, 140);
            this.lb_idade.Name = "lb_idade";
            this.lb_idade.Size = new System.Drawing.Size(74, 29);
            this.lb_idade.TabIndex = 21;
            this.lb_idade.Text = "Idade";
            this.lb_idade.Click += new System.EventHandler(this.lb_escot4_Click);
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome.Location = new System.Drawing.Point(12, 75);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(79, 29);
            this.lb_nome.TabIndex = 20;
            this.lb_nome.Text = "Nome";
            // 
            // bt_excluiraluno
            // 
            this.bt_excluiraluno.Enabled = false;
            this.bt_excluiraluno.Location = new System.Drawing.Point(314, 206);
            this.bt_excluiraluno.Name = "bt_excluiraluno";
            this.bt_excluiraluno.Size = new System.Drawing.Size(60, 40);
            this.bt_excluiraluno.TabIndex = 37;
            this.bt_excluiraluno.TabStop = false;
            this.bt_excluiraluno.Text = "Excluir";
            this.bt_excluiraluno.UseVisualStyleBackColor = true;
            this.bt_excluiraluno.Click += new System.EventHandler(this.bt_excluiraluno_Click);
            // 
            // bt_editaraluno
            // 
            this.bt_editaraluno.Enabled = false;
            this.bt_editaraluno.Location = new System.Drawing.Point(74, 400);
            this.bt_editaraluno.Name = "bt_editaraluno";
            this.bt_editaraluno.Size = new System.Drawing.Size(60, 40);
            this.bt_editaraluno.TabIndex = 36;
            this.bt_editaraluno.TabStop = false;
            this.bt_editaraluno.Text = "Editar";
            this.bt_editaraluno.UseVisualStyleBackColor = true;
            this.bt_editaraluno.Click += new System.EventHandler(this.bt_editaraluno_Click);
            // 
            // bt_cadastraraluno
            // 
            this.bt_cadastraraluno.Enabled = false;
            this.bt_cadastraraluno.Location = new System.Drawing.Point(8, 400);
            this.bt_cadastraraluno.Name = "bt_cadastraraluno";
            this.bt_cadastraraluno.Size = new System.Drawing.Size(60, 40);
            this.bt_cadastraraluno.TabIndex = 35;
            this.bt_cadastraraluno.TabStop = false;
            this.bt_cadastraraluno.Text = "Cadastrar";
            this.bt_cadastraraluno.UseVisualStyleBackColor = true;
            this.bt_cadastraraluno.Click += new System.EventHandler(this.bt_cadastraraluno_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codview,
            this.nomeview,
            this.idadeview,
            this.contatoview,
            this.escolariedadeview,
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Enabled = false;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(314, 0);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(485, 200);
            this.listView1.TabIndex = 38;
            this.listView1.TabStop = false;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // codview
            // 
            this.codview.Text = "Id";
            this.codview.Width = 25;
            // 
            // nomeview
            // 
            this.nomeview.Text = "Curso";
            this.nomeview.Width = 140;
            // 
            // idadeview
            // 
            this.idadeview.Text = "Vagas";
            this.idadeview.Width = 68;
            // 
            // contatoview
            // 
            this.contatoview.Text = "Valor";
            this.contatoview.Width = 47;
            // 
            // escolariedadeview
            // 
            this.escolariedadeview.Text = "Idade";
            this.escolariedadeview.Width = 39;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Carha Horaria";
            this.columnHeader1.Width = 77;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Escolariedade";
            this.columnHeader2.Width = 85;
            // 
            // tb_cep
            // 
            this.tb_cep.Location = new System.Drawing.Point(8, 372);
            this.tb_cep.Name = "tb_cep";
            this.tb_cep.Size = new System.Drawing.Size(173, 20);
            this.tb_cep.TabIndex = 4;
            // 
            // lb_cep
            // 
            this.lb_cep.AutoSize = true;
            this.lb_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cep.Location = new System.Drawing.Point(12, 340);
            this.lb_cep.Name = "lb_cep";
            this.lb_cep.Size = new System.Drawing.Size(62, 29);
            this.lb_cep.TabIndex = 40;
            this.lb_cep.Text = "CEP";
            // 
            // bt_confirmaedite
            // 
            this.bt_confirmaedite.Enabled = false;
            this.bt_confirmaedite.Location = new System.Drawing.Point(182, 400);
            this.bt_confirmaedite.Name = "bt_confirmaedite";
            this.bt_confirmaedite.Size = new System.Drawing.Size(60, 40);
            this.bt_confirmaedite.TabIndex = 42;
            this.bt_confirmaedite.TabStop = false;
            this.bt_confirmaedite.Text = "Confirmar";
            this.bt_confirmaedite.UseVisualStyleBackColor = true;
            this.bt_confirmaedite.Click += new System.EventHandler(this.bt_confirmaedite_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Medio Completo",
            "Fundamental Completo"});
            this.comboBox1.Location = new System.Drawing.Point(8, 304);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // bt_cance
            // 
            this.bt_cance.Enabled = false;
            this.bt_cance.Location = new System.Drawing.Point(248, 400);
            this.bt_cance.Name = "bt_cance";
            this.bt_cance.Size = new System.Drawing.Size(60, 40);
            this.bt_cance.TabIndex = 46;
            this.bt_cance.TabStop = false;
            this.bt_cance.Text = "Cancelar";
            this.bt_cance.UseVisualStyleBackColor = true;
            this.bt_cance.Click += new System.EventHandler(this.bt_cance_Click);
            // 
            // lb_numero
            // 
            this.lb_numero.AutoSize = true;
            this.lb_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_numero.Location = new System.Drawing.Point(220, 340);
            this.lb_numero.Name = "lb_numero";
            this.lb_numero.Size = new System.Drawing.Size(39, 29);
            this.lb_numero.TabIndex = 47;
            this.lb_numero.Text = "N°";
            // 
            // tb_ncep
            // 
            this.tb_ncep.Location = new System.Drawing.Point(225, 372);
            this.tb_ncep.Name = "tb_ncep";
            this.tb_ncep.Size = new System.Drawing.Size(78, 20);
            this.tb_ncep.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 40);
            this.button1.TabIndex = 48;
            this.button1.TabStop = false;
            this.button1.Text = "Cursos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(8, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 40);
            this.button2.TabIndex = 49;
            this.button2.TabStop = false;
            this.button2.Text = "Alunos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listView2.Enabled = false;
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(314, 252);
            this.listView2.MultiSelect = false;
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(485, 200);
            this.listView2.TabIndex = 50;
            this.listView2.TabStop = false;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Id";
            this.columnHeader3.Width = 21;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nome";
            this.columnHeader4.Width = 147;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Escolariedade";
            this.columnHeader5.Width = 79;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Contato";
            this.columnHeader6.Width = 97;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Idade";
            this.columnHeader7.Width = 42;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "CEP";
            this.columnHeader8.Width = 61;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Numero";
            this.columnHeader9.Width = 33;
            // 
            // bt_cadcursoal
            // 
            this.bt_cadcursoal.Location = new System.Drawing.Point(570, 206);
            this.bt_cadcursoal.Name = "bt_cadcursoal";
            this.bt_cadcursoal.Size = new System.Drawing.Size(70, 40);
            this.bt_cadcursoal.TabIndex = 51;
            this.bt_cadcursoal.TabStop = false;
            this.bt_cadcursoal.Text = "Matricular";
            this.bt_cadcursoal.UseVisualStyleBackColor = true;
            this.bt_cadcursoal.Click += new System.EventHandler(this.bt_cadcursoal_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(233, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 40);
            this.button3.TabIndex = 52;
            this.button3.TabStop = false;
            this.button3.Text = "Atualizar Lista";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cadaluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bt_cadcursoal);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_ncep);
            this.Controls.Add(this.lb_numero);
            this.Controls.Add(this.bt_cance);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bt_confirmaedite);
            this.Controls.Add(this.tb_cep);
            this.Controls.Add(this.lb_cep);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.bt_excluiraluno);
            this.Controls.Add(this.bt_editaraluno);
            this.Controls.Add(this.bt_cadastraraluno);
            this.Controls.Add(this.tb_contato);
            this.Controls.Add(this.tb_idadeal);
            this.Controls.Add(this.tb_nomeal);
            this.Controls.Add(this.bt_fechart4);
            this.Controls.Add(this.lb_cargat4);
            this.Controls.Add(this.lb_contato);
            this.Controls.Add(this.lb_idade);
            this.Controls.Add(this.lb_nome);
            this.Name = "cadaluno";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.tela4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_contato;
        private System.Windows.Forms.TextBox tb_idadeal;
        private System.Windows.Forms.TextBox tb_nomeal;
        private System.Windows.Forms.Button bt_fechart4;
        private System.Windows.Forms.Label lb_cargat4;
        private System.Windows.Forms.Label lb_contato;
        private System.Windows.Forms.Label lb_idade;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.Button bt_excluiraluno;
        private System.Windows.Forms.Button bt_editaraluno;
        private System.Windows.Forms.Button bt_cadastraraluno;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader codview;
        private System.Windows.Forms.ColumnHeader nomeview;
        private System.Windows.Forms.ColumnHeader idadeview;
        private System.Windows.Forms.ColumnHeader contatoview;
        private System.Windows.Forms.ColumnHeader escolariedadeview;
        private System.Windows.Forms.TextBox tb_cep;
        private System.Windows.Forms.Label lb_cep;
        private System.Windows.Forms.Button bt_confirmaedite;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button bt_cance;
        private System.Windows.Forms.Label lb_numero;
        private System.Windows.Forms.TextBox tb_ncep;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Button bt_cadcursoal;
        private System.Windows.Forms.Button button3;
    }
}