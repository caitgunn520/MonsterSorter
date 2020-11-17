using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MonsterSorter
{
    public partial class Form1 : Form
    {
        List<Monster> monsterList = new List<Monster>();
        string typeShown; //Used for Show all [x] buttons

        public Form1()
        {
            InitializeComponent();
            List<string> savedList = File.ReadAllLines("SavedMonsters.txt").ToList();

            for (int i = 0; i < savedList.Count; i += 3) //Writes down each monster in XML file
            {
                string name = savedList[i];
                string type = savedList[i + 1];
                string role = savedList[i + 2];

                Monster newMon = new Monster(name, type, role);
                monsterList.Add(newMon);
            }
        }

        private void addMonsterButton_Click(object sender, EventArgs e) //Adds new monster to list
        {
            if (nameInput.Text != "" && typeInput.Text != "" && roleInput.Text != "") //Checks if all 
                                                                                      //input boxes have
                                                                                      //information
            {
                string monName, monType, monRole;
                int index = monsterList.FindIndex(n => n.name == nameInput.Text);

                if (index == -1) //Checks to make sure monster does not already exist
                {
                    monName = nameInput.Text;
                    monType = (string)typeInput.SelectedItem;
                    monRole = roleInput.Text;

                    Monster newMon = new Monster(monName, monType, monRole);
                    monsterList.Add(newMon);
                    techOutput.Text = $"{monName} successfully added.";
                }
                else //If monster already exists, error message is shown
                {
                    ErrorScreen.ShowError("monExists");
                }
            }
            else //Return error if any input box is empty
            {
                ErrorScreen.ShowError("badInput");
            }
        }

        private void removeMonsterButton_Click(object sender, EventArgs e) //Removes monster from list
        {
            int index = monsterList.FindIndex(n => n.name == nameInput.Text);

            if (index >= 0) //Checks if monster exists
            {
                DialogResult dr = ConfirmScreen.Show(nameInput.Text);

                if (dr == DialogResult.Yes) //Confirms that user wants to delete monster
                {
                    techOutput.Text = $"{nameInput.Text} removed from list.";
                    monsterList.Remove(monsterList[index]);
                }
            }
            else //Returns error if monster does not exist
            {
                ErrorScreen.ShowError("monNotFound");
            }
        }

        private void changeTypeButton_Click(object sender, EventArgs e) //Changes monster type
        {
            int index = monsterList.FindIndex(n => n.name == nameInput.Text);

            if (index >= 0) //Checks to see if monster exists
            {
                if (monsterList[index].type != typeInput.SelectedItem.ToString()) //Checks to see if 
                                                                                  //monster is already 
                                                                                  //the type the user 
                                                                                  //wants to change it 
                                                                                  //to
                {
                    monsterList[index].type = typeInput.SelectedItem.ToString();
                    techOutput.Text = $"{monsterList[index].name}'s type is now " +
                        $"{typeInput.SelectedItem}.";
                }
                else //Returns error if monster is already the type the user wants to change it to
                {
                    ErrorScreen.ShowError("alreadyThatType");
                }
            }
            else //Returns error if monster does not exist
            {
                ErrorScreen.ShowError("monNotFound");
            }
        }

        private void changeRoleButton_Click(object sender, EventArgs e) //Changes monster role
        {
            int index = monsterList.FindIndex(n => n.name == nameInput.Text);

            if (index >= 0) //Checks to see if monster already exists
            {
                if (monsterList[index].role != roleInput.Text) //Checks to see if monster already has 
                                                               //desired role
                {
                    monsterList[index].role = roleInput.Text;
                    techOutput.Text = $"{monsterList[index].name}'s role is now " +
                        $"{roleInput.Text}.";
                }
                else //Returns error if monster already has desired role
                {
                    ErrorScreen.ShowError("alreadyThatRole");
                }
            }
            else //Returns error if monster does not exist
            {
                ErrorScreen.ShowError("monNotFound");
            }
        }

        private void showAllButton_Click(object sender, EventArgs e) //Shows all monsters
        {
            OutputClear();

            for (int i = 0; i < monsterList.Count(); i++) //Writes down each monster w/info
            {
                monsterOutput.Text += $"{monsterList[i].name}\n";
                typeOutput.Text += $"{monsterList[i].type}\n";
                roleOutput.Text += $"{monsterList[i].role}\n";
            }
        }

        private void showEarth_Click(object sender, EventArgs e) //Shows all earth-type monsters
        {
            typeShown = "Earth";
            ShowAllType();
        }

        private void showWater_Click(object sender, EventArgs e) //Shows all water-type monsters
        {
            typeShown = "Water";
            ShowAllType();
        }

        private void showFire_Click(object sender, EventArgs e) //Shows all fire-type monsters
        {
            typeShown = "Fire";
            ShowAllType();
        }

        private void showAir_Click(object sender, EventArgs e) //Shows all air-type monsters
        {
            typeShown = "Air";
            ShowAllType();
        }

        public void ShowAllType() //Shows all monsters of a certain type
        {
            OutputClear();
            
            for (int i = 0; i < monsterList.Count(); i++) //Checks each monster
            {
                if (monsterList[i].type == typeShown) //Writes it down if it is correct type
                {
                    monsterOutput.Text += $"{monsterList[i].name}\n";
                    typeOutput.Text += $"{monsterList[i].type}\n";
                    roleOutput.Text += $"{monsterList[i].role}\n";
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e) //Search for one specific monster
        {
            int index = monsterList.FindIndex(n => n.name == nameInput.Text);

            if (index >= 0) //Checks to see if monster exists
            {
                monsterOutput.Text = $"{monsterList[index].name}";
                typeOutput.Text = $"{monsterList[index].type}";
                roleOutput.Text = $"{monsterList[index].role}";
            }
            else //Returns error if monster doesn't exist
            {
                ErrorScreen.ShowError("monNotFound");
            }
        }

        private void OutputClear() //Clear output textboxes
        {
            monsterOutput.Text = "";
            typeOutput.Text = "";
            roleOutput.Text = "";
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) //Stuff to do when form 
                                                                            //closes
        {
            List<string> saveList = new List<string>();

            foreach (Monster mon in monsterList) //Writes down each monster in XML file
            {
                saveList.Add(mon.name);
                saveList.Add(mon.type);
                saveList.Add(mon.role);
            }

            File.WriteAllLines("SavedMonsters.txt", saveList);
        }

        
    }
}
