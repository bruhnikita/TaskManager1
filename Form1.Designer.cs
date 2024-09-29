namespace TaskManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MurkAsComplete = new Button();
            DeleteTask = new Button();
            AddTask = new Button();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // MurkAsComplete
            // 
            MurkAsComplete.BackColor = Color.Orange;
            MurkAsComplete.Location = new Point(515, 12);
            MurkAsComplete.Name = "MurkAsComplete";
            MurkAsComplete.Size = new Size(342, 44);
            MurkAsComplete.TabIndex = 1;
            MurkAsComplete.Text = "Отметить выполненной";
            MurkAsComplete.UseVisualStyleBackColor = false;
            MurkAsComplete.Click += MurkAsComplete_Click;
            // 
            // DeleteTask
            // 
            DeleteTask.BackColor = Color.Orange;
            DeleteTask.Location = new Point(515, 112);
            DeleteTask.Name = "DeleteTask";
            DeleteTask.Size = new Size(342, 44);
            DeleteTask.TabIndex = 1;
            DeleteTask.Text = "Удалить задачу";
            DeleteTask.UseVisualStyleBackColor = false;
            DeleteTask.Click += DeleteTask_Click;
            // 
            // AddTask
            // 
            AddTask.BackColor = Color.Orange;
            AddTask.Location = new Point(515, 62);
            AddTask.Name = "AddTask";
            AddTask.Size = new Size(342, 44);
            AddTask.TabIndex = 1;
            AddTask.Text = "Добавить задачу";
            AddTask.UseVisualStyleBackColor = false;
            AddTask.Click += AddTask_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(497, 524);
            listBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(524, 170);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(333, 27);
            textBox1.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(524, 213);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(333, 27);
            dateTimePicker1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(869, 548);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(AddTask);
            Controls.Add(DeleteTask);
            Controls.Add(MurkAsComplete);
            Name = "Form1";
            Text = "Менеджер задач";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button MurkAsComplete;
        private Button DeleteTask;
        private Button AddTask;
        private ListBox listBox1;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
    }
}
