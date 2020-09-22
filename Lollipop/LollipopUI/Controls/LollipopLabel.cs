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
using LollipopUI.UIManagers;
using System.Drawing;
using System.Windows.Forms;

namespace LollipopUI.Controls {
  public class LollipopLabel : Label {

    FontManager font = new FontManager();

    public LollipopLabel() {
      this.Font = font.Roboto_Medium10;
      ForeColor = ColorTranslator.FromHtml("#999999");
      BackColor = Color.Transparent;
    }

  }
}
