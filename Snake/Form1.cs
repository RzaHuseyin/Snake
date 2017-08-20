using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {

        List<Label>  LabelList = new List<Label>();
        List<Label>  FoodList = new List<Label>();
        List<string> SaveLastClickList = new List<string>();
        List<Point>  locationsave = new List<Point>();
        Random rm = new Random();
        string a = "";
        int p = 0;
        int k = 30;
        int speed = 400;
        System.Timers.Timer timer = new System.Timers.Timer(400);
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SaveLastClickList.Add("something");
            creatSnake();
            Food();
        }
        public void creatSnake()
        {
            Label lbl = new Label();
            lbl.Size = new Size(20, 20);
            lbl.Name= "label01";
            lbl.Location = new Point(rm.Next(1, 14) * 20, rm.Next(1, 14) * 20);
            lbl.BackColor = Color.Red;
            lbl.Font = new Font("Serif", 11, FontStyle.Bold);
            lbl.TextAlign = ContentAlignment.MiddleCenter;
            LabelList.Add(lbl);
            foreach (var item in LabelList)
            {
                this.Controls.Add(item);
            }
            timer.Enabled = true;
            timer.Elapsed += MoveMethod;
        }
        public void Food()
        {
            for (int i = 0; i < 30; i++)
            {
                Label food = new Label();
                food.Size = new Size(20, 20);
                food.Name=""+i;
                food.Text = "O";
                food.Font = new Font("Serif", 11, FontStyle.Bold);
                food.Location = new Point(rm.Next(1, 14) * 20, rm.Next(1, 14) * 20);
                food.BackColor = Color.Aqua;
                FoodList.Add(food);
            }
            foreach (var item in FoodList)
            {
                this.Controls.Add(item);
                item.Hide();
            }
            FoodList[0].Show();
        }
        public void MoveMethod(object sender, EventArgs e)
        {
            switch (a)
            {
                case "Up":
                    if (SaveLastClickList[SaveLastClickList.Count - 2] == "Down")
                    {
                        foreach (var item in LabelList)
                        {
                            item.Top += 20;
                        }
                    }
                    else
                    {
                        StandartLocationMethod();
                        LabelList[0].Top -= 20;
                        LabelList[0].Text = "^";
                    }
                    break;
                case "Left":
                    if (SaveLastClickList[SaveLastClickList.Count - 2] == "Right")
                    {
                        foreach (var item in LabelList)
                        {
                            item.Left += 20;
                        }
                    }
                    else
                    {
                        StandartLocationMethod();
                        LabelList[0].Left -= 20;
                        LabelList[0].Text = "<";
                    }
                    break;
                case "Right":
                    if (SaveLastClickList[SaveLastClickList.Count - 2] == "Left")
                    {
                        foreach (var item in LabelList)
                        {
                            item.Left -= 20;
                        }
                    }
                    else
                    {
                        StandartLocationMethod();
                        LabelList[0].Left += 20;
                        LabelList[0].Text = ">";
                    }
                    break;
                case "Down":
                    if (SaveLastClickList[SaveLastClickList.Count - 2] == "Up")
                    {
                        MessageBox.Show("Test");

                        foreach (var item in LabelList)
                        {
                            item.Top -= 20;
                        }
                    }
                    else
                    {
                        StandartLocationMethod();
                        LabelList[0].Top += 20;
                        LabelList[0].Text = "v";
                    }
                    break;
            }
            Limit();
            Eating(ref p);

        }
        private void ClickLable(object sender, EventArgs e)
        {
            Label btn = sender as Label;
            switch (btn.Text)
            {
                case "Up":
                    if (SaveLastClickList[SaveLastClickList.Count - 1] != "Up" && SaveLastClickList[SaveLastClickList.Count - 1] != "Down")
                    {
                        a = "Up";
                        SaveLastClickList.Add(a);
                    }
                    break;
                case "Left":

                    if (SaveLastClickList[SaveLastClickList.Count - 1] != "Left" && SaveLastClickList[SaveLastClickList.Count - 1] != "Right")
                    {
                        a = "Left";
                        SaveLastClickList.Add(a);
                    }

                    break;
                case "Right":
                    if (SaveLastClickList[SaveLastClickList.Count - 1] != "Right" && SaveLastClickList[SaveLastClickList.Count - 1] != "Left")
                    {
                        a = "Right";
                        SaveLastClickList.Add(a);
                    }

                    break;
                case "Down":
                    if (SaveLastClickList[SaveLastClickList.Count - 1] != "Down" && SaveLastClickList[SaveLastClickList.Count - 1] != "Up")
                    {
                        a = "Down";
                        SaveLastClickList.Add(a);
                    }
                    break;
            }
        }
        public void StandartLocationMethod()
        {
            locationsave.Clear();
            for (int i = 0; i < LabelList.Count; i++)
            {
                locationsave.Add(LabelList[i].Location);
            }
            for (int i = 0; i < LabelList.Count; i++)
            {
                if (i + 1 == LabelList.Count)
                    break;
                LabelList[i + 1].Location = locationsave[i];
            }
        }
        public void Limit()
        {
            int z = 0;
            bool l = true;
            if (LabelList[0].Top < 0 || LabelList[0].Top > 370 || LabelList[0].Left < 0|| LabelList[0].Left >610)
            {
                timer.Enabled = false;
                if (p > Convert.ToInt32(label9.Text))
                {
                    label9.Text = p.ToString();
                }
                MessageBox.Show("Game Over");
            }
            for (int i = 0; i < LabelList.Count; i++)
            {
                for (int j = 0; j < LabelList.Count; j++)
                {
                    if (i == j)
                        continue;
                    else if(LabelList[i].Location == LabelList[j].Location)
                    {
                        
                        timer.Enabled = false;
                        if (p > Convert.ToInt32(label9.Text))
                        {
                            label9.Text = p.ToString();
                        }
                        MessageBox.Show("Game Over");
                        l = false;
                    }
                }
                if (l==false)
                {
                    break;
                }
            }
        }
        public void Eating(ref int  p)
        {
            if (LabelList[0].Location == FoodList[p].Location)
            {
                if (p == 29)
                {
                    speed -= 30;
                    timer.Elapsed -= MoveMethod;
                    MessageBox.Show("You Win", "Congratulation");
                }
                switch (a)
                {
                    case "Right":
                        FoodList[p].Location = new Point(LabelList[LabelList.Count-1].Location.X - 20, LabelList[LabelList.Count-1].Location.Y);
                        LabelList.Add(FoodList[p]);
                        break;
                    case "Up":
                        FoodList[p].Location = new Point(LabelList[LabelList.Count-1].Location.X, LabelList[LabelList.Count-1].Location.Y + 20);
                        LabelList.Add(FoodList[p]);
                        break;
                    case "Left":
                        FoodList[p].Location = new Point(LabelList[LabelList.Count-1].Location.X + 20, LabelList[LabelList.Count-1].Location.Y);
                        LabelList.Add(FoodList[p]);
                        break;
                    case "Down":
                        FoodList[p].Location = new Point(LabelList[LabelList.Count-1].Location.X, LabelList[LabelList.Count-1].Location.Y - 20);
                        LabelList.Add(FoodList[p]);
                        break;
                    default:
                        break;
                }
                FoodList[p + 1].Show();
                p += 1;
                --k;
                label8.Text = k.ToString();
                
            }
            
        }
        private void RefreshClickMethod(object sender, EventArgs e)
        {
            a="";
            p=0;
            timer.Interval = speed;
            LabelList.Clear();
            this.Controls.RemoveByKey("label01");
            SaveLastClickList.Add("something");
            foreach (var item in FoodList)
	        {
                this.Controls.RemoveByKey(item.Name);
	        }
            label8.Text = "30";
            k = 30;
            timer.Elapsed -= MoveMethod;
            FoodList.Clear();
            creatSnake();
            Food();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData.ToString())
            {
                case "Up":
                    if (SaveLastClickList[SaveLastClickList.Count - 1] != "Up" && SaveLastClickList[SaveLastClickList.Count - 1] != "Down")
                    {
                        a = "Up";
                        SaveLastClickList.Add(a);
                    }
                    break;
                case "Left":
                    if (SaveLastClickList[SaveLastClickList.Count - 1] != "Left" && SaveLastClickList[SaveLastClickList.Count - 1] != "Right")
                    {
                        a = "Left";
                        SaveLastClickList.Add(a);
                    }
                    break;
                case "Right":
                    if (SaveLastClickList[SaveLastClickList.Count - 1] != "Right" && SaveLastClickList[SaveLastClickList.Count - 1] != "Left")
                    {
                        a = "Right";
                        SaveLastClickList.Add(a);
                    }
                    break;
                case "Down":
                    if (SaveLastClickList[SaveLastClickList.Count - 1] != "Down" && SaveLastClickList[SaveLastClickList.Count - 1] != "Up")
                    {
                        a = "Down";
                        SaveLastClickList.Add(a);
                    }
                    break;
            }
        }
    }
}
