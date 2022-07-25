
namespace HaloModHelper
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.singleMultiSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.multiMaps = new System.Windows.Forms.ComboBox();
            this.singlePlayerMaps = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.haloFolderBox = new System.Windows.Forms.TextBox();
            this.findHalo3 = new System.Windows.Forms.Button();
            this.modBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.findMod = new System.Windows.Forms.Button();
            this.installMod = new System.Windows.Forms.Button();
            this.modFolder = new System.Windows.Forms.OpenFileDialog();
            this.halo3Folder = new System.Windows.Forms.FolderBrowserDialog();
            this.backupBox = new System.Windows.Forms.CheckBox();
            this.restoreBtn = new System.Windows.Forms.Button();
            this.helpBtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.versionNum = new System.Windows.Forms.ToolStripStatusLabel();
            this.updateFail = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // singleMultiSelect
            // 
            this.singleMultiSelect.FormattingEnabled = true;
            this.singleMultiSelect.Items.AddRange(new object[] {
            "Multiplayer",
            "Singleplayer"});
            this.singleMultiSelect.Location = new System.Drawing.Point(149, 64);
            this.singleMultiSelect.Name = "singleMultiSelect";
            this.singleMultiSelect.Size = new System.Drawing.Size(121, 21);
            this.singleMultiSelect.TabIndex = 0;
            this.singleMultiSelect.Text = "Multiplayer";
            this.singleMultiSelect.SelectedIndexChanged += new System.EventHandler(this.singleMultiSelect_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Single/Multi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Level:";
            // 
            // multiMaps
            // 
            this.multiMaps.FormattingEnabled = true;
            this.multiMaps.Items.AddRange(new object[] {
            "Assembly",
            "Avalanche",
            "Blackout",
            "Citadel",
            "Cold Storage",
            "Construct",
            "Epitaph",
            "Foundry",
            "Ghost Town",
            "Guardian",
            "Heretic",
            "High Ground",
            "Isolation",
            "Last Resort",
            "Longshore",
            "Narrows",
            "Orbital",
            "Rats Nest",
            "Sandbox",
            "Sandtrap",
            "Snowbound",
            "Standoff",
            "The Pit",
            "Valhalla"});
            this.multiMaps.Location = new System.Drawing.Point(149, 91);
            this.multiMaps.Name = "multiMaps";
            this.multiMaps.Size = new System.Drawing.Size(121, 21);
            this.multiMaps.TabIndex = 2;
            // 
            // singlePlayerMaps
            // 
            this.singlePlayerMaps.FormattingEnabled = true;
            this.singlePlayerMaps.Items.AddRange(new object[] {
            "Sierra 117",
            "Crows Nest",
            "Tsavo Highway",
            "The Storm",
            "Floodgate",
            "The Ark",
            "The Covenant",
            "Cortana",
            "Halo"});
            this.singlePlayerMaps.Location = new System.Drawing.Point(149, 91);
            this.singlePlayerMaps.Name = "singlePlayerMaps";
            this.singlePlayerMaps.Size = new System.Drawing.Size(121, 21);
            this.singlePlayerMaps.TabIndex = 4;
            this.singlePlayerMaps.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Location of \"halo3\" folder:";
            // 
            // haloFolderBox
            // 
            this.haloFolderBox.Location = new System.Drawing.Point(149, 12);
            this.haloFolderBox.Name = "haloFolderBox";
            this.haloFolderBox.Size = new System.Drawing.Size(558, 20);
            this.haloFolderBox.TabIndex = 6;
            this.haloFolderBox.TextChanged += new System.EventHandler(this.haloFolderBox_TextChanged);
            // 
            // findHalo3
            // 
            this.findHalo3.Location = new System.Drawing.Point(713, 10);
            this.findHalo3.Name = "findHalo3";
            this.findHalo3.Size = new System.Drawing.Size(75, 23);
            this.findHalo3.TabIndex = 7;
            this.findHalo3.Text = "Open";
            this.findHalo3.UseVisualStyleBackColor = true;
            this.findHalo3.Click += new System.EventHandler(this.findHalo3_Click);
            // 
            // modBox
            // 
            this.modBox.Location = new System.Drawing.Point(149, 38);
            this.modBox.Name = "modBox";
            this.modBox.Size = new System.Drawing.Size(558, 20);
            this.modBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mod file to be installed:";
            // 
            // findMod
            // 
            this.findMod.Location = new System.Drawing.Point(713, 36);
            this.findMod.Name = "findMod";
            this.findMod.Size = new System.Drawing.Size(75, 23);
            this.findMod.TabIndex = 10;
            this.findMod.Text = "Open";
            this.findMod.UseVisualStyleBackColor = true;
            this.findMod.Click += new System.EventHandler(this.findMod_Click);
            // 
            // installMod
            // 
            this.installMod.Location = new System.Drawing.Point(276, 64);
            this.installMod.Name = "installMod";
            this.installMod.Size = new System.Drawing.Size(138, 48);
            this.installMod.TabIndex = 11;
            this.installMod.Text = "Install Mod";
            this.installMod.UseVisualStyleBackColor = true;
            this.installMod.Click += new System.EventHandler(this.installMod_Click);
            // 
            // modFolder
            // 
            this.modFolder.Filter = "Halo Map File|*.map";
            // 
            // halo3Folder
            // 
            this.halo3Folder.Description = "Select your halo3 folder in your Halo: MCC folder";
            this.halo3Folder.ShowNewFolderButton = false;
            // 
            // backupBox
            // 
            this.backupBox.AutoSize = true;
            this.backupBox.Checked = true;
            this.backupBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.backupBox.Location = new System.Drawing.Point(149, 119);
            this.backupBox.Name = "backupBox";
            this.backupBox.Size = new System.Drawing.Size(138, 17);
            this.backupBox.TabIndex = 12;
            this.backupBox.Text = "Backup original map file";
            this.backupBox.UseVisualStyleBackColor = true;
            // 
            // restoreBtn
            // 
            this.restoreBtn.Location = new System.Drawing.Point(563, 64);
            this.restoreBtn.Name = "restoreBtn";
            this.restoreBtn.Size = new System.Drawing.Size(144, 48);
            this.restoreBtn.TabIndex = 13;
            this.restoreBtn.Text = "Restore Backups";
            this.restoreBtn.UseVisualStyleBackColor = true;
            this.restoreBtn.Click += new System.EventHandler(this.restoreBtn_Click);
            // 
            // helpBtn
            // 
            this.helpBtn.Location = new System.Drawing.Point(524, 154);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(264, 23);
            this.helpBtn.TabIndex = 14;
            this.helpBtn.Text = "Help! I\'m retarded and don\'t know what to do!";
            this.helpBtn.UseVisualStyleBackColor = true;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionNum,
            this.updateFail});
            this.statusStrip1.Location = new System.Drawing.Point(0, 193);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // versionNum
            // 
            this.versionNum.Name = "versionNum";
            this.versionNum.Size = new System.Drawing.Size(0, 17);
            // 
            // updateFail
            // 
            this.updateFail.Name = "updateFail";
            this.updateFail.Size = new System.Drawing.Size(0, 17);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 215);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.restoreBtn);
            this.Controls.Add(this.backupBox);
            this.Controls.Add(this.installMod);
            this.Controls.Add(this.findMod);
            this.Controls.Add(this.modBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.findHalo3);
            this.Controls.Add(this.haloFolderBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.singlePlayerMaps);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.multiMaps);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.singleMultiSelect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 254);
            this.MinimumSize = new System.Drawing.Size(816, 254);
            this.Name = "MainWindow";
            this.Text = "Halo Mod Helper";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox singleMultiSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox multiMaps;
        private System.Windows.Forms.ComboBox singlePlayerMaps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox haloFolderBox;
        private System.Windows.Forms.Button findHalo3;
        private System.Windows.Forms.TextBox modBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button findMod;
        private System.Windows.Forms.Button installMod;
        private System.Windows.Forms.OpenFileDialog modFolder;
        private System.Windows.Forms.FolderBrowserDialog halo3Folder;
        private System.Windows.Forms.CheckBox backupBox;
        private System.Windows.Forms.Button restoreBtn;
        private System.Windows.Forms.Button helpBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel versionNum;
        private System.Windows.Forms.ToolStripStatusLabel updateFail;
    }
}

