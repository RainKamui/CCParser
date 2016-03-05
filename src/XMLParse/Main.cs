using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace CCParser {
	public partial class Main : Form {
		public Main() {
			InitializeComponent();
		}

		private CXMLParser xml = null;
		private string filename = string.Empty;


		private void loadAndDisplay(string path) {
			StreamReader sr = new StreamReader(path);
			string str = sr.ReadToEnd();
			sr.Close();
			xml = new CXMLParser();
			var result = xml.OpenDom(str);
			tree.Tag = result;
			tree.Nodes.Clear();
			TreeNode rootNode = new TreeNode("Root");
			traversed(rootNode, result);
			foreach (TreeNode tn in rootNode.Nodes)
				tree.Nodes.Add(tn);

			//rch2.Text = xml.BuildXMLDocument(result);
		}

		private void traversed(TreeNode parent, CXMLContent content) {
			foreach (CXMLNode node in content.ChildNodes) {
				TreeNode treeNode = new TreeNode(node.Name);
				treeNode.Tag = node;
				parent.Nodes.Add(treeNode);
				if (node.Content != null)
					traversed(treeNode, node.Content);
			}
		}

		private void Main_Load(object sender, EventArgs e) {

		}

		private void meu_open_Click(object sender, EventArgs e) {
			if (ofd.ShowDialog() == DialogResult.OK) {
				filename = ofd.FileName;
				loadAndDisplay(ofd.FileName);
				this.Text = filename;
			}
		}

		private void displayNode(CXMLNode node) {
			lsv_attribute.Items.Clear();
			rch_text.Text = string.Empty;

			lsv_attribute.Tag = node;
			foreach (var attribute in node.Attribute) {
				var item = new ListViewItem();
				item.Text = attribute.Key;
				item.SubItems.Add(attribute.Value);
				lsv_attribute.Items.Add(item);
			}

			if (node.Content != null && node.Content.Text != null) {
				rch_text.Text = node.Content.Text != null ? node.Content.Text : string.Empty;
				rch_text.Tag = node;
			}
		}



		private void tree_AfterSelect(object sender, TreeViewEventArgs e) {
			displayNode((CXMLNode)tree.SelectedNode.Tag);
		}

		private void meu_item_addnode_Click(object sender, EventArgs e) {
			string input = Microsoft.VisualBasic.Interaction.InputBox("节点名称", "添加节点");
			if (input != string.Empty) {
				TreeNode treenode = new TreeNode(input);
				CXMLNode cnode = new CXMLNode();
				cnode.Name = input;
				treenode.Tag = cnode;
				tree.SelectedNode.Nodes.Add(treenode);
				if (((CXMLNode)tree.SelectedNode.Tag).Content == null)
					((CXMLNode)tree.SelectedNode.Tag).Content = new CXMLContent();
				((CXMLNode)tree.SelectedNode.Tag).Content.ChildNodes.Add(cnode);
			}
		}

		private void meu_item_delete_node_Click(object sender, EventArgs e) {
			if (tree.SelectedNode != null) {
				TreeNode parentTreeNode = tree.SelectedNode.Parent;
				CXMLNode parentCNode = (CXMLNode)parentTreeNode.Tag;
				parentCNode.Content.ChildNodes.Remove((CXMLNode)tree.SelectedNode.Tag);
				tree.SelectedNode.Remove();
			}
		}

		private void lsv_attribute_SelectedIndexChanged(object sender, EventArgs e) {
			foreach (ListViewItem item in lsv_attribute.SelectedItems) {
				tex_attriname.Text = item.Text;
				tex_attrivalue.Text = item.SubItems[1].Text;
				tex_attriname.Tag = item;
				break;
			}

		}

		private void btn_change_Click(object sender, EventArgs e) {
			if (tex_attriname.Tag != null && tex_attriname.Text != string.Empty) {
				((ListViewItem)tex_attriname.Tag).Text = tex_attriname.Text;
				((ListViewItem)tex_attriname.Tag).SubItems[1].Text = tex_attrivalue.Text;
			}

			if (((CXMLNode)lsv_attribute.Tag).Content == null)
				((CXMLNode)lsv_attribute.Tag).Content = new CXMLContent();
			((CXMLNode)lsv_attribute.Tag).Content.Text = rch_text.Text;
		}

		private void btn_add_Click(object sender, EventArgs e) {
			var item = new ListViewItem();
			item.Text = tex_attriname.Text;
			item.SubItems.Add(tex_attrivalue.Text);
			lsv_attribute.Items.Add(item);

			if (lsv_attribute.Tag != null)
				((CXMLNode)lsv_attribute.Tag).Attribute[tex_attriname.Text] = tex_attrivalue.Text;
		}

		private void btn_delete_Click(object sender, EventArgs e) {
			if (tex_attriname.Tag != null) {
				((ListViewItem)tex_attriname.Tag).Remove();

				if (lsv_attribute.Tag != null)
					((CXMLNode)lsv_attribute.Tag).Attribute.Remove(tex_attriname.Text);
			}
		}

		private void meu_save_Click(object sender, EventArgs e) {
			var xmlStr = xml.BuildXMLDocument((CXMLContent)tree.Tag);
			StreamWriter sw = new StreamWriter(filename, false);
			sw.Write(xmlStr);
			sw.Close();
		}

		private void meu_save_as_Click(object sender, EventArgs e) {
			if ((CXMLContent)tree.Tag != null) {
				if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
					var xmlStr = xml.BuildXMLDocument((CXMLContent)tree.Tag);
					StreamWriter sw = new StreamWriter(sfd.FileName, false);
					sw.Write(xmlStr);
					sw.Close();
				}
			}
		}
	}
}
