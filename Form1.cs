using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

// Z Zeichne
// R Rechts
// L Links
// Rule DDR[RDLDLD]L[LDRDRDRD]

namespace Lindenmayer_System
{
    public partial class Form1 : Form
    {
        LSystem lSystem;
        static Graphics g = null;

        static PointF StartPoint;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            drawPanel.Refresh();
            CreateLSystem();
        }
        private void CreateLSystem()
        {
            char axiom = 'D';
            string rule = "DDR[RDLDLD]L[LDRDRDRD]";
            string startWord = "D";
            float angle = 22.5f;
            int length = 50;
            int generationGoal = Convert.ToInt32(generation_textfield.Text);

            lSystem = new LSystem(rule,axiom,angle,length,generationGoal,g);
            lSystem.CreateBranch(startWord, StartPoint);
        }
        
        private void enteredNumber_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void drawPanel_Paint(object sender, PaintEventArgs e)
        {
            StartPoint = new PointF(drawPanel.Width / 2, drawPanel.Height - 20);
            g = drawPanel.CreateGraphics();
        }

        private void generation_textfield_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(generation_textfield.Text, out _))
                generateButton.Show();
            else generateButton.Hide();
        }
    }
}
