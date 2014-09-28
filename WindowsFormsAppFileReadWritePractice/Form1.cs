using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsAppFileReadWritePractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string Location = @"nameInfo.txt";
        string name;
        private void saveButton_Click(object sender, EventArgs e)
        {
            name = nameTextBox.Text;
            FileStream afileStream = new FileStream(Location, FileMode.Append);
            StreamWriter astreamWriter = new StreamWriter(afileStream);
            astreamWriter.Write(name);
            astreamWriter.WriteLine();
            astreamWriter.Close();
            nameTextBox.Clear();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            FileStream afileStream = new FileStream(Location, FileMode.Open);
            StreamReader aStreamReader = new StreamReader(afileStream);

            while (!aStreamReader.EndOfStream)
            {
                String aline = aStreamReader.ReadLine();
                infoListBox.Items.Add(aline);
            } aStreamReader.Close();
        }
    }
}
