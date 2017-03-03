namespace CartesBinairesV1
{
    partial class View
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
            this.gbx_Bits = new System.Windows.Forms.GroupBox();
            this.pbx_bit1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbx_Bits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_bit1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbx_Bits
            // 
            this.gbx_Bits.Controls.Add(this.pbx_bit1);
            this.gbx_Bits.Location = new System.Drawing.Point(12, 29);
            this.gbx_Bits.Name = "gbx_Bits";
            this.gbx_Bits.Size = new System.Drawing.Size(578, 175);
            this.gbx_Bits.TabIndex = 0;
            this.gbx_Bits.TabStop = false;
            this.gbx_Bits.Text = "Bits";
            // 
            // pbx_bit1
            // 
            this.pbx_bit1.Image = global::CartesBinairesV1.Properties.Resources.DosDeCarte;
            this.pbx_bit1.Location = new System.Drawing.Point(477, 19);
            this.pbx_bit1.Name = "pbx_bit1";
            this.pbx_bit1.Size = new System.Drawing.Size(88, 142);
            this.pbx_bit1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_bit1.TabIndex = 6;
            this.pbx_bit1.TabStop = false;
            this.pbx_bit1.Click += new System.EventHandler(this.pbx_bit1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbx_Bits);
            this.Name = "View";
            this.Text = "Apprends le binaire  !";
            this.gbx_Bits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_bit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_Bits;
        private System.Windows.Forms.PictureBox pbx_bit1;
        private System.Windows.Forms.Label label1;
    }
}

