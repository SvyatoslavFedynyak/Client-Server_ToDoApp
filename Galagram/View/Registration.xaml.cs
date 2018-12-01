namespace View
{
    /// <summary>
    /// Interaction logic for Registration.xaml
    /// </summary>
    public partial class Registration : System.Windows.Window
    {
        /// <summary>
        /// Initialize a new instance of <see cref="Registration"/>
        /// </summary>
        public Registration()
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
