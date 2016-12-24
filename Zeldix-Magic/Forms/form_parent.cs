using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Zeldix.Classes;
using Zeldix.Forms;

namespace Zeldix
{
    public partial class form_parent : Form
    {
        private string realFilePath, copyFilePath, backBone;

        private Romio rom;
        public form_parent()
        { InitializeComponent(); }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        { toolStripLabel_window.Enabled = openFile(); }

        private bool openFile()
        {
            bool pass = false;
            OpenFileDialog FD = new OpenFileDialog();
            FD.Filter = "SFC|*.sfc|SMC|*.smc";

            if (FD.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    backBone = "../../Resources/";
                    realFilePath = FD.FileName;
                    copyFilePath = backBone + Path.GetFileName(realFilePath);

                    rom = new Romio(realFilePath, ref pass);
                    File.Copy(realFilePath, copyFilePath, true);

                    pass = true;
                }

                catch (IOException)
                {
                    MessageBox.Show("Don't open your ROM in the resources folder.");
                    pass = false;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e + "Error");
                    pass = false;
                }

            }
            return pass;
        }

        private void close()
        { this.Close(); }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        { close(); }

        private void form_parent_FormClosed(object sender, FormClosedEventArgs e)
        { close(); }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.WindowsShutDown)
                return;

            // Confirm user wants to close
            switch (MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    File.Delete(copyFilePath);
                    break;
                default:
                    Process.GetCurrentProcess().Kill();
                    break;
            }
        }
        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_overworld frm = new form_overworld(realFilePath);
            frm.MdiParent = this;
            frm.Show();
        }

        private void monologuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_monologue frm = new form_monologue(ref rom, copyFilePath);
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripLabel_file_Click(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(copyFilePath);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                File.Copy(copyFilePath, realFilePath, true);
                MessageBox.Show("Saved.", "Save");
            }
            catch { }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is an about message. Text goes here.", "About");
        }
    }
}
