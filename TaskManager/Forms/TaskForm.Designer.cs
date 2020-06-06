namespace TaskManager
{
    partial class TaskForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskForm));
            this.listView_tasks = new System.Windows.Forms.ListView();
            this.columnHeader_taskTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_note = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movedownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_add = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_remove = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_moveUp = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_moveDown = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_message = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_tasks
            // 
            this.listView_tasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_tasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_taskTitle,
            this.columnHeader_note});
            this.listView_tasks.FullRowSelect = true;
            this.listView_tasks.HideSelection = false;
            this.listView_tasks.Location = new System.Drawing.Point(0, 72);
            this.listView_tasks.MultiSelect = false;
            this.listView_tasks.Name = "listView_tasks";
            this.listView_tasks.Size = new System.Drawing.Size(984, 354);
            this.listView_tasks.TabIndex = 0;
            this.listView_tasks.UseCompatibleStateImageBehavior = false;
            this.listView_tasks.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_taskTitle
            // 
            this.columnHeader_taskTitle.Text = "Title";
            this.columnHeader_taskTitle.Width = 180;
            // 
            // columnHeader_note
            // 
            this.columnHeader_note.Text = "Note";
            this.columnHeader_note.Width = 500;
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(982, 28);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moveUpToolStripMenuItem,
            this.movedownToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripMenuItem2,
            this.removeTaskToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // moveUpToolStripMenuItem
            // 
            this.moveUpToolStripMenuItem.Name = "moveUpToolStripMenuItem";
            this.moveUpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Up)));
            this.moveUpToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.moveUpToolStripMenuItem.Text = "Move &Up";
            this.moveUpToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton_moveUp_Click);
            // 
            // movedownToolStripMenuItem
            // 
            this.movedownToolStripMenuItem.Name = "movedownToolStripMenuItem";
            this.movedownToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Down)));
            this.movedownToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.movedownToolStripMenuItem.Text = "Move &Down";
            this.movedownToolStripMenuItem.Click += new System.EventHandler(this.toolStripButton_moveDown_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(242, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.toolStripMenuItem2.Size = new System.Drawing.Size(245, 26);
            this.toolStripMenuItem2.Text = "&Add Tast...";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.ToolStripButton_add_Click);
            // 
            // removeTaskToolStripMenuItem
            // 
            this.removeTaskToolStripMenuItem.Name = "removeTaskToolStripMenuItem";
            this.removeTaskToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.removeTaskToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.removeTaskToolStripMenuItem.Text = "&Remove Task";
            this.removeTaskToolStripMenuItem.Click += new System.EventHandler(this.ToolStripButton_remove_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.GripMargin = new System.Windows.Forms.Padding(10);
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_add,
            this.toolStripButton_remove,
            this.toolStripSeparator6,
            this.toolStripButton_moveUp,
            this.toolStripButton_moveDown});
            this.toolStrip.Location = new System.Drawing.Point(0, 28);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(982, 39);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripButton_add
            // 
            this.toolStripButton_add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_add.Image = global::TaskManager.Properties.Resources.Add;
            this.toolStripButton_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_add.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
            this.toolStripButton_add.Name = "toolStripButton_add";
            this.toolStripButton_add.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton_add.Text = "Add";
            this.toolStripButton_add.Click += new System.EventHandler(this.ToolStripButton_add_Click);
            // 
            // toolStripButton_remove
            // 
            this.toolStripButton_remove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_remove.Image = global::TaskManager.Properties.Resources.Cancel;
            this.toolStripButton_remove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_remove.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.toolStripButton_remove.Name = "toolStripButton_remove";
            this.toolStripButton_remove.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton_remove.Text = "Remove";
            this.toolStripButton_remove.Click += new System.EventHandler(this.ToolStripButton_remove_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripButton_moveUp
            // 
            this.toolStripButton_moveUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_moveUp.Image = global::TaskManager.Properties.Resources.ArrowUp;
            this.toolStripButton_moveUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_moveUp.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
            this.toolStripButton_moveUp.Name = "toolStripButton_moveUp";
            this.toolStripButton_moveUp.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton_moveUp.Text = "Move Task Up";
            this.toolStripButton_moveUp.Click += new System.EventHandler(this.toolStripButton_moveUp_Click);
            // 
            // toolStripButton_moveDown
            // 
            this.toolStripButton_moveDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_moveDown.Image = global::TaskManager.Properties.Resources.ArrowDown;
            this.toolStripButton_moveDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_moveDown.Name = "toolStripButton_moveDown";
            this.toolStripButton_moveDown.Size = new System.Drawing.Size(36, 36);
            this.toolStripButton_moveDown.Text = "Move Task Down";
            this.toolStripButton_moveDown.Click += new System.EventHandler(this.toolStripButton_moveDown_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_message});
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(982, 25);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel_message
            // 
            this.toolStripStatusLabel_message.Margin = new System.Windows.Forms.Padding(5, 3, 0, 2);
            this.toolStripStatusLabel_message.Name = "toolStripStatusLabel_message";
            this.toolStripStatusLabel_message.Size = new System.Drawing.Size(71, 20);
            this.toolStripStatusLabel_message.Text = "Welcome";
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.listView_tasks);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "TaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TaskForm_FormClosing);
            this.Load += new System.EventHandler(this.TaskForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_tasks;
        private System.Windows.Forms.ColumnHeader columnHeader_taskTitle;
        private System.Windows.Forms.ColumnHeader columnHeader_note;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButton_add;
        private System.Windows.Forms.ToolStripButton toolStripButton_remove;
        private System.Windows.Forms.ToolStripButton toolStripButton_moveDown;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButton_moveUp;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_message;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movedownToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem removeTaskToolStripMenuItem;
    }
}

