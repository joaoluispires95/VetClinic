
namespace clinicaVeterinaria.Forms
{
    partial class MedicosInserir
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
            this.lbl_nome = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.lbl_especialização = new System.Windows.Forms.Label();
            this.lbl_sala = new System.Windows.Forms.Label();
            this.cb_sala = new System.Windows.Forms.ComboBox();
            this.cb_especializacao = new System.Windows.Forms.ComboBox();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.label_dados = new System.Windows.Forms.Label();
            this.buttonBorder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.ForeColor = System.Drawing.Color.Gray;
            this.lbl_nome.Location = new System.Drawing.Point(303, 111);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(55, 20);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome:";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(364, 111);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(377, 20);
            this.tb_nome.TabIndex = 1;
            // 
            // lbl_especialização
            // 
            this.lbl_especialização.AutoSize = true;
            this.lbl_especialização.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_especialização.ForeColor = System.Drawing.Color.Gray;
            this.lbl_especialização.Location = new System.Drawing.Point(303, 149);
            this.lbl_especialização.Name = "lbl_especialização";
            this.lbl_especialização.Size = new System.Drawing.Size(119, 20);
            this.lbl_especialização.TabIndex = 2;
            this.lbl_especialização.Text = "Especialização:";
            // 
            // lbl_sala
            // 
            this.lbl_sala.AutoSize = true;
            this.lbl_sala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sala.ForeColor = System.Drawing.Color.Gray;
            this.lbl_sala.Location = new System.Drawing.Point(303, 188);
            this.lbl_sala.Name = "lbl_sala";
            this.lbl_sala.Size = new System.Drawing.Size(45, 20);
            this.lbl_sala.TabIndex = 4;
            this.lbl_sala.Text = "Sala:";
            // 
            // cb_sala
            // 
            this.cb_sala.FormattingEnabled = true;
            this.cb_sala.Location = new System.Drawing.Point(354, 188);
            this.cb_sala.Name = "cb_sala";
            this.cb_sala.Size = new System.Drawing.Size(387, 21);
            this.cb_sala.TabIndex = 5;
            // 
            // cb_especializacao
            // 
            this.cb_especializacao.FormattingEnabled = true;
            this.cb_especializacao.Items.AddRange(new object[] {
            "Cardiologia",
            "Fisioterapia",
            "Dermatologia",
            "Gastroenterologia"});
            this.cb_especializacao.Location = new System.Drawing.Point(428, 149);
            this.cb_especializacao.Name = "cb_especializacao";
            this.cb_especializacao.Size = new System.Drawing.Size(313, 21);
            this.cb_especializacao.TabIndex = 3;
            this.cb_especializacao.SelectedIndexChanged += new System.EventHandler(this.cb_especializacao_SelectedIndexChanged);
            // 
            // btn_inserir
            // 
            this.btn_inserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(176)))));
            this.btn_inserir.FlatAppearance.BorderSize = 0;
            this.btn_inserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inserir.ForeColor = System.Drawing.Color.White;
            this.btn_inserir.Location = new System.Drawing.Point(447, 300);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(150, 50);
            this.btn_inserir.TabIndex = 6;
            this.btn_inserir.Text = "Inserir";
            this.btn_inserir.UseVisualStyleBackColor = false;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // label_dados
            // 
            this.label_dados.AutoSize = true;
            this.label_dados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(176)))));
            this.label_dados.Location = new System.Drawing.Point(159, 59);
            this.label_dados.Name = "label_dados";
            this.label_dados.Size = new System.Drawing.Size(163, 16);
            this.label_dados.TabIndex = 28;
            this.label_dados.Text = "Dados do/a médico/a:";
            // 
            // buttonBorder
            // 
            this.buttonBorder.BackColor = System.Drawing.Color.White;
            this.buttonBorder.Enabled = false;
            this.buttonBorder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(176)))));
            this.buttonBorder.FlatAppearance.BorderSize = 3;
            this.buttonBorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBorder.Location = new System.Drawing.Point(118, 67);
            this.buttonBorder.Name = "buttonBorder";
            this.buttonBorder.Size = new System.Drawing.Size(808, 384);
            this.buttonBorder.TabIndex = 27;
            this.buttonBorder.UseVisualStyleBackColor = false;
            // 
            // MedicosInserir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1044, 545);
            this.Controls.Add(this.btn_inserir);
            this.Controls.Add(this.cb_sala);
            this.Controls.Add(this.lbl_sala);
            this.Controls.Add(this.cb_especializacao);
            this.Controls.Add(this.lbl_especialização);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.label_dados);
            this.Controls.Add(this.buttonBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MedicosInserir";
            this.ShowIcon = false;
            this.Text = "MedicosInserir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label lbl_especialização;
        private System.Windows.Forms.Label lbl_sala;
        private System.Windows.Forms.ComboBox cb_sala;
        private System.Windows.Forms.ComboBox cb_especializacao;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.Label label_dados;
        private System.Windows.Forms.Button buttonBorder;
    }
}