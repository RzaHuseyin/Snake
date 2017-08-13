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
        List<Label> LabelList = new List<Label>();
        List<Label> FoodList = new List<Label>();
        List<string> SaveLastClickList = new List<string>();
        Random rm = new Random();
        string a = "";
        int z = 0;
        int p = 0;
        System.Timers.Timer timer = new System.Timers.Timer(400);
        public Form1()
        {
            InitializeComponent();
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
            lbl.Location = new Point(rm.Next(1, 14) * 20, rm.Next(1, 14) * 20);
            lbl.BackColor = Color.Red;
            lbl.Text =">>";
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
                food.Text = ""+i;
                food.Location = new Point(rm.Next(1, 14) * 20, rm.Next(1, 14) * 20);
                food.BackColor = Color.Aqua;
                //food.Hide();
                FoodList.Add(food);
                this.Controls.Add(food);
            }
           // FoodList[0].Show();
            
        }
        public void MoveMethod(object sender, EventArgs e)
        {
            //Label btn = sender as Label;
            switch (a)
            {
                case "Top":
                    if (SaveLastClickList[SaveLastClickList.Count - 2] == "Bottom")
                    {
                        foreach (var item in LabelList)
                        {
                            item.Top += 20;
                        }
                    }
                    else
                    {
                        z += 1;
                        if (z <= LabelList.Count)
                        {
                            if (SaveLastClickList[SaveLastClickList.Count - 2] == "Left")
                            {
                                for (int i = z; i < LabelList.Count; i++)
                                {
                                    LabelList[i].Left -= 20;
                                }
                            }
                            else if (SaveLastClickList[SaveLastClickList.Count - 2] == "Right")
                            {
                                for (int i = z; i < LabelList.Count; i++)
                                {
                                    LabelList[i].Left += 20;
                                }
                            }
                            for (int i = 0; i < z; i++)
                            {
                                LabelList[i].Top -= 20;
                            }
                        }
                        else
                        {
                            foreach (var item in LabelList)
                            {
                                item.Top -= 20;

                            }
                        }
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
                        z += 1;
                        if (z <= LabelList.Count)
                        {
                            if (SaveLastClickList[SaveLastClickList.Count - 2] == "Top")
                            {
                                for (int i = z; i < LabelList.Count; i++)
                                {
                                    LabelList[i].Top -= 20;
                                }
                            }
                            else if (SaveLastClickList[SaveLastClickList.Count - 2] == "Bottom")
                            {
                                for (int i = z; i < LabelList.Count; i++)
                                {
                                    LabelList[i].Top += 20;
                                }
                            }
                            for (int i = 0; i < z; i++)
                            {

                                LabelList[i].Left -= 20;
                            }
                        }
                        else
                        {
                            foreach (var item in LabelList)
                            {
                                item.Left -= 20;

                            }
                        }
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
                        z += 1;
                        if (z <= LabelList.Count)
                        {
                            if (SaveLastClickList[SaveLastClickList.Count - 2] == "Top")
                            {
                                for (int i = z; i < LabelList.Count; i++)
                                {
                                    LabelList[i].Top -= 20;
                                }
                            }
                            else if (SaveLastClickList[SaveLastClickList.Count - 2] == "Bottom")
                            {
                                for (int i = z; i < LabelList.Count; i++)
                                {
                                    LabelList[i].Top += 20;
                                }
                            }
                            for (int i = 0; i < z; i++)
                            {

                                LabelList[i].Left += 20;
                            }
                        }
                        else
                        {
                            foreach (var item in LabelList)
                            {
                                item.Left += 20;

                            }
                        }
                    }
                    break;
                case "Bottom":
                    if (SaveLastClickList[SaveLastClickList.Count - 2] == "Top")
                    {
                        MessageBox.Show("Test");

                        foreach (var item in LabelList)
                        {
                            item.Top -= 20;
                        }
                    }
                    else
                    {
                        z+=1;
                        if (z<= LabelList.Count)
                        {
                            if (SaveLastClickList[SaveLastClickList.Count - 2] == "Left")
                            {
                                for (int i = z; i < LabelList.Count; i++)
                                {
                                    LabelList[i].Left -= 20;
                                }
                            }
                            else if (SaveLastClickList[SaveLastClickList.Count - 2] == "Right")
                            {
                                for (int i = z; i < LabelList.Count; i++)
                                {
                                    LabelList[i].Left += 20;
                                }
                            }
                                for (int i = 0; i < z; i++)
                                {

                                    LabelList[i].Top += 20;
                                }
                        }
                        else
                        {
                            foreach (var item in LabelList)
                            {
                                item.Top += 20;

                            }
                        }




                    }
                    break;
            }
            
            Limit();
            Eating(ref p);

        }
        private void Bu(object sender, EventArgs e)
        {
            Label btn = sender as Label;
            switch (btn.Text)
            {
                case "Top":
                    if (SaveLastClickList[SaveLastClickList.Count - 1] != "Top" && SaveLastClickList[SaveLastClickList.Count - 1] != "Bottom")
                    {
                        a = "Top";
                        z = 0;
                        SaveLastClickList.Add(a);
                    }
                    break;
                case "Left":

                    if (SaveLastClickList[SaveLastClickList.Count - 1] != "Left" && SaveLastClickList[SaveLastClickList.Count - 1] != "Right")
                    {
                        z = 0;
                        a = "Left";
                        SaveLastClickList.Add(a);
                    }

                    break;
                case "Right":
                    if (SaveLastClickList[SaveLastClickList.Count - 1] != "Right" && SaveLastClickList[SaveLastClickList.Count - 1] != "Left")
                    {
                        z = 0;
                        a = "Right";
                        SaveLastClickList.Add(a);
                    }

                    break;
                case "Bot":
                    if (SaveLastClickList[SaveLastClickList.Count - 1] != "Bottom" && SaveLastClickList[SaveLastClickList.Count - 1] != "Top")
                    {
                        z = 0;
                        a = "Bottom";
                        SaveLastClickList.Add(a);
                    }

                    break;
            }
        }
        public void Limit()
        {
            if (LabelList[0].Top < 0 || LabelList[0].Top > 370 || LabelList[0].Left < 0|| LabelList[0].Left >610)
            {
                timer.Enabled = false;
                MessageBox.Show("Lose");
            }
        }
        public void Eating(ref int  p)
        {
            if (LabelList[0].Location == FoodList[p].Location)
            {
                switch (a)
                {
                    case "Right":
                        FoodList[p].Location = new Point(LabelList[LabelList.Count-1].Location.X - 20, LabelList[LabelList.Count-1].Location.Y);
                        LabelList.Add(FoodList[p]);
                        //FoodList[p + 1].Show();
                        break;
                    case "Top":
                        FoodList[p].Location = new Point(LabelList[LabelList.Count-1].Location.X, LabelList[LabelList.Count-1].Location.Y + 20);
                        LabelList.Add(FoodList[p]);
                       // FoodList[p + 1].Show();
                        break;
                    case "Left":
                        FoodList[p].Location = new Point(LabelList[LabelList.Count-1].Location.X + 20, LabelList[LabelList.Count-1].Location.Y);
                        LabelList.Add(FoodList[p]);
                       // FoodList[p + 1].Show();
                        break;
                    case "Bottom":
                        FoodList[p].Location = new Point(LabelList[LabelList.Count-1].Location.X, LabelList[LabelList.Count-1].Location.Y - 20);
                        LabelList.Add(FoodList[p]);
                       // FoodList[p + 1].Show();
                        break;
                    default:
                        break;

                }
                p += 1;
               // this.BackColor = Color.GreenYellow;

            }

        }
        

        private void RefreshClickMethod(object sender, EventArgs e)
        {
            


            //a = "";

            // n = 8;
            // m = 9;
            //foreach (var item in LabelList)
            //{
            //    this.Controls.Remove(item);
            //}
            //foreach (var item in FoodList)
            //{
            //    this.Controls.Remove(item);
            //}
            //LabelList.Clear();
            //FoodList.Clear();
            //timer.Elapsed -= MoveMethod;

            //creatSnake();
            //Food();
        }
    }
}
