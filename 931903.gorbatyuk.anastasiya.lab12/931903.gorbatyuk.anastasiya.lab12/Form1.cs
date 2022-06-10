using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _931903.gorbatyuk.anastasiya.lab12
{
    public partial class Form1 : Form
    {

        public class Model
        {
            private double[][] Q = {new double[]{-0.4, 0, 0.75, 0.25},
            new double[]{-0.8, 0.5, 0, 0.5 },
            new double[]{-0.5, 0.2, 0.8, 0 }};
            private Random rnd = new Random();
            public List<Pogoda> stat;
            public List<double> time;
            public double t;
            public double dt = 1;

            public double[] stattime;

            public void Init()
            {
                t = 0;
                stat = new List<Pogoda> { Pogoda.yasno };
                time = new List<double> { 0 };
                stattime = new double[3] { 0, 0, 0 };
                AddState();
            }

            public void SledSh()
            {
                t += dt;
                while (time[time.Count - 1] <= t)
                {
                    AddState();
                }
            }

            private void AddState()
            {
                int currentState = (int)stat[stat.Count - 1];
                double tay = Math.Log(rnd.NextDouble()) / Q[currentState][0];
                stattime[currentState] += tay;
                time.Add(time[time.Count - 1] + tay);
                stat.Add(GenerateState(Q[currentState]));
            }

            private Pogoda GenerateState(double[] prob)
            {
                var value = rnd.NextDouble();

                int i = 1;
                while (prob[i] <= value)
                {
                    value -= prob[i++];
                }

                return (Pogoda)(i - 1);
            }
        }
        private Model model;
        public enum Pogoda
        {
            yasno = 0,
            pasm = 1,
            dojd = 2
        }
       

        public Form1()
        {
            InitializeComponent();
            model = new Model();
            InitFormAndModel();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            var button = sender as Button;

            switch (button.Text)
            {
                case "Старт":
                    Start();
                    break;
                case "Продолжить":
                    Prodolj();
                    break;
                case "Пауза":
                    Pause();
                    break;
            }
        }

        private void InitFormAndModel()
        {
            model.Init();

            UpdateForm();
        }

        private void UpdateForm()
        {
            lbPogoda.Text = GetLabel(model.stat[model.stat.Count - 2]);
            var time = (int)Math.Ceiling(model.t * 10);
            lbDay.Text = $"{time / 100}.{time % 100}";
            lbYasno.Text = (100 * model.stattime[0] / model.time[model.time.Count - 1]).ToString("f1");
            lbPas.Text = (100 * model.stattime[1] / model.time[model.time.Count - 1]).ToString("f1");
            lbDojd.Text = (100 * model.stattime[2] / model.time[model.time.Count - 1]).ToString("f1");
        }

        private string GetLabel(Pogoda state)
        {
            switch (state)
            {
                case Pogoda.yasno: return "ясно";
                case Pogoda.pasm: return "пасмурно";
                case Pogoda.dojd: return "дождь";
            }

            return "";
        }

        private void Start()
        {
            InitFormAndModel();
            StartBtn.Text = "Пауза";
            StartBtn.Enabled = true;
            timer1.Enabled = true;
        }

        private void Pause()
        {
            StartBtn.Text = "Продолжить";
            timer1.Enabled = false;
        }

        private void Prodolj()
        {
            StartBtn.Text = "Пауза";
            timer1.Enabled = true;
        }

        private void Stop()
        {
            StartBtn.Text = "Запустить";
            btStop.Enabled = false;
           timer1.Enabled = false;
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            model.SledSh();
            UpdateForm();
        }
    }
}
