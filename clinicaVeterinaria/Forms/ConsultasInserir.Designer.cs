
namespace clinicaVeterinaria.Forms
{
    partial class ConsultasInserir
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
            this.lbl_especialidade = new System.Windows.Forms.Label();
            this.cb_especialidade = new System.Windows.Forms.ComboBox();
            this.lbl_animal = new System.Windows.Forms.Label();
            this.cb_animal = new System.Windows.Forms.ComboBox();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.tb_cliente = new System.Windows.Forms.TextBox();
            this.lbl_medico = new System.Windows.Forms.Label();
            this.cb_medico = new System.Windows.Forms.ComboBox();
            this.lbl_horas = new System.Windows.Forms.Label();
            this.cb_horas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_minutos = new System.Windows.Forms.ComboBox();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.lbl_data = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label_dados = new System.Windows.Forms.Label();
            this.buttonBorder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_especialidade
            // 
            this.lbl_especialidade.AutoSize = true;
            this.lbl_especialidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_especialidade.ForeColor = System.Drawing.Color.Gray;
            this.lbl_especialidade.Location = new System.Drawing.Point(303, 111);
            this.lbl_especialidade.Name = "lbl_especialidade";
            this.lbl_especialidade.Size = new System.Drawing.Size(112, 20);
            this.lbl_especialidade.TabIndex = 0;
            this.lbl_especialidade.Text = "Especialidade:";
            // 
            // cb_especialidade
            // 
            this.cb_especialidade.FormattingEnabled = true;
            this.cb_especialidade.Items.AddRange(new object[] {
            "Cardiologia",
            "Fisioterapia",
            "Dermatologia",
            "Gastroenterologia"});
            this.cb_especialidade.Location = new System.Drawing.Point(421, 111);
            this.cb_especialidade.Name = "cb_especialidade";
            this.cb_especialidade.Size = new System.Drawing.Size(320, 21);
            this.cb_especialidade.TabIndex = 1;
            this.cb_especialidade.SelectedIndexChanged += new System.EventHandler(this.cb_especialidade_SelectedIndexChanged);
            // 
            // lbl_animal
            // 
            this.lbl_animal.AutoSize = true;
            this.lbl_animal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_animal.ForeColor = System.Drawing.Color.Gray;
            this.lbl_animal.Location = new System.Drawing.Point(303, 144);
            this.lbl_animal.Name = "lbl_animal";
            this.lbl_animal.Size = new System.Drawing.Size(61, 20);
            this.lbl_animal.TabIndex = 2;
            this.lbl_animal.Text = "Animal:";
            // 
            // cb_animal
            // 
            this.cb_animal.FormattingEnabled = true;
            this.cb_animal.Location = new System.Drawing.Point(370, 144);
            this.cb_animal.Name = "cb_animal";
            this.cb_animal.Size = new System.Drawing.Size(371, 21);
            this.cb_animal.TabIndex = 3;
            this.cb_animal.SelectedIndexChanged += new System.EventHandler(this.cb_animal_SelectedIndexChanged);
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cliente.ForeColor = System.Drawing.Color.Gray;
            this.lbl_cliente.Location = new System.Drawing.Point(303, 177);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(62, 20);
            this.lbl_cliente.TabIndex = 5;
            this.lbl_cliente.Text = "Cliente:";
            // 
            // tb_cliente
            // 
            this.tb_cliente.Location = new System.Drawing.Point(371, 177);
            this.tb_cliente.Name = "tb_cliente";
            this.tb_cliente.ReadOnly = true;
            this.tb_cliente.Size = new System.Drawing.Size(370, 20);
            this.tb_cliente.TabIndex = 6;
            // 
            // lbl_medico
            // 
            this.lbl_medico.AutoSize = true;
            this.lbl_medico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_medico.ForeColor = System.Drawing.Color.Gray;
            this.lbl_medico.Location = new System.Drawing.Point(303, 212);
            this.lbl_medico.Name = "lbl_medico";
            this.lbl_medico.Size = new System.Drawing.Size(64, 20);
            this.lbl_medico.TabIndex = 7;
            this.lbl_medico.Text = "Médico:";
            // 
            // cb_medico
            // 
            this.cb_medico.FormattingEnabled = true;
            this.cb_medico.Location = new System.Drawing.Point(373, 212);
            this.cb_medico.Name = "cb_medico";
            this.cb_medico.Size = new System.Drawing.Size(368, 21);
            this.cb_medico.TabIndex = 8;
            this.cb_medico.SelectedIndexChanged += new System.EventHandler(this.cb_medico_SelectedIndexChanged);
            // 
            // lbl_horas
            // 
            this.lbl_horas.AutoSize = true;
            this.lbl_horas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_horas.ForeColor = System.Drawing.Color.Gray;
            this.lbl_horas.Location = new System.Drawing.Point(303, 283);
            this.lbl_horas.Name = "lbl_horas";
            this.lbl_horas.Size = new System.Drawing.Size(56, 20);
            this.lbl_horas.TabIndex = 9;
            this.lbl_horas.Text = "Horas:";
            // 
            // cb_horas
            // 
            this.cb_horas.FormattingEnabled = true;
            this.cb_horas.Items.AddRange(new object[] {
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19"});
            this.cb_horas.Location = new System.Drawing.Point(365, 283);
            this.cb_horas.Name = "cb_horas";
            this.cb_horas.Size = new System.Drawing.Size(40, 21);
            this.cb_horas.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(411, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "/";
            // 
            // cb_minutos
            // 
            this.cb_minutos.FormattingEnabled = true;
            this.cb_minutos.Items.AddRange(new object[] {
            "00",
            "30"});
            this.cb_minutos.Location = new System.Drawing.Point(430, 283);
            this.cb_minutos.Name = "cb_minutos";
            this.cb_minutos.Size = new System.Drawing.Size(40, 21);
            this.cb_minutos.TabIndex = 12;
            // 
            // btn_inserir
            // 
            this.btn_inserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(176)))));
            this.btn_inserir.FlatAppearance.BorderSize = 0;
            this.btn_inserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inserir.ForeColor = System.Drawing.Color.White;
            this.btn_inserir.Location = new System.Drawing.Point(447, 350);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(150, 50);
            this.btn_inserir.TabIndex = 13;
            this.btn_inserir.Text = "Inserir";
            this.btn_inserir.UseVisualStyleBackColor = false;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data.ForeColor = System.Drawing.Color.Gray;
            this.lbl_data.Location = new System.Drawing.Point(303, 248);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(48, 20);
            this.lbl_data.TabIndex = 14;
            this.lbl_data.Text = "Data:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(357, 248);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(384, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // label_dados
            // 
            this.label_dados.AutoSize = true;
            this.label_dados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(176)))));
            this.label_dados.Location = new System.Drawing.Point(159, 59);
            this.label_dados.Name = "label_dados";
            this.label_dados.Size = new System.Drawing.Size(142, 16);
            this.label_dados.TabIndex = 26;
            this.label_dados.Text = "Dados da consulta:";
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
            this.buttonBorder.TabIndex = 25;
            this.buttonBorder.UseVisualStyleBackColor = false;
            // 
            // ConsultasInserir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1044, 545);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbl_data);
            this.Controls.Add(this.btn_inserir);
            this.Controls.Add(this.cb_minutos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_horas);
            this.Controls.Add(this.lbl_horas);
            this.Controls.Add(this.cb_medico);
            this.Controls.Add(this.lbl_medico);
            this.Controls.Add(this.tb_cliente);
            this.Controls.Add(this.lbl_cliente);
            this.Controls.Add(this.cb_animal);
            this.Controls.Add(this.lbl_animal);
            this.Controls.Add(this.cb_especialidade);
            this.Controls.Add(this.lbl_especialidade);
            this.Controls.Add(this.label_dados);
            this.Controls.Add(this.buttonBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultasInserir";
            this.ShowIcon = false;
            this.Text = "ConsultasInserir";
            this.Load += new System.EventHandler(this.ConsultasInserir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_especialidade;
        private System.Windows.Forms.ComboBox cb_especialidade;
        private System.Windows.Forms.Label lbl_animal;
        private System.Windows.Forms.ComboBox cb_animal;
        private System.Windows.Forms.Label lbl_cliente;
        private System.Windows.Forms.TextBox tb_cliente;
        private System.Windows.Forms.Label lbl_medico;
        private System.Windows.Forms.ComboBox cb_medico;
        private System.Windows.Forms.Label lbl_horas;
        private System.Windows.Forms.ComboBox cb_horas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_minutos;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label_dados;
        private System.Windows.Forms.Button buttonBorder;
    }
}