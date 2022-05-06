namespace top_ten_winforms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbctrlMenu = new MaterialSkin.Controls.MaterialTabControl();
            this.tabHome = new System.Windows.Forms.TabPage();
            this.btnManga = new MaterialSkin.Controls.MaterialButton();
            this.btnAnime = new MaterialSkin.Controls.MaterialButton();
            this.tabAnime = new System.Windows.Forms.TabPage();
            this.lblAnime = new MaterialSkin.Controls.MaterialLabel();
            this.btnAnimeClearAll = new MaterialSkin.Controls.MaterialButton();
            this.btnAnimeRemove = new MaterialSkin.Controls.MaterialButton();
            this.btnAnimeClear = new MaterialSkin.Controls.MaterialButton();
            this.btnAnimeAdd = new MaterialSkin.Controls.MaterialButton();
            this.tbAnime = new MaterialSkin.Controls.MaterialTextBox();
            this.lstbAnime = new MaterialSkin.Controls.MaterialListBox();
            this.ptbAnime = new System.Windows.Forms.PictureBox();
            this.tabManga = new System.Windows.Forms.TabPage();
            this.lblManga = new MaterialSkin.Controls.MaterialLabel();
            this.btnClearAll = new MaterialSkin.Controls.MaterialButton();
            this.btnMangaRemove = new MaterialSkin.Controls.MaterialButton();
            this.btnMangaClear = new MaterialSkin.Controls.MaterialButton();
            this.btnMangaAdd = new MaterialSkin.Controls.MaterialButton();
            this.tbManga = new MaterialSkin.Controls.MaterialTextBox();
            this.lstbManga = new MaterialSkin.Controls.MaterialListBox();
            this.ptbManga = new System.Windows.Forms.PictureBox();
            this.imglstTabIcons = new System.Windows.Forms.ImageList(this.components);
            this.tbctrlMenu.SuspendLayout();
            this.tabHome.SuspendLayout();
            this.tabAnime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnime)).BeginInit();
            this.tabManga.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbManga)).BeginInit();
            this.SuspendLayout();
            // 
            // tbctrlMenu
            // 
            this.tbctrlMenu.Controls.Add(this.tabHome);
            this.tbctrlMenu.Controls.Add(this.tabAnime);
            this.tbctrlMenu.Controls.Add(this.tabManga);
            this.tbctrlMenu.Depth = 0;
            this.tbctrlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbctrlMenu.ImageList = this.imglstTabIcons;
            this.tbctrlMenu.Location = new System.Drawing.Point(0, 64);
            this.tbctrlMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.tbctrlMenu.Multiline = true;
            this.tbctrlMenu.Name = "tbctrlMenu";
            this.tbctrlMenu.SelectedIndex = 0;
            this.tbctrlMenu.Size = new System.Drawing.Size(1007, 583);
            this.tbctrlMenu.TabIndex = 1;
            // 
            // tabHome
            // 
            this.tabHome.BackgroundImage = global::top_ten_winforms.Properties.Resources.background;
            this.tabHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabHome.Controls.Add(this.btnManga);
            this.tabHome.Controls.Add(this.btnAnime);
            this.tabHome.ImageKey = "home.png";
            this.tabHome.Location = new System.Drawing.Point(4, 39);
            this.tabHome.Name = "tabHome";
            this.tabHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabHome.Size = new System.Drawing.Size(999, 540);
            this.tabHome.TabIndex = 0;
            this.tabHome.Text = "Home";
            this.tabHome.UseVisualStyleBackColor = true;
            // 
            // btnManga
            // 
            this.btnManga.AutoSize = false;
            this.btnManga.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnManga.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnManga.Depth = 0;
            this.btnManga.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManga.HighEmphasis = true;
            this.btnManga.Icon = null;
            this.btnManga.Location = new System.Drawing.Point(356, 351);
            this.btnManga.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnManga.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnManga.Name = "btnManga";
            this.btnManga.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnManga.Size = new System.Drawing.Size(240, 38);
            this.btnManga.TabIndex = 1;
            this.btnManga.Text = "MANGA";
            this.btnManga.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnManga.UseAccentColor = false;
            this.btnManga.UseVisualStyleBackColor = true;
            this.btnManga.Click += new System.EventHandler(this.btnManga_Click);
            // 
            // btnAnime
            // 
            this.btnAnime.AutoSize = false;
            this.btnAnime.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAnime.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAnime.Depth = 0;
            this.btnAnime.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnime.HighEmphasis = true;
            this.btnAnime.Icon = null;
            this.btnAnime.Location = new System.Drawing.Point(356, 301);
            this.btnAnime.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAnime.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAnime.Name = "btnAnime";
            this.btnAnime.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAnime.Size = new System.Drawing.Size(240, 38);
            this.btnAnime.TabIndex = 1;
            this.btnAnime.Text = "ANIME";
            this.btnAnime.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAnime.UseAccentColor = false;
            this.btnAnime.UseVisualStyleBackColor = true;
            this.btnAnime.Click += new System.EventHandler(this.btnAnime_Click);
            // 
            // tabAnime
            // 
            this.tabAnime.Controls.Add(this.lblAnime);
            this.tabAnime.Controls.Add(this.btnAnimeClearAll);
            this.tabAnime.Controls.Add(this.btnAnimeRemove);
            this.tabAnime.Controls.Add(this.btnAnimeClear);
            this.tabAnime.Controls.Add(this.btnAnimeAdd);
            this.tabAnime.Controls.Add(this.tbAnime);
            this.tabAnime.Controls.Add(this.lstbAnime);
            this.tabAnime.Controls.Add(this.ptbAnime);
            this.tabAnime.ImageKey = "anime.png";
            this.tabAnime.Location = new System.Drawing.Point(4, 39);
            this.tabAnime.Name = "tabAnime";
            this.tabAnime.Padding = new System.Windows.Forms.Padding(3);
            this.tabAnime.Size = new System.Drawing.Size(999, 540);
            this.tabAnime.TabIndex = 1;
            this.tabAnime.Text = "Anime";
            this.tabAnime.UseVisualStyleBackColor = true;
            // 
            // lblAnime
            // 
            this.lblAnime.AutoSize = true;
            this.lblAnime.Depth = 0;
            this.lblAnime.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblAnime.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.lblAnime.Location = new System.Drawing.Point(39, 18);
            this.lblAnime.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAnime.Name = "lblAnime";
            this.lblAnime.Size = new System.Drawing.Size(306, 41);
            this.lblAnime.TabIndex = 12;
            this.lblAnime.Text = "MY TOP TEN ANIME";
            // 
            // btnAnimeClearAll
            // 
            this.btnAnimeClearAll.AutoSize = false;
            this.btnAnimeClearAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAnimeClearAll.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAnimeClearAll.Depth = 0;
            this.btnAnimeClearAll.HighEmphasis = true;
            this.btnAnimeClearAll.Icon = null;
            this.btnAnimeClearAll.Location = new System.Drawing.Point(644, 316);
            this.btnAnimeClearAll.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAnimeClearAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAnimeClearAll.Name = "btnAnimeClearAll";
            this.btnAnimeClearAll.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAnimeClearAll.Size = new System.Drawing.Size(281, 36);
            this.btnAnimeClearAll.TabIndex = 2;
            this.btnAnimeClearAll.Text = "CLEAR ALL";
            this.btnAnimeClearAll.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAnimeClearAll.UseAccentColor = false;
            this.btnAnimeClearAll.UseVisualStyleBackColor = true;
            this.btnAnimeClearAll.Click += new System.EventHandler(this.btnAnimeClearAll_Click);
            // 
            // btnAnimeRemove
            // 
            this.btnAnimeRemove.AutoSize = false;
            this.btnAnimeRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAnimeRemove.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAnimeRemove.Depth = 0;
            this.btnAnimeRemove.HighEmphasis = true;
            this.btnAnimeRemove.Icon = null;
            this.btnAnimeRemove.Location = new System.Drawing.Point(644, 268);
            this.btnAnimeRemove.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAnimeRemove.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAnimeRemove.Name = "btnAnimeRemove";
            this.btnAnimeRemove.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAnimeRemove.Size = new System.Drawing.Size(281, 36);
            this.btnAnimeRemove.TabIndex = 2;
            this.btnAnimeRemove.Text = "REMOVE";
            this.btnAnimeRemove.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAnimeRemove.UseAccentColor = false;
            this.btnAnimeRemove.UseVisualStyleBackColor = true;
            this.btnAnimeRemove.Click += new System.EventHandler(this.btnAnimeRemove_Click);
            // 
            // btnAnimeClear
            // 
            this.btnAnimeClear.AutoSize = false;
            this.btnAnimeClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAnimeClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAnimeClear.Depth = 0;
            this.btnAnimeClear.HighEmphasis = true;
            this.btnAnimeClear.Icon = null;
            this.btnAnimeClear.Location = new System.Drawing.Point(644, 193);
            this.btnAnimeClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAnimeClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAnimeClear.Name = "btnAnimeClear";
            this.btnAnimeClear.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAnimeClear.Size = new System.Drawing.Size(281, 36);
            this.btnAnimeClear.TabIndex = 2;
            this.btnAnimeClear.Text = "CLEAR";
            this.btnAnimeClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAnimeClear.UseAccentColor = false;
            this.btnAnimeClear.UseVisualStyleBackColor = true;
            this.btnAnimeClear.Click += new System.EventHandler(this.btnAnimeClear_Click);
            // 
            // btnAnimeAdd
            // 
            this.btnAnimeAdd.AutoSize = false;
            this.btnAnimeAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAnimeAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAnimeAdd.Depth = 0;
            this.btnAnimeAdd.HighEmphasis = true;
            this.btnAnimeAdd.Icon = null;
            this.btnAnimeAdd.Location = new System.Drawing.Point(644, 145);
            this.btnAnimeAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAnimeAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAnimeAdd.Name = "btnAnimeAdd";
            this.btnAnimeAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAnimeAdd.Size = new System.Drawing.Size(281, 36);
            this.btnAnimeAdd.TabIndex = 2;
            this.btnAnimeAdd.Text = "ADD";
            this.btnAnimeAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAnimeAdd.UseAccentColor = false;
            this.btnAnimeAdd.UseVisualStyleBackColor = true;
            this.btnAnimeAdd.Click += new System.EventHandler(this.btnAnimeAdd_Click);
            // 
            // tbAnime
            // 
            this.tbAnime.AnimateReadOnly = false;
            this.tbAnime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbAnime.Depth = 0;
            this.tbAnime.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbAnime.LeadingIcon = null;
            this.tbAnime.Location = new System.Drawing.Point(644, 77);
            this.tbAnime.MaxLength = 50;
            this.tbAnime.MouseState = MaterialSkin.MouseState.OUT;
            this.tbAnime.Multiline = false;
            this.tbAnime.Name = "tbAnime";
            this.tbAnime.Size = new System.Drawing.Size(281, 50);
            this.tbAnime.TabIndex = 0;
            this.tbAnime.Text = "";
            this.tbAnime.TrailingIcon = null;
            this.tbAnime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAnime_KeyDown);
            // 
            // lstbAnime
            // 
            this.lstbAnime.BackColor = System.Drawing.Color.White;
            this.lstbAnime.BorderColor = System.Drawing.Color.LightGray;
            this.lstbAnime.Depth = 0;
            this.lstbAnime.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lstbAnime.Location = new System.Drawing.Point(39, 77);
            this.lstbAnime.MouseState = MaterialSkin.MouseState.HOVER;
            this.lstbAnime.Name = "lstbAnime";
            this.lstbAnime.SelectedIndex = -1;
            this.lstbAnime.SelectedItem = null;
            this.lstbAnime.Size = new System.Drawing.Size(579, 404);
            this.lstbAnime.TabIndex = 0;
            // 
            // ptbAnime
            // 
            this.ptbAnime.Image = global::top_ten_winforms.Properties.Resources.yui;
            this.ptbAnime.Location = new System.Drawing.Point(605, 379);
            this.ptbAnime.Name = "ptbAnime";
            this.ptbAnime.Size = new System.Drawing.Size(364, 206);
            this.ptbAnime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAnime.TabIndex = 3;
            this.ptbAnime.TabStop = false;
            // 
            // tabManga
            // 
            this.tabManga.Controls.Add(this.lblManga);
            this.tabManga.Controls.Add(this.btnClearAll);
            this.tabManga.Controls.Add(this.btnMangaRemove);
            this.tabManga.Controls.Add(this.btnMangaClear);
            this.tabManga.Controls.Add(this.btnMangaAdd);
            this.tabManga.Controls.Add(this.tbManga);
            this.tabManga.Controls.Add(this.lstbManga);
            this.tabManga.Controls.Add(this.ptbManga);
            this.tabManga.ImageKey = "manga.png";
            this.tabManga.Location = new System.Drawing.Point(4, 39);
            this.tabManga.Name = "tabManga";
            this.tabManga.Size = new System.Drawing.Size(999, 540);
            this.tabManga.TabIndex = 2;
            this.tabManga.Text = "Manga";
            this.tabManga.UseVisualStyleBackColor = true;
            // 
            // lblManga
            // 
            this.lblManga.AutoSize = true;
            this.lblManga.Depth = 0;
            this.lblManga.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lblManga.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.lblManga.Location = new System.Drawing.Point(39, 18);
            this.lblManga.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblManga.Name = "lblManga";
            this.lblManga.Size = new System.Drawing.Size(323, 41);
            this.lblManga.TabIndex = 11;
            this.lblManga.Text = "MY TOP TEN MANGA";
            // 
            // btnClearAll
            // 
            this.btnClearAll.AutoSize = false;
            this.btnClearAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClearAll.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClearAll.Depth = 0;
            this.btnClearAll.HighEmphasis = true;
            this.btnClearAll.Icon = null;
            this.btnClearAll.Location = new System.Drawing.Point(644, 316);
            this.btnClearAll.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClearAll.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClearAll.Size = new System.Drawing.Size(281, 36);
            this.btnClearAll.TabIndex = 6;
            this.btnClearAll.Text = "CLEAR ALL";
            this.btnClearAll.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClearAll.UseAccentColor = false;
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnMangaRemove
            // 
            this.btnMangaRemove.AutoSize = false;
            this.btnMangaRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMangaRemove.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnMangaRemove.Depth = 0;
            this.btnMangaRemove.HighEmphasis = true;
            this.btnMangaRemove.Icon = null;
            this.btnMangaRemove.Location = new System.Drawing.Point(644, 268);
            this.btnMangaRemove.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMangaRemove.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMangaRemove.Name = "btnMangaRemove";
            this.btnMangaRemove.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnMangaRemove.Size = new System.Drawing.Size(281, 36);
            this.btnMangaRemove.TabIndex = 7;
            this.btnMangaRemove.Text = "REMOVE";
            this.btnMangaRemove.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnMangaRemove.UseAccentColor = false;
            this.btnMangaRemove.UseVisualStyleBackColor = true;
            this.btnMangaRemove.Click += new System.EventHandler(this.btnMangaRemove_Click);
            // 
            // btnMangaClear
            // 
            this.btnMangaClear.AutoSize = false;
            this.btnMangaClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMangaClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnMangaClear.Depth = 0;
            this.btnMangaClear.HighEmphasis = true;
            this.btnMangaClear.Icon = null;
            this.btnMangaClear.Location = new System.Drawing.Point(644, 193);
            this.btnMangaClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMangaClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMangaClear.Name = "btnMangaClear";
            this.btnMangaClear.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnMangaClear.Size = new System.Drawing.Size(281, 36);
            this.btnMangaClear.TabIndex = 8;
            this.btnMangaClear.Text = "CLEAR";
            this.btnMangaClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnMangaClear.UseAccentColor = false;
            this.btnMangaClear.UseVisualStyleBackColor = true;
            this.btnMangaClear.Click += new System.EventHandler(this.btnMangaClear_Click);
            // 
            // btnMangaAdd
            // 
            this.btnMangaAdd.AutoSize = false;
            this.btnMangaAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMangaAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnMangaAdd.Depth = 0;
            this.btnMangaAdd.HighEmphasis = true;
            this.btnMangaAdd.Icon = null;
            this.btnMangaAdd.Location = new System.Drawing.Point(644, 145);
            this.btnMangaAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMangaAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMangaAdd.Name = "btnMangaAdd";
            this.btnMangaAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnMangaAdd.Size = new System.Drawing.Size(281, 36);
            this.btnMangaAdd.TabIndex = 9;
            this.btnMangaAdd.Text = "ADD";
            this.btnMangaAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnMangaAdd.UseAccentColor = false;
            this.btnMangaAdd.UseVisualStyleBackColor = true;
            this.btnMangaAdd.Click += new System.EventHandler(this.btnMangaAdd_Click);
            // 
            // tbManga
            // 
            this.tbManga.AnimateReadOnly = false;
            this.tbManga.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbManga.Depth = 0;
            this.tbManga.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tbManga.LeadingIcon = null;
            this.tbManga.Location = new System.Drawing.Point(644, 77);
            this.tbManga.MaxLength = 50;
            this.tbManga.MouseState = MaterialSkin.MouseState.OUT;
            this.tbManga.Multiline = false;
            this.tbManga.Name = "tbManga";
            this.tbManga.Size = new System.Drawing.Size(281, 50);
            this.tbManga.TabIndex = 0;
            this.tbManga.Text = "";
            this.tbManga.TrailingIcon = null;
            this.tbManga.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbManga_KeyDown);
            // 
            // lstbManga
            // 
            this.lstbManga.BackColor = System.Drawing.Color.White;
            this.lstbManga.BorderColor = System.Drawing.Color.LightGray;
            this.lstbManga.Depth = 0;
            this.lstbManga.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lstbManga.Location = new System.Drawing.Point(39, 77);
            this.lstbManga.MouseState = MaterialSkin.MouseState.HOVER;
            this.lstbManga.Name = "lstbManga";
            this.lstbManga.SelectedIndex = -1;
            this.lstbManga.SelectedItem = null;
            this.lstbManga.Size = new System.Drawing.Size(579, 404);
            this.lstbManga.TabIndex = 4;
            // 
            // ptbManga
            // 
            this.ptbManga.Image = global::top_ten_winforms.Properties.Resources.Picture2;
            this.ptbManga.Location = new System.Drawing.Point(617, 380);
            this.ptbManga.Name = "ptbManga";
            this.ptbManga.Size = new System.Drawing.Size(330, 205);
            this.ptbManga.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbManga.TabIndex = 10;
            this.ptbManga.TabStop = false;
            // 
            // imglstTabIcons
            // 
            this.imglstTabIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imglstTabIcons.ImageStream")));
            this.imglstTabIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imglstTabIcons.Images.SetKeyName(0, "anime.png");
            this.imglstTabIcons.Images.SetKeyName(1, "home.png");
            this.imglstTabIcons.Images.SetKeyName(2, "manga.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 650);
            this.Controls.Add(this.tbctrlMenu);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.tbctrlMenu;
            this.DrawerWidth = 150;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 64, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anime & Manga: My Top Ten";
            this.tbctrlMenu.ResumeLayout(false);
            this.tabHome.ResumeLayout(false);
            this.tabAnime.ResumeLayout(false);
            this.tabAnime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAnime)).EndInit();
            this.tabManga.ResumeLayout(false);
            this.tabManga.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbManga)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl tbctrlMenu;
        private System.Windows.Forms.TabPage tabHome;
        private System.Windows.Forms.TabPage tabAnime;
        private System.Windows.Forms.TabPage tabManga;
        private System.Windows.Forms.ImageList imglstTabIcons;
        private MaterialSkin.Controls.MaterialButton btnAnime;
        private MaterialSkin.Controls.MaterialButton btnManga;
        private MaterialSkin.Controls.MaterialListBox lstbAnime;
        private MaterialSkin.Controls.MaterialTextBox tbAnime;
        private MaterialSkin.Controls.MaterialButton btnAnimeClearAll;
        private MaterialSkin.Controls.MaterialButton btnAnimeRemove;
        private MaterialSkin.Controls.MaterialButton btnAnimeClear;
        private MaterialSkin.Controls.MaterialButton btnAnimeAdd;
        private System.Windows.Forms.PictureBox ptbAnime;
        private MaterialSkin.Controls.MaterialButton btnClearAll;
        private MaterialSkin.Controls.MaterialButton btnMangaRemove;
        private MaterialSkin.Controls.MaterialButton btnMangaClear;
        private MaterialSkin.Controls.MaterialButton btnMangaAdd;
        private MaterialSkin.Controls.MaterialTextBox tbManga;
        private MaterialSkin.Controls.MaterialListBox lstbManga;
        private System.Windows.Forms.PictureBox ptbManga;
        private MaterialSkin.Controls.MaterialLabel lblManga;
        private MaterialSkin.Controls.MaterialLabel lblAnime;
    }
}

