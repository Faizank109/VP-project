using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSCore;
using CSCore.SoundIn;
using CSCore.Codecs.WAV;
using System.Runtime.InteropServices;
using System.Diagnostics;
//using Microsoft.VisualBasic;



namespace vpprojectPrototype
{
    public partial class Form1 : Form
    {
       // [DllImport("winmm.dll", EntryPoint = "mciSendStringA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        //private static extern int record(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback); 

        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int record(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);  
        
        public Form1()
        {
            InitializeComponent();
            /*HScrollBar obj = new HScrollBar();
            obj.Height = 10;
            obj.Width = 2000;
            this.Controls.Add(obj);*/
         
            button15.BackColor = Color.Black;
            button16.BackColor = Color.Black;
            button17.BackColor = Color.Black;
            button18.BackColor = Color.Black;
            button19.BackColor = Color.Black;
            button20.BackColor = Color.Black;
            button21.BackColor = Color.Black;
            button22.BackColor = Color.Black;
            button23.BackColor = Color.Black;
            button26.BackColor = Color.Black;
            button30.BackColor = Color.Black;
            button33.BackColor = Color.Black;
            button36.BackColor = Color.Black;
            
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.BackColor = Color.White;
            timer1.Start();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void button38_Click(object sender, EventArgs e)
        {
            button38.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\D4virtual.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            button44.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\C5virtual.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            button45.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\D5virtual.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }

        private void button47_Click(object sender, EventArgs e)
        {
            button47.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\F5virtual.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }

        private void button58_Click(object sender, EventArgs e)
        {
            button58.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\c7.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }

        private void button60_Click(object sender, EventArgs e)
        {
            button60.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\e7.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button42_Click(object sender, EventArgs e)
        {
            button42.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\A4virtual.wav";
            s.Load();
            s.Play();

            timer1.Start();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\a0virtual.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            button1.BackColor = Control.DefaultBackColor;
            button2.BackColor = Control.DefaultBackColor;
            button3.BackColor = Control.DefaultBackColor;
            button4.BackColor = Control.DefaultBackColor;
            button5.BackColor = Control.DefaultBackColor;
            button6.BackColor = Control.DefaultBackColor;
            button7.BackColor = Control.DefaultBackColor;
            button8.BackColor = Control.DefaultBackColor;
            button9.BackColor = Control.DefaultBackColor;
            button10.BackColor = Control.DefaultBackColor;
            button11.BackColor = Control.DefaultBackColor;
            button12.BackColor = Control.DefaultBackColor;
            button13.BackColor = Control.DefaultBackColor;
            button14.BackColor = Control.DefaultBackColor;
            button24.BackColor = Control.DefaultBackColor;
            button25.BackColor = Control.DefaultBackColor;
            button27.BackColor = Control.DefaultBackColor;
            button28.BackColor = Control.DefaultBackColor;
            button29.BackColor = Control.DefaultBackColor;
            button31.BackColor = Control.DefaultBackColor;
            button32.BackColor = Control.DefaultBackColor;
            button34.BackColor = Control.DefaultBackColor;
            button35.BackColor = Control.DefaultBackColor;
            button37.BackColor = Control.DefaultBackColor;
            button38.BackColor = Control.DefaultBackColor;
            button39.BackColor = Control.DefaultBackColor;
            button40.BackColor = Control.DefaultBackColor;
            button41.BackColor = Control.DefaultBackColor;
            button42.BackColor = Control.DefaultBackColor;
            button43.BackColor = Control.DefaultBackColor;
            button44.BackColor = Control.DefaultBackColor;
            button45.BackColor = Control.DefaultBackColor;
            button46.BackColor = Control.DefaultBackColor;
            button47.BackColor = Control.DefaultBackColor;
            button48.BackColor = Control.DefaultBackColor;
            button49.BackColor = Control.DefaultBackColor;
            button50.BackColor = Control.DefaultBackColor;
            button51.BackColor = Control.DefaultBackColor;
            button52.BackColor = Control.DefaultBackColor;
            button53.BackColor = Control.DefaultBackColor;
            button54.BackColor = Control.DefaultBackColor;
            button55.BackColor = Control.DefaultBackColor;
            button56.BackColor = Control.DefaultBackColor;
            button57.BackColor = Control.DefaultBackColor;
            button58.BackColor = Control.DefaultBackColor;
            button59.BackColor = Control.DefaultBackColor;
            button60.BackColor = Control.DefaultBackColor;
            button61.BackColor = Control.DefaultBackColor;
            button62.BackColor = Control.DefaultBackColor;
            button63.BackColor = Control.DefaultBackColor;
            button64.BackColor = Control.DefaultBackColor;
            button65.BackColor = Control.DefaultBackColor;
            button15.BackColor = Color.Black;
            button16.BackColor = Color.Black;
            button17.BackColor = Color.Black;
            button18.BackColor = Color.Black;
            button19.BackColor = Color.Black;
            button20.BackColor = Color.Black;
            button21.BackColor = Color.Black;
            button22.BackColor = Color.Black;
            button23.BackColor = Color.Black;
            button26.BackColor = Color.Black;
            button30.BackColor = Color.Black;
            button33.BackColor = Color.Black;
            button36.BackColor = Color.Black;
            button66.BackColor = Color.Black;
            button67.BackColor = Color.Black;
            button68.BackColor = Color.Black;
            button69.BackColor = Color.Black;
            button70.BackColor = Color.Black;
            button71.BackColor = Color.Black;
            button72.BackColor = Color.Black;
            button73.BackColor = Color.Black;
            button74.BackColor = Color.Black;
            button75.BackColor = Color.Black;
            button76.BackColor = Color.Black;
            button77.BackColor = Color.Black;
            button78.BackColor = Color.Black;
            button79.BackColor = Color.Black;
            button80.BackColor = Color.Black;
            button81.BackColor = Color.Black;
            button82.BackColor = Color.Black;
            button83.BackColor = Color.Black;
            button84.BackColor = Color.Black;
            button85.BackColor = Color.Black;
            button86.BackColor = Color.Black;
            button87.BackColor = Color.Black;
        }


        
        private void button2_Click(object sender, EventArgs e)
        {
            
            button2.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\b0virtual.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\c1virtual.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\d1.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\e1.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\f1virtual.wav";
            s.Load();
            s.Play();
            
            timer1.Start();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\G1virtual.wav";
            s.Load();
            s.Play();
          
            timer1.Start();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\A1virtual.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\b1virtual.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "D:\\piano Sounds\\c1.wav";
            s.Load();
            s.Play();

            timer1.Start();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                button11.BackColor = Color.RoyalBlue;
                System.Media.SoundPlayer s = new System.Media.SoundPlayer();
                s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\D2virtual.wav";
                s.Load();
                s.Play();
                timer1.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("   Sorry this tile doesnot contain sound right now");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\E2virtual.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\F2virtual.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\G2virtual.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            button24.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\piano Sounds\\a2.wav";
            s.Load();
            s.Play();

            timer1.Start();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            button25.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "D:\\piano Sounds\\b12amplified.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            button27.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\wav-piano-sound-master\\wav\\c1.wav";
            s.Load();
            s.Play();
         
            timer1.Start();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            button28.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\wav-piano-sound-master\\wav\\d1.wav";
            s.Load();
            s.Play();
            timer1.Start();
            
        }

        private void button29_Click(object sender, EventArgs e)
        {
            button29.BackColor = Color.RoyalBlue;
            //button5.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\wav-piano-sound-master\\wav\\e1.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            button31.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\wav-piano-sound-master\\wav\\f1.wav";
            s.Load();
            s.Play();
            timer1.Start();
            timer1.Start();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            button32.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\wav-piano-sound-master\\wav\\g1.wav";
            s.Load();
            s.Play();
           timer1.Start();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            button34.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\wav-piano-sound-master\\wav\\a1.wav";
            s.Load();
            s.Play();

            timer1.Start();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            button35.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\wav-piano-sound-master\\wav\\b1.wav";
            s.Load();
            s.Play();
            timer1.Start();
            
        }

        private void button37_Click(object sender, EventArgs e)
        {
            button37.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\c4virtual.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            button39.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\E4virtual.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            button40.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\F4virtual.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            button41.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\G4virtual.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            button43.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\B4virtual.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }

        private void button46_Click(object sender, EventArgs e)
        {
            button46.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\E5virtual.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }

        private void button48_Click(object sender, EventArgs e)
        {
            button48.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\G5virtual.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }

        private void button49_Click(object sender, EventArgs e)
        {
            button49.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\A5virtual.wav";
            s.Load();
            s.Play();

            timer1.Start();
        }

        private void button50_Click(object sender, EventArgs e)
        {
            button50.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\B5virtual.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }

        private void button51_Click(object sender, EventArgs e)
        {
            button51.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\c6virtual.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }

        private void button52_Click(object sender, EventArgs e)
        {
            button52.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\D6virtual.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }

        private void button53_Click(object sender, EventArgs e)
        {
            button53.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\E6virtual.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }

        private void button54_Click(object sender, EventArgs e)
        {
            button54.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\F6virtual.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }

        private void button55_Click(object sender, EventArgs e)
        {
            button55.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\g6.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }

        private void button56_Click(object sender, EventArgs e)
        {
            button56.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\a6.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }

        private void button57_Click(object sender, EventArgs e)
        {
            button57.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\b6.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }

        private void button59_Click(object sender, EventArgs e)
        {
            button59.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\d7.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }

        private void button61_Click(object sender, EventArgs e)
        {
            button61.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\f7.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }

        private void button62_Click(object sender, EventArgs e)
        {
            button62.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\g7.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }

        private void button63_Click(object sender, EventArgs e)
        {
            button63.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\a7.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }

        private void button64_Click(object sender, EventArgs e)
        {
            button64.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\b7.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }

        private void button65_Click(object sender, EventArgs e)
        {
            button65.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\c8.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.BackColor = Color.White;
            timer1.Start();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            button17.BackColor = Color.White;
            timer1.Start();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button18.BackColor = Color.White;
            timer1.Start();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button19.BackColor = Color.White;
            timer1.Start();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button20.BackColor = Color.White;
            timer1.Start();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            button21.BackColor = Color.White;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "D:\\piano Sounds\\c#2amplified.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            button22.BackColor = Color.White;
            timer1.Start();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            button23.BackColor = Color.White;
            timer1.Start();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            button26.BackColor = Color.White;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "D:\\piano Sounds\\a#2amplified.wav";
            s.Load();
            s.Play();
            
            timer1.Start();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            button30.BackColor = Color.White;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\wav-piano-sound-master\\wav\\c1s.wav";
            s.Load();
            s.Play();

            
            timer1.Start();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            button33.BackColor = Color.White;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\wav-piano-sound-master\\wav\\f1s.wav";
            s.Load();
            s.Play();

         
            timer1.Start();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            button36.BackColor = Color.White;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\wav-piano-sound-master\\wav\\a1s.wav";
            s.Load();
            s.Play();

          
            timer1.Start();
        }

        private void button66_Click(object sender, EventArgs e)
        {
            button66.BackColor = Color.White;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "D:\\piano Sounds\\o30-11.wav";
            s.Load();
            s.Play();
          
           
            timer1.Start();
        }

        private void button67_Click(object sender, EventArgs e)
        {
            button67.BackColor = Color.White;
            timer1.Start();
        }

        private void button68_Click(object sender, EventArgs e)
        {
            button68.BackColor = Color.White;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "D:\\piano Sounds\\o31.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }

        private void button69_Click(object sender, EventArgs e)
        {
            button69.BackColor = Color.White;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "D:\\piano Sounds\\o33.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }

        private void button70_Click(object sender, EventArgs e)
        {
            button70.BackColor = Color.White;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "D:\\piano Sounds\\a#35amplified.wav";
            s.Load();
            s.Play();

            timer1.Start();
        }

        private void button71_Click(object sender, EventArgs e)
        {
            button71.BackColor = Color.White;
            timer1.Start();
        }

        private void button72_Click(object sender, EventArgs e)
        {
            button72.BackColor = Color.White;
            timer1.Start();
        }

        private void button73_Click(object sender, EventArgs e)
        {
            button73.BackColor = Color.White;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "D:\\piano Sounds\\o43.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }

        private void button74_Click(object sender, EventArgs e)
        {
            button74.BackColor = Color.White;
                System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "D:\\piano Sounds\\o45.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }

        private void button75_Click(object sender, EventArgs e)
        {
            button75.BackColor = Color.White;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "D:\\piano Sounds\\a#47amplified.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }

        private void button76_Click(object sender, EventArgs e)
        {
            button76.BackColor = Color.White;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();

            s.SoundLocation = "D:\\piano Sounds\\c#47amplified.wav";
            s.Load();
            s.Play(); 
           
            timer1.Start();
        }

        private void button77_Click(object sender, EventArgs e)
        {
            button77.BackColor = Color.White;
            timer1.Start();
        }

        private void button78_Click(object sender, EventArgs e)
        {
            button78.BackColor = Color.White;
            timer1.Start();
        }

        private void button79_Click(object sender, EventArgs e)
        {
            button79.BackColor = Color.White;
            timer1.Start();
        }

        private void button80_Click(object sender, EventArgs e)
        {
            button80.BackColor = Color.White;
            timer1.Start();
        }

        private void button81_Click(object sender, EventArgs e)
        {
            button81.BackColor = Color.White;
            timer1.Start();
        }

        private void button82_Click(object sender, EventArgs e)
        {
            button82.BackColor = Color.White;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "D:\\piano Sounds\\o40.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }

        private void button83_Click(object sender, EventArgs e)
        {
            button83.BackColor = Color.White;
            timer1.Start();
        }

        private void button84_Click(object sender, EventArgs e)
        {
            button84.BackColor = Color.White;
            timer1.Start();
        }

        private void button85_Click(object sender, EventArgs e)
        {
            button85.BackColor = Color.White;
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Orange;
            button2.BackColor = Color.Orange;
            button3.BackColor = Color.Orange;
            button4.BackColor = Color.Orange;
            button5.BackColor = Color.Orange;
            button6.BackColor = Color.Orange;
            button7.BackColor = Color.Orange;
            button8.BackColor = Color.Orange;
            button9.BackColor = Color.Orange;
        }

        private void button86_Click(object sender, EventArgs e)
        {
            button86.BackColor = Color.White;
            timer1.Start();
        }

        private void button87_Click(object sender, EventArgs e)
        {
            button87.BackColor = Color.White;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\wav-piano-sound-master\\wav\\d1s.wav";
            s.Load();
            s.Play();
            timer1.Start(); 
        }


        Stopwatch watch = new Stopwatch();
        private void recordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblRecord.Visible = true;
            lblRecord.Text = "Recording...";
            lblHur.Visible = true;
                        watch.Reset();
            watch.Start();
            MessageBox.Show("Recording Started");
            

            timer1.Enabled = true;
            timer1.Start();
            lblHur.Text = watch.Elapsed.Hours.ToString("00") + ":" + watch.Elapsed.Minutes.ToString("00") + ":" + watch.Elapsed.Seconds.ToString("00");

            record("open new Type waveaudio Alias recsound", "", 0, 0);
            record("record recsound", "", 0, 0);  
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //timer1.Stop();
            timer1.Enabled = false;
            lblRecord.Text = "Saving Sound...";
            //record("save recsound d:\\mic.wav", "", 0, 0);
            //record("close recsound", "", 0, 0);
            timer1.Stop();
            watch.Stop();
            lblHur.Visible = true;
           lblHur.Text =
           watch.Elapsed.Hours.ToString("00") + ":" + watch.Elapsed.Minutes.ToString("00") + ":" + watch.Elapsed.Seconds.ToString("00");

            timer1.Enabled = false;
            record("save recsound d:\\mic.wav", "", 0, 0);
            record("close recsound", "", 0, 0);  
        }

        private void playToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // ms = 0;
            //h = 0;
            //s = 0;
            //m = 0;
            timer1.Enabled = false;
            lblHur.Visible = true;
            lblRecord.Text = "Playing...";
         
            (new Microsoft.VisualBasic.Devices.Audio()).Play("d:\\mic.wav"); 

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
               
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            this.KeyPreview = true;
            this.Focus();
            if (e.KeyCode == Keys.A)
            {
                button27.PerformClick();
               
            }
            if (e.KeyCode == Keys.S)
            {
                button28.PerformClick();
                
            }
            if (e.KeyCode == Keys.D)
            {
                button31.PerformClick();
               
            }
            if (e.KeyCode == Keys.F)
            {
                button29.PerformClick();
               
            }         
        }

        private void button88_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.PeachPuff;
            button2.BackColor = Color.Orange;
        }

        private void label2_Click(object sender, EventArgs e)
        {
        
            button10.BackColor = Color.LawnGreen;
            button11.BackColor = Color.LawnGreen;
            button12.BackColor = Color.LawnGreen;
            button13.BackColor = Color.LawnGreen;
            button14.BackColor = Color.LawnGreen;
            button24.BackColor = Color.LawnGreen;
            button25.BackColor = Color.LawnGreen;
            timer1.Start();
//To Reset 

        }

        private void label3_Click(object sender, EventArgs e)
        {
            button27.BackColor = Color.Orchid;
            button28.BackColor = Color.Orchid;
            button29.BackColor = Color.Orchid;
            button31.BackColor = Color.Orchid;
            button32.BackColor = Color.Orchid;
            button34.BackColor = Color.Orchid;
            button35.BackColor = Color.Orchid;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            button37.BackColor = Color.SkyBlue;
            button38.BackColor = Color.SkyBlue;
            button39.BackColor = Color.SkyBlue;
            button40.BackColor = Color.SkyBlue;
            button41.BackColor = Color.SkyBlue;
            button42.BackColor = Color.SkyBlue;
            button43.BackColor = Color.SkyBlue;


        }

        private void label6_Click(object sender, EventArgs e)
        {
            button51.BackColor = Color.Gray;
            button52.BackColor = Color.Gray;
            button53.BackColor = Color.Gray;
            button54.BackColor = Color.Gray;
            button55.BackColor = Color.Gray;
            button56.BackColor = Color.Gray;
            button57.BackColor = Color.Gray;


        }

        private void label5_Click(object sender, EventArgs e)
        {
            button44.BackColor = Color.Teal;
            button45.BackColor = Color.Teal;
            button46.BackColor = Color.Teal;
            button47.BackColor = Color.Teal;
            button48.BackColor = Color.Teal;
            button49.BackColor = Color.Teal;
            button50.BackColor = Color.Teal;
            







        }

        private void label7_Click(object sender, EventArgs e)
        {
            button58.BackColor = Color.Gold;
            button59.BackColor = Color.Gold;
            button60.BackColor = Color.Gold;
            button61.BackColor = Color.Gold;
            button62.BackColor = Color.Gold;
            button63.BackColor = Color.Gold;
            button64.BackColor = Color.Gold;
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
