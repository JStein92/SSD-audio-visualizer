using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Diagnostics;
namespace audioVU
{

    public partial class AudioDeltaTest : Form
    {
        LeftMeter LMeter = new LeftMeter();
        RightMeter RMeter = new RightMeter();
        List<double> volumes = new List<double>();
        List<double> volumesR = new List<double>();
        Stopwatch redBarTime = new Stopwatch();
        Stopwatch redBarTimeR = new Stopwatch();

        Color barColor = new Color();
        Color barBGColor = new Color();

        float significantDiff = .2f;
        public AudioDeltaTest()
        {
     

            InitializeComponent();
            
            NAudio.CoreAudioApi.MMDeviceEnumerator enumerator = new NAudio.CoreAudioApi.MMDeviceEnumerator();
            var devices = enumerator.EnumerateAudioEndPoints(NAudio.CoreAudioApi.DataFlow.All, NAudio.CoreAudioApi.DeviceState.Active);
            comboBox1.Items.AddRange(devices.ToArray());
           
            RMeter.Show();
            LMeter.Show();
            RMeter.TopMost = true;
            LMeter.TopMost = true;

            LMeter.MinimumSize = new Size(50, 50);
            RMeter.MinimumSize = new Size(50, 50);

            LMeter.Opacity = (double)((numericUpDown1.Value / 100));
            RMeter.Opacity = (double)((numericUpDown1.Value / 100));

            barColor = Color.Blue;
            barBGColor = Color.Transparent;

            LMeter.progressBarLeft.BarColorSolid = Color.Blue;
            RMeter.progressBarRight.BarColorSolid = Color.Blue;

            redBarTime.Start();
            redBarTimeR.Start();


        }
        private void Form1_Load(object sender, EventArgs e)
        {
          
            // See if user pressed ok.
        
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                
             
                var device = (NAudio.CoreAudioApi.MMDevice)comboBox1.SelectedItem;
                float leftVal = device.AudioMeterInformation.PeakValues[0] * 100;
                float rightVal = device.AudioMeterInformation.PeakValues[1] * 100;
              


                if (masterCheckBox.Checked)
                {
                    float mainVal = device.AudioMeterInformation.MasterPeakValue * 100;
                    progressBar1.Value = (int)(Math.Round(mainVal));
                }else
                {
                    progressBar1.Value = 0;
                }
               

                if (showDeltas.Checked)
                {

                    double leftDiff = Math.Round(leftVal - rightVal);
                    double rightDiff = Math.Round(rightVal - leftVal);

                    if (leftVal - rightVal > 0)
                    {                     
                        LMeter.progressBarLeft.Value = (int)(leftDiff);
                    }
                    else
                    {
                        LMeter.progressBarLeft.Value = 0;
                    }
                      
                    if (rightVal - leftVal > 0)
                    {
                        RMeter.progressBarRight.Value = (int)(rightDiff);
                    }
                    else
                    {
                        RMeter.progressBarRight.Value = 0;
                    }

                    findDiff(leftDiff, volumes, redBarTime, 0);
                    findDiff(rightDiff, volumesR, redBarTimeR, 1);
                   // Console.Write(redBarTime.ElapsedMilliseconds);
                }

                else
                {
                    LMeter.progressBarLeft.Value = (int)((Math.Round(leftVal)));
                    RMeter.progressBarRight.Value = (int)(Math.Round(rightVal));

                    findDiff(leftVal, volumes, redBarTime, 0);
                    findDiff(rightVal, volumesR, redBarTimeR, 1);

                }

               
            }

        }

        public void findDiff(double diff, List<double> list, Stopwatch stopWatch, int channel)
        {
            list.Add(diff / 100);
            if (list.Count > 10)
            {
                list.RemoveAt(0);
            }
            if (list.Count > 9)
            {
                double avgOldValues = ((list[4] + list[5] + list[6]) / 3);
                double avgNewValues = ((list[7] + list[8] + list[9]) / 3);

                //   Console.Write(" Old: " + avgOldValues + " New: " + avgNewValues);
                if (avgNewValues - avgOldValues > significantDiff)
                {
                   // Console.Write(avgNewValues - avgOldValues);
                    stopWatch.Restart();
                }

            }
            if (stopWatch.ElapsedMilliseconds > 200)
            {
                if (channel == 0)
                {
                    LMeter.progressBarLeft.BarColorSolid = barColor;
                } else if (channel == 1)
                {
                    RMeter.progressBarRight.BarColorSolid = barColor;
                }
                

            }
            else
            {
                if (channel == 0)
                {
                    LMeter.progressBarLeft.BarColorSolid = Color.Red;
                }
                else if (channel == 1)
                {
                    RMeter.progressBarRight.BarColorSolid = Color.Red;
                }
           


            }
        }

        private void btnPickColor_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {

                // Set form background to the selected color.
                barColor = colorDialog1.Color;
                barBGColor = colorDialog1.Color;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           
            LMeter.Opacity = (double)(numericUpDown1.Value/100);
            RMeter.Opacity = (double)(numericUpDown1.Value/100);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {

                // Set form background to the selected color.
                LMeter.progressBarLeft.BarBackColor = colorDialog1.Color;
                RMeter.progressBarRight.BarBackColor = colorDialog1.Color;
               
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
          //  Console.Write(significantDiff);
            significantDiff = (float)(numericUpDown2.Value / 100);
        }
    }

   }

