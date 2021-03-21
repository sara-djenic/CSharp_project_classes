namespace Zadatak1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProizvodjac = new System.Windows.Forms.TextBox();
            this.txtCenaDostave = new System.Windows.Forms.TextBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbBoxRAM = new System.Windows.Forms.ComboBox();
            this.cmbBoxProcesor = new System.Windows.Forms.ComboBox();
            this.cmbBoxGraficka = new System.Windows.Forms.ComboBox();
            this.numKolicina = new System.Windows.Forms.NumericUpDown();
            this.txtMaticna = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proizvodjac: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "RAM:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Procesor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Maticna ploca:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cena:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Kolicina:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 413);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cena dostave: ";
            // 
            // txtProizvodjac
            // 
            this.txtProizvodjac.Location = new System.Drawing.Point(165, 41);
            this.txtProizvodjac.Name = "txtProizvodjac";
            this.txtProizvodjac.Size = new System.Drawing.Size(100, 20);
            this.txtProizvodjac.TabIndex = 7;
            // 
            // txtCenaDostave
            // 
            this.txtCenaDostave.Location = new System.Drawing.Point(165, 410);
            this.txtCenaDostave.Name = "txtCenaDostave";
            this.txtCenaDostave.Size = new System.Drawing.Size(100, 20);
            this.txtCenaDostave.TabIndex = 11;
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(165, 305);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(100, 20);
            this.txtCena.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(500, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 44);
            this.button1.TabIndex = 14;
            this.button1.Text = "Dodaj u listu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbBoxRAM
            // 
            this.cmbBoxRAM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxRAM.FormattingEnabled = true;
            this.cmbBoxRAM.Items.AddRange(new object[] {
            "4",
            "8",
            "16",
            "32"});
            this.cmbBoxRAM.Location = new System.Drawing.Point(165, 87);
            this.cmbBoxRAM.Name = "cmbBoxRAM";
            this.cmbBoxRAM.Size = new System.Drawing.Size(100, 21);
            this.cmbBoxRAM.TabIndex = 15;
            this.cmbBoxRAM.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbBoxProcesor
            // 
            this.cmbBoxProcesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxProcesor.FormattingEnabled = true;
            this.cmbBoxProcesor.Items.AddRange(new object[] {
            "AMD ",
            "Intel"});
            this.cmbBoxProcesor.Location = new System.Drawing.Point(165, 124);
            this.cmbBoxProcesor.Name = "cmbBoxProcesor";
            this.cmbBoxProcesor.Size = new System.Drawing.Size(100, 21);
            this.cmbBoxProcesor.TabIndex = 16;
            this.cmbBoxProcesor.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cmbBoxGraficka
            // 
            this.cmbBoxGraficka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxGraficka.FormattingEnabled = true;
            this.cmbBoxGraficka.Items.AddRange(new object[] {
            "AMD Radeon ",
            "Nvidia ",
            "Intel"});
            this.cmbBoxGraficka.Location = new System.Drawing.Point(513, 33);
            this.cmbBoxGraficka.Name = "cmbBoxGraficka";
            this.cmbBoxGraficka.Size = new System.Drawing.Size(100, 21);
            this.cmbBoxGraficka.TabIndex = 17;
            // 
            // numKolicina
            // 
            this.numKolicina.Location = new System.Drawing.Point(165, 356);
            this.numKolicina.Name = "numKolicina";
            this.numKolicina.Size = new System.Drawing.Size(100, 20);
            this.numKolicina.TabIndex = 18;
            // 
            // txtMaticna
            // 
            this.txtMaticna.Location = new System.Drawing.Point(165, 182);
            this.txtMaticna.Name = "txtMaticna";
            this.txtMaticna.Size = new System.Drawing.Size(100, 20);
            this.txtMaticna.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(400, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Graficka kartica:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(500, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 41);
            this.button2.TabIndex = 21;
            this.button2.Text = "Serijalizacija";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 482);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMaticna);
            this.Controls.Add(this.numKolicina);
            this.Controls.Add(this.cmbBoxGraficka);
            this.Controls.Add(this.cmbBoxProcesor);
            this.Controls.Add(this.cmbBoxRAM);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.txtCenaDostave);
            this.Controls.Add(this.txtProizvodjac);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numKolicina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProizvodjac;
        private System.Windows.Forms.TextBox txtCenaDostave;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbBoxRAM;
        private System.Windows.Forms.ComboBox cmbBoxProcesor;
        private System.Windows.Forms.ComboBox cmbBoxGraficka;
        private System.Windows.Forms.NumericUpDown numKolicina;
        private System.Windows.Forms.TextBox txtMaticna;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
    }
}

