using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace OmegaSphere
{
    public partial class soft_fr : Form
    {

        public soft_fr()
        {
            InitializeComponent();

            WebClient webClient = new WebClient();
            if (!webClient.DownloadString("https://fprogeek.yj.fr/omegasphere/version.txt").Contains("4.0.5"))
            {

                if (MessageBox.Show("Une nouvelle version d'omegasphere est disponible, Voulez vous télécharger la nouvelle version ?", "OmegaSphere Updater", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                        using (var client = new WebClient())
                        {
                            client.DownloadFile("https://fprogeek.yj.fr/omegasphere/OmegaSphere_Updater.exe", @"C:\OmegaSphere\OmegaSphere_Updater.exe");
                            if (MessageBox.Show("La version est téléchargé, voulez vous l'installer ?", "OmegaSphere Updater", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                using (var update = new WebClient())
                                {
                                    if (File.Exists(@"C:\OmegaSphere\OmegaSphere_Updater.exe"))
                                    {
                                        System.Diagnostics.Process.Start("explorer.exe", @"C:\OmegaSphere\OmegaSphere_Updater.exe");
                                    }
                                    else
                                    {
                                        MessageBox.Show("Le fichier d'installation est introuvable");
                                    }
                                }
                            }
                            else
                            {

                            }
                        }
                    }
                else
                {

                }
            }
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;

            }

            base.WndProc(ref m);
        }

        private void soft_fr_Load(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();
            if (diag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string folder = diag.SelectedPath + "\\tinfoil.nro"; // chemin du dossier sélectionné

                using (var client = new WebClient())
                {
                    client.DownloadFile("https://fprogeek.yj.fr/omegasphere/Homebrew/tinfoil.nro", folder);
                    PopupNotifier popup = new PopupNotifier();
                    popup.Image = Properties.Resources.info;
                    popup.TitleText = "OmegaSphere Notification";
                    popup.ContentText = "L'homebrew est correctement installé sur votre carte sd.";
                    popup.Popup();
                    MessageBox.Show("L'homebrew est correctement installé sur votre carte sd.");
                }
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();
            if (diag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string folder = diag.SelectedPath + "\\goldleaf.nro"; // chemin du dossier sélectionné

                using (var client = new WebClient())
                {
                    client.DownloadFile("https://fprogeek.yj.fr/omegasphere/Homebrew/goldleaf.nro", folder);
                    PopupNotifier popup = new PopupNotifier();
                    popup.Image = Properties.Resources.info;
                    popup.TitleText = "OmegaSphere Notification";
                    popup.ContentText = "L'homebrew est correctement installé sur votre carte sd.";
                    popup.Popup();
                    MessageBox.Show("L'homebrew est correctement installé sur votre carte sd.");
                }
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();
            if (diag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string folder = diag.SelectedPath + "\\choidujournx.nro"; // chemin du dossier sélectionné

                using (var client = new WebClient())
                {
                    client.DownloadFile("https://fprogeek.yj.fr/omegasphere/Homebrew/choidujournx.nro", folder);
                    PopupNotifier popup = new PopupNotifier();
                    popup.Image = Properties.Resources.info;
                    popup.TitleText = "OmegaSphere Notification";
                    popup.ContentText = "L'homebrew est correctement installé sur votre carte sd.";
                    popup.Popup();
                    MessageBox.Show("L'homebrew est correctement installé sur votre carte sd.");
                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();
            if (diag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string folder = diag.SelectedPath + "\\nxthemesInstaller.nro"; // chemin du dossier sélectionné

                using (var client = new WebClient())
                {
                    client.DownloadFile("https://fprogeek.yj.fr/omegasphere/Homebrew/nxthemesInstaller.nro", folder);
                    PopupNotifier popup = new PopupNotifier();
                    popup.Image = Properties.Resources.info;
                    popup.TitleText = "OmegaSphere Notification";
                    popup.ContentText = "L'homebrew est correctement installé sur votre carte sd.";
                    popup.Popup();
                    MessageBox.Show("L'homebrew est correctement installé sur votre carte sd.");
                }
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\OmegaSphere\Ressources\Logiciel\hacdiskmount\HacDiskMount.exe"))
            {
                System.Diagnostics.Process.Start("explorer.exe", @"C:\OmegaSphere\Ressources\Logiciel\hacdiskmount\HacDiskMount.exe");

                WebClient webClient = new WebClient();
                if (!webClient.DownloadString("https://fprogeek.yj.fr/omegasphere/update/version-hacdiskmount.txt").Contains("1.0.5-5"))
                {

                    if (MessageBox.Show("Une nouvelle version de HacDiskMount est disponible, Voulez vous télécharger la nouvelle version ?", "OmegaSphere Updater", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        using (var client = new WebClient())
                        {
                            client.DownloadFile("https://fprogeek.yj.fr/omegasphere/update/hacdiskmount_updater.zip", @"C:\OmegaSphere\hacdiskmount_updater.zip");
                            if (MessageBox.Show("La version est téléchargé, voulez vous l'installer ?", "OmegaSphere Updater", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                using (var update = new WebClient())
                                {
                                    ExtractZipFile(@"C:\OmegaSphere\hacdiskmount_updater.zip", @"C:\OmegaSphere");
                                    System.Diagnostics.Process.Start("explorer.exe", @"C:\OmegaSphere\Ressources\Logiciel\hacdiskmount\HacDiskMount.exe");
                                    File.Delete(@"C:\OmegaSphere\hacdiskmount_updater.zip");
                                }
                            }
                            else
                            {
                            }
                        }
                    }
                    else
                    {
                    }
                }
            }
            else
            {
                MessageBox.Show("Le Logiciel est introuvable, il va être téléchargé depuis notre serveur.");
                using (var client = new WebClient())
                {
                    client.DownloadFile("https://fprogeek.yj.fr/omegasphere/logiciel/hacdiskmount.zip", @"C:\OmegaSphere\Ressources\Logiciel\hacdiskmount.zip");
                    MessageBox.Show("Le logiciel est téléchargé. Il va s'installer puis s'ouvrir.");

                    ExtractZipFile(@"C:\OmegaSphere\Ressources\Logiciel\hacdiskmount.zip", @"C:\OmegaSphere\Ressources\Logiciel");
                    System.Diagnostics.Process.Start("explorer.exe", @"C:\OmegaSphere\Ressources\Logiciel\hacdiskmount\HacDiskMount.exe");
                    File.Delete(@"C:\OmegaSphere\Ressources\Logiciel\hacdiskmount.zip");
                }
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\OmegaSphere\Ressources\Logiciel\tegrarcmgui\TegraRcmGUI.exe"))
            {
                System.Diagnostics.Process.Start("explorer.exe", @"C:\OmegaSphere\Ressources\Logiciel\tegrarcmgui\TegraRcmGUI.exe");

                WebClient webClient = new WebClient();
                if (!webClient.DownloadString("https://fprogeek.yj.fr/omegasphere/update/version-tegrarcmgui.txt").Contains("2.6"))
                {

                    if (MessageBox.Show("Une nouvelle version de TegraRcmGUI est disponible, Voulez vous télécharger la nouvelle version ?", "OmegaSphere Updater", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        using (var client = new WebClient())
                        {
                            client.DownloadFile("https://fprogeek.yj.fr/omegasphere/update/tegrarcmgui_updater.zip", @"C:\OmegaSphere\tegrarcmgui_updater.zip");
                            if (MessageBox.Show("La version est téléchargé, voulez vous l'installer ?", "OmegaSphere Updater", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                using (var update = new WebClient())
                                {
                                    ExtractZipFile(@"C:\OmegaSphere\tegrarcmgui_updater.zip", @"C:\OmegaSphere");
                                    System.Diagnostics.Process.Start("explorer.exe", @"C:\OmegaSphere\Ressources\Logiciel\tegrarcmgui\TegraRcmGUI.exe");
                                    File.Delete(@"C:\OmegaSphere\tegrarcmgui_updater.zip");
                                }
                            }
                            else
                            {
                            }
                        }
                    }
                    else
                    {
                    }
                        }
                    }
            else
            {
                MessageBox.Show("Le Logiciel est introuvable, il va être téléchargé depuis notre serveur.");
                using (var client = new WebClient())
                {
                    client.DownloadFile("https://fprogeek.yj.fr/omegasphere/logiciel/tegrarcmgui.zip", @"C:\OmegaSphere\Ressources\Logiciel\tegrarcmgui.zip");
                    MessageBox.Show("Le logiciel est téléchargé. Il va s'installer puis s'ouvrir.");

                    ExtractZipFile(@"C:\OmegaSphere\Ressources\Logiciel\tegrarcmgui.zip", @"C:\OmegaSphere\Ressources\Logiciel");
                    System.Diagnostics.Process.Start("explorer.exe", @"C:\OmegaSphere\Ressources\Logiciel\tegrarcmgui\TegraRcmGUI.exe");
                    File.Delete(@"C:\OmegaSphere\Ressources\Logiciel\tegrarcmgui.zip");
                }
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\OmegaSphere\Ressources\Logiciel\nscb\NSCB.bat"))
            {
                System.Diagnostics.Process.Start("explorer.exe", @"C:\OmegaSphere\Ressources\Logiciel\nscb\NSCB.bat");

                WebClient webClient = new WebClient();
                if (!webClient.DownloadString("https://fprogeek.yj.fr/omegasphere/update/version-nscb.txt").Contains("0.89b"))
                {

                    if (MessageBox.Show("Une nouvelle version de NSC_Builder est disponible, Voulez vous télécharger la nouvelle version ?", "OmegaSphere Updater", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        using (var client = new WebClient())
                        {
                            client.DownloadFile("https://fprogeek.yj.fr/omegasphere/update/nscb_updater.zip", @"C:\OmegaSphere\nscb_updater.zip");
                            if (MessageBox.Show("La version est téléchargé, voulez vous l'installer ?", "OmegaSphere Updater", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                using (var update = new WebClient())
                                {
                                    ExtractZipFile(@"C:\OmegaSphere\nscb_updater.zip", @"C:\OmegaSphere");
                                    System.Diagnostics.Process.Start("explorer.exe", @"C:\OmegaSphere\Ressources\Logiciel\nscb\NSCB.bat");
                                    File.Delete(@"C:\OmegaSphere\nscb_updater.zip");
                                }
                            }
                            else
                            {
                            }
                        }
                    }
                    else
                    {
                    }
                }
            }
            else
            {
                MessageBox.Show("Le Logiciel est introuvable, il va être téléchargé depuis notre serveur.");
                using (var client = new WebClient())
                {
                    client.DownloadFile("https://fprogeek.yj.fr/omegasphere/logiciel/nscb.zip", @"C:\OmegaSphere\Ressources\Logiciel\nscb.zip");
                    MessageBox.Show("Le logiciel est téléchargé. Il va s'installer puis s'ouvrir.");

                    ExtractZipFile(@"C:\OmegaSphere\Ressources\Logiciel\nscb.zip", @"C:\OmegaSphere\Ressources\Logiciel");
                    System.Diagnostics.Process.Start("explorer.exe", @"C:\OmegaSphere\Ressources\Logiciel\nscb\NSCB.bat");
                    File.Delete(@"C:\OmegaSphere\Ressources\Logiciel\nscb.zip");
                }
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\OmegaSphere\Ressources\Logiciel\fluffy\fluffy.exe"))
            {
                System.Diagnostics.Process.Start("explorer.exe", @"C:\OmegaSphere\Ressources\Logiciel\fluffy\fluffy.exe");

                WebClient webClient = new WebClient();
                if (!webClient.DownloadString("https://fprogeek.yj.fr/omegasphere/update/version-fluffy.txt").Contains("2.9.2"))
                {

                    if (MessageBox.Show("Une nouvelle version de Fluffy est disponible, Voulez vous télécharger la nouvelle version ?", "OmegaSphere Updater", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        using (var client = new WebClient())
                        {
                            client.DownloadFile("https://fprogeek.yj.fr/omegasphere/update/fluffy_updater.zip", @"C:\OmegaSphere\fluffy_updater.zip");
                            if (MessageBox.Show("La version est téléchargé, voulez vous l'installer ?", "OmegaSphere Updater", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                using (var update = new WebClient())
                                {
                                    ExtractZipFile(@"C:\OmegaSphere\fluffy_updater.zip", @"C:\OmegaSphere");
                                    System.Diagnostics.Process.Start("explorer.exe", @"C:\OmegaSphere\Ressources\Logiciel\fluffy\fluffy.exe");
                                    File.Delete(@"C:\OmegaSphere\fluffy_updater.zip");
                                }
                            }
                            else
                            {
                            }
                        }
                    }
                    else
                    {
                    }
                }
            }
            else
            {
                MessageBox.Show("Le Logiciel est introuvable, il va être téléchargé depuis notre serveur.");
                using (var client = new WebClient())
                {
                    client.DownloadFile("https://fprogeek.yj.fr/omegasphere/logiciel/fluffy.zip", @"C:\OmegaSphere\Ressources\Logiciel\fluffy.zip");
                    MessageBox.Show("Le logiciel est téléchargé. Il va s'installer puis s'ouvrir.");

                    ExtractZipFile(@"C:\OmegaSphere\Ressources\Logiciel\fluffy.zip", @"C:\OmegaSphere\Ressources\Logiciel");
                    System.Diagnostics.Process.Start("explorer.exe", @"C:\OmegaSphere\Ressources\Logiciel\fluffy\fluffy.exe");
                    File.Delete(@"C:\OmegaSphere\Ressources\Logiciel\fluffy.zip");
                }
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\OmegaSphere\Ressources\Logiciel\switchthemeinjector\SwitchThemes.exe"))
            {
                System.Diagnostics.Process.Start("explorer.exe", @"C:\OmegaSphere\Ressources\Logiciel\switchthemeinjector\SwitchThemes.exe");

                WebClient webClient = new WebClient();
                if (!webClient.DownloadString("https://fprogeek.yj.fr/omegasphere/update/version-switchthemeinjector.txt").Contains("4.2"))
                {

                    if (MessageBox.Show("Une nouvelle version de SwitchThemeInjector est disponible, Voulez vous télécharger la nouvelle version ?", "OmegaSphere Updater", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        using (var client = new WebClient())
                        {
                            client.DownloadFile("https://fprogeek.yj.fr/omegasphere/update/switchthemeinjector_updater.zip", @"C:\OmegaSphere\switchthemeinjector_updater.zip");
                            if (MessageBox.Show("La version est téléchargé, voulez vous l'installer ?", "OmegaSphere Updater", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                using (var update = new WebClient())
                                {
                                    ExtractZipFile(@"C:\OmegaSphere\switchthemeinjector_updater.zip", @"C:\OmegaSphere");
                                    System.Diagnostics.Process.Start("explorer.exe", @"C:\OmegaSphere\Ressources\Logiciel\switchthemeinjector\SwitchThemes.exe");
                                    File.Delete(@"C:\OmegaSphere\switchthemeinjector_updater.zip");
                                }
                            }
                            else
                            {
                            }
                        }
                    }
                    else
                    {
                    }
                }
            }
            else
            {
                MessageBox.Show("Le Logiciel est introuvable, il va être téléchargé depuis notre serveur.");
                using (var client = new WebClient())
                {
                    client.DownloadFile("https://fprogeek.yj.fr/omegasphere/logiciel/switchthemeinjector.zip", @"C:\OmegaSphere\Ressources\Logiciel\switchthemeinjector.zip");
                    MessageBox.Show("Le logiciel est téléchargé. Il va s'installer puis s'ouvrir.");

                    ExtractZipFile(@"C:\OmegaSphere\Ressources\Logiciel\switchthemeinjector.zip", @"C:\OmegaSphere\Ressources\Logiciel");
                    System.Diagnostics.Process.Start("explorer.exe", @"C:\OmegaSphere\Ressources\Logiciel\switchthemeinjector\SwitchThemes.exe");
                    File.Delete(@"C:\OmegaSphere\Ressources\Logiciel\switchthemeinjector.zip");
                }
        }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\OmegaSphere\Ressources\Payload\sxos\OmegaSphere-sxos.bat"))
            {
                System.Diagnostics.Process.Start("explorer.exe", @"C:\OmegaSphere\Ressources\Payload\sxos\OmegaSphere-sxos.bat");
            }
            else
            {
                MessageBox.Show("Le payload est introuvable.");
                // MessageBox.Show("Le payload est introuvable, il va être téléchargé depuis notre serveur.");
                //  using (var client = new WebClient())
                //   {
                //      client.DownloadFile("https://fprogeek.yj.fr/omegasphere/payload/sxos.zip", @"C:\OmegaSphere\Ressources\Payload\sxos.zip");
                //      MessageBox.Show("Le payload est téléchargé. Il va s'installer puis s'ouvrir.");

                //     ExtractZipFile(@"C:\OmegaSphere\Ressources\Payload\sxos.zip", @"C:\OmegaSphere\Ressources\Payload");
                //     System.Diagnostics.Process.Start("explorer.exe", @"C:\OmegaSphere\Ressources\Payload\sxos\OmegaSphere-sxos.bat");
                //     File.Delete(@"C:\OmegaSphere\Ressources\Payload\sxos.zip");
                //  }
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\OmegaSphere\Ressources\Payload\atmosphere\OmegaSphere-atmosphere.bat"))
            {
                System.Diagnostics.Process.Start("explorer.exe", @"C:\OmegaSphere\Ressources\Payload\atmosphere\OmegaSphere-atmosphere.bat");
            }
            else
            {
                MessageBox.Show("Le payload est introuvable");
                // MessageBox.Show("Le payload est introuvable, il va être téléchargé depuis notre serveur.");
                //using (var client = new WebClient())
                //{
                //client.DownloadFile("https://fprogeek.yj.fr/omegasphere/payload/atmosphere.zip", @"C:\OmegaSphere\Ressources\Payload\atmosphere.zip");
                //MessageBox.Show("Le payload est téléchargé. Il va s'installer puis s'ouvrir.");

                //ExtractZipFile(@"C:\OmegaSphere\Ressources\Payload\atmosphere.zip", @"C:\OmegaSphere\Ressources\Payload");
                //System.Diagnostics.Process.Start("explorer.exe", @"C:\OmegaSphere\Ressources\Payload\atmosphere\OmegaSphere-atmosphere.bat");
                //File.Delete(@"C:\OmegaSphere\Ressources\Payload\atmosphere.zip");
                // }
            }
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\OmegaSphere\Ressources\Payload\hekate\OmegaSphere-hekate.bat"))
            {
                System.Diagnostics.Process.Start("explorer.exe", @"C:\OmegaSphere\Ressources\Payload\hekate\OmegaSphere-hekate.bat");
            }
            else
            {
                MessageBox.Show("Le payload est introuvable");
                //MessageBox.Show("Le payload est introuvable, il va être téléchargé depuis notre serveur.");
                //using (var client = new WebClient())
                //{
                //client.DownloadFile("https://fprogeek.yj.fr/omegasphere/payload/hekate.zip", @"C:\OmegaSphere\Ressources\Payload\hekate.zip");
                //MessageBox.Show("Le payload est téléchargé. Il va s'installer puis s'ouvrir.");

                //ExtractZipFile(@"C:\OmegaSphere\Ressources\Payload\hekate.zip", @"C:\OmegaSphere\Ressources\Payload");
                //System.Diagnostics.Process.Start("explorer.exe", @"C:\OmegaSphere\Ressources\Payload\hekate\OmegaSphere-hekate.bat");
                //File.Delete(@"C:\OmegaSphere\Ressources\Payload\hekate.zip");
                // }
            }
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\OmegaSphere\Ressources\Payload\reinx\OmegaSphere-reinx.bat"))
            {
                System.Diagnostics.Process.Start("explorer.exe", @"C:\OmegaSphere\Ressources\Payload\reinx\OmegaSphere-reinx.bat");
            }
            else
            {
                MessageBox.Show("Le payload est introuvable.");
                // MessageBox.Show("Le payload est introuvable, il va être téléchargé depuis notre serveur.");
                // using (var client = new WebClient())
                // {
                //  client.DownloadFile("https://fprogeek.yj.fr/omegasphere/payload/reinx.zip", @"C:\OmegaSphere\Ressources\Payload\reinx.zip");
                //  MessageBox.Show("Le payload est téléchargé. Il va s'installer puis s'ouvrir.");

                // ExtractZipFile(@"C:\OmegaSphere\Ressources\Payload\reinx.zip", @"C:\OmegaSphere\Ressources\Payload");
                // System.Diagnostics.Process.Start("explorer.exe", @"C:\OmegaSphere\Ressources\Payload\reinx\OmegaSphere-reinx.bat");
                // File.Delete(@"C:\OmegaSphere\Ressources\Payload\reinx.zip");
                //}
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void ExtractZipFile(string zipFileLocation, string destination)
        {
            using (Ionic.Zip.ZipFile zip = new Ionic.Zip.ZipFile(zipFileLocation))
            {
                zip.ExtractAll(destination);
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\OmegaSphere\Ressources\Logiciel\nscb\NSCB.bat"))
            {
                System.Diagnostics.Process.Start("explorer.exe", @"C:\OmegaSphere\Ressources\Logiciel\nscb\ztools");
            }
            else
            {
                MessageBox.Show("Le Logiciel est introuvable, il va être téléchargé depuis notre serveur.");
                using (var client = new WebClient())
                {
                    client.DownloadFile("https://fprogeek.yj.fr/omegasphere/logiciel/nscb.zip", @"C:\OmegaSphere\Ressources\Logiciel\nscb.zip");
                    MessageBox.Show("Le logiciel est téléchargé. Il va s'installer puis s'ouvrir.");

                    ExtractZipFile(@"C:\OmegaSphere\Ressources\Logiciel\nscb.zip", @"C:\OmegaSphere\Ressources\Logiciel");
                    System.Diagnostics.Process.Start("explorer.exe", @"C:\OmegaSphere\Ressources\Logiciel\nscb\ztools");
                    File.Delete(@"C:\OmegaSphere\Ressources\Logiciel\nscb.zip");
                }
            }
        }
    }
}
