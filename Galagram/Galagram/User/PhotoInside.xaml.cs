namespace Galagram.User
{
    /// <summary>
    /// Interaction logic for PhotoInside.xaml
    /// </summary>
    public partial class PhotoInside : System.Windows.Window
    {
        /// <summary>
        /// Initialize a new instance of <see cref="PhotoInside"/>
        /// </summary>
        public PhotoInside()
        {
            InitializeComponent();
        }
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
