using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Timers;
using System.Windows.Forms;


namespace PictureViewer
{
    public partial class PictureViewerForm : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public PictureViewerForm()
        {
            InitializeComponent();

            pictureBox1.KeyDown += PictureBox1_KeyDown;
        }
       private static System.Timers.Timer timer = new System.Timers.Timer();

        private void PictureBox1_KeyDown(object? sender, KeyEventArgs e)
        {
            string path = pictureBox1.ImageLocation.ToString();
            int index = Pics.IndexOf(path);

            if (e.KeyCode == Keys.Left)
            {

                if (index - 1 < Pics.IndexOf(Pics.First()))
                {
                    MessageBox.Show("No more pictures that way!", "Error");
                }
                else
                {
                    pictureBox1.ImageLocation = Pics[index - 1];
                    pictureBox1.Image = new Bitmap(pictureBox1.ImageLocation);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            else if (e.KeyCode == Keys.Right)
            {

                if (index + 1 == Pics.Count)
                {
                    MessageBox.Show("No more pictures that way!", "Error");
                }
                else
                {
                    pictureBox1.ImageLocation = Pics[index + 1];
                    pictureBox1.Image = new Bitmap(pictureBox1.ImageLocation);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }
       
        private List<String> Pics = new List<String>();
        private string[] files;
   
        private void imageLocation()
        {
            pictureBox1.ImageLocation = Pics.First();
            pictureBox1.Image = new Bitmap(pictureBox1.ImageLocation);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string path = pictureBox1.ImageLocation.ToString();
            int index = Pics.IndexOf(path);


            if (index - 1 < Pics.IndexOf(Pics.First()))
            {
                MessageBox.Show("No more pictures that way!", "Error");
            }
            else
            {
                pictureBox1.ImageLocation = Pics[index - 1];
                pictureBox1.Image = new Bitmap(pictureBox1.ImageLocation);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            string path = pictureBox1.ImageLocation.ToString();
            int index = Pics.IndexOf(path);


            if (index + 1 == Pics.Count)
            {
                MessageBox.Show("No more pictures that way!", "Error");
            }
            else
            {
                pictureBox1.ImageLocation = Pics[index + 1];
                pictureBox1.Image = new Bitmap(pictureBox1.ImageLocation);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        
            private void openFolderToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                files = Directory.GetFiles(folder.SelectedPath);

            //    label1.Text = $"{files.Length}";
                Pics.Clear();
                Pics = new List<string>(files);

            //    label2.Text = $"{Pics.Count}";

                imageLocation();

            }
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                pictureBox1.ImageLocation = openFileDialog.FileName;
                string path = pictureBox1.ImageLocation.ToString();
                Pics.Add(path);
                pictureBox1.Image = new Bitmap(path);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.TabIndex = 0;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pics.Clear();

            Close();
        }
        //TODO: figure out how to change color from another class
        private void darkToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.ControlDarkDark;
            pictureBox1.BackColor= SystemColors.ControlDarkDark;
            toolStrip1.BackColor= SystemColors.ControlDarkDark;
            
        }
         
        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.ControlLightLight;
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            toolStrip1.BackColor = SystemColors.ControlLightLight;
        }
        
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void slideShow_Click(object sender, EventArgs e)
        {
            timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            timer.Interval = 5000;
            timer.Enabled = true;

        }
        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            Random random = new Random();
            int currentPic = random.Next(0, Pics.Count);
            pictureBox1.ImageLocation = Pics[currentPic];
            pictureBox1.Image = new Bitmap(pictureBox1.ImageLocation);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void pause_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }
    }
}
