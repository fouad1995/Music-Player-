using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_Player
{
    public partial class Form1 : Form
    {
        string[] path;
   
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter= "Mp3 files (*.mp3)|*.mp3";
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                path = openFileDialog1.FileNames;
                
                for (int i = 0; i < path.Length; i++)
                    listBox1.Items.Add(path[i]);
            }


        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = listBox1.GetItemText(listBox1.SelectedItem);
        }

    }
}
