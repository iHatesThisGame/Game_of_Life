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
    public partial class SettingsModal : Form
    {
        public SettingsModal()
        {
            InitializeComponent();
        }

        public int Timer
        {
            get { return (int)numericUpDownTimer.Value; }
            set { numericUpDownTimer.Value = value; }
        }

        public int Rows
        {
            get { return (int)numericUpDownRows.Value; }
            set { numericUpDownRows.Value = value; }
        }

        public int Columns
        {
            get { return (int)numericUpDownColumns.Value; }
            set { numericUpDownColumns.Value = value; }
        }
    }
}
