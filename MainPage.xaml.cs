using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SkiaSharp;
using SkiaSharp.Views.Forms;

namespace TestSkiaTwo
{
    public partial class MainPage : ContentPage
    {
        float xball, yball, rball;
        float vx, vy;

        float xball2, yball2, rball2;
        float vx2, vy2;

        float xball3, yball3, rball3;
        float vx3, vy3;

        float xball4, yball4, rball4;
        float vx4, vy4;

        float xball5, yball5, rball5;
        float vx5, vy5;
        public MainPage()
        {
            InitializeComponent();

                Device.StartTimer(TimeSpan.FromMilliseconds(50), () =>
                {
                    canvasView.InvalidateSurface();

                    return true;
                });

            xball = 600; yball = 100; rball = 50;
            vx = 10f; vy = 7f;

            xball2 = 200; yball2 = 300; rball2 = 80;
            vx2 = 20f; vy2 = 10f;

            xball3 = 300; yball3 = 200; rball3 = 200;
            vx3 = 20f; vy3 = 20f;

            xball4 = 1000; yball4 = 700; rball4 = 70;
            vx4 = -20f; vy4 = 10f;

            xball5 = 400; yball5 = 100; rball5 = 80;
            vx5 = 30f; vy5 = 30f;
        }


        private void CanvasView_PaintSurface(object sender, SkiaSharp.Views.Forms.SKPaintSurfaceEventArgs e)
        {
            SKSurface surface = e.Surface;
            SKCanvas canvas = surface.Canvas;
            canvas.Clear(SKColors.CornflowerBlue);
            SKSize size = canvasView.CanvasSize;

            SKPaint a = new SKPaint();
            SKPaint b = new SKPaint();
            SKPaint c = new SKPaint();
            SKPaint d = new SKPaint();
            SKPaint f = new SKPaint();
            a.Color = SKColors.DarkSlateBlue;
            b.Color = SKColors.White;
            c.Color = SKColors.PaleVioletRed;
            d.Color = SKColors.Aquamarine;
            f.Color = SKColors.Yellow;
            canvas.DrawCircle(xball, yball, rball, a);
            canvas.DrawCircle(xball2, yball2, rball2, b);
            canvas.DrawCircle(xball3, yball3, rball3, c);
            canvas.DrawCircle(xball4, yball4, rball4, d);
            canvas.DrawCircle(xball5, yball5, rball5, f);
            xball += vx;
            yball += vy;
            xball2 += vx2;
            yball2 += vy2;
            xball3 += vx3;
            yball3 += vy3;
            xball4 += vx4;
            yball4 += vy4;
            xball5 += vx5;
            yball5 += vy5;

            if ((xball > size.Width - rball) || (xball < rball)) vx = -vx;
            if ((yball > size.Height - rball) || (yball <rball)) vy = -vy;

            if ((xball2 > size.Width - rball2) || (xball2 < rball2)) vx2 = -vx2;
            if ((yball2 > size.Height - rball2) || (yball2 < rball2)) vy2 = -vy2;

            if ((xball3 > size.Width - rball3) || (xball3 < rball3)) vx3 = -vx3;
            if ((yball3 > size.Height - rball3) || (yball3 < rball3)) vy3 = -vy3;

            if ((xball4 > size.Width - rball4) || (xball4 < rball4)) vx4 = -vx4;
            if ((yball4 > size.Height - rball4) || (yball4 < rball4)) vy4 = -vy4;

            if ((xball5 > size.Width - rball5) || (xball5 < rball5)) vx5 = -vx5;
            if ((yball5 > size.Height - rball5) || (yball5 < rball5)) vy5 = -vy5;
        }
    }
}
