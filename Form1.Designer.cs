namespace Srak
{
    partial class Srak
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
            this.enableAuto = new System.Windows.Forms.Button();
            this.disableAuto = new System.Windows.Forms.Button();
            this.clickCombobox = new System.Windows.Forms.ComboBox();
            this.msLabel = new System.Windows.Forms.Label();
            this.clickCombo = new System.Windows.Forms.Label();
            this.hotkeyCombobox = new System.Windows.Forms.ComboBox();
            this.hotkeyLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.msTextbox = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msTextbox)).BeginInit();
            this.SuspendLayout();
            // 
            // enableAuto
            // 
            this.enableAuto.Location = new System.Drawing.Point(16, 368);
            this.enableAuto.Name = "enableAuto";
            this.enableAuto.Size = new System.Drawing.Size(210, 70);
            this.enableAuto.TabIndex = 0;
            this.enableAuto.Text = "Enable Autoclick (F6)";
            this.enableAuto.UseVisualStyleBackColor = true;
            // 
            // disableAuto
            // 
            this.disableAuto.Enabled = false;
            this.disableAuto.Location = new System.Drawing.Point(232, 368);
            this.disableAuto.Name = "disableAuto";
            this.disableAuto.Size = new System.Drawing.Size(210, 70);
            this.disableAuto.TabIndex = 1;
            this.disableAuto.Text = "Disable Autoclick (F6)";
            this.disableAuto.UseVisualStyleBackColor = true;
            // 
            // clickCombobox
            // 
            this.clickCombobox.FormattingEnabled = true;
            this.clickCombobox.Location = new System.Drawing.Point(6, 158);
            this.clickCombobox.Name = "clickCombobox";
            this.clickCombobox.Size = new System.Drawing.Size(121, 21);
            this.clickCombobox.TabIndex = 2;
            this.clickCombobox.SelectionChangeCommitted += new System.EventHandler(this.mouseBtn_ChangeCommited);
            // 
            // msLabel
            // 
            this.msLabel.AutoSize = true;
            this.msLabel.Location = new System.Drawing.Point(3, 89);
            this.msLabel.Name = "msLabel";
            this.msLabel.Size = new System.Drawing.Size(62, 13);
            this.msLabel.TabIndex = 4;
            this.msLabel.Text = "Miliseconds";
            // 
            // clickCombo
            // 
            this.clickCombo.AutoSize = true;
            this.clickCombo.Location = new System.Drawing.Point(3, 142);
            this.clickCombo.Name = "clickCombo";
            this.clickCombo.Size = new System.Drawing.Size(30, 13);
            this.clickCombo.TabIndex = 5;
            this.clickCombo.Text = "Click";
            // 
            // hotkeyCombobox
            // 
            this.hotkeyCombobox.FormattingEnabled = true;
            this.hotkeyCombobox.Location = new System.Drawing.Point(6, 45);
            this.hotkeyCombobox.Name = "hotkeyCombobox";
            this.hotkeyCombobox.Size = new System.Drawing.Size(121, 21);
            this.hotkeyCombobox.TabIndex = 6;
            this.hotkeyCombobox.SelectionChangeCommitted += new System.EventHandler(this.ChangedCommitted_Click);
            // 
            // hotkeyLabel
            // 
            this.hotkeyLabel.AutoSize = true;
            this.hotkeyLabel.Location = new System.Drawing.Point(3, 29);
            this.hotkeyLabel.Name = "hotkeyLabel";
            this.hotkeyLabel.Size = new System.Drawing.Size(41, 13);
            this.hotkeyLabel.TabIndex = 7;
            this.hotkeyLabel.Text = "Hotkey";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.msTextbox);
            this.groupBox1.Controls.Add(this.hotkeyCombobox);
            this.groupBox1.Controls.Add(this.clickCombobox);
            this.groupBox1.Controls.Add(this.msLabel);
            this.groupBox1.Controls.Add(this.hotkeyLabel);
            this.groupBox1.Controls.Add(this.clickCombo);
            this.groupBox1.Location = new System.Drawing.Point(246, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 195);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // msTextbox
            // 
            this.msTextbox.Location = new System.Drawing.Point(7, 105);
            this.msTextbox.Name = "msTextbox";
            this.msTextbox.Size = new System.Drawing.Size(120, 20);
            this.msTextbox.TabIndex = 8;
            // 
            // Srak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.disableAuto);
            this.Controls.Add(this.enableAuto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Srak";
            this.Text = "root";
            this.Load += new System.EventHandler(this.Srak_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msTextbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button enableAuto;
        private System.Windows.Forms.Button disableAuto;
        private System.Windows.Forms.ComboBox clickCombobox;
        private System.Windows.Forms.Label msLabel;
        private System.Windows.Forms.Label clickCombo;
        private System.Windows.Forms.ComboBox hotkeyCombobox;
        private System.Windows.Forms.Label hotkeyLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown msTextbox;
    }
}

