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
            this.enableMouseAuto = new System.Windows.Forms.Button();
            this.disableAuto = new System.Windows.Forms.Button();
            this.clickCombobox = new System.Windows.Forms.ComboBox();
            this.msLabel = new System.Windows.Forms.Label();
            this.clickCombo = new System.Windows.Forms.Label();
            this.hotkeyCombobox = new System.Windows.Forms.ComboBox();
            this.hotkeyLabel = new System.Windows.Forms.Label();
            this.mouseGBox = new System.Windows.Forms.GroupBox();
            this.mTextbox = new System.Windows.Forms.NumericUpDown();
            this.mLabel = new System.Windows.Forms.Label();
            this.sTextbox = new System.Windows.Forms.NumericUpDown();
            this.sLabel = new System.Windows.Forms.Label();
            this.msTextbox = new System.Windows.Forms.NumericUpDown();
            this.kybdGBox = new System.Windows.Forms.GroupBox();
            this.kybdHotkeys = new System.Windows.Forms.ComboBox();
            this.kybdHkLabel = new System.Windows.Forms.Label();
            this.kybdKeyLabel = new System.Windows.Forms.Label();
            this.insertKey = new System.Windows.Forms.Button();
            this.enableKybdAuto = new System.Windows.Forms.Button();
            this.singleClick = new System.Windows.Forms.RadioButton();
            this.doubleClick = new System.Windows.Forms.RadioButton();
            this.clickNb = new System.Windows.Forms.GroupBox();
            this.mouseGBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mTextbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTextbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msTextbox)).BeginInit();
            this.kybdGBox.SuspendLayout();
            this.clickNb.SuspendLayout();
            this.SuspendLayout();
            // 
            // enableMouseAuto
            // 
            this.enableMouseAuto.Location = new System.Drawing.Point(16, 404);
            this.enableMouseAuto.Name = "enableMouseAuto";
            this.enableMouseAuto.Size = new System.Drawing.Size(210, 34);
            this.enableMouseAuto.TabIndex = 0;
            this.enableMouseAuto.Text = "Enable Mouse (F6)";
            this.enableMouseAuto.UseVisualStyleBackColor = true;
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
            // mouseGBox
            // 
            this.mouseGBox.Controls.Add(this.mTextbox);
            this.mouseGBox.Controls.Add(this.mLabel);
            this.mouseGBox.Controls.Add(this.sTextbox);
            this.mouseGBox.Controls.Add(this.sLabel);
            this.mouseGBox.Controls.Add(this.msTextbox);
            this.mouseGBox.Controls.Add(this.hotkeyCombobox);
            this.mouseGBox.Controls.Add(this.clickCombobox);
            this.mouseGBox.Controls.Add(this.msLabel);
            this.mouseGBox.Controls.Add(this.hotkeyLabel);
            this.mouseGBox.Controls.Add(this.clickCombo);
            this.mouseGBox.Location = new System.Drawing.Point(246, 12);
            this.mouseGBox.Name = "mouseGBox";
            this.mouseGBox.Size = new System.Drawing.Size(200, 314);
            this.mouseGBox.TabIndex = 9;
            this.mouseGBox.TabStop = false;
            this.mouseGBox.Text = "groupBox1";
            // 
            // mTextbox
            // 
            this.mTextbox.Location = new System.Drawing.Point(6, 266);
            this.mTextbox.Name = "mTextbox";
            this.mTextbox.Size = new System.Drawing.Size(120, 20);
            this.mTextbox.TabIndex = 12;
            this.mTextbox.Validated += new System.EventHandler(this.mTextbox_Validated);
            // 
            // mLabel
            // 
            this.mLabel.AutoSize = true;
            this.mLabel.Location = new System.Drawing.Point(2, 250);
            this.mLabel.Name = "mLabel";
            this.mLabel.Size = new System.Drawing.Size(44, 13);
            this.mLabel.TabIndex = 11;
            this.mLabel.Text = "Minutes";
            // 
            // sTextbox
            // 
            this.sTextbox.Location = new System.Drawing.Point(7, 214);
            this.sTextbox.Name = "sTextbox";
            this.sTextbox.Size = new System.Drawing.Size(120, 20);
            this.sTextbox.TabIndex = 10;
            this.sTextbox.Validated += new System.EventHandler(this.sTextbox_Validated);
            // 
            // sLabel
            // 
            this.sLabel.AutoSize = true;
            this.sLabel.Location = new System.Drawing.Point(3, 198);
            this.sLabel.Name = "sLabel";
            this.sLabel.Size = new System.Drawing.Size(49, 13);
            this.sLabel.TabIndex = 9;
            this.sLabel.Text = "Seconds";
            // 
            // msTextbox
            // 
            this.msTextbox.Location = new System.Drawing.Point(7, 105);
            this.msTextbox.Name = "msTextbox";
            this.msTextbox.Size = new System.Drawing.Size(120, 20);
            this.msTextbox.TabIndex = 8;
            this.msTextbox.Validated += new System.EventHandler(this.msTextbox_ValueChanged);
            // 
            // kybdGBox
            // 
            this.kybdGBox.Controls.Add(this.kybdHotkeys);
            this.kybdGBox.Controls.Add(this.kybdHkLabel);
            this.kybdGBox.Controls.Add(this.kybdKeyLabel);
            this.kybdGBox.Controls.Add(this.insertKey);
            this.kybdGBox.Location = new System.Drawing.Point(30, 12);
            this.kybdGBox.Name = "kybdGBox";
            this.kybdGBox.Size = new System.Drawing.Size(200, 195);
            this.kybdGBox.TabIndex = 10;
            this.kybdGBox.TabStop = false;
            this.kybdGBox.Text = "groupBox2";
            // 
            // kybdHotkeys
            // 
            this.kybdHotkeys.FormattingEnabled = true;
            this.kybdHotkeys.Location = new System.Drawing.Point(7, 104);
            this.kybdHotkeys.Name = "kybdHotkeys";
            this.kybdHotkeys.Size = new System.Drawing.Size(121, 21);
            this.kybdHotkeys.TabIndex = 9;
            this.kybdHotkeys.SelectionChangeCommitted += new System.EventHandler(this.ChangedKybdCommited_Click);
            // 
            // kybdHkLabel
            // 
            this.kybdHkLabel.AutoSize = true;
            this.kybdHkLabel.Location = new System.Drawing.Point(4, 88);
            this.kybdHkLabel.Name = "kybdHkLabel";
            this.kybdHkLabel.Size = new System.Drawing.Size(41, 13);
            this.kybdHkLabel.TabIndex = 10;
            this.kybdHkLabel.Text = "Hotkey";
            // 
            // kybdKeyLabel
            // 
            this.kybdKeyLabel.AutoSize = true;
            this.kybdKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kybdKeyLabel.Location = new System.Drawing.Point(134, 48);
            this.kybdKeyLabel.Name = "kybdKeyLabel";
            this.kybdKeyLabel.Size = new System.Drawing.Size(46, 18);
            this.kybdKeyLabel.TabIndex = 1;
            this.kybdKeyLabel.Text = "label1";
            // 
            // insertKey
            // 
            this.insertKey.Location = new System.Drawing.Point(7, 45);
            this.insertKey.Name = "insertKey";
            this.insertKey.Size = new System.Drawing.Size(108, 23);
            this.insertKey.TabIndex = 0;
            this.insertKey.Text = "button1";
            this.insertKey.UseVisualStyleBackColor = true;
            // 
            // enableKybdAuto
            // 
            this.enableKybdAuto.Location = new System.Drawing.Point(16, 368);
            this.enableKybdAuto.Name = "enableKybdAuto";
            this.enableKybdAuto.Size = new System.Drawing.Size(210, 34);
            this.enableKybdAuto.TabIndex = 11;
            this.enableKybdAuto.Text = "Enable Keyboard (F7)";
            this.enableKybdAuto.UseVisualStyleBackColor = true;
            // 
            // singleClick
            // 
            this.singleClick.AutoSize = true;
            this.singleClick.Location = new System.Drawing.Point(7, 35);
            this.singleClick.Name = "singleClick";
            this.singleClick.Size = new System.Drawing.Size(85, 17);
            this.singleClick.TabIndex = 11;
            this.singleClick.TabStop = true;
            this.singleClick.Text = "radioButton1";
            this.singleClick.UseVisualStyleBackColor = true;
            this.singleClick.CheckedChanged += new System.EventHandler(this.singleClick_CheckedChanged);
            // 
            // doubleClick
            // 
            this.doubleClick.AutoSize = true;
            this.doubleClick.Location = new System.Drawing.Point(6, 68);
            this.doubleClick.Name = "doubleClick";
            this.doubleClick.Size = new System.Drawing.Size(85, 17);
            this.doubleClick.TabIndex = 12;
            this.doubleClick.TabStop = true;
            this.doubleClick.Text = "radioButton2";
            this.doubleClick.UseVisualStyleBackColor = true;
            // 
            // clickNb
            // 
            this.clickNb.Controls.Add(this.singleClick);
            this.clickNb.Controls.Add(this.doubleClick);
            this.clickNb.Location = new System.Drawing.Point(30, 213);
            this.clickNb.Name = "clickNb";
            this.clickNb.Size = new System.Drawing.Size(115, 100);
            this.clickNb.TabIndex = 13;
            this.clickNb.TabStop = false;
            this.clickNb.Text = "groupBox1";
            // 
            // Srak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 450);
            this.Controls.Add(this.clickNb);
            this.Controls.Add(this.enableKybdAuto);
            this.Controls.Add(this.kybdGBox);
            this.Controls.Add(this.mouseGBox);
            this.Controls.Add(this.disableAuto);
            this.Controls.Add(this.enableMouseAuto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Srak";
            this.Text = "root";
            this.Load += new System.EventHandler(this.Srak_Load);
            this.mouseGBox.ResumeLayout(false);
            this.mouseGBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mTextbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTextbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msTextbox)).EndInit();
            this.kybdGBox.ResumeLayout(false);
            this.kybdGBox.PerformLayout();
            this.clickNb.ResumeLayout(false);
            this.clickNb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button enableMouseAuto;
        private System.Windows.Forms.Button disableAuto;
        private System.Windows.Forms.ComboBox clickCombobox;
        private System.Windows.Forms.Label msLabel;
        private System.Windows.Forms.Label clickCombo;
        private System.Windows.Forms.ComboBox hotkeyCombobox;
        private System.Windows.Forms.Label hotkeyLabel;
        private System.Windows.Forms.GroupBox mouseGBox;
        private System.Windows.Forms.NumericUpDown msTextbox;
        private System.Windows.Forms.GroupBox kybdGBox;
        private System.Windows.Forms.Label kybdKeyLabel;
        private System.Windows.Forms.Button insertKey;
        private System.Windows.Forms.Button enableKybdAuto;
        private System.Windows.Forms.ComboBox kybdHotkeys;
        private System.Windows.Forms.Label kybdHkLabel;
        private System.Windows.Forms.RadioButton singleClick;
        private System.Windows.Forms.RadioButton doubleClick;
        private System.Windows.Forms.GroupBox clickNb;
        private System.Windows.Forms.NumericUpDown mTextbox;
        private System.Windows.Forms.Label mLabel;
        private System.Windows.Forms.NumericUpDown sTextbox;
        private System.Windows.Forms.Label sLabel;
    }
}

