using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        bool toroidal = false;

        // Drawing colors
        Color gridColor = Color.Black;
        Color cellColor = Color.Gray;

        // The Timer class
        Timer timer = new Timer();

        // Generation count
        int generations = 0;


public Form1()
        {
            InitializeComponent();

            // Set default colors
            BackColor = Properties.Settings.Default.PanelColor; // background color
            cellColor = Properties.Settings.Default.CellColor;  // cell color
            gridColor = Properties.Settings.Default.GridColor;  // grid color

            // Setup the timer
            timer.Interval = 100; // milliseconds
            timer.Tick += Timer_Tick;
            timer.Enabled = false; // start timer running
        }

        // Calculate the next generation of cells
        private void NextGeneration()
        {
            bool[,] scratchPad = new bool[30, 30];

            //string toroidalCheck = "";

            //if (toroidal == true)
            //{
            //    toroidalCheck = "Toroidal mode";
            //}
            //else if (toroidal == false)
            //{
            //    toroidalCheck = "Finite mode";
            //}

            if (toroidal == true)
            {
                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    for (int x = 0; x < universe.GetLength(0); x++)
                    {
                        int neighbors = CountNeighborsToroidal(x, y);
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
                    }
                } 
            }
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
                    }
                }
            }


            bool[,] temp = universe;
            universe = scratchPad;
            scratchPad = temp;

            for (int y = 0; y < scratchPad.GetLength(1); y++)
            {
                for (int x = 0; x < scratchPad.GetLength(0); x++)
                {
                    scratchPad[x, y] = false;
                }
            }

            // Increment generation count
            generations++;

            // Update status strip generations
            toolStripStatusLabelGenerations.Text = "Generations = " + generations.ToString()/* + " " + toroidalCheck*/;

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
            int cellWidth = graphicsPanel1.ClientSize.Width / universe.GetLength(0);
            // CELL HEIGHT = WINDOW HEIGHT / NUMBER OF CELLS IN Y
            int cellHeight = graphicsPanel1.ClientSize.Height / universe.GetLength(1);

            // A Pen for drawing the grid lines (color, width)
            Pen gridPen = new Pen(gridColor, 1);

            // A Brush for filling living cells interiors (color)
            Brush cellBrush = new SolidBrush(cellColor);

            // Iterate through the universe in the y, top to bottom
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                // Iterate through the universe in the x, left to right
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    // A rectangle to represent each cell in pixels
                    Rectangle cellRect = Rectangle.Empty;
                    cellRect.X = x * cellWidth;
                    cellRect.Y = y * cellHeight;
                    cellRect.Width = cellWidth;
                    cellRect.Height = cellHeight;

                    // Fill the cell with a brush if alive
                    if (universe[x, y] == true)
                    {
                        e.Graphics.FillRectangle(cellBrush, cellRect);
                    }

                    // Outline the cell with a pen
                    e.Graphics.DrawRectangle(gridPen, cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height);
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
                int cellWidth = graphicsPanel1.ClientSize.Width / universe.GetLength(0);
                int cellHeight = graphicsPanel1.ClientSize.Height / universe.GetLength(1);

                // Calculate the cell that was clicked in
                // CELL X = MOUSE X / CELL WIDTH
                int x = e.X / cellWidth;
                // CELL Y = MOUSE Y / CELL HEIGHT
                int y = e.Y / cellHeight;

                // Toggle the cell's state
                universe[x, y] = !universe[x, y];

                // Tell Windows you need to repaint
                graphicsPanel1.Invalidate();
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
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
                        xCheck = xLen -1;
                    }
                    if (yCheck < 0)
                    {
                        yCheck = yLen -1;
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

        private void newToolStripButton_Click(object sender, EventArgs e)                           // terrible variable name. this is "New" option in the menu
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

            toolStripStatusLabelGenerations.Text = "Generations = " + generations.ToString()/* + " " + toroidalCheck*/;

            graphicsPanel1.Invalidate();
        }

        private void newRandomSeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rng = new Random();

            timer.Enabled = false;
            generations = 0;

            toolStripStatusLabelGenerations.Text = "Generations = " + generations.ToString()/* + " " + toroidalCheck*/;

            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    universe[x, y] = false;
                }
            }

            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    universe[x, y] = rng.Next(2) == 1;
                }
            }
            graphicsPanel1.Invalidate();
        }

        private void backgroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.Color = graphicsPanel1.BackColor;
            if (DialogResult.OK == dialog.ShowDialog())
            {
                graphicsPanel1.BackColor = dialog.Color;
                graphicsPanel1.Invalidate();
            }
        }

        private void cellColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.Color = cellColor;
            if (DialogResult.OK == dialog.ShowDialog())
            {
                cellColor = dialog.Color;
                graphicsPanel1.Invalidate();
            }
        }

        private void gridColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.Color = gridColor;
            if (DialogResult.OK == dialog.ShowDialog())
            {
                gridColor = dialog.Color;
                graphicsPanel1.Invalidate();
            }
        }

        private void toroidalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toroidal = true;        // set mode to toroidal
        }

        private void finiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toroidal = false;       // set mode to finite
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.PanelColor = graphicsPanel1.BackColor;  // updates background color on exit
            Properties.Settings.Default.CellColor = cellColor;                  // updates cell color on exit
            Properties.Settings.Default.GridColor = gridColor;                  // updates grid color on exit

            Properties.Settings.Default.Save();
        }
    }
}