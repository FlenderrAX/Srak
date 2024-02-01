using System;
using System.Windows.Forms;

public class KeyInputDialog : Form
{
    public Keys SelectedKey { get; private set; }

    public KeyInputDialog()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        this.Text = "Press a key";
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.StartPosition = FormStartPosition.CenterScreen;
        this.KeyPreview = true;
        this.KeyPress += KeyInputDialog_KeyPress;
    }

    private void KeyInputDialog_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (char.IsLetterOrDigit(e.KeyChar))
        {
            SelectedKey = (Keys)Enum.Parse(typeof(Keys), e.KeyChar.ToString(), true);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
