﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project19_TableStatusMomentary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        


        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MomentaryDBEntities momentaryDBEntities = new MomentaryDBEntities();
            var buttons = this.Controls.OfType<Button>().ToList();

            foreach (var btn in buttons)
            {
                this.Controls.Remove(btn);
            }

            var values = momentaryDBEntities.Tables.ToList();
            int buttonWitdh = 100;
            int buttonHeight = 50;
            int padding = 10;
            int xOffset = 10;
            int yOffset = 10;

            for (int i = 0; i < values.Count; i++)
            {
                var item = values[i];
                Button button = new Button();
                button.Text = item.TableNumber.ToString();
                button.Size = new Size(buttonWitdh, buttonHeight);
                button.Location = new Point(xOffset + (i % 4) * (buttonWitdh + padding), yOffset + (i / 4) * (buttonHeight) + padding);

                button.BackColor = (bool)item.Status ? System.Drawing.Color.Green : System.Drawing.Color.Red;

                this.Controls.Add(button);

            }
        }
    }
}
