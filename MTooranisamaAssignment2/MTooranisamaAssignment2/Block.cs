using System;
using System.Collections.Generic;
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
//  25/09/2018    Bug Fixed


namespace MtooranisamaAssignment2
{
    // A Class called Block inherited from PictureBox Class Library
    //added Row, Column and Type Properties
    public class Block : PictureBox
    {
        public int Row;
        public int Column;
        public int Type;
        public Block()
        {
        }
        public Block(int row, int column, int type)
        {
            this.Row = row;
            this.Column = column;
            this.Type = type;
        }        
    }
    // An enum for tools of puzzle game
    public enum currentBox
    {
        NONE,
        WALL,
        REDDOOR,
        GREENDOOR,
        BLUEDOOR,
        YELLOWDOOR,
        REDBOX,
        GREENBOX,
        BLUEBOX,
        YELLOWBOX,
    }    
}
