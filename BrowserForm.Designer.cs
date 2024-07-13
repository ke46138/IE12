namespace CefSharp.MinimalExample.WinForms
{
    partial class BrowserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowserForm));
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.statusLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.backButton = new System.Windows.Forms.ToolStripButton();
            this.forwardButton = new System.Windows.Forms.ToolStripButton();
            this.urlTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.goButton = new System.Windows.Forms.ToolStripButton();
            this.Home = new System.Windows.Forms.ToolStripButton();
            this.Star = new System.Windows.Forms.ToolStripButton();
            this.settingsButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.debugButton = new System.Windows.Forms.ToolStripButton();
            this.settingsContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printbToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.previewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.pageSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.воВесьЭкранToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакCTRLSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиНаЭтойСтраницеCTRLFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рекомедуемыСайтыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клавишнаяНавигацияF7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browserMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.вперёдToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.назадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.открытьИнструментыРазработчикаDevToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.settingsContextMenuStrip.SuspendLayout();
            this.browserMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer
            // 
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.Controls.Add(this.statusLabel);
            this.toolStripContainer.ContentPanel.Controls.Add(this.outputLabel);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(730, 449);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.LeftToolStripPanelVisible = false;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.RightToolStripPanelVisible = false;
            this.toolStripContainer.Size = new System.Drawing.Size(730, 490);
            this.toolStripContainer.TabIndex = 0;
            this.toolStripContainer.Text = "toolStripContainer1";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // statusLabel
            // 
            this.statusLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusLabel.Location = new System.Drawing.Point(0, 423);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(730, 13);
            this.statusLabel.TabIndex = 1;
            // 
            // outputLabel
            // 
            this.outputLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.outputLabel.Location = new System.Drawing.Point(0, 436);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(730, 13);
            this.outputLabel.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backButton,
            this.forwardButton,
            this.urlTextBox,
            this.goButton,
            this.Home,
            this.Star,
            this.settingsButton,
            this.toolStripButton1,
            this.debugButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(730, 41);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Layout += new System.Windows.Forms.LayoutEventHandler(this.HandleToolStripLayout);
            // 
            // backButton
            // 
            this.backButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.backButton.Image = global::CefSharp.MinimalExample.WinForms.Properties.Resources.backNotBlue;
            this.backButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.backButton.ImageTransparentColor = System.Drawing.Color.White;
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(42, 38);
            this.backButton.Text = "Назад";
            this.backButton.Click += new System.EventHandler(this.BackButtonClick);
            // 
            // forwardButton
            // 
            this.forwardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.forwardButton.Image = global::CefSharp.MinimalExample.WinForms.Properties.Resources.ForwoardNotBlue;
            this.forwardButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.forwardButton.ImageTransparentColor = System.Drawing.Color.White;
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(30, 38);
            this.forwardButton.Text = "Вперёд";
            this.forwardButton.Click += new System.EventHandler(this.ForwardButtonClick);
            // 
            // urlTextBox
            // 
            this.urlTextBox.AutoSize = false;
            this.urlTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(500, 25);
            this.urlTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UrlTextBoxKeyUp);
            // 
            // goButton
            // 
            this.goButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.goButton.Image = global::CefSharp.MinimalExample.WinForms.Properties.Resources.refresh;
            this.goButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.goButton.ImageTransparentColor = System.Drawing.Color.White;
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(23, 38);
            this.goButton.Text = "Обновить";
            this.goButton.Click += new System.EventHandler(this.GoButtonClick);
            // 
            // Home
            // 
            this.Home.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Home.Image = global::CefSharp.MinimalExample.WinForms.Properties.Resources.home;
            this.Home.ImageTransparentColor = System.Drawing.Color.White;
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(23, 38);
            this.Home.Text = "Домой (ALT+HOME)";
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Star
            // 
            this.Star.CheckOnClick = true;
            this.Star.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Star.Image = global::CefSharp.MinimalExample.WinForms.Properties.Resources.star;
            this.Star.ImageTransparentColor = System.Drawing.Color.White;
            this.Star.Name = "Star";
            this.Star.Size = new System.Drawing.Size(23, 38);
            this.Star.Text = "Просмотр избранного, веб-каналов и журналов (ALT+C)";
            // 
            // settingsButton
            // 
            this.settingsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.settingsButton.Image = global::CefSharp.MinimalExample.WinForms.Properties.Resources.settings;
            this.settingsButton.ImageTransparentColor = System.Drawing.Color.White;
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(23, 38);
            this.settingsButton.Text = "toolStripButton1";
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::CefSharp.MinimalExample.WinForms.Properties.Resources.smile;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 38);
            this.toolStripButton1.Text = "Открыть страницу проекта на github";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // debugButton
            // 
            this.debugButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.debugButton.Image = ((System.Drawing.Image)(resources.GetObject("debugButton.Image")));
            this.debugButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.debugButton.Name = "debugButton";
            this.debugButton.Size = new System.Drawing.Size(23, 38);
            this.debugButton.Text = "Debug button";
            this.debugButton.Click += new System.EventHandler(this.debugButton_Click);
            // 
            // settingsContextMenuStrip
            // 
            this.settingsContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.fileToolStripMenuItem});
            this.settingsContextMenuStrip.Name = "settingsContextMenuStrip";
            this.settingsContextMenuStrip.Size = new System.Drawing.Size(114, 48);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printbToolStripMenuItem1,
            this.previewToolStripMenuItem,
            this.toolStripSeparator1,
            this.pageSettingsToolStripMenuItem});
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.printToolStripMenuItem.Text = "Печать";
            // 
            // printbToolStripMenuItem1
            // 
            this.printbToolStripMenuItem1.Name = "printbToolStripMenuItem1";
            this.printbToolStripMenuItem1.Size = new System.Drawing.Size(242, 22);
            this.printbToolStripMenuItem1.Text = "Печать... CTRL+P";
            // 
            // previewToolStripMenuItem
            // 
            this.previewToolStripMenuItem.Name = "previewToolStripMenuItem";
            this.previewToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.previewToolStripMenuItem.Text = "Предварительный просмотр...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(239, 6);
            // 
            // pageSettingsToolStripMenuItem
            // 
            this.pageSettingsToolStripMenuItem.Name = "pageSettingsToolStripMenuItem";
            this.pageSettingsToolStripMenuItem.Size = new System.Drawing.Size(242, 22);
            this.pageSettingsToolStripMenuItem.Text = "Параметры страницы...";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.воВесьЭкранToolStripMenuItem,
            this.сохранитьКакCTRLSToolStripMenuItem,
            this.найтиНаЭтойСтраницеCTRLFToolStripMenuItem,
            this.рекомедуемыСайтыToolStripMenuItem,
            this.клавишнаяНавигацияF7ToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // воВесьЭкранToolStripMenuItem
            // 
            this.воВесьЭкранToolStripMenuItem.Name = "воВесьЭкранToolStripMenuItem";
            this.воВесьЭкранToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.воВесьЭкранToolStripMenuItem.Text = "Во весь экран                             F11";
            // 
            // сохранитьКакCTRLSToolStripMenuItem
            // 
            this.сохранитьКакCTRLSToolStripMenuItem.Name = "сохранитьКакCTRLSToolStripMenuItem";
            this.сохранитьКакCTRLSToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.сохранитьКакCTRLSToolStripMenuItem.Text = "Сохранить как...                        CTRL+S";
            // 
            // найтиНаЭтойСтраницеCTRLFToolStripMenuItem
            // 
            this.найтиНаЭтойСтраницеCTRLFToolStripMenuItem.Name = "найтиНаЭтойСтраницеCTRLFToolStripMenuItem";
            this.найтиНаЭтойСтраницеCTRLFToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.найтиНаЭтойСтраницеCTRLFToolStripMenuItem.Text = "Найти на этой странице          CTRL+F";
            // 
            // рекомедуемыСайтыToolStripMenuItem
            // 
            this.рекомедуемыСайтыToolStripMenuItem.Name = "рекомедуемыСайтыToolStripMenuItem";
            this.рекомедуемыСайтыToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.рекомедуемыСайтыToolStripMenuItem.Text = "Рекомедуемые сайты";
            // 
            // клавишнаяНавигацияF7ToolStripMenuItem
            // 
            this.клавишнаяНавигацияF7ToolStripMenuItem.Name = "клавишнаяНавигацияF7ToolStripMenuItem";
            this.клавишнаяНавигацияF7ToolStripMenuItem.Size = new System.Drawing.Size(277, 22);
            this.клавишнаяНавигацияF7ToolStripMenuItem.Text = "Клавишная навигация             F7";
            // 
            // browserMenuStrip
            // 
            this.browserMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вперёдToolStripMenuItem,
            this.назадToolStripMenuItem,
            this.toolStripSeparator2,
            this.открытьИнструментыРазработчикаDevToolsToolStripMenuItem});
            this.browserMenuStrip.Name = "browserMenuStrip";
            this.browserMenuStrip.Size = new System.Drawing.Size(336, 76);
            // 
            // вперёдToolStripMenuItem
            // 
            this.вперёдToolStripMenuItem.Name = "вперёдToolStripMenuItem";
            this.вперёдToolStripMenuItem.Size = new System.Drawing.Size(335, 22);
            this.вперёдToolStripMenuItem.Text = "Вперёд";
            // 
            // назадToolStripMenuItem
            // 
            this.назадToolStripMenuItem.Name = "назадToolStripMenuItem";
            this.назадToolStripMenuItem.Size = new System.Drawing.Size(335, 22);
            this.назадToolStripMenuItem.Text = "Назад";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(332, 6);
            // 
            // открытьИнструментыРазработчикаDevToolsToolStripMenuItem
            // 
            this.открытьИнструментыРазработчикаDevToolsToolStripMenuItem.Name = "открытьИнструментыРазработчикаDevToolsToolStripMenuItem";
            this.открытьИнструментыРазработчикаDevToolsToolStripMenuItem.Size = new System.Drawing.Size(335, 22);
            this.открытьИнструментыРазработчикаDevToolsToolStripMenuItem.Text = "Открыть инструменты разработчика (DevTools)";
            // 
            // BrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 490);
            this.Controls.Add(this.toolStripContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BrowserForm";
            this.Text = "IE 12";
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.PerformLayout();
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.settingsContextMenuStrip.ResumeLayout(false);
            this.browserMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton backButton;
        private System.Windows.Forms.ToolStripButton forwardButton;
        private System.Windows.Forms.ToolStripTextBox urlTextBox;
        private System.Windows.Forms.ToolStripButton goButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ToolStripButton Home;
        private System.Windows.Forms.ContextMenuStrip settingsContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printbToolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton Star;
        private System.Windows.Forms.ToolStripButton settingsButton;
        private System.Windows.Forms.ToolStripMenuItem previewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem pageSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem воВесьЭкранToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакCTRLSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem найтиНаЭтойСтраницеCTRLFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рекомедуемыСайтыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem клавишнаяНавигацияF7ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton debugButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ContextMenuStrip browserMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem вперёдToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem назадToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem открытьИнструментыРазработчикаDevToolsToolStripMenuItem;
    }
}