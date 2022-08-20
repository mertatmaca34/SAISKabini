using System.Windows.Forms;
using System.Drawing;

namespace SAISKabini
{
    internal class FormStyles
    {
        internal void CellPaints(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (e.Row % 2 == 0)
            {
                e.Graphics.FillRectangle(Brushes.WhiteSmoke, e.CellBounds);
            }
            else if (e.Row % 2 == 1)
            {
                e.Graphics.FillRectangle(Brushes.White, e.CellBounds);
            }
        }
    }
}
