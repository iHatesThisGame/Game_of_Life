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

        public int GetTimerInterval()
        {
            return (int)numericUpDownTimer.Value;
        }

        public void SetTimerInterval(int number)
        {
            numericUpDownTimer.Value = number;
        }

        public int GetRows()
        {
            return (int)numericUpDownRows.Value;
        }

        public void SetRows(int number)
        {
            numericUpDownRows.Value = number;
        }

        public int GetColumns()
        {
            return (int)numericUpDownColumns.Value;
        }

        public void SetColums(int number)
        {
            numericUpDownColumns.Value = number;
        }
    }
}
