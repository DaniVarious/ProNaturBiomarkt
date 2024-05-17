﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pronatur_Biomarkt_GmbH
{
    public partial class LoadingScreen : Form
    {
        private int loadingBarValue;
        
        public LoadingScreen()
        {
            InitializeComponent();
        }

     
        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            LoadingBarTimer.Start();

        }

        private void LoadingBarTimer_Tick(object sender, EventArgs e)
        {
            loadingBarValue++;
            
            LoadingProgressBar.Value = loadingBarValue;
            lblprogress.Text = loadingBarValue.ToString();

            if (loadingBarValue >= 100)
            {
                LoadingBarTimer.Stop();

                //Finish loading
                MainMenuScreen mainMenuScreen = new MainMenuScreen();
                mainMenuScreen.Show();
                this.Hide();
            }
        }


    }
}
