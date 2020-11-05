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

        public static DialogResult Show()
        {
            confirmScreen = new ConfirmScreen();

            confirmScreen.ShowDialog();
            return deleteTrue;
        }
    }
}
