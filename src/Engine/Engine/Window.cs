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
            _app.Load();
        }

        private void Window_Paint(object sender, PaintEventArgs e)
        {
            _app.Update();
        }

        private void SetupForm()
        {
            ClientSize = new Size((int)_app.Config.WindowSize!.X, (int)_app.Config.WindowSize!.Y);
            Name = _app.Config.Title;
            Text = _app.Config.Title;

            MinimumSize = ClientSize;
            MaximumSize = ClientSize;
        }
    }
}