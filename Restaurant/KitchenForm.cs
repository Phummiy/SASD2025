using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class KitchenForm : Form
    {
        public KitchenForm()
        {
            InitializeComponent();
        }

        private void KitchenForm_Load(object sender, EventArgs e)
        {
            LoadTextFile();

            CreateListenerThread();

        }

        private void KitchenForm_FormClosed(object sender, FormClosedEventArgs e)

        {

            SaveTextFile();

        }

        private string filename = "data.txt";

        private void LoadTextFile()

        {

            //Debug.WriteLine(Directory.GetCurrentDirectory());

            if (!File.Exists(filename))

                File.Create(filename);

            else

                textBox1.Text = File.ReadAllText(filename);

        }

        private void SaveTextFile()

        {

            File.WriteAllText(filename, textBox1.Text);
        }
    }
}
