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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtKeyToEncrypt = new System.Windows.Forms.TextBox();
            this.IblInitialText = new System.Windows.Forms.Label();
            this.txtToEncrypt = new System.Windows.Forms.TextBox();
            this.IblOutputText = new System.Windows.Forms.Label();
            this.txtEncryptedText = new System.Windows.Forms.TextBox();
            this.btnClearControls = new System.Windows.Forms.Button();
            this.btnCipher = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.IblKey.Size = new System.Drawing.Size(46, 17);
            this.IblKey.TabIndex = 0;
            this.IblKey.Text = " Ключ :";
            this.IblKey.Click += new System.EventHandler(this.IblKey_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.ItemSize = new System.Drawing.Size(48, 18);
            this.tabControl1.Location = new System.Drawing.Point(0, 67);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(429, 528);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCipher);
            this.tabPage1.Controls.Add(this.btnClearControls);
            this.tabPage1.Controls.Add(this.txtEncryptedText);
            this.tabPage1.Controls.Add(this.IblOutputText);
            this.tabPage1.Controls.Add(this.txtToEncrypt);
            this.tabPage1.Controls.Add(this.IblInitialText);
            this.tabPage1.Controls.Add(this.txtKeyToEncrypt);
            this.tabPage1.Controls.Add(this.IblKey);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(421, 502);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(421, 502);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtKeyToEncrypt
            // 
            this.txtKeyToEncrypt.Location = new System.Drawing.Point(54, 17);
            this.txtKeyToEncrypt.Name = "txtKeyToEncrypt";
            this.txtKeyToEncrypt.Size = new System.Drawing.Size(337, 20);
            this.txtKeyToEncrypt.TabIndex = 3;
            // 
            // IblInitialText
            // 
            this.IblInitialText.AutoSize = true;
            this.IblInitialText.BackColor = System.Drawing.SystemColors.Window;
            this.IblInitialText.Font = new System.Drawing.Font("Rockwell", 11F);
            this.IblInitialText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.IblInitialText.Location = new System.Drawing.Point(8, 57);
            this.IblInitialText.Name = "IblInitialText";
            this.IblInitialText.Size = new System.Drawing.Size(136, 17);
            this.IblInitialText.TabIndex = 4;
            this.IblInitialText.Text = "Текст для зашифровки :";
            // 
            // txtToEncrypt
            // 
            this.txtToEncrypt.Location = new System.Drawing.Point(9, 77);
            this.txtToEncrypt.Multiline = true;
            this.txtToEncrypt.Name = "txtToEncrypt";
            this.txtToEncrypt.Size = new System.Drawing.Size(385, 154);
            this.txtToEncrypt.TabIndex = 3;
            // 
            // IblOutputText
            // 
            this.IblOutputText.AutoSize = true;
            this.IblOutputText.BackColor = System.Drawing.SystemColors.Window;
            this.IblOutputText.Font = new System.Drawing.Font("Rockwell", 11F);
            this.IblOutputText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.IblOutputText.Location = new System.Drawing.Point(11, 238);
            this.IblOutputText.Name = "IblOutputText";
            this.IblOutputText.Size = new System.Drawing.Size(125, 17);
            this.IblOutputText.TabIndex = 0;
            this.IblOutputText.Text = "Зашифрованный текст";
            // 
            // txtEncryptedText
            // 
            this.txtEncryptedText.Location = new System.Drawing.Point(9, 259);
            this.txtEncryptedText.Multiline = true;
            this.txtEncryptedText.Name = "txtEncryptedText";
            this.txtEncryptedText.Size = new System.Drawing.Size(385, 164);
            this.txtEncryptedText.TabIndex = 3;
            // 
            // btnClearControls
            // 
            this.btnClearControls.Location = new System.Drawing.Point(9, 428);
            this.btnClearControls.Name = "btnClearControls";
            this.btnClearControls.Size = new System.Drawing.Size(182, 71);
            this.btnClearControls.TabIndex = 4;
            this.btnClearControls.Text = "очистить";
            this.btnClearControls.UseVisualStyleBackColor = true;
            // 
            // btnCipher
            // 
            this.btnCipher.Location = new System.Drawing.Point(211, 429);
            this.btnCipher.Name = "btnCipher";
            this.btnCipher.Size = new System.Drawing.Size(185, 71);
            this.btnCipher.TabIndex = 4;
            this.btnCipher.Text = "Зашифровать";
            this.btnCipher.UseVisualStyleBackColor = true;
            // 
            // CaesarCipher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(429, 595);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "CaesarCipher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Caesar Cipher";
            this.Load += new System.EventHandler(this.CaesarCipher_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label IblKey;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtKeyToEncrypt;
        private System.Windows.Forms.Label IblInitialText;
        private System.Windows.Forms.TextBox txtToEncrypt;
        private System.Windows.Forms.Label IblOutputText;
        private System.Windows.Forms.Button btnClearControls;
        private System.Windows.Forms.TextBox txtEncryptedText;
        private System.Windows.Forms.Button btnCipher;
    }
}

