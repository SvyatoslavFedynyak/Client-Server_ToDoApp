namespace View.User
{
    /// <summary>
    /// Interaction logic for AskQuestion.xaml
    /// </summary>
    public partial class AskQuestion : System.Windows.Window
    {
        /// <summary>
        /// Initialize a new instance of <see cref="AskQuestion"/>
        /// </summary>
        public AskQuestion()
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
