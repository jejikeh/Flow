using Engine.Events;

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

        private async void Window_Paint(object sender, PaintEventArgs e)
        {
            _app.Update();
            await Task.Delay(_app.Config.RefreshRate);
            Invalidate();
        }

        private void SetupForm()
        {
            ClientSize = new Size((int)_app.Config.WindowSize!.X, (int)_app.Config.WindowSize!.Y);
            Name = _app.Config.Title;
            Text = _app.Config.Title;

            MinimumSize = ClientSize;
            MaximumSize = ClientSize;
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            _app.OnEvent(new KeyPressedEvent(e.KeyCode));
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            _app.OnEvent(new KeyReleasedEvent(e.KeyCode));
        }
    }
}