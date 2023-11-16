using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe_Forms
{
    public partial class Form1 : Form
    {

        int[,] arrTiles = new int[3, 3];
        int turn = 0, temp = 0;
        int winX = 0, winO = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.TranslateTransform(5, 5);
            for (int i = 0; i <= 300; i += 100)
            {
                g.DrawLine(new Pen(Color.Black, 5f), i, 0, i, 300);
                g.DrawLine(new Pen(Color.Black, 5f), 0, i, 300, i);
            }
            // 0 0
            if (arrTiles[0, 0] == 1)
            {
                g.DrawLine(new Pen(Color.Blue, 5f), 0, 0, 100, 100);
                g.DrawLine(new Pen(Color.Blue, 5f), 0, 100, 100, 0);
            }
            else if (arrTiles[0, 0] == 2)
            {
                g.DrawEllipse(new Pen(Color.Red, 5f), 0, 0, 100, 100);
            }
            // 0 1
            if (arrTiles[0, 1] == 1)
            {
                g.DrawLine(new Pen(Color.Blue, 5f), 100, 0, 200, 100);
                g.DrawLine(new Pen(Color.Blue, 5f), 100, 100, 200, 0);
            }
            else if (arrTiles[0, 1] == 2)
            {
                g.DrawEllipse(new Pen(Color.Red, 5f), 100, 0, 100, 100);
            }
            // 0 2
            if (arrTiles[0, 2] == 1)
            {
                g.DrawLine(new Pen(Color.Blue, 5f), 200, 0, 300, 100);
                g.DrawLine(new Pen(Color.Blue, 5f), 200, 100, 300, 0);
            }
            else if (arrTiles[0, 2] == 2)
            {
                g.DrawEllipse(new Pen(Color.Red, 5f), 200, 0, 100, 100);
            }
            // 1 0
            if (arrTiles[1, 0] == 1)
            {
                g.DrawLine(new Pen(Color.Blue, 5f), 0, 100, 100, 200);
                g.DrawLine(new Pen(Color.Blue, 5f), 0, 200, 100, 100);
            }
            else if (arrTiles[1, 0] == 2)
            {
                g.DrawEllipse(new Pen(Color.Red, 5f), 0, 100, 100, 100);
            }
            // 1 1
            if (arrTiles[1, 1] == 1)
            {
                g.DrawLine(new Pen(Color.Blue, 5f), 100, 100, 200, 200);
                g.DrawLine(new Pen(Color.Blue, 5f), 100, 200, 200, 100);
            }
            else if (arrTiles[1, 1] == 2)
            {
                g.DrawEllipse(new Pen(Color.Red, 5f), 100, 100, 100, 100);
            }
            // 1 2
            if (arrTiles[1, 2] == 1)
            {
                g.DrawLine(new Pen(Color.Blue, 5f), 200, 100, 300, 200);
                g.DrawLine(new Pen(Color.Blue, 5f), 200, 200, 300, 100);
            }
            else if (arrTiles[1, 2] == 2)
            {
                g.DrawEllipse(new Pen(Color.Red, 5f), 200, 100, 100, 100);
            }
            // 2 0
            if (arrTiles[2, 0] == 1)
            {
                g.DrawLine(new Pen(Color.Blue, 5f), 0, 200, 100, 300);
                g.DrawLine(new Pen(Color.Blue, 5f), 0, 300, 100, 200);
            }
            else if (arrTiles[2, 0] == 2)
            {
                g.DrawEllipse(new Pen(Color.Red, 5f), 0, 200, 100, 100);
            }
            // 2 1
            if (arrTiles[2, 1] == 1)
            {
                g.DrawLine(new Pen(Color.Blue, 5f), 100, 200, 200, 300);
                g.DrawLine(new Pen(Color.Blue, 5f), 100, 300, 200, 200);
            }
            else if (arrTiles[2, 1] == 2)
            {
                g.DrawEllipse(new Pen(Color.Red, 5f), 100, 200, 100, 100);
            }
            // 2 2
            if (arrTiles[2, 2] == 1)
            {
                g.DrawLine(new Pen(Color.Blue, 5f), 200, 200, 300, 300);
                g.DrawLine(new Pen(Color.Blue, 5f), 200, 300, 300, 200);
            }
            else if (arrTiles[2, 2] == 2)
            {
                g.DrawEllipse(new Pen(Color.Red, 5f), 200, 200, 100, 100);
            }

            //CHECKWIN
            if ((arrTiles[0, 0] == arrTiles[0, 1]) && (arrTiles[0, 1] == arrTiles[0, 2] && (arrTiles[0, 0] != 0)))
            {
                turn = 0;
                temp = arrTiles[0, 0];
                g.DrawLine(new Pen(Color.Black, 10f), 0, 50, 300, 50);
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        arrTiles[i, j] = 0;
                    }
                }
                if (temp == 1)
                {
                    MessageBox.Show("Первый игрок победил!",
                        "Победа!");
                    winX++;
                }
                else if (temp == 2)
                {
                    MessageBox.Show("Второй игрок победил!",
                        "Победа!");
                    winO++;
                }
                Invalidate();
            }
            else if ((arrTiles[1, 0] == arrTiles[1, 1]) && (arrTiles[1, 1] == arrTiles[1, 2] && (arrTiles[1, 0] != 0)))
            {
                turn = 0;
                temp = arrTiles[1, 0];
                g.DrawLine(new Pen(Color.Black, 10f), 0, 150, 300, 150);
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        arrTiles[i, j] = 0;
                    }
                }
                if (temp == 1)
                {
                    MessageBox.Show("Первый игрок победил!",
                        "Победа!");
                    winX++;
                }
                else if (temp == 2)
                {
                    MessageBox.Show("Второй игрок победил!",
                        "Победа!");
                    winO++;
                }
                Invalidate();
            }
            else if ((arrTiles[2, 0] == arrTiles[2, 1]) && (arrTiles[2, 1] == arrTiles[2, 2] && (arrTiles[2, 0] != 0)))
            {
                turn = 0;
                temp = arrTiles[2, 0];
                g.DrawLine(new Pen(Color.Black, 10f), 0, 250, 300, 250);
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        arrTiles[i, j] = 0;
                    }
                }
                if (temp == 1)
                {
                    MessageBox.Show("Первый игрок победил!",
                        "Победа!");
                    winX++;
                }
                else if (temp == 2)
                {
                    MessageBox.Show("Второй игрок победил!",
                        "Победа!");
                    winO++;
                }
                Invalidate();
            }
            else if ((arrTiles[0, 0] == arrTiles[1, 0]) && (arrTiles[1, 0] == arrTiles[2, 0] && (arrTiles[2, 0] != 0)))
            {
                turn = 0;
                temp = arrTiles[2, 0];
                g.DrawLine(new Pen(Color.Black, 10f), 50, 0, 50, 300);
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        arrTiles[i, j] = 0;
                    }
                }
                if (temp == 1)
                {
                    MessageBox.Show("Первый игрок победил!",
                        "Победа!");
                    winX++;
                }
                else if (temp == 2)
                {
                    MessageBox.Show("Второй игрок победил!",
                        "Победа!");
                    winO++;
                }
                Invalidate();
            }
            else if ((arrTiles[0, 1] == arrTiles[1, 1]) && (arrTiles[1, 1] == arrTiles[2, 1] && (arrTiles[2, 1] != 0)))
            {
                turn = 0;
                temp = arrTiles[2, 1];
                g.DrawLine(new Pen(Color.Black, 10f), 150, 0, 150, 300);
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        arrTiles[i, j] = 0;
                    }
                }
                if (temp == 1)
                {
                    MessageBox.Show("Первый игрок победил!",
                        "Победа!");
                    winX++;
                }
                else if (temp == 2)
                {
                    MessageBox.Show("Второй игрок победил!",
                        "Победа!");
                    winO++;
                }
                Invalidate();
            }
            else if ((arrTiles[0, 2] == arrTiles[1, 2]) && (arrTiles[1, 2] == arrTiles[2, 2] && (arrTiles[2, 2] != 0)))
            {
                turn = 0;
                temp = arrTiles[2, 2];
                g.DrawLine(new Pen(Color.Black, 10f), 250, 0, 250, 300);
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        arrTiles[i, j] = 0;
                    }
                }
                if (temp == 1)
                {
                    MessageBox.Show("Первый игрок победил!",
                        "Победа!");
                    winX++;
                }
                else if (temp == 2)
                {
                    MessageBox.Show("Второй игрок победил!",
                        "Победа!");
                    winO++;
                }
                Invalidate();
            }
            else if ((arrTiles[0, 0] == arrTiles[1, 1]) && (arrTiles[1, 1] == arrTiles[2, 2] && (arrTiles[2, 2] != 0)))
            {
                turn = 0;
                temp = arrTiles[2, 2];
                g.DrawLine(new Pen(Color.Black, 10f), 0, 0, 300, 300);
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        arrTiles[i, j] = 0;
                    }
                }
                if (temp == 1)
                {
                    MessageBox.Show("Первый игрок победил!",
                        "Победа!");
                    winX++;
                }
                else if (temp == 2)
                {
                    MessageBox.Show("Второй игрок победил!",
                        "Победа!");
                    winO++;
                }
                Invalidate();
            }
            else if ((arrTiles[0, 2] == arrTiles[1, 1]) && (arrTiles[1, 1] == arrTiles[2, 0] && (arrTiles[2, 0] != 0)))
            {
                turn = 0;
                temp = arrTiles[2, 0];
                g.DrawLine(new Pen(Color.Black, 10f), 0, 300, 300, 0);
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        arrTiles[i, j] = 0;
                    }
                }
                if (temp == 1)
                {
                    MessageBox.Show("Первый игрок победил!",
                        "Победа!");
                    winX++;
                }
                else if (temp == 2)
                {
                    MessageBox.Show("Второй игрок победил!",
                        "Победа!");
                    winO++;
                }
                Invalidate();
            }
            else if (arrTiles[0, 0] != 0 && arrTiles[0, 1] != 0 && arrTiles[0, 2] != 0
                && arrTiles[1, 0] != 0 && arrTiles[1, 1] != 0 && arrTiles[1, 2] != 0
                && arrTiles[2, 0] != 0 && arrTiles[2, 1] != 0 && arrTiles[2, 2] != 0)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        arrTiles[i, j] = 0;
                    }
                }
                MessageBox.Show("Ничья!",
                    "Ничья!");
                Invalidate();
            }
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox1.Text = Convert.ToString(winX);
            textBox2.Text = Convert.ToString(winO);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arrTiles[i, j] = 0;
                }
            }
            turn = 0;
            winX = 0;
            winO = 0;
            Invalidate();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            // 1 2 3 
            // 4 5 6
            // 7 8 9

            if ((e.X > 0) && (e.X < 100) && (e.Y > 0) && (e.Y < 100) && (turn % 2 == 0) && arrTiles[0, 0] == 0)
            {
                arrTiles[0, 0] = 1;
                turn++;
            }
            else if ((e.X > 0) && (e.X < 100) && (e.Y > 0) && (e.Y < 100) && (turn % 2 != 0) && arrTiles[0, 0] == 0)
            {
                arrTiles[0, 0] = 2;
                turn++;
            }

            if ((e.X > 100) && (e.X < 200) && (e.Y > 0) && (e.Y < 100) && (turn % 2 == 0) && arrTiles[0, 1] == 0)
            {
                arrTiles[0, 1] = 1;
                turn++;
            }
            else if ((e.X > 100) && (e.X < 200) && (e.Y > 0) && (e.Y < 100) && (turn % 2 != 0) && arrTiles[0, 1] == 0)
            {
                arrTiles[0, 1] = 2;
                turn++;
            }

            if ((e.X > 200) && (e.X < 300) && (e.Y > 0) && (e.Y < 100) && (turn % 2 == 0) && arrTiles[0, 2] == 0)
            {
                arrTiles[0, 2] = 1;
                turn++;
            }
            else if ((e.X > 200) && (e.X < 300) && (e.Y > 0) && (e.Y < 100) && (turn % 2 != 0) && arrTiles[0, 2] == 0)
            {
                turn++;
                arrTiles[0, 2] = 2;
            }

            if ((e.X > 0) && (e.X < 100) && (e.Y > 100) && (e.Y < 200) && (turn % 2 == 0) && arrTiles[1, 0] == 0)
            {
                turn++;
                arrTiles[1, 0] = 1;
            }
            else if ((e.X > 0) && (e.X < 100) && (e.Y > 100) && (e.Y < 200) && (turn % 2 != 0) && arrTiles[1, 0] == 0)
            {
                arrTiles[1, 0] = 2;
                turn++;
            }

            if ((e.X > 100) && (e.X < 200) && (e.Y > 100) && (e.Y < 200) && (turn % 2 == 0) && arrTiles[1, 1] == 0)
            {
                arrTiles[1, 1] = 1;
                turn++;
            }
            else if ((e.X > 100) && (e.X < 200) && (e.Y > 100) && (e.Y < 200) && (turn % 2 != 0) && arrTiles[1, 1] == 0)
            {
                arrTiles[1, 1] = 2;
                turn++;
            }

            if ((e.X > 200) && (e.X < 300) && (e.Y > 100) && (e.Y < 200) && (turn % 2 == 0) && arrTiles[1, 2] == 0)
            {
                arrTiles[1, 2] = 1;
                turn++;
            }
            else if ((e.X > 200) && (e.X < 300) && (e.Y > 100) && (e.Y < 200) && (turn % 2 != 0) && arrTiles[1, 2] == 0)
            {
                arrTiles[1, 2] = 2;
                turn++;
            }

            if ((e.X > 0) && (e.X < 100) && (e.Y > 200) && (e.Y < 300) && (turn % 2 == 0) && arrTiles[2, 0] == 0)
            {
                arrTiles[2, 0] = 1;
                turn++;
            }
            else if ((e.X > 0) && (e.X < 100) && (e.Y > 200) && (e.Y < 300) && (turn % 2 != 0) && arrTiles[2, 0] == 0)
            {
                arrTiles[2, 0] = 2;
                turn++;
            }

            if ((e.X > 100) && (e.X < 200) && (e.Y > 200) && (e.Y < 300) && (turn % 2 == 0) && arrTiles[2, 1] == 0)
            {
                arrTiles[2, 1] = 1;
                turn++;
            }
            else if ((e.X > 100) && (e.X < 200) && (e.Y > 200) && (e.Y < 300) && (turn % 2 != 0) && arrTiles[2, 1] == 0)
            {
                arrTiles[2, 1] = 2;
                turn++;
            }

            if ((e.X > 200) && (e.X < 300) && (e.Y > 200) && (e.Y < 300) && (turn % 2 == 0) && arrTiles[2, 2] == 0)
            {
                arrTiles[2, 2] = 1;
                turn++;
            }
            else if ((e.X > 200) && (e.X < 300) && (e.Y > 200) && (e.Y < 300) && (turn % 2 != 0) && arrTiles[2, 2] == 0)
            {
                arrTiles[2, 2] = 2;
                turn++;
            }
            Invalidate();
        }
    }
}
