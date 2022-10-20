
namespace Game_of_Life
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cellColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toroidalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reload = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeAndTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showNeighborCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridOnOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hudOnOff = new System.Windows.Forms.ToolStripMenuItem();
            this.seedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomSeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.PlayButton = new System.Windows.Forms.ToolStripButton();
            this.PauseButton = new System.Windows.Forms.ToolStripButton();
            this.NextButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelGenerations = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelLiveCells = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelMode = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundColorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cellColorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gridColorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toroidalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.finiteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.graphicsPanel1 = new Game_of_Life.GraphicsPanel();
            this.hudMode = new System.Windows.Forms.Label();
            this.hudWidth = new System.Windows.Forms.Label();
            this.hudHeight = new System.Windows.Forms.Label();
            this.hudCellCount = new System.Windows.Forms.Label();
            this.hudGenerations = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.graphicsPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.seedToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(813, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.open,
            this.toolStripSeparator,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newRandomSeed_Click);
            // 
            // open
            // 
            this.open.Image = ((System.Drawing.Image)(resources.GetObject("open.Image")));
            this.open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.open.Name = "open";
            this.open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.open.Size = new System.Drawing.Size(146, 22);
            this.open.Text = "&Open";
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exit_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.modeToolStripMenuItem,
            this.toolStripSeparator2,
            this.resetToolStripMenuItem,
            this.reload,
            this.sizeAndTimeToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.toolsToolStripMenuItem.Text = "&Settings";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundColorToolStripMenuItem,
            this.cellColorToolStripMenuItem,
            this.gridColorToolStripMenuItem});
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // backgroundColorToolStripMenuItem
            // 
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.backgroundColorToolStripMenuItem.Text = "Background Color";
            this.backgroundColorToolStripMenuItem.Click += new System.EventHandler(this.backgroundColor_Click);
            // 
            // cellColorToolStripMenuItem
            // 
            this.cellColorToolStripMenuItem.Name = "cellColorToolStripMenuItem";
            this.cellColorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.cellColorToolStripMenuItem.Text = "Cell Color";
            this.cellColorToolStripMenuItem.Click += new System.EventHandler(this.cellColor_Click);
            // 
            // gridColorToolStripMenuItem
            // 
            this.gridColorToolStripMenuItem.Name = "gridColorToolStripMenuItem";
            this.gridColorToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.gridColorToolStripMenuItem.Text = "Grid Color";
            this.gridColorToolStripMenuItem.Click += new System.EventHandler(this.gridColor_Click);
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toroidalToolStripMenuItem,
            this.finiteToolStripMenuItem});
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.modeToolStripMenuItem.Text = "&Mode";
            // 
            // toroidalToolStripMenuItem
            // 
            this.toroidalToolStripMenuItem.Name = "toroidalToolStripMenuItem";
            this.toroidalToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.toroidalToolStripMenuItem.Text = "Toroidal";
            this.toroidalToolStripMenuItem.Click += new System.EventHandler(this.toroidal_Click);
            // 
            // finiteToolStripMenuItem
            // 
            this.finiteToolStripMenuItem.Checked = true;
            this.finiteToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.finiteToolStripMenuItem.Name = "finiteToolStripMenuItem";
            this.finiteToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.finiteToolStripMenuItem.Text = "Finite";
            this.finiteToolStripMenuItem.Click += new System.EventHandler(this.finite_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.resetToolStripMenuItem.Text = "&Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.reset_Click);
            // 
            // reload
            // 
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(146, 22);
            this.reload.Text = "&Reload";
            this.reload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.reload.Click += new System.EventHandler(this.reload_Click);
            // 
            // sizeAndTimeToolStripMenuItem
            // 
            this.sizeAndTimeToolStripMenuItem.Name = "sizeAndTimeToolStripMenuItem";
            this.sizeAndTimeToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.sizeAndTimeToolStripMenuItem.Text = "&Size and Time";
            this.sizeAndTimeToolStripMenuItem.Click += new System.EventHandler(this.sizeAndTime_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showNeighborCountToolStripMenuItem,
            this.gridOnOffToolStripMenuItem,
            this.hudOnOff});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // showNeighborCountToolStripMenuItem
            // 
            this.showNeighborCountToolStripMenuItem.Name = "showNeighborCountToolStripMenuItem";
            this.showNeighborCountToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.showNeighborCountToolStripMenuItem.Text = "Show Neighbor Count";
            this.showNeighborCountToolStripMenuItem.Click += new System.EventHandler(this.showNeighborCount_Click);
            // 
            // gridOnOffToolStripMenuItem
            // 
            this.gridOnOffToolStripMenuItem.Name = "gridOnOffToolStripMenuItem";
            this.gridOnOffToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.gridOnOffToolStripMenuItem.Text = "Grid On/Off";
            this.gridOnOffToolStripMenuItem.Click += new System.EventHandler(this.gridOnOff_Click);
            // 
            // hudOnOff
            // 
            this.hudOnOff.Name = "hudOnOff";
            this.hudOnOff.Size = new System.Drawing.Size(192, 22);
            this.hudOnOff.Text = "HUD On/Off";
            this.hudOnOff.Click += new System.EventHandler(this.hudOnOff_Click);
            // 
            // seedToolStripMenuItem
            // 
            this.seedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSeedToolStripMenuItem,
            this.randomSeedToolStripMenuItem});
            this.seedToolStripMenuItem.Name = "seedToolStripMenuItem";
            this.seedToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.seedToolStripMenuItem.Text = "&Seed";
            // 
            // newSeedToolStripMenuItem
            // 
            this.newSeedToolStripMenuItem.Name = "newSeedToolStripMenuItem";
            this.newSeedToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.newSeedToolStripMenuItem.Text = "&New Seed";
            this.newSeedToolStripMenuItem.Click += new System.EventHandler(this.newSeed_Click);
            // 
            // randomSeedToolStripMenuItem
            // 
            this.randomSeedToolStripMenuItem.Name = "randomSeedToolStripMenuItem";
            this.randomSeedToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.randomSeedToolStripMenuItem.Text = "&Random Seed";
            this.randomSeedToolStripMenuItem.Click += new System.EventHandler(this.newRandomSeed_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator6,
            this.PlayButton,
            this.PauseButton,
            this.NextButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(813, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newButton
            // 
            this.newButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newButton.Image = ((System.Drawing.Image)(resources.GetObject("newButton.Image")));
            this.newButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(23, 22);
            this.newButton.Text = "&New";
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            this.openToolStripButton.Click += new System.EventHandler(this.open_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveAs_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // PlayButton
            // 
            this.PlayButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PlayButton.Image = ((System.Drawing.Image)(resources.GetObject("PlayButton.Image")));
            this.PlayButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(23, 22);
            this.PlayButton.Text = "Start";
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PauseButton.Image = ((System.Drawing.Image)(resources.GetObject("PauseButton.Image")));
            this.PauseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(23, 22);
            this.PauseButton.Text = "Pause";
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NextButton.Image = ((System.Drawing.Image)(resources.GetObject("NextButton.Image")));
            this.NextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(23, 22);
            this.NextButton.Text = "Next Generation";
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelGenerations,
            this.toolStripStatusLabelLiveCells,
            this.toolStripStatusLabelMode});
            this.statusStrip1.Location = new System.Drawing.Point(0, 643);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(813, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelGenerations
            // 
            this.toolStripStatusLabelGenerations.Name = "toolStripStatusLabelGenerations";
            this.toolStripStatusLabelGenerations.Size = new System.Drawing.Size(90, 17);
            this.toolStripStatusLabelGenerations.Text = "Generations = 0";
            // 
            // toolStripStatusLabelLiveCells
            // 
            this.toolStripStatusLabelLiveCells.Name = "toolStripStatusLabelLiveCells";
            this.toolStripStatusLabelLiveCells.Size = new System.Drawing.Size(76, 17);
            this.toolStripStatusLabelLiveCells.Text = "Live Cells = 0";
            // 
            // toolStripStatusLabelMode
            // 
            this.toolStripStatusLabelMode.Name = "toolStripStatusLabelMode";
            this.toolStripStatusLabelMode.Size = new System.Drawing.Size(73, 17);
            this.toolStripStatusLabelMode.Text = "Mode: Finite";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.modeToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(106, 48);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backgroundColorToolStripMenuItem1,
            this.cellColorToolStripMenuItem1,
            this.gridColorToolStripMenuItem1});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // backgroundColorToolStripMenuItem1
            // 
            this.backgroundColorToolStripMenuItem1.Name = "backgroundColorToolStripMenuItem1";
            this.backgroundColorToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.backgroundColorToolStripMenuItem1.Text = "Background Color";
            this.backgroundColorToolStripMenuItem1.Click += new System.EventHandler(this.backgroundColor_Click);
            // 
            // cellColorToolStripMenuItem1
            // 
            this.cellColorToolStripMenuItem1.Name = "cellColorToolStripMenuItem1";
            this.cellColorToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.cellColorToolStripMenuItem1.Text = "Cell Color";
            this.cellColorToolStripMenuItem1.Click += new System.EventHandler(this.cellColor_Click);
            // 
            // gridColorToolStripMenuItem1
            // 
            this.gridColorToolStripMenuItem1.Name = "gridColorToolStripMenuItem1";
            this.gridColorToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.gridColorToolStripMenuItem1.Text = "Grid Color";
            this.gridColorToolStripMenuItem1.Click += new System.EventHandler(this.gridColor_Click);
            // 
            // modeToolStripMenuItem1
            // 
            this.modeToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toroidalToolStripMenuItem1,
            this.finiteToolStripMenuItem1});
            this.modeToolStripMenuItem1.Name = "modeToolStripMenuItem1";
            this.modeToolStripMenuItem1.Size = new System.Drawing.Size(105, 22);
            this.modeToolStripMenuItem1.Text = "Mode";
            // 
            // toroidalToolStripMenuItem1
            // 
            this.toroidalToolStripMenuItem1.Name = "toroidalToolStripMenuItem1";
            this.toroidalToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.toroidalToolStripMenuItem1.Text = "Toroidal";
            this.toroidalToolStripMenuItem1.Click += new System.EventHandler(this.toroidal_Click);
            // 
            // finiteToolStripMenuItem1
            // 
            this.finiteToolStripMenuItem1.Name = "finiteToolStripMenuItem1";
            this.finiteToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.finiteToolStripMenuItem1.Text = "Finite";
            this.finiteToolStripMenuItem1.Click += new System.EventHandler(this.finite_Click);
            // 
            // graphicsPanel1
            // 
            this.graphicsPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.graphicsPanel1.ContextMenuStrip = this.contextMenuStrip1;
            this.graphicsPanel1.Controls.Add(this.hudMode);
            this.graphicsPanel1.Controls.Add(this.hudWidth);
            this.graphicsPanel1.Controls.Add(this.hudHeight);
            this.graphicsPanel1.Controls.Add(this.hudCellCount);
            this.graphicsPanel1.Controls.Add(this.hudGenerations);
            this.graphicsPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphicsPanel1.Location = new System.Drawing.Point(0, 49);
            this.graphicsPanel1.Name = "graphicsPanel1";
            this.graphicsPanel1.Size = new System.Drawing.Size(813, 594);
            this.graphicsPanel1.TabIndex = 3;
            this.graphicsPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.graphicsPanel1_Paint);
            this.graphicsPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.graphicsPanel1_MouseClick);
            // 
            // hudMode
            // 
            this.hudMode.AutoSize = true;
            this.hudMode.BackColor = System.Drawing.Color.Transparent;
            this.hudMode.CausesValidation = false;
            this.hudMode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hudMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hudMode.Location = new System.Drawing.Point(0, 494);
            this.hudMode.Name = "hudMode";
            this.hudMode.Size = new System.Drawing.Size(108, 20);
            this.hudMode.TabIndex = 4;
            this.hudMode.Text = "Mode: Finite";
            // 
            // hudWidth
            // 
            this.hudWidth.AutoSize = true;
            this.hudWidth.BackColor = System.Drawing.Color.Transparent;
            this.hudWidth.CausesValidation = false;
            this.hudWidth.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hudWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hudWidth.Location = new System.Drawing.Point(0, 514);
            this.hudWidth.Name = "hudWidth";
            this.hudWidth.Size = new System.Drawing.Size(95, 20);
            this.hudWidth.TabIndex = 3;
            this.hudWidth.Text = "Width = 30";
            // 
            // hudHeight
            // 
            this.hudHeight.AutoSize = true;
            this.hudHeight.BackColor = System.Drawing.Color.Transparent;
            this.hudHeight.CausesValidation = false;
            this.hudHeight.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hudHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hudHeight.Location = new System.Drawing.Point(0, 534);
            this.hudHeight.Name = "hudHeight";
            this.hudHeight.Size = new System.Drawing.Size(102, 20);
            this.hudHeight.TabIndex = 2;
            this.hudHeight.Text = "Height = 30";
            // 
            // hudCellCount
            // 
            this.hudCellCount.AutoSize = true;
            this.hudCellCount.BackColor = System.Drawing.Color.Transparent;
            this.hudCellCount.CausesValidation = false;
            this.hudCellCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hudCellCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hudCellCount.Location = new System.Drawing.Point(0, 554);
            this.hudCellCount.Name = "hudCellCount";
            this.hudCellCount.Size = new System.Drawing.Size(122, 20);
            this.hudCellCount.TabIndex = 1;
            this.hudCellCount.Text = "Cell Count = 0";
            // 
            // hudGenerations
            // 
            this.hudGenerations.AutoSize = true;
            this.hudGenerations.BackColor = System.Drawing.Color.Transparent;
            this.hudGenerations.CausesValidation = false;
            this.hudGenerations.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hudGenerations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hudGenerations.Location = new System.Drawing.Point(0, 574);
            this.hudGenerations.Name = "hudGenerations";
            this.hudGenerations.Size = new System.Drawing.Size(138, 20);
            this.hudGenerations.TabIndex = 0;
            this.hudGenerations.Text = "Generations = 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 665);
            this.Controls.Add(this.graphicsPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.graphicsPanel1.ResumeLayout(false);
            this.graphicsPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private GraphicsPanel graphicsPanel1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem open;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton newButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelGenerations;
        private System.Windows.Forms.ToolStripButton PlayButton;
        private System.Windows.Forms.ToolStripButton PauseButton;
        private System.Windows.Forms.ToolStripButton NextButton;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cellColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridColorToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backgroundColorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cellColorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gridColorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toroidalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toroidalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem finiteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem seedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomSeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sizeAndTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showNeighborCountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridOnOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hudOnOff;
        private System.Windows.Forms.ToolStripMenuItem reload;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLiveCells;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMode;
        private System.Windows.Forms.Label hudMode;
        private System.Windows.Forms.Label hudWidth;
        private System.Windows.Forms.Label hudHeight;
        private System.Windows.Forms.Label hudCellCount;
        private System.Windows.Forms.Label hudGenerations;
    }
}

