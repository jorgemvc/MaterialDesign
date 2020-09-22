/* DESCRIPTION
 *
 * NOTES
 *
 * REQUIRES
 *
 * MODIFICATIONS
 *   J.Villalobos  22.Set.2020  .NET 4.8
 *   Viki4Tech     02.Jun.2015  Creation
 */
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LollipopUI.Controls {

  public class LollipopProgressBar : Control {

    #region variables
    int ProgressNum = 10;
    string ProgressColor = "#508ef5";

    Color BackGroundColor;
    #endregion

    #region Properties
    [Category("Appearance")]
    public string BGColor {
      get { return ProgressColor; }
      set {
        ProgressColor = value;
        Invalidate();
      }
    }

    [Category("Behavior")]
    public int Value {
      get { return ProgressNum; }
      set {
        ProgressNum = value;
        Invalidate();
      }
    }
    #endregion

    public LollipopProgressBar() {
      Width = 300; Height = 4; DoubleBuffered = true;
    }

    protected override void OnPaint(PaintEventArgs e) {
      base.OnPaint(e);

      Graphics G = e.Graphics;
      G.Clear(Parent.BackColor);

      BackGroundColor = ColorTranslator.FromHtml(ProgressColor);
      G.FillRectangle(new SolidBrush(Color.FromArgb(68, BackGroundColor)), 0, 0, Width, Height);


      if (ProgressNum <= 101 && ProgressNum >= 0) { G.FillRectangle(new SolidBrush(BackGroundColor), 0, 0, (Width * ProgressNum) / (100 - 0), Height); } else {
        ProgressNum = 10;

        MessageBox.Show("Wrong value...!", "Lollipop Theme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        G.FillRectangle(new SolidBrush(BackGroundColor), 0, 0, (Width * ProgressNum) / (100 - 0), Height);
      }
    }
  }
}
