namespace MTooranisamaAssignment2
{
    partial class MazeDesignerForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MazeDesignerForm));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRow = new System.Windows.Forms.TextBox();
            this.textBoxColumn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonYellowBox = new System.Windows.Forms.Button();
            this.buttonBlueBox = new System.Windows.Forms.Button();
            this.buttonGreenBox = new System.Windows.Forms.Button();
            this.buttonRedBox = new System.Windows.Forms.Button();
            this.buttonYellowDoor = new System.Windows.Forms.Button();
            this.buttonBlueDoor = new System.Windows.Forms.Button();
            this.buttonGreenDoor = new System.Windows.Forms.Button();
            this.buttonRedDoor = new System.Windows.Forms.Button();
            this.buttonWall = new System.Windows.Forms.Button();
            this.buttonNone = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "none.jpg");
            this.imageList1.Images.SetKeyName(1, "wall.jpg");
            this.imageList1.Images.SetKeyName(2, "redDoor.jpg");
            this.imageList1.Images.SetKeyName(3, "greenDoor.jpg");
            this.imageList1.Images.SetKeyName(4, "blueDoor.jpg");
            this.imageList1.Images.SetKeyName(5, "yellowDoor.jpg");
            this.imageList1.Images.SetKeyName(6, "redBox.jpg");
            this.imageList1.Images.SetKeyName(7, "greenBox.jpg");
            this.imageList1.Images.SetKeyName(8, "blueBox.jpg");
            this.imageList1.Images.SetKeyName(9, "yellowBox.jpg");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 50;
            this.label1.Text = "Row";
            // 
            // textBoxRow
            // 
            this.textBoxRow.Location = new System.Drawing.Point(61, 15);
            this.textBoxRow.Name = "textBoxRow";
            this.textBoxRow.Size = new System.Drawing.Size(100, 20);
            this.textBoxRow.TabIndex = 51;
            // 
            // textBoxColumn
            // 
            this.textBoxColumn.Location = new System.Drawing.Point(244, 14);
            this.textBoxColumn.Name = "textBoxColumn";
            this.textBoxColumn.Size = new System.Drawing.Size(100, 20);
            this.textBoxColumn.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 52;
            this.label2.Text = "Column";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerate.Location = new System.Drawing.Point(402, 13);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerate.TabIndex = 54;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.buttonYellowBox);
            this.groupBox1.Controls.Add(this.buttonBlueBox);
            this.groupBox1.Controls.Add(this.buttonGreenBox);
            this.groupBox1.Controls.Add(this.buttonRedBox);
            this.groupBox1.Controls.Add(this.buttonYellowDoor);
            this.groupBox1.Controls.Add(this.buttonBlueDoor);
            this.groupBox1.Controls.Add(this.buttonGreenDoor);
            this.groupBox1.Controls.Add(this.buttonRedDoor);
            this.groupBox1.Controls.Add(this.buttonWall);
            this.groupBox1.Controls.Add(this.buttonNone);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 506);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tool Box";
            // 
            // buttonYellowBox
            // 
            this.buttonYellowBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonYellowBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonYellowBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonYellowBox.ImageIndex = 9;
            this.buttonYellowBox.ImageList = this.imageList1;
            this.buttonYellowBox.Location = new System.Drawing.Point(15, 446);
            this.buttonYellowBox.Name = "buttonYellowBox";
            this.buttonYellowBox.Size = new System.Drawing.Size(109, 40);
            this.buttonYellowBox.TabIndex = 62;
            this.buttonYellowBox.Text = "Yellow Box";
            this.buttonYellowBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonYellowBox.UseCompatibleTextRendering = true;
            this.buttonYellowBox.UseVisualStyleBackColor = true;
            this.buttonYellowBox.Click += new System.EventHandler(this.buttonYellowBox_Click);
            // 
            // buttonBlueBox
            // 
            this.buttonBlueBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonBlueBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBlueBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBlueBox.ImageIndex = 8;
            this.buttonBlueBox.ImageList = this.imageList1;
            this.buttonBlueBox.Location = new System.Drawing.Point(14, 400);
            this.buttonBlueBox.Name = "buttonBlueBox";
            this.buttonBlueBox.Size = new System.Drawing.Size(109, 40);
            this.buttonBlueBox.TabIndex = 61;
            this.buttonBlueBox.Text = "Blue Box";
            this.buttonBlueBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBlueBox.UseCompatibleTextRendering = true;
            this.buttonBlueBox.UseVisualStyleBackColor = true;
            this.buttonBlueBox.Click += new System.EventHandler(this.buttonBlueBox_Click);
            // 
            // buttonGreenBox
            // 
            this.buttonGreenBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonGreenBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonGreenBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGreenBox.ImageIndex = 7;
            this.buttonGreenBox.ImageList = this.imageList1;
            this.buttonGreenBox.Location = new System.Drawing.Point(15, 354);
            this.buttonGreenBox.Name = "buttonGreenBox";
            this.buttonGreenBox.Size = new System.Drawing.Size(109, 40);
            this.buttonGreenBox.TabIndex = 60;
            this.buttonGreenBox.Text = "Green Box";
            this.buttonGreenBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGreenBox.UseCompatibleTextRendering = true;
            this.buttonGreenBox.UseVisualStyleBackColor = true;
            this.buttonGreenBox.Click += new System.EventHandler(this.buttonGreenBox_Click);
            // 
            // buttonRedBox
            // 
            this.buttonRedBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonRedBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRedBox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRedBox.ImageIndex = 6;
            this.buttonRedBox.ImageList = this.imageList1;
            this.buttonRedBox.Location = new System.Drawing.Point(14, 308);
            this.buttonRedBox.Name = "buttonRedBox";
            this.buttonRedBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonRedBox.Size = new System.Drawing.Size(109, 40);
            this.buttonRedBox.TabIndex = 59;
            this.buttonRedBox.Text = "Red Box";
            this.buttonRedBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRedBox.UseCompatibleTextRendering = true;
            this.buttonRedBox.UseVisualStyleBackColor = true;
            this.buttonRedBox.Click += new System.EventHandler(this.buttonRedBox_Click);
            // 
            // buttonYellowDoor
            // 
            this.buttonYellowDoor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonYellowDoor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonYellowDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonYellowDoor.ImageIndex = 5;
            this.buttonYellowDoor.ImageList = this.imageList1;
            this.buttonYellowDoor.Location = new System.Drawing.Point(14, 262);
            this.buttonYellowDoor.Name = "buttonYellowDoor";
            this.buttonYellowDoor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonYellowDoor.Size = new System.Drawing.Size(109, 40);
            this.buttonYellowDoor.TabIndex = 58;
            this.buttonYellowDoor.Text = "Yellow Door";
            this.buttonYellowDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonYellowDoor.UseCompatibleTextRendering = true;
            this.buttonYellowDoor.UseVisualStyleBackColor = true;
            this.buttonYellowDoor.Click += new System.EventHandler(this.buttonYellowDoor_Click);
            // 
            // buttonBlueDoor
            // 
            this.buttonBlueDoor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonBlueDoor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonBlueDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBlueDoor.ImageIndex = 4;
            this.buttonBlueDoor.ImageList = this.imageList1;
            this.buttonBlueDoor.Location = new System.Drawing.Point(14, 216);
            this.buttonBlueDoor.Name = "buttonBlueDoor";
            this.buttonBlueDoor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonBlueDoor.Size = new System.Drawing.Size(109, 40);
            this.buttonBlueDoor.TabIndex = 57;
            this.buttonBlueDoor.Text = "Blue Door";
            this.buttonBlueDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBlueDoor.UseCompatibleTextRendering = true;
            this.buttonBlueDoor.UseVisualStyleBackColor = true;
            this.buttonBlueDoor.Click += new System.EventHandler(this.buttonBlueDoor_Click);
            // 
            // buttonGreenDoor
            // 
            this.buttonGreenDoor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonGreenDoor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonGreenDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGreenDoor.ImageIndex = 3;
            this.buttonGreenDoor.ImageList = this.imageList1;
            this.buttonGreenDoor.Location = new System.Drawing.Point(14, 170);
            this.buttonGreenDoor.Name = "buttonGreenDoor";
            this.buttonGreenDoor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonGreenDoor.Size = new System.Drawing.Size(109, 40);
            this.buttonGreenDoor.TabIndex = 56;
            this.buttonGreenDoor.Text = "Green Door";
            this.buttonGreenDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonGreenDoor.UseCompatibleTextRendering = true;
            this.buttonGreenDoor.UseVisualStyleBackColor = true;
            this.buttonGreenDoor.Click += new System.EventHandler(this.buttonGreenDoor_Click);
            // 
            // buttonRedDoor
            // 
            this.buttonRedDoor.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonRedDoor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRedDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRedDoor.ImageIndex = 2;
            this.buttonRedDoor.ImageList = this.imageList1;
            this.buttonRedDoor.Location = new System.Drawing.Point(14, 124);
            this.buttonRedDoor.Name = "buttonRedDoor";
            this.buttonRedDoor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonRedDoor.Size = new System.Drawing.Size(109, 40);
            this.buttonRedDoor.TabIndex = 55;
            this.buttonRedDoor.Text = "Red Door";
            this.buttonRedDoor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRedDoor.UseCompatibleTextRendering = true;
            this.buttonRedDoor.UseVisualStyleBackColor = true;
            this.buttonRedDoor.Click += new System.EventHandler(this.buttonRedDoor_Click);
            // 
            // buttonWall
            // 
            this.buttonWall.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonWall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonWall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonWall.ImageIndex = 1;
            this.buttonWall.ImageList = this.imageList1;
            this.buttonWall.Location = new System.Drawing.Point(15, 78);
            this.buttonWall.Name = "buttonWall";
            this.buttonWall.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonWall.Size = new System.Drawing.Size(109, 40);
            this.buttonWall.TabIndex = 54;
            this.buttonWall.Text = "Wall";
            this.buttonWall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonWall.UseVisualStyleBackColor = true;
            this.buttonWall.Click += new System.EventHandler(this.buttonWall_Click);
            // 
            // buttonNone
            // 
            this.buttonNone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNone.ImageIndex = 0;
            this.buttonNone.ImageList = this.imageList1;
            this.buttonNone.Location = new System.Drawing.Point(15, 32);
            this.buttonNone.Name = "buttonNone";
            this.buttonNone.Size = new System.Drawing.Size(109, 40);
            this.buttonNone.TabIndex = 53;
            this.buttonNone.Text = "None";
            this.buttonNone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNone.UseVisualStyleBackColor = true;
            this.buttonNone.Click += new System.EventHandler(this.buttonNone_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(817, 24);
            this.menuStrip1.TabIndex = 58;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxRow);
            this.groupBox2.Controls.Add(this.textBoxColumn);
            this.groupBox2.Controls.Add(this.buttonGenerate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(793, 44);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            // 
            // MazeDesignerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 609);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Name = "MazeDesignerForm";
            this.Text = "MazeDesignerForm";
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRow;
        private System.Windows.Forms.TextBox textBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonYellowBox;
        private System.Windows.Forms.Button buttonBlueBox;
        private System.Windows.Forms.Button buttonGreenBox;
        private System.Windows.Forms.Button buttonRedBox;
        private System.Windows.Forms.Button buttonYellowDoor;
        private System.Windows.Forms.Button buttonBlueDoor;
        private System.Windows.Forms.Button buttonGreenDoor;
        private System.Windows.Forms.Button buttonRedDoor;
        private System.Windows.Forms.Button buttonWall;
        private System.Windows.Forms.Button buttonNone;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}