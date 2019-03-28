using System;
using System.Collections.Generic;
using System.Text;
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
                for (var j = 0; j < this.matrixGridView.ColumnCount; j++)
                {
                    this.matrixGridView[j, i].Value = fillMark;
                }
            }
        }

        private void PlanButton_Click(object sender, EventArgs e)
        {
            var graph = new GraphConstructor().ConstructGraph(this.matrixGridView, this.typeTextBox.Text);
            var plan = new Plan(graph);
            this.FillResultGridView(plan);
        }

        private void FillResultGridView(Plan plan)
        {
            int number = 0;
            this.resultGridView.RowCount = plan.GetSteps().Count;
            foreach (var step in plan.GetSteps())
            {
                this.resultGridView[0, number].Value = (number + 1).ToString();
                this.resultGridView[1, number].Value = this.TasksInStep(step);
                this.resultGridView[2, number].Value = plan.GetCountType(number, "+");
                this.resultGridView[3, number].Value = plan.GetCountType(number++, "*");
            }
        }

        private string TasksInStep(IList<Node> step)
        {
            var builder = new StringBuilder();

            foreach (Node node in step)
            {
                builder.Append($"{ node.Value }{ node.Type }");
                builder.Append(" ");
            }

            return builder.ToString();
        }
    }
}
