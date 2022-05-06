using System;
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
        string[] animelist = new string[10];
        string[] mangalist = new string[10];

        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue800, Primary.Blue500, Accent.Blue200, TextShade.WHITE);
        }

        private void btnAnime_Click(object sender, EventArgs e) => tbctrlMenu.SelectedTab = tabAnime;

        private void btnManga_Click(object sender, EventArgs e) => tbctrlMenu.SelectedTab = tabManga;

        private void btnAnimeAdd_Click(object sender, EventArgs e)
        {
            if (lstbAnime.Items.Count < 10)
            {
                int i = 0;
                if (tbAnime.Text != "")
                {
                    animelist[i] = tbAnime.Text;
                    lstbAnime.Items.Add(new MaterialListBoxItem(animelist[i]));
                    i++;
                }
                else
                    MessageBox.Show("Empty textbox.");
            }
            else
                MessageBox.Show("List should be 10 only.");
        }

        private void tbAnime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAnimeAdd_Click(this, new EventArgs());
                tbAnime.ResetText();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btnAnimeClear_Click(object sender, EventArgs e) => tbAnime.ResetText();

        private void btnAnimeRemove_Click(object sender, EventArgs e) => lstbAnime.Items.Remove(lstbAnime.SelectedItem);

        private void btnAnimeClearAll_Click(object sender, EventArgs e) => lstbAnime.Clear();

        private void btnMangaAdd_Click(object sender, EventArgs e)
        {
            if (lstbManga.Items.Count < 10)
            {
                int i = 0;
                if (tbManga.Text != "")
                {
                    mangalist[i] = tbManga.Text;
                    lstbManga.Items.Add(new MaterialListBoxItem(mangalist[i]));
                    i++;
                }
                else
                    MessageBox.Show("Empty textbox.");
            }
            else
                MessageBox.Show("List should be 10 only.");
        }

        private void tbManga_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnMangaAdd_Click(this, new EventArgs());
                tbManga.ResetText();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btnMangaClear_Click(object sender, EventArgs e) => tbManga.ResetText();

        private void btnMangaRemove_Click(object sender, EventArgs e) => lstbManga.Items.Remove(lstbManga.SelectedItem);

        private void btnClearAll_Click(object sender, EventArgs e) => lstbManga.Clear();
    }
}