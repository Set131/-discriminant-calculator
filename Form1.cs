using System.Security.Cryptography.Xml;
using System;
namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Start_Click(object sender, EventArgs e)
        {
            if (textBox_a.Text != "" && textBox_b.Text != "" && textBox_c.Text != "")
            {
                if (textBox_a.Text != "0")
                {
                    int ax, bx, cx;
                    if (int.TryParse(textBox_a.Text, out ax) == false || int.TryParse(textBox_b.Text, out bx) == false || int.TryParse(textBox_c.Text, out cx) == false) {
                        Result.Text = "Введіть числа";
                    }
                    else
                    {
                        ax = Convert.ToInt32(textBox_a.Text);
                        bx = Convert.ToInt32(textBox_b.Text);
                        cx = Convert.ToInt32(textBox_c.Text);
                        float D = bx * bx - 4 * ax * cx;
                        float d = (float)Math.Sqrt(D);
                        float x = -1 * (bx / (2 * ax));
                        float x1 = (-bx + d) / (2 * ax);
                        float x2 = (-bx - d) / (2 * ax);

                        if (D < 0)
                        {
                            Result.Text = "рівняння коренів не має" +
                                "\nПричина: дискримінант < 0";
                        }
                        else if (D == 0)
                        {
                            Result.Text = $"x = {x}" +
                                "\nДискримінат = 0, отже маємо тільки 1 корінь";
                        }
                        else
                        {
                            Result.Text = $"x1 = {x1}; \nx2 = {x2}.";
                        }
                    }
                }
                else
                {
                    Result.Text = "рівняння коренів не має" +
                        "\nПричина: ділити на нуль не можна" +
                        "\nПорада: 'а' повинно бути не нуль";
                }
            }
            else
            {
                Result.Text = "Введіть усі параметри";
            }
        }

    }
}
