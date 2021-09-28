
namespace clinicaVeterinaria.Forms
{
    partial class AnimaisInserir
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
            this.btn_inserir = new System.Windows.Forms.Button();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.lbl_dataNascimento = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_raca = new System.Windows.Forms.Label();
            this.tb_raca = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_dono = new System.Windows.Forms.Label();
            this.cb_dono = new System.Windows.Forms.ComboBox();
            this.buttonBorder = new System.Windows.Forms.Button();
            this.label_dados = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.btn_inserir.TabIndex = 17;
            this.btn_inserir.Text = "Inserir";
            this.btn_inserir.UseVisualStyleBackColor = false;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click_1);
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(364, 111);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(377, 20);
            this.tb_nome.TabIndex = 13;
            // 
            // lbl_dataNascimento
            // 
            this.lbl_dataNascimento.AutoSize = true;
            this.lbl_dataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dataNascimento.ForeColor = System.Drawing.Color.Gray;
            this.lbl_dataNascimento.Location = new System.Drawing.Point(303, 149);
            this.lbl_dataNascimento.Name = "lbl_dataNascimento";
            this.lbl_dataNascimento.Size = new System.Drawing.Size(156, 20);
            this.lbl_dataNascimento.TabIndex = 10;
            this.lbl_dataNascimento.Text = "Data de nascimento:";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.ForeColor = System.Drawing.Color.Gray;
            this.lbl_nome.Location = new System.Drawing.Point(303, 111);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(55, 20);
            this.lbl_nome.TabIndex = 9;
            this.lbl_nome.Text = "Nome:";
            // 
            // lbl_raca
            // 
            this.lbl_raca.AutoSize = true;
            this.lbl_raca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_raca.ForeColor = System.Drawing.Color.Gray;
            this.lbl_raca.Location = new System.Drawing.Point(303, 186);
            this.lbl_raca.Name = "lbl_raca";
            this.lbl_raca.Size = new System.Drawing.Size(112, 20);
            this.lbl_raca.TabIndex = 11;
            this.lbl_raca.Text = "Espécie/Raça:";
            // 
            // tb_raca
            // 
            this.tb_raca.Location = new System.Drawing.Point(417, 188);
            this.tb_raca.Name = "tb_raca";
            this.tb_raca.Size = new System.Drawing.Size(324, 20);
            this.tb_raca.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(465, 149);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(276, 20);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // lbl_dono
            // 
            this.lbl_dono.AutoSize = true;
            this.lbl_dono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dono.ForeColor = System.Drawing.Color.Gray;
            this.lbl_dono.Location = new System.Drawing.Point(303, 224);
            this.lbl_dono.Name = "lbl_dono";
            this.lbl_dono.Size = new System.Drawing.Size(52, 20);
            this.lbl_dono.TabIndex = 19;
            this.lbl_dono.Text = "Dono:";
            // 
            // cb_dono
            // 
            this.cb_dono.FormattingEnabled = true;
            this.cb_dono.Location = new System.Drawing.Point(361, 223);
            this.cb_dono.Name = "cb_dono";
            this.cb_dono.Size = new System.Drawing.Size(380, 21);
            this.cb_dono.TabIndex = 20;
            this.cb_dono.SelectedIndexChanged += new System.EventHandler(this.cb_dono_SelectedIndexChanged);
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
            this.buttonBorder.TabIndex = 21;
            this.buttonBorder.UseVisualStyleBackColor = false;
            // 
            // label_dados
            // 
            this.label_dados.AutoSize = true;
            this.label_dados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(176)))));
            this.label_dados.Location = new System.Drawing.Point(159, 60);
            this.label_dados.Name = "label_dados";
            this.label_dados.Size = new System.Drawing.Size(130, 16);
            this.label_dados.TabIndex = 22;
            this.label_dados.Text = "Dados do animal:";
            // 
            // AnimaisInserir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1044, 545);
            this.Controls.Add(this.label_dados);
            this.Controls.Add(this.cb_dono);
            this.Controls.Add(this.lbl_dono);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_inserir);
            this.Controls.Add(this.tb_raca);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.lbl_raca);
            this.Controls.Add(this.lbl_dataNascimento);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.buttonBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnimaisInserir";
            this.ShowIcon = false;
            this.Text = "AnimaisTodos";
            this.Load += new System.EventHandler(this.AnimaisInserir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label lbl_dataNascimento;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_raca;
        private System.Windows.Forms.TextBox tb_raca;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_dono;
        private System.Windows.Forms.ComboBox cb_dono;
        private System.Windows.Forms.Button buttonBorder;
        private System.Windows.Forms.Label label_dados;
    }
}