
namespace GomokuGUI
{
    partial class Gomoku
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editGameParametersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelMenu = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxGameMode = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelGameMode = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonBvsB = new System.Windows.Forms.RadioButton();
            this.radioButtonBvsP = new System.Windows.Forms.RadioButton();
            this.radioButtonPvsP = new System.Windows.Forms.RadioButton();
            this.buttonStart = new System.Windows.Forms.Button();
            this.groupBoxBotsSettings = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelBotsSettings = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxBot2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelBot2 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonBot2GreedyHeuristics = new System.Windows.Forms.RadioButton();
            this.radioButtonBot2MCTSUCB1withHeuristics = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanelBot2Iterations = new System.Windows.Forms.TableLayoutPanel();
            this.labelBot2Iterations = new System.Windows.Forms.Label();
            this.labelBot2IterationsNumber = new System.Windows.Forms.Label();
            this.trackBarBot2 = new System.Windows.Forms.TrackBar();
            this.labelBot2SelectAlgorithm = new System.Windows.Forms.Label();
            this.radioButtonBot2MCTSClassic = new System.Windows.Forms.RadioButton();
            this.radioButtonBot2MCTSUCB1Tuned = new System.Windows.Forms.RadioButton();
            this.groupBoxBot1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelBot1 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonBot1GreedyHeuristics = new System.Windows.Forms.RadioButton();
            this.radioButtonBot1MCTSUCB1withHeuristics = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanelBot1Iterations = new System.Windows.Forms.TableLayoutPanel();
            this.labelBot1Iterations = new System.Windows.Forms.Label();
            this.labelBot1IterationsNumber = new System.Windows.Forms.Label();
            this.trackBarBot1 = new System.Windows.Forms.TrackBar();
            this.labelBot1SelectAlgorithm = new System.Windows.Forms.Label();
            this.radioButtonBot1MCTSClassic = new System.Windows.Forms.RadioButton();
            this.radioButtonBot1MCTSUCB1Tuned = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tableLayoutPanelMenu.SuspendLayout();
            this.groupBoxGameMode.SuspendLayout();
            this.tableLayoutPanelGameMode.SuspendLayout();
            this.groupBoxBotsSettings.SuspendLayout();
            this.tableLayoutPanelBotsSettings.SuspendLayout();
            this.groupBoxBot2.SuspendLayout();
            this.tableLayoutPanelBot2.SuspendLayout();
            this.tableLayoutPanelBot2Iterations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBot2)).BeginInit();
            this.groupBoxBot1.SuspendLayout();
            this.tableLayoutPanelBot1.SuspendLayout();
            this.tableLayoutPanelBot1Iterations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBot1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.menuStrip, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanelMain, 0, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(938, 749);
            this.tableLayoutPanel.TabIndex = 2;
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(938, 30);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editGameParametersToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 26);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // editGameParametersToolStripMenuItem
            // 
            this.editGameParametersToolStripMenuItem.Name = "editGameParametersToolStripMenuItem";
            this.editGameParametersToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.editGameParametersToolStripMenuItem.Text = "Edit game parameters";
            this.editGameParametersToolStripMenuItem.Click += new System.EventHandler(this.EditGameParametersToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanelMain.Controls.Add(this.pictureBox, 1, 0);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelMenu, 0, 0);
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(3, 33);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 1;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(932, 713);
            this.tableLayoutPanelMain.TabIndex = 3;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(236, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(693, 707);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // tableLayoutPanelMenu
            // 
            this.tableLayoutPanelMenu.ColumnCount = 1;
            this.tableLayoutPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMenu.Controls.Add(this.groupBoxGameMode, 0, 0);
            this.tableLayoutPanelMenu.Controls.Add(this.buttonStart, 0, 2);
            this.tableLayoutPanelMenu.Controls.Add(this.groupBoxBotsSettings, 0, 1);
            this.tableLayoutPanelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMenu.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelMenu.Name = "tableLayoutPanelMenu";
            this.tableLayoutPanelMenu.RowCount = 3;
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMenu.Size = new System.Drawing.Size(227, 707);
            this.tableLayoutPanelMenu.TabIndex = 1;
            // 
            // groupBoxGameMode
            // 
            this.groupBoxGameMode.Controls.Add(this.tableLayoutPanelGameMode);
            this.groupBoxGameMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxGameMode.Location = new System.Drawing.Point(3, 3);
            this.groupBoxGameMode.Name = "groupBoxGameMode";
            this.groupBoxGameMode.Size = new System.Drawing.Size(221, 135);
            this.groupBoxGameMode.TabIndex = 0;
            this.groupBoxGameMode.TabStop = false;
            this.groupBoxGameMode.Text = "Game Mode";
            // 
            // tableLayoutPanelGameMode
            // 
            this.tableLayoutPanelGameMode.ColumnCount = 1;
            this.tableLayoutPanelGameMode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelGameMode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelGameMode.Controls.Add(this.radioButtonBvsB, 0, 0);
            this.tableLayoutPanelGameMode.Controls.Add(this.radioButtonBvsP, 0, 1);
            this.tableLayoutPanelGameMode.Controls.Add(this.radioButtonPvsP, 0, 2);
            this.tableLayoutPanelGameMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelGameMode.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanelGameMode.Name = "tableLayoutPanelGameMode";
            this.tableLayoutPanelGameMode.RowCount = 3;
            this.tableLayoutPanelGameMode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelGameMode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelGameMode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelGameMode.Size = new System.Drawing.Size(215, 109);
            this.tableLayoutPanelGameMode.TabIndex = 0;
            // 
            // radioButtonBvsB
            // 
            this.radioButtonBvsB.AutoSize = true;
            this.radioButtonBvsB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonBvsB.Location = new System.Drawing.Point(3, 3);
            this.radioButtonBvsB.Name = "radioButtonBvsB";
            this.radioButtonBvsB.Size = new System.Drawing.Size(209, 30);
            this.radioButtonBvsB.TabIndex = 0;
            this.radioButtonBvsB.Text = "Bot vs. Bot";
            this.radioButtonBvsB.UseVisualStyleBackColor = true;
            this.radioButtonBvsB.CheckedChanged += new System.EventHandler(this.RadioButtonBvsB_CheckedChanged);
            // 
            // radioButtonBvsP
            // 
            this.radioButtonBvsP.AutoSize = true;
            this.radioButtonBvsP.Checked = true;
            this.radioButtonBvsP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonBvsP.Location = new System.Drawing.Point(3, 39);
            this.radioButtonBvsP.Name = "radioButtonBvsP";
            this.radioButtonBvsP.Size = new System.Drawing.Size(209, 30);
            this.radioButtonBvsP.TabIndex = 1;
            this.radioButtonBvsP.TabStop = true;
            this.radioButtonBvsP.Text = "Bot vs. Player";
            this.radioButtonBvsP.UseVisualStyleBackColor = true;
            this.radioButtonBvsP.CheckedChanged += new System.EventHandler(this.RadioButtonBvsP_CheckedChanged);
            // 
            // radioButtonPvsP
            // 
            this.radioButtonPvsP.AutoSize = true;
            this.radioButtonPvsP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonPvsP.Location = new System.Drawing.Point(3, 75);
            this.radioButtonPvsP.Name = "radioButtonPvsP";
            this.radioButtonPvsP.Size = new System.Drawing.Size(209, 31);
            this.radioButtonPvsP.TabIndex = 2;
            this.radioButtonPvsP.Text = "Player vs. Player";
            this.radioButtonPvsP.UseVisualStyleBackColor = true;
            this.radioButtonPvsP.CheckedChanged += new System.EventHandler(this.RadioButtonPvsP_CheckedChanged);
            // 
            // buttonStart
            // 
            this.buttonStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStart.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonStart.Location = new System.Drawing.Point(3, 638);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(221, 66);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // groupBoxBotsSettings
            // 
            this.groupBoxBotsSettings.Controls.Add(this.tableLayoutPanelBotsSettings);
            this.groupBoxBotsSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxBotsSettings.Location = new System.Drawing.Point(3, 144);
            this.groupBoxBotsSettings.Name = "groupBoxBotsSettings";
            this.groupBoxBotsSettings.Size = new System.Drawing.Size(221, 488);
            this.groupBoxBotsSettings.TabIndex = 3;
            this.groupBoxBotsSettings.TabStop = false;
            this.groupBoxBotsSettings.Text = "Bots settings";
            // 
            // tableLayoutPanelBotsSettings
            // 
            this.tableLayoutPanelBotsSettings.ColumnCount = 1;
            this.tableLayoutPanelBotsSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBotsSettings.Controls.Add(this.groupBoxBot2, 0, 1);
            this.tableLayoutPanelBotsSettings.Controls.Add(this.groupBoxBot1, 0, 0);
            this.tableLayoutPanelBotsSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBotsSettings.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanelBotsSettings.Name = "tableLayoutPanelBotsSettings";
            this.tableLayoutPanelBotsSettings.RowCount = 2;
            this.tableLayoutPanelBotsSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBotsSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBotsSettings.Size = new System.Drawing.Size(215, 462);
            this.tableLayoutPanelBotsSettings.TabIndex = 0;
            // 
            // groupBoxBot2
            // 
            this.groupBoxBot2.Controls.Add(this.tableLayoutPanelBot2);
            this.groupBoxBot2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxBot2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxBot2.Location = new System.Drawing.Point(3, 234);
            this.groupBoxBot2.Name = "groupBoxBot2";
            this.groupBoxBot2.Size = new System.Drawing.Size(209, 225);
            this.groupBoxBot2.TabIndex = 1;
            this.groupBoxBot2.TabStop = false;
            this.groupBoxBot2.Text = "Bot Peter";
            // 
            // tableLayoutPanelBot2
            // 
            this.tableLayoutPanelBot2.ColumnCount = 1;
            this.tableLayoutPanelBot2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBot2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelBot2.Controls.Add(this.radioButtonBot2GreedyHeuristics, 0, 6);
            this.tableLayoutPanelBot2.Controls.Add(this.radioButtonBot2MCTSUCB1withHeuristics, 0, 5);
            this.tableLayoutPanelBot2.Controls.Add(this.tableLayoutPanelBot2Iterations, 0, 0);
            this.tableLayoutPanelBot2.Controls.Add(this.trackBarBot2, 0, 1);
            this.tableLayoutPanelBot2.Controls.Add(this.labelBot2SelectAlgorithm, 0, 2);
            this.tableLayoutPanelBot2.Controls.Add(this.radioButtonBot2MCTSClassic, 0, 3);
            this.tableLayoutPanelBot2.Controls.Add(this.radioButtonBot2MCTSUCB1Tuned, 0, 4);
            this.tableLayoutPanelBot2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBot2.Location = new System.Drawing.Point(3, 21);
            this.tableLayoutPanelBot2.Name = "tableLayoutPanelBot2";
            this.tableLayoutPanelBot2.RowCount = 7;
            this.tableLayoutPanelBot2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelBot2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelBot2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelBot2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelBot2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelBot2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelBot2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelBot2.Size = new System.Drawing.Size(203, 201);
            this.tableLayoutPanelBot2.TabIndex = 0;
            // 
            // radioButtonBot2GreedyHeuristics
            // 
            this.radioButtonBot2GreedyHeuristics.AutoSize = true;
            this.radioButtonBot2GreedyHeuristics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonBot2GreedyHeuristics.Location = new System.Drawing.Point(3, 171);
            this.radioButtonBot2GreedyHeuristics.Name = "radioButtonBot2GreedyHeuristics";
            this.radioButtonBot2GreedyHeuristics.Size = new System.Drawing.Size(197, 27);
            this.radioButtonBot2GreedyHeuristics.TabIndex = 6;
            this.radioButtonBot2GreedyHeuristics.Text = "Greedy heuristics";
            this.radioButtonBot2GreedyHeuristics.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonBot2GreedyHeuristics.UseVisualStyleBackColor = true;
            // 
            // radioButtonBot2MCTSUCB1withHeuristics
            // 
            this.radioButtonBot2MCTSUCB1withHeuristics.AutoSize = true;
            this.radioButtonBot2MCTSUCB1withHeuristics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonBot2MCTSUCB1withHeuristics.Location = new System.Drawing.Point(3, 143);
            this.radioButtonBot2MCTSUCB1withHeuristics.Name = "radioButtonBot2MCTSUCB1withHeuristics";
            this.radioButtonBot2MCTSUCB1withHeuristics.Size = new System.Drawing.Size(197, 22);
            this.radioButtonBot2MCTSUCB1withHeuristics.TabIndex = 5;
            this.radioButtonBot2MCTSUCB1withHeuristics.Text = "MCTS UCB1 with heuristics";
            this.radioButtonBot2MCTSUCB1withHeuristics.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonBot2MCTSUCB1withHeuristics.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelBot2Iterations
            // 
            this.tableLayoutPanelBot2Iterations.ColumnCount = 2;
            this.tableLayoutPanelBot2Iterations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanelBot2Iterations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanelBot2Iterations.Controls.Add(this.labelBot2Iterations, 0, 0);
            this.tableLayoutPanelBot2Iterations.Controls.Add(this.labelBot2IterationsNumber, 1, 0);
            this.tableLayoutPanelBot2Iterations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBot2Iterations.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelBot2Iterations.Name = "tableLayoutPanelBot2Iterations";
            this.tableLayoutPanelBot2Iterations.RowCount = 1;
            this.tableLayoutPanelBot2Iterations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBot2Iterations.Size = new System.Drawing.Size(197, 22);
            this.tableLayoutPanelBot2Iterations.TabIndex = 0;
            // 
            // labelBot2Iterations
            // 
            this.labelBot2Iterations.AutoSize = true;
            this.labelBot2Iterations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBot2Iterations.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBot2Iterations.Location = new System.Drawing.Point(3, 0);
            this.labelBot2Iterations.Name = "labelBot2Iterations";
            this.labelBot2Iterations.Size = new System.Drawing.Size(122, 22);
            this.labelBot2Iterations.TabIndex = 0;
            this.labelBot2Iterations.Text = "Iterations:";
            this.labelBot2Iterations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBot2IterationsNumber
            // 
            this.labelBot2IterationsNumber.AutoSize = true;
            this.labelBot2IterationsNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBot2IterationsNumber.Location = new System.Drawing.Point(131, 0);
            this.labelBot2IterationsNumber.Name = "labelBot2IterationsNumber";
            this.labelBot2IterationsNumber.Size = new System.Drawing.Size(63, 22);
            this.labelBot2IterationsNumber.TabIndex = 1;
            this.labelBot2IterationsNumber.Text = "1500";
            this.labelBot2IterationsNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarBot2
            // 
            this.trackBarBot2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarBot2.Location = new System.Drawing.Point(3, 31);
            this.trackBarBot2.Maximum = 4500;
            this.trackBarBot2.Minimum = 500;
            this.trackBarBot2.Name = "trackBarBot2";
            this.trackBarBot2.Size = new System.Drawing.Size(197, 22);
            this.trackBarBot2.TabIndex = 1;
            this.trackBarBot2.TickFrequency = 100;
            this.trackBarBot2.Value = 1500;
            this.trackBarBot2.ValueChanged += new System.EventHandler(this.TrackBarBot2_ValueChanged);
            // 
            // labelBot2SelectAlgorithm
            // 
            this.labelBot2SelectAlgorithm.AutoSize = true;
            this.labelBot2SelectAlgorithm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBot2SelectAlgorithm.Location = new System.Drawing.Point(3, 56);
            this.labelBot2SelectAlgorithm.Name = "labelBot2SelectAlgorithm";
            this.labelBot2SelectAlgorithm.Size = new System.Drawing.Size(197, 28);
            this.labelBot2SelectAlgorithm.TabIndex = 2;
            this.labelBot2SelectAlgorithm.Text = "Select algorithm:";
            this.labelBot2SelectAlgorithm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radioButtonBot2MCTSClassic
            // 
            this.radioButtonBot2MCTSClassic.AutoSize = true;
            this.radioButtonBot2MCTSClassic.Checked = true;
            this.radioButtonBot2MCTSClassic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonBot2MCTSClassic.Location = new System.Drawing.Point(3, 87);
            this.radioButtonBot2MCTSClassic.Name = "radioButtonBot2MCTSClassic";
            this.radioButtonBot2MCTSClassic.Size = new System.Drawing.Size(197, 22);
            this.radioButtonBot2MCTSClassic.TabIndex = 3;
            this.radioButtonBot2MCTSClassic.TabStop = true;
            this.radioButtonBot2MCTSClassic.Text = "MCTS classic";
            this.radioButtonBot2MCTSClassic.UseVisualStyleBackColor = true;
            // 
            // radioButtonBot2MCTSUCB1Tuned
            // 
            this.radioButtonBot2MCTSUCB1Tuned.AutoSize = true;
            this.radioButtonBot2MCTSUCB1Tuned.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonBot2MCTSUCB1Tuned.Location = new System.Drawing.Point(3, 115);
            this.radioButtonBot2MCTSUCB1Tuned.Name = "radioButtonBot2MCTSUCB1Tuned";
            this.radioButtonBot2MCTSUCB1Tuned.Size = new System.Drawing.Size(197, 22);
            this.radioButtonBot2MCTSUCB1Tuned.TabIndex = 4;
            this.radioButtonBot2MCTSUCB1Tuned.Text = "MCTS UCB1-Tuned";
            this.radioButtonBot2MCTSUCB1Tuned.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonBot2MCTSUCB1Tuned.UseVisualStyleBackColor = true;
            // 
            // groupBoxBot1
            // 
            this.groupBoxBot1.Controls.Add(this.tableLayoutPanelBot1);
            this.groupBoxBot1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxBot1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxBot1.Location = new System.Drawing.Point(3, 3);
            this.groupBoxBot1.Name = "groupBoxBot1";
            this.groupBoxBot1.Size = new System.Drawing.Size(209, 225);
            this.groupBoxBot1.TabIndex = 0;
            this.groupBoxBot1.TabStop = false;
            this.groupBoxBot1.Text = "Bot Adam";
            // 
            // tableLayoutPanelBot1
            // 
            this.tableLayoutPanelBot1.ColumnCount = 1;
            this.tableLayoutPanelBot1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBot1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelBot1.Controls.Add(this.radioButtonBot1GreedyHeuristics, 0, 6);
            this.tableLayoutPanelBot1.Controls.Add(this.radioButtonBot1MCTSUCB1withHeuristics, 0, 5);
            this.tableLayoutPanelBot1.Controls.Add(this.tableLayoutPanelBot1Iterations, 0, 0);
            this.tableLayoutPanelBot1.Controls.Add(this.trackBarBot1, 0, 1);
            this.tableLayoutPanelBot1.Controls.Add(this.labelBot1SelectAlgorithm, 0, 2);
            this.tableLayoutPanelBot1.Controls.Add(this.radioButtonBot1MCTSClassic, 0, 3);
            this.tableLayoutPanelBot1.Controls.Add(this.radioButtonBot1MCTSUCB1Tuned, 0, 4);
            this.tableLayoutPanelBot1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBot1.Location = new System.Drawing.Point(3, 21);
            this.tableLayoutPanelBot1.Name = "tableLayoutPanelBot1";
            this.tableLayoutPanelBot1.RowCount = 7;
            this.tableLayoutPanelBot1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelBot1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelBot1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelBot1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelBot1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelBot1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelBot1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelBot1.Size = new System.Drawing.Size(203, 201);
            this.tableLayoutPanelBot1.TabIndex = 0;
            // 
            // radioButtonBot1GreedyHeuristics
            // 
            this.radioButtonBot1GreedyHeuristics.AutoSize = true;
            this.radioButtonBot1GreedyHeuristics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonBot1GreedyHeuristics.Location = new System.Drawing.Point(3, 171);
            this.radioButtonBot1GreedyHeuristics.Name = "radioButtonBot1GreedyHeuristics";
            this.radioButtonBot1GreedyHeuristics.Size = new System.Drawing.Size(197, 27);
            this.radioButtonBot1GreedyHeuristics.TabIndex = 6;
            this.radioButtonBot1GreedyHeuristics.Text = "Greedy heuristics";
            this.radioButtonBot1GreedyHeuristics.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonBot1GreedyHeuristics.UseVisualStyleBackColor = true;
            // 
            // radioButtonBot1MCTSUCB1withHeuristics
            // 
            this.radioButtonBot1MCTSUCB1withHeuristics.AutoSize = true;
            this.radioButtonBot1MCTSUCB1withHeuristics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonBot1MCTSUCB1withHeuristics.Location = new System.Drawing.Point(3, 143);
            this.radioButtonBot1MCTSUCB1withHeuristics.Name = "radioButtonBot1MCTSUCB1withHeuristics";
            this.radioButtonBot1MCTSUCB1withHeuristics.Size = new System.Drawing.Size(197, 22);
            this.radioButtonBot1MCTSUCB1withHeuristics.TabIndex = 5;
            this.radioButtonBot1MCTSUCB1withHeuristics.Text = "MCTS UCB1 with heuristics";
            this.radioButtonBot1MCTSUCB1withHeuristics.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonBot1MCTSUCB1withHeuristics.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelBot1Iterations
            // 
            this.tableLayoutPanelBot1Iterations.ColumnCount = 2;
            this.tableLayoutPanelBot1Iterations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanelBot1Iterations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanelBot1Iterations.Controls.Add(this.labelBot1Iterations, 0, 0);
            this.tableLayoutPanelBot1Iterations.Controls.Add(this.labelBot1IterationsNumber, 1, 0);
            this.tableLayoutPanelBot1Iterations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBot1Iterations.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelBot1Iterations.Name = "tableLayoutPanelBot1Iterations";
            this.tableLayoutPanelBot1Iterations.RowCount = 1;
            this.tableLayoutPanelBot1Iterations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBot1Iterations.Size = new System.Drawing.Size(197, 22);
            this.tableLayoutPanelBot1Iterations.TabIndex = 0;
            // 
            // labelBot1Iterations
            // 
            this.labelBot1Iterations.AutoSize = true;
            this.labelBot1Iterations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBot1Iterations.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBot1Iterations.Location = new System.Drawing.Point(3, 0);
            this.labelBot1Iterations.Name = "labelBot1Iterations";
            this.labelBot1Iterations.Size = new System.Drawing.Size(122, 22);
            this.labelBot1Iterations.TabIndex = 0;
            this.labelBot1Iterations.Text = "Iterations:";
            this.labelBot1Iterations.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBot1IterationsNumber
            // 
            this.labelBot1IterationsNumber.AutoSize = true;
            this.labelBot1IterationsNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBot1IterationsNumber.Location = new System.Drawing.Point(131, 0);
            this.labelBot1IterationsNumber.Name = "labelBot1IterationsNumber";
            this.labelBot1IterationsNumber.Size = new System.Drawing.Size(63, 22);
            this.labelBot1IterationsNumber.TabIndex = 1;
            this.labelBot1IterationsNumber.Text = "1500";
            this.labelBot1IterationsNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarBot1
            // 
            this.trackBarBot1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarBot1.Location = new System.Drawing.Point(3, 31);
            this.trackBarBot1.Maximum = 4500;
            this.trackBarBot1.Minimum = 500;
            this.trackBarBot1.Name = "trackBarBot1";
            this.trackBarBot1.Size = new System.Drawing.Size(197, 22);
            this.trackBarBot1.TabIndex = 1;
            this.trackBarBot1.TickFrequency = 100;
            this.trackBarBot1.Value = 1500;
            this.trackBarBot1.ValueChanged += new System.EventHandler(this.TrackBarBot1_ValueChanged);
            // 
            // labelBot1SelectAlgorithm
            // 
            this.labelBot1SelectAlgorithm.AutoSize = true;
            this.labelBot1SelectAlgorithm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBot1SelectAlgorithm.Location = new System.Drawing.Point(3, 56);
            this.labelBot1SelectAlgorithm.Name = "labelBot1SelectAlgorithm";
            this.labelBot1SelectAlgorithm.Size = new System.Drawing.Size(197, 28);
            this.labelBot1SelectAlgorithm.TabIndex = 2;
            this.labelBot1SelectAlgorithm.Text = "Select algorithm:";
            this.labelBot1SelectAlgorithm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radioButtonBot1MCTSClassic
            // 
            this.radioButtonBot1MCTSClassic.AutoSize = true;
            this.radioButtonBot1MCTSClassic.Checked = true;
            this.radioButtonBot1MCTSClassic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonBot1MCTSClassic.Location = new System.Drawing.Point(3, 87);
            this.radioButtonBot1MCTSClassic.Name = "radioButtonBot1MCTSClassic";
            this.radioButtonBot1MCTSClassic.Size = new System.Drawing.Size(197, 22);
            this.radioButtonBot1MCTSClassic.TabIndex = 3;
            this.radioButtonBot1MCTSClassic.TabStop = true;
            this.radioButtonBot1MCTSClassic.Text = "MCTS classic";
            this.radioButtonBot1MCTSClassic.UseVisualStyleBackColor = true;
            // 
            // radioButtonBot1MCTSUCB1Tuned
            // 
            this.radioButtonBot1MCTSUCB1Tuned.AutoSize = true;
            this.radioButtonBot1MCTSUCB1Tuned.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonBot1MCTSUCB1Tuned.Location = new System.Drawing.Point(3, 115);
            this.radioButtonBot1MCTSUCB1Tuned.Name = "radioButtonBot1MCTSUCB1Tuned";
            this.radioButtonBot1MCTSUCB1Tuned.Size = new System.Drawing.Size(197, 22);
            this.radioButtonBot1MCTSUCB1Tuned.TabIndex = 4;
            this.radioButtonBot1MCTSUCB1Tuned.Text = "MCTS UCB1-Tuned";
            this.radioButtonBot1MCTSUCB1Tuned.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButtonBot1MCTSUCB1Tuned.UseVisualStyleBackColor = true;
            // 
            // Gomoku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 749);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "Gomoku";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gomoku";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tableLayoutPanelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tableLayoutPanelMenu.ResumeLayout(false);
            this.groupBoxGameMode.ResumeLayout(false);
            this.tableLayoutPanelGameMode.ResumeLayout(false);
            this.tableLayoutPanelGameMode.PerformLayout();
            this.groupBoxBotsSettings.ResumeLayout(false);
            this.tableLayoutPanelBotsSettings.ResumeLayout(false);
            this.groupBoxBot2.ResumeLayout(false);
            this.tableLayoutPanelBot2.ResumeLayout(false);
            this.tableLayoutPanelBot2.PerformLayout();
            this.tableLayoutPanelBot2Iterations.ResumeLayout(false);
            this.tableLayoutPanelBot2Iterations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBot2)).EndInit();
            this.groupBoxBot1.ResumeLayout(false);
            this.tableLayoutPanelBot1.ResumeLayout(false);
            this.tableLayoutPanelBot1.PerformLayout();
            this.tableLayoutPanelBot1Iterations.ResumeLayout(false);
            this.tableLayoutPanelBot1Iterations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBot1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMenu;
        private System.Windows.Forms.GroupBox groupBoxGameMode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelGameMode;
        private System.Windows.Forms.RadioButton radioButtonBvsB;
        private System.Windows.Forms.RadioButton radioButtonBvsP;
        private System.Windows.Forms.RadioButton radioButtonPvsP;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.GroupBox groupBoxBotsSettings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBotsSettings;
        private System.Windows.Forms.GroupBox groupBoxBot2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBot2;
        private System.Windows.Forms.RadioButton radioButtonBot2GreedyHeuristics;
        private System.Windows.Forms.RadioButton radioButtonBot2MCTSUCB1withHeuristics;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBot2Iterations;
        private System.Windows.Forms.Label labelBot2Iterations;
        private System.Windows.Forms.Label labelBot2IterationsNumber;
        private System.Windows.Forms.TrackBar trackBarBot2;
        private System.Windows.Forms.Label labelBot2SelectAlgorithm;
        private System.Windows.Forms.RadioButton radioButtonBot2MCTSClassic;
        private System.Windows.Forms.RadioButton radioButtonBot2MCTSUCB1Tuned;
        private System.Windows.Forms.GroupBox groupBoxBot1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBot1;
        private System.Windows.Forms.RadioButton radioButtonBot1GreedyHeuristics;
        private System.Windows.Forms.RadioButton radioButtonBot1MCTSUCB1withHeuristics;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBot1Iterations;
        private System.Windows.Forms.Label labelBot1Iterations;
        private System.Windows.Forms.Label labelBot1IterationsNumber;
        private System.Windows.Forms.TrackBar trackBarBot1;
        private System.Windows.Forms.Label labelBot1SelectAlgorithm;
        private System.Windows.Forms.RadioButton radioButtonBot1MCTSClassic;
        private System.Windows.Forms.RadioButton radioButtonBot1MCTSUCB1Tuned;
        private System.Windows.Forms.ToolStripMenuItem editGameParametersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}

