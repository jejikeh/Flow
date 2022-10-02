namespace Engine
{
    public partial class Window : Form
    {
        private readonly Game _app;
        public Window(Game app)
        {

            _app = app;
            _app.Init(Handle);
            InitializeComponent();
            SetupForm();
        }

        private void Window_Load(object sender, EventArgs e)
        {
            _app.Start();
        }

        private void Window_Paint(object sender, PaintEventArgs e)
        {
            _app.Update();
        }

        private void SetupForm()
        {
            ClientSize = new Size(_app.WindowSize!.Item1, _app.WindowSize!.Item2);
            Name = _app.Title;
            Text = _app.Title;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            TinyLog.Log.Warn("HAHA");
        }
    }
}