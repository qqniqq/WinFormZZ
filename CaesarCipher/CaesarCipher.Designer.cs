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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaesarCipher));
            this.IblKey = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblAlphabet = new System.Windows.Forms.Label();
            this.cmbKeyEncrypt = new System.Windows.Forms.ComboBox();
            this.cmbAlphabet = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.btnCipher = new System.Windows.Forms.Button();
            this.btnClearControls = new System.Windows.Forms.Button();
            this.txtEncryptedText = new System.Windows.Forms.TextBox();
            this.IblOutputText = new System.Windows.Forms.Label();
            this.txtToEncrypt = new System.Windows.Forms.TextBox();
            this.IblInitialText = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKeyDecrypt = new System.Windows.Forms.ComboBox();
            this.cmbAlphabetDecrypt = new System.Windows.Forms.ComboBox();
            this.btnUsePrevious = new System.Windows.Forms.Button();
            this.buttonLoadForDecryption = new System.Windows.Forms.Button();
            this.btnDecipher = new System.Windows.Forms.Button();
            this.btnCleaerControlsDecrypt = new System.Windows.Forms.Button();
            this.txtDecryptedText = new System.Windows.Forms.TextBox();
            this.materialLabel3 = new System.Windows.Forms.Label();
            this.txtTextToDecrypt = new System.Windows.Forms.TextBox();
            this.lblDecrypt = new System.Windows.Forms.Label();
            this.materialLabel1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // IblKey
            // 
            resources.ApplyResources(this.IblKey, "IblKey");
            this.IblKey.BackColor = System.Drawing.Color.Honeydew;
            this.IblKey.ForeColor = System.Drawing.Color.Black;
            this.IblKey.Name = "IblKey";
            this.IblKey.Click += new System.EventHandler(this.IblKey_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Honeydew;
            this.tabPage3.Controls.Add(this.lblAlphabet);
            this.tabPage3.Controls.Add(this.cmbKeyEncrypt);
            this.tabPage3.Controls.Add(this.cmbAlphabet);
            this.tabPage3.Controls.Add(this.buttonSave);
            this.tabPage3.Controls.Add(this.btnCipher);
            this.tabPage3.Controls.Add(this.btnClearControls);
            this.tabPage3.Controls.Add(this.txtEncryptedText);
            this.tabPage3.Controls.Add(this.IblOutputText);
            this.tabPage3.Controls.Add(this.txtToEncrypt);
            this.tabPage3.Controls.Add(this.IblInitialText);
            this.tabPage3.Controls.Add(this.IblKey);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.ForeColor = System.Drawing.Color.DarkGreen;
            this.tabPage3.Name = "tabPage3";
            // 
            // lblAlphabet
            // 
            resources.ApplyResources(this.lblAlphabet, "lblAlphabet");
            this.lblAlphabet.BackColor = System.Drawing.Color.Honeydew;
            this.lblAlphabet.ForeColor = System.Drawing.Color.Black;
            this.lblAlphabet.Name = "lblAlphabet";
            // 
            // cmbKeyEncrypt
            // 
            this.cmbKeyEncrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.cmbKeyEncrypt, "cmbKeyEncrypt");
            this.cmbKeyEncrypt.ForeColor = System.Drawing.Color.Black;
            this.cmbKeyEncrypt.FormattingEnabled = true;
            this.cmbKeyEncrypt.Items.AddRange(new object[] {
            resources.GetString("cmbKeyEncrypt.Items"),
            resources.GetString("cmbKeyEncrypt.Items1"),
            resources.GetString("cmbKeyEncrypt.Items2"),
            resources.GetString("cmbKeyEncrypt.Items3"),
            resources.GetString("cmbKeyEncrypt.Items4"),
            resources.GetString("cmbKeyEncrypt.Items5"),
            resources.GetString("cmbKeyEncrypt.Items6"),
            resources.GetString("cmbKeyEncrypt.Items7"),
            resources.GetString("cmbKeyEncrypt.Items8"),
            resources.GetString("cmbKeyEncrypt.Items9"),
            resources.GetString("cmbKeyEncrypt.Items10"),
            resources.GetString("cmbKeyEncrypt.Items11"),
            resources.GetString("cmbKeyEncrypt.Items12"),
            resources.GetString("cmbKeyEncrypt.Items13"),
            resources.GetString("cmbKeyEncrypt.Items14"),
            resources.GetString("cmbKeyEncrypt.Items15"),
            resources.GetString("cmbKeyEncrypt.Items16"),
            resources.GetString("cmbKeyEncrypt.Items17"),
            resources.GetString("cmbKeyEncrypt.Items18"),
            resources.GetString("cmbKeyEncrypt.Items19"),
            resources.GetString("cmbKeyEncrypt.Items20"),
            resources.GetString("cmbKeyEncrypt.Items21"),
            resources.GetString("cmbKeyEncrypt.Items22"),
            resources.GetString("cmbKeyEncrypt.Items23"),
            resources.GetString("cmbKeyEncrypt.Items24"),
            resources.GetString("cmbKeyEncrypt.Items25"),
            resources.GetString("cmbKeyEncrypt.Items26"),
            resources.GetString("cmbKeyEncrypt.Items27"),
            resources.GetString("cmbKeyEncrypt.Items28"),
            resources.GetString("cmbKeyEncrypt.Items29"),
            resources.GetString("cmbKeyEncrypt.Items30"),
            resources.GetString("cmbKeyEncrypt.Items31"),
            resources.GetString("cmbKeyEncrypt.Items32")});
            this.cmbKeyEncrypt.Name = "cmbKeyEncrypt";
            this.cmbKeyEncrypt.SelectedIndexChanged += new System.EventHandler(this.cmbKeyEncrypt_SelectedIndexChanged);
            // 
            // cmbAlphabet
            // 
            resources.ApplyResources(this.cmbAlphabet, "cmbAlphabet");
            this.cmbAlphabet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbAlphabet.FormattingEnabled = true;
            this.cmbAlphabet.Items.AddRange(new object[] {
            resources.GetString("cmbAlphabet.Items"),
            resources.GetString("cmbAlphabet.Items1"),
            resources.GetString("cmbAlphabet.Items2")});
            this.cmbAlphabet.Name = "cmbAlphabet";
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.buttonSave, "buttonSave");
            this.buttonSave.ForeColor = System.Drawing.Color.Black;
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // btnCipher
            // 
            this.btnCipher.BackColor = System.Drawing.Color.LightGreen;
            this.btnCipher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCipher.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnCipher, "btnCipher");
            this.btnCipher.ForeColor = System.Drawing.Color.Black;
            this.btnCipher.Name = "btnCipher";
            this.btnCipher.UseVisualStyleBackColor = false;
            this.btnCipher.Click += new System.EventHandler(this.btnCipher_Click);
            // 
            // btnClearControls
            // 
            this.btnClearControls.BackColor = System.Drawing.Color.LightGreen;
            this.btnClearControls.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearControls.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnClearControls, "btnClearControls");
            this.btnClearControls.ForeColor = System.Drawing.Color.Black;
            this.btnClearControls.Name = "btnClearControls";
            this.btnClearControls.UseVisualStyleBackColor = false;
            this.btnClearControls.Click += new System.EventHandler(this.btnClearControls_Click);
            // 
            // txtEncryptedText
            // 
            this.txtEncryptedText.BackColor = System.Drawing.Color.MintCream;
            resources.ApplyResources(this.txtEncryptedText, "txtEncryptedText");
            this.txtEncryptedText.ForeColor = System.Drawing.Color.Black;
            this.txtEncryptedText.Name = "txtEncryptedText";
            this.txtEncryptedText.ReadOnly = true;
            // 
            // IblOutputText
            // 
            resources.ApplyResources(this.IblOutputText, "IblOutputText");
            this.IblOutputText.BackColor = System.Drawing.Color.Honeydew;
            this.IblOutputText.ForeColor = System.Drawing.Color.Black;
            this.IblOutputText.Name = "IblOutputText";
            // 
            // txtToEncrypt
            // 
            resources.ApplyResources(this.txtToEncrypt, "txtToEncrypt");
            this.txtToEncrypt.ForeColor = System.Drawing.Color.Black;
            this.txtToEncrypt.Name = "txtToEncrypt";
            this.txtToEncrypt.TextChanged += new System.EventHandler(this.txtToEncrypt_TextChanged);
            this.txtToEncrypt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtToEncrypt_KeyDown);
            // 
            // IblInitialText
            // 
            resources.ApplyResources(this.IblInitialText, "IblInitialText");
            this.IblInitialText.BackColor = System.Drawing.Color.Honeydew;
            this.IblInitialText.ForeColor = System.Drawing.Color.Black;
            this.IblInitialText.Name = "IblInitialText";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Honeydew;
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.cmbKeyDecrypt);
            this.tabPage4.Controls.Add(this.cmbAlphabetDecrypt);
            this.tabPage4.Controls.Add(this.btnUsePrevious);
            this.tabPage4.Controls.Add(this.buttonLoadForDecryption);
            this.tabPage4.Controls.Add(this.btnDecipher);
            this.tabPage4.Controls.Add(this.btnCleaerControlsDecrypt);
            this.tabPage4.Controls.Add(this.txtDecryptedText);
            this.tabPage4.Controls.Add(this.materialLabel3);
            this.tabPage4.Controls.Add(this.txtTextToDecrypt);
            this.tabPage4.Controls.Add(this.lblDecrypt);
            this.tabPage4.Controls.Add(this.materialLabel1);
            this.tabPage4.ForeColor = System.Drawing.Color.DarkGreen;
            resources.ApplyResources(this.tabPage4, "tabPage4");
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            // 
            // cmbKeyDecrypt
            // 
            this.cmbKeyDecrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.cmbKeyDecrypt, "cmbKeyDecrypt");
            this.cmbKeyDecrypt.ForeColor = System.Drawing.Color.Black;
            this.cmbKeyDecrypt.FormattingEnabled = true;
            this.cmbKeyDecrypt.Items.AddRange(new object[] {
            resources.GetString("cmbKeyDecrypt.Items"),
            resources.GetString("cmbKeyDecrypt.Items1"),
            resources.GetString("cmbKeyDecrypt.Items2"),
            resources.GetString("cmbKeyDecrypt.Items3"),
            resources.GetString("cmbKeyDecrypt.Items4"),
            resources.GetString("cmbKeyDecrypt.Items5"),
            resources.GetString("cmbKeyDecrypt.Items6"),
            resources.GetString("cmbKeyDecrypt.Items7"),
            resources.GetString("cmbKeyDecrypt.Items8"),
            resources.GetString("cmbKeyDecrypt.Items9"),
            resources.GetString("cmbKeyDecrypt.Items10"),
            resources.GetString("cmbKeyDecrypt.Items11"),
            resources.GetString("cmbKeyDecrypt.Items12"),
            resources.GetString("cmbKeyDecrypt.Items13"),
            resources.GetString("cmbKeyDecrypt.Items14"),
            resources.GetString("cmbKeyDecrypt.Items15"),
            resources.GetString("cmbKeyDecrypt.Items16"),
            resources.GetString("cmbKeyDecrypt.Items17"),
            resources.GetString("cmbKeyDecrypt.Items18"),
            resources.GetString("cmbKeyDecrypt.Items19"),
            resources.GetString("cmbKeyDecrypt.Items20"),
            resources.GetString("cmbKeyDecrypt.Items21"),
            resources.GetString("cmbKeyDecrypt.Items22"),
            resources.GetString("cmbKeyDecrypt.Items23"),
            resources.GetString("cmbKeyDecrypt.Items24"),
            resources.GetString("cmbKeyDecrypt.Items25"),
            resources.GetString("cmbKeyDecrypt.Items26"),
            resources.GetString("cmbKeyDecrypt.Items27"),
            resources.GetString("cmbKeyDecrypt.Items28"),
            resources.GetString("cmbKeyDecrypt.Items29"),
            resources.GetString("cmbKeyDecrypt.Items30"),
            resources.GetString("cmbKeyDecrypt.Items31"),
            resources.GetString("cmbKeyDecrypt.Items32")});
            this.cmbKeyDecrypt.Name = "cmbKeyDecrypt";
            this.cmbKeyDecrypt.SelectedIndexChanged += new System.EventHandler(this.cmbKeyDecrypt_SelectedIndexChanged);
            // 
            // cmbAlphabetDecrypt
            // 
            this.cmbAlphabetDecrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.cmbAlphabetDecrypt, "cmbAlphabetDecrypt");
            this.cmbAlphabetDecrypt.ForeColor = System.Drawing.Color.Black;
            this.cmbAlphabetDecrypt.FormattingEnabled = true;
            this.cmbAlphabetDecrypt.Items.AddRange(new object[] {
            resources.GetString("cmbAlphabetDecrypt.Items"),
            resources.GetString("cmbAlphabetDecrypt.Items1"),
            resources.GetString("cmbAlphabetDecrypt.Items2")});
            this.cmbAlphabetDecrypt.Name = "cmbAlphabetDecrypt";
            // 
            // btnUsePrevious
            // 
            this.btnUsePrevious.BackColor = System.Drawing.Color.PaleGreen;
            this.btnUsePrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnUsePrevious, "btnUsePrevious");
            this.btnUsePrevious.ForeColor = System.Drawing.Color.Black;
            this.btnUsePrevious.Name = "btnUsePrevious";
            this.btnUsePrevious.UseVisualStyleBackColor = false;
            this.btnUsePrevious.Click += new System.EventHandler(this.btnUsePrevious_Click);
            // 
            // buttonLoadForDecryption
            // 
            this.buttonLoadForDecryption.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonLoadForDecryption.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.buttonLoadForDecryption, "buttonLoadForDecryption");
            this.buttonLoadForDecryption.ForeColor = System.Drawing.Color.Black;
            this.buttonLoadForDecryption.Name = "buttonLoadForDecryption";
            this.buttonLoadForDecryption.UseVisualStyleBackColor = false;
            this.buttonLoadForDecryption.Click += new System.EventHandler(this.buttonLoadForDecryption_Click);
            // 
            // btnDecipher
            // 
            this.btnDecipher.BackColor = System.Drawing.Color.LightGreen;
            this.btnDecipher.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnDecipher, "btnDecipher");
            this.btnDecipher.ForeColor = System.Drawing.Color.Black;
            this.btnDecipher.Name = "btnDecipher";
            this.btnDecipher.UseVisualStyleBackColor = false;
            this.btnDecipher.Click += new System.EventHandler(this.btnDecipher_Click);
            // 
            // btnCleaerControlsDecrypt
            // 
            this.btnCleaerControlsDecrypt.BackColor = System.Drawing.Color.LightGreen;
            this.btnCleaerControlsDecrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnCleaerControlsDecrypt, "btnCleaerControlsDecrypt");
            this.btnCleaerControlsDecrypt.ForeColor = System.Drawing.Color.Black;
            this.btnCleaerControlsDecrypt.Name = "btnCleaerControlsDecrypt";
            this.btnCleaerControlsDecrypt.UseVisualStyleBackColor = false;
            this.btnCleaerControlsDecrypt.Click += new System.EventHandler(this.btnCleaerControlsDecrypt_Click);
            // 
            // txtDecryptedText
            // 
            this.txtDecryptedText.BackColor = System.Drawing.Color.MintCream;
            resources.ApplyResources(this.txtDecryptedText, "txtDecryptedText");
            this.txtDecryptedText.ForeColor = System.Drawing.Color.Black;
            this.txtDecryptedText.Name = "txtDecryptedText";
            this.txtDecryptedText.ReadOnly = true;
            // 
            // materialLabel3
            // 
            resources.ApplyResources(this.materialLabel3, "materialLabel3");
            this.materialLabel3.BackColor = System.Drawing.Color.Honeydew;
            this.materialLabel3.ForeColor = System.Drawing.Color.Black;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Click += new System.EventHandler(this.materialLabel3_Click);
            // 
            // txtTextToDecrypt
            // 
            resources.ApplyResources(this.txtTextToDecrypt, "txtTextToDecrypt");
            this.txtTextToDecrypt.ForeColor = System.Drawing.Color.Black;
            this.txtTextToDecrypt.Name = "txtTextToDecrypt";
            this.txtTextToDecrypt.TextChanged += new System.EventHandler(this.txtTextToDecrypt_TextChanged);
            this.txtTextToDecrypt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTextToDecrypt_KeyDown);
            // 
            // lblDecrypt
            // 
            resources.ApplyResources(this.lblDecrypt, "lblDecrypt");
            this.lblDecrypt.BackColor = System.Drawing.Color.Honeydew;
            this.lblDecrypt.ForeColor = System.Drawing.Color.Black;
            this.lblDecrypt.Name = "lblDecrypt";
            this.lblDecrypt.Click += new System.EventHandler(this.lblDecrypt_Click);
            // 
            // materialLabel1
            // 
            resources.ApplyResources(this.materialLabel1, "materialLabel1");
            this.materialLabel1.BackColor = System.Drawing.Color.Honeydew;
            this.materialLabel1.ForeColor = System.Drawing.Color.Black;
            this.materialLabel1.Name = "materialLabel1";
            // 
            // CaesarCipher
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CaesarCipher";
            this.Tag = "";
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
        private System.Windows.Forms.Label IblInitialText;
        private System.Windows.Forms.TextBox txtToEncrypt;
        private System.Windows.Forms.Label IblOutputText;
        private System.Windows.Forms.Button btnClearControls;
        private System.Windows.Forms.TextBox txtEncryptedText;
        private System.Windows.Forms.Button btnCipher;
        private System.Windows.Forms.Label materialLabel1;
        private System.Windows.Forms.Label lblDecrypt;
        private System.Windows.Forms.Label materialLabel3;
        private System.Windows.Forms.TextBox txtTextToDecrypt;
        private System.Windows.Forms.Button btnCleaerControlsDecrypt;
        private System.Windows.Forms.TextBox txtDecryptedText;
        private System.Windows.Forms.Button btnDecipher;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoadForDecryption;
        private System.Windows.Forms.Button btnUsePrevious;
        private System.Windows.Forms.ComboBox cmbAlphabet;
        private System.Windows.Forms.ComboBox cmbAlphabetDecrypt;
        private System.Windows.Forms.ComboBox cmbKeyEncrypt;
        private System.Windows.Forms.ComboBox cmbKeyDecrypt;
        private System.Windows.Forms.Label lblAlphabet;
        private System.Windows.Forms.Label label1;
    }
}

