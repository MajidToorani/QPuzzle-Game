using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using MtooranisamaAssignment2;

// QPuzzle Game
// Assignment 2
//    
// Majid Tooranisama
// 04/11/2018
//
// Revision history
//  16/09/2018    Created
//  16/09/2018    UI Designed
//  29/09/2018    Bug Fixed

namespace MTooranisamaAssignment2
{
    // A class of pictureboxes for creating levels of QPuzzle game
    public partial class MazeDesignerForm : Form
    {
        private const int STARTX = 200;
        private const int STARTY = 100;
        private const int BLOCKWIDTH = 40;
        private const int BLOCKHEIGHT = 40;
        private Block [,] pb;
        currentBox currentBlock;

        public MazeDesignerForm()
        {
            InitializeComponent();
        }
        // The click event handler for the None button
        private void buttonNone_Click(object sender, EventArgs e)
        {
            currentBlock = currentBox.NONE;
        }
        // The click event handler for the wall button
        private void buttonWall_Click(object sender, EventArgs e)
        {
            currentBlock = currentBox.WALL;
        }
        // The click event handler for the Red Door button
        private void buttonRedDoor_Click(object sender, EventArgs e)
        {
            currentBlock = currentBox.REDDOOR;
        }
        // The click event handler for the Green Door button
        private void buttonGreenDoor_Click(object sender, EventArgs e)
        {
            currentBlock = currentBox.GREENDOOR;
        }
        // The click event handler for the Blue Door button
        private void buttonBlueDoor_Click(object sender, EventArgs e)
        {
            currentBlock = currentBox.BLUEDOOR;
        }
        // The click event handler for the Yellow Door button
        private void buttonYellowDoor_Click(object sender, EventArgs e)
        {
            currentBlock = currentBox.YELLOWDOOR;
        }
        // The click event handler for the Red Box button
        private void buttonRedBox_Click(object sender, EventArgs e)
        {
            currentBlock = currentBox.REDBOX;
        }
        // The click event handler for the Green Box button
        private void buttonGreenBox_Click(object sender, EventArgs e)
        {
            currentBlock = currentBox.GREENBOX;
        }
        // The click event handler for the Blue Box button
        private void buttonBlueBox_Click(object sender, EventArgs e)
        {
            currentBlock = currentBox.BLUEBOX;
        }
        // The click event handler for the Yellow Box button
        private void buttonYellowBox_Click(object sender, EventArgs e)
        {
            currentBlock = currentBox.YELLOWBOX;
        }
        // The click event handler for Generating blocks
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                int row = int.Parse(textBoxRow.Text);
                int column = int.Parse(textBoxColumn.Text);

                pb =new Block[row,column];
                
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        pb[i, j] = new Block();
                        pb[i, j].Location = new Point((j * BLOCKWIDTH) + STARTX, (i * BLOCKHEIGHT) + STARTY);
                        pb[i, j].Width = BLOCKWIDTH;
                        pb[i, j].Height = BLOCKHEIGHT;
                        pb[i, j].Visible = true;
                        pb[i, j].BorderStyle = BorderStyle.Fixed3D;
                        pb[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                        pb[i, j].BringToFront();
                        this.Controls.Add(pb[i, j]);
                        pb[i, j].Row = i;
                        pb[i, j].Column = j;
                        pb[i, j].Type = 0;

                        pb[i, j].Click += PB_Click;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurd:{ex.Message}");
            }
        }
        // The click event handler for assigning images and types to pictureboxes
        private void PB_Click(object sender, EventArgs e)
        {
            Block pb = sender as Block;
            switch (currentBlock)
            {
                case currentBox.NONE:
                    pb.Image = null;
                    pb.Type = 0;
                    break;
                case currentBox.WALL:
                    pb.Image = MTooranisamaAssignment2.Properties.Resources.wall;
                    pb.Type = 1;
                    break;
                case currentBox.REDDOOR:
                    pb.Image = MTooranisamaAssignment2.Properties.Resources.redDoor;
                    pb.Type = 2;
                    break;
                case currentBox.GREENDOOR:
                    pb.Image = MTooranisamaAssignment2.Properties.Resources.greenDoor;
                    pb.Type = 3;
                    break;
                case currentBox.BLUEDOOR:
                    pb.Image = MTooranisamaAssignment2.Properties.Resources.blueDoor;
                    pb.Type = 4;
                    break;
                case currentBox.YELLOWDOOR:
                    pb.Image = MTooranisamaAssignment2.Properties.Resources.yellowDoor;
                    pb.Type = 5;
                    break;
                case currentBox.REDBOX:
                    pb.Image = MTooranisamaAssignment2.Properties.Resources.redBox;
                    pb.Type = 6;
                    break;
                case currentBox.GREENBOX:
                    pb.Image = MTooranisamaAssignment2.Properties.Resources.greenBox;
                    pb.Type = 7;
                    break;
                case currentBox.BLUEBOX:
                    pb.Image = MTooranisamaAssignment2.Properties.Resources.blueBox;
                    pb.Type = 8;
                    break;
                case currentBox.YELLOWBOX:
                    pb.Image = MTooranisamaAssignment2.Properties.Resources.yellowBox;
                    pb.Type = 9;
                    break;
                default:
                    break;
            }
        }
        // A method that saves the layout of puzzle to a filename.txt
        private void doSave(string fileName)
        {            
           try
            {
                StreamWriter writer = new StreamWriter(fileName);
                int numberOfRows = int.Parse(textBoxRow.Text);
                int numberOfColumns = int.Parse(textBoxColumn.Text);

                writer.WriteLine(numberOfRows);
                writer.WriteLine(numberOfColumns);

                for (int i = 0; i < numberOfRows; i++)
                {
                    for (int j = 0; j < numberOfColumns; j++)
                    {
                        writer.WriteLine(pb[i, j].Row);
                        writer.WriteLine(pb[i, j].Column);                              
                        writer.WriteLine(pb[i, j].Type);
                    }             
                }
                writer.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"error occured:{ex.Message}");
            }           
        }
        // The click event handler for the save option in the menu
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "*.txt | *.txt";
            DialogResult result = saveFileDialog1.ShowDialog();
            switch (result)
            {
                case DialogResult.Cancel:
                    break;
                case DialogResult.OK:
                    try
                    {
                        string fileName = saveFileDialog1.FileName;
                        doSave(fileName);
                        MessageBox.Show("This level saved successfully");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error in file save");
                    }
                    break;
                default:
                    break;            
            }
        }
        // The click event handler for the exit option in the menu
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }       
    }
}
