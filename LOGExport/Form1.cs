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

            List<Chrome> text = new List<Chrome>();

            for (int i = 0; i < dir.Length; i++) {

                string[] lines = File.ReadAllLines(dir[i]);

                foreach (var line in lines) {                    

                    if(line.Contains("wlan_mac is")) {
                        int index = line.IndexOf("wlan_mac is");
                        Console.WriteLine($"MAC_ADDRESS: {line.Substring(index + 12)}");
                    }

                    if (line.Contains("bt_mac is")) {                       
                        int index = line.IndexOf("bt_mac is");
                        Console.WriteLine($"MAC_BLUETOOTH: {line.Substring(index + 10)}");
                    }

                    if (line.Contains("main_garg:FAT.FATStart.ScanSN> [INFO] main_garg:FAT.FATStart.ScanSN device_data.py:300 2021-12-16 11:39:59.867 Updating device ")) {
                        int index = line.IndexOf("serial_number");
                        Console.WriteLine($"SERIAL_NUMBER: {line.Substring(index + 15)}");
                    }
                }   
            }            
        }

        
    }
}
