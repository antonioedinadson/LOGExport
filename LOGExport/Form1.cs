using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOGExport {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        public string filePath;

        private void BTNOpen_Click(object sender, EventArgs e) {
            
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK) {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
                filePath = folderBrowserDialog1.SelectedPath;
            }
        }

        private void BTNLoad_Click(object sender, EventArgs e) {

            string[] dir = Directory.GetFiles(textBox1.Text, "*.*", SearchOption.AllDirectories);

            foreach (var item in dir) {
                Console.WriteLine(item);
            }
           
        }

        
    }
}
