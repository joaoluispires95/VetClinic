
namespace clinicaVeterinaria.Forms
{
    partial class Comunicacao
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
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_horario = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.panelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.White;
            this.panelPrincipal.Controls.Add(this.panel1);
            this.panelPrincipal.Controls.Add(this.btn_horario);
            this.panelPrincipal.Controls.Add(this.btn_cancelar);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1044, 545);
            this.panelPrincipal.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(82)))), ((int)(((byte)(140)))));
            this.panel1.Location = new System.Drawing.Point(520, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 400);
            this.panel1.TabIndex = 4;
            // 
            // btn_horario
            // 
            this.btn_horario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(176)))));
            this.btn_horario.FlatAppearance.BorderSize = 0;
            this.btn_horario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_horario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_horario.ForeColor = System.Drawing.Color.White;
            this.btn_horario.Image = global::clinicaVeterinaria.Properties.Resources.edit;
            this.btn_horario.Location = new System.Drawing.Point(200, 172);
            this.btn_horario.Name = "btn_horario";
            this.btn_horario.Size = new System.Drawing.Size(200, 200);
            this.btn_horario.TabIndex = 0;
            this.btn_horario.Text = "Alteração de horário";
            this.btn_horario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_horario.UseVisualStyleBackColor = false;
            this.btn_horario.Click += new System.EventHandler(this.btn_horario_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(176)))));
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Image = global::clinicaVeterinaria.Properties.Resources.x;
            this.btn_cancelar.Location = new System.Drawing.Point(645, 172);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(200, 200);
            this.btn_cancelar.TabIndex = 1;
            this.btn_cancelar.Text = "Cancelar por médico";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // Comunicacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 545);
            this.Controls.Add(this.panelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Comunicacao";
            this.ShowIcon = false;
            this.Text = "Comunicacao";
            this.panelPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_horario;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panel1;
    }
}