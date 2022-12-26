using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace petardSearch
{
    public partial class Form1 : Form
    {
        public class DoubleClickButton : Button
        {
            public DoubleClickButton() : base()
            {
                // Set the style so a double click event occurs.
                SetStyle(ControlStyles.StandardClick |
                    ControlStyles.StandardDoubleClick, true);
            }
        }

        //private FormBorderStyle initialStyle;

        int[,] array = new int[10, 10];
        int[,] Pos = new int[10, 10];
        int[,] Visit = new int[10, 10];
        int[,] Cnt = new int[10, 10];
        DoubleClickButton[,] btnarr = new DoubleClickButton[10, 10];
        bool GameOver;



        public Form1()
        {
            InitializeComponent();
            Width = 440;
            Height = 440;
            panel1.Top = 0;
            panel1.Left = 0;
            panel1.Width = Width;
            panel1.Height = Height;

            CreatePos();
            ButtonCreate();

        }

        private void CreatePos()
        {
            //throw new NotImplementedException();
            int i, j;
            Random r = new Random();
            r.Next();
            for (i = 0; i < 10; i++)
            {
                int y = r.Next(1, 10);
                int x = r.Next(1, 10);
                if (Pos[y, x] == 1)
                {
                    i--;
                    continue;
                }
                Pos[y, x] = 1;
            }
            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    if (i > 0) Cnt[i, j] += Pos[i - 1, j];
                    if (i < 9) Cnt[i, j] += Pos[i + 1, j];
                    if (j > 0) Cnt[i, j] += Pos[i, j - 1];
                    if (j < 9) Cnt[i, j] += Pos[i, j + 1];
                    if (i > 0 && j > 0) Cnt[i, j] += Pos[i - 1, j - 1];
                    if (i > 0 && j < 9) Cnt[i, j] += Pos[i - 1, j + 1];
                    if (i < 9 && j > 0) Cnt[i, j] += Pos[i + 1, j - 1];
                    if (i < 9 && j < 9) Cnt[i, j] += Pos[i + 1, j + 1];
                    if (Pos[i, j] == 1) Cnt[i, j] = -1;
                }
            }
        }

        private void ButtonCreate()
        {
            int i, j;
            int num = 1;
            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    //private DoubleClickButton button1;
                    DoubleClickButton btn = new DoubleClickButton();
                    btn.Width = 40;
                    btn.Height = 40;
                    btn.Top = i * 40;
                    btn.Left = j * 40;
                    btn.Tag = num;
                    btn.BackColor = Color.Black;// button1.BackColor;
                    array[i, j] = num;
                    //btn.Text = Cnt[i, j].ToString();
                    btn.Click += new EventHandler(btn_Click);
                    //this.AllowDrop = true;
                    btn.DoubleClick += new EventHandler(btn_DoubleClick);
                    btn.MouseDown += new MouseEventHandler(btn_MouseDown);
                    num++;
                    btnarr[i, j] = btn;
                    panel1.Controls.Add(btn);

                }
            }
        }

        private void btn_DoubleClick(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
            //this.FormBorderStyle = initialStyle;
            if (GameOver) return;


            int x, y;
            int res = CheckVisit((sender as Button).Tag, out x, out y);
            if (res == -1)
            {
                GameOver = true;
                MessageBox.Show("게임오버");
            }
            else if (res == 1) return;

            OpenButton(x, y);
            if (GameCheck())
            {
                MessageBox.Show("성공");
            }


        }

        private bool GameCheck()
        {
            int cnt = 0;
            int i, j;
            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    if (Visit[i, j] == 2) cnt++;
                    else if (Visit[i, j] == 0) return false;
                }
            }
            if (cnt == 10) return true;
            else return false;
        }

        private void OpenButton(int x, int y)
        {
            //throw new NotImplementedException();
            if (x < 0 || y < 0 || x > 9 || y > 9) return;
            if (Visit[y, x] != 0) return;
            Visit[y, x] = 1;
            btnarr[y, x].BackColor = Color.White;
            btnarr[y, x].Text = Cnt[y, x].ToString();
            if (Cnt[y, x] > 0) return;
            OpenButton(x + 1, y);
            OpenButton(x - 1, y);
            OpenButton(x, y + 1);
            OpenButton(x, y - 1);
            OpenButton(x - 1, y - 1);
            OpenButton(x - 1, y + 1);
            OpenButton(x + 1, y - 1);
            OpenButton(x + 1, y + 1);
        }

        private int CheckVisit(object tag, out int x, out int y)
        {
            int num = int.Parse(tag.ToString());
            int i, j;
            y = -1;
            x = -1;
            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    if (array[i, j] == num)
                    {
                        y = i;
                        x = j;
                        if (Cnt[i, j] == -1) return -1;
                        if (Visit[i, j] == 0) return 0;
                        else return 1;
                    }
                }
            }
            return 1;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            //this.FormBorderStyle = FormBorderStyle.FixedToolWindow;

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            panel1.Top = 0;
            panel1.Left = 0;
            panel1.Width = Width;
            panel1.Height = Height;
        }

        private void btn_MouseDown(object sender, MouseEventArgs e)
        {
            if (GameOver) return;
            //
            if (e.Button == MouseButtons.Right)
            {
                //MessageBox.Show((sender as Button).Tag + "번 우클릭");
                if ((sender as Button).BackColor == Color.Red) (sender as Button).BackColor = Color.Black;
                else (sender as Button).BackColor = Color.Red;
                RightClick((sender as Button).Tag);
            }

        }

        private void RightClick(object tag)
        {
            int num = int.Parse(tag.ToString());
            int i, j;
            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 10; j++)
                {
                    if (array[i, j] == num)
                    {
                        if (Visit[i, j] == 2) Visit[i, j] = 0;
                        else Visit[i, j] = 2;
                        return;
                    }
                }
            }
            if (GameCheck())
            {
                MessageBox.Show("성공");
            }
            //MessageBox.Show(num.ToString());
        }
    }
}
