namespace Galagram.Admin
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : System.Windows.Window
    {
        // CONSTRUCTORS
        public AdminWindow()
        {
            InitializeComponent();
        }
        // METHODS
        private void MovingWindow(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.ChangedButton == System.Windows.Input.MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            Content.Child = new UserControls.Messages.MessageInside()
            {
                Width = Content.Width,
                Height = Content.Height,
            };
        }

        private void Button_Click_1(object sender, System.Windows.RoutedEventArgs e)
        {
            Content.Child = new UserControls.DeleteItem()
            {
                Width = Content.Width,
                Height = Content.Height,
                DeleteItemName = "Item name to delete"
            };
        }

        private void Button_Click_2(object sender, System.Windows.RoutedEventArgs e)
        {
            Content.Child = null;
        }
    }
}
