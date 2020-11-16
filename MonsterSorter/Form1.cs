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

            for (int i = 0; i < savedList.Count; i += 3)
            {
                string name = savedList[i];
                string type = savedList[i + 1];
                string role = savedList[i + 2];

                Monster newMon = new Monster(name, type, role);
                monsterList.Add(newMon);
            }
        }

        private void addMonsterButton_Click(object sender, EventArgs e)
        {
            if (nameInput.Text != "" && typeInput.Text != "" && roleInput.Text != "")
            { 
                string monName, monType, monRole;
                int index = monsterList.FindIndex(n => n.name == nameInput.Text);

                if (index == -1)
                {
                    monName = nameInput.Text;
                    monType = (string)typeInput.SelectedItem;
                    monRole = roleInput.Text;

                    Monster newMon = new Monster(monName, monType, monRole);
                    monsterList.Add(newMon);
                    techOutput.Text = $"{monName} successfully added.";
                }
                else
                {
                    ErrorScreen.ShowError("monExists");
                }
            }
            else
            {
                ErrorScreen.ShowError("badInput");
            }
        }

        private void removeMonsterButton_Click(object sender, EventArgs e)
        {
            int index = monsterList.FindIndex(n => n.name == nameInput.Text);

            if (index >= 0)
            {
                DialogResult dr = ConfirmScreen.Show(nameInput.Text);
                
                if (dr == DialogResult.Yes)
                {
                    techOutput.Text = $"{nameInput.Text} removed from list.";
                    monsterList.Remove(monsterList[index]);
                }
            }
            else
            {
                ErrorScreen.ShowError("monNotFound");
            }
        }

        private void changeTypeButton_Click(object sender, EventArgs e)
        {
            int index = monsterList.FindIndex(n => n.name == nameInput.Text);

            if (index >= 0)
            {
                if (monsterList[index].type != typeInput.SelectedItem.ToString())
                {
                    monsterList[index].type = typeInput.SelectedItem.ToString();
                    techOutput.Text = $"{monsterList[index].name}'s type is now " +
                        $"{typeInput.SelectedItem}.";
                }
                else
                {
                    ErrorScreen.ShowError("alreadyThatType");
                }
            }
            else
            {
                ErrorScreen.ShowError("monNotFound");
            }
        }

        private void changeRoleButton_Click(object sender, EventArgs e)
        {
            int index = monsterList.FindIndex(n => n.name == nameInput.Text);

            if (index >= 0)
            {
                if (monsterList[index].role != roleInput.Text)
                {
                    monsterList[index].role = roleInput.Text;
                    techOutput.Text = $"{monsterList[index].name}'s role is now " +
                        $"{roleInput.Text}.";
                }
                else
                {
                    ErrorScreen.ShowError("alreadyThatRole");
                }
            }
            else
            {
                ErrorScreen.ShowError("monNotFound");
            }
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            OutputClear();

            for (int i = 0; i < monsterList.Count(); i++)
            {
                monsterOutput.Text += $"{monsterList[i].name}\n";
                typeOutput.Text += $"{monsterList[i].type}\n";
                roleOutput.Text += $"{monsterList[i].role}\n";
            }
        }

        private void showEarth_Click(object sender, EventArgs e)
        {
            typeShown = "Earth";
            ShowAllType();
        }

        private void showWater_Click(object sender, EventArgs e)
        {
            typeShown = "Water";
            ShowAllType();
        }

        private void showFire_Click(object sender, EventArgs e)
        {
            typeShown = "Fire";
            ShowAllType();
        }

        private void showAir_Click(object sender, EventArgs e)
        {
            typeShown = "Air";
            ShowAllType();
        }

        public void ShowAllType()
        {
            OutputClear();
            
            for (int i = 0; i < monsterList.Count(); i++)
            {
                if (monsterList[i].type == typeShown)
                {
                    monsterOutput.Text += $"{monsterList[i].name}\n";
                    typeOutput.Text += $"{monsterList[i].type}\n";
                    roleOutput.Text += $"{monsterList[i].role}\n";
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int index = monsterList.FindIndex(n => n.name == nameInput.Text);

            if (index >= 0)
            {
                monsterOutput.Text = $"{monsterList[index].name}";
                typeOutput.Text = $"{monsterList[index].type}";
                roleOutput.Text = $"{monsterList[index].role}";
            }
            else
            {
                ErrorScreen.ShowError("monNotFound");
            }
        }

        private void OutputClear()
        {
            monsterOutput.Text = "";
            typeOutput.Text = "";
            roleOutput.Text = "";
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            List<string> saveList = new List<string>();

            foreach (Monster mon in monsterList)
            {
                saveList.Add(mon.name);
                saveList.Add(mon.type);
                saveList.Add(mon.role);
            }

            File.WriteAllLines("SavedMonsters.txt", saveList);
        }

        
    }
}
