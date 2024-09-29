using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace TaskManager
{
    public partial class Form1 : Form
    {
        private List<Task> tasksList = new List<Task>();
        private System.Windows.Forms.Timer taskTimer;
        public Form1()
        {
            InitializeComponent();

            listBox1.DrawMode = DrawMode.OwnerDrawFixed;
            listBox1.DrawItem += ListBox1_DrawItem;

            taskTimer = new System.Windows.Forms.Timer();
            taskTimer.Interval = 60000;
            taskTimer.Tick += TaskTimer_Tick;
            taskTimer.Start();
        }

        private void MurkAsComplete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                tasksList[listBox1.SelectedIndex].IsCompleted = true;
            }

            listBox1.Invalidate();
        }

        private void AddTask_Click(object sender, EventArgs e)
        {
            string taskTitle = textBox1.Text;
            DateTime dueTime = dateTimePicker1.Value;

            if (!string.IsNullOrWhiteSpace(taskTitle))
            {
                Task task = new Task(taskTitle, dueTime);
                tasksList.Add(task);

                listBox1.Items.Add(task);

                textBox1.Clear();
            }

            else
            {
                MessageBox.Show("Введите название задачи.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteTask_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                tasksList.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }

            listBox1.Invalidate();
        }

        private void ListBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            Task selectedTask = tasksList[e.Index];
            e.DrawBackground();

            Color textColor = selectedTask.IsCompleted ? Color.Red : Color.Green;
            e.Graphics.DrawString(listBox1.Items[e.Index].ToString(), e.Font, new SolidBrush(textColor), e.Bounds);

            e.DrawFocusRectangle();
        }

        private void TaskTimer_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            var dueTasks = tasksList.Where(task => !task.IsCompleted && task.DueTime <= currentTime);

            foreach (var task in dueTasks)
            {
                MessageBox.Show($"Пришло время для выполнения задачи {task.Title}.", "Напоминание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                task.IsCompleted = true;
            }

            listBox1.Invalidate();
        }
    }
}
