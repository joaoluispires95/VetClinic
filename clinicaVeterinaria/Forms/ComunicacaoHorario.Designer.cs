
namespace clinicaVeterinaria.Forms
{
    partial class ComunicacaoHorario
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
            this.lbl_motivo = new System.Windows.Forms.Label();
            this.cb_motivo = new System.Windows.Forms.ComboBox();
            this.lbl_dia = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cb_horas = new System.Windows.Forms.ComboBox();
            this.lbl_horas = new System.Windows.Forms.Label();
            this.cb_minutos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_mensagemAdicional = new System.Windows.Forms.TextBox();
            this.btn_enviar = new System.Windows.Forms.Button();
            this.label_dados = new System.Windows.Forms.Label();
            this.buttonBorder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_motivo
            // 
            this.lbl_motivo.AutoSize = true;
            this.lbl_motivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_motivo.ForeColor = System.Drawing.Color.Gray;
            this.lbl_motivo.Location = new System.Drawing.Point(303, 111);
            this.lbl_motivo.Name = "lbl_motivo";
            this.lbl_motivo.Size = new System.Drawing.Size(59, 20);
            this.lbl_motivo.TabIndex = 0;
            this.lbl_motivo.Text = "Motivo:";
            // 
            // cb_motivo
            // 
            this.cb_motivo.FormattingEnabled = true;
            this.cb_motivo.Items.AddRange(new object[] {
            "Encerrado",
            "Abertura tardia",
            "Fecho antecipado"});
            this.cb_motivo.Location = new System.Drawing.Point(368, 111);
            this.cb_motivo.Name = "cb_motivo";
            this.cb_motivo.Size = new System.Drawing.Size(373, 21);
            this.cb_motivo.TabIndex = 1;
            this.cb_motivo.SelectedIndexChanged += new System.EventHandler(this.cb_motivo_SelectedIndexChanged);
            // 
            // lbl_dia
            // 
            this.lbl_dia.AutoSize = true;
            this.lbl_dia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dia.ForeColor = System.Drawing.Color.Gray;
            this.lbl_dia.Location = new System.Drawing.Point(303, 149);
            this.lbl_dia.Name = "lbl_dia";
            this.lbl_dia.Size = new System.Drawing.Size(37, 20);
            this.lbl_dia.TabIndex = 2;
            this.lbl_dia.Text = "Dia:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(346, 149);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(395, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // cb_horas
            // 
            this.cb_horas.Enabled = false;
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
            this.cb_horas.Location = new System.Drawing.Point(365, 186);
            this.cb_horas.Name = "cb_horas";
            this.cb_horas.Size = new System.Drawing.Size(40, 21);
            this.cb_horas.TabIndex = 4;
            // 
            // lbl_horas
            // 
            this.lbl_horas.AutoSize = true;
            this.lbl_horas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_horas.ForeColor = System.Drawing.Color.Gray;
            this.lbl_horas.Location = new System.Drawing.Point(303, 186);
            this.lbl_horas.Name = "lbl_horas";
            this.lbl_horas.Size = new System.Drawing.Size(56, 20);
            this.lbl_horas.TabIndex = 5;
            this.lbl_horas.Text = "Horas:";
            // 
            // cb_minutos
            // 
            this.cb_minutos.Enabled = false;
            this.cb_minutos.FormattingEnabled = true;
            this.cb_minutos.Items.AddRange(new object[] {
            "00",
            "30"});
            this.cb_minutos.Location = new System.Drawing.Point(430, 186);
            this.cb_minutos.Name = "cb_minutos";
            this.cb_minutos.Size = new System.Drawing.Size(40, 21);
            this.cb_minutos.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(411, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "/";
            // 
            // tb_mensagemAdicional
            // 
            this.tb_mensagemAdicional.Location = new System.Drawing.Point(307, 224);
            this.tb_mensagemAdicional.Multiline = true;
            this.tb_mensagemAdicional.Name = "tb_mensagemAdicional";
            this.tb_mensagemAdicional.Size = new System.Drawing.Size(434, 124);
            this.tb_mensagemAdicional.TabIndex = 13;
            this.tb_mensagemAdicional.Text = "Mensagem adicional (opcional)";
            // 
            // btn_enviar
            // 
            this.btn_enviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(176)))));
            this.btn_enviar.FlatAppearance.BorderSize = 0;
            this.btn_enviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enviar.ForeColor = System.Drawing.Color.White;
            this.btn_enviar.Location = new System.Drawing.Point(447, 370);
            this.btn_enviar.Name = "btn_enviar";
            this.btn_enviar.Size = new System.Drawing.Size(150, 50);
            this.btn_enviar.TabIndex = 14;
            this.btn_enviar.Text = "Enviar";
            this.btn_enviar.UseVisualStyleBackColor = false;
            this.btn_enviar.Click += new System.EventHandler(this.btn_enviar_Click);
            // 
            // label_dados
            // 
            this.label_dados.AutoSize = true;
            this.label_dados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(176)))));
            this.label_dados.Location = new System.Drawing.Point(159, 59);
            this.label_dados.Name = "label_dados";
            this.label_dados.Size = new System.Drawing.Size(218, 16);
            this.label_dados.TabIndex = 26;
            this.label_dados.Text = "Aviso de alteração de horário:";
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
            // ComunicacaoHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1044, 545);
            this.Controls.Add(this.btn_enviar);
            this.Controls.Add(this.tb_mensagemAdicional);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_minutos);
            this.Controls.Add(this.lbl_horas);
            this.Controls.Add(this.cb_horas);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbl_dia);
            this.Controls.Add(this.cb_motivo);
            this.Controls.Add(this.lbl_motivo);
            this.Controls.Add(this.label_dados);
            this.Controls.Add(this.buttonBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ComunicacaoHorario";
            this.ShowIcon = false;
            this.Text = "ComunicacaoHorario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_motivo;
        private System.Windows.Forms.ComboBox cb_motivo;
        private System.Windows.Forms.Label lbl_dia;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cb_horas;
        private System.Windows.Forms.Label lbl_horas;
        private System.Windows.Forms.ComboBox cb_minutos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_mensagemAdicional;
        private System.Windows.Forms.Button btn_enviar;
        private System.Windows.Forms.Label label_dados;
        private System.Windows.Forms.Button buttonBorder;
    }
}