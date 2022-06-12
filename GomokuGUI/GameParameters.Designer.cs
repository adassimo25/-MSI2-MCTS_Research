
namespace GomokuGUI
{
    partial class GameParameters
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelBoardSize = new System.Windows.Forms.Label();
            this.labelWinning = new System.Windows.Forms.Label();
            this.numericUpDownBoardSize = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownWinning = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBoardSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWinning)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel.Controls.Add(this.labelBoardSize, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.labelWinning, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.numericUpDownBoardSize, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.numericUpDownWinning, 2, 3);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(282, 153);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // labelBoardSize
            // 
            this.labelBoardSize.AutoSize = true;
            this.labelBoardSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBoardSize.Location = new System.Drawing.Point(45, 38);
            this.labelBoardSize.Name = "labelBoardSize";
            this.labelBoardSize.Size = new System.Drawing.Size(92, 30);
            this.labelBoardSize.TabIndex = 0;
            this.labelBoardSize.Text = "Board size:";
            this.labelBoardSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelWinning
            // 
            this.labelWinning.AutoSize = true;
            this.labelWinning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWinning.Location = new System.Drawing.Point(45, 83);
            this.labelWinning.Name = "labelWinning";
            this.labelWinning.Size = new System.Drawing.Size(92, 30);
            this.labelWinning.TabIndex = 1;
            this.labelWinning.Text = "Winning:";
            this.labelWinning.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDownBoardSize
            // 
            this.numericUpDownBoardSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownBoardSize.Location = new System.Drawing.Point(143, 41);
            this.numericUpDownBoardSize.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownBoardSize.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownBoardSize.Name = "numericUpDownBoardSize";
            this.numericUpDownBoardSize.Size = new System.Drawing.Size(92, 27);
            this.numericUpDownBoardSize.TabIndex = 2;
            this.numericUpDownBoardSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownBoardSize.Value = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.numericUpDownBoardSize.ValueChanged += new System.EventHandler(this.NumericUpDownBoardSize_ValueChanged);
            // 
            // numericUpDownWinning
            // 
            this.numericUpDownWinning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownWinning.Location = new System.Drawing.Point(143, 86);
            this.numericUpDownWinning.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDownWinning.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownWinning.Name = "numericUpDownWinning";
            this.numericUpDownWinning.Size = new System.Drawing.Size(92, 27);
            this.numericUpDownWinning.TabIndex = 3;
            this.numericUpDownWinning.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownWinning.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownWinning.ValueChanged += new System.EventHandler(this.NumericUpDownWinning_ValueChanged);
            // 
            // GameParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 153);
            this.Controls.Add(this.tableLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GameParameters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Set game params";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBoardSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWinning)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label labelBoardSize;
        private System.Windows.Forms.Label labelWinning;
        private System.Windows.Forms.NumericUpDown numericUpDownBoardSize;
        private System.Windows.Forms.NumericUpDown numericUpDownWinning;
    }
}