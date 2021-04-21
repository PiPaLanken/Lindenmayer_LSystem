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
    public partial class MainForm : Form
    {
        LSystem lSystem;
        Graphics g = null;

        PointF StartPoint;

        public MainForm()
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
            char axiom = Convert.ToChar(triggerTextBox.Text);
            string rule = ruleTextBox.Text;
            string startWord = startWordTextBox.Text;
            float angle = float.Parse(angle_textbox.Text, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
            int.TryParse(length_textbox.Text, out int length);
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

        private void startWordTextBox_TextChanged(object sender, EventArgs e)
        {
        }
        private void triggerTextBox_TextChanged(object sender, EventArgs e)
        {
            if (startWordTextBox.Text.Length > 1)
            {
                startWordTextBox.Text = startWordTextBox.Text[0].ToString();
            }
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            startWordTextBox.Text = "D";
            ruleTextBox.Text = "DDR[RDLDLD]L[LDRDRDRD]";
            triggerTextBox.Text = "D";
            angle_textbox.Text = "22.5";
            length_textbox.Text = "50";
        }

        private void angle_textbox_TextChanged(object sender, EventArgs e)
        {    
            var filtered = System.Text.RegularExpressions.Regex.Replace(angle_textbox.Text, "[^0-9.]", "");
            angle_textbox.Text = filtered;
        }

        private void ruleTextBox_TextChanged(object sender, EventArgs e)
        {
            int countOpen = 0;
            int countClose = 0;
            for (int i = 0; i<ruleTextBox.TextLength; i++)
            {
                if (ruleTextBox.Text[i] == '[')
                    countOpen++;
                if (ruleTextBox.Text[i] == ']')
                    countClose++;
            }
            if (countOpen != countClose)
            {
                rulewrong_label.Show();
            }
            else rulewrong_label.Hide();
        }

        private void length_textbox_TextChanged(object sender, EventArgs e)
        {
            var filtered = System.Text.RegularExpressions.Regex.Replace(length_textbox.Text, "[^0-9]", "");
            length_textbox.Text = filtered;
        }
    }
}
