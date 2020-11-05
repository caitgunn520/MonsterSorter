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
    public partial class ErrorScreen : Form
    {
        private static ErrorScreen errorScreen;

        public ErrorScreen()
        {
            InitializeComponent();
        }

        public static void ShowError(string errorReason)
        {
            errorScreen = new ErrorScreen();
            
            switch (errorReason)
            {
                case "badInput":
                    errorScreen.errorOutput.Text = "Please fill in all forms properly.";
                    break;
                case "monExists":
                    errorScreen.errorOutput.Text = "The monster you are trying to add " +
                        "already exists.";
                    break;
                case "monNotFound":
                    errorScreen.errorOutput.Text = "That monster is not in the database.";
                    break;
                case "alreadyThatType":
                    errorScreen.errorOutput.Text = "The monster you are trying to edit " +
                        "is already that type.";
                    break;
                default:
                    errorScreen.errorOutput.Text = "You shouldn't be receiving this " +
                        "message.";
                    break;
            }

            errorScreen.ShowDialog();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            errorScreen.Close();
        }
    }
}
