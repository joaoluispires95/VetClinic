
namespace clinicaVeterinaria
{
    partial class frm_principal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_principal));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonComunicacao = new System.Windows.Forms.Button();
            this.buttonConsultas = new System.Windows.Forms.Button();
            this.buttonMedicos = new System.Windows.Forms.Button();
            this.buttonAnimais = new System.Windows.Forms.Button();
            this.panelAbout = new System.Windows.Forms.Panel();
            this.buttonClientes = new System.Windows.Forms.Button();
            this.panelHome = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.lbl_home = new System.Windows.Forms.Label();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.lbl_versao = new System.Windows.Forms.Label();
            this.lbl_conteudos = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_relogio = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panelAbout.SuspendLayout();
            this.panelHome.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(82)))), ((int)(((byte)(140)))));
            this.panelMenu.Controls.Add(this.buttonComunicacao);
            this.panelMenu.Controls.Add(this.buttonConsultas);
            this.panelMenu.Controls.Add(this.buttonMedicos);
            this.panelMenu.Controls.Add(this.buttonAnimais);
            this.panelMenu.Controls.Add(this.panelAbout);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 681);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonComunicacao
            // 
            this.buttonComunicacao.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonComunicacao.FlatAppearance.BorderSize = 0;
            this.buttonComunicacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonComunicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonComunicacao.ForeColor = System.Drawing.Color.White;
            this.buttonComunicacao.Image = global::clinicaVeterinaria.Properties.Resources.comunicacao;
            this.buttonComunicacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonComunicacao.Location = new System.Drawing.Point(0, 544);
            this.buttonComunicacao.Name = "buttonComunicacao";
            this.buttonComunicacao.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonComunicacao.Size = new System.Drawing.Size(220, 136);
            this.buttonComunicacao.TabIndex = 4;
            this.buttonComunicacao.Text = "     Comunicação";
            this.buttonComunicacao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonComunicacao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonComunicacao.UseVisualStyleBackColor = true;
            this.buttonComunicacao.Click += new System.EventHandler(this.buttonComunicacao_Click);
            // 
            // buttonConsultas
            // 
            this.buttonConsultas.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonConsultas.FlatAppearance.BorderSize = 0;
            this.buttonConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsultas.ForeColor = System.Drawing.Color.White;
            this.buttonConsultas.Image = global::clinicaVeterinaria.Properties.Resources.consultas;
            this.buttonConsultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConsultas.Location = new System.Drawing.Point(0, 408);
            this.buttonConsultas.Name = "buttonConsultas";
            this.buttonConsultas.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonConsultas.Size = new System.Drawing.Size(220, 136);
            this.buttonConsultas.TabIndex = 3;
            this.buttonConsultas.Text = "     Consultas";
            this.buttonConsultas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConsultas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonConsultas.UseVisualStyleBackColor = true;
            this.buttonConsultas.Click += new System.EventHandler(this.buttonConsultas_Click);
            // 
            // buttonMedicos
            // 
            this.buttonMedicos.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMedicos.FlatAppearance.BorderSize = 0;
            this.buttonMedicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMedicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMedicos.ForeColor = System.Drawing.Color.White;
            this.buttonMedicos.Image = global::clinicaVeterinaria.Properties.Resources.medicosBranco;
            this.buttonMedicos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMedicos.Location = new System.Drawing.Point(0, 272);
            this.buttonMedicos.Name = "buttonMedicos";
            this.buttonMedicos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonMedicos.Size = new System.Drawing.Size(220, 136);
            this.buttonMedicos.TabIndex = 2;
            this.buttonMedicos.Text = "     Médicos";
            this.buttonMedicos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMedicos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMedicos.UseVisualStyleBackColor = true;
            this.buttonMedicos.Click += new System.EventHandler(this.buttonMedicos_Click);
            // 
            // buttonAnimais
            // 
            this.buttonAnimais.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAnimais.FlatAppearance.BorderSize = 0;
            this.buttonAnimais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnimais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnimais.ForeColor = System.Drawing.Color.White;
            this.buttonAnimais.Image = global::clinicaVeterinaria.Properties.Resources.dog;
            this.buttonAnimais.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAnimais.Location = new System.Drawing.Point(0, 136);
            this.buttonAnimais.Name = "buttonAnimais";
            this.buttonAnimais.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonAnimais.Size = new System.Drawing.Size(220, 136);
            this.buttonAnimais.TabIndex = 1;
            this.buttonAnimais.Text = "     Animais";
            this.buttonAnimais.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAnimais.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAnimais.UseVisualStyleBackColor = true;
            this.buttonAnimais.Click += new System.EventHandler(this.buttonClientes_Click);
            // 
            // panelAbout
            // 
            this.panelAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(63)))), ((int)(((byte)(107)))));
            this.panelAbout.Controls.Add(this.buttonClientes);
            this.panelAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAbout.Location = new System.Drawing.Point(0, 0);
            this.panelAbout.Name = "panelAbout";
            this.panelAbout.Size = new System.Drawing.Size(220, 136);
            this.panelAbout.TabIndex = 0;
            // 
            // buttonClientes
            // 
            this.buttonClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(82)))), ((int)(((byte)(140)))));
            this.buttonClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonClientes.FlatAppearance.BorderSize = 0;
            this.buttonClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClientes.ForeColor = System.Drawing.Color.White;
            this.buttonClientes.Image = global::clinicaVeterinaria.Properties.Resources.clientesBrancoFinal;
            this.buttonClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClientes.Location = new System.Drawing.Point(0, 0);
            this.buttonClientes.Name = "buttonClientes";
            this.buttonClientes.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonClientes.Size = new System.Drawing.Size(220, 136);
            this.buttonClientes.TabIndex = 2;
            this.buttonClientes.Text = "     Clientes";
            this.buttonClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonClientes.UseVisualStyleBackColor = false;
            this.buttonClientes.Click += new System.EventHandler(this.buttonAnimais_Click_1);
            // 
            // panelHome
            // 
            this.panelHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(176)))));
            this.panelHome.Controls.Add(this.buttonClose);
            this.panelHome.Controls.Add(this.lbl_home);
            this.panelHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHome.Location = new System.Drawing.Point(220, 0);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(1044, 136);
            this.panelHome.TabIndex = 1;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(176)))));
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Image = global::clinicaVeterinaria.Properties.Resources.close2;
            this.buttonClose.Location = new System.Drawing.Point(0, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(100, 136);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Visible = false;
            this.buttonClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_home
            // 
            this.lbl_home.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_home.AutoSize = true;
            this.lbl_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_home.ForeColor = System.Drawing.Color.White;
            this.lbl_home.Location = new System.Drawing.Point(436, 41);
            this.lbl_home.Name = "lbl_home";
            this.lbl_home.Size = new System.Drawing.Size(172, 55);
            this.lbl_home.TabIndex = 0;
            this.lbl_home.Text = "HOME";
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.White;
            this.panelPrincipal.Controls.Add(this.lbl_versao);
            this.panelPrincipal.Controls.Add(this.lbl_conteudos);
            this.panelPrincipal.Controls.Add(this.lbl_password);
            this.panelPrincipal.Controls.Add(this.lbl_user);
            this.panelPrincipal.Controls.Add(this.btn_logout);
            this.panelPrincipal.Controls.Add(this.btn_login);
            this.panelPrincipal.Controls.Add(this.tb_password);
            this.panelPrincipal.Controls.Add(this.tb_username);
            this.panelPrincipal.Controls.Add(this.lbl_login);
            this.panelPrincipal.Controls.Add(this.lbl_relogio);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(220, 136);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1044, 545);
            this.panelPrincipal.TabIndex = 2;
            // 
            // lbl_versao
            // 
            this.lbl_versao.AutoSize = true;
            this.lbl_versao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_versao.ForeColor = System.Drawing.Color.Gray;
            this.lbl_versao.Location = new System.Drawing.Point(700, 516);
            this.lbl_versao.Name = "lbl_versao";
            this.lbl_versao.Size = new System.Drawing.Size(0, 20);
            this.lbl_versao.TabIndex = 9;
            // 
            // lbl_conteudos
            // 
            this.lbl_conteudos.AutoSize = true;
            this.lbl_conteudos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_conteudos.ForeColor = System.Drawing.Color.Gray;
            this.lbl_conteudos.Location = new System.Drawing.Point(337, 80);
            this.lbl_conteudos.Name = "lbl_conteudos";
            this.lbl_conteudos.Size = new System.Drawing.Size(370, 16);
            this.lbl_conteudos.TabIndex = 8;
            this.lbl_conteudos.Text = "Pode agora aceder a todos os conteúdos e funcionalidades!";
            this.lbl_conteudos.Visible = false;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.Color.Gray;
            this.lbl_password.Location = new System.Drawing.Point(303, 200);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(82, 20);
            this.lbl_password.TabIndex = 7;
            this.lbl_password.Text = "Password:";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.Color.Gray;
            this.lbl_user.Location = new System.Drawing.Point(303, 150);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(47, 20);
            this.lbl_user.TabIndex = 6;
            this.lbl_user.Text = "User:";
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(176)))));
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(447, 275);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(150, 50);
            this.btn_logout.TabIndex = 5;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Visible = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(176)))));
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(447, 275);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(150, 50);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(391, 200);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(350, 20);
            this.tb_password.TabIndex = 3;
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(356, 150);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(385, 20);
            this.tb_username.TabIndex = 2;
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(176)))));
            this.lbl_login.Location = new System.Drawing.Point(442, 30);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(161, 25);
            this.lbl_login.TabIndex = 1;
            this.lbl_login.Text = "Login efetuado!";
            this.lbl_login.Visible = false;
            // 
            // lbl_relogio
            // 
            this.lbl_relogio.AutoSize = true;
            this.lbl_relogio.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_relogio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(176)))));
            this.lbl_relogio.Location = new System.Drawing.Point(6, 497);
            this.lbl_relogio.Name = "lbl_relogio";
            this.lbl_relogio.Size = new System.Drawing.Size(141, 39);
            this.lbl_relogio.TabIndex = 0;
            this.lbl_relogio.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelHome);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_principal";
            this.Text = "PetClinic Pro";
            this.Load += new System.EventHandler(this.frm_principal_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelAbout.ResumeLayout(false);
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonAnimais;
        private System.Windows.Forms.Panel panelAbout;
        private System.Windows.Forms.Button buttonComunicacao;
        private System.Windows.Forms.Button buttonConsultas;
        private System.Windows.Forms.Button buttonMedicos;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Label lbl_home;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonClientes;
        private System.Windows.Forms.Label lbl_relogio;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_conteudos;
        private System.Windows.Forms.Label lbl_versao;
    }
}