using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace visualizzatore
{
    public partial class Form1 : Form
    {
        public string[] percorsi;
        public Form1()
        {
            InitializeComponent();
            loadingPicture.ImageLocation = Application.StartupPath + @"\loading.gif";
        }

        private void textRicerca_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                pictureImaggine.Image = null;
                pictureImaggine.SizeMode = PictureBoxSizeMode.Zoom;
                pictureImaggine.Visible = false;
                loadingPicture.SizeMode = PictureBoxSizeMode.Zoom;
                loadingPicture.Visible = true;
                loadingPicture.Dock = DockStyle.Fill;
                labelerrore.Dock = DockStyle.Fill;
                Application.DoEvents();
                bool trovato = false;
                labelerrore.Visible = false;
                foreach (string percorso in percorsi)
                {
                    string[] files = Directory.GetFiles(percorso, "*.*", SearchOption.AllDirectories).OrderByDescending(d => new FileInfo(d).LastWriteTime).ToArray();
                    foreach (string file in files)
                    {//con ToLower() vengono ignorate maiuscole e minuscole
                        if (file.ToLower().Contains(textRicerca.Text.ToLower()) && textRicerca.Text != "")
                        {//le estensioni vanno scritte in minuscolo!
                            if (file.ToLower().EndsWith("jpg") || file.ToLower().EndsWith("bmp") || file.ToLower().EndsWith("png"))
                            {
                                trovato = true;
                                pictureImaggine.Visible = true;
                                pictureImaggine.Dock = DockStyle.Fill;
                                dwgbox.Visible = false;
                                dwgbox.Dock = DockStyle.None;
                                pictureImaggine.ImageLocation = file;
                            }
                            if (file.ToLower().EndsWith("dwg") || file.ToLower().EndsWith("dxf"))
                            {
                                trovato = true;
                                pictureImaggine.Visible = false;
                                pictureImaggine.Dock = DockStyle.None;
                                dwgbox.Visible = true;
                                dwgbox.Dock = DockStyle.Fill;
                                dwgbox.PutSourcePath(file);
                                Application.DoEvents();
                            }
                            break;
                        }
                    }
                    loadingPicture.Visible = false;
                    loadingPicture.Dock = DockStyle.None;
                    labelerrore.Visible = !trovato;
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            dwgbox._Deactivate();
            dwgbox = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string config_file = Application.StartupPath + @"\config.ini";
            if (File.Exists(config_file))//controlla se esiste il file di configurazione 
            {
                int ind = 0;
                string[] lines = System.IO.File.ReadAllLines(config_file);//se c'è lo legge 
                percorsi = lines;
            }

            else
            {//se non trova il file di configurazione 
                MessageBox.Show("Non trovo il file di configurazione: " + config_file);
                textRicerca.Enabled = false;
                textRicerca.Text = "Impostare il file di configurazione";
            }
        }
    }
 }
