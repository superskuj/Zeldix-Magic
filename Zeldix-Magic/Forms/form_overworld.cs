using System.Collections.Generic;
using System.Windows.Forms;
using Zeldix.Classes;

namespace Zeldix.Forms
{
    public partial class form_overworld : Form
    {
        string filePath;

        public form_overworld(string filePath)
        {
            InitializeComponent();
            this.filePath = filePath;
        }

        private void textBox_room_id_TextChanged(object sender, System.EventArgs e)
        {
            
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (textBox_room_id.Text.Equals("00"))
            {
                Romio obj = new Romio(filePath);

                label_map.Text = obj.readInDecimal(0x8008, 800);
            }
            else
                label_map.Text = "N/A";
        }
    }
}
