namespace Project
{
	partial class PointIODelaySetUI
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("根");
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PointIODelaySetUI));
			this.label4 = new System.Windows.Forms.Label();
			this.checkBox_andCheck = new System.Windows.Forms.CheckBox();
			this.MenuItem_Rename = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItem_Add = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuItem_Del = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.label3 = new System.Windows.Forms.Label();
			this.treeView_IO = new System.Windows.Forms.TreeView();
			this.label2 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.button4_AddIn = new System.Windows.Forms.Button();
			this.comboBox_Stat = new System.Windows.Forms.ComboBox();
			this.button3 = new System.Windows.Forms.Button();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button_Add = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(248, 57);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(71, 12);
			this.label4.TabIndex = 41;
			this.label4.Text = "输出IO控制2";
			// 
			// checkBox_andCheck
			// 
			this.checkBox_andCheck.AutoSize = true;
			this.checkBox_andCheck.Location = new System.Drawing.Point(999, 90);
			this.checkBox_andCheck.Name = "checkBox_andCheck";
			this.checkBox_andCheck.Size = new System.Drawing.Size(72, 16);
			this.checkBox_andCheck.TabIndex = 39;
			this.checkBox_andCheck.Text = "并行执行";
			this.checkBox_andCheck.UseVisualStyleBackColor = true;
			this.checkBox_andCheck.CheckedChanged += new System.EventHandler(this.checkBox_andCheck_CheckedChanged);
			// 
			// MenuItem_Rename
			// 
			this.MenuItem_Rename.Name = "MenuItem_Rename";
			this.MenuItem_Rename.Size = new System.Drawing.Size(112, 22);
			this.MenuItem_Rename.Text = "重命名";
			this.MenuItem_Rename.Click += new System.EventHandler(this.MenuItem_Rename_Click);
			// 
			// MenuItem_Add
			// 
			this.MenuItem_Add.Name = "MenuItem_Add";
			this.MenuItem_Add.Size = new System.Drawing.Size(112, 22);
			this.MenuItem_Add.Text = "添加";
			this.MenuItem_Add.Click += new System.EventHandler(this.MenuItem_Add_Click);
			// 
			// MenuItem_Del
			// 
			this.MenuItem_Del.Name = "MenuItem_Del";
			this.MenuItem_Del.Size = new System.Drawing.Size(112, 22);
			this.MenuItem_Del.Text = "删除";
			this.MenuItem_Del.Click += new System.EventHandler(this.MenuItem_Del_Click);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Del,
            this.MenuItem_Add,
            this.MenuItem_Rename});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(113, 70);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(741, 57);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 12);
			this.label3.TabIndex = 40;
			this.label3.Text = "安全io设置";
			// 
			// treeView_IO
			// 
			this.treeView_IO.ContextMenuStrip = this.contextMenuStrip1;
			this.treeView_IO.Location = new System.Drawing.Point(12, 12);
			this.treeView_IO.Name = "treeView_IO";
			treeNode1.Name = "节点0";
			treeNode1.Text = "根";
			this.treeView_IO.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
			this.treeView_IO.Size = new System.Drawing.Size(223, 419);
			this.treeView_IO.TabIndex = 38;
			this.treeView_IO.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeView_IO_AfterLabelEdit);
			this.treeView_IO.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_IO_NodeMouseDoubleClick);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(741, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 12);
			this.label2.TabIndex = 37;
			this.label2.Text = "到位io设置";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(862, 87);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(102, 23);
			this.button2.TabIndex = 36;
			this.button2.Text = "配置为安全IO";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(248, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 12);
			this.label1.TabIndex = 35;
			this.label1.Text = "输出IO控制1";
			// 
			// button4_AddIn
			// 
			this.button4_AddIn.Location = new System.Drawing.Point(488, 87);
			this.button4_AddIn.Name = "button4_AddIn";
			this.button4_AddIn.Size = new System.Drawing.Size(84, 23);
			this.button4_AddIn.TabIndex = 34;
			this.button4_AddIn.Text = "添加到工位";
			this.button4_AddIn.UseVisualStyleBackColor = true;
			this.button4_AddIn.Click += new System.EventHandler(this.button4_AddIn_Click);
			// 
			// comboBox_Stat
			// 
			this.comboBox_Stat.FormattingEnabled = true;
			this.comboBox_Stat.Location = new System.Drawing.Point(578, 90);
			this.comboBox_Stat.Name = "comboBox_Stat";
			this.comboBox_Stat.Size = new System.Drawing.Size(157, 20);
			this.comboBox_Stat.TabIndex = 33;
			this.comboBox_Stat.SelectedIndexChanged += new System.EventHandler(this.comboBox_Stat_SelectedIndexChanged);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(764, 87);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 32;
			this.button3.Text = "配置为IO1";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// listBox2
			// 
			this.listBox2.FormattingEnabled = true;
			this.listBox2.ItemHeight = 12;
			this.listBox2.Location = new System.Drawing.Point(764, 116);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(238, 340);
			this.listBox2.TabIndex = 31;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(383, 87);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(92, 23);
			this.button1.TabIndex = 30;
			this.button1.Text = "配置为输出IO2";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button_Add
			// 
			this.button_Add.Location = new System.Drawing.Point(280, 87);
			this.button_Add.Name = "button_Add";
			this.button_Add.Size = new System.Drawing.Size(100, 23);
			this.button_Add.TabIndex = 29;
			this.button_Add.Text = "配置为输出IO1";
			this.button_Add.UseVisualStyleBackColor = true;
			this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 12;
			this.listBox1.Location = new System.Drawing.Point(280, 116);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(292, 340);
			this.listBox1.TabIndex = 28;
			// 
			// PointIODelaySetUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1114, 552);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.checkBox_andCheck);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.treeView_IO);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button4_AddIn);
			this.Controls.Add(this.comboBox_Stat);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.listBox2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button_Add);
			this.Controls.Add(this.listBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "PointIODelaySetUI";
			this.Text = "PointIODelaySetControl";
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox checkBox_andCheck;
		private System.Windows.Forms.ToolStripMenuItem MenuItem_Rename;
		private System.Windows.Forms.ToolStripMenuItem MenuItem_Add;
		private System.Windows.Forms.ToolStripMenuItem MenuItem_Del;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TreeView treeView_IO;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button4_AddIn;
		private System.Windows.Forms.ComboBox comboBox_Stat;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button_Add;
		private System.Windows.Forms.ListBox listBox1;
	}
}