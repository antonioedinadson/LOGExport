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
using System.Xml;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

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

            var regex = new Regex(@"\}");

            string[] dir = Directory.GetFiles(textBox1.Text, "*.*", SearchOption.AllDirectories);

            List<Chrome> text = new List<Chrome>();

            for (int i = 0; i < dir.Length; i++) {

                string[] lines = File.ReadAllLines(dir[i]);

                string macAddress = "";
                string macBluetooth = "";
                string serialnumber = "";

                foreach (var line in lines) {                    

                    if(line.Contains("factory.wlan_mac")) {
                        int index = line.IndexOf("factory.wlan_mac");
                        macAddress = line.Substring(index + 19);

                    }

                    if (line.Contains("bt_mac is")) {                       
                        int index = line.IndexOf("bt_mac is");
                        macBluetooth = line.Substring(index + 10);
                    }

                    if (line.Contains("{'serials.serial_number': '")) {
                        int index = line.IndexOf("{'serials.serial_number': '");
                        serialnumber = line.Substring(index + 27);
                    }
                }

                text.Add(new Chrome() {
                    macBluetooth = regex.Replace(macBluetooth, ""),
                    macWireless = regex.Replace(macAddress, ""),
                    serialNumber = regex.Replace(serialnumber, "")
                }) ;

                Console.WriteLine(i);
            }

            SetDataList(text);
        }

        private void SetDataList(List<Chrome> chrome) {

            try {

                using (XmlWriter writer = XmlWriter.Create("CHROMEBOOKS.xml")) {

                    writer.WriteStartElement("CHROMEBOOKS");

                    foreach (var item in chrome) {
                        writer.WriteStartElement("DEVICE");
                        writer.WriteElementString("MAC_ADDRESS", item.macWireless.Replace("'", string.Empty));
                        writer.WriteElementString("MAC_BLUETOOTH", item.macBluetooth.Replace(".", string.Empty));
                        writer.WriteElementString("SERIAL_NUMBER", item.serialNumber.Replace("'", string.Empty));
                        writer.WriteEndElement();

                        InsertDataBase(item.serialNumber.Replace("'", string.Empty), item.macWireless.Replace("'", string.Empty), item.macBluetooth.Replace(".", string.Empty));                        
                    }

                    writer.WriteEndElement();
                    writer.Flush();
                }                

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

            MessageBox.Show("FILE EXPORTED");
            Application.Exit();
        }   

        private void InsertDataBase(string serialNumber, string wireless, string bluetooth) {

            DBController conn = new DBController();
            MySqlCommand cmd = new MySqlCommand();
            
            try {

                conn.OpenConnetion();
                cmd.Connection = conn.GetConnection();
                cmd.CommandText = "INSERT INTO chrome.product (serialnumber, bluetooth, wireless) VALUES (@ser, @blu, @wir)";
                cmd.Parameters.Add(new MySqlParameter("@ser", serialNumber));
                cmd.Parameters.Add(new MySqlParameter("@blu", wireless));
                cmd.Parameters.Add(new MySqlParameter("@wir", bluetooth));
                cmd.ExecuteNonQuery();

            } catch (Exception ex) {
                conn.CloseConnetion();
                MessageBox.Show(ex.Message);

            } finally {
                conn.CloseConnetion();
            }  
        }
        
    }
}
