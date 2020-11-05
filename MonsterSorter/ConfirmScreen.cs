using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonsterSorter
{
    public partial class ConfirmScreen : Form
    {
        private static ConfirmScreen confirmScreen;
        private static DialogResult deleteTrue = new DialogResult();

        public ConfirmScreen()
        {
            InitializeComponent();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            deleteTrue = DialogResult.Yes;
            confirmScreen.Close();
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            deleteTrue = DialogResult.Cancel;
            confirmScreen.Close();
        }

        public static DialogResult Show(string monName)
        {
            confirmScreen = new ConfirmScreen();

            confirmScreen.confirmText.Text = $"Are you sure you want to delete {monName}?";
            confirmScreen.ShowDialog();
            return deleteTrue;
        }
    }
}
