using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuranoTest
{
    public partial class Form1 : Form
    {
        SearchController contr = new SearchController();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void onlineSearchButton_Click(object sender, EventArgs e)
        {
            foreach (string s in contr.searchOnline(searchBox.Text.ToLower()))
                resultBox.Items.Add(s);
        }

        private void savedDataSearchButton_Click(object sender, EventArgs e)
        {
            foreach (string s in contr.searchOffline(searchBox.Text.ToLower()))
                resultBox.Items.Add(s);
        }
    }
}
