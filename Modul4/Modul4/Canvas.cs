using System;
using System.Drawing;
using System.Windows.Forms;

public class Canvas : Form, IDrawable
{
    private Bitmap canvasBitmap;
    private Graphics graphics;

    public Canvas()
    {
        this.Width = 800;
        this.Height = 600;
        this.Text = "Рисование на холсте";

        canvasBitmap = new Bitmap(this.Width, this.Height);
        graphics = Graphics.FromImage(canvasBitmap);
        graphics.Clear(Color.White);  // Очищаем холст белым фоном

        this.Paint += new PaintEventHandler(this.Canvas_Paint);
    }

    // Метод для корректного отображения при вызове Paint
    private void Canvas_Paint(object sender, PaintEventArgs e)
    {
        e.Graphics.DrawImage(canvasBitmap, Point.Empty);
    }

    public void DrawLine(float x1, float y1, float x2, float y2)
    {
        Pen pen = new Pen(Color.Black, 2);
        graphics.DrawLine(pen, x1, y1, x2, y2);
        this.Invalidate();  // Перерисовать холст
    }

    public void DrawCircle(float x, float y, float radius)
    {
        Pen pen = new Pen(Color.Blue, 2);
        graphics.DrawEllipse(pen, x - radius, y - radius, radius * 2, radius * 2);
        this.Invalidate();  // Перерисовать холст
    }

    public void DrawRectangle(float x, float y, float width, float height)
    {
        Pen pen = new Pen(Color.Red, 2);
        graphics.DrawRectangle(pen, x, y, width, height);
        this.Invalidate();  // Перерисовать холст
    }

    // Для демонстрации
    public void DemoDraw()
    {
        DrawLine(50, 50, 200, 50);
        DrawCircle(150, 150, 50);
        DrawRectangle(250, 250, 100, 60);
    }
}
