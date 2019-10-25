using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisztracioAlkalmazas
{
    public partial class Regisztracio : Form
    {
        public Regisztracio()
        {
            InitializeComponent();
            saveFileDialogMentes.FileOk += (senderFile, eFile) =>
            {
                try
                {
                    string fileName = saveFileDialogMentes.FileName;
                    using (var sw = new StreamWriter(fileName))
                    {
                        sw.WriteLine(NevBox.Text);
                        sw.WriteLine(DatumBox.Text);
                        string nem;
                        if (FerfiRadioButton.Checked)
                        {
                            nem = "férfi";
                        }
                        else if (MuskatliRadioButton.Checked)
                        {
                            nem = "muskátli";
                        }
                        else
                        {
                            nem = "nő";
                        }
                        sw.WriteLine(nem);
                        sw.WriteLine(HobbiListBox.SelectedItem);
                        sw.Close();
                    }

                }
                catch (IOException)
                {
                    MessageBox.Show("Hiba");
                }
            };

            openFileDialogNyitas.FileOk += (senderFile, e) =>
            {
                try
                {
                    string[] sorok = File.ReadAllLines(openFileDialogNyitas.FileName);
                    NevBox.Text = sorok[0];
                    DatumBox.Text = sorok[1];
                    if (sorok[2] == "férfi")
                    {
                        FerfiRadioButton.Checked = true;
                        NoRadioButton.Checked = false;
                        MuskatliRadioButton.Checked = false;
                    }
                    else if (sorok[2] == "nő")
                    {
                        NoRadioButton.Checked = true;
                        MuskatliRadioButton.Checked = false;
                        FerfiRadioButton.Checked = false;
                    }
                    else
                    {
                        MuskatliRadioButton.Checked = true;
                        NoRadioButton.Checked = false;
                        FerfiRadioButton.Checked = false;
                    }
                    string elem;
                    if (!HobbiListBox.Items.Contains(sorok[3]))
                    {
                        HobbiListBox.Items.Add(sorok[3]);
                        HobbiListBox.SelectedItem = sorok[3];
                    }
                    else
                    {
                        foreach (var item in sorok)
                        {
                            if (item == sorok[3])
                            {
                                HobbiListBox.SelectedItem.Equals(item);
                            }
                        }
                    }
                }
                catch (IOException)
                {
                    MessageBox.Show("Hiba");
                }
            };
        }




        private void HobbiListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HozzaadButton_Click(object sender, EventArgs e)
        {
            HobbiListBox.Items.Add(HobbiBox);
        }

        private void openFileDialogNyitas_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void saveFileDialogMentes_FileOk(object sender, CancelEventArgs e)
        {

        }
    }

    




}

