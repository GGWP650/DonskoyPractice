using System;
using System.Windows.Forms;

public class Program
{
    public static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        Canvas canvas = new Canvas();
        canvas.Show();

        // Для демонстрации нарисуем фигуры
        canvas.DemoDraw();

        Application.Run(canvas);
    }
}
