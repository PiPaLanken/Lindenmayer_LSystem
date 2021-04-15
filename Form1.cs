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
        Artist lArtist;

        static Graphics g = null;
        static Pen pen = new Pen(Color.Black, 1);

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
            //Console.WriteLine(GenerateLSystem(Convert.ToInt32(generation_textfield.Text), rule, startWord));
        }
        private void CreateLSystem()
        {
            string rule = "DDR[RDLDLD]L[LDRDRDRD]";
            string startWord = "D";
            float angle = 22.5f;
            Vector2 rotation = new Vector2(MathF.Sin(angle), MathF.Cos(angle));
            int length = 10;
            int generationGoal = Convert.ToInt32(generation_textfield.Text);

            lSystem = new LSystem(rule, startWord);
            lArtist = new Artist(startWord, length, rotation, g);

            for (int i=0; i < generationGoal; i++)
            {
                //Save
                lArtist.SetWord(lSystem.Generate());
                if (i>0)
                    lArtist.ChangeSize(0.5f);
                lArtist.Render(StartPoint);
                
                //Load
            }
        }
        /*static string GenerateLSystem(int generationAmount, string rule, string word, int count = 0)
        {
            var newWord = "";
            if (count == generationAmount)
                return word;
            for (int a = 0; a < word.Length; a++)
            {
                if (word[a] == 'D')
                {
                    newWord += rule;
                    //DrawCalculator(newWord, count);
                }
                else newWord += word[a];
            }
            DrawCalculator(newWord, count);
            return GenerateLSystem(generationAmount, rule, newWord, count + 1);
        }

        static void DrawCalculator(string word, int currentGeneration)
        {
            int length = 20;
            if (currentGeneration>0)
                length /= (currentGeneration*2);
            float rotationAngle = 5;   //22.5f
            float rotationX = 0;
            float rotationY = 0;
            Point currentPos = StartPoint;
            Point savePos = currentPos;

            for (int i = 0; i < word.Length; i++)
            {
                Point destPos = currentPos;
                if (word[i] == '[') //Position abspeichen
                {
                    savePos = currentPos;
                    if (word[i - 1] == 'R')
                    {
                        rotationY += MathF.Cos(rotationAngle) * length;
                        rotationX -= MathF.Sin(rotationAngle) * length;
                    }

                    if (word[i - 1] == 'L')
                    {
                        rotationY += MathF.Cos(rotationAngle) * length;
                        rotationX += MathF.Sin(rotationAngle) * length;
                    }
                }
                if (word[i] == ']')
                {
                    currentPos = savePos; //Speicherung anwenden
                    rotationX = 0;
                    rotationY = 0;
                }
                if (word[i] == 'D')
                {
                    if (i > 0 &&word[i - 1] == 'R')
                    {
                        rotationY += MathF.Cos(22.5f) * length;
                        rotationX -= MathF.Sin(22.5f) * length;
                    }
                    else if (i > 0&&word[i - 1] == 'L')
                    {
                        rotationY += MathF.Cos(22.5f) * length;
                        rotationX += MathF.Sin(22.5f) * length;
                    }
                    else 
                     destPos.Y -= length;
                    destPos.X += (int)rotationX; 
                    destPos.Y += (int)rotationY;
                    DrawLine(currentPos,destPos);
                    currentPos = destPos;
                }
            }
        }
        public static void DrawLine(Point p1, Point p2)
        {
            Point[] points =
            {
                p1,
                p2
            };
            g.DrawLines(pen, points);
        }*/

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
