using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace TreeViewCustomControl
{
    public partial class Form1 : Form
    {
        #region Constructor

        public Form1()
		{
			InitializeComponent();
			this.treeViewAdv1.Nodes[0].CustomControl = this.comboBoxAdv1;
            this.treeViewAdv1.Nodes[2].Nodes[0].CustomControl = this.comboBoxAdv3;

            this.treeViewAdv1.Nodes[0].Tag = "Search node";
            this.treeViewAdv1.Nodes[1].Tag = "Search node";
            this.treeViewAdv1.Nodes[2].Tag = "Search node";
            this.treeViewAdv1.Nodes[2].Nodes[0].Tag = "Search node";

            //To search all nodes
            nodes = treeViewAdv1.SearchTree().Where(n => n.Tag == "Search node").ToList();
		}

        #endregion

        List<TreeNodeAdv> nodes;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            if (this.textBox1.Text == "Search node")
            {
                foreach (TreeNodeAdv item in nodes)
                {
                   this.listBox1.Items.Add(item.Text + " :" + "Tag : " + item.Tag);
                }
            }
        }
	}

    public static class SOExtension
    {
        public static IEnumerable<TreeNodeAdv> SearchTree(this TreeViewAdv treeView)
        {
            return SearchTree(treeView.Nodes);
        }

        public static IEnumerable<TreeNodeAdv> SearchTree(this TreeNodeAdvCollection coll)
        {
            return coll.Cast<TreeNodeAdv>().Concat(coll.Cast<TreeNodeAdv>().SelectMany(x => SearchTree(x.Nodes)));
        }
    }
}