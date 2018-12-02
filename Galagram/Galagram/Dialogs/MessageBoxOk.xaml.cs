namespace Galagram.Dialogs
{
    /// <summary>
    /// Interaction logic for MessageBoxOk.xaml
    /// </summary>
    public partial class MessageBoxOk : System.Windows.Window
    {
        // CONSTRUCTORS
        public MessageBoxOk()
        {
            InitializeComponent();
        }
        // PROPERTIES
        public string Header
        {
            get
            {
                return HeaderLbl.Content.ToString();
            }
            set
            {
                HeaderLbl.Content = value;
            }
        }
        public string Text
        {
            get
            {
                return ContentTb.Text;
            }
            set
            {
                ContentTb.Text = value;
            }
        }
        // METHODS
        private void MovingWindow(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.ChangedButton == System.Windows.Input.MouseButton.Left)
            {
                this.DragMove();
            }
        }
        private void Exit(object sender, System.Windows.RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
