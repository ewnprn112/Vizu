namespace Vizu
{
    public partial class MainForm : Form
    {
        private (int A, int R, int G, int B) ActualColor;

        public MainForm()
        {
            InitializeComponent();

            // Initializing ActualColor's default value
            ActualColor = (255, 0, 0, 0);

            // Initializing components' properties
            TrackBar_Channel_1.Value = ActualColor.R;
            TrackBar_Channel_2.Value = ActualColor.G;
            TrackBar_Channel_3.Value = ActualColor.B;
            TrackBar_Channel_4.Value = ActualColor.A;

            //TextBox_Channel_1_Value.Text = ActualColor.R.ToString();
            //TextBox_Channel_2_Value.Text = ActualColor.G.ToString();
            //TextBox_Channel_3_Value.Text = ActualColor.B.ToString();
            //TextBox_Channel_4_Value.Text = ActualColor.A.ToString();

            Panel_ColorVisualization.Paint += Panel_ColorVisualization_Paint;
            //Sync_Panel_ColorVisualization_BackColor_With_ActualColor();
        }

        private void Panel_ColorVisualization_Paint(object sender, PaintEventArgs e)
        {
            var Brush = new SolidBrush(Color.FromArgb(ActualColor.A, ActualColor.R, ActualColor.G, ActualColor.B));
            e.Graphics.FillRectangle(Brush, Panel_ColorVisualization.ClientRectangle);
        }

        private void Sync_Panel_ColorVisualization_BackColor_With_ActualColor()
        {
            Panel_ColorVisualization.Invalidate();
        }

        private void TrackBar_Channel_1_ValueChanged(object sender, EventArgs e)
        {
            var Channel_Value = TrackBar_Channel_1.Value;
            ActualColor.R = Channel_Value;
            TextBox_Channel_1_Value.Text = Channel_Value.ToString();
            Sync_Panel_ColorVisualization_BackColor_With_ActualColor();
        }

        private void TrackBar_Channel_2_ValueChanged(object sender, EventArgs e)
        {
            var Channel_Value = TrackBar_Channel_2.Value;
            ActualColor.G = Channel_Value;
            TextBox_Channel_2_Value.Text = Channel_Value.ToString();
            Sync_Panel_ColorVisualization_BackColor_With_ActualColor();
        }

        private void TrackBar_Channel_3_ValueChanged(object sender, EventArgs e)
        {
            var Channel_Value = TrackBar_Channel_3.Value;
            ActualColor.B = Channel_Value;
            TextBox_Channel_3_Value.Text = Channel_Value.ToString();
            Sync_Panel_ColorVisualization_BackColor_With_ActualColor();
        }

        private void TrackBar_Channel_4_ValueChanged(object sender, EventArgs e)
        {
            var Channel_Value = TrackBar_Channel_4.Value;
            ActualColor.A = Channel_Value;
            TextBox_Channel_4_Value.Text = Channel_Value.ToString();
            Sync_Panel_ColorVisualization_BackColor_With_ActualColor();
        }

        private void TextBox_Channel_1_Value_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(TextBox_Channel_1_Value.Text, out int ConvertedValue)) {
                TextBox_Channel_1_Value.BackColor = SystemColors.Control;
                ConvertedValue = Math.Clamp(ConvertedValue, 0, 255);
                TrackBar_Channel_1.Value = ConvertedValue;
                TextBox_Channel_1_Value.Text = ConvertedValue.ToString();
            } else {
                TextBox_Channel_1_Value.BackColor = Color.Red;
            }
        }

        private void TextBox_Channel_2_Value_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(TextBox_Channel_2_Value.Text, out int ConvertedValue)) {
                TextBox_Channel_2_Value.BackColor = SystemColors.Control;
                ConvertedValue = Math.Clamp(ConvertedValue, 0, 255);
                TrackBar_Channel_2.Value = ConvertedValue;
                TextBox_Channel_2_Value.Text = ConvertedValue.ToString();
            } else {
                TextBox_Channel_2_Value.BackColor = Color.Red;
            }
        }

        private void TextBox_Channel_3_Value_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(TextBox_Channel_3_Value.Text, out int ConvertedValue)) {
                TextBox_Channel_3_Value.BackColor = SystemColors.Control;
                ConvertedValue = Math.Clamp(ConvertedValue, 0, 255);
                TrackBar_Channel_3.Value = ConvertedValue;
                TextBox_Channel_3_Value.Text = ConvertedValue.ToString();
            } else {
                TextBox_Channel_3_Value.BackColor = Color.Red;
            }
        }

        private void TextBox_Channel_4_Value_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(TextBox_Channel_4_Value.Text, out int ConvertedValue)) {
                TextBox_Channel_4_Value.BackColor = SystemColors.Control;
                ConvertedValue = Math.Clamp(ConvertedValue, 0, 255);
                TrackBar_Channel_4.Value = ConvertedValue;
                TextBox_Channel_4_Value.Text = ConvertedValue.ToString();
            } else {
                TextBox_Channel_4_Value.BackColor = Color.Red;
            }
        }
    }
}
