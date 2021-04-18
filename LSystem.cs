using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Numerics;

namespace Lindenmayer_System
{
    class LSystem
    {
        private char Axiom;
        private string Rule;
        int GenerationAmount;
        float Length;
        float Angle;
        Graphics GraphicPanel;
        Pen Blackpen = new Pen(Color.Black, 1);

        public LSystem(string rule,char axiom, float angle, float length, int generatioAmount, Graphics graphics)
        {
            Angle = angle;
            Axiom = axiom;
            Length = length;
            Rule = rule;
            GraphicPanel = graphics;
            GenerationAmount = generatioAmount;
        }
        public void CreateBranch(string word, PointF startPos, int depthLevel = 0,float angle=0)
        {
            PointF currentPos = startPos;
            for (int a = 0; a < word.Length; a++)
            {
                if (word[a] == 'R')
                    angle += Angle;
                else if (word[a] == 'L')
                    angle -= Angle;
                else if (word[a] == '[')
                {
                    string newBranch = "";
                    for (a+=1; a < word.Length && word[a] != ']'; a++)
                        newBranch += word[a];
                    CreateBranch(newBranch, currentPos, depthLevel, angle);
                }
                else if (word[a] == Axiom)
                {
                    if (depthLevel < GenerationAmount)
                        CreateBranch(Rule, currentPos, depthLevel + 1, angle);
                    currentPos = Draw(MathF.Pow(0.5f, depthLevel)*Length, angle, currentPos);
                }
            }
        }

        public PointF Draw(float length, float angle, PointF startPos)
        {
            PointF destPos = startPos;
            Vector2 direction = new Vector2(MathF.Sin(angle * MathF.PI / 180), MathF.Cos(angle * MathF.PI / 180));
            destPos.X += direction.X * length;
            destPos.Y -= direction.Y * length;
            DrawLine(startPos, destPos);
            return destPos;
        }
        
        public void DrawLine(PointF p1, PointF p2)
        {
            PointF[] points =
            {
                p1,
                p2
            };
            GraphicPanel.DrawLines(Blackpen, points);
        }
    }
}
