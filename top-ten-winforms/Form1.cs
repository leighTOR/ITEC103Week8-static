﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace top_ten_winforms
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue800, Primary.Blue500, Accent.Blue200, TextShade.WHITE); ;
        }

        private void btnAnime_Click(object sender, EventArgs e) => tbctrlMenu.SelectedTab = tabAnime;

        private void btnManga_Click(object sender, EventArgs e) => tbctrlMenu.SelectedTab = tabManga;


    }
}
