using System;
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

        /// <summary>
        /// Clicking the Anime button from home tab.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnime_Click(object sender, EventArgs e) => tbctrlMenu.SelectedTab = tabAnime;

        /// <summary>
        /// Clicking the Manga button from home tab.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnManga_Click(object sender, EventArgs e) => tbctrlMenu.SelectedTab = tabManga;

        /// <summary>
        /// Clicking the add button from anime tab.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Pressing the enter key to trigger the add button from anime tab.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Clicking the clear button from anime tab.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnimeClear_Click(object sender, EventArgs e) => tbAnime.ResetText();

        /// <summary>
        /// Clicking the remove button from anime tab.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnimeRemove_Click(object sender, EventArgs e) => lstbAnime.Items.Remove(lstbAnime.SelectedItem);

        /// <summary>
        /// Clicking the clear all button from anime tab.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnimeClearAll_Click(object sender, EventArgs e) => lstbAnime.Clear();

        /// <summary>
        /// Clicking the add button from manga button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Pressing the enter key to trigger the add button from manga tab.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Clicking the clear button from manga tab.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMangaClear_Click(object sender, EventArgs e) => tbManga.ResetText();

        /// <summary>
        /// Clicking the remove button from manga tab.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMangaRemove_Click(object sender, EventArgs e) => lstbManga.Items.Remove(lstbManga.SelectedItem);

        /// <summary>
        /// Clicking the clear all button from manga tab.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearAll_Click(object sender, EventArgs e) => lstbManga.Clear();
    }
}