namespace WindowsFormsApp1
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Glavna = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Desno = new System.Windows.Forms.Button();
            this.btn_Gore = new System.Windows.Forms.Button();
            this.btn_Levo = new System.Windows.Forms.Button();
            this.btn_Dole = new System.Windows.Forms.Button();
            this.lbl_Brojac = new System.Windows.Forms.Label();
            this.lbl_Lokacija = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Goldenrod;
            this.panel1.Controls.Add(this.lbl_Glavna);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 345);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl_Glavna
            // 
            this.lbl_Glavna.AutoSize = true;
            this.lbl_Glavna.Location = new System.Drawing.Point(291, 162);
            this.lbl_Glavna.Name = "lbl_Glavna";
            this.lbl_Glavna.Size = new System.Drawing.Size(15, 13);
            this.lbl_Glavna.TabIndex = 0;
            this.lbl_Glavna.Text = "O";
            this.lbl_Glavna.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.lbl_Lokacija);
            this.panel2.Controls.Add(this.lbl_Brojac);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(637, 0);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel2.Size = new System.Drawing.Size(224, 485);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Fuchsia;
            this.panel3.Controls.Add(this.btn_Desno);
            this.panel3.Controls.Add(this.btn_Gore);
            this.panel3.Controls.Add(this.btn_Levo);
            this.panel3.Controls.Add(this.btn_Dole);
            this.panel3.Location = new System.Drawing.Point(0, 351);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(631, 134);
            this.panel3.TabIndex = 2;
            // 
            // btn_Desno
            // 
            this.btn_Desno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Desno.Location = new System.Drawing.Point(337, 49);
            this.btn_Desno.Name = "btn_Desno";
            this.btn_Desno.Size = new System.Drawing.Size(37, 38);
            this.btn_Desno.TabIndex = 3;
            this.btn_Desno.Text = ">";
            this.btn_Desno.UseVisualStyleBackColor = true;
            this.btn_Desno.Click += new System.EventHandler(this.btn_Desno_Click);
            // 
            // btn_Gore
            // 
            this.btn_Gore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Gore.Location = new System.Drawing.Point(294, 27);
            this.btn_Gore.Name = "btn_Gore";
            this.btn_Gore.Size = new System.Drawing.Size(37, 38);
            this.btn_Gore.TabIndex = 0;
            this.btn_Gore.Text = "/\\";
            this.btn_Gore.UseVisualStyleBackColor = true;
            this.btn_Gore.Click += new System.EventHandler(this.btn_Gore_Click);
            // 
            // btn_Levo
            // 
            this.btn_Levo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Levo.Location = new System.Drawing.Point(251, 49);
            this.btn_Levo.Name = "btn_Levo";
            this.btn_Levo.Size = new System.Drawing.Size(37, 38);
            this.btn_Levo.TabIndex = 2;
            this.btn_Levo.Text = "<";
            this.btn_Levo.UseVisualStyleBackColor = true;
            this.btn_Levo.Click += new System.EventHandler(this.btn_Levo_Click);
            // 
            // btn_Dole
            // 
            this.btn_Dole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Dole.Location = new System.Drawing.Point(294, 71);
            this.btn_Dole.Name = "btn_Dole";
            this.btn_Dole.Size = new System.Drawing.Size(37, 38);
            this.btn_Dole.TabIndex = 1;
            this.btn_Dole.Text = "\\/";
            this.btn_Dole.UseVisualStyleBackColor = true;
            this.btn_Dole.Click += new System.EventHandler(this.btn_Dole_Click);
            // 
            // lbl_Brojac
            // 
            this.lbl_Brojac.AutoSize = true;
            this.lbl_Brojac.Location = new System.Drawing.Point(66, 27);
            this.lbl_Brojac.Name = "lbl_Brojac";
            this.lbl_Brojac.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Brojac.Size = new System.Drawing.Size(73, 13);
            this.lbl_Brojac.TabIndex = 0;
            this.lbl_Brojac.Text = "Broj pokreta : ";
            this.lbl_Brojac.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_Lokacija
            // 
            this.lbl_Lokacija.AutoSize = true;
            this.lbl_Lokacija.Location = new System.Drawing.Point(69, 52);
            this.lbl_Lokacija.Name = "lbl_Lokacija";
            this.lbl_Lokacija.Size = new System.Drawing.Size(35, 13);
            this.lbl_Lokacija.TabIndex = 1;
            this.lbl_Lokacija.Text = "AAAA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(861, 485);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(877, 524);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_Glavna;
        private System.Windows.Forms.Button btn_Desno;
        private System.Windows.Forms.Button btn_Gore;
        private System.Windows.Forms.Button btn_Levo;
        private System.Windows.Forms.Button btn_Dole;
        private System.Windows.Forms.Label lbl_Brojac;
        private System.Windows.Forms.Label lbl_Lokacija;
    }
}

