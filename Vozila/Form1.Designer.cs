namespace Vozila
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
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtGodinaProizvodnje = new System.Windows.Forms.TextBox();
            this.txtKilometraza = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.listbox = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSortiraj = new System.Windows.Forms.Button();
            this.txtSortirano = new System.Windows.Forms.TextBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Godina proizvodnje";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "KIlometraza";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(170, 31);
            this.txtMarka.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(112, 26);
            this.txtMarka.TabIndex = 4;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(170, 71);
            this.txtModel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(112, 26);
            this.txtModel.TabIndex = 5;
            // 
            // txtGodinaProizvodnje
            // 
            this.txtGodinaProizvodnje.Location = new System.Drawing.Point(170, 110);
            this.txtGodinaProizvodnje.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGodinaProizvodnje.Name = "txtGodinaProizvodnje";
            this.txtGodinaProizvodnje.Size = new System.Drawing.Size(112, 26);
            this.txtGodinaProizvodnje.TabIndex = 6;
            // 
            // txtKilometraza
            // 
            this.txtKilometraza.Location = new System.Drawing.Point(170, 150);
            this.txtKilometraza.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtKilometraza.Name = "txtKilometraza";
            this.txtKilometraza.Size = new System.Drawing.Size(112, 26);
            this.txtKilometraza.TabIndex = 7;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(14, 204);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(120, 29);
            this.btnDodaj.TabIndex = 8;
            this.btnDodaj.Text = "Dodaj vozilo";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // listbox
            // 
            this.listbox.FormattingEnabled = true;
            this.listbox.ItemHeight = 20;
            this.listbox.Location = new System.Drawing.Point(321, 31);
            this.listbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(442, 204);
            this.listbox.TabIndex = 9;
            this.listbox.SelectedIndexChanged += new System.EventHandler(this.listbox_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(14, 280);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 28);
            this.comboBox1.TabIndex = 10;
            // 
            // btnSortiraj
            // 
            this.btnSortiraj.Location = new System.Drawing.Point(199, 280);
            this.btnSortiraj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSortiraj.Name = "btnSortiraj";
            this.btnSortiraj.Size = new System.Drawing.Size(84, 29);
            this.btnSortiraj.TabIndex = 11;
            this.btnSortiraj.Text = "Sortiraj";
            this.btnSortiraj.UseVisualStyleBackColor = true;
            this.btnSortiraj.Click += new System.EventHandler(this.btnSortiraj_Click);
            // 
            // txtSortirano
            // 
            this.txtSortirano.Location = new System.Drawing.Point(14, 352);
            this.txtSortirano.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSortirano.Multiline = true;
            this.txtSortirano.Name = "txtSortirano";
            this.txtSortirano.Size = new System.Drawing.Size(471, 153);
            this.txtSortirano.TabIndex = 12;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(361, 285);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(92, 30);
            this.btnObrisi.TabIndex = 13;
            this.btnObrisi.Text = "Brisanje";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 521);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.txtSortirano);
            this.Controls.Add(this.btnSortiraj);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listbox);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtKilometraza);
            this.Controls.Add(this.txtGodinaProizvodnje);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Sortiranje vozila";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtGodinaProizvodnje;
        private System.Windows.Forms.TextBox txtKilometraza;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ListBox listbox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnSortiraj;
        private System.Windows.Forms.TextBox txtSortirano;
        private System.Windows.Forms.Button btnObrisi;
    }
}

