using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafficLight
{
    public partial class ctrlTrafficLight : UserControl
    {
        public int RedTime
        {
            get { return redLightTime; }
            set { redLightTime = value; }
        }
        public int OrangeTime
        {
            get { return orangeLightTime; }
            set { orangeLightTime = value; }
        }
        public int GreenTime
        {
            get { return greenLightTime; }
            set { greenLightTime = value; }
        }

        public event EventHandler OnRedLightOn;
        public event EventHandler OnOrangeLightOn;
        public event EventHandler OnGreenLightOn;
        public enum TrafficLights { Red,Orange,Green}

        private int redLightTime = 10;
        private int orangeLightTime = 7;
        private int greenLightTime = 5;

        private TrafficLights _currentLight = TrafficLights.Red;
        private int _currentCountValue;
        
        public ctrlTrafficLight()
        {
            InitializeComponent();
        }

        public void RedLightOn()
        {
            if (OnRedLightOn == null) return;

            OnRedLightOn(this, EventArgs.Empty);
        }

        public void OrangeLightOn()
        {
            if (OnOrangeLightOn == null) return;

            OnOrangeLightOn(this, EventArgs.Empty);
        }

        public void GreenLightOn()
        {
            if (OnGreenLightOn == null) return;

            OnGreenLightOn(this, EventArgs.Empty);
        }

        private int GetCurrentLightTime()
        {
            switch (_currentLight)
            {
                case TrafficLights.Red:
                    return RedTime;
                case TrafficLights.Orange:
                    return OrangeTime;
                case TrafficLights.Green:
                    return GreenTime;
                default: 
                    return RedTime;
            }
        }
        private string GetLightImagePath()
        {
            switch (_currentLight)
            {
                case TrafficLights.Red:
                    return "D:\\Courses\\Programing-Advice\\Projects\\Course 20\\TrafficLightProject\\TrafficLightProject\\Images\\Red.png";
                case TrafficLights.Orange:
                    return "D:\\Courses\\Programing-Advice\\Projects\\Course 20\\TrafficLightProject\\TrafficLightProject\\Images\\Orange.png";
                case TrafficLights.Green:
                    return "D:\\Courses\\Programing-Advice\\Projects\\Course 20\\TrafficLightProject\\TrafficLightProject\\Images\\Green.png";
                default:
                    return "D:\\Courses\\Programing-Advice\\Projects\\Course 20\\TrafficLightProject\\TrafficLightProject\\Images\\Red.png";
            }
        }

        private void EnableGreenLight()
        {
            _currentLight = TrafficLights.Green;
            _currentCountValue = GetCurrentLightTime();
            pictureBox1.Load(GetLightImagePath());
            TimerValue.ForeColor = Color.Green;

            ComingFromLight = TrafficLights.Green;
            GreenLightOn();
        }
        
        private void EnableRedLight()
        {
            _currentLight = TrafficLights.Red;
            _currentCountValue = GetCurrentLightTime();
            pictureBox1.Load(GetLightImagePath());
            TimerValue.ForeColor = Color.Red;

            ComingFromLight = TrafficLights.Red;
            RedLightOn();
        }
        
        private void EnableOrangeLight()
        {
            _currentLight = TrafficLights.Orange;
            _currentCountValue = GetCurrentLightTime();
            pictureBox1.Load(GetLightImagePath());
            TimerValue.ForeColor = Color.Orange;

            OrangeLightOn();
        }
        
        public void Start()
        {
            _currentCountValue = GetCurrentLightTime();
            LightTimer.Start();
        }
        public void Stop()
        {
            LightTimer.Stop();
        }
        public void Reset()
        {
            _currentCountValue = redLightTime;
            _currentLight = TrafficLights.Red;
            pictureBox1.Load(GetLightImagePath());
            TimerValue.ForeColor = Color.Red;
            ComingFromLight = TrafficLights.Red;

        }
        private void LightTimer_Tick(object sender, EventArgs e)
        {
            TimerValue.Text = _currentCountValue.ToString();
            if(_currentCountValue == 0)
            {
                ChangeLight();
            }
            else
            {
                --_currentCountValue;
            }
        }

        TrafficLights ComingFromLight = TrafficLights.Red;
        private void ChangeLight()
        {
            
            switch (_currentLight)
            {
                case TrafficLights.Red:
                    EnableOrangeLight();
                    break;

                case TrafficLights.Orange:
                    if(ComingFromLight == TrafficLights.Red)
                    {
                        EnableGreenLight();
                        break;
                    }
                    else
                    {
                        EnableRedLight();
                        break;
                    }
                
                case TrafficLights.Green:
                    EnableOrangeLight();
                    break;
                
                default:
                    _currentLight = TrafficLights.Red;
                    pictureBox1.Load(GetLightImagePath());
                    break;

            }
        }
    }
}