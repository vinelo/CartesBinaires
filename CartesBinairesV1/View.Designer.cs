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
            this.gbx_Calcul = new System.Windows.Forms.GroupBox();
            this.gbx_Nombre = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Indication = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfBits)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_Bits
            // 
            this.gbx_Bits.Location = new System.Drawing.Point(12, 116);
            this.gbx_Bits.Name = "gbx_Bits";
            this.gbx_Bits.Size = new System.Drawing.Size(751, 175);
            this.gbx_Bits.TabIndex = 0;
            this.gbx_Bits.TabStop = false;
            this.gbx_Bits.Text = "Cartes Binaire";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(384, 25);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(31, 13);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "____";
            // 
            // tmrAutoDec
            // 
            this.tmrAutoDec.Tick += new System.EventHandler(this.tmrAutoDec_Tick);
            // 
            // btn_Croissant
            // 
            this.btn_Croissant.Location = new System.Drawing.Point(302, 440);
            this.btn_Croissant.Name = "btn_Croissant";
            this.btn_Croissant.Size = new System.Drawing.Size(75, 48);
            this.btn_Croissant.TabIndex = 2;
            this.btn_Croissant.Text = " Mode automatique croissant";
            this.btn_Croissant.UseVisualStyleBackColor = true;
            this.btn_Croissant.Click += new System.EventHandler(this.btn_Croissant_Click);
            // 
            // btn_Decroissant
            // 
            this.btn_Decroissant.Location = new System.Drawing.Point(383, 440);
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
            this.btn_Stop.Location = new System.Drawing.Point(465, 440);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(75, 48);
            this.btn_Stop.TabIndex = 5;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // gbx_Calcul
            // 
            this.gbx_Calcul.Location = new System.Drawing.Point(12, 297);
            this.gbx_Calcul.Name = "gbx_Calcul";
            this.gbx_Calcul.Size = new System.Drawing.Size(751, 76);
            this.gbx_Calcul.TabIndex = 6;
            this.gbx_Calcul.TabStop = false;
            this.gbx_Calcul.Text = "Calcul de la valeur décimale équivalente";
            // 
            // gbx_Nombre
            // 
            this.gbx_Nombre.Location = new System.Drawing.Point(12, 11);
            this.gbx_Nombre.Name = "gbx_Nombre";
            this.gbx_Nombre.Size = new System.Drawing.Size(751, 76);
            this.gbx_Nombre.TabIndex = 7;
            this.gbx_Nombre.TabStop = false;
            this.gbx_Nombre.Text = "Nombre binaire correspondant";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblResult);
            this.groupBox1.Location = new System.Drawing.Point(12, 379);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 55);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Résultat du calcul";
            // 
            // lbl_Indication
            // 
            this.lbl_Indication.AutoSize = true;
            this.lbl_Indication.Location = new System.Drawing.Point(269, 97);
            this.lbl_Indication.Name = "lbl_Indication";
            this.lbl_Indication.Size = new System.Drawing.Size(277, 13);
            this.lbl_Indication.TabIndex = 8;
            this.lbl_Indication.Text = "Cliquez sur les cartes binaires pour constituer un nombre !";
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 496);
            this.Controls.Add(this.lbl_Indication);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbx_Nombre);
            this.Controls.Add(this.gbx_Calcul);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.numNumberOfBits);
            this.Controls.Add(this.btn_Decroissant);
            this.Controls.Add(this.btn_Croissant);
            this.Controls.Add(this.gbx_Bits);
            this.Name = "View";
            this.Text = "Apprends le binaire  !";
            ((System.ComponentModel.ISupportInitialize)(this.numNumberOfBits)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbx_Calcul;
        private System.Windows.Forms.GroupBox gbx_Nombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_Indication;
    }
}

