namespace WindowsFormsApp_Service_TEST
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Txtx = new System.Windows.Forms.TextBox();
            this.Txty = new System.Windows.Forms.TextBox();
            this.Txtz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btplus = new System.Windows.Forms.Button();
            this.Btsous = new System.Windows.Forms.Button();
            this.Btdiv = new System.Windows.Forms.Button();
            this.Btmult = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txtx
            // 
            this.Txtx.Location = new System.Drawing.Point(434, 112);
            this.Txtx.Name = "Txtx";
            this.Txtx.Size = new System.Drawing.Size(164, 26);
            this.Txtx.TabIndex = 0;
            this.Txtx.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Txty
            // 
            this.Txty.Location = new System.Drawing.Point(434, 151);
            this.Txty.Name = "Txty";
            this.Txty.Size = new System.Drawing.Size(164, 26);
            this.Txty.TabIndex = 1;
            this.Txty.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Txtz
            // 
            this.Txtz.Location = new System.Drawing.Point(434, 226);
            this.Txtz.Name = "Txtz";
            this.Txtz.Size = new System.Drawing.Size(164, 26);
            this.Txtz.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resultat";
            // 
            // Btplus
            // 
            this.Btplus.Location = new System.Drawing.Point(135, 341);
            this.Btplus.Name = "Btplus";
            this.Btplus.Size = new System.Drawing.Size(75, 37);
            this.Btplus.TabIndex = 6;
            this.Btplus.Text = "+";
            this.Btplus.UseVisualStyleBackColor = true;
            this.Btplus.Click += new System.EventHandler(this.Btplus_Click);
            // 
            // Btsous
            // 
            this.Btsous.Location = new System.Drawing.Point(253, 341);
            this.Btsous.Name = "Btsous";
            this.Btsous.Size = new System.Drawing.Size(75, 38);
            this.Btsous.TabIndex = 7;
            this.Btsous.Text = "-";
            this.Btsous.UseVisualStyleBackColor = true;
            this.Btsous.Click += new System.EventHandler(this.Btsous_Click);
            // 
            // Btdiv
            // 
            this.Btdiv.Location = new System.Drawing.Point(369, 341);
            this.Btdiv.Name = "Btdiv";
            this.Btdiv.Size = new System.Drawing.Size(75, 38);
            this.Btdiv.TabIndex = 8;
            this.Btdiv.Text = "/";
            this.Btdiv.UseVisualStyleBackColor = true;
            this.Btdiv.Click += new System.EventHandler(this.Btdiv_Click);
            // 
            // Btmult
            // 
            this.Btmult.Location = new System.Drawing.Point(492, 341);
            this.Btmult.Name = "Btmult";
            this.Btmult.Size = new System.Drawing.Size(75, 38);
            this.Btmult.TabIndex = 9;
            this.Btmult.Text = "*";
            this.Btmult.UseVisualStyleBackColor = true;
            this.Btmult.Click += new System.EventHandler(this.Btmult_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Bahnini Saad TP WCF";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Btmult);
            this.Controls.Add(this.Btdiv);
            this.Controls.Add(this.Btsous);
            this.Controls.Add(this.Btplus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txtz);
            this.Controls.Add(this.Txty);
            this.Controls.Add(this.Txtx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txtx;
        private System.Windows.Forms.TextBox Txty;
        private System.Windows.Forms.TextBox Txtz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btplus;
        private System.Windows.Forms.Button Btsous;
        private System.Windows.Forms.Button Btdiv;
        private System.Windows.Forms.Button Btmult;
        private System.Windows.Forms.Label label4;
    }
}

