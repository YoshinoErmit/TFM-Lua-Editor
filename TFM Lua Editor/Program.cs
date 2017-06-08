using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
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
        static void Main(string[] args)
        {
            if (args.Length == 1 && args[0] == "Baka")
            {
            }
            else
            {
                try
                {
                    Process.Start(Path.Combine(Application.StartupPath, "Updater.exe"));
                    Process.GetCurrentProcess().Kill();
                }
                catch { MessageBox.Show("Updater introuvable.."); }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}