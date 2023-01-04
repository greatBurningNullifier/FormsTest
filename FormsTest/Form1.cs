using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Security.Cryptography;

namespace FormsTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //public Random randomRectHeight = new Random();
        //public Random randomRectWidth = new Random();
        public Random randomRectPosition = new Random();
        public Random randomTriPosition = new Random();
        Thread thRect;
        Thread thTri;
        Thread thCir;

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            thRect = new Thread(CreateRectangle);
            thRect.Start();
        }

        public void CreateRectangle()
        {
            while (true)
            {
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Red, 5),
                    new Rectangle(
                    randomRectPosition.Next(0, Width),
                    randomRectPosition.Next(0, Height),
                    100, 50));
                Thread.Sleep(3000);
            }
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            thTri = new Thread(CreateTriangle);
            thTri.Start();
        }

        public void CreateTriangle()
        {
            while (true)
            {
                //this.CreateGraphics().DrawPolygon();
                Thread.Sleep(2000);
            }
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            thRect = new Thread(CreateRectangle);
            thRect.Start();
        }

        public void CreateCirle()
        {

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            thRect.Abort();
        }
    }
}
