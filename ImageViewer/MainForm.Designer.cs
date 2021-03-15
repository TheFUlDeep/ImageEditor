namespace ImageViewer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDrawing = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemPenType = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemBrush = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemPencil = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemLine = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemRectangle = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEllipse = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemText = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFont = new System.Windows.Forms.ToolStripMenuItem();
            this.TextBoxText = new System.Windows.Forms.ToolStripTextBox();
            this.MenuItemColor = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemThickness = new System.Windows.Forms.ToolStripMenuItem();
            this.TextBoxThickness = new System.Windows.Forms.ToolStripTextBox();
            this.MenuItemFilters = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemGrayWorld = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemGauss = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSobel = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemRotate = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEmboss = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.radioButtonZoom = new System.Windows.Forms.RadioButton();
            this.radioButtonCenterImage = new System.Windows.Forms.RadioButton();
            this.radioButtonStretchImage = new System.Windows.Forms.RadioButton();
            this.radioButtonNormal = new System.Windows.Forms.RadioButton();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.pictureSubBox = new System.Windows.Forms.PictureBox();
            this.buttonChooseImageColor = new System.Windows.Forms.Button();
            this.MenuItemColorCorr = new System.Windows.Forms.ToolStripMenuItem();
            this.морфологическийГрадиентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBoxOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSubBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFile,
            this.MenuItemDrawing,
            this.MenuItemFilters,
            this.menuItemHelp});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // menuItemFile
            // 
            this.menuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemOpen,
            this.menuItemExit});
            this.menuItemFile.Name = "menuItemFile";
            resources.ApplyResources(this.menuItemFile, "menuItemFile");
            // 
            // menuItemOpen
            // 
            this.menuItemOpen.Name = "menuItemOpen";
            resources.ApplyResources(this.menuItemOpen, "menuItemOpen");
            this.menuItemOpen.Click += new System.EventHandler(this.menuItemOpen_Click);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            resources.ApplyResources(this.menuItemExit, "menuItemExit");
            this.menuItemExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MenuItemDrawing
            // 
            this.MenuItemDrawing.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemPenType,
            this.MenuItemColor,
            this.MenuItemThickness});
            this.MenuItemDrawing.Name = "MenuItemDrawing";
            resources.ApplyResources(this.MenuItemDrawing, "MenuItemDrawing");
            this.MenuItemDrawing.Click += new System.EventHandler(this.MenuItemDrawing_Click);
            // 
            // MenuItemPenType
            // 
            this.MenuItemPenType.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemBrush,
            this.MenuItemPencil,
            this.MenuItemLine,
            this.MenuItemRectangle,
            this.MenuItemEllipse,
            this.MenuItemText});
            this.MenuItemPenType.Name = "MenuItemPenType";
            resources.ApplyResources(this.MenuItemPenType, "MenuItemPenType");
            // 
            // MenuItemBrush
            // 
            this.MenuItemBrush.Checked = true;
            this.MenuItemBrush.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MenuItemBrush.Name = "MenuItemBrush";
            resources.ApplyResources(this.MenuItemBrush, "MenuItemBrush");
            this.MenuItemBrush.Click += new System.EventHandler(this.MenuItemBrush_Click);
            // 
            // MenuItemPencil
            // 
            this.MenuItemPencil.Name = "MenuItemPencil";
            resources.ApplyResources(this.MenuItemPencil, "MenuItemPencil");
            this.MenuItemPencil.Click += new System.EventHandler(this.MenuItemPencil_Click);
            // 
            // MenuItemLine
            // 
            this.MenuItemLine.Name = "MenuItemLine";
            resources.ApplyResources(this.MenuItemLine, "MenuItemLine");
            this.MenuItemLine.Click += new System.EventHandler(this.MenuItemLine_Click);
            // 
            // MenuItemRectangle
            // 
            this.MenuItemRectangle.Name = "MenuItemRectangle";
            resources.ApplyResources(this.MenuItemRectangle, "MenuItemRectangle");
            this.MenuItemRectangle.Click += new System.EventHandler(this.MenuItemRectangle_Click);
            // 
            // MenuItemEllipse
            // 
            this.MenuItemEllipse.Name = "MenuItemEllipse";
            resources.ApplyResources(this.MenuItemEllipse, "MenuItemEllipse");
            this.MenuItemEllipse.Click += new System.EventHandler(this.MenuItemEllipse_Click);
            // 
            // MenuItemText
            // 
            this.MenuItemText.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFont,
            this.TextBoxText});
            this.MenuItemText.Name = "MenuItemText";
            resources.ApplyResources(this.MenuItemText, "MenuItemText");
            this.MenuItemText.Click += new System.EventHandler(this.MenuItemText_Click);
            // 
            // MenuItemFont
            // 
            this.MenuItemFont.Name = "MenuItemFont";
            resources.ApplyResources(this.MenuItemFont, "MenuItemFont");
            this.MenuItemFont.Click += new System.EventHandler(this.MenuItemFont_Click);
            // 
            // TextBoxText
            // 
            resources.ApplyResources(this.TextBoxText, "TextBoxText");
            this.TextBoxText.Name = "TextBoxText";
            // 
            // MenuItemColor
            // 
            this.MenuItemColor.Name = "MenuItemColor";
            resources.ApplyResources(this.MenuItemColor, "MenuItemColor");
            this.MenuItemColor.Click += new System.EventHandler(this.MenuItemColor_Click);
            // 
            // MenuItemThickness
            // 
            this.MenuItemThickness.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TextBoxThickness});
            this.MenuItemThickness.Name = "MenuItemThickness";
            resources.ApplyResources(this.MenuItemThickness, "MenuItemThickness");
            // 
            // TextBoxThickness
            // 
            resources.ApplyResources(this.TextBoxThickness, "TextBoxThickness");
            this.TextBoxThickness.Name = "TextBoxThickness";
            this.TextBoxThickness.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxThickness_KeyUp);
            // 
            // MenuItemFilters
            // 
            this.MenuItemFilters.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemColorCorr,
            this.MenuItemGrayWorld,
            this.морфологическийГрадиентToolStripMenuItem,
            this.MenuItemGauss,
            this.MenuItemSobel,
            this.MenuItemRotate,
            this.MenuItemEmboss});
            this.MenuItemFilters.Name = "MenuItemFilters";
            resources.ApplyResources(this.MenuItemFilters, "MenuItemFilters");
            // 
            // MenuItemGrayWorld
            // 
            this.MenuItemGrayWorld.Name = "MenuItemGrayWorld";
            resources.ApplyResources(this.MenuItemGrayWorld, "MenuItemGrayWorld");
            this.MenuItemGrayWorld.Click += new System.EventHandler(this.MenuItemGrayWorld_Click);
            // 
            // MenuItemGauss
            // 
            this.MenuItemGauss.Name = "MenuItemGauss";
            resources.ApplyResources(this.MenuItemGauss, "MenuItemGauss");
            this.MenuItemGauss.Click += new System.EventHandler(this.MenuItemGauss_Click);
            // 
            // MenuItemSobel
            // 
            this.MenuItemSobel.Name = "MenuItemSobel";
            resources.ApplyResources(this.MenuItemSobel, "MenuItemSobel");
            this.MenuItemSobel.Click += new System.EventHandler(this.MenuItemSobel_Click);
            // 
            // MenuItemRotate
            // 
            this.MenuItemRotate.Name = "MenuItemRotate";
            resources.ApplyResources(this.MenuItemRotate, "MenuItemRotate");
            this.MenuItemRotate.Click += new System.EventHandler(this.MenuItemRotate_Click);
            // 
            // MenuItemEmboss
            // 
            this.MenuItemEmboss.Name = "MenuItemEmboss";
            resources.ApplyResources(this.MenuItemEmboss, "MenuItemEmboss");
            this.MenuItemEmboss.Click += new System.EventHandler(this.MenuItemEmboss_Click);
            // 
            // menuItemHelp
            // 
            this.menuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAbout});
            this.menuItemHelp.Name = "menuItemHelp";
            resources.ApplyResources(this.menuItemHelp, "menuItemHelp");
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Name = "menuItemAbout";
            resources.ApplyResources(this.menuItemAbout, "menuItemAbout");
            this.menuItemAbout.Click += new System.EventHandler(this.menuItemAbout_Click);
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.Controls.Add(this.progressBar);
            this.groupBoxOptions.Controls.Add(this.radioButtonZoom);
            this.groupBoxOptions.Controls.Add(this.radioButtonCenterImage);
            this.groupBoxOptions.Controls.Add(this.radioButtonStretchImage);
            this.groupBoxOptions.Controls.Add(this.radioButtonNormal);
            resources.ApplyResources(this.groupBoxOptions, "groupBoxOptions");
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.TabStop = false;
            // 
            // progressBar
            // 
            resources.ApplyResources(this.progressBar, "progressBar");
            this.progressBar.Name = "progressBar";
            // 
            // radioButtonZoom
            // 
            resources.ApplyResources(this.radioButtonZoom, "radioButtonZoom");
            this.radioButtonZoom.Name = "radioButtonZoom";
            this.radioButtonZoom.UseVisualStyleBackColor = true;
            this.radioButtonZoom.CheckedChanged += new System.EventHandler(this.radioButtonZoom_CheckedChanged);
            // 
            // radioButtonCenterImage
            // 
            resources.ApplyResources(this.radioButtonCenterImage, "radioButtonCenterImage");
            this.radioButtonCenterImage.Name = "radioButtonCenterImage";
            this.radioButtonCenterImage.UseVisualStyleBackColor = true;
            this.radioButtonCenterImage.CheckedChanged += new System.EventHandler(this.radioButtonCenterImage_CheckedChanged);
            // 
            // radioButtonStretchImage
            // 
            resources.ApplyResources(this.radioButtonStretchImage, "radioButtonStretchImage");
            this.radioButtonStretchImage.Name = "radioButtonStretchImage";
            this.radioButtonStretchImage.UseVisualStyleBackColor = true;
            this.radioButtonStretchImage.CheckedChanged += new System.EventHandler(this.radioButtonStretchImage_CheckedChanged);
            // 
            // radioButtonNormal
            // 
            resources.ApplyResources(this.radioButtonNormal, "radioButtonNormal");
            this.radioButtonNormal.Checked = true;
            this.radioButtonNormal.Name = "radioButtonNormal";
            this.radioButtonNormal.TabStop = true;
            this.radioButtonNormal.UseVisualStyleBackColor = true;
            this.radioButtonNormal.CheckedChanged += new System.EventHandler(this.radioButtonNormal_CheckedChanged);
            // 
            // pictureBox
            // 
            resources.ApplyResources(this.pictureBox, "pictureBox");
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            // 
            // pictureSubBox
            // 
            resources.ApplyResources(this.pictureSubBox, "pictureSubBox");
            this.pictureSubBox.Name = "pictureSubBox";
            this.pictureSubBox.TabStop = false;
            // 
            // buttonChooseImageColor
            // 
            resources.ApplyResources(this.buttonChooseImageColor, "buttonChooseImageColor");
            this.buttonChooseImageColor.Name = "buttonChooseImageColor";
            this.buttonChooseImageColor.UseVisualStyleBackColor = true;
            this.buttonChooseImageColor.Click += new System.EventHandler(this.buttonChooseImageColorClick);
            // 
            // MenuItemColorCorr
            // 
            this.MenuItemColorCorr.Name = "MenuItemColorCorr";
            resources.ApplyResources(this.MenuItemColorCorr, "MenuItemColorCorr");
            this.MenuItemColorCorr.Click += new System.EventHandler(this.MenuItemColorCorr_Click);
            // 
            // морфологическийГрадиентToolStripMenuItem
            // 
            this.морфологическийГрадиентToolStripMenuItem.Name = "морфологическийГрадиентToolStripMenuItem";
            resources.ApplyResources(this.морфологическийГрадиентToolStripMenuItem, "морфологическийГрадиентToolStripMenuItem");
            this.морфологическийГрадиентToolStripMenuItem.Click += new System.EventHandler(this.морфологическийГрадиентToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonChooseImageColor);
            this.Controls.Add(this.pictureSubBox);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.groupBoxOptions);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSubBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItemFile;
        private System.Windows.Forms.ToolStripMenuItem menuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.ToolStripMenuItem menuItemHelp;
        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.RadioButton radioButtonZoom;
        private System.Windows.Forms.RadioButton radioButtonCenterImage;
        private System.Windows.Forms.RadioButton radioButtonStretchImage;
        private System.Windows.Forms.RadioButton radioButtonNormal;
        private System.Windows.Forms.ToolStripMenuItem menuItemAbout;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDrawing;
        private System.Windows.Forms.ToolStripMenuItem MenuItemPenType;
        private System.Windows.Forms.ToolStripMenuItem MenuItemColor;
        private System.Windows.Forms.ToolStripMenuItem MenuItemThickness;
        private System.Windows.Forms.ToolStripTextBox TextBoxThickness;
        private System.Windows.Forms.ToolStripMenuItem MenuItemRectangle;
        private System.Windows.Forms.ToolStripMenuItem MenuItemLine;
        private System.Windows.Forms.ToolStripMenuItem MenuItemPencil;
        private System.Windows.Forms.ToolStripMenuItem MenuItemBrush;
        private System.Windows.Forms.ToolStripMenuItem MenuItemText;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFont;
        private System.Windows.Forms.ToolStripTextBox TextBoxText;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEllipse;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFilters;
        private System.Windows.Forms.ToolStripMenuItem MenuItemRotate;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSobel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ToolStripMenuItem MenuItemGrayWorld;
        private System.Windows.Forms.ToolStripMenuItem MenuItemGauss;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEmboss;
        private System.Windows.Forms.PictureBox pictureSubBox;
        private System.Windows.Forms.Button buttonChooseImageColor;
        private System.Windows.Forms.ToolStripMenuItem MenuItemColorCorr;
        private System.Windows.Forms.ToolStripMenuItem морфологическийГрадиентToolStripMenuItem;
    }
}

