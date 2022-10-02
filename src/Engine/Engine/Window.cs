namespace Engine
{
    public partial class Window : Form
    {
        private Game _app;
        public Window(Game app)
        {
            _app = app;
            InitializeComponent();
            
            _app.Start();
        }
    }
}