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
    public partial class Form1 : Form
    {
        List<Monster> monsterList = new List<Monster>();

        public Form1()
        {
            InitializeComponent();
            //Read xml file “Saved Monsters”
            //For each 2 lines in xml file “Saved Monsters”
            //Create new monster
            //Name = line 1
            //Type = line 2
            //Add new monster to global list “Monsters”
        }

        private void addMonsterButton_Click(object sender, EventArgs e)
        {
            if (nameInput.Text != "" && typeInput.Text != "")
            { 
                string monName, monType;

                monName = nameInput.Text;
                monType = (string)typeInput.SelectedItem;

                Monster newMon = new Monster(monName, monType);
                monsterList.Add(newMon);
            }
            else
            {
                monsterOutput.Text = "Invalid Input.";
            }
        }

        private void removeMonsterButton_Click(object sender, EventArgs e)
        {
            int index = monsterList.FindIndex(n => n.name == nameInput.Text);

            if (index >= 0)
            {
                //Return confirmation box - “Are you sure you want to 
                //delete [monster name]?
                //If yes Delete that monster
            }
            else
            {
                monsterOutput.Text = "Monster not found.";
            }
        }

        private void changeTypeButton_Click(object sender, EventArgs e)
        {
            int index = monsterList.FindIndex(n => n.name == nameInput.Text);

            if (index >= 0)
            {
                if ()
                {

                }
            }
            
            //TODO If monster with same name as input in name box exists
            //and If monster has different type than input in type box
            //Change monster type to input in type box
            //Else
            //Return error message - “Monster is already that type”
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            //For each object in global list “Monsters”
            //Display object on output screen
        }

        private void showEarth_Click(object sender, EventArgs e)
        {
            //For each object in global list “Monsters”
            //If type = [x]
            //Display object on output screen
        }

        private void showWater_Click(object sender, EventArgs e)
        {
            //For each object in global list “Monsters”
            //If type = [x]
            //Display object on output screen
        }

        private void showFire_Click(object sender, EventArgs e)
        {
            //For each object in global list “Monsters”
            //If type = [x]
            //Display object on output screen
        }

        private void showAir_Click(object sender, EventArgs e)
        {
            //For each object in global list “Monsters”
            //If type = [x]
            //Display object on output screen
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //Search global list “Monsters” for monster with same name as name input box
            //If monster exists
            //Display monster attributes in output
            //Else
            //Return error message - “Monster not found”
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //TODO Save all objects in global list “Monsters” to xml file “Saved Monsters”
        }
    }
}
