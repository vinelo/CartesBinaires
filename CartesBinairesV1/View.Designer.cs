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
            this.gbx_Calcul = new System.Windows.Forms.GroupBox();
            this.gbx_Nombre = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Indication = new System.Windows.Forms.Label();
            this.mspMenu = new System.Windows.Forms.MenuStrip();
            this.tsmFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiLeave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTools = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiChronologic = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiChronologicInverse = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiManual = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsiShowCard = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHideCarde = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsiNumberOfCard = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiOne = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiTwo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiThree = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiFour = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiFive = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiSix = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiEight = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.àProposDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.mspMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_Bits
            // 
            this.gbx_Bits.Location = new System.Drawing.Point(12, 116);
            this.gbx_Bits.Name = "gbx_Bits";
            this.gbx_Bits.Size = new System.Drawing.Size(751, 237);
            this.gbx_Bits.TabIndex = 0;
            this.gbx_Bits.TabStop = false;
            this.gbx_Bits.Text = "Cartes Binaire";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(346, 16);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(62, 31);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "____";
            // 
            // tmrAutoDec
            // 
            this.tmrAutoDec.Tick += new System.EventHandler(this.tmrAutoDec_Tick);
            // 
            // gbx_Calcul
            // 
            this.gbx_Calcul.Location = new System.Drawing.Point(12, 359);
            this.gbx_Calcul.Name = "gbx_Calcul";
            this.gbx_Calcul.Size = new System.Drawing.Size(751, 76);
            this.gbx_Calcul.TabIndex = 6;
            this.gbx_Calcul.TabStop = false;
            this.gbx_Calcul.Text = "Calcul de la valeur décimale équivalente";
            // 
            // gbx_Nombre
            // 
            this.gbx_Nombre.Location = new System.Drawing.Point(12, 27);
            this.gbx_Nombre.Name = "gbx_Nombre";
            this.gbx_Nombre.Size = new System.Drawing.Size(751, 60);
            this.gbx_Nombre.TabIndex = 7;
            this.gbx_Nombre.TabStop = false;
            this.gbx_Nombre.Text = "Nombre binaire correspondant";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblResult);
            this.groupBox1.Location = new System.Drawing.Point(12, 441);
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
            // mspMenu
            // 
            this.mspMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFolder,
            this.tsmTools,
            this.aideToolStripMenuItem});
            this.mspMenu.Location = new System.Drawing.Point(0, 0);
            this.mspMenu.Name = "mspMenu";
            this.mspMenu.Size = new System.Drawing.Size(772, 24);
            this.mspMenu.TabIndex = 10;
            // 
            // tsmFolder
            // 
            this.tsmFolder.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiLeave});
            this.tsmFolder.Name = "tsmFolder";
            this.tsmFolder.Size = new System.Drawing.Size(54, 20);
            this.tsmFolder.Text = "Fichier";
            // 
            // tsiLeave
            // 
            this.tsiLeave.Name = "tsiLeave";
            this.tsiLeave.Size = new System.Drawing.Size(111, 22);
            this.tsiLeave.Text = "Quitter";
            this.tsiLeave.Click += new System.EventHandler(this.tsiLeave_Click);
            // 
            // tsmTools
            // 
            this.tsmTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiChronologic,
            this.tsiChronologicInverse,
            this.tsiManual,
            this.toolStripSeparator2,
            this.tsiShowCard,
            this.tsmHideCarde,
            this.toolStripSeparator1,
            this.tsiNumberOfCard});
            this.tsmTools.Name = "tsmTools";
            this.tsmTools.Size = new System.Drawing.Size(50, 20);
            this.tsmTools.Text = "Outils";
            // 
            // tsiChronologic
            // 
            this.tsiChronologic.Name = "tsiChronologic";
            this.tsiChronologic.Size = new System.Drawing.Size(311, 22);
            this.tsiChronologic.Text = "Mode chronologique ( automatique )";
            this.tsiChronologic.Click += new System.EventHandler(this.tsiChronologic_Click);
            // 
            // tsiChronologicInverse
            // 
            this.tsiChronologicInverse.Name = "tsiChronologicInverse";
            this.tsiChronologicInverse.Size = new System.Drawing.Size(311, 22);
            this.tsiChronologicInverse.Text = "Mode chronologique inversé ( automatique )";
            this.tsiChronologicInverse.Click += new System.EventHandler(this.tsiChronologicInverse_Click);
            // 
            // tsiManual
            // 
            this.tsiManual.Checked = true;
            this.tsiManual.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsiManual.Name = "tsiManual";
            this.tsiManual.Size = new System.Drawing.Size(311, 22);
            this.tsiManual.Text = "Mode manuel";
            this.tsiManual.Click += new System.EventHandler(this.tsiManual_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(308, 6);
            // 
            // tsiShowCard
            // 
            this.tsiShowCard.Name = "tsiShowCard";
            this.tsiShowCard.Size = new System.Drawing.Size(311, 22);
            this.tsiShowCard.Text = "Retourner toutes les cartes";
            this.tsiShowCard.Click += new System.EventHandler(this.tsiShowCard_Click);
            // 
            // tsmHideCarde
            // 
            this.tsmHideCarde.Name = "tsmHideCarde";
            this.tsmHideCarde.Size = new System.Drawing.Size(311, 22);
            this.tsmHideCarde.Text = "Cacher toutes les cartes";
            this.tsmHideCarde.Click += new System.EventHandler(this.tsmHideCarde_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(308, 6);
            // 
            // tsiNumberOfCard
            // 
            this.tsiNumberOfCard.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiOne,
            this.tsiTwo,
            this.tsiThree,
            this.tsiFour,
            this.tsiFive,
            this.tsiSix,
            this.tsiEight});
            this.tsiNumberOfCard.Name = "tsiNumberOfCard";
            this.tsiNumberOfCard.Size = new System.Drawing.Size(311, 22);
            this.tsiNumberOfCard.Text = "Nombre de cartes";
            // 
            // tsiOne
            // 
            this.tsiOne.Name = "tsiOne";
            this.tsiOne.Size = new System.Drawing.Size(80, 22);
            this.tsiOne.Text = "1";
            this.tsiOne.Click += new System.EventHandler(this.tsiOne_Click);
            // 
            // tsiTwo
            // 
            this.tsiTwo.Name = "tsiTwo";
            this.tsiTwo.Size = new System.Drawing.Size(80, 22);
            this.tsiTwo.Text = "2";
            this.tsiTwo.Click += new System.EventHandler(this.tsiTwo_Click);
            // 
            // tsiThree
            // 
            this.tsiThree.Name = "tsiThree";
            this.tsiThree.Size = new System.Drawing.Size(80, 22);
            this.tsiThree.Text = "3";
            this.tsiThree.Click += new System.EventHandler(this.tsiThree_Click);
            // 
            // tsiFour
            // 
            this.tsiFour.Name = "tsiFour";
            this.tsiFour.Size = new System.Drawing.Size(80, 22);
            this.tsiFour.Text = "4";
            this.tsiFour.Click += new System.EventHandler(this.tsiFour_Click);
            // 
            // tsiFive
            // 
            this.tsiFive.Name = "tsiFive";
            this.tsiFive.Size = new System.Drawing.Size(80, 22);
            this.tsiFive.Text = "5";
            this.tsiFive.Click += new System.EventHandler(this.tsiFive_Click);
            // 
            // tsiSix
            // 
            this.tsiSix.Name = "tsiSix";
            this.tsiSix.Size = new System.Drawing.Size(80, 22);
            this.tsiSix.Text = "6";
            this.tsiSix.Click += new System.EventHandler(this.tsiSix_Click);
            // 
            // tsiEight
            // 
            this.tsiEight.Name = "tsiEight";
            this.tsiEight.Size = new System.Drawing.Size(80, 22);
            this.tsiEight.Text = "8";
            this.tsiEight.Click += new System.EventHandler(this.tsiEight_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.àProposDeToolStripMenuItem});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // àProposDeToolStripMenuItem
            // 
            this.àProposDeToolStripMenuItem.Name = "àProposDeToolStripMenuItem";
            this.àProposDeToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.àProposDeToolStripMenuItem.Text = "À propos de...";
            this.àProposDeToolStripMenuItem.Click += new System.EventHandler(this.àProposDeToolStripMenuItem_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 509);
            this.Controls.Add(this.mspMenu);
            this.Controls.Add(this.lbl_Indication);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbx_Nombre);
            this.Controls.Add(this.gbx_Calcul);
            this.Controls.Add(this.gbx_Bits);
            this.Name = "View";
            this.Text = "Apprends le binaire  !";
            this.Load += new System.EventHandler(this.View_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.mspMenu.ResumeLayout(false);
            this.mspMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_Bits;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Timer tmrAutoDec;
        private System.Windows.Forms.GroupBox gbx_Calcul;
        private System.Windows.Forms.GroupBox gbx_Nombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_Indication;
        private System.Windows.Forms.MenuStrip mspMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmFolder;
        private System.Windows.Forms.ToolStripMenuItem tsiLeave;
        private System.Windows.Forms.ToolStripMenuItem tsmTools;
        private System.Windows.Forms.ToolStripMenuItem tsiChronologic;
        private System.Windows.Forms.ToolStripMenuItem tsiChronologicInverse;
        private System.Windows.Forms.ToolStripMenuItem tsiManual;
        private System.Windows.Forms.ToolStripMenuItem tsiShowCard;
        private System.Windows.Forms.ToolStripMenuItem tsmHideCarde;
        private System.Windows.Forms.ToolStripMenuItem tsiNumberOfCard;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsiOne;
        private System.Windows.Forms.ToolStripMenuItem tsiTwo;
        private System.Windows.Forms.ToolStripMenuItem tsiThree;
        private System.Windows.Forms.ToolStripMenuItem tsiFour;
        private System.Windows.Forms.ToolStripMenuItem tsiFive;
        private System.Windows.Forms.ToolStripMenuItem tsiSix;
        private System.Windows.Forms.ToolStripMenuItem tsiEight;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem àProposDeToolStripMenuItem;
    }
}

