using System;
using System.IO;
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
                    string[] adatok = File.ReadAllLines(openFileDialogNyitas.FileName);
                    NevBox.Text = adatok[0];
                    DatumBox.Text = adatok[1];
                    if (adatok[2] == "férfi")
                    {
                        FerfiRadioButton.Checked = true;
                        NoRadioButton.Checked = false;
                        MuskatliRadioButton.Checked = false;
                    }
                    else if (adatok[2] == "nő")
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
                    if (!HobbiListBox.Items.Contains(adatok[3])) // "!" ez egy tagadó feltétel
                    {
                        HobbiListBox.Items.Add(adatok[3]);
                        HobbiListBox.SelectedItem = adatok[3]; //Itt elhasalhat a kód, ha a lentebbi hiba él
                    }
                    else if (HobbiListBox.Items.Contains(adatok[3]))
                    {
                        HobbiListBox.SelectedItem = adatok[3]; //Ha a listában van, akkor arra ugrik
                    }
                    /**
                     * !!Ez a bug egyszer csak megszűnt a sokadik lefuttatás után, nem tudom miért. Lehet feature lett belőle :)!!
                     * Betöltésre hibát dob ismeretlen okból.
                     * A hiba nem jelentkezik ha először mentünk, aztán bezárás nélkül betöltünk                   
                     */
                    else
                    {
                        foreach (var item in adatok)
                        {
                            if (item == adatok[3])
                            {
                                HobbiListBox.SelectedItem.Equals(item);  //<--- "Hiba" (Megszünt random)
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
        private void HozzaadButton_Click(object sender, EventArgs e)
        {
            HobbiListBox.Items.Add(HobbiBox.Text);
        }

        private void HobbiBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                HobbiListBox.Items.Add(HobbiBox.Text + "");
            }
        }

        private void MentesButton_Click(object sender, EventArgs e)
        {
            if (NevBox.Text != "" && DatumBox.Text != "" && HobbiListBox.SelectedIndex != -1 &&
                (FerfiRadioButton.Checked || NoRadioButton.Checked || MuskatliRadioButton.Checked))
            {
                saveFileDialogMentes.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nem töltöttél ki minden mezőt!");
            }
        }

        private void BetoltesButton_Click(object sender, EventArgs e)
        {
            openFileDialogNyitas.ShowDialog();
        }
    }






}

