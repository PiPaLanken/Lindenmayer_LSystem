using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Numerics;

namespace Lindenmayer_System
{
    class Artist
    {
        Graphics g = null;
        Pen p = new Pen(Color.Black, 1);

        PointF[] Points;
        Vector2 Angle;
        Vector2 CurrentRotation = new Vector2(0, 1);

        string Word;
        float Length;

        public Artist(string word, float length, Vector2 angle, Graphics graphics)
        {
            Word = word;
            Length = length;
            Angle = angle;
            g = graphics;
        }
        public PointF[] Render(PointF currentPos)
        {
            PointF destPos = currentPos;
            PointF savePos = currentPos;
            Vector2 saveAngle = CurrentRotation;

            for (int i = 0; i < Word.Length; i++)
            {
                if (Word[i] == '[')
                {
                    savePos = currentPos;
                    saveAngle = CurrentRotation;
                    if (i > 0)
                        CurrentRotation = CheckRotationLimit(CurrentRotation, Word[i - 1], i);
                }
                if (Word[i] == ']')
                {
                    currentPos = savePos;
                    CurrentRotation = saveAngle;
                }
                if (Word[i] == 'D')
                {
                    if (i > 0)
                        CurrentRotation = CheckRotationLimit(CurrentRotation, Word[i - 1], i);
                    destPos.X += CurrentRotation.X *-Length;
                    destPos.Y += CurrentRotation.Y*-Length;
                    DrawLineXX(currentPos, destPos);
                    currentPos = destPos;
                }
            }
            return Points;
        }
        public void DrawLineXX(PointF p1, PointF p2)
        {
            PointF[] points =
            {
                p1,
                p2
            };
            g.DrawLines(p, points);
        }
        Vector2 CheckRotationLimit(Vector2 rotation,char c, int i)
        {
            if (c == 'R')
            {
                rotation.X += Angle.X;
                rotation.Y -= Angle.Y;
            }
            if (c == 'L')
            {
                rotation.X -= Angle.X;
                rotation.Y -= Angle.Y;
            }

            float x = MathF.Abs(rotation.X);
            float y = MathF.Abs(rotation.Y);

            if (x+y !=1)
            {
                float sum = x + y;
                x = x /sum;
                y = y /sum ;
            }
            if (rotation.X < 0)
            {
                rotation.X = -x;
            }
            else rotation.X = x;
            if (rotation.Y < 0)
            {
                rotation.Y = -y;
            }
            else rotation.Y = y;
            return new Vector2(rotation.X,rotation.Y);
        }
        public void ChangeSize(float percent)
        {
            Length *= percent;
        }
        public void SetWord(string word)
        {
            Word = word;
        }
    }
}
