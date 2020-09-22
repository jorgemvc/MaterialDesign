/* DESCRIPTION
 *
 * NOTES
 *
 * REQUIRES
 *
 * MODIFICACIONES
 *   J.Villalobos  22.Set.2020  .NET 4.8
 *   Viki4Tech     02.Jun.2015  Creation
 */
using System;
using System.Windows.Forms;

namespace LollipopUI.Example {
  public partial class MainForm : Form {
    public MainForm() {
      InitializeComponent();
    }

    private void lollipopButton1_Click(object sender, EventArgs e) {
      MessageBox.Show("lollipoButton1 Clicked !!!");
    }

    private void lollipopFlatButton1_Click(object sender, EventArgs e) {
      MessageBox.Show("lollipopFlatButton1 Clicked !!!");
    }

    private void lollipopCard1_OnCardButtonClick(object sender, EventArgs e) {
      MessageBox.Show("lollipopCard1 Clicked");
    }

    private void lollipopToggle1_CheckedChanged(object sender, EventArgs e) {
      lollipopLabel2.Text = lollipopToggle1.Checked.ToString();
    }
  }
}
