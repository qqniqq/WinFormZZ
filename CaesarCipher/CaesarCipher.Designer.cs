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
            this.IblKey.AutoSize = true;
            this.IblKey.BackColor = System.Drawing.SystemColors.Window;
            this.IblKey.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.IblKey.Location = new System.Drawing.Point(19, 5);
            this.IblKey.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.IblKey.Name = "IblKey";
            this.IblKey.Size = new System.Drawing.Size(51, 22);
            this.IblKey.TabIndex = 0;
            this.IblKey.Text = "Ключ";
            this.IblKey.Click += new System.EventHandler(this.IblKey_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(48, 18);
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(889, 599);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage3
            // 
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
            this.tabPage3.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage3.Size = new System.Drawing.Size(881, 573);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Зашифровка";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblAlphabet
            // 
            this.lblAlphabet.AutoSize = true;
            this.lblAlphabet.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlphabet.Location = new System.Drawing.Point(165, 5);
            this.lblAlphabet.Name = "lblAlphabet";
            this.lblAlphabet.Size = new System.Drawing.Size(82, 22);
            this.lblAlphabet.TabIndex = 15;
            this.lblAlphabet.Text = "Алфавит";
            // 
            // cmbKeyEncrypt
            // 
            this.cmbKeyEncrypt.FormattingEnabled = true;
            this.cmbKeyEncrypt.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33"});
            this.cmbKeyEncrypt.Location = new System.Drawing.Point(22, 31);
            this.cmbKeyEncrypt.Margin = new System.Windows.Forms.Padding(4);
            this.cmbKeyEncrypt.Name = "cmbKeyEncrypt";
            this.cmbKeyEncrypt.Size = new System.Drawing.Size(122, 28);
            this.cmbKeyEncrypt.TabIndex = 14;
            this.cmbKeyEncrypt.SelectedIndexChanged += new System.EventHandler(this.cmbKeyEncrypt_SelectedIndexChanged);
            // 
            // cmbAlphabet
            // 
            this.cmbAlphabet.AccessibleDescription = "";
            this.cmbAlphabet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbAlphabet.FormattingEnabled = true;
            this.cmbAlphabet.Items.AddRange(new object[] {
            "Русский",
            "Английский"});
            this.cmbAlphabet.Location = new System.Drawing.Point(169, 31);
            this.cmbAlphabet.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAlphabet.Name = "cmbAlphabet";
            this.cmbAlphabet.Size = new System.Drawing.Size(183, 28);
            this.cmbAlphabet.TabIndex = 13;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(538, 329);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(286, 76);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Сохранить результат";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // btnCipher
            // 
            this.btnCipher.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCipher.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCipher.Location = new System.Drawing.Point(536, 100);
            this.btnCipher.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnCipher.Name = "btnCipher";
            this.btnCipher.Size = new System.Drawing.Size(286, 76);
            this.btnCipher.TabIndex = 12;
            this.btnCipher.Text = "Зашифровать";
            this.btnCipher.UseVisualStyleBackColor = true;
            this.btnCipher.Click += new System.EventHandler(this.btnCipher_Click);
            // 
            // btnClearControls
            // 
            this.btnClearControls.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClearControls.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearControls.Location = new System.Drawing.Point(536, 445);
            this.btnClearControls.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnClearControls.Name = "btnClearControls";
            this.btnClearControls.Size = new System.Drawing.Size(286, 76);
            this.btnClearControls.TabIndex = 4;
            this.btnClearControls.Text = "Очистить ";
            this.btnClearControls.UseVisualStyleBackColor = true;
            this.btnClearControls.Click += new System.EventHandler(this.btnClearControls_Click);
            // 
            // txtEncryptedText
            // 
            this.txtEncryptedText.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncryptedText.Location = new System.Drawing.Point(23, 329);
            this.txtEncryptedText.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtEncryptedText.Multiline = true;
            this.txtEncryptedText.Name = "txtEncryptedText";
            this.txtEncryptedText.Size = new System.Drawing.Size(502, 192);
            this.txtEncryptedText.TabIndex = 3;
            // 
            // IblOutputText
            // 
            this.IblOutputText.AutoSize = true;
            this.IblOutputText.BackColor = System.Drawing.SystemColors.Window;
            this.IblOutputText.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblOutputText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.IblOutputText.Location = new System.Drawing.Point(18, 298);
            this.IblOutputText.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.IblOutputText.Name = "IblOutputText";
            this.IblOutputText.Size = new System.Drawing.Size(200, 22);
            this.IblOutputText.TabIndex = 0;
            this.IblOutputText.Text = "Зашифрованный текст :";
            // 
            // txtToEncrypt
            // 
            this.txtToEncrypt.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToEncrypt.Location = new System.Drawing.Point(23, 100);
            this.txtToEncrypt.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtToEncrypt.Multiline = true;
            this.txtToEncrypt.Name = "txtToEncrypt";
            this.txtToEncrypt.Size = new System.Drawing.Size(502, 192);
            this.txtToEncrypt.TabIndex = 10;
            // 
            // IblInitialText
            // 
            this.IblInitialText.AutoSize = true;
            this.IblInitialText.BackColor = System.Drawing.SystemColors.Window;
            this.IblInitialText.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblInitialText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.IblInitialText.Location = new System.Drawing.Point(18, 70);
            this.IblInitialText.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.IblInitialText.Name = "IblInitialText";
            this.IblInitialText.Size = new System.Drawing.Size(221, 22);
            this.IblInitialText.TabIndex = 4;
            this.IblInitialText.Text = "Текст для зашифрования :";
            // 
            // tabPage4
            // 
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
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tabPage4.Size = new System.Drawing.Size(881, 573);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Расшифровка";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "Алфавит";
            // 
            // cmbKeyDecrypt
            // 
            this.cmbKeyDecrypt.FormattingEnabled = true;
            this.cmbKeyDecrypt.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33"});
            this.cmbKeyDecrypt.Location = new System.Drawing.Point(22, 31);
            this.cmbKeyDecrypt.Margin = new System.Windows.Forms.Padding(4);
            this.cmbKeyDecrypt.Name = "cmbKeyDecrypt";
            this.cmbKeyDecrypt.Size = new System.Drawing.Size(122, 28);
            this.cmbKeyDecrypt.TabIndex = 17;
            this.cmbKeyDecrypt.SelectedIndexChanged += new System.EventHandler(this.cmbKeyDecrypt_SelectedIndexChanged);
            // 
            // cmbAlphabetDecrypt
            // 
            this.cmbAlphabetDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAlphabetDecrypt.FormattingEnabled = true;
            this.cmbAlphabetDecrypt.Items.AddRange(new object[] {
            "Русский",
            "Английский"});
            this.cmbAlphabetDecrypt.Location = new System.Drawing.Point(169, 31);
            this.cmbAlphabetDecrypt.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAlphabetDecrypt.Name = "cmbAlphabetDecrypt";
            this.cmbAlphabetDecrypt.Size = new System.Drawing.Size(183, 28);
            this.cmbAlphabetDecrypt.TabIndex = 16;
            // 
            // btnUsePrevious
            // 
            this.btnUsePrevious.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsePrevious.Location = new System.Drawing.Point(536, 184);
            this.btnUsePrevious.Margin = new System.Windows.Forms.Padding(4);
            this.btnUsePrevious.Name = "btnUsePrevious";
            this.btnUsePrevious.Size = new System.Drawing.Size(286, 109);
            this.btnUsePrevious.TabIndex = 15;
            this.btnUsePrevious.Text = "Расшифровать предыдущий зашифрованный текст";
            this.btnUsePrevious.UseVisualStyleBackColor = true;
            this.btnUsePrevious.Click += new System.EventHandler(this.btnUsePrevious_Click);
            // 
            // buttonLoadForDecryption
            // 
            this.buttonLoadForDecryption.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadForDecryption.Location = new System.Drawing.Point(441, 18);
            this.buttonLoadForDecryption.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLoadForDecryption.Name = "buttonLoadForDecryption";
            this.buttonLoadForDecryption.Size = new System.Drawing.Size(381, 74);
            this.buttonLoadForDecryption.TabIndex = 14;
            this.buttonLoadForDecryption.Text = "Загрузить сохраненный текст для расшифровки";
            this.buttonLoadForDecryption.UseVisualStyleBackColor = true;
            this.buttonLoadForDecryption.Click += new System.EventHandler(this.buttonLoadForDecryption_Click);
            // 
            // btnDecipher
            // 
            this.btnDecipher.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecipher.Location = new System.Drawing.Point(536, 100);
            this.btnDecipher.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnDecipher.Name = "btnDecipher";
            this.btnDecipher.Size = new System.Drawing.Size(286, 76);
            this.btnDecipher.TabIndex = 12;
            this.btnDecipher.Text = "Расшифровать";
            this.btnDecipher.UseVisualStyleBackColor = true;
            this.btnDecipher.Click += new System.EventHandler(this.btnDecipher_Click);
            // 
            // btnCleaerControlsDecrypt
            // 
            this.btnCleaerControlsDecrypt.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCleaerControlsDecrypt.Location = new System.Drawing.Point(536, 445);
            this.btnCleaerControlsDecrypt.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnCleaerControlsDecrypt.Name = "btnCleaerControlsDecrypt";
            this.btnCleaerControlsDecrypt.Size = new System.Drawing.Size(286, 76);
            this.btnCleaerControlsDecrypt.TabIndex = 11;
            this.btnCleaerControlsDecrypt.Text = "Очистить";
            this.btnCleaerControlsDecrypt.UseVisualStyleBackColor = true;
            this.btnCleaerControlsDecrypt.Click += new System.EventHandler(this.btnCleaerControlsDecrypt_Click);
            // 
            // txtDecryptedText
            // 
            this.txtDecryptedText.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecryptedText.Location = new System.Drawing.Point(23, 329);
            this.txtDecryptedText.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtDecryptedText.Multiline = true;
            this.txtDecryptedText.Name = "txtDecryptedText";
            this.txtDecryptedText.Size = new System.Drawing.Size(502, 192);
            this.txtDecryptedText.TabIndex = 9;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(18, 298);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(207, 22);
            this.materialLabel3.TabIndex = 7;
            this.materialLabel3.Text = "Расшифрованный текст :";
            this.materialLabel3.Click += new System.EventHandler(this.materialLabel3_Click);
            // 
            // txtTextToDecrypt
            // 
            this.txtTextToDecrypt.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTextToDecrypt.Location = new System.Drawing.Point(23, 100);
            this.txtTextToDecrypt.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtTextToDecrypt.Multiline = true;
            this.txtTextToDecrypt.Name = "txtTextToDecrypt";
            this.txtTextToDecrypt.Size = new System.Drawing.Size(502, 192);
            this.txtTextToDecrypt.TabIndex = 10;
            // 
            // lblDecrypt
            // 
            this.lblDecrypt.AutoSize = true;
            this.lblDecrypt.BackColor = System.Drawing.SystemColors.Window;
            this.lblDecrypt.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecrypt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDecrypt.Location = new System.Drawing.Point(18, 70);
            this.lblDecrypt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDecrypt.Name = "lblDecrypt";
            this.lblDecrypt.Size = new System.Drawing.Size(211, 22);
            this.lblDecrypt.TabIndex = 6;
            this.lblDecrypt.Text = "Текст для расшифровки :";
            this.lblDecrypt.Click += new System.EventHandler(this.lblDecrypt_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(19, 5);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(51, 22);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Ключ";
            // 
            // CaesarCipher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(889, 623);
            this.Controls.Add(this.tabControl1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Rockwell", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
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

