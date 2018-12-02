namespace Galagram.Dialogs
{
    /// <summary>
    /// Interaction logic for MessageBoxYesNo.xaml
    /// </summary>
    public partial class MessageBoxYesNo : System.Windows.Window
    {
        // CONSTRUCTORS
        public MessageBoxYesNo()
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
        private void Yes(object sender, System.Windows.RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }
        private void No(object sender, System.Windows.RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
