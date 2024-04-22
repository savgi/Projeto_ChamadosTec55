namespace ChamadosTecnicosTec55.Adicionar
{
    partial class frmAdicionarTecnico
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txbSENHA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbEMAIL = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbESPECIALIDADE = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbNOME = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbOBS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(288, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "&Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(116, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "&Salvar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txbSENHA
            // 
            this.txbSENHA.Location = new System.Drawing.Point(27, 238);
            this.txbSENHA.Multiline = true;
            this.txbSENHA.Name = "txbSENHA";
            this.txbSENHA.Size = new System.Drawing.Size(455, 19);
            this.txbSENHA.TabIndex = 23;
            this.txbSENHA.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Email";
            // 
            // txbEMAIL
            // 
            this.txbEMAIL.Location = new System.Drawing.Point(25, 189);
            this.txbEMAIL.Name = "txbEMAIL";
            this.txbEMAIL.Size = new System.Drawing.Size(456, 20);
            this.txbEMAIL.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Especialidade";
            // 
            // txbESPECIALIDADE
            // 
            this.txbESPECIALIDADE.Location = new System.Drawing.Point(27, 125);
            this.txbESPECIALIDADE.Name = "txbESPECIALIDADE";
            this.txbESPECIALIDADE.Size = new System.Drawing.Size(456, 20);
            this.txbESPECIALIDADE.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Nome";
            // 
            // txbNOME
            // 
            this.txbNOME.Location = new System.Drawing.Point(27, 67);
            this.txbNOME.Name = "txbNOME";
            this.txbNOME.Size = new System.Drawing.Size(456, 20);
            this.txbNOME.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(211, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 31);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tecnico";
            // 
            // txbOBS
            // 
            this.txbOBS.Location = new System.Drawing.Point(29, 285);
            this.txbOBS.Multiline = true;
            this.txbOBS.Name = "txbOBS";
            this.txbOBS.Size = new System.Drawing.Size(455, 45);
            this.txbOBS.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Obs";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmAdicionarTecnico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 382);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbOBS);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txbSENHA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbEMAIL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbESPECIALIDADE);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbNOME);
            this.Controls.Add(this.label8);
            this.Name = "frmAdicionarTecnico";
            this.Text = "frmAdicionarTecnico";
            this.Load += new System.EventHandler(this.frmAdicionarTecnico_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txbSENHA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbEMAIL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbESPECIALIDADE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbNOME;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbOBS;
        private System.Windows.Forms.Label label1;
    }
}