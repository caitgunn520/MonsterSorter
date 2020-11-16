namespace MonsterSorter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.typeInput = new System.Windows.Forms.ListBox();
            this.addMonsterButton = new System.Windows.Forms.Button();
            this.removeMonsterButton = new System.Windows.Forms.Button();
            this.changeTypeButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.monsterOutput = new System.Windows.Forms.Label();
            this.showAllButton = new System.Windows.Forms.Button();
            this.showEarth = new System.Windows.Forms.Button();
            this.showWater = new System.Windows.Forms.Button();
            this.showFire = new System.Windows.Forms.Button();
            this.showAir = new System.Windows.Forms.Button();
            this.typeOutput = new System.Windows.Forms.Label();
            this.roleOutput = new System.Windows.Forms.Label();
            this.techOutput = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.roleInput = new System.Windows.Forms.TextBox();
            this.changeRoleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monster Name";
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(125, 51);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(115, 20);
            this.nameInput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Monster Type";
            // 
            // typeInput
            // 
            this.typeInput.FormattingEnabled = true;
            this.typeInput.Items.AddRange(new object[] {
            "Earth",
            "Water",
            "Fire",
            "Air"});
            this.typeInput.Location = new System.Drawing.Point(125, 105);
            this.typeInput.Name = "typeInput";
            this.typeInput.Size = new System.Drawing.Size(120, 56);
            this.typeInput.TabIndex = 3;
            // 
            // addMonsterButton
            // 
            this.addMonsterButton.Location = new System.Drawing.Point(37, 270);
            this.addMonsterButton.Name = "addMonsterButton";
            this.addMonsterButton.Size = new System.Drawing.Size(85, 23);
            this.addMonsterButton.TabIndex = 4;
            this.addMonsterButton.Text = "Add Monster";
            this.addMonsterButton.UseVisualStyleBackColor = true;
            this.addMonsterButton.Click += new System.EventHandler(this.addMonsterButton_Click);
            // 
            // removeMonsterButton
            // 
            this.removeMonsterButton.Location = new System.Drawing.Point(142, 269);
            this.removeMonsterButton.Name = "removeMonsterButton";
            this.removeMonsterButton.Size = new System.Drawing.Size(98, 23);
            this.removeMonsterButton.TabIndex = 5;
            this.removeMonsterButton.Text = "Remove Monster";
            this.removeMonsterButton.UseVisualStyleBackColor = true;
            this.removeMonsterButton.Click += new System.EventHandler(this.removeMonsterButton_Click);
            // 
            // changeTypeButton
            // 
            this.changeTypeButton.Location = new System.Drawing.Point(37, 299);
            this.changeTypeButton.Name = "changeTypeButton";
            this.changeTypeButton.Size = new System.Drawing.Size(85, 38);
            this.changeTypeButton.TabIndex = 6;
            this.changeTypeButton.Text = "Change Monster Type";
            this.changeTypeButton.UseVisualStyleBackColor = true;
            this.changeTypeButton.Click += new System.EventHandler(this.changeTypeButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(142, 224);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(98, 39);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Search for Monster";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // monsterOutput
            // 
            this.monsterOutput.BackColor = System.Drawing.Color.White;
            this.monsterOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.monsterOutput.Location = new System.Drawing.Point(328, 51);
            this.monsterOutput.Name = "monsterOutput";
            this.monsterOutput.Size = new System.Drawing.Size(92, 286);
            this.monsterOutput.TabIndex = 8;
            // 
            // showAllButton
            // 
            this.showAllButton.Location = new System.Drawing.Point(328, 349);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(115, 23);
            this.showAllButton.TabIndex = 9;
            this.showAllButton.Text = "Show All Monsters";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // showEarth
            // 
            this.showEarth.Location = new System.Drawing.Point(328, 378);
            this.showEarth.Name = "showEarth";
            this.showEarth.Size = new System.Drawing.Size(137, 23);
            this.showEarth.TabIndex = 10;
            this.showEarth.Text = "Show Earth Monsters";
            this.showEarth.UseVisualStyleBackColor = true;
            this.showEarth.Click += new System.EventHandler(this.showEarth_Click);
            // 
            // showWater
            // 
            this.showWater.Location = new System.Drawing.Point(471, 378);
            this.showWater.Name = "showWater";
            this.showWater.Size = new System.Drawing.Size(133, 23);
            this.showWater.TabIndex = 11;
            this.showWater.Text = "Show Water Monsters";
            this.showWater.UseVisualStyleBackColor = true;
            this.showWater.Click += new System.EventHandler(this.showWater_Click);
            // 
            // showFire
            // 
            this.showFire.Location = new System.Drawing.Point(328, 407);
            this.showFire.Name = "showFire";
            this.showFire.Size = new System.Drawing.Size(137, 23);
            this.showFire.TabIndex = 12;
            this.showFire.Text = "Show Fire Monsters";
            this.showFire.UseVisualStyleBackColor = true;
            this.showFire.Click += new System.EventHandler(this.showFire_Click);
            // 
            // showAir
            // 
            this.showAir.Location = new System.Drawing.Point(471, 407);
            this.showAir.Name = "showAir";
            this.showAir.Size = new System.Drawing.Size(133, 23);
            this.showAir.TabIndex = 13;
            this.showAir.Text = "Show Air Monsters";
            this.showAir.UseVisualStyleBackColor = true;
            this.showAir.Click += new System.EventHandler(this.showAir_Click);
            // 
            // typeOutput
            // 
            this.typeOutput.BackColor = System.Drawing.Color.White;
            this.typeOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.typeOutput.Location = new System.Drawing.Point(418, 51);
            this.typeOutput.Name = "typeOutput";
            this.typeOutput.Size = new System.Drawing.Size(95, 286);
            this.typeOutput.TabIndex = 14;
            // 
            // roleOutput
            // 
            this.roleOutput.BackColor = System.Drawing.Color.White;
            this.roleOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roleOutput.Location = new System.Drawing.Point(512, 51);
            this.roleOutput.Name = "roleOutput";
            this.roleOutput.Size = new System.Drawing.Size(92, 286);
            this.roleOutput.TabIndex = 15;
            // 
            // techOutput
            // 
            this.techOutput.Location = new System.Drawing.Point(34, 359);
            this.techOutput.Name = "techOutput";
            this.techOutput.Size = new System.Drawing.Size(206, 61);
            this.techOutput.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Monster Role";
            // 
            // roleInput
            // 
            this.roleInput.Location = new System.Drawing.Point(125, 194);
            this.roleInput.Name = "roleInput";
            this.roleInput.Size = new System.Drawing.Size(120, 20);
            this.roleInput.TabIndex = 18;
            // 
            // changeRoleButton
            // 
            this.changeRoleButton.Location = new System.Drawing.Point(142, 301);
            this.changeRoleButton.Name = "changeRoleButton";
            this.changeRoleButton.Size = new System.Drawing.Size(98, 36);
            this.changeRoleButton.TabIndex = 19;
            this.changeRoleButton.Text = "Change Monster Role";
            this.changeRoleButton.UseVisualStyleBackColor = true;
            this.changeRoleButton.Click += new System.EventHandler(this.changeRoleButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.changeRoleButton);
            this.Controls.Add(this.roleInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.techOutput);
            this.Controls.Add(this.roleOutput);
            this.Controls.Add(this.typeOutput);
            this.Controls.Add(this.showAir);
            this.Controls.Add(this.showFire);
            this.Controls.Add(this.showWater);
            this.Controls.Add(this.showEarth);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.monsterOutput);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.changeTypeButton);
            this.Controls.Add(this.removeMonsterButton);
            this.Controls.Add(this.addMonsterButton);
            this.Controls.Add(this.typeInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Monster Sorter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox typeInput;
        private System.Windows.Forms.Button addMonsterButton;
        private System.Windows.Forms.Button removeMonsterButton;
        private System.Windows.Forms.Button changeTypeButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label monsterOutput;
        private System.Windows.Forms.Button showAllButton;
        private System.Windows.Forms.Button showEarth;
        private System.Windows.Forms.Button showWater;
        private System.Windows.Forms.Button showFire;
        private System.Windows.Forms.Button showAir;
        private System.Windows.Forms.Label typeOutput;
        private System.Windows.Forms.Label roleOutput;
        private System.Windows.Forms.Label techOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox roleInput;
        private System.Windows.Forms.Button changeRoleButton;
    }
}

