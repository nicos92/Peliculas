using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Peliculas.Utils
{
    public static partial class Utils
    {
        
        public static DialogResult CartelConfirmWarn(string msj, string titulo) => MessageBox.Show(msj, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

        public static void CartelConfirmInfo(string msj, string titulo) => MessageBox.Show(msj, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        public static void CartelError(string msj, string titulo) => MessageBox.Show(msj, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);




        [GeneratedRegex(@"^(\d){0,14}$")]
        public static partial Regex RegexInt();

        public static bool ValidarInt(TextBox text, Label label) => label.Visible = !RegexInt().IsMatch(text.Text);
        

    }
}
