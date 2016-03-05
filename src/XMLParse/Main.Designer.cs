namespace CCParser {
	partial class Main {
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent() {
			this.men = new System.Windows.Forms.MenuStrip();
			this.meu_item_file = new System.Windows.Forms.ToolStripMenuItem();
			this.meu_open = new System.Windows.Forms.ToolStripMenuItem();
			this.meu_save = new System.Windows.Forms.ToolStripMenuItem();
			this.meu_save_as = new System.Windows.Forms.ToolStripMenuItem();
			this.meu_item_addnode = new System.Windows.Forms.ToolStripMenuItem();
			this.meu_item_delete_node = new System.Windows.Forms.ToolStripMenuItem();
			this.ofd = new System.Windows.Forms.OpenFileDialog();
			this.spl_main = new System.Windows.Forms.SplitContainer();
			this.tree = new System.Windows.Forms.TreeView();
			this.spl_right = new System.Windows.Forms.SplitContainer();
			this.panel_right_down = new System.Windows.Forms.Panel();
			this.btn_delete = new System.Windows.Forms.Button();
			this.btn_add = new System.Windows.Forms.Button();
			this.btn_change = new System.Windows.Forms.Button();
			this.tex_attrivalue = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tex_attriname = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lsv_attribute = new System.Windows.Forms.ListView();
			this.attr_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.attr_value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.rch_text = new System.Windows.Forms.RichTextBox();
			this.sfd = new System.Windows.Forms.SaveFileDialog();
			this.men.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.spl_main)).BeginInit();
			this.spl_main.Panel1.SuspendLayout();
			this.spl_main.Panel2.SuspendLayout();
			this.spl_main.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.spl_right)).BeginInit();
			this.spl_right.Panel1.SuspendLayout();
			this.spl_right.Panel2.SuspendLayout();
			this.spl_right.SuspendLayout();
			this.panel_right_down.SuspendLayout();
			this.SuspendLayout();
			// 
			// men
			// 
			this.men.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meu_item_file,
            this.meu_item_addnode,
            this.meu_item_delete_node});
			this.men.Location = new System.Drawing.Point(0, 0);
			this.men.Name = "men";
			this.men.Size = new System.Drawing.Size(997, 24);
			this.men.TabIndex = 4;
			this.men.Text = "menuStrip1";
			// 
			// meu_item_file
			// 
			this.meu_item_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meu_open,
            this.meu_save,
            this.meu_save_as});
			this.meu_item_file.Name = "meu_item_file";
			this.meu_item_file.Size = new System.Drawing.Size(41, 20);
			this.meu_item_file.Text = "File";
			// 
			// meu_open
			// 
			this.meu_open.Name = "meu_open";
			this.meu_open.Size = new System.Drawing.Size(152, 22);
			this.meu_open.Text = "Open(&O)";
			this.meu_open.Click += new System.EventHandler(this.meu_open_Click);
			// 
			// meu_save
			// 
			this.meu_save.Name = "meu_save";
			this.meu_save.Size = new System.Drawing.Size(152, 22);
			this.meu_save.Text = "Save(&S)";
			this.meu_save.Click += new System.EventHandler(this.meu_save_Click);
			// 
			// meu_save_as
			// 
			this.meu_save_as.Name = "meu_save_as";
			this.meu_save_as.Size = new System.Drawing.Size(152, 22);
			this.meu_save_as.Text = "Save as(&D)";
			this.meu_save_as.Click += new System.EventHandler(this.meu_save_as_Click);
			// 
			// meu_item_addnode
			// 
			this.meu_item_addnode.Name = "meu_item_addnode";
			this.meu_item_addnode.Size = new System.Drawing.Size(65, 20);
			this.meu_item_addnode.Text = "Add Node";
			this.meu_item_addnode.Click += new System.EventHandler(this.meu_item_addnode_Click);
			// 
			// meu_item_delete_node
			// 
			this.meu_item_delete_node.Name = "meu_item_delete_node";
			this.meu_item_delete_node.Size = new System.Drawing.Size(83, 20);
			this.meu_item_delete_node.Text = "Delete Node";
			this.meu_item_delete_node.Click += new System.EventHandler(this.meu_item_delete_node_Click);
			// 
			// ofd
			// 
			this.ofd.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
			this.ofd.InitialDirectory = "E:\\";
			this.ofd.RestoreDirectory = true;
			this.ofd.Title = "保存";
			// 
			// spl_main
			// 
			this.spl_main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.spl_main.Location = new System.Drawing.Point(0, 24);
			this.spl_main.Name = "spl_main";
			// 
			// spl_main.Panel1
			// 
			this.spl_main.Panel1.Controls.Add(this.tree);
			// 
			// spl_main.Panel2
			// 
			this.spl_main.Panel2.Controls.Add(this.spl_right);
			this.spl_main.Size = new System.Drawing.Size(997, 448);
			this.spl_main.SplitterDistance = 222;
			this.spl_main.TabIndex = 9;
			// 
			// tree
			// 
			this.tree.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tree.Location = new System.Drawing.Point(0, 0);
			this.tree.Name = "tree";
			this.tree.Size = new System.Drawing.Size(222, 448);
			this.tree.TabIndex = 3;
			this.tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tree_AfterSelect);
			// 
			// spl_right
			// 
			this.spl_right.Dock = System.Windows.Forms.DockStyle.Fill;
			this.spl_right.Location = new System.Drawing.Point(0, 0);
			this.spl_right.Name = "spl_right";
			this.spl_right.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// spl_right.Panel1
			// 
			this.spl_right.Panel1.Controls.Add(this.panel_right_down);
			this.spl_right.Panel1.Controls.Add(this.lsv_attribute);
			// 
			// spl_right.Panel2
			// 
			this.spl_right.Panel2.Controls.Add(this.rch_text);
			this.spl_right.Size = new System.Drawing.Size(771, 448);
			this.spl_right.SplitterDistance = 317;
			this.spl_right.TabIndex = 8;
			// 
			// panel_right_down
			// 
			this.panel_right_down.Controls.Add(this.btn_delete);
			this.panel_right_down.Controls.Add(this.btn_add);
			this.panel_right_down.Controls.Add(this.btn_change);
			this.panel_right_down.Controls.Add(this.tex_attrivalue);
			this.panel_right_down.Controls.Add(this.label2);
			this.panel_right_down.Controls.Add(this.tex_attriname);
			this.panel_right_down.Controls.Add(this.label1);
			this.panel_right_down.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel_right_down.Location = new System.Drawing.Point(0, 286);
			this.panel_right_down.Name = "panel_right_down";
			this.panel_right_down.Size = new System.Drawing.Size(771, 31);
			this.panel_right_down.TabIndex = 8;
			// 
			// btn_delete
			// 
			this.btn_delete.Location = new System.Drawing.Point(672, 5);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(78, 23);
			this.btn_delete.TabIndex = 6;
			this.btn_delete.Text = "Delete";
			this.btn_delete.UseVisualStyleBackColor = true;
			this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
			// 
			// btn_add
			// 
			this.btn_add.Location = new System.Drawing.Point(588, 6);
			this.btn_add.Name = "btn_add";
			this.btn_add.Size = new System.Drawing.Size(78, 23);
			this.btn_add.TabIndex = 5;
			this.btn_add.Text = "Add";
			this.btn_add.UseVisualStyleBackColor = true;
			this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
			// 
			// btn_change
			// 
			this.btn_change.Location = new System.Drawing.Point(504, 6);
			this.btn_change.Name = "btn_change";
			this.btn_change.Size = new System.Drawing.Size(78, 23);
			this.btn_change.TabIndex = 4;
			this.btn_change.Text = "Modify";
			this.btn_change.UseVisualStyleBackColor = true;
			this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
			// 
			// tex_attrivalue
			// 
			this.tex_attrivalue.Location = new System.Drawing.Point(309, 5);
			this.tex_attrivalue.Name = "tex_attrivalue";
			this.tex_attrivalue.Size = new System.Drawing.Size(189, 21);
			this.tex_attrivalue.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(261, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 12);
			this.label2.TabIndex = 2;
			this.label2.Text = "Value:";
			// 
			// tex_attriname
			// 
			this.tex_attriname.Location = new System.Drawing.Point(63, 5);
			this.tex_attriname.Name = "tex_attriname";
			this.tex_attriname.Size = new System.Drawing.Size(189, 21);
			this.tex_attriname.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name:";
			// 
			// lsv_attribute
			// 
			this.lsv_attribute.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.attr_name,
            this.attr_value});
			this.lsv_attribute.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lsv_attribute.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lsv_attribute.FullRowSelect = true;
			this.lsv_attribute.GridLines = true;
			this.lsv_attribute.LabelEdit = true;
			this.lsv_attribute.Location = new System.Drawing.Point(0, 0);
			this.lsv_attribute.Name = "lsv_attribute";
			this.lsv_attribute.Size = new System.Drawing.Size(771, 317);
			this.lsv_attribute.TabIndex = 7;
			this.lsv_attribute.UseCompatibleStateImageBehavior = false;
			this.lsv_attribute.View = System.Windows.Forms.View.Details;
			this.lsv_attribute.SelectedIndexChanged += new System.EventHandler(this.lsv_attribute_SelectedIndexChanged);
			// 
			// attr_name
			// 
			this.attr_name.Text = "Property Name";
			this.attr_name.Width = 251;
			// 
			// attr_value
			// 
			this.attr_value.Text = "Value";
			this.attr_value.Width = 500;
			// 
			// rch_text
			// 
			this.rch_text.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rch_text.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.rch_text.Location = new System.Drawing.Point(0, 0);
			this.rch_text.Name = "rch_text";
			this.rch_text.Size = new System.Drawing.Size(771, 127);
			this.rch_text.TabIndex = 8;
			this.rch_text.Text = "";
			// 
			// sfd
			// 
			this.sfd.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
			this.sfd.Title = "另存为";
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(997, 472);
			this.Controls.Add(this.spl_main);
			this.Controls.Add(this.men);
			this.MainMenuStrip = this.men;
			this.Name = "Main";
			this.Text = "XMLParser";
			this.Load += new System.EventHandler(this.Main_Load);
			this.men.ResumeLayout(false);
			this.men.PerformLayout();
			this.spl_main.Panel1.ResumeLayout(false);
			this.spl_main.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.spl_main)).EndInit();
			this.spl_main.ResumeLayout(false);
			this.spl_right.Panel1.ResumeLayout(false);
			this.spl_right.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.spl_right)).EndInit();
			this.spl_right.ResumeLayout(false);
			this.panel_right_down.ResumeLayout(false);
			this.panel_right_down.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip men;
		private System.Windows.Forms.ToolStripMenuItem meu_item_file;
		private System.Windows.Forms.ToolStripMenuItem meu_open;
		private System.Windows.Forms.ToolStripMenuItem meu_save;
		private System.Windows.Forms.OpenFileDialog ofd;
		private System.Windows.Forms.SplitContainer spl_main;
		private System.Windows.Forms.SplitContainer spl_right;
		private System.Windows.Forms.ListView lsv_attribute;
		private System.Windows.Forms.ColumnHeader attr_name;
		private System.Windows.Forms.ColumnHeader attr_value;
		private System.Windows.Forms.RichTextBox rch_text;
		private System.Windows.Forms.TreeView tree;
		private System.Windows.Forms.ToolStripMenuItem meu_item_addnode;
		private System.Windows.Forms.ToolStripMenuItem meu_item_delete_node;
		private System.Windows.Forms.Panel panel_right_down;
		private System.Windows.Forms.TextBox tex_attrivalue;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tex_attriname;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_add;
		private System.Windows.Forms.Button btn_change;
		private System.Windows.Forms.Button btn_delete;
		private System.Windows.Forms.ToolStripMenuItem meu_save_as;
		private System.Windows.Forms.SaveFileDialog sfd;
	}
}

