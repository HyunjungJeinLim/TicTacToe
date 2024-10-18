using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TicTacToe
{
    public class CustomButton : Button
    {
        public CustomButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0; 
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            Graphics graphics = pevent.Graphics;
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Rectangle rect = this.ClientRectangle;

            // Gradation Color
            using (LinearGradientBrush brush = new LinearGradientBrush(rect, Color.Yellow, Color.LightGreen, 45F)) 
            {
                graphics.FillRectangle(brush, rect);
            }

            // Outline
            Pen pen = new Pen(Color.White, 3); 
            graphics.DrawRectangle(pen, rect);

            StringFormat sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), rect, sf);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
        }
    }
}