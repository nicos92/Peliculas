using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliculas.Utils
{
    public class UtilVistas
    {
        public static void MostrarVistas(UserControl userControl, Panel PanelVistas)
        {
            userControl.Dock = DockStyle.Fill;
            PanelVistas.Controls.Clear();
            PanelVistas.Controls.Add(userControl);
            userControl.BringToFront();

        }
    }
}
