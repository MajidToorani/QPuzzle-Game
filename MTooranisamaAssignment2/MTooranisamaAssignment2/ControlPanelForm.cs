using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
//  16/09/2018    Created
//  16/09/2018    UI Designed
//  29/09/2018    Bug Fixed


namespace MTooranisamaAssignment2
{
    // A class of Control Panel that opens MazeDesignerForm, closes this form
    // and a button for playing the game
    public partial class ControlPanelForm : Form
    {
        public ControlPanelForm()
        {
            InitializeComponent();
        }
        // The click event handler for the Design button
        private void designBtn_Click(object sender, EventArgs e)
        {
            MazeDesignerForm Design = new MazeDesignerForm();
            Design.Show();
        }
        // The click event handler for the Play button
        private void playBtn_Click(object sender, EventArgs e)
        {
            PlayForm Play = new PlayForm();
            Play.Show();
        }
        // The click event handler for the Exit button
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
    }
}