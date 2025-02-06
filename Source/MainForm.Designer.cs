namespace Vizu
{
    partial class MainForm
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
            TableLayoutPanel_MainLayout = new TableLayoutPanel();
            TableLayoutPanel_Channels = new TableLayoutPanel();
            TextBox_Channel_4_Value = new TextBox();
            TextBox_Channel_3_Value = new TextBox();
            TextBox_Channel_2_Value = new TextBox();
            TrackBar_Channel_4 = new TrackBar();
            TrackBar_Channel_3 = new TrackBar();
            TrackBar_Channel_2 = new TrackBar();
            TrackBar_Channel_1 = new TrackBar();
            TextBox_Channel_1_Value = new TextBox();
            Panel_ColorVisualization = new Panel();
            TableLayoutPanel_MainLayout.SuspendLayout();
            TableLayoutPanel_Channels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TrackBar_Channel_4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TrackBar_Channel_3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TrackBar_Channel_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TrackBar_Channel_1).BeginInit();
            SuspendLayout();
            // 
            // TableLayoutPanel_MainLayout
            // 
            TableLayoutPanel_MainLayout.ColumnCount = 2;
            TableLayoutPanel_MainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayoutPanel_MainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableLayoutPanel_MainLayout.Controls.Add(TableLayoutPanel_Channels, 0, 0);
            TableLayoutPanel_MainLayout.Controls.Add(Panel_ColorVisualization, 1, 0);
            TableLayoutPanel_MainLayout.Dock = DockStyle.Fill;
            TableLayoutPanel_MainLayout.Location = new Point(0, 0);
            TableLayoutPanel_MainLayout.Margin = new Padding(0);
            TableLayoutPanel_MainLayout.Name = "TableLayoutPanel_MainLayout";
            TableLayoutPanel_MainLayout.RowCount = 1;
            TableLayoutPanel_MainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanel_MainLayout.Size = new Size(800, 450);
            TableLayoutPanel_MainLayout.TabIndex = 0;
            // 
            // TableLayoutPanel_Channels
            // 
            TableLayoutPanel_Channels.ColumnCount = 4;
            TableLayoutPanel_Channels.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TableLayoutPanel_Channels.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TableLayoutPanel_Channels.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TableLayoutPanel_Channels.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TableLayoutPanel_Channels.Controls.Add(TextBox_Channel_4_Value, 3, 1);
            TableLayoutPanel_Channels.Controls.Add(TextBox_Channel_3_Value, 2, 1);
            TableLayoutPanel_Channels.Controls.Add(TextBox_Channel_2_Value, 1, 1);
            TableLayoutPanel_Channels.Controls.Add(TrackBar_Channel_4, 3, 0);
            TableLayoutPanel_Channels.Controls.Add(TrackBar_Channel_3, 2, 0);
            TableLayoutPanel_Channels.Controls.Add(TrackBar_Channel_2, 1, 0);
            TableLayoutPanel_Channels.Controls.Add(TrackBar_Channel_1, 0, 0);
            TableLayoutPanel_Channels.Controls.Add(TextBox_Channel_1_Value, 0, 1);
            TableLayoutPanel_Channels.Dock = DockStyle.Fill;
            TableLayoutPanel_Channels.Location = new Point(3, 3);
            TableLayoutPanel_Channels.Name = "TableLayoutPanel_Channels";
            TableLayoutPanel_Channels.RowCount = 2;
            TableLayoutPanel_Channels.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TableLayoutPanel_Channels.RowStyles.Add(new RowStyle());
            TableLayoutPanel_Channels.Size = new Size(394, 444);
            TableLayoutPanel_Channels.TabIndex = 0;
            // 
            // TextBox_Channel_4_Value
            // 
            TextBox_Channel_4_Value.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TextBox_Channel_4_Value.Location = new Point(297, 414);
            TextBox_Channel_4_Value.MaxLength = 3;
            TextBox_Channel_4_Value.Name = "TextBox_Channel_4_Value";
            TextBox_Channel_4_Value.Size = new Size(94, 27);
            TextBox_Channel_4_Value.TabIndex = 11;
            TextBox_Channel_4_Value.Text = "0";
            TextBox_Channel_4_Value.TextAlign = HorizontalAlignment.Center;
            TextBox_Channel_4_Value.TextChanged += TextBox_Channel_4_Value_TextChanged;
            // 
            // TextBox_Channel_3_Value
            // 
            TextBox_Channel_3_Value.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TextBox_Channel_3_Value.Location = new Point(199, 414);
            TextBox_Channel_3_Value.MaxLength = 3;
            TextBox_Channel_3_Value.Name = "TextBox_Channel_3_Value";
            TextBox_Channel_3_Value.Size = new Size(92, 27);
            TextBox_Channel_3_Value.TabIndex = 10;
            TextBox_Channel_3_Value.Text = "0";
            TextBox_Channel_3_Value.TextAlign = HorizontalAlignment.Center;
            TextBox_Channel_3_Value.TextChanged += TextBox_Channel_3_Value_TextChanged;
            // 
            // TextBox_Channel_2_Value
            // 
            TextBox_Channel_2_Value.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TextBox_Channel_2_Value.Location = new Point(101, 414);
            TextBox_Channel_2_Value.MaxLength = 3;
            TextBox_Channel_2_Value.Name = "TextBox_Channel_2_Value";
            TextBox_Channel_2_Value.Size = new Size(92, 27);
            TextBox_Channel_2_Value.TabIndex = 9;
            TextBox_Channel_2_Value.Text = "0";
            TextBox_Channel_2_Value.TextAlign = HorizontalAlignment.Center;
            TextBox_Channel_2_Value.TextChanged += TextBox_Channel_2_Value_TextChanged;
            // 
            // TrackBar_Channel_4
            // 
            TrackBar_Channel_4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            TrackBar_Channel_4.BackColor = Color.Gray;
            TrackBar_Channel_4.Cursor = Cursors.SizeNS;
            TrackBar_Channel_4.Location = new Point(316, 3);
            TrackBar_Channel_4.Maximum = 255;
            TrackBar_Channel_4.Name = "TrackBar_Channel_4";
            TrackBar_Channel_4.Orientation = Orientation.Vertical;
            TrackBar_Channel_4.Size = new Size(56, 405);
            TrackBar_Channel_4.TabIndex = 6;
            TrackBar_Channel_4.ValueChanged += TrackBar_Channel_4_ValueChanged;
            // 
            // TrackBar_Channel_3
            // 
            TrackBar_Channel_3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            TrackBar_Channel_3.BackColor = Color.Blue;
            TrackBar_Channel_3.Cursor = Cursors.SizeNS;
            TrackBar_Channel_3.Location = new Point(217, 3);
            TrackBar_Channel_3.Maximum = 255;
            TrackBar_Channel_3.Name = "TrackBar_Channel_3";
            TrackBar_Channel_3.Orientation = Orientation.Vertical;
            TrackBar_Channel_3.Size = new Size(56, 405);
            TrackBar_Channel_3.TabIndex = 5;
            TrackBar_Channel_3.ValueChanged += TrackBar_Channel_3_ValueChanged;
            // 
            // TrackBar_Channel_2
            // 
            TrackBar_Channel_2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            TrackBar_Channel_2.BackColor = Color.Green;
            TrackBar_Channel_2.Cursor = Cursors.SizeNS;
            TrackBar_Channel_2.Location = new Point(119, 3);
            TrackBar_Channel_2.Maximum = 255;
            TrackBar_Channel_2.Name = "TrackBar_Channel_2";
            TrackBar_Channel_2.Orientation = Orientation.Vertical;
            TrackBar_Channel_2.Size = new Size(56, 405);
            TrackBar_Channel_2.TabIndex = 2;
            TrackBar_Channel_2.ValueChanged += TrackBar_Channel_2_ValueChanged;
            // 
            // TrackBar_Channel_1
            // 
            TrackBar_Channel_1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            TrackBar_Channel_1.BackColor = Color.Red;
            TrackBar_Channel_1.Cursor = Cursors.SizeNS;
            TrackBar_Channel_1.Location = new Point(21, 3);
            TrackBar_Channel_1.Maximum = 255;
            TrackBar_Channel_1.Name = "TrackBar_Channel_1";
            TrackBar_Channel_1.Orientation = Orientation.Vertical;
            TrackBar_Channel_1.Size = new Size(56, 405);
            TrackBar_Channel_1.TabIndex = 0;
            TrackBar_Channel_1.ValueChanged += TrackBar_Channel_1_ValueChanged;
            // 
            // TextBox_Channel_1_Value
            // 
            TextBox_Channel_1_Value.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TextBox_Channel_1_Value.Location = new Point(3, 414);
            TextBox_Channel_1_Value.MaxLength = 3;
            TextBox_Channel_1_Value.Name = "TextBox_Channel_1_Value";
            TextBox_Channel_1_Value.Size = new Size(92, 27);
            TextBox_Channel_1_Value.TabIndex = 8;
            TextBox_Channel_1_Value.Text = "0";
            TextBox_Channel_1_Value.TextAlign = HorizontalAlignment.Center;
            TextBox_Channel_1_Value.TextChanged += TextBox_Channel_1_Value_TextChanged;
            // 
            // Panel_ColorVisualization
            // 
            Panel_ColorVisualization.BackColor = Color.Transparent;
            Panel_ColorVisualization.BackgroundImage = Properties.Resources.grid;
            Panel_ColorVisualization.BackgroundImageLayout = ImageLayout.Center;
            Panel_ColorVisualization.Dock = DockStyle.Fill;
            Panel_ColorVisualization.Location = new Point(403, 3);
            Panel_ColorVisualization.Name = "Panel_ColorVisualization";
            Panel_ColorVisualization.Size = new Size(394, 444);
            Panel_ColorVisualization.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TableLayoutPanel_MainLayout);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vizu";
            TableLayoutPanel_MainLayout.ResumeLayout(false);
            TableLayoutPanel_Channels.ResumeLayout(false);
            TableLayoutPanel_Channels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TrackBar_Channel_4).EndInit();
            ((System.ComponentModel.ISupportInitialize)TrackBar_Channel_3).EndInit();
            ((System.ComponentModel.ISupportInitialize)TrackBar_Channel_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)TrackBar_Channel_1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TableLayoutPanel_MainLayout;


        private TableLayoutPanel TableLayoutPanel_Channels;
        private TrackBar TrackBar_Channel_1;
        private TrackBar TrackBar_Channel_2;
        private TrackBar TrackBar_Channel_3;


        private Panel Panel_ColorVisualization;
        private TrackBar TrackBar_Channel_4;
        private TextBox TextBox_Channel_1_Value;
        private TextBox TextBox_Channel_4_Value;
        private TextBox TextBox_Channel_3_Value;
        private TextBox TextBox_Channel_2_Value;
    }
}
