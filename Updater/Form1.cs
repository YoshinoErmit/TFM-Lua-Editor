using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Updater
{
    public partial class UpdateForm : Form
    {
        string baseUrl = "http://yprog.livehost.fr/update/";
        TaskCompletionSource<bool> waitEndFile;
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            lbl_dl.Visible = false;
            lbl_ko.Visible = false;
            lbl_file.Text = "Recherche de mise à jour...";
            //Get version
            using (WebClient web = new WebClient())
            {
                if (Properties.Settings.Default.Version == "0.0.0")
                {
                    web.DownloadStringCompleted += Web_DownloadStringCompleted;
                    web.DownloadStringAsync(new Uri($"{baseUrl}base.txt"));
                }
                else
                {
                    web.DownloadStringCompleted += Web_DownloadStringUpdate;
                    web.DownloadStringAsync(new Uri($"{baseUrl}update.txt"));
                }
            }
        }

        private async void Web_DownloadStringUpdate(object sender, DownloadStringCompletedEventArgs e)
        {
            //Splititng file for get version and file
            string Result = e.Result;
            var result = Regex.Split(Result, "\r\n|\r|\n");
            var version = result[0].Split(':');
            //Version checking
            if(Properties.Settings.Default.Version != version[1])
                await startDownload(result); //asynchrous method for waiting each file downloaded
            else
                lbl_file.Text = "Éditeur à jour";
            //Save version after all chacking
            Properties.Settings.Default.Version = version[1];
            Properties.Settings.Default.Save();
            //Start editor
            lbl_file.Text = "Lancement de l'éditeur";
            lbl_ko.Visible = false;
            lbl_dl.Visible = false;
            Process.Start("TFM Lua Editor.exe", "Baka");
            this.Close();
        }

        private async void Web_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            //Splitting file for get version and file
            string Result = e.Result;
            var result = Regex.Split(Result, "\r\n|\r|\n");
            await startDownload(result);//asynchrous method for waiting each file downloaded

            var version = result[0].Split(':');//Saving version
            Properties.Settings.Default.Version = version[1];
            Properties.Settings.Default.Save();
            //Start editor
            lbl_file.Text = "Lancement de l'éditeur";
            lbl_ko.Visible = false;
            lbl_dl.Visible = false;
            Process.Start("TFM Lua Editor.exe", "Baka");
            this.Close();
        }

        private void Web_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            waitEndFile.SetResult(true);
            pgbar_file.Value++;
        }

        private void Web_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            pgbar.Value = e.ProgressPercentage;
            lbl_ko.Text = $"{e.BytesReceived/1000} ko/{e.TotalBytesToReceive/1000} ko";
        }

        private async Task startDownload(string[] files)
        {
            for (int i = 1; i < files.Count() - 1; i++)
            {
                string[] name = files[i].Split(':');
                if (name[0] != "version")
                {
                    using (WebClient web = new WebClient())
                    {
                        waitEndFile = new TaskCompletionSource<bool>();
                        pgbar.Value = 0;
                        lbl_dl.Text = $"Téléchargement du fichier : {name[0]}";
                        lbl_ko.Visible = true;
                        lbl_dl.Visible = true;
                        lbl_file.Text = $"Fichier télécharger : {i - 1}/{ files.Count() - 1}";
                        pgbar_file.MaximumValue = files.Count() - 1;
                        web.DownloadProgressChanged += Web_DownloadProgressChanged;
                        web.DownloadFileCompleted += Web_DownloadFileCompleted;
                        web.DownloadFileAsync(new Uri($"{baseUrl}{name[0]}"), @name[1]);
                        await waitEndFile.Task;
                    }
                }
            }
        }
    }
}
