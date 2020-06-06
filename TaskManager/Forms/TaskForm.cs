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
using System.Xml.Linq;

namespace TaskManager
{
    public partial class TaskForm : Form
    {
        private static TaskForm instance;
        public static TaskForm Instance {
            get {
                if (instance is null)
                    instance = new TaskForm();
                return instance;
            }
        }

        private string savePath = Path.Combine(Directory.GetCurrentDirectory(), "saves");

        private ImageList small_icons = new ImageList();
        private ImageList large_icons = new ImageList();

        public StatusStrip StatusStrip { get; }

        public IList<Model.Task> Tasks { get; set; } = new List<Model.Task>();

        public TaskForm()
        {
            InitializeComponent();

            StatusStrip = statusStrip;
        }

        private void TaskForm_Load(object sender, EventArgs e)
        {
            if(File.Exists(savePath + "//saves.task"))
                LoadTasks();

            StatusStrip.Items[0].Image = Properties.Resources.WavingHand;
            SetupIconLists();
            DisplayTasks();
        }

        private void ToolStripButton_add_Click(object sender, EventArgs e)
        {
            AddForm form = new AddForm();

            if (form.ShowDialog() != DialogResult.OK)
                return;

            listView_tasks.Items.Clear();
            DisplayTasks();
        }

        private void ToolStripButton_remove_Click(object sender, EventArgs e)
        {
            Model.Task task = listView_tasks.SelectedItems[0].Tag as Model.Task;
            if (task is null)
                throw new ArgumentNullException("Ошибка при удалении. Аргумент пустой.", nameof(task));

            Tasks.Remove(task);
            listView_tasks.Items.Clear();
            DisplayTasks();

            StatusStrip.Items[0].Text = "Task deleted.";
            StatusStrip.Items[0].Image = Properties.Resources.Cancel;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DisplayTasks()
        {
            foreach (Model.Task task in Tasks)
            {
                ListViewItem item = new ListViewItem(task.Title);
                item.SubItems.Add(task.Note);
                item.ImageIndex = (int)task.TaskType;
                item.Tag = task;
                listView_tasks.Items.Add(item);
            }
        }

        private void SetupIconLists()
        {
            small_icons.ImageSize = new Size(20, 20);
            large_icons.ImageSize = new Size(100, 100);
            listView_tasks.SmallImageList = small_icons;
            listView_tasks.LargeImageList = large_icons;
            LoadIconsTo(small_icons);
            LoadIconsTo(large_icons);
        }

        private static void LoadIconsTo(ImageList imageList)
        {
            imageList.Images.Add(Properties.Resources.Job);
            imageList.Images.Add(Properties.Resources.Study);
            imageList.Images.Add(Properties.Resources.Family);
            imageList.Images.Add(Properties.Resources.Home);
        }

        private void toolStripButton_moveUp_Click(object sender, EventArgs e)
        {
            if (listView_tasks.SelectedItems.Count == 0)
            {
                StatusStrip.Items[0].Text = "Select item first to move tasks";
                StatusStrip.Items[0].Image = Properties.Resources.Stop;
                return;
            }

            Model.Task task = listView_tasks.SelectedItems[0].Tag as Model.Task;
            int taskIndex = Tasks.IndexOf(task);
            if (taskIndex - 1 < 0)
                return;

            Model.Task temp = Tasks[taskIndex];
            Tasks[taskIndex] = Tasks[taskIndex - 1];
            Tasks[taskIndex - 1] = temp;

            listView_tasks.Items.Clear();
            DisplayTasks();
            listView_tasks.Items[taskIndex - 1].Selected = true;
        }

        private void toolStripButton_moveDown_Click(object sender, EventArgs e)
        {
            if (listView_tasks.SelectedItems.Count == 0)
            {
                StatusStrip.Items[0].Text = "Select item first to move tasks";
                StatusStrip.Items[0].Image = Properties.Resources.Stop;
                return;
            }

            Model.Task task = listView_tasks.SelectedItems[0].Tag as Model.Task;
            int taskIndex = Tasks.IndexOf(task);
            if (taskIndex + 1 >= Tasks.Count)
                return;

            Model.Task temp = Tasks[taskIndex];
            Tasks[taskIndex] = Tasks[taskIndex + 1];
            Tasks[taskIndex + 1] = temp;

            listView_tasks.Items.Clear();
            DisplayTasks();
            listView_tasks.Items[taskIndex + 1].Selected = true;
        }

        private void TaskForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("You sure want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;

            SaveTasks();
        }

        private void SaveTasks()
        {
            XElement xElement = new XElement("tasks", Tasks.Select(task => task.ToXml()));

            if (!Directory.Exists(savePath))
                Directory.CreateDirectory(savePath);
            xElement.Save(Path.Combine(savePath, "saves.task"));
        }

        private void LoadTasks() =>
            Tasks = XElement.Load(Path.Combine(savePath, "saves.task"))
                .Elements("task")
                .Select(node => Model.Task.FromXml(node))
                .ToList(); 
    }
}
