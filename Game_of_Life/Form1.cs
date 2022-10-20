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

namespace Game_of_Life
{
    public partial class Form1 : Form
    {
        // The universe array
        bool[,] universe = new bool[30, 30];
        bool[,] scratchPad = new bool[30, 30];

        // Settings to be toggled
        bool showNums = true;
        bool toroidal = false;
        bool showGrid = true;
        bool showHUD = true;

        // Drawing colors
        Color gridColor = Color.Black;
        Color cellColor = Color.Gray;
        Color hudColor = Color.Red;

        // The Timer class
        Timer timer = new Timer();
        //int timerInterval = 100;

        // Generation count
        int generations = 0;
        // Set height and width
        int rows = 0;
        int columns = 0;
        // String to be updated for tool strip, will have mode and int for number of living cells
        string toroidalCheck = "";
        string displayLivingCells = "";


        public Form1()
        {
            InitializeComponent();
            // Setup the timer
            timer.Interval = 100; // milliseconds
            timer.Tick += Timer_Tick;
            timer.Enabled = false; // start timer running


            // Set default settings
            graphicsPanel1.BackColor = Properties.Settings.Default.PanelColor; // background color
            cellColor = Properties.Settings.Default.CellColor;  // cell color
            gridColor = Properties.Settings.Default.GridColor;  // grid color
            timer.Interval = Properties.Settings.Default.TimerInterval; // timer interval
            columns = Properties.Settings.Default.Columns;      // width
            rows = Properties.Settings.Default.Rows;            // height

            // reset universes after resizing
            universe = new bool[columns, rows];
            scratchPad = new bool[columns, rows];
            graphicsPanel1.Invalidate();
        }

        // Calculate the next generation of cells
        private void NextGeneration()
        {
            // how many cells are alive currently
            displayLivingCells = livingCells().ToString();

            if (toroidal == true)
            {
                toroidalCheck = "Toroidal mode";            // if toroidal check is true
            }
            else if (toroidal == false)
            {
                toroidalCheck = "Finite mode";              //if toroidal check is false
            }
            // checks to see if toroidal check is true and then follows the toroidal ruleset
            if (toroidal == true)
            {
                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    for (int x = 0; x < universe.GetLength(0); x++)
                    {
                        // counts neighboring cells and checks which are alive
                        int neighbors = CountNeighborsToroidal(x, y);
                        // number of neighboring cells that are alive
                        int count;

                        //checks to see if the cell is alive
                        if (universe[x, y] == true)
                        {
                            count = 1;
                        }
                        else
                        {
                            count = 0;
                        }

                        // rule set for if a cell will live into next generation
                        if (count == 1 && (neighbors < 2 || neighbors > 3))
                        {
                            scratchPad[x, y] = false;
                        }
                        else if (count == 1 && (neighbors == 2 || neighbors == 3))
                        {
                            scratchPad[x, y] = true;
                        }

                        else if (count == 0 && neighbors == 3)
                        {
                            scratchPad[x, y] = true;
                        }
                        else if (count == 0 && neighbors != 3)
                        {
                            scratchPad[x, y] = false;
                        }
                    }
                }
            }

            // same set of rules, following the finite setting instead of toroidal
            else if (toroidal == false)
            {
                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    for (int x = 0; x < universe.GetLength(0); x++)
                    {
                        int neighbors = CountNeighborsFinite(x, y);
                        int count;

                        if (universe[x, y] == true)
                        {
                            count = 1;
                        }
                        else
                        {
                            count = 0;
                        }

                        if (count == 1 && (neighbors < 2 || neighbors > 3))
                        {
                            scratchPad[x, y] = false;
                        }
                        else if (count == 1 && (neighbors == 2 || neighbors == 3))
                        {
                            scratchPad[x, y] = true;
                        }

                        else if (count == 0 && neighbors == 3)
                        {
                            scratchPad[x, y] = true;
                        }
                        else if (count == 0 && neighbors != 3)
                        {
                            scratchPad[x, y] = false;
                        }
                    }
                }
            }


            bool[,] temp = universe;
            universe = scratchPad;
            scratchPad = temp;

            // Increment generation count
            generations++;

