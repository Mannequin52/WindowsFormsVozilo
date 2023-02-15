namespace WindowsForms15_2
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
            this.marka = new System.Windows.Forms.TextBox();
            this.model = new System.Windows.Forms.TextBox();
            this.vrsta = new System.Windows.Forms.ComboBox();
            this.rezultat = new System.Windows.Forms.RichTextBox();
            this.unos = new System.Windows.Forms.Button();
            this.ispis = new System.Windows.Forms.Button();
            this.obrada = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.obradatxt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // marka
            // 
            this.marka.Location = new System.Drawing.Point(36, 50);
            this.marka.Name = "marka";
            this.marka.Size = new System.Drawing.Size(121, 20);
            this.marka.TabIndex = 0;
            // 
            // model
            // 
            this.model.Location = new System.Drawing.Point(36, 108);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(121, 20);
            this.model.TabIndex = 1;
            // 
            // vrsta
            // 
            this.vrsta.FormattingEnabled = true;
            this.vrsta.Items.AddRange(new object[] {
            "Avion",
            "Automobil",
            "Brod"});
            this.vrsta.Location = new System.Drawing.Point(36, 175);
            this.vrsta.Name = "vrsta";
            this.vrsta.Size = new System.Drawing.Size(121, 21);
            this.vrsta.TabIndex = 2;
            // 
            // rezultat
            // 
            this.rezultat.Location = new System.Drawing.Point(245, 50);
            this.rezultat.Name = "rezultat";
            this.rezultat.Size = new System.Drawing.Size(336, 146);
            this.rezultat.TabIndex = 3;
            this.rezultat.Text = "";
            // 
            // unos
            // 
            this.unos.Location = new System.Drawing.Point(36, 252);
            this.unos.Name = "unos";
            this.unos.Size = new System.Drawing.Size(75, 23);
            this.unos.TabIndex = 4;
            this.unos.Text = "&Unos";
            this.unos.UseVisualStyleBackColor = true;
            this.unos.Click += new System.EventHandler(this.button1_Click);
            // 
            // ispis
            // 
            this.ispis.Location = new System.Drawing.Point(506, 252);
            this.ispis.Name = "ispis";
            this.ispis.Size = new System.Drawing.Size(75, 23);
            this.ispis.TabIndex = 5;
            this.ispis.Text = "&Ispis";
            this.ispis.UseVisualStyleBackColor = true;
            this.ispis.Click += new System.EventHandler(this.ispis_Click);
            // 
            // obrada
            // 
            this.obrada.Location = new System.Drawing.Point(0, 0);
            this.obrada.Name = "obrada";
            this.obrada.Size = new System.Drawing.Size(75, 23);
            this.obrada.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Model: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Vrsta:";
            // 
            // obradatxt
            // 
            this.obradatxt.Location = new System.Drawing.Point(245, 252);
            this.obradatxt.Name = "obradatxt";
            this.obradatxt.Size = new System.Drawing.Size(75, 23);
            this.obradatxt.TabIndex = 12;
            this.obradatxt.Text = "&Obrada";
            this.obradatxt.UseVisualStyleBackColor = true;
            this.obradatxt.Click += new System.EventHandler(this.obradatxt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Marka:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.obradatxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.obrada);
            this.Controls.Add(this.ispis);
            this.Controls.Add(this.unos);
            this.Controls.Add(this.rezultat);
            this.Controls.Add(this.vrsta);
            this.Controls.Add(this.model);
            this.Controls.Add(this.marka);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox marka;
        private System.Windows.Forms.TextBox model;
        private System.Windows.Forms.ComboBox vrsta;
        private System.Windows.Forms.RichTextBox rezultat;
        private System.Windows.Forms.Button unos;
        private System.Windows.Forms.Button ispis;
        private System.Windows.Forms.Button obrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button obradatxt;
        private System.Windows.Forms.Label label4;
    }
}

