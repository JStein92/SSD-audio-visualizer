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

namespace audioVU
{

    public partial class AudioDeltaTest : Form
    {
        LeftMeter LMeter = new LeftMeter();
        RightMeter RMeter = new RightMeter();
        
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
                float mainVal = device.AudioMeterInformation.MasterPeakValue * 100;

                if (masterCheckBox.Checked)
                {
                    progressBar1.Value = (int)(Math.Round(mainVal));
                }else
                {
                    progressBar1.Value = 0;
                }
               

                if (showDeltas.Checked)
                {
                   
                    if (leftVal - rightVal > 0)
                    {                     
                        LMeter.progressBarLeft.Value = (int)((Math.Round(leftVal - rightVal)));
                    }
                    else
                    {
                        LMeter.progressBarLeft.Value = 0;
                    }
                      
                    if (rightVal - leftVal > 0)
                    {
                        RMeter.progressBarRight.Value = (int)(Math.Round((rightVal - leftVal)));
                    }
                    else
                    {
                        RMeter.progressBarRight.Value = 0;
                    }
                        
                    
                           
                }
                else
                {
                    LMeter.progressBarLeft.Value = (int)((Math.Round(leftVal)));
                    RMeter.progressBarRight.Value = (int)(Math.Round(rightVal));
                }
               
            }
        }

        private void btnPickColor_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {

                // Set form background to the selected color.
                LMeter.progressBarLeft.BarColorSolid = colorDialog1.Color;
                RMeter.progressBarRight.BarColorSolid = colorDialog1.Color;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           
            LMeter.Opacity = (double)((numericUpDown1.Value/100));
            RMeter.Opacity = (double)((numericUpDown1.Value/100));
           
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
    }

   }

