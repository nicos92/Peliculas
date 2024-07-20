using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peliculas.Singleton
{
    public class MiPanelVistas
    {
        private static MiPanelVistas? instance;   
        private static readonly object instanceLock = new();
        private readonly Panel _panel;

        private MiPanelVistas() {

            _panel = new Panel
            {
                Dock = DockStyle.Right,
                Location = new Point(200, 0),
                Name = "PanelVistas",
                Size = new Size(584, 461),
                TabIndex = 1
            };
        }

        public static MiPanelVistas GetInstancia
        {
            get{
                if (instance == null)
                {
                    lock (instanceLock)
                    {
                        instance ??= new MiPanelVistas();
                    }
                }
                return instance;
            }
        }

        public Panel GetPanel
        {
            get { return _panel; }
        }

        public void Add(UserControl userControl) => _panel.Controls.Add(userControl);


        public void Clear() => _panel.Controls.Clear();
        

        public static void MostrarVistas(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            MiPanelVistas.GetInstancia.Clear();
            MiPanelVistas.GetInstancia.Add(userControl);
            userControl.BringToFront();

        }

    }
}
