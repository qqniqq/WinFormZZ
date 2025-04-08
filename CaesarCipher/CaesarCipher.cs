using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaesarCipher
{
    public partial class CaesarCipher: Form
    {
        private string output;
        public CaesarCipher()
        {
            InitializeComponent();
            ClearControlsEncrypt();
            ClearControlsDecrypt();
        }

        public void ClearControlsEncrypt()
        {

            txtEncryptedText.Text = "";
            txtKeyToEncrypt.Text = "";
            txtToEncrypt.Text = "";
        }

        public void ClearControlsDecrypt()
        {
            txtDecryptedText.Text = "";
            txtKeyToDecrypt.Text = "";
            txtTextToDecrypt.Text = "";
        }

        private void CaesarCipher_Load(object sender, EventArgs e)
        {

        }

        private void IblKey_Click(object sender, EventArgs e)
        {

        }

        private void btnClearControls_Click(object sender, EventArgs e)
        {
            ClearControlsEncrypt();
        }

        private void btnCleaerControlsDecrypt_Click(object sender, EventArgs e)
        {
            ClearControlsDecrypt();
        }

        private void btnCipher_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtKeyToEncrypt.Text) && !string.IsNullOrEmpty(txtToEncrypt.Text))
            {
                output = Cipher.Encrypt(txtToEncrypt.Text, int.Parse(txtKeyToEncrypt.Text));

                txtEncryptedText.Text = output;
            }
        }

        private void btnDecipher_Click(object sender, EventArgs e)
        {
  if (!string.IsNullOrEmpty(txtKeyToDecrypt.Text) && !string.IsNullOrEmpty(txtTextToDecrypt.Text))
            {
                output = Cipher.Decrypt(txtTextToDecrypt.Text, int.Parse(txtKeyToDecrypt.Text));

                txtDecryptedText.Text = output;
            }
        }

        private void txtKeyToEncrypt_TextChanged(object sender, EventArgs e)
        {
        
       
    }

        private void txtKeyToEncrypt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
