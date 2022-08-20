using System.Windows.Forms;
using System.Drawing;
using System;

namespace SAISKabini
{
    internal class FormStyles
    {
        internal void CellPaints(object sender, TableLayoutCellPaintEventArgs e)
        {
            ((e.Row % 2 == 0) ? (Action)(() => { e.Graphics.FillRectangle(Brushes.WhiteSmoke, e.CellBounds); })
                : () => { e.Graphics.FillRectangle(Brushes.White, e.CellBounds); })();
        }
    }
}
