﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEACHER
{
    public partial class Form2 : Form
    {
        private bool SystemIsCollapsed;
        private bool InfoIsCollapsed;
        private bool SearchIsCollapsed;
        public Form2()
        {
            WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void SystemBtnLeftPanel_Click(object sender, EventArgs e)
        {
            timerSystemDropDown.Start();
        }

        private void timerSystemDropDown_Tick(object sender, EventArgs e)
        {
            if (SystemIsCollapsed)
            {
                SystemDropDownPanel.Height += 10;
                if (SystemDropDownPanel.Size == SystemDropDownPanel.MaximumSize)
                {
                    timerSystemDropDown.Stop();
                    SystemIsCollapsed = false;
                }
            }
            else
            {
                SystemDropDownPanel.Height -= 10;
                if (SystemDropDownPanel.Size == SystemDropDownPanel.MinimumSize)
                {
                    timerSystemDropDown.Stop();
                    SystemIsCollapsed = true;
                }
            }
        }

        private void InfoBtnLeftPanel_Click(object sender, EventArgs e)
        {
            timerInfoDropDown.Start();
        }

        private void timerInfoDropDown_Tick(object sender, EventArgs e)
        {
            if (InfoIsCollapsed)
            {
                InfoDropDownPanel.Height += 10;
                if (InfoDropDownPanel.Size == InfoDropDownPanel.MaximumSize)
                {
                    timerInfoDropDown.Stop();
                    InfoIsCollapsed = false;
                }
            }
            else
            {
                InfoDropDownPanel.Height -= 10;
                if (InfoDropDownPanel.Size == InfoDropDownPanel.MinimumSize)
                {
                    timerInfoDropDown.Stop();
                    InfoIsCollapsed = true;
                }
            }
        }

        private void SearchBtnLeftPanel_Click(object sender, EventArgs e)
        {
            timerSearchDropDown.Start();
        }

        private void timerSearchDropDown_Tick(object sender, EventArgs e)
        {
            if (SearchIsCollapsed)
            {
                SearchDropDownPanel.Height += 10;
                if (SearchDropDownPanel.Size == SearchDropDownPanel.MaximumSize)
                {
                    timerSearchDropDown.Stop();
                    SearchIsCollapsed = false;
                }
            }
            else
            {
                SearchDropDownPanel.Height -= 10;
                if (SearchDropDownPanel.Size == SearchDropDownPanel.MinimumSize)
                {
                    timerSearchDropDown.Stop();
                    SearchIsCollapsed = true;
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }
    }
}