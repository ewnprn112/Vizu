namespace Vizu
{
    public partial class MainForm : Form
    {
        private (int R, int G, int B) ActualColor;

        public MainForm()
        {
            InitializeComponent();

            // Initializing ActualColor's default value
            ActualColor = (0, 0, 0);

            // Initializing components' properties
            TrackBar_Channel_1.Value = ActualColor.R;
            TrackBar_Channel_2.Value = ActualColor.G;
            TrackBar_Channel_3.Value = ActualColor.B;

            Label_Channel_1_Value.Text = ActualColor.R.ToString();
            Label_Channel_2_Value.Text = ActualColor.G.ToString();
            Label_Channel_3_Value.Text = ActualColor.B.ToString();

            Sync_Panel_ColorVisualization_BackColor_With_ActualColor();
        }

        private void Sync_Panel_ColorVisualization_BackColor_With_ActualColor()
        {
            Panel_ColorVisualization.BackColor = Color.FromArgb(ActualColor.R, ActualColor.G, ActualColor.B);
        }

        private void TrackBar_Channel_1_ValueChanged(object sender, EventArgs e)
        {
            var Channel_Value = TrackBar_Channel_1.Value;

            ActualColor.R = Channel_Value;
            Label_Channel_1_Value.Text = Channel_Value.ToString();

            Sync_Panel_ColorVisualization_BackColor_With_ActualColor();
        }

        private void TrackBar_Channel_2_ValueChanged(object sender, EventArgs e)
        {
            var Channel_Value = TrackBar_Channel_2.Value;

            ActualColor.G = Channel_Value;
            Label_Channel_2_Value.Text = Channel_Value.ToString();

            Sync_Panel_ColorVisualization_BackColor_With_ActualColor();
        }

        private void TrackBar_Channel_3_ValueChanged(object sender, EventArgs e)
        {
            var Channel_Value = TrackBar_Channel_3.Value;

            ActualColor.B = Channel_Value;
            Label_Channel_3_Value.Text = Channel_Value.ToString();

            Sync_Panel_ColorVisualization_BackColor_With_ActualColor();
        }
    }
}
