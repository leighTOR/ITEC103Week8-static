using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace top_ten_winforms
{
    /// <summary>
    /// A desktop application that lists your top ten favourite anime and manga.
    /// This project implemented a static data structure which is array to demonstrate how this static works.
    /// </summary>
    public partial class Form1 : MaterialForm
    {
        string[] animelist = new string[10];
        string[] mangalist = new string[10];

        #region Constructors
        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue900, Primary.Blue800, Primary.Blue500, Accent.Blue200, TextShade.WHITE);
        }
        #endregion

        #region Home tab
        /// <summary>
        /// Going to the anime tab.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnime_Click(object sender, EventArgs e) => tbctrlMenu.SelectedTab = tabAnime;

        /// <summary>
        /// Going to the manga tab.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnManga_Click(object sender, EventArgs e) => tbctrlMenu.SelectedTab = tabManga;
        #endregion;

        #region Anime tab
        /// <summary>
        /// Adding the anime titles from the textbox to the listbox.
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
        /// Clearing the Anime title in texbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnimeClear_Click(object sender, EventArgs e) => tbAnime.ResetText();

        /// <summary>
        /// Removing an anime title from the listbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnimeRemove_Click(object sender, EventArgs e) => lstbAnime.Items.Remove(lstbAnime.SelectedItem);

        /// <summary>
        /// Clearing all the titles from the listbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnimeClearAll_Click(object sender, EventArgs e) => lstbAnime.Clear();
        #endregion

        #region Manga tab
        /// <summary>
        /// Adding the manga title from textbox to the listbox.
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
        /// Clearing the manga title textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMangaClear_Click(object sender, EventArgs e) => tbManga.ResetText();

        /// <summary>
        /// Removing a manga title from the listbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMangaRemove_Click(object sender, EventArgs e) => lstbManga.Items.Remove(lstbManga.SelectedItem);

        /// <summary>
        /// Clearing all the titles from the listbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearAll_Click(object sender, EventArgs e) => lstbManga.Clear();
        #endregion
    }
}