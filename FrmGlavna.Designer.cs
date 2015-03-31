namespace WindowsFormsApplication1
{
    partial class FrmGlavna
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
            this.groupBoxUplaceni = new System.Windows.Forms.GroupBox();
            this.txtUplaceniBroj1 = new System.Windows.Forms.TextBox();
            this.txtUplaceniBroj2 = new System.Windows.Forms.TextBox();
            this.txtUplaceniBroj3 = new System.Windows.Forms.TextBox();
            this.txtUplaceniBroj4 = new System.Windows.Forms.TextBox();
            this.txtUplaceniBroj5 = new System.Windows.Forms.TextBox();
            this.txtUplaceniBroj6 = new System.Windows.Forms.TextBox();
            this.txtUplaceniBroj7 = new System.Windows.Forms.TextBox();
            this.btnUplati = new System.Windows.Forms.Button();
            this.groupBoxDobitni = new System.Windows.Forms.GroupBox();
            this.groupBoxUplaceni.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUplaceni
            // 
            this.groupBoxUplaceni.Controls.Add(this.btnUplati);
            this.groupBoxUplaceni.Controls.Add(this.txtUplaceniBroj7);
            this.groupBoxUplaceni.Controls.Add(this.txtUplaceniBroj6);
            this.groupBoxUplaceni.Controls.Add(this.txtUplaceniBroj5);
            this.groupBoxUplaceni.Controls.Add(this.txtUplaceniBroj4);
            this.groupBoxUplaceni.Controls.Add(this.txtUplaceniBroj3);
            this.groupBoxUplaceni.Controls.Add(this.txtUplaceniBroj2);
            this.groupBoxUplaceni.Controls.Add(this.txtUplaceniBroj1);
            this.groupBoxUplaceni.Location = new System.Drawing.Point(12, 21);
            this.groupBoxUplaceni.Name = "groupBoxUplaceni";
            this.groupBoxUplaceni.Size = new System.Drawing.Size(348, 102);
            this.groupBoxUplaceni.TabIndex = 0;
            this.groupBoxUplaceni.TabStop = false;
            this.groupBoxUplaceni.Text = "Uplacena kombinacija";
            // 
            // txtUplaceniBroj1
            // 
            this.txtUplaceniBroj1.Location = new System.Drawing.Point(16, 19);
            this.txtUplaceniBroj1.Name = "txtUplaceniBroj1";
            this.txtUplaceniBroj1.Size = new System.Drawing.Size(40, 20);
            this.txtUplaceniBroj1.TabIndex = 0;
            // 
            // txtUplaceniBroj2
            // 
            this.txtUplaceniBroj2.Location = new System.Drawing.Point(62, 19);
            this.txtUplaceniBroj2.Name = "txtUplaceniBroj2";
            this.txtUplaceniBroj2.Size = new System.Drawing.Size(40, 20);
            this.txtUplaceniBroj2.TabIndex = 1;
            // 
            // txtUplaceniBroj3
            // 
            this.txtUplaceniBroj3.Location = new System.Drawing.Point(108, 19);
            this.txtUplaceniBroj3.Name = "txtUplaceniBroj3";
            this.txtUplaceniBroj3.Size = new System.Drawing.Size(40, 20);
            this.txtUplaceniBroj3.TabIndex = 2;
            // 
            // txtUplaceniBroj4
            // 
            this.txtUplaceniBroj4.Location = new System.Drawing.Point(154, 19);
            this.txtUplaceniBroj4.Name = "txtUplaceniBroj4";
            this.txtUplaceniBroj4.Size = new System.Drawing.Size(40, 20);
            this.txtUplaceniBroj4.TabIndex = 3;
            // 
            // txtUplaceniBroj5
            // 
            this.txtUplaceniBroj5.Location = new System.Drawing.Point(200, 19);
            this.txtUplaceniBroj5.Name = "txtUplaceniBroj5";
            this.txtUplaceniBroj5.Size = new System.Drawing.Size(40, 20);
            this.txtUplaceniBroj5.TabIndex = 4;
            // 
            // txtUplaceniBroj6
            // 
            this.txtUplaceniBroj6.Location = new System.Drawing.Point(246, 19);
            this.txtUplaceniBroj6.Name = "txtUplaceniBroj6";
            this.txtUplaceniBroj6.Size = new System.Drawing.Size(40, 20);
            this.txtUplaceniBroj6.TabIndex = 5;
            // 
            // txtUplaceniBroj7
            // 
            this.txtUplaceniBroj7.Location = new System.Drawing.Point(292, 19);
            this.txtUplaceniBroj7.Name = "txtUplaceniBroj7";
            this.txtUplaceniBroj7.Size = new System.Drawing.Size(40, 20);
            this.txtUplaceniBroj7.TabIndex = 6;
            // 
            // btnUplati
            // 
            this.btnUplati.Location = new System.Drawing.Point(246, 61);
            this.btnUplati.Name = "btnUplati";
            this.btnUplati.Size = new System.Drawing.Size(75, 23);
            this.btnUplati.TabIndex = 7;
            this.btnUplati.Text = "Uplati";
            this.btnUplati.UseVisualStyleBackColor = true;
            // 
            // groupBoxDobitni
            // 
            this.groupBoxDobitni.Location = new System.Drawing.Point(12, 144);
            this.groupBoxDobitni.Name = "groupBoxDobitni";
            this.groupBoxDobitni.Size = new System.Drawing.Size(348, 93);
            this.groupBoxDobitni.TabIndex = 1;
            this.groupBoxDobitni.TabStop = false;
            this.groupBoxDobitni.Text = "Dobitna kombinacija";
            // 
            // FrmGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 293);
            this.Controls.Add(this.groupBoxDobitni);
            this.Controls.Add(this.groupBoxUplaceni);
            this.Name = "FrmGlavna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOTO ";
            this.groupBoxUplaceni.ResumeLayout(false);
            this.groupBoxUplaceni.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUplaceni;
        private System.Windows.Forms.Button btnUplati;
        private System.Windows.Forms.TextBox txtUplaceniBroj7;
        private System.Windows.Forms.TextBox txtUplaceniBroj6;
        private System.Windows.Forms.TextBox txtUplaceniBroj5;
        private System.Windows.Forms.TextBox txtUplaceniBroj4;
        private System.Windows.Forms.TextBox txtUplaceniBroj3;
        private System.Windows.Forms.TextBox txtUplaceniBroj2;
        private System.Windows.Forms.TextBox txtUplaceniBroj1;
        private System.Windows.Forms.GroupBox groupBoxDobitni;
    }
}

