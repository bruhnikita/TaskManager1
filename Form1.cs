namespace TaskManager
{
    public partial class Form1 : Form
    {
        private List<Task> tasksList = new List<Task>();
        public Form1()
        {
            InitializeComponent();

            listBox1.DrawMode = DrawMode.OwnerDrawFixed;
            listBox1.DrawItem += ListBox1_DrawItem;
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

            if (!string.IsNullOrWhiteSpace(taskTitle))
            {
                Task task = new Task(taskTitle);
                tasksList.Add(task);

                listBox1.Items.Add(task);

                textBox1.Clear();
            }

            else
            {
                MessageBox.Show("¬ведите название задачи.", "ќшибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}
