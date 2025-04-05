namespace CaesarCipher
{
    partial class CaesarCipher
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.IblKey = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnCipher = new System.Windows.Forms.Button();
            this.btnClearControls = new System.Windows.Forms.Button();
            this.txtEncryptedText = new System.Windows.Forms.TextBox();
            this.IblOutputText = new System.Windows.Forms.Label();
            this.txtToEncrypt = new System.Windows.Forms.TextBox();
            this.IblInitialText = new System.Windows.Forms.Label();
            this.txtKeyToEncrypt = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnDecipher = new System.Windows.Forms.Button();
            this.btnCleaerControlsDecrypt = new System.Windows.Forms.Button();
            this.txtDecryptedText = new System.Windows.Forms.TextBox();
            this.materialLabel3 = new System.Windows.Forms.Label();
            this.txtTextToDecrypt = new System.Windows.Forms.TextBox();
            this.lblDecrypt = new System.Windows.Forms.Label();
            this.txtKeyToDecrypt = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // IblKey
            // 
            this.IblKey.AutoSize = true;
            this.IblKey.BackColor = System.Drawing.SystemColors.Window;
            this.IblKey.Font = new System.Drawing.Font("Rockwell", 11F);
            this.IblKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.IblKey.Location = new System.Drawing.Point(6, 20);
            this.IblKey.Name = "IblKey";
            this.IblKey.Size = new System.Drawing.Size(42, 17);
            this.IblKey.TabIndex = 0;
            this.IblKey.Text = "Key :";
            this.IblKey.Click += new System.EventHandler(this.IblKey_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.ItemSize = new System.Drawing.Size(48, 18);
            this.tabControl1.Location = new System.Drawing.Point(0, 67);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(429, 528);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnCipher);
            this.tabPage3.Controls.Add(this.btnClearControls);
            this.tabPage3.Controls.Add(this.txtEncryptedText);
            this.tabPage3.Controls.Add(this.IblOutputText);
            this.tabPage3.Controls.Add(this.txtToEncrypt);
            this.tabPage3.Controls.Add(this.IblInitialText);
            this.tabPage3.Controls.Add(this.txtKeyToEncrypt);
            this.tabPage3.Controls.Add(this.IblKey);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(421, 502);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Encrypt";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnCipher
            // 
            this.btnCipher.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCipher.Location = new System.Drawing.Point(211, 429);
            this.btnCipher.Name = "btnCipher";
            this.btnCipher.Size = new System.Drawing.Size(185, 71);
            this.btnCipher.TabIndex = 12;
            this.btnCipher.Text = "CIPHER";
            this.btnCipher.UseVisualStyleBackColor = true;
            this.btnCipher.Click += new System.EventHandler(this.btnCipher_Click);
            // 
            // btnClearControls
            // 
            this.btnClearControls.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClearControls.Location = new System.Drawing.Point(9, 428);
            this.btnClearControls.Name = "btnClearControls";
            this.btnClearControls.Size = new System.Drawing.Size(182, 71);
            this.btnClearControls.TabIndex = 4;
            this.btnClearControls.Text = "Clear Controls";
            this.btnClearControls.UseVisualStyleBackColor = true;
            this.btnClearControls.Click += new System.EventHandler(this.btnClearControls_Click);
            // 
            // txtEncryptedText
            // 
            this.txtEncryptedText.Location = new System.Drawing.Point(9, 259);
            this.txtEncryptedText.Multiline = true;
            this.txtEncryptedText.Name = "txtEncryptedText";
            this.txtEncryptedText.Size = new System.Drawing.Size(385, 164);
            this.txtEncryptedText.TabIndex = 3;
            // 
            // IblOutputText
            // 
            this.IblOutputText.AutoSize = true;
            this.IblOutputText.BackColor = System.Drawing.SystemColors.Window;
            this.IblOutputText.Font = new System.Drawing.Font("Rockwell", 11F);
            this.IblOutputText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.IblOutputText.Location = new System.Drawing.Point(11, 238);
            this.IblOutputText.Name = "IblOutputText";
            this.IblOutputText.Size = new System.Drawing.Size(123, 17);
            this.IblOutputText.TabIndex = 0;
            this.IblOutputText.Text = "Encrypted Text :";
            // 
            // txtToEncrypt
            // 
            this.txtToEncrypt.Location = new System.Drawing.Point(9, 77);
            this.txtToEncrypt.Multiline = true;
            this.txtToEncrypt.Name = "txtToEncrypt";
            this.txtToEncrypt.Size = new System.Drawing.Size(385, 154);
            this.txtToEncrypt.TabIndex = 3;
            // 
            // IblInitialText
            // 
            this.IblInitialText.AutoSize = true;
            this.IblInitialText.BackColor = System.Drawing.SystemColors.Window;
            this.IblInitialText.Font = new System.Drawing.Font("Rockwell", 11F);
            this.IblInitialText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.IblInitialText.Location = new System.Drawing.Point(8, 57);
            this.IblInitialText.Name = "IblInitialText";
            this.IblInitialText.Size = new System.Drawing.Size(123, 17);
            this.IblInitialText.TabIndex = 4;
            this.IblInitialText.Text = "Text to Encrypt :";
            // 
            // txtKeyToEncrypt
            // 
            this.txtKeyToEncrypt.Location = new System.Drawing.Point(54, 17);
            this.txtKeyToEncrypt.Name = "txtKeyToEncrypt";
            this.txtKeyToEncrypt.Size = new System.Drawing.Size(337, 20);
            this.txtKeyToEncrypt.TabIndex = 3;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnDecipher);
            this.tabPage4.Controls.Add(this.btnCleaerControlsDecrypt);
            this.tabPage4.Controls.Add(this.txtDecryptedText);
            this.tabPage4.Controls.Add(this.materialLabel3);
            this.tabPage4.Controls.Add(this.txtTextToDecrypt);
            this.tabPage4.Controls.Add(this.lblDecrypt);
            this.tabPage4.Controls.Add(this.txtKeyToDecrypt);
            this.tabPage4.Controls.Add(this.materialLabel1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(421, 502);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Decrypt";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnDecipher
            // 
            this.btnDecipher.Location = new System.Drawing.Point(212, 421);
            this.btnDecipher.Name = "btnDecipher";
            this.btnDecipher.Size = new System.Drawing.Size(185, 71);
            this.btnDecipher.TabIndex = 12;
            this.btnDecipher.Text = "DECIPHER";
            this.btnDecipher.UseVisualStyleBackColor = true;
            this.btnDecipher.Click += new System.EventHandler(this.btnDecipher_Click);
            // 
            // btnCleaerControlsDecrypt
            // 
            this.btnCleaerControlsDecrypt.Location = new System.Drawing.Point(3, 421);
            this.btnCleaerControlsDecrypt.Name = "btnCleaerControlsDecrypt";
            this.btnCleaerControlsDecrypt.Size = new System.Drawing.Size(182, 71);
            this.btnCleaerControlsDecrypt.TabIndex = 11;
            this.btnCleaerControlsDecrypt.Text = "CLEAR CONTROLS";
            this.btnCleaerControlsDecrypt.UseVisualStyleBackColor = true;
            this.btnCleaerControlsDecrypt.Click += new System.EventHandler(this.btnCleaerControlsDecrypt_Click);
            // 
            // txtDecryptedText
            // 
            this.txtDecryptedText.Location = new System.Drawing.Point(8, 238);
            this.txtDecryptedText.Multiline = true;
            this.txtDecryptedText.Name = "txtDecryptedText";
            this.txtDecryptedText.Size = new System.Drawing.Size(389, 154);
            this.txtDecryptedText.TabIndex = 9;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel3.Font = new System.Drawing.Font("Rockwell", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(4, 216);
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(125, 17);
            this.materialLabel3.TabIndex = 7;
            this.materialLabel3.Text = "Decrypted Text :";
            // 
            // txtTextToDecrypt
            // 
            this.txtTextToDecrypt.Location = new System.Drawing.Point(8, 59);
            this.txtTextToDecrypt.Multiline = true;
            this.txtTextToDecrypt.Name = "txtTextToDecrypt";
            this.txtTextToDecrypt.Size = new System.Drawing.Size(389, 154);
            this.txtTextToDecrypt.TabIndex = 10;
            // 
            // lblDecrypt
            // 
            this.lblDecrypt.AutoSize = true;
            this.lblDecrypt.BackColor = System.Drawing.SystemColors.Window;
            this.lblDecrypt.Font = new System.Drawing.Font("Rockwell", 11F);
            this.lblDecrypt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDecrypt.Location = new System.Drawing.Point(8, 37);
            this.lblDecrypt.Name = "lblDecrypt";
            this.lblDecrypt.Size = new System.Drawing.Size(129, 17);
            this.lblDecrypt.TabIndex = 6;
            this.lblDecrypt.Text = "Text to  Decrypt :";
            // 
            // txtKeyToDecrypt
            // 
            this.txtKeyToDecrypt.Location = new System.Drawing.Point(60, 6);
            this.txtKeyToDecrypt.Name = "txtKeyToDecrypt";
            this.txtKeyToDecrypt.Size = new System.Drawing.Size(337, 20);
            this.txtKeyToDecrypt.TabIndex = 8;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel1.Font = new System.Drawing.Font("Rockwell", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(8, 7);
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(42, 17);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Key :";
            // 
            // CaesarCipher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(429, 595);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "CaesarCipher";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Caesar Cipher";
            this.Load += new System.EventHandler(this.CaesarCipher_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label IblKey;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtKeyToEncrypt;
        private System.Windows.Forms.Label IblInitialText;
        private System.Windows.Forms.TextBox txtToEncrypt;
        private System.Windows.Forms.Label IblOutputText;
        private System.Windows.Forms.Button btnClearControls;
        private System.Windows.Forms.TextBox txtEncryptedText;
        private System.Windows.Forms.Button btnCipher;
        private System.Windows.Forms.Label materialLabel1;
        private System.Windows.Forms.Label lblDecrypt;
        private System.Windows.Forms.TextBox txtKeyToDecrypt;
        private System.Windows.Forms.Label materialLabel3;
        private System.Windows.Forms.TextBox txtTextToDecrypt;
        private System.Windows.Forms.Button btnCleaerControlsDecrypt;
        private System.Windows.Forms.TextBox txtDecryptedText;
        private System.Windows.Forms.Button btnDecipher;
    }
}

