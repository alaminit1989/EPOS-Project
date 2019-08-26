using EPOS.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPOS.Forms
{
    public partial class Home : Form
    {
        int PanelWith;
        bool isCollapsed;

        public Home()
        {
            InitializeComponent();
            tmTime.Start();
            PanelWith = panelLeft.Width;
            isCollapsed = false;
            //Dashboard dashb = new Dashboard();
            //AddControlsToPanel(dashb);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void TmMenu_Tick(object sender, EventArgs e)        
        {
            if (isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 10;
                if (panelLeft.Width >= PanelWith)
                {
                    tmMenu.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }                
            }
            else
            {
                panelLeft.Width = panelLeft.Width - 10;
                if (panelLeft.Width <= 59)
                {
                    tmMenu.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            tmMenu.Start();
        }

        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }
        private void BtnHome_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnHome);
            Dashboard dashb = new Dashboard();
            AddControlsToPanel(dashb);
        }

        private void BtnPurchase_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnPurchase);
        }

        private void BtnSales_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnSales);
        }

        private void BtnInventory_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnInventory);
        }

        private void BtnItem_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnItem);
        }

        private void BtnExpenses_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnExpenses);
        }

        private void TmTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("HH:MM:ss");
        }
    }
}
