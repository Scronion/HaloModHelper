﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace HaloModHelper
{
    public partial class Form1 : Form
    {
        public static string modFile;
        public static string mapFolder;
        public static string backupFolder;
        public static string mapFile;

        public Form1()
        {
            InitializeComponent();
        }

        private void singleMultiSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (singleMultiSelect.SelectedItem.Equals("Singleplayer"))
            {
                singlePlayerMaps.Visible = true;
                multiMaps.Visible = false;
            }
            else
            {
                singlePlayerMaps.Visible = false;
                multiMaps.Visible = true;
            }
        }

        private void multiMaps_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void singlePlayerMaps_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void findHalo3_Click(object sender, EventArgs e)
        {
            halo3Folder.ShowDialog();
            haloFolderBox.Text = halo3Folder.SelectedPath;
        }

        private void findMod_Click(object sender, EventArgs e)
        {
            modFolder.ShowDialog();
            modBox.Text = modFolder.FileName;
        }

        private void halo3Folder_HelpRequest(object sender, EventArgs e)
        {

        }

        private void installMod_Click(object sender, EventArgs e)
        {
            modFile = modBox.Text;
            mapFolder = haloFolderBox.Text + "\\maps\\";
            backupFolder = haloFolderBox.Text + "\\backups\\";
            mapFile = "";

            if (modFile.Equals(""))
            {
                MessageBox.Show("Select a mod to install", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (haloFolderBox.Text.Equals(""))
            {
                MessageBox.Show("Select your Halo 3 install folder", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (singleMultiSelect.SelectedItem.Equals("Singleplayer"))
            {
                switch (singlePlayerMaps.SelectedIndex)
                {
                    case 0:
                        mapFile = "010_jungle.map";
                        break;

                    case 1:
                        mapFile = "020_base.map";
                        break;

                    case 2:
                        mapFile = "030_outskirts.map";
                        break;

                    case 3:
                        mapFile = "040_voi.map";
                        break;

                    case 4:
                        mapFile = "050_floodvoi.map";
                        break;

                    case 5:
                        mapFile = "070_waste.map";
                        break;

                    case 6:
                        mapFile = "100_citadel.map";
                        break;

                    case 7:
                        mapFile = "110_hc.map";
                        break;

                    case 8:
                        mapFile = "120_halo.map";
                        break;
                }
            }
            else
            {
                switch (multiMaps.SelectedIndex)
                {
                    case 0:
                        mapFile = "descent.map";
                        break;

                    case 1:
                        mapFile = "sidewinder.map";
                        break;

                    case 2:
                        mapFile = "lockout.map";
                        break;

                    case 3:
                        mapFile = "fortress.map";
                        break;

                    case 4:
                        mapFile = "chillout.map";
                        break;

                    case 5:
                        mapFile = "construct.map";
                        break;

                    case 6:
                        mapFile = "salvation.map";
                        break;

                    case 7:
                        mapFile = "warehouse.map";
                        break;

                    case 8:
                        mapFile = "ghosttown.map";
                        break;

                    case 9:
                        mapFile = "guardian.map";
                        break;

                    case 10:
                        mapFile = "midship.map";
                        break;

                    case 11:
                        mapFile = "deadlock.map";
                        break;

                    case 12:
                        mapFile = "isolation.map";
                        break;

                    case 13:
                        mapFile = "zanzibar.map";
                        break;

                    case 14:
                        mapFile = "docks.map";
                        break;

                    case 15:
                        mapFile = "chill.map";
                        break;

                    case 16:
                        mapFile = "spacecamp.map";
                        break;

                    case 17:
                        mapFile = "armory.map";
                        break;

                    case 18:
                        mapFile = "sandbox.map";
                        break;

                    case 19:
                        mapFile = "shrine.map";
                        break;

                    case 20:
                        mapFile = "snowbound.map";
                        break;

                    case 21:
                        mapFile = "bunkerworld.map";
                        break;

                    case 22:
                        mapFile = "cyberdyne.map";
                        break;

                    case 23:
                        mapFile = "riverworld.map";
                        break;
                }
            }

            if (mapFile.Equals(""))
            {
                MessageBox.Show("Select what level you are overwriting", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if(backupBox.Checked == true)
            {
                if (!Directory.Exists(backupFolder))
                {
                    Directory.CreateDirectory(backupFolder);
                }

                if(File.Exists(backupFolder + mapFile))
                {
                    var result = MessageBox.Show("WARNING: There is a backup of this map already. Do you want to overwrite the backup?", "Overwriting Backup", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if(result == DialogResult.Yes)
                    {
                        File.Copy(mapFolder + mapFile, backupFolder + mapFile, true);
                    }
                }
                else
                {
                    File.Copy(mapFolder + mapFile, backupFolder + mapFile, true);
                }
            }

            File.Copy(modFile, mapFolder + mapFile, true);

            MessageBox.Show("Mod successfully installed!", " ");
        }

        private void restoreBtn_Click(object sender, EventArgs e)
        {
            modFile = modBox.Text;
            mapFolder = haloFolderBox.Text + "\\maps\\";
            backupFolder = haloFolderBox.Text + "\\backups\\";

            if (!Directory.Exists(backupFolder))
            {
                MessageBox.Show("Cannot find backups folder", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (string backupFile in Directory.GetFiles(backupFolder))
            {
                File.Copy(backupFile, mapFolder + backupFile.Split('\\').Last(), true);
            }

            MessageBox.Show("Mods have been uninstalled!", " ");
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Begin by finding the folder that contains Halo 3. It will look something like this:\n" +
                "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Halo The Master Chief Collection\\halo3\n\n" +
                "Once you've done that, you can restore the backups of your maps by clicking \"Restore Backups\"\n\n" +
                "If you want to install a mod, make sure you selected your halo3 folder from the beginning and then select the mod file under \"Mod file to be installed:\"\n" +
                "then choose what level this mod is replacing and select whether you want to make a backup of the original level first.\n" +
                "Then click \"Install Mod\".", "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}