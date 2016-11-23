namespace FOR2B2U_Tverk7
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbSkraFlokkur = new System.Windows.Forms.ComboBox();
            this.btSkra = new System.Windows.Forms.Button();
            this.tbSkraAr = new System.Windows.Forms.TextBox();
            this.tbSkraUtgefandi = new System.Windows.Forms.TextBox();
            this.tbSkraLeikstjori = new System.Windows.Forms.TextBox();
            this.tbSkraTitill = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tb = new System.Windows.Forms.TextBox();
            this.btUppfaera = new System.Windows.Forms.Button();
            this.lvTafla = new System.Windows.Forms.ListView();
            this.tbLeikstjori = new System.Windows.Forms.TextBox();
            this.tbFlokkur = new System.Windows.Forms.TextBox();
            this.tbUtgefandi = new System.Windows.Forms.TextBox();
            this.tbTitill = new System.Windows.Forms.TextBox();
            this.tbAr = new System.Windows.Forms.TextBox();
            this.btEyda = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1394, 665);
            this.tabControl1.TabIndex = 25;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbSkraFlokkur);
            this.tabPage1.Controls.Add(this.btSkra);
            this.tabPage1.Controls.Add(this.tbSkraAr);
            this.tabPage1.Controls.Add(this.tbSkraUtgefandi);
            this.tabPage1.Controls.Add(this.tbSkraLeikstjori);
            this.tabPage1.Controls.Add(this.tbSkraTitill);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1386, 639);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbSkraFlokkur
            // 
            this.cbSkraFlokkur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSkraFlokkur.FormattingEnabled = true;
            this.cbSkraFlokkur.Items.AddRange(new object[] {
            "Hasar",
            "Ævintýri",
            "Gaman",
            "Glæpa",
            "Drama",
            "Fantasía",
            "Söguleg",
            "Hrollvekja",
            "Rómantík",
            "Spennutryllir",
            ""});
            this.cbSkraFlokkur.Location = new System.Drawing.Point(189, 267);
            this.cbSkraFlokkur.Name = "cbSkraFlokkur";
            this.cbSkraFlokkur.Size = new System.Drawing.Size(214, 28);
            this.cbSkraFlokkur.TabIndex = 6;
            // 
            // btSkra
            // 
            this.btSkra.Location = new System.Drawing.Point(423, 141);
            this.btSkra.Name = "btSkra";
            this.btSkra.Size = new System.Drawing.Size(106, 23);
            this.btSkra.TabIndex = 5;
            this.btSkra.Text = "button1";
            this.btSkra.UseVisualStyleBackColor = true;
            this.btSkra.Click += new System.EventHandler(this.btSkra_Click);
            // 
            // tbSkraAr
            // 
            this.tbSkraAr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSkraAr.Location = new System.Drawing.Point(189, 234);
            this.tbSkraAr.Name = "tbSkraAr";
            this.tbSkraAr.Size = new System.Drawing.Size(214, 26);
            this.tbSkraAr.TabIndex = 3;
            // 
            // tbSkraUtgefandi
            // 
            this.tbSkraUtgefandi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSkraUtgefandi.Location = new System.Drawing.Point(189, 202);
            this.tbSkraUtgefandi.Name = "tbSkraUtgefandi";
            this.tbSkraUtgefandi.Size = new System.Drawing.Size(214, 26);
            this.tbSkraUtgefandi.TabIndex = 2;
            // 
            // tbSkraLeikstjori
            // 
            this.tbSkraLeikstjori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSkraLeikstjori.Location = new System.Drawing.Point(189, 170);
            this.tbSkraLeikstjori.Name = "tbSkraLeikstjori";
            this.tbSkraLeikstjori.Size = new System.Drawing.Size(214, 26);
            this.tbSkraLeikstjori.TabIndex = 1;
            // 
            // tbSkraTitill
            // 
            this.tbSkraTitill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSkraTitill.Location = new System.Drawing.Point(189, 138);
            this.tbSkraTitill.Name = "tbSkraTitill";
            this.tbSkraTitill.Size = new System.Drawing.Size(214, 26);
            this.tbSkraTitill.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btEyda);
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Controls.Add(this.btUppfaera);
            this.tabPage2.Controls.Add(this.lvTafla);
            this.tabPage2.Controls.Add(this.tbLeikstjori);
            this.tabPage2.Controls.Add(this.tbFlokkur);
            this.tabPage2.Controls.Add(this.tbUtgefandi);
            this.tabPage2.Controls.Add(this.tbTitill);
            this.tabPage2.Controls.Add(this.tbAr);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1386, 639);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(7, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1373, 331);
            this.tabControl2.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1365, 305);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tb);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1365, 305);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tb
            // 
            this.tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb.Location = new System.Drawing.Point(44, 56);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(214, 26);
            this.tb.TabIndex = 1;
            // 
            // btUppfaera
            // 
            this.btUppfaera.Location = new System.Drawing.Point(931, 503);
            this.btUppfaera.Name = "btUppfaera";
            this.btUppfaera.Size = new System.Drawing.Size(83, 23);
            this.btUppfaera.TabIndex = 9;
            this.btUppfaera.Text = "Breyta";
            this.btUppfaera.UseVisualStyleBackColor = true;
            this.btUppfaera.Click += new System.EventHandler(this.btUppfaera_Click);
            // 
            // lvTafla
            // 
            this.lvTafla.FullRowSelect = true;
            this.lvTafla.GridLines = true;
            this.lvTafla.Location = new System.Drawing.Point(3, 343);
            this.lvTafla.Name = "lvTafla";
            this.lvTafla.Size = new System.Drawing.Size(718, 287);
            this.lvTafla.TabIndex = 3;
            this.lvTafla.UseCompatibleStateImageBehavior = false;
            this.lvTafla.View = System.Windows.Forms.View.Details;
            this.lvTafla.SelectedIndexChanged += new System.EventHandler(this.lvOutput_SelectedIndexChanged);
            // 
            // tbLeikstjori
            // 
            this.tbLeikstjori.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLeikstjori.Location = new System.Drawing.Point(931, 375);
            this.tbLeikstjori.Name = "tbLeikstjori";
            this.tbLeikstjori.Size = new System.Drawing.Size(165, 26);
            this.tbLeikstjori.TabIndex = 5;
            // 
            // tbFlokkur
            // 
            this.tbFlokkur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFlokkur.Location = new System.Drawing.Point(931, 471);
            this.tbFlokkur.Name = "tbFlokkur";
            this.tbFlokkur.Size = new System.Drawing.Size(165, 26);
            this.tbFlokkur.TabIndex = 8;
            // 
            // tbUtgefandi
            // 
            this.tbUtgefandi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUtgefandi.Location = new System.Drawing.Point(931, 407);
            this.tbUtgefandi.Name = "tbUtgefandi";
            this.tbUtgefandi.Size = new System.Drawing.Size(165, 26);
            this.tbUtgefandi.TabIndex = 6;
            // 
            // tbTitill
            // 
            this.tbTitill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitill.Location = new System.Drawing.Point(931, 343);
            this.tbTitill.Name = "tbTitill";
            this.tbTitill.Size = new System.Drawing.Size(165, 26);
            this.tbTitill.TabIndex = 4;
            // 
            // tbAr
            // 
            this.tbAr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAr.Location = new System.Drawing.Point(931, 439);
            this.tbAr.Name = "tbAr";
            this.tbAr.Size = new System.Drawing.Size(165, 26);
            this.tbAr.TabIndex = 7;
            // 
            // btEyda
            // 
            this.btEyda.Location = new System.Drawing.Point(1013, 503);
            this.btEyda.Name = "btEyda";
            this.btEyda.Size = new System.Drawing.Size(83, 23);
            this.btEyda.TabIndex = 10;
            this.btEyda.Text = "Eyða";
            this.btEyda.UseVisualStyleBackColor = true;
            this.btEyda.Click += new System.EventHandler(this.btEyda_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 667);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Tverk 7";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListView lvTafla;
        private System.Windows.Forms.TextBox tbFlokkur;
        private System.Windows.Forms.TextBox tbAr;
        private System.Windows.Forms.TextBox tbUtgefandi;
        private System.Windows.Forms.TextBox tbLeikstjori;
        private System.Windows.Forms.TextBox tbTitill;
        private System.Windows.Forms.Button btUppfaera;
        private System.Windows.Forms.TextBox tbSkraTitill;
        private System.Windows.Forms.TextBox tbSkraAr;
        private System.Windows.Forms.TextBox tbSkraUtgefandi;
        private System.Windows.Forms.TextBox tbSkraLeikstjori;
        private System.Windows.Forms.Button btSkra;
        private System.Windows.Forms.ComboBox cbSkraFlokkur;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Button btEyda;
    }
}

