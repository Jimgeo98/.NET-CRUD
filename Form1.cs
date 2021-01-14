using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace application
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            updateform();
        }

        void updateform()
        {
            btn_add.Enabled = !String.IsNullOrWhiteSpace(TextBox.Text);
            btn_delete.Enabled = (ListBox.Items.Count > 0) && (ListBox.SelectedIndex >= 0);
            btn_update.Enabled = (ListBox.Items.Count > 0) && (ListBox.SelectedIndex >= 0);
            btn_clear.Enabled = (ListBox.Items.Count > 0);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            ListBox.Items.Add(TextBox.Text);
            TextBox.Clear();
            updateform();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            btn_add.Enabled = !String.IsNullOrWhiteSpace(TextBox.Text);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            ListBox.Items.RemoveAt(ListBox.SelectedIndex);
            updateform();
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateform();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            ListBox.Items.Insert(ListBox.SelectedIndex, TextBox.Text);
            ListBox.Items.RemoveAt(ListBox.SelectedIndex);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ListBox.Items.Clear();
            updateform();
        }
    }
}
