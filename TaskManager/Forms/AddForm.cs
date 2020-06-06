using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();

            ((Model.TaskType[])Enum.GetValues(typeof(Model.TaskType))).ToList()
                .ForEach(type => comboBox_taskType.Items.Add(type));
        }

        private void Button_add_Click(object sender, EventArgs e)
        {
            if (comboBox_taskType.SelectedIndex == -1)
            {
                TaskForm.Instance.StatusStrip.Items[0].Text = "Error! Task type should be selected.";
                TaskForm.Instance.StatusStrip.Items[0].Image = Properties.Resources.Error;
                Close();
                return;
            }

            TaskForm.Instance.Tasks.Add(
                    new Model.Task()
                    {
                        Title = textBox_title.Text,
                        Note = richTextBox_note.Text,
                        TaskType = (Model.TaskType)comboBox_taskType.SelectedItem
                    }
                );

            DialogResult = DialogResult.OK;
            TaskForm.Instance.StatusStrip.Items[0].Text = "Task added!";
            TaskForm.Instance.StatusStrip.Items[0].Image = Properties.Resources.Accept;

            Close();
        }

        private void Button_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            TaskForm.Instance.StatusStrip.Items[0].Text = "Task addition canceled.";
            TaskForm.Instance.StatusStrip.Items[0].Image = Properties.Resources.Stop;

            Close();
        }
    }
}
