namespace Engine
{
    public partial class FlowWindow : Form
    {
        public FlowWindow(FlowGame app)
        {
            InitializeComponent();
            app.Start();
        }

        private void FlowWindow_Activated(object sender, EventArgs e)
        {
        }

        private void FlowWindow_Paint(object sender, EventArgs e)
        {

        }

        private void FlowWindow_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}