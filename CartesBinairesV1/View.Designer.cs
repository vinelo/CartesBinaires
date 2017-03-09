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
            this.components = new System.ComponentModel.Container();
            this.gbx_Bits = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.tmrAutoDec = new System.Windows.Forms.Timer(this.components);
            this.btn_Croissant = new System.Windows.Forms.Button();
            this.btn_Decroissant = new System.Windows.Forms.Button();
            this.numNumberOfBits = new System.Windows.Forms.NumericUpDown();
            this.btn_Stop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfBits)).BeginInit();
            this.SuspendLayout();
            // 
            // gbx_Bits
            // 
            this.gbx_Bits.Location = new System.Drawing.Point(12, 29);
            this.gbx_Bits.Name = "gbx_Bits";
            this.gbx_Bits.Size = new System.Drawing.Size(751, 175);
            this.gbx_Bits.TabIndex = 0;
            this.gbx_Bits.TabStop = false;
            this.gbx_Bits.Text = "Bits";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(769, 109);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(35, 13);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "label1";
            // 
            // tmrAutoDec
            // 
            this.tmrAutoDec.Tick += new System.EventHandler(this.tmrAutoDec_Tick);
            // 
            // btn_Croissant
            // 
            this.btn_Croissant.Location = new System.Drawing.Point(298, 232);
            this.btn_Croissant.Name = "btn_Croissant";
            this.btn_Croissant.Size = new System.Drawing.Size(75, 48);
            this.btn_Croissant.TabIndex = 2;
            this.btn_Croissant.Text = " Mode automatique croissant";
            this.btn_Croissant.UseVisualStyleBackColor = true;
            this.btn_Croissant.Click += new System.EventHandler(this.btn_Croissant_Click);
            // 
            // btn_Decroissant
            // 
            this.btn_Decroissant.Location = new System.Drawing.Point(379, 232);
            this.btn_Decroissant.Name = "btn_Decroissant";
            this.btn_Decroissant.Size = new System.Drawing.Size(75, 48);
            this.btn_Decroissant.TabIndex = 3;
            this.btn_Decroissant.Text = " Mode automatique décroissant";
            this.btn_Decroissant.UseVisualStyleBackColor = true;
            this.btn_Decroissant.Click += new System.EventHandler(this.btn_Decroissant_Click);
            // 
            // numNumberOfBits
            // 
            this.numNumberOfBits.Location = new System.Drawing.Point(772, 126);
            this.numNumberOfBits.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numNumberOfBits.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numNumberOfBits.Name = "numNumberOfBits";
            this.numNumberOfBits.Size = new System.Drawing.Size(57, 20);
            this.numNumberOfBits.TabIndex = 4;
            this.numNumberOfBits.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numNumberOfBits.ValueChanged += new System.EventHandler(this.numNumberOfBits_ValueChanged);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Enabled = false;
            this.btn_Stop.Location = new System.Drawing.Point(461, 232);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(75, 48);
            this.btn_Stop.TabIndex = 5;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 303);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.numNumberOfBits);
            this.Controls.Add(this.btn_Decroissant);
            this.Controls.Add(this.btn_Croissant);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.gbx_Bits);
            this.Name = "View";
            this.Text = "Apprends le binaire  !";
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfBits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_Bits;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Timer tmrAutoDec;
        private System.Windows.Forms.Button btn_Croissant;
        private System.Windows.Forms.Button btn_Decroissant;
        private System.Windows.Forms.NumericUpDown numNumberOfBits;
        private System.Windows.Forms.Button btn_Stop;
    }
}

