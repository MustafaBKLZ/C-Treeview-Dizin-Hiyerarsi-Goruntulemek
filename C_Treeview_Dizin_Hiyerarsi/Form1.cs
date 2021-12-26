using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;

namespace C_Treeview_Dizin_Hiyerarsi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // İki dizine gidin ve oradan bir TreeView oluşturun.
        private void Form1_Load(object sender, EventArgs e)
        {
            //string dir = Path.Combine(Environment.CurrentDirectory, "..\\..");
            string dir = Path.Combine(Environment.CurrentDirectory, "C:\\");
            DirectoryInfo dir_info = new DirectoryInfo(dir);

            trvDirectory.LoadFromDirectory(dir_info.FullName, 0, 1);
            trvDirectory.ExpandAll();
            trvDirectory.SelectedNode = trvDirectory.Nodes[0];
        }
    }
}
