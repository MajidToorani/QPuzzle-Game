using MtooranisamaAssignment2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// QPuzzle Game
// Assignment 2
//    
// Majid Tooranisama
// 04/11/2018
//
// Revision history
//  16/10/2018    Created
//  16/10/2018    UI Designed
//  31/10/2018    Bug Fixed
//  03/11/2018    Comments Added

namespace MTooranisamaAssignment2
{
    public partial class PlayForm : Form
    {
        // Constant parameter for start point, width and height of pictureboxes
        private const int STARTX = 50;
        private const int STARTY = 50;
        private const int BLOCKWIDTH = 40;
        private const int BLOCKHEIGHT = 40;
        // Global variables that will be used in all methods 
        Block[,] pb;
        currentBox currentTool;
        Block myTile;
        int myType;
        int myTileRow = 0;
        int myTileColumn = 0;
        int count = 0;
        int moveCounter = 0;
        public PlayForm()
        {
            InitializeComponent();
        } 
        // Load method that is called in play section and load in menu bar
        // it uses stream reader to read the filename.txt and loads picture boxes into form panel
        private void doLoad(string filename)
        {
            this.panel1.Controls.Clear();
            try
            {
                StreamReader reader = new StreamReader(filename);
                int numberOfRows = int.Parse(reader.ReadLine());
                int numberOfColumns = int.Parse(reader.ReadLine());

                pb = new Block[numberOfRows, numberOfColumns];

                for (int i = 0; i < numberOfRows; i++)
                {
                    for (int j = 0; j < numberOfColumns; j++)
                    {
                        pb[i, j] = new Block();
                        pb[i, j].Row= int.Parse(reader.ReadLine());
                        pb[i, j].Column = int.Parse(reader.ReadLine());
                        pb[i, j].Type = int.Parse(reader.ReadLine());
                        switch (pb[i, j].Type)
                        {
                            case 0:
                                pb[i, j].Image = null;
                                break;
                            case 1:
                                pb[i, j].Image = MTooranisamaAssignment2.Properties.Resources.wall;
                                break;
                            case 2:
                                pb[i, j].Image = MTooranisamaAssignment2.Properties.Resources.redDoor;
                                break;
                            case 3:
                                pb[i, j].Image = MTooranisamaAssignment2.Properties.Resources.greenDoor;
                                break;
                            case 4:
                                pb[i, j].Image = MTooranisamaAssignment2.Properties.Resources.blueDoor;
                                break;
                            case 5:
                                pb[i, j].Image = MTooranisamaAssignment2.Properties.Resources.yellowDoor;
                                break;
                            case 6:
                                pb[i, j].Image = MTooranisamaAssignment2.Properties.Resources.redBox;
                                break;
                            case 7:
                                pb[i, j].Image = MTooranisamaAssignment2.Properties.Resources.greenBox;
                                break;
                            case 8:
                                pb[i, j].Image = MTooranisamaAssignment2.Properties.Resources.blueBox;
                                break;
                            case 9:
                                pb[i, j].Image = MTooranisamaAssignment2.Properties.Resources.yellowBox;
                                break;
                            default:
                                break;
                        }
                        pb[i, j].Location = new Point((j * BLOCKWIDTH) + STARTX, (i * BLOCKHEIGHT) + STARTY);
                        pb[i, j].Width = BLOCKWIDTH;
                        pb[i, j].Height = BLOCKHEIGHT;
                        pb[i, j].Visible = true;
                        pb[i, j].SizeMode = PictureBoxSizeMode.StretchImage;
                        pb[i, j].BringToFront();
                        this.panel1.Controls.Add(pb[i, j]);

                        pb[i, j].Click += PB_Click;
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"error occured:{ex.Message}");
            }
        }
        // The click event handler for the load option in the menu bar
        private void loadGamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "*.txt | *.txt";
            DialogResult result = openFileDialog1.ShowDialog();
            switch (result)
            {
                case DialogResult.Cancel:
                    break;
                case DialogResult.OK:
                    try
                    {
                        string filename = openFileDialog1.FileName;
                        doLoad(filename);
                        MessageBox.Show("This level loaded successfully");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error in file load");
                    }
                    break;
                default:
                    break;
            }
        }
        // The click event handler for the exit option in the menu bar
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // The click event handler for assigning row, column, and type to boxes joining to currentTool(enums)
        private void PB_Click(object sender, EventArgs e)
        {
            Block myBox = sender as Block;            
            myTile = myBox;
            myTileRow = myTile.Row;
            myTileColumn = myTile.Column;
            myType = pb[myTileRow, myTileColumn].Type;
            switch (myType)
            {
                case 6:
                    currentTool = currentBox.REDBOX;
                    break;
                case 7:
                    currentTool = currentBox.GREENBOX;
                    break;
                case 8:
                    currentTool = currentBox.BLUEBOX;
                    break;
                case 9:
                    currentTool = currentBox.YELLOWBOX;
                    break;
                default:
                    MessageBox.Show("Click only Boxes to select");
                    break;
            }           
        }
        // A method for checking if any box is exist in the form panel, so if not returns true
        public bool BoxExistCheck()
        {
            string output = "";
            for (int i = 0; i < pb.GetUpperBound(0); i++)
            {
                for (int j = 0; j < pb.GetUpperBound(1); j++)
                {
                    if (pb[i, j].Type == 6 || pb[i, j].Type == 7 || pb[i, j].Type == 8 || pb[i, j].Type == 9)
                    {
                        output = "Yes";
                    }
                }
            }
            if (output == "Yes")
                return false;
            else
                return true;
        }
        // A method is called when a box faces any pictureboxes that is not null
        // so this method checks the next box if the type of nextbox is a door with 
        // same color of box, it removes box from the form panel
        public void PassTheDoor(Block box, Block door)
        {
            switch (currentTool)
            {
                case currentBox.REDBOX:
                    if (door.Type == 2)
                    {
                        this.panel1.Controls.Remove(box);
                        pb[box.Row, box.Column].Type = 0;
                    }
                    break;
                case currentBox.GREENBOX:
                    if (door.Type == 3)
                    {
                        this.panel1.Controls.Remove(box);
                        pb[box.Row, box.Column].Type = 0;
                    }
                    break;
                case currentBox.BLUEBOX:
                    if (door.Type == 4)
                    {
                        this.panel1.Controls.Remove(box);
                        pb[box.Row, box.Column].Type = 0;
                    }
                    break;
                case currentBox.YELLOWBOX:
                    if (door.Type == 5)
                    {
                        this.panel1.Controls.Remove(box);
                        pb[box.Row, box.Column].Type = 0;
                    }
                    break;
                default:
                    break;
            }           
            if (BoxExistCheck() == true)  // This method is called for checking existence of 
            {                             // boxes(if "true" game ends and a congratulation pops up)
                MessageBox.Show("Congratulation! \n Game End");
                this.panel1.Controls.Clear();
                moveCounter = 0;
                txtBoxMoves.Text = moveCounter.ToString();
            }
        }
        // This method is called to move only the boxes and carries(this box, next box and the direction)
        public void MoveTheBox(Block thisBox, Block nextBox, string direction)
        {
            moveCounter++; // counter for the number of movements and displays at the textbox on the form panel
            txtBoxMoves.Text = moveCounter.ToString();

            if (myType == 6 || myType == 7 || myType == 8 || myType == 9)
            {
                switch (direction)
                {
                    case "UP":
                        while (pb[myTileRow - 1, myTileColumn].Type == 0)
                        {
                            thisBox.Top -= BLOCKHEIGHT;
                            thisBox.BringToFront();
                            pb[myTileRow - 1, myTileColumn].Type = pb[myTileRow, myTileColumn].Type;
                            pb[myTileRow, myTileColumn].Type = 0;
                            myTile.Row = myTile.Row - 1;
                            myTileRow -= 1;                           
                        }
                        PassTheDoor(thisBox, pb[myTileRow - 1, myTileColumn]);
                        break;
                    case "DOWN":
                        while (pb[myTileRow + 1, myTileColumn].Type == 0)
                        {
                            thisBox.Top += BLOCKHEIGHT;
                            thisBox.BringToFront();
                            pb[myTileRow + 1, myTileColumn].Type = pb[myTileRow, myTileColumn].Type;
                            pb[myTileRow, myTileColumn].Type = 0;
                            myTile.Row = myTile.Row + 1;
                            myTileRow += 1;
                        }
                        PassTheDoor(thisBox, pb[myTileRow + 1, myTileColumn]);
                        break;
                    case "LEFT":
                        while (pb[myTileRow, myTileColumn - 1].Type == 0)
                        {
                            thisBox.Left -= BLOCKWIDTH;
                            thisBox.BringToFront();
                            pb[myTileRow, myTileColumn - 1].Type = pb[myTileRow, myTileColumn].Type;
                            pb[myTileRow, myTileColumn].Type = 0;
                            myTile.Column = myTile.Column - 1;
                            myTileColumn -= 1;
                        }
                        PassTheDoor(thisBox, pb[myTileRow, myTileColumn - 1]);
                        break;
                    case "RIGHT":
                        while (pb[myTileRow, myTileColumn + 1].Type == 0)
                        {
                            thisBox.Left += BLOCKWIDTH;
                            thisBox.BringToFront();
                            pb[myTileRow, myTileColumn + 1].Type = pb[myTileRow, myTileColumn].Type;
                            pb[myTileRow, myTileColumn].Type = 0;
                            myTile.Column = myTile.Column + 1;
                            myTileColumn += 1;
                        }
                        PassTheDoor(thisBox, pb[myTileRow, myTileColumn + 1]);
                        break;
                    default:                        
                        break;
                }
            }                        
        }
        // The click event handler when UP button on the control pad is clicked
        private void btnUp_Click(object sender, EventArgs e)
        {
            try
            {
                Block nextTile = pb[myTile.Row - 1, myTile.Column];
                MoveTheBox(myTile, nextTile, "UP"); // MoveTheBox method is called and carries myTile(global variable)
            }                                       // and nextTile(assigned at above line) and the direction "UP"
            catch (Exception)
            {
                MessageBox.Show("Select a box");
            }
        }
        // The click event handler when RIGHT button on the control pad is clicked
        private void btnRight_Click(object sender, EventArgs e)
        {           
            try
            {
                Block nextTile = pb[myTile.Row, myTile.Column + 1];
                MoveTheBox(myTile, nextTile, "RIGHT"); // MoveTheBox method is called and carries myTile(global variable)
            }                                          // and nextTile(assigned at above line) and the direction "RIGHT"
            catch (Exception)
            {
                MessageBox.Show("Select a box");
            }
        }
        // The click event handler when LEFT button on the control pad is clicked
        private void btnLeft_Click(object sender, EventArgs e)
        {
            try
            {
                Block nextTile = pb[myTile.Row, myTile.Column - 1];
                MoveTheBox(myTile, nextTile, "LEFT"); // MoveTheBox method is called and carries myTile(global variable)
            }                                         // and nextTile(assigned at above line) and the direction "LEFT"
            catch (Exception)
            {
                MessageBox.Show("Select a box");
            }
        }
        // The click event handler when DOWN button on the control pad is clicked
        private void btnDown_Click(object sender, EventArgs e)
        {
            try
            {
                Block nextTile = pb[myTile.Row + 1, myTile.Column];
                MoveTheBox(myTile, nextTile, "DOWN"); // MoveTheBox method is called and carries myTile(global variable)
            }                                         // and nextTile(assigned at above line) and the direction "DOWN"
            catch (Exception)
            {
                MessageBox.Show("Select a box");
            }
        }
        // Additional Event handler method just for fun: in this method when color button 
        //is clicked this changes the color of control pad 
        private void btnColor_Click(object sender, EventArgs e)
        {
            if (count % 2 == 0)
            {
                btnDown.BackColor = Color.Pink;
                btnUp.BackColor = Color.Pink;
                btnLeft.BackColor = Color.Pink;
                btnRight.BackColor = Color.Pink;
            }
            else if (count % 3 == 0)
            {
                btnDown.BackColor = Color.Green;
                btnUp.BackColor = Color.Green;
                btnLeft.BackColor = Color.Green;
                btnRight.BackColor = Color.Green;
            }
            else if (count % 5 == 0)
            {
                btnDown.BackColor = Color.DeepSkyBlue;
                btnUp.BackColor = Color.DeepSkyBlue;
                btnLeft.BackColor = Color.DeepSkyBlue;
                btnRight.BackColor = Color.DeepSkyBlue;
            }
            else
            {
                btnDown.BackColor = Color.Khaki;
                btnUp.BackColor = Color.Khaki;
                btnLeft.BackColor = Color.Khaki;
                btnRight.BackColor = Color.Khaki;
            }
            count++;
        }
    }
}
