
namespace clinicaVeterinaria.Forms
{
    partial class ComunicacaoCancelar
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
            this.lbl_medico = new System.Windows.Forms.Label();
            this.cb_medicos = new System.Windows.Forms.ComboBox();
            this.lbl_dia = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label_dados = new System.Windows.Forms.Label();
            this.buttonBorder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_medico
            // 
            this.lbl_medico.AutoSize = true;
            this.lbl_medico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_medico.ForeColor = System.Drawing.Color.Gray;
            this.lbl_medico.Location = new System.Drawing.Point(303, 111);
            this.lbl_medico.Name = "lbl_medico";
            this.lbl_medico.Size = new System.Drawing.Size(64, 20);
            this.lbl_medico.TabIndex = 0;
            this.lbl_medico.Text = "Médico:";
            // 
            // cb_medicos
            // 
            this.cb_medicos.FormattingEnabled = true;
            this.cb_medicos.Location = new System.Drawing.Point(373, 111);
            this.cb_medicos.Name = "cb_medicos";
            this.cb_medicos.Size = new System.Drawing.Size(368, 21);
            this.cb_medicos.TabIndex = 1;
            // 
            // lbl_dia
            // 
            this.lbl_dia.AutoSize = true;
            this.lbl_dia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dia.ForeColor = System.Drawing.Color.Gray;
            this.lbl_dia.Location = new System.Drawing.Point(303, 154);
            this.lbl_dia.Name = "lbl_dia";
            this.lbl_dia.Size = new System.Drawing.Size(37, 20);
            this.lbl_dia.TabIndex = 2;
            this.lbl_dia.Text = "Dia:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(346, 154);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(395, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(176)))));
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(447, 300);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(150, 50);
            this.btn_cancelar.TabIndex = 4;
            this.btn_cancelar.Text = "Cancelar consultas";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label_dados
            // 
            this.label_dados.AutoSize = true;
            this.label_dados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(176)))));
            this.label_dados.Location = new System.Drawing.Point(159, 59);
            this.label_dados.Name = "label_dados";
            this.label_dados.Size = new System.Drawing.Size(382, 16);
            this.label_dados.TabIndex = 26;
            this.label_dados.Text = "Cancelar consultas de um médico no dia selecionado:";
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
            // ComunicacaoCancelar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1044, 545);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbl_dia);
            this.Controls.Add(this.cb_medicos);
            this.Controls.Add(this.lbl_medico);
            this.Controls.Add(this.label_dados);
            this.Controls.Add(this.buttonBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ComunicacaoCancelar";
            this.ShowIcon = false;
            this.Text = "ComunicacaoCancelar";
            this.Load += new System.EventHandler(this.ComunicacaoCancelar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_medico;
        private System.Windows.Forms.ComboBox cb_medicos;
        private System.Windows.Forms.Label lbl_dia;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label_dados;
        private System.Windows.Forms.Button buttonBorder;
    }
}