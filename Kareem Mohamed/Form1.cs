using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;
namespace Kareem_Mohamed
{
    
    public partial class Form1 : Form
    {
        
        private bool _dragging = false;
        
        private Point _start_point = new Point(0, 0);

        public Form1()
        {
            InitializeComponent();
            

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(712, 352);
            pictureBox9.Hide();
            SoundPlayer audio = new SoundPlayer(Kareem_Mohamed.Properties.Resources.ee); // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
            audio.Play();

            label1.Hide();
            label3.Hide();
            label4.Hide();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/karimzidozz");

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.way2prof.com/");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/zidozz175");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/way2prof");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Process.Start("https://plus.google.com/101012225688200639619");
        }
              
     
      

     
        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = SystemColors.HotTrack;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = SystemColors.HotTrack;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackColor = SystemColors.HotTrack;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.BackColor = SystemColors.HotTrack;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.BackColor = SystemColors.HotTrack;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox2.BackColor = Color.White;
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox3.BackColor = Color.White;
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox4.BackColor = Color.White;
        }

        private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox5.BackColor = Color.White;
        }

        private void pictureBox6_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox6.BackColor = Color.White;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            SoundPlayer audio = new SoundPlayer(Kareem_Mohamed.Properties.Resources.ss); // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
            audio.Play();
            pictureBox11.Enabled = false;
            pictureBox12.BackColor = Color.FromArgb(0, 174, 239);
            this.Size = new Size(264, 352);
            pictureBox9.Enabled = true;
            pictureBox9.Visible = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
                       
        }

        private void pictureBox7_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox7.BackColor = Color.SteelBlue;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.BackColor = SystemColors.HotTrack;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            {
                _dragging = true;  // _dragging is your variable flag
                _start_point = new Point(e.X, e.Y);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false; 
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox8.Hide();
            pictureBox11.Enabled = true;
            pictureBox12.Visible = true;
        }

        private void pictureBox8_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }

        private void pictureBox8_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false; 
        }

        private void pictureBox8_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.Show();
            pictureBox9.Enabled = false;
          

        }

      

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox9_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }

        private void pictureBox9_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false; 
        }

        private void pictureBox9_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Application.Exit();
            //this.Hide();
        }

 
        private void pictureBox10_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox10.BackColor = Color.FromArgb(30, 136, 229);
            label3.Show();
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            pictureBox10.BackColor = SystemColors.HotTrack;
            label3.Hide();
        }

        private void pictureBox11_MouseLeave(object sender, EventArgs e)
        {
            pictureBox11.BackColor = SystemColors.HotTrack;
            label4.Hide();
        }

        private void pictureBox11_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox11.BackColor = Color.FromArgb(30, 136, 229);
            label4.Show();
        }

        private void pictureBox10_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            this.Size = new System.Drawing.Size(712, 352);
            pictureBox9.Hide();
            pictureBox8.Show();
             // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
            SoundPlayer audioo = new SoundPlayer(Kareem_Mohamed.Properties.Resources.ee);
            audioo.Play();
            timer2.Enabled = false;
            timer3.Enabled = false;
            label1.Hide();


        }

      
    }
}
