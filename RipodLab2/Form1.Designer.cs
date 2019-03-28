namespace RipodLab2
{
    public partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView matrixGridView;
        private System.Windows.Forms.DataGridView resultGridView;
        private System.Windows.Forms.TrackBar tasksTrackBar;
        private System.Windows.Forms.TextBox typeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label taskLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button planButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn stepColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeAddColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeMulColumn;

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
            this.matrixGridView = new System.Windows.Forms.DataGridView();
            this.resultGridView = new System.Windows.Forms.DataGridView();
            this.stepColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeAddColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeMulColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tasksTrackBar = new System.Windows.Forms.TrackBar();
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.taskLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.planButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.matrixGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // matrixGridView
            // 
            this.matrixGridView.AllowUserToAddRows = false;
            this.matrixGridView.AllowUserToDeleteRows = false;
            this.matrixGridView.AllowUserToResizeColumns = false;
            this.matrixGridView.AllowUserToResizeRows = false;
            this.matrixGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.matrixGridView.ColumnHeadersHeight = 15;
            this.matrixGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.matrixGridView.ColumnHeadersVisible = false;
            this.matrixGridView.Location = new System.Drawing.Point(12, 12);
            this.matrixGridView.MultiSelect = false;
            this.matrixGridView.Name = "matrixGridView";
            this.matrixGridView.RowHeadersVisible = false;
            this.matrixGridView.RowHeadersWidth = 15;
            this.matrixGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.matrixGridView.RowTemplate.Height = 15;
            this.matrixGridView.Size = new System.Drawing.Size(265, 265);
            this.matrixGridView.TabIndex = 0;
            // 
            // resultGridView
            // 
            this.resultGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stepColumn,
            this.taskColumn,
            this.typeAddColumn,
            this.typeMulColumn});
            this.resultGridView.Location = new System.Drawing.Point(12, 287);
            this.resultGridView.Name = "resultGridView";
            this.resultGridView.RowHeadersVisible = false;
            this.resultGridView.Size = new System.Drawing.Size(265, 153);
            this.resultGridView.TabIndex = 1;
            // 
            // stepColumn
            // 
            this.stepColumn.HeaderText = "Шаг";
            this.stepColumn.Name = "stepColumn";
            this.stepColumn.ReadOnly = true;
            this.stepColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.stepColumn.Width = 50;
            // 
            // taskColumn
            // 
            this.taskColumn.HeaderText = "Операции";
            this.taskColumn.Name = "taskColumn";
            this.taskColumn.ReadOnly = true;
            this.taskColumn.Width = 112;
            // 
            // typeAddColumn
            // 
            this.typeAddColumn.HeaderText = "Тип +";
            this.typeAddColumn.Name = "typeAddColumn";
            this.typeAddColumn.ReadOnly = true;
            this.typeAddColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.typeAddColumn.Width = 50;
            // 
            // typeMulColumn
            // 
            this.typeMulColumn.HeaderText = "Тип *";
            this.typeMulColumn.Name = "typeMulColumn";
            this.typeMulColumn.ReadOnly = true;
            this.typeMulColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.typeMulColumn.Width = 50;
            // 
            // tasksTrackBar
            // 
            this.tasksTrackBar.LargeChange = 1;
            this.tasksTrackBar.Location = new System.Drawing.Point(397, 12);
            this.tasksTrackBar.Maximum = 16;
            this.tasksTrackBar.Minimum = 12;
            this.tasksTrackBar.Name = "tasksTrackBar";
            this.tasksTrackBar.Size = new System.Drawing.Size(104, 45);
            this.tasksTrackBar.TabIndex = 2;
            this.tasksTrackBar.Value = 12;
            this.tasksTrackBar.Scroll += new System.EventHandler(this.TasksTrackBar_Scroll);
            // 
            // typeTextBox
            // 
            this.typeTextBox.Location = new System.Drawing.Point(359, 63);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(138, 20);
            this.typeTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Количество вершин";
            // 
            // taskLabel
            // 
            this.taskLabel.AutoSize = true;
            this.taskLabel.Location = new System.Drawing.Point(507, 13);
            this.taskLabel.Name = "taskLabel";
            this.taskLabel.Size = new System.Drawing.Size(0, 13);
            this.taskLabel.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Типы задач";
            // 
            // planButton
            // 
            this.planButton.Location = new System.Drawing.Point(426, 417);
            this.planButton.Name = "planButton";
            this.planButton.Size = new System.Drawing.Size(75, 23);
            this.planButton.TabIndex = 7;
            this.planButton.Text = "План";
            this.planButton.UseVisualStyleBackColor = true;
            this.planButton.Click += new System.EventHandler(this.PlanButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 452);
            this.Controls.Add(this.planButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.taskLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.tasksTrackBar);
            this.Controls.Add(this.resultGridView);
            this.Controls.Add(this.matrixGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.matrixGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tasksTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}