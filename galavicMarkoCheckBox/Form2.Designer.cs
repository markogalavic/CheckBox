namespace galavicMarkoCheckBox
{
    partial class checkBox
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
            this.dorucak = new System.Windows.Forms.CheckBox();
            this.rucak = new System.Windows.Forms.CheckBox();
            this.vecera = new System.Windows.Forms.CheckBox();
            this.prikaz = new System.Windows.Forms.TextBox();
            this.sakrij = new System.Windows.Forms.CheckBox();
            this.posalji = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dorucak
            // 
            this.dorucak.AutoSize = true;
            this.dorucak.Location = new System.Drawing.Point(88, 85);
            this.dorucak.Name = "dorucak";
            this.dorucak.Size = new System.Drawing.Size(67, 17);
            this.dorucak.TabIndex = 0;
            this.dorucak.Text = "Dorucak";
            this.dorucak.UseVisualStyleBackColor = true;
            this.dorucak.CheckedChanged += new System.EventHandler(this.Dorucak_CheckedChanged);
            // 
            // rucak
            // 
            this.rucak.AutoSize = true;
            this.rucak.Location = new System.Drawing.Point(88, 143);
            this.rucak.Name = "rucak";
            this.rucak.Size = new System.Drawing.Size(58, 17);
            this.rucak.TabIndex = 1;
            this.rucak.Text = "Rucak";
            this.rucak.UseVisualStyleBackColor = true;
            this.rucak.CheckedChanged += new System.EventHandler(this.Rucak_CheckedChanged);
            // 
            // vecera
            // 
            this.vecera.AutoSize = true;
            this.vecera.Location = new System.Drawing.Point(88, 192);
            this.vecera.Name = "vecera";
            this.vecera.Size = new System.Drawing.Size(60, 17);
            this.vecera.TabIndex = 2;
            this.vecera.Text = "Vecera";
            this.vecera.UseVisualStyleBackColor = true;
            this.vecera.CheckedChanged += new System.EventHandler(this.CheckBox3_CheckedChanged);
            // 
            // prikaz
            // 
            this.prikaz.Location = new System.Drawing.Point(454, 102);
            this.prikaz.Multiline = true;
            this.prikaz.Name = "prikaz";
            this.prikaz.Size = new System.Drawing.Size(238, 170);
            this.prikaz.TabIndex = 4;
            this.prikaz.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // sakrij
            // 
            this.sakrij.AutoSize = true;
            this.sakrij.Location = new System.Drawing.Point(454, 293);
            this.sakrij.Name = "sakrij";
            this.sakrij.Size = new System.Drawing.Size(99, 17);
            this.sakrij.TabIndex = 5;
            this.sakrij.Text = "Sakrij narudžbu";
            this.sakrij.UseVisualStyleBackColor = true;
            this.sakrij.CheckedChanged += new System.EventHandler(this.Sakrij_CheckedChanged);
            // 
            // posalji
            // 
            this.posalji.Location = new System.Drawing.Point(88, 293);
            this.posalji.Name = "posalji";
            this.posalji.Size = new System.Drawing.Size(152, 34);
            this.posalji.TabIndex = 6;
            this.posalji.Text = "Pošalji";
            this.posalji.UseVisualStyleBackColor = true;
            this.posalji.Click += new System.EventHandler(this.Posalji_Click);
            // 
            // checkBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.posalji);
            this.Controls.Add(this.sakrij);
            this.Controls.Add(this.prikaz);
            this.Controls.Add(this.vecera);
            this.Controls.Add(this.rucak);
            this.Controls.Add(this.dorucak);
            this.Name = "checkBox";
            this.Text = "Upotreba CheckBox kontrole";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox dorucak;
        private System.Windows.Forms.CheckBox rucak;
        private System.Windows.Forms.CheckBox vecera;
        private System.Windows.Forms.TextBox prikaz;
        private System.Windows.Forms.CheckBox sakrij;
        private System.Windows.Forms.Button posalji;
    }
}

