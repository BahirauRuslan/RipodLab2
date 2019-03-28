using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RipodLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.InitializeComponent();
            this.TasksTrackBar_Scroll(this, null);
        }

        private void TasksTrackBar_Scroll(object sender, EventArgs e)
        {
            this.taskLabel.Text = this.tasksTrackBar.Value.ToString();
            this.typeTextBox.MaxLength = this.tasksTrackBar.Value;
            this.SetSizeToMatrixGridView(this.tasksTrackBar.Value);
            this.FillMatrixGridView("0");
        }

        private void SetSizeToMatrixGridView(int size)
        {
            if (size < 0)
            {
                throw new ArgumentException();
            }

            this.matrixGridView.ColumnCount = size;
            this.matrixGridView.RowCount = size;
        }

        private void FillMatrixGridView(string fillMark)
        {
            for (var i = 0; i < this.matrixGridView.RowCount; i++)
            {
                for (var j = i; j < this.matrixGridView.ColumnCount; j++)
                {
                    this.matrixGridView[j, i].Value = fillMark;
                }
            }
        }

        private void PlanButton_Click(object sender, EventArgs e)
        {
            var graph = new GraphConstructor().ConstructGraph(this.matrixGridView, this.typeTextBox.Text);
        }
    }
}
