using System;
using System.Windows.Forms;

namespace TFM_Lua_Editor
{
    static class Program
    {
        public static bool Args;
        public static string File;
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main(string[] args = null)
        {
            args = args ?? new string[0];

            if (args.Length != 0)
            {
                if (args[0] != "")
                {
                    Args = true;
                    File = args[0];
                }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
