using System;
using System.Windows.Forms;
using Zeldix.Classes;

namespace Zeldix.Forms
{
    public partial class form_monologue : Form
    {
        private string[] allMonologues;
        private string seperator, copyFilePath;
        private Romio romioObj;
        private CharacterTable chara;
        private string selectedAddress, selectedSize;

        public form_monologue(ref Romio romioObj, string copyFilePath)
        {
            selectedAddress = "";
            selectedSize = "";

            InitializeComponent();
            seperator = ": ";
            chara = new CharacterTable(" = ");

            this.copyFilePath = copyFilePath;
            this.romioObj = romioObj;
        }

        /*
         * If selected item in list has changed, update the textBox editor
         */
        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string textSelect = listBox.SelectedItem.ToString();
                richTextBox_selected.Text = textSelect.Substring(textSelect.IndexOf(seperator) + seperator.Length).Replace("\\n", "\n");
            }
            catch { }
        }
        /*
         * Dump text into textfile
         */
        private void button_dump_Click(object sender, EventArgs e)
        {
            SaveFileDialog FD = new SaveFileDialog();
            FD.Filter = "TXT|*.txt";

            if (FD.ShowDialog() == DialogResult.OK)
            {
                Txtio txt = new Txtio(FD.FileName);
                switch (radioButton_txt.Checked)
                {
                    case true:
                        string output = "";
                        foreach (string s in listBox.Items)
                            output += s + "\n============\n";
                        txt.clear();
                        txt.writeToLine(output.Replace("\\n", "\n\r"));
                        break;
                    case false:
                        txt.clear();
                        txt.writeToLine(romioObj.readInHex(0xE0020, 32500).Replace(" ", "").Replace("\n", ""));
                        break;
                }
            }
        }

        private void button_import_Click(object sender, EventArgs e)
        {

        }

        /*
         * Commit changes to temporary ROM
         */
        private void button_submit_Click(object sender, EventArgs e)
        {
            try
            {
                listBox.Items.Clear();
                selectedAddress = textBox_address.Text;
                selectedSize = textBox_size.Text;


                int 
                    selectedAddressConv = (new MyMath()).hexToDec(textBox_address.Text),
                    selectedSizeConv = (new MyMath()).hexToDec(selectedSize);

                allMonologues = (chara.convertDecimaltoChara(romioObj.readInDecimal(
                    selectedAddressConv, selectedSizeConv))).Split('%');

                int i = 0;
                foreach (string s in allMonologues)
                    listBox.Items.Add(i++ + seperator + s);
            }
            catch (Exception ee) { MessageBox.Show("Error: " + ee); }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox_address.Enabled = textBox_size.Enabled = !radioButton_1.Checked;
            change("E0000", "8000");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox_address.Enabled = textBox_size.Enabled = !radioButton_2.Checked;
            change("75F40", "14C0");
        }

        private void change(string address, string size)
        {
            textBox_address.Text = address;
            textBox_size.Text = size;
        }

        private void radioButton_custom_CheckedChanged(object sender, EventArgs e)
        {
            textBox_address.Enabled = textBox_size.Enabled = radioButton_custom.Checked;
        }

        private void button_set_Click(object sender, EventArgs e)
        {
            try
            {
                int i = listBox.SelectedIndex;
                allMonologues[i] = richTextBox_selected.Text.Replace("\n", "\\n");
                listBox.Items.RemoveAt(i);
                listBox.Items.Insert(i, i + seperator + allMonologues[i]);
                listBox.SetSelected(i, true);
            }
            catch { }
        }

        private void button_save_Click(object sender, EventArgs e)
        {

            try
            {
                string s = romioObj.convertScriptToHex(selectedSize, allMonologues, chara);


                if (romioObj.writeToROM(selectedAddress, selectedSize, s, copyFilePath))
                    MessageBox.Show("Saved");
                else MessageBox.Show("Not saved");
            }
            catch (Exception ee)  { MessageBox.Show("Not saved due to error:" + ee); }
        }

        private void button_values_Click(object sender, EventArgs e)
        { chara.displayCharacterTable(); }
    }
}