            // Update status strip generations
            toolStripStatusLabelGenerations.Text = "Generations = " + generations.ToString();
            toolStripStatusLabelLiveCells.Text = "Living Cells = " + displayLivingCells;
            toolStripStatusLabelMode.Text = "Mode: " + toroidalCheck;

            graphicsPanel1.Invalidate();
        }

        // The event called by the timer every Interval milliseconds.
        private void Timer_Tick(object sender, EventArgs e)
        {
            NextGeneration();
        }

        private void graphicsPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Calculate the width and height of each cell in pixels
            // CELL WIDTH = WINDOW WIDTH / NUMBER OF CELLS IN X
            float cellWidth = graphicsPanel1.ClientSize.Width / (float)universe.GetLength(0);
            // CELL HEIGHT = WINDOW HEIGHT / NUMBER OF CELLS IN Y
            float cellHeight = graphicsPanel1.ClientSize.Height / (float)universe.GetLength(1);

            // A Pen for drawing the grid lines (color, width)
            Pen gridPen = new Pen(gridColor, 1);

            // A Pen for drawing the HUD
            Brush hudBrush = new SolidBrush(hudColor);

            // Painting HUD

            // A Brush for filling living cells interiors (color)
            Brush cellBrush = new SolidBrush(cellColor);

            // Iterate through the universe in the y, top to bottom
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    // A rectangle to represent each cell in pixels
                    RectangleF cellRect = RectangleF.Empty;
                    cellRect.X = x * cellWidth;
                    cellRect.Y = y * cellHeight;
                    cellRect.Width = cellWidth;
                    cellRect.Height = cellHeight;

                    // Formatting for number of neighbors display
                    StringFormat format = new StringFormat();
                    format.Alignment = StringAlignment.Center;
                    format.LineAlignment = StringAlignment.Center;
                    float numSize = cellHeight / 2;
                    if (numSize < 1)
                    {
                        numSize = 1;
                    }
                    Font font = new Font(FontFamily.GenericSansSerif, numSize, FontStyle.Regular);

                    int neighborCountFinite = CountNeighborsFinite(x, y);
                    int neighborCountToroidal = CountNeighborsToroidal(x, y);

                    // Fill the cell with a brush if alive
                    if (toroidal == false)
                    {
                        if (universe[x, y] == true)
                        {
                            e.Graphics.FillRectangle(cellBrush, cellRect);
                            if (showNums == true)
                            {
                                e.Graphics.DrawString(neighborCountFinite.ToString(), font, Brushes.White, cellRect, format);
                            }
                        }
                        else
                        {
                            if (showNums == true)
                            {
                                e.Graphics.DrawString(neighborCountFinite.ToString(), font, Brushes.White, cellRect, format);
                            }
                        }
                    }

                    if (toroidal == true)
                    {
                        if (universe[x, y] == true)
                        {
                            e.Graphics.FillRectangle(cellBrush, cellRect);
                            if (showNums == true)
                            {
                                e.Graphics.DrawString(neighborCountToroidal.ToString(), font, Brushes.White, cellRect, format);
                            }
                        }
                        else
                        {
                            if (showNums == true)
                            {
                                e.Graphics.DrawString(neighborCountToroidal.ToString(), font, Brushes.White, cellRect, format);
                            }
                        }
                    }

                    // Outline the cell with a pen
                    if (showGrid == true)
                    {
                        e.Graphics.DrawRectangle(gridPen, cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height);
                    }
                }
            }

            // Cleaning up pens and brushes
            gridPen.Dispose();
            cellBrush.Dispose();
        }

        private void graphicsPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            // If the left mouse button was clicked
            if (e.Button == MouseButtons.Left)
            {
                // Calculate the width and height of each cell in pixels
                float cellWidth = graphicsPanel1.ClientSize.Width / (float)universe.GetLength(0);
                float cellHeight = graphicsPanel1.ClientSize.Height / (float)universe.GetLength(1);

                // Calculate the cell that was clicked in
                // CELL X = MOUSE X / CELL WIDTH
                int x = (int)(e.X / cellWidth);
                // CELL Y = MOUSE Y / CELL HEIGHT
                int y = (int)(e.Y / cellHeight);

                // Toggle the cell's state
                universe[x, y] = !universe[x, y];

                // Tell Windows you need to repaint
                graphicsPanel1.Invalidate();
            }
        }

        public int livingCells()
        {
            int numLivingCells = 0;
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    bool thisCell = universe[x, y];
                    if (thisCell == true)
                    {
                        numLivingCells++;
                    }
                }
            }
            return numLivingCells;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            // Closes Game of Life
            this.Close();
        }

        private int CountNeighborsFinite(int x, int y)
        {
            int count = 0;
            int xLen = universe.GetLength(0);                       // Length of universe from each direction, both x and y
            int yLen = universe.GetLength(1);


            for (int yOffset = -1; yOffset <= 1; yOffset++)
            {
                for (int xOffset = -1; xOffset <= 1; xOffset++)
                {
                    int xCheck = x + xOffset;
                    int yCheck = y + yOffset;

                    if (xOffset == 0 && yOffset == 0)               // If at cell we're checking, move to next step
                    {
                        continue;
                    }

                    // If at cell above, below, continue to next step

                    if (xCheck < 0)
                    {
                        continue;
                    }
                    if (yCheck < 0)
                    {
                        continue;
                    }
                    if (xCheck >= xLen)
                    {
                        continue;
                    }
                    if (yCheck >= yLen)
                    {
                        continue;
                    }

                    // If cells are active, increase counter for neighbor

                    if (universe[xCheck, yCheck] == true)
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        private int CountNeighborsToroidal(int x, int y)
        {
            int count = 0;
            int xLen = universe.GetLength(0);
            int yLen = universe.GetLength(1);                                               // Follows same format as above however resets to other side of screen
            for (int yOffset = -1; yOffset <= 1; yOffset++)                                 // if at edge instead of calling everything off screen dead
            {
                for (int xOffset = -1; xOffset <= 1; xOffset++)
                {
                    int xCheck = x + xOffset;
                    int yCheck = y + yOffset;

                    if (xOffset == 0 && yOffset == 0)
                    {
                        continue;
                    }
                    if (xCheck < 0)
                    {
                        xCheck = xLen - 1;
                    }
                    if (yCheck < 0)
                    {
                        yCheck = yLen - 1;
                    }
                    if (xCheck >= xLen)
                    {
                        xCheck = 0;
                    }
                    if (yCheck >= yLen)
                    {
                        yCheck = 0;
                    }

                    if (universe[xCheck, yCheck] == true)
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            // pressing play enables the timer
            timer.Enabled = true;
            graphicsPanel1.Invalidate();
        }

        private void PauseButton_Click(object sender, EventArgs e)
        {
            // pressing pause disables the timer or restarts (depending on current state of timer)
            timer.Enabled = !timer.Enabled;
            graphicsPanel1.Invalidate();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            // proceeds to next generation
            NextGeneration();
            graphicsPanel1.Invalidate();
        }

        private void newButton_Click(object sender, EventArgs e)                           // terrible variable name. this is "New" option in the menu
        {
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    // clears each spot in the array, one spot at a time
                    universe[x, y] = false;
                }
            }
            generations = 0;

            timer.Enabled = false;

            toolStripStatusLabelGenerations.Text = "Generations = " + generations.ToString();
            toolStripStatusLabelLiveCells.Text = "Living Cells = " + displayLivingCells;
            toolStripStatusLabelMode.Text = "Mode: " + toroidalCheck;

            graphicsPanel1.Invalidate();
        }

        private void newRandomSeed_Click(object sender, EventArgs e)
        {
            Random rng = new Random();

            timer.Enabled = false;
            generations = 0;

            toolStripStatusLabelGenerations.Text = "Generations = " + generations.ToString();
            toolStripStatusLabelLiveCells.Text = "Living Cells = " + displayLivingCells;
            toolStripStatusLabelMode.Text = "Mode: " + toroidalCheck;

            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    universe[x, y] = false;
                    universe[x, y] = rng.Next(2) == 1;
                }
            }
            graphicsPanel1.Invalidate();
        }

        private void newSeed_Click(object sender, EventArgs e)
        {
            NewSeedModal dialog = new NewSeedModal();
            int seed = 0;
            dialog.SetSeed(seed);

            Random rng = new Random(seed);

            if (DialogResult.OK == dialog.ShowDialog())
            {
                timer.Enabled = false;
                generations = 0;

                toolStripStatusLabelGenerations.Text = "Generations = " + generations.ToString();
                toolStripStatusLabelLiveCells.Text = "Living Cells = " + displayLivingCells;
                toolStripStatusLabelMode.Text = "Mode: " + toroidalCheck;

                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    for (int x = 0; x < universe.GetLength(0); x++)
                    {
                        universe[x, y] = false;
                        universe[x, y] = rng.Next(2) == 1;
                    }
                }
                graphicsPanel1.Invalidate();
            }
        }

        private void backgroundColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.Color = graphicsPanel1.BackColor;
            if (DialogResult.OK == dialog.ShowDialog())
            {
                graphicsPanel1.BackColor = dialog.Color;
                graphicsPanel1.Invalidate();
            }
        }

        private void cellColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.Color = cellColor;
            if (DialogResult.OK == dialog.ShowDialog())
            {
                cellColor = dialog.Color;
                graphicsPanel1.Invalidate();
            }
        }

        private void gridColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.Color = gridColor;
            if (DialogResult.OK == dialog.ShowDialog())
            {
                gridColor = dialog.Color;
                graphicsPanel1.Invalidate();
            }
        }

        private void toroidal_Click(object sender, EventArgs e)
        {
            toroidal = true;        // set mode to toroidal
            finiteToolStripMenuItem.Checked = false;
            toroidalToolStripMenuItem.Checked = true;
        }

        private void finite_Click(object sender, EventArgs e)
        {
            toroidal = false;       // set mode to finite
            toroidalToolStripMenuItem.Checked = false;
            finiteToolStripMenuItem.Checked = true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.PanelColor = graphicsPanel1.BackColor;  // updates background color on exit
            Properties.Settings.Default.CellColor = cellColor;                  // updates cell color on exit
            Properties.Settings.Default.GridColor = gridColor;                  // updates grid color on exit
            Properties.Settings.Default.TimerInterval = timer.Interval;
            Properties.Settings.Default.Rows = rows;
            Properties.Settings.Default.Columns = columns;

            Properties.Settings.Default.Save();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();

            graphicsPanel1.BackColor = Properties.Settings.Default.PanelColor; // background color
            cellColor = Properties.Settings.Default.CellColor;  // cell color
            gridColor = Properties.Settings.Default.GridColor;  // grid color
            rows = Properties.Settings.Default.Rows;            // height
            columns = Properties.Settings.Default.Columns;      // width
            timer.Interval = Properties.Settings.Default.TimerInterval; // timer speed

            universe = new bool[columns, rows];
            scratchPad = new bool[columns, rows];
            graphicsPanel1.Invalidate();
        }
        private void reload_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
            graphicsPanel1.BackColor = Properties.Settings.Default.PanelColor; // background color
            cellColor = Properties.Settings.Default.CellColor;  // cell color
            gridColor = Properties.Settings.Default.GridColor;  // grid color
            rows = Properties.Settings.Default.Rows;            // height
            columns = Properties.Settings.Default.Columns;      // width
            timer.Interval = Properties.Settings.Default.TimerInterval; // timer speed

            universe = new bool[columns, rows];
            scratchPad = new bool[columns, rows];
            graphicsPanel1.Invalidate();
        }

        private void sizeAndTime_Click(object sender, EventArgs e)
        {
            SettingsModal dialog = new SettingsModal();

            dialog.Timer = timer.Interval;
            dialog.Rows = rows;
            dialog.Columns = columns;

            if (DialogResult.OK == dialog.ShowDialog())
            {
                timer.Interval = dialog.Timer;
                rows = dialog.Rows;
                columns = dialog.Columns;
                universe = new bool[columns, rows];
                scratchPad = new bool[columns, rows];
                graphicsPanel1.Invalidate();
            }
        }

        private void showNeighborCount_Click(object sender, EventArgs e)
        {
            showNums = !showNums;
            graphicsPanel1.Invalidate();
        }

        private void gridOnOff_Click(object sender, EventArgs e)
        {
            showGrid = !showGrid;
            graphicsPanel1.Invalidate();
        }

        private void saveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "All Files|*.*|Cells|*.cells";
            dialog.FilterIndex = 2; dialog.DefaultExt = "cells";


            if (DialogResult.OK == dialog.ShowDialog())
            {
                StreamWriter writer = new StreamWriter(dialog.FileName);

                // Write any comments you want to include first.
                // Prefix all comment strings with an exclamation point.
                // Use WriteLine to write the strings to the file. 
                // It appends a CRLF for you.
                writer.WriteLine("!This is my comment.");

                // Iterate through the universe one row at a time.
                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    // Create a string to represent the current row.
                    String currentRow = string.Empty;
                    // Iterate through the current row one cell at a time.
                    for (int x = 0; x < universe.GetLength(0); x++)
                    {
                        // If the universe[x,y] is alive then append 'O' (capital O)
                        // to the row string.
                        if (universe[x, y] == true)
                        {
                            currentRow += "O";
                        }
                        // Else if the universe[x,y] is dead then append '.' (period)
                        // to the row string.
                        else if (universe[x, y] == false)
                        {
                            currentRow += ".";
                        }
                    }

                    // Once the current row has been read through and the 
                    // string constructed then write it to the file using WriteLine.
                    writer.WriteLine(currentRow);
                }

                // After all rows and columns have been written then close the file.
                writer.Close();
            }
        }

        private void open_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "All Files|.|Cells|*.cells";
            dialog.FilterIndex = 2;

            if (DialogResult.OK == dialog.ShowDialog())
            {
                StreamReader reader = new StreamReader(dialog.FileName);

                // Create a couple variables to calculate the width and height
                // of the data in the file.
                int maxWidth = 0;
                int maxHeight = 0;

                // Iterate through the file once to get its size.
                while (!reader.EndOfStream)
                {
                    // Read one row at a time.
                    string row = reader.ReadLine();

                    // If the row begins with '!' then it is a comment
                    // and should be ignored.
                    if (row.StartsWith("!"))
                    {
                        continue;
                    }
                    // If the row is not a comment then it is a row of cells.
                    // Increment the maxHeight variable for each row read.
                    else
                    {
                        maxHeight++;
                    }
                    // Get the length of the current row string
                    // and adjust the maxWidth variable if necessary.
                    maxWidth = row.Length;
                }
                // Resize the current universe and scratchPad
                // to the width and height of the file calculated above.
                universe = new bool[maxWidth, maxHeight];
                scratchPad = new bool[maxWidth, maxHeight];

                // Reset the file pointer back to the beginning of the file.
                reader.BaseStream.Seek(0, SeekOrigin.Begin);

                // yPos variable
                int yPos = 0;

                // Iterate through the file again, this time reading in the cells.
                while (!reader.EndOfStream)
                {
                    // Read one row at a time.
                    string row = reader.ReadLine();

                    // If the row begins with '!' then
                    // it is a comment and should be ignored.
                    if (row.StartsWith("!"))
                    {
                        continue;
                    }
                    // If the row is not a comment then 
                    // it is a row of cells and needs to be iterated through.




                    for (int xPos = 0; xPos < row.Length; xPos++)
                    {
                        // If row[xPos] is a 'O' (capital O) then
                        // set the corresponding cell in the universe to alive.
                        if (row[xPos] == 'O')
                        {
                            universe[xPos, yPos] = true;
                        }
                        // If row[xPos] is a '.' (period) then
                        // set the corresponding cell in the universe to dead.
                        if (row[xPos] == '.')
                        {
                            universe[xPos, yPos] = false;
                        }
                    }
                    yPos++;
                }
            }
        }

        private void hudOnOff_Click(object sender, EventArgs e)
        {
            showHUD = !showHUD;
            if (showHUD == true)
            {
                hudMode.Visible = true;
                hudWidth.Visible = true;
                hudHeight.Visible = true;
                hudCellCount.Visible = true;
                hudGenerations.Visible = true;
            }
            else
            {
                hudMode.Visible = false;
                hudWidth.Visible = false;
                hudHeight.Visible = false;
                hudCellCount.Visible = false;
                hudGenerations.Visible = false;
            }
            graphicsPanel1.Invalidate();
            graphicsPanel1.Invalidate();
        }
    }
}
