
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
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelMenu = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxGameMode = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelGameMode = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonBvsB = new System.Windows.Forms.RadioButton();
            this.radioButtonBvsP = new System.Windows.Forms.RadioButton();
            this.radioButtonPvsP = new System.Windows.Forms.RadioButton();
            this.groupBoxMCTSBotsIterations = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelMCTSBotsIterations = new System.Windows.Forms.TableLayoutPanel();
            this.trackBarBot1 = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanelBot1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelBot1 = new System.Windows.Forms.Label();
            this.labelBot1Iterations = new System.Windows.Forms.Label();
            this.tableLayoutPanelBot2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelBot2 = new System.Windows.Forms.Label();
            this.labelBot2Iterations = new System.Windows.Forms.Label();
            this.trackBarBot2 = new System.Windows.Forms.TrackBar();
            this.buttonStart = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tableLayoutPanelMenu.SuspendLayout();
            this.groupBoxGameMode.SuspendLayout();
            this.tableLayoutPanelGameMode.SuspendLayout();
            this.groupBoxMCTSBotsIterations.SuspendLayout();
            this.tableLayoutPanelMCTSBotsIterations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBot1)).BeginInit();
            this.tableLayoutPanelBot1.SuspendLayout();
            this.tableLayoutPanelBot2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBot2)).BeginInit();
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
            this.closeToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 26);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
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
            this.pictureBox.Location = new System.Drawing.Point(189, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(740, 707);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // tableLayoutPanelMenu
            // 
            this.tableLayoutPanelMenu.ColumnCount = 1;
            this.tableLayoutPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMenu.Controls.Add(this.groupBoxGameMode, 0, 0);
            this.tableLayoutPanelMenu.Controls.Add(this.groupBoxMCTSBotsIterations, 0, 1);
            this.tableLayoutPanelMenu.Controls.Add(this.buttonStart, 0, 2);
            this.tableLayoutPanelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMenu.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelMenu.Name = "tableLayoutPanelMenu";
            this.tableLayoutPanelMenu.RowCount = 4;
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanelMenu.Size = new System.Drawing.Size(180, 707);
            this.tableLayoutPanelMenu.TabIndex = 1;
            // 
            // groupBoxGameMode
            // 
            this.groupBoxGameMode.Controls.Add(this.tableLayoutPanelGameMode);
            this.groupBoxGameMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxGameMode.Location = new System.Drawing.Point(3, 3);
            this.groupBoxGameMode.Name = "groupBoxGameMode";
            this.groupBoxGameMode.Size = new System.Drawing.Size(174, 206);
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
            this.tableLayoutPanelGameMode.Size = new System.Drawing.Size(168, 180);
            this.tableLayoutPanelGameMode.TabIndex = 0;
            // 
            // radioButtonBvsB
            // 
            this.radioButtonBvsB.AutoSize = true;
            this.radioButtonBvsB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonBvsB.Location = new System.Drawing.Point(3, 3);
            this.radioButtonBvsB.Name = "radioButtonBvsB";
            this.radioButtonBvsB.Size = new System.Drawing.Size(162, 54);
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
            this.radioButtonBvsP.Location = new System.Drawing.Point(3, 63);
            this.radioButtonBvsP.Name = "radioButtonBvsP";
            this.radioButtonBvsP.Size = new System.Drawing.Size(162, 54);
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
            this.radioButtonPvsP.Location = new System.Drawing.Point(3, 123);
            this.radioButtonPvsP.Name = "radioButtonPvsP";
            this.radioButtonPvsP.Size = new System.Drawing.Size(162, 54);
            this.radioButtonPvsP.TabIndex = 2;
            this.radioButtonPvsP.Text = "Player vs. Player";
            this.radioButtonPvsP.UseVisualStyleBackColor = true;
            this.radioButtonPvsP.CheckedChanged += new System.EventHandler(this.RadioButtonPvsP_CheckedChanged);
            // 
            // groupBoxMCTSBotsIterations
            // 
            this.groupBoxMCTSBotsIterations.Controls.Add(this.tableLayoutPanelMCTSBotsIterations);
            this.groupBoxMCTSBotsIterations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxMCTSBotsIterations.Location = new System.Drawing.Point(3, 215);
            this.groupBoxMCTSBotsIterations.Name = "groupBoxMCTSBotsIterations";
            this.groupBoxMCTSBotsIterations.Size = new System.Drawing.Size(174, 170);
            this.groupBoxMCTSBotsIterations.TabIndex = 1;
            this.groupBoxMCTSBotsIterations.TabStop = false;
            this.groupBoxMCTSBotsIterations.Text = "MCTS Bots Iterations";
            // 
            // tableLayoutPanelMCTSBotsIterations
            // 
            this.tableLayoutPanelMCTSBotsIterations.ColumnCount = 1;
            this.tableLayoutPanelMCTSBotsIterations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMCTSBotsIterations.Controls.Add(this.trackBarBot1, 0, 1);
            this.tableLayoutPanelMCTSBotsIterations.Controls.Add(this.tableLayoutPanelBot1, 0, 0);
            this.tableLayoutPanelMCTSBotsIterations.Controls.Add(this.tableLayoutPanelBot2, 0, 2);
            this.tableLayoutPanelMCTSBotsIterations.Controls.Add(this.trackBarBot2, 0, 3);
            this.tableLayoutPanelMCTSBotsIterations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMCTSBotsIterations.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanelMCTSBotsIterations.Name = "tableLayoutPanelMCTSBotsIterations";
            this.tableLayoutPanelMCTSBotsIterations.RowCount = 4;
            this.tableLayoutPanelMCTSBotsIterations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMCTSBotsIterations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelMCTSBotsIterations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelMCTSBotsIterations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelMCTSBotsIterations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMCTSBotsIterations.Size = new System.Drawing.Size(168, 144);
            this.tableLayoutPanelMCTSBotsIterations.TabIndex = 0;
            // 
            // trackBarBot1
            // 
            this.trackBarBot1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarBot1.LargeChange = 50;
            this.trackBarBot1.Location = new System.Drawing.Point(3, 31);
            this.trackBarBot1.Maximum = 1000;
            this.trackBarBot1.Minimum = 100;
            this.trackBarBot1.Name = "trackBarBot1";
            this.trackBarBot1.Size = new System.Drawing.Size(162, 37);
            this.trackBarBot1.SmallChange = 50;
            this.trackBarBot1.TabIndex = 1;
            this.trackBarBot1.TickFrequency = 25;
            this.trackBarBot1.Value = 250;
            this.trackBarBot1.ValueChanged += new System.EventHandler(this.TrackBarBot1_ValueChanged);
            // 
            // tableLayoutPanelBot1
            // 
            this.tableLayoutPanelBot1.ColumnCount = 2;
            this.tableLayoutPanelBot1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBot1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBot1.Controls.Add(this.labelBot1, 0, 0);
            this.tableLayoutPanelBot1.Controls.Add(this.labelBot1Iterations, 1, 0);
            this.tableLayoutPanelBot1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBot1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelBot1.Name = "tableLayoutPanelBot1";
            this.tableLayoutPanelBot1.RowCount = 1;
            this.tableLayoutPanelBot1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBot1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanelBot1.Size = new System.Drawing.Size(162, 22);
            this.tableLayoutPanelBot1.TabIndex = 3;
            // 
            // labelBot1
            // 
            this.labelBot1.AutoSize = true;
            this.labelBot1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBot1.Location = new System.Drawing.Point(3, 0);
            this.labelBot1.Name = "labelBot1";
            this.labelBot1.Size = new System.Drawing.Size(75, 22);
            this.labelBot1.TabIndex = 0;
            this.labelBot1.Text = "Bot 1:";
            // 
            // labelBot1Iterations
            // 
            this.labelBot1Iterations.AutoSize = true;
            this.labelBot1Iterations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBot1Iterations.Location = new System.Drawing.Point(84, 0);
            this.labelBot1Iterations.Name = "labelBot1Iterations";
            this.labelBot1Iterations.Size = new System.Drawing.Size(75, 22);
            this.labelBot1Iterations.TabIndex = 1;
            this.labelBot1Iterations.Text = "250";
            // 
            // tableLayoutPanelBot2
            // 
            this.tableLayoutPanelBot2.ColumnCount = 2;
            this.tableLayoutPanelBot2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBot2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBot2.Controls.Add(this.labelBot2, 0, 0);
            this.tableLayoutPanelBot2.Controls.Add(this.labelBot2Iterations, 1, 0);
            this.tableLayoutPanelBot2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBot2.Location = new System.Drawing.Point(3, 74);
            this.tableLayoutPanelBot2.Name = "tableLayoutPanelBot2";
            this.tableLayoutPanelBot2.RowCount = 1;
            this.tableLayoutPanelBot2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBot2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanelBot2.Size = new System.Drawing.Size(162, 22);
            this.tableLayoutPanelBot2.TabIndex = 4;
            // 
            // labelBot2
            // 
            this.labelBot2.AutoSize = true;
            this.labelBot2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBot2.Location = new System.Drawing.Point(3, 0);
            this.labelBot2.Name = "labelBot2";
            this.labelBot2.Size = new System.Drawing.Size(75, 22);
            this.labelBot2.TabIndex = 0;
            this.labelBot2.Text = "Bot 2:";
            // 
            // labelBot2Iterations
            // 
            this.labelBot2Iterations.AutoSize = true;
            this.labelBot2Iterations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBot2Iterations.Location = new System.Drawing.Point(84, 0);
            this.labelBot2Iterations.Name = "labelBot2Iterations";
            this.labelBot2Iterations.Size = new System.Drawing.Size(75, 22);
            this.labelBot2Iterations.TabIndex = 1;
            this.labelBot2Iterations.Text = "250";
            // 
            // trackBarBot2
            // 
            this.trackBarBot2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBarBot2.LargeChange = 50;
            this.trackBarBot2.Location = new System.Drawing.Point(3, 102);
            this.trackBarBot2.Maximum = 1000;
            this.trackBarBot2.Minimum = 100;
            this.trackBarBot2.Name = "trackBarBot2";
            this.trackBarBot2.Size = new System.Drawing.Size(162, 39);
            this.trackBarBot2.SmallChange = 50;
            this.trackBarBot2.TabIndex = 5;
            this.trackBarBot2.TickFrequency = 25;
            this.trackBarBot2.Value = 250;
            this.trackBarBot2.ValueChanged += new System.EventHandler(this.TrackBarBot2_ValueChanged);
            // 
            // buttonStart
            // 
            this.buttonStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStart.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonStart.Location = new System.Drawing.Point(3, 391);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(174, 64);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
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
            this.groupBoxMCTSBotsIterations.ResumeLayout(false);
            this.tableLayoutPanelMCTSBotsIterations.ResumeLayout(false);
            this.tableLayoutPanelMCTSBotsIterations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBot1)).EndInit();
            this.tableLayoutPanelBot1.ResumeLayout(false);
            this.tableLayoutPanelBot1.PerformLayout();
            this.tableLayoutPanelBot2.ResumeLayout(false);
            this.tableLayoutPanelBot2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBot2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMenu;
        private System.Windows.Forms.GroupBox groupBoxGameMode;
        private System.Windows.Forms.GroupBox groupBoxMCTSBotsIterations;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelGameMode;
        private System.Windows.Forms.RadioButton radioButtonBvsB;
        private System.Windows.Forms.RadioButton radioButtonBvsP;
        private System.Windows.Forms.RadioButton radioButtonPvsP;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMCTSBotsIterations;
        private System.Windows.Forms.TrackBar trackBarBot1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBot1;
        private System.Windows.Forms.Label labelBot1;
        private System.Windows.Forms.Label labelBot1Iterations;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBot2;
        private System.Windows.Forms.Label labelBot2;
        private System.Windows.Forms.Label labelBot2Iterations;
        private System.Windows.Forms.TrackBar trackBarBot2;
        private System.Windows.Forms.Button buttonStart;
    }
}

