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
    //******Important  note******** :
    //all  the  file and  directory paths  
    //are  set  according  to  the  system  in  which  this  program  was  developed//
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
            this.KeyPreview = true;         
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
            try {

            
            button15.BackColor = Color.White;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\2.wav";
            s.Load();
            s.Play();
         
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }


        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void button38_Click(object sender, EventArgs e)
        {
            try {

            
            button38.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\D4virtual.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }


        private void button44_Click(object sender, EventArgs e)
        {
            try {

            
            button44.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\C5virtual.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }


        private void button45_Click(object sender, EventArgs e)
        {
            try {

            
            button45.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\D5virtual.wav";
            s.Load();
            s.Play();
            timer1.Start();

        }
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }


        private void button47_Click(object sender, EventArgs e)
        {
            try {

            
            button47.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\F5virtual.wav";
            s.Load();
            s.Play();
            timer1.Start();
            }
        
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }


        private void button58_Click(object sender, EventArgs e)
        {
            try {

            
            button58.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\c7.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }


        private void button60_Click(object sender, EventArgs e)
        {
            try {

            
            button60.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\e7.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button42_Click(object sender, EventArgs e)
        {
            try {

            
            button42.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\A4virtual.wav";
            s.Load();
            s.Play();

            timer1.Start();
        }
        catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            try {

            
            button1.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\a0virtual.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
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
            try {

            
            
            button2.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\b0virtual.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            try {

            
            button3.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\c1virtual.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            try {

            
            button4.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\d1.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }




        private void button5_Click(object sender, EventArgs e)
        {
            try {

            
            button5.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\e1.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }
        catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }


        private void button6_Click(object sender, EventArgs e)
        {
            try {

            
            button6.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\f1virtual.wav";
            s.Load();
            s.Play();
            
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }


        private void button7_Click(object sender, EventArgs e)
        {
            try {

            
            button7.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\G1virtual.wav";
            s.Load();
            s.Play();
          
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }


        private void button8_Click(object sender, EventArgs e)
        {
            try {

            
            button8.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\A1virtual.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }


        private void button9_Click(object sender, EventArgs e)
        {
            try {

            
            button9.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\b1virtual.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }


        private void button10_Click(object sender, EventArgs e)
        {
            try {

            
            button10.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "D:\\piano Sounds\\c1.wav";
            s.Load();
            s.Play();

            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
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
                MessageBox.Show(" please  check file  path");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {

                button12.BackColor = Color.RoyalBlue;
                System.Media.SoundPlayer s = new System.Media.SoundPlayer();
                s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\E2virtual.wav";
                s.Load();
                s.Play();
                timer1.Start();
            }
            catch (Exception)
            {
                MessageBox.Show(" please  check file  or directory path");
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                button13.BackColor = Color.RoyalBlue;
                System.Media.SoundPlayer s = new System.Media.SoundPlayer();
                s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\F2virtual.wav";
                s.Load();
                s.Play();
                timer1.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("please  check  your  file or directory path");
            
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try{

            
            button14.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\G2virtual.wav";
            s.Load();
            s.Play();
            timer1.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }



        private void button24_Click(object sender, EventArgs e)
        {
            try
            {
                button24.BackColor = Color.RoyalBlue;
                System.Media.SoundPlayer s = new System.Media.SoundPlayer();
                s.SoundLocation = "C:\\piano Sounds\\a2.wav";
                s.Load();
                s.Play();

                timer1.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("please check your  file or  directory path");
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            try
            {
                button25.BackColor = Color.RoyalBlue;
                System.Media.SoundPlayer s = new System.Media.SoundPlayer();
                s.SoundLocation = "D:\\piano Sounds\\b12amplified.wav";
                s.Load();
                s.Play();
                timer1.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path ");
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            try
            {
                button27.BackColor = Color.RoyalBlue;
                System.Media.SoundPlayer s = new System.Media.SoundPlayer();
                s.SoundLocation = "C:\\wav-piano-sound-master\\wav\\c1.wav";
                s.Load();
                s.Play();

                timer1.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("please chech your file or directory path");
            }
        }
        private void button28_Click(object sender, EventArgs e)
        { 
            try {

            

            button28.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\wav-piano-sound-master\\wav\\d1.wav";
            s.Load();
            s.Play();
            timer1.Start();
            
        }
        catch (Exception)
            {
                MessageBox.Show("please chech your file or directory path");
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            try
            {

            
            button29.BackColor = Color.RoyalBlue;
            
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\wav-piano-sound-master\\wav\\e1.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please chech your file or directory path");
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            try {

            
            button31.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\wav-piano-sound-master\\wav\\f1.wav";
            s.Load();
            s.Play();
            timer1.Start();
            
        }
         catch (Exception)
            {
                MessageBox.Show("please chech your file or directory path");
            }
        }


        private void button32_Click(object sender, EventArgs e)
        {
            try
            {

            
            button32.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\wav-piano-sound-master\\wav\\g1.wav";
            s.Load();
            s.Play();
           timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            try
            { 
            button34.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\wav-piano-sound-master\\wav\\a1.wav";
            s.Load();
            s.Play();

            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            try
            {

            
            button35.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\wav-piano-sound-master\\wav\\b1.wav";
            s.Load();
            s.Play();
            timer1.Start();
            
        }
            catch (Exception)
            {
                MessageBox.Show("please chech your file or directory path");
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            try
            {

            
            button37.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\c4virtual.wav";
            s.Load();
            s.Play();
            timer1.Start();

        }
            catch (Exception)
            {
                MessageBox.Show("please chech your file or directory path");
            }
        }
        private void button39_Click(object sender, EventArgs e)
        {
            try
            {

            
            button39.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\E4virtual.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please chech your file or directory path");
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            try
            {

            
            button40.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\F4virtual.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please chech your file or directory path");
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            try
            {

            
            button41.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\G4virtual.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please chech your file or directory path");
            }
        }

        private void button43_Click(object sender, EventArgs e)
        {
            try
            {

            
            button43.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\B4virtual.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please chech your file or directory path");
            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            try
            {

                        button46.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\E5virtual.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please chech your file or directory path");
            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            try
            {

            
            button48.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\G5virtual.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please chech your file or directory path");
            }
        }

        private void button49_Click(object sender, EventArgs e)
        {
            try { 
            button49.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\A5virtual.wav";
            s.Load();
            s.Play();

            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please chech your file or directory path");
            }
        }

        private void button50_Click(object sender, EventArgs e)
        {
            try { 
            button50.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\B5virtual.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please chech your file or directory path");
            }
        }

        private void button51_Click(object sender, EventArgs e)
        {
            try
            {

            
            button51.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\c6virtual.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please chech your file or directory path");
            }
        }

        private void button52_Click(object sender, EventArgs e)
        { 
            try
            { 
            button52.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\D6virtual.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please chech your file or directory path");
            }
        }

        private void button53_Click(object sender, EventArgs e)
        {
            try
            {

            
            button53.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\E6virtual.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please chech your file or directory path");
            }
        }

        private void button54_Click(object sender, EventArgs e)
        {
            try
            {
            button54.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\F6virtual.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please chech your file or directory path");
            }
        }

        private void button55_Click(object sender, EventArgs e)
        {
            try
            {

            
            button55.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\g6.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please chech your file or directory path");
            }
        }

        private void button56_Click(object sender, EventArgs e)
        {
            try
            {

            
            button56.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\a6.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please chech your file or directory path");
            }
        }

        private void button57_Click(object sender, EventArgs e)
        {
            try
            {

            
            button57.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\b6.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please chech your file or directory path");
            }
        }

        private void button59_Click(object sender, EventArgs e)
        {
            try
            {

            
            button59.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\d7.wav";
            s.Load();
            s.Play();
            timer1.Start();

        }
            catch (Exception)
            {
                MessageBox.Show("please chech your file or directory path");
            }
        }

        private void button61_Click(object sender, EventArgs e)
        {
            try {

            button61.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\f7.wav";
            s.Load();
            s.Play();
            timer1.Start();
                
        }
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }

            

            


        private void button62_Click(object sender, EventArgs e)
        {
            try {

            
            button62.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\g7.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }

           

       

        private void button63_Click(object sender, EventArgs e)
        {
            try {

            
            button63.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\a7.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }

           


        private void button64_Click(object sender, EventArgs e)
        { 
            try{

            
            button64.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\b7.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }

         

        private void button65_Click(object sender, EventArgs e)
        {
            try {

            
            button65.BackColor = Color.RoyalBlue;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\virtual piano sounds faizan\\c8.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }

          


        private void button16_Click(object sender, EventArgs e)
        {
            try {

            
            button16.BackColor = Color.White;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\5.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }

          


        private void button17_Click(object sender, EventArgs e)

        {
            try {

            
            button17.BackColor = Color.White;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\7.wav";
            s.Load();
            s.Play();
            timer1.Start();

        }
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }


           

         


        private void button18_Click(object sender, EventArgs e)
        {
            try {

            
            button18.BackColor = Color.White;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\10.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }


        private void button19_Click(object sender, EventArgs e)
        {
            try {

            

            button19.BackColor = Color.White;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\12.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }


        private void button20_Click(object sender, EventArgs e)
        {
            try{

            
            button20.BackColor = Color.White;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\14.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }


        private void button21_Click(object sender, EventArgs e)
        {
            try{

            
            button21.BackColor = Color.White;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\17.wav";
            s.Load();
            s.Play();
           
            timer1.Start();

        }
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }


        private void button22_Click(object sender, EventArgs e)
        {
            try{

            
            button22.BackColor = Color.White;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\19.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }


        private void button23_Click(object sender, EventArgs e)
        { 
            try{

            
            button23.BackColor = Color.White;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\22.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }


        private void button26_Click(object sender, EventArgs e)
        {  
            try{

            button26.BackColor = Color.White;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\24.wav";
            s.Load();
            s.Play();
            timer1.Start();
            

        }
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }


        private void button30_Click(object sender, EventArgs e)
        {
            try {

            
            button30.BackColor = Color.White;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\wav-piano-sound-master\\wav\\c1s.wav";
            s.Load();
            s.Play();

            
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }


        private void button33_Click(object sender, EventArgs e)
        {
            try {

            
            button33.BackColor = Color.White;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\wav-piano-sound-master\\wav\\f1s.wav";
            s.Load();
            s.Play();

         
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }


        private void button36_Click(object sender, EventArgs e)
        {
            try {

            
            button36.BackColor = Color.White;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\wav-piano-sound-master\\wav\\a1s.wav";
            s.Load();
            s.Play();

          
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }


        private void button66_Click(object sender, EventArgs e)
        { 
            try {

            
            button66.BackColor = Color.White;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\38.wav";
            s.Load();
            s.Play();

            
          
           
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }


        private void button67_Click(object sender, EventArgs e)
        {
            try {

            
            button67.BackColor = Color.White;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\43.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }


        private void button68_Click(object sender, EventArgs e)
        {
            try {

            
            button68.BackColor = Color.White;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\46.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }


        private void button69_Click(object sender, EventArgs e)
        {
            try {

            
            button69.BackColor = Color.White;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "D:\\piano Sounds\\o33.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }


        private void button70_Click(object sender, EventArgs e)
        {
            try {

            
            button70.BackColor = Color.White;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "D:\\piano Sounds\\a#35amplified.wav";
            s.Load();
            s.Play();

            timer1.Start();
        }
catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }

        private void button71_Click(object sender, EventArgs e)
        {
            try {

            
            button71.BackColor = Color.White;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\53.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }


        private void button72_Click(object sender, EventArgs e)
        {
            try {

            
            button72.BackColor = Color.White;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\55.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }


        private void button73_Click(object sender, EventArgs e)
        { 
            try {

            
            button73.BackColor = Color.White;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\58.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }


        private void button74_Click(object sender, EventArgs e)
        {
            try {

            
            button74.BackColor = Color.White;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\60.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }


        private void button75_Click(object sender, EventArgs e)
        {
            try {

            
            button75.BackColor = Color.White;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\62.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }


        private void button76_Click(object sender, EventArgs e)
        {
            try {

            
            button76.BackColor = Color.White;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\65.wav";
            s.Load();
            s.Play();
            
           
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }


        private void button77_Click(object sender, EventArgs e)
        {
            try {

            
            button77.BackColor = Color.White;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\67.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }


        private void button78_Click(object sender, EventArgs e)
        {
            try {

            

            button78.BackColor = Color.White;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\70.wav";
            s.Load();
            s.Play();

            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }


        private void button79_Click(object sender, EventArgs e)
        {
            try {

            
            button79.BackColor = Color.White;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\72.wav";
            s.Load();
            s.Play();

            timer1.Start();
        }
        catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }


        private void button80_Click(object sender, EventArgs e)
        {
            try {

            
            button80.BackColor = Color.White;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\74.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }
        catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }


        private void button81_Click(object sender, EventArgs e)
        {
            try {

            
            button81.BackColor = Color.White;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\77.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }


        private void button82_Click(object sender, EventArgs e)
        {
            try {

            
            button82.BackColor = Color.White;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\79.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }
catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }

        private void button83_Click(object sender, EventArgs e)
        {
            try {

            
            button83.BackColor = Color.White;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\82.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }


        private void button84_Click(object sender, EventArgs e)
        {
            try {

            
            button84.BackColor = Color.White;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\84.wav";
            s.Load();
            s.Play();

            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }


        private void button85_Click(object sender, EventArgs e)
        {
            try {

            
            button85.BackColor = Color.White;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\86.wav";
            s.Load();
            s.Play();
            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {
            
            
            button3.BackColor = Color.Wheat;
            button4.BackColor = Color.Wheat;
            button5.BackColor = Color.Wheat;
            button6.BackColor = Color.Wheat;
            button7.BackColor = Color.Wheat;
            button8.BackColor = Color.Wheat;
            button9.BackColor = Color.Wheat;
        }

        private void button86_Click(object sender, EventArgs e)
        { 
            try {

            
            button86.BackColor = Color.White;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\Users\\Khalid pervaiz\\Desktop\\26.wav";
            s.Load();
            s.Play();

            timer1.Start();
        }
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }


        private void button87_Click(object sender, EventArgs e)
        {
            try {

            
            button87.BackColor = Color.White;
            System.Media.SoundPlayer s = new System.Media.SoundPlayer();
            s.SoundLocation = "C:\\wav-piano-sound-master\\wav\\d1s.wav";
            s.Load();
            s.Play();
            timer1.Start(); 
        }
        catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
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
            try{

            
            if (e.KeyChar == Convert.ToInt16(Keys.Q))
            {
                button1.PerformClick();
            }
            if (e.KeyChar == Convert.ToInt16(Keys.W))
            {
                button2.PerformClick();
            }
            if (e.KeyChar == Convert.ToInt16(Keys.E))
            {
                button3.PerformClick();
            }
            if (e.KeyChar == Convert.ToInt16(Keys.R))
            {
                button4.PerformClick();
            }
            if (e.KeyChar == Convert.ToInt16(Keys.T))
            {
                button5.PerformClick();
            }
            if (e.KeyChar == Convert.ToInt16(Keys.Y))
            {
                button6.PerformClick();
            }
            if (e.KeyChar == Convert.ToInt16(Keys.U))
            {
                button7.PerformClick();
            }
            if (e.KeyChar == Convert.ToInt16(Keys.I))
            {
                button8.PerformClick();
            }
            if (e.KeyChar == Convert.ToInt16(Keys.O))
            {
                button9.PerformClick();
            }
            if (e.KeyChar == Convert.ToInt16(Keys.P))
            {
                button10.PerformClick();
            }
            if (e.KeyChar == Convert.ToInt16(Keys.A))
            {
                button11.PerformClick();
            }
            if (e.KeyChar == Convert.ToInt16(Keys.S))
            {
                button12.PerformClick();
            }
            if (e.KeyChar == Convert.ToInt16(Keys.D))
            {
                button13.PerformClick();
            }
            if (e.KeyChar == Convert.ToInt16(Keys.F))
            {
                button14.PerformClick();
            }
            if (e.KeyChar == Convert.ToInt16(Keys.G))
            {
                button24.PerformClick();
            }
            if (e.KeyChar == Convert.ToInt16(Keys.H))
            {
                button25.PerformClick();
            }
            if (e.KeyChar == Convert.ToInt16(Keys.J))
            {
                button27.PerformClick();
            }
            if (e.KeyChar == Convert.ToInt16(Keys.K))
            {
                button28.PerformClick();
            }
            if (e.KeyChar == Convert.ToInt16(Keys.L))
            {
                button29.PerformClick();
            }
            if (e.KeyChar == Convert.ToInt16(Keys.Z))
            {
                button31.PerformClick();
            }
            if (e.KeyChar == Convert.ToInt16(Keys.X))
            {
                button32.PerformClick();
            }
            if (e.KeyChar == Convert.ToInt16(Keys.C))
            {
                button34.PerformClick();
            }
            if (e.KeyChar == Convert.ToInt16(Keys.V))
            {
                button35.PerformClick();
            }
            if (e.KeyChar == Convert.ToInt16(Keys.B))
            {
                button37.PerformClick();
            }
            if (e.KeyChar == Convert.ToInt16(Keys.N))
            {
                button38.PerformClick();
            }
            if (e.KeyChar == Convert.ToInt16(Keys.M))
            {
                button39.PerformClick();
            }
            if (e.KeyChar == Convert.ToInt16(Keys.D1))
            {
                button40.PerformClick();
            }
            if (e.KeyChar == Convert.ToInt16(Keys.D2))
            {
                button41.PerformClick();
            }
            if (e.KeyChar == Convert.ToInt16(Keys.D3))
            {
                button42.PerformClick();
            }
            if (e.KeyChar == Convert.ToInt16(Keys.D4))
            {
                button43.PerformClick();
            }
            if (e.KeyChar == Convert.ToInt16(Keys.D5))
            {
                button44.PerformClick();
            }
            if (e.KeyChar == Convert.ToInt16(Keys.D6))
            {
                button45.PerformClick();
            }
            if (e.KeyChar == Convert.ToInt16(Keys.D7))
            {
                button46.PerformClick();
            }
            if (e.KeyChar == Convert.ToInt16(Keys.D8))
            {
                button47.PerformClick();
            }
            if (e.KeyChar == Convert.ToInt16(Keys.D9))
            {
                button48.PerformClick();
            }
            if (e.KeyChar == Convert.ToInt16(Keys.D0))
            {
                button49.PerformClick();
            }

            if (e.KeyChar == Convert.ToInt16(Keys.NumLock))
            {
                button50.PerformClick();

            }

            if (e.KeyChar == Convert.ToInt16(Keys.NumPad0))
            {
                button51.PerformClick();

            }

            if (e.KeyChar == Convert.ToInt16(Keys.NumPad1))
            {
                button52.PerformClick();
            }


            if (e.KeyChar == Convert.ToInt16(Keys.NumPad2))
            {


                button53.PerformClick();
            }

            if (e.KeyChar == Convert.ToInt16(Keys.NumPad3))
            {
                button54.PerformClick();

            }
            if (e.KeyChar == Convert.ToInt16(Keys.NumPad4))
            {
                button55.PerformClick();
            }
            if (e.KeyChar == Convert.ToInt16(Keys.NumPad5))
            {
                button56.PerformClick();
            }

            if (e.KeyChar == Convert.ToInt16(Keys.NumPad6))
            {
                button56.PerformClick();
            }
            if (e.KeyChar == Convert.ToInt16(Keys.NumPad7))
            {
                button57.PerformClick();

            }
            if (e.KeyChar == Convert.ToInt16(Keys.NumPad8))
            {
                button57.PerformClick();

            }
            if (e.KeyChar == Convert.ToInt16(Keys.NumPad9))
            {
                button58.PerformClick();
            }
            if (e.KeyChar == Convert.ToInt16(Keys.Escape))
            {
                button59.PerformClick();

            }
            if (e.KeyChar == Convert.ToInt16(Keys.Add))
            {
                button60.PerformClick();
            }
            if (e.KeyChar == Convert.ToInt16(Keys.Subtract))
            {
                button61.PerformClick();
            }
            if (e.KeyChar == Convert.ToInt16(Keys.Enter))
            {
                button62.PerformClick();
            }
            if (e.KeyChar == Convert.ToInt16(Keys.Delete))
            {
                button63.PerformClick();
            }
            if (e.KeyChar == Convert.ToInt16(Keys.ControlKey))
            {
                button64.PerformClick();
            }
            if (e.KeyChar == Convert.ToInt16(Keys.Divide))
            {
                button65.PerformClick();
            }
            if (e.KeyChar == Convert.ToInt16(Keys.PageUp))
            {
                button15.PerformClick();
            }
            if (e.KeyChar == Convert.ToInt16(Keys.PageDown))
            {
                button16.PerformClick();
            }
            if (e.KeyChar == Convert.ToInt16(Keys.VolumeUp))
            {
                button17.PerformClick();
            }
            if (e.KeyChar == Convert.ToInt16(Keys.VolumeDown))
            {
                button18.PerformClick();
            }
            if (e.KeyChar == Convert.ToInt16(Keys.VolumeMute))
            {
                button19.PerformClick();
            }
            if (e.KeyChar == Convert.ToInt16(Keys.Zoom))
            {
                button20.PerformClick();
            }
                if (e.KeyChar == Convert.ToInt16(Keys.Oem1))
                {
                    button21.PerformClick();
                }

                if (e.KeyChar == Convert.ToInt16(Keys.Oem2))
                {
                    button22.PerformClick();
                }

                if (e.KeyChar == Convert.ToInt16(Keys.Oem3))
                {
                    button23.PerformClick();
                }
                if (e.KeyChar == Convert.ToInt16(Keys.Oem4))
                {
                    button26.PerformClick();
                }
                if (e.KeyChar == Convert.ToInt16(Keys.Oem5))
                {
                    button86.PerformClick();
                }
                if (e.KeyChar == Convert.ToInt16(Keys.Zoom))
                {
                    button30.PerformClick();
                }
                if (e.KeyChar == Convert.ToInt16(Keys.Oem6))
                {
                    button87.PerformClick();
                }
                if (e.KeyChar == Convert.ToInt16(Keys.Oem7))
                {
                    button33.PerformClick();
                }
                if (e.KeyChar == Convert.ToInt16(Keys.Oem8))
                {
                    button36.PerformClick();
                }
                if (e.KeyChar == Convert.ToInt16(Keys.OemBackslash))
                {
                    button66.PerformClick();

                }


            }
            catch (Exception)
            {
                MessageBox.Show("please check your file or directory path");
            }
        }

        
         
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
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
            button44.BackColor = Color.BurlyWood;
            button45.BackColor = Color.BurlyWood;
            button46.BackColor = Color.BurlyWood;
            button47.BackColor = Color.BurlyWood;
            button48.BackColor = Color.BurlyWood;
            button49.BackColor = Color.BurlyWood;
            button50.BackColor = Color.BurlyWood;
            







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

        

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
