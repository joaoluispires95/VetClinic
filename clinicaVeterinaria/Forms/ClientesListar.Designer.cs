
namespace clinicaVeterinaria.Forms
{
    partial class ClientesListar
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_apagar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.lbl_morada = new System.Windows.Forms.Label();
            this.tb_morada = new System.Windows.Forms.TextBox();
            this.lbl_telemovel = new System.Windows.Forms.Label();
            this.tb_telemovel = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.lbl_aviso = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(176)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1044, 250);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 295);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1044, 250);
            this.panel1.TabIndex = 1;
            // 
            // btn_apagar
            // 
            this.btn_apagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(176)))));
            this.btn_apagar.FlatAppearance.BorderSize = 0;
            this.btn_apagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_apagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_apagar.ForeColor = System.Drawing.Color.White;
            this.btn_apagar.Location = new System.Drawing.Point(882, 178);
            this.btn_apagar.Name = "btn_apagar";
            this.btn_apagar.Size = new System.Drawing.Size(150, 75);
            this.btn_apagar.TabIndex = 2;
            this.btn_apagar.Text = "Apagar";
            this.btn_apagar.UseVisualStyleBackColor = false;
            this.btn_apagar.Click += new System.EventHandler(this.btn_apagar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(196)))), ((int)(((byte)(176)))));
            this.btn_editar.FlatAppearance.BorderSize = 0;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = System.Drawing.Color.White;
            this.btn_editar.Location = new System.Drawing.Point(882, 48);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(150, 75);
            this.btn_editar.TabIndex = 3;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // lbl_morada
            // 
            this.lbl_morada.AutoSize = true;
            this.lbl_morada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_morada.ForeColor = System.Drawing.Color.Gray;
            this.lbl_morada.Location = new System.Drawing.Point(303, 50);
            this.lbl_morada.Name = "lbl_morada";
            this.lbl_morada.Size = new System.Drawing.Size(67, 20);
            this.lbl_morada.TabIndex = 4;
            this.lbl_morada.Text = "Morada:";
            this.lbl_morada.Visible = false;
            // 
            // tb_morada
            // 
            this.tb_morada.Location = new System.Drawing.Point(376, 50);
            this.tb_morada.Name = "tb_morada";
            this.tb_morada.Size = new System.Drawing.Size(365, 20);
            this.tb_morada.TabIndex = 5;
            this.tb_morada.Visible = false;
            // 
            // lbl_telemovel
            // 
            this.lbl_telemovel.AutoSize = true;
            this.lbl_telemovel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telemovel.ForeColor = System.Drawing.Color.Gray;
            this.lbl_telemovel.Location = new System.Drawing.Point(303, 88);
            this.lbl_telemovel.Name = "lbl_telemovel";
            this.lbl_telemovel.Size = new System.Drawing.Size(84, 20);
            this.lbl_telemovel.TabIndex = 6;
            this.lbl_telemovel.Text = "Telemóvel:";
            this.lbl_telemovel.Visible = false;
            // 
            // tb_telemovel
            // 
            this.tb_telemovel.Location = new System.Drawing.Point(393, 88);
            this.tb_telemovel.Name = "tb_telemovel";
            this.tb_telemovel.Size = new System.Drawing.Size(348, 20);
            this.tb_telemovel.TabIndex = 7;
            this.tb_telemovel.Visible = false;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.Color.Gray;
            this.lbl_email.Location = new System.Drawing.Point(303, 125);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(52, 20);
            this.lbl_email.TabIndex = 8;
            this.lbl_email.Text = "Email:";
            this.lbl_email.Visible = false;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(361, 125);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(380, 20);
            this.tb_email.TabIndex = 9;
            this.tb_email.Visible = false;
            // 
            // lbl_aviso
            // 
            this.lbl_aviso.ForeColor = System.Drawing.Color.Gray;
            this.lbl_aviso.Location = new System.Drawing.Point(319, 274);
            this.lbl_aviso.Name = "lbl_aviso";
            this.lbl_aviso.Size = new System.Drawing.Size(407, 18);
            this.lbl_aviso.TabIndex = 10;
            this.lbl_aviso.Text = "Para apagar/editar um registo: selecione um registo e de seguida, pressione o bot" +
    "ão";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(82)))), ((int)(((byte)(140)))));
            this.panel2.Location = new System.Drawing.Point(825, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 200);
            this.panel2.TabIndex = 11;
            // 
            // ClientesListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1044, 545);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbl_aviso);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.tb_telemovel);
            this.Controls.Add(this.lbl_telemovel);
            this.Controls.Add(this.tb_morada);
            this.Controls.Add(this.lbl_morada);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_apagar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientesListar";
            this.ShowIcon = false;
            this.Text = "ClientesListar";
            this.Load += new System.EventHandler(this.ClientesListar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_apagar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Label lbl_morada;
        private System.Windows.Forms.TextBox tb_morada;
        private System.Windows.Forms.Label lbl_telemovel;
        private System.Windows.Forms.TextBox tb_telemovel;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label lbl_aviso;
        private System.Windows.Forms.Panel panel2;
    }
}