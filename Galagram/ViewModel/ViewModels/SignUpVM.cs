using ViewModel.Commands;

using Models.Entities;
using View;
using System.ComponentModel;

namespace ViewModel.ViewModels
{
    /// <summary>
    /// A class that bond view and models and represents signing up and logging in logic.
    /// </summary>
    public class SignUpVM : INotifyPropertyChanged
    {
        // FIELDS
        private string login;
        private string password;
        private User currentUser;

        #region Windows
        Registration registrationWindow;
        #endregion

        #region Commands
        private RelayCommand logIn;
        private RelayCommand signUp;
        #endregion

        // EVENTS
        /// <summary>
        /// Event that invokes when some propery changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        // PROPERTIES
        /// <summary>
        /// Propetry that enable to interract with current driver
        /// </summary>
        /// <returns>Current driver</returns>
        public User CurrentUser
        {
            get
            {
                return currentUser;
            }
            set
            {
                currentUser = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(CurrentUser)));
            }
        }
        /// <summary>
        /// Property that enable to interact with user login.
        /// </summary>
        public string Login
        {
            set
            {
                login = value;
            }
        }
        /// <summary>
        /// Property that enable to interact with user password
        /// </summary>
        public string Password
        {
            set
            {
                password = value;
            }
        }

        #region Commands
        /// <summary>
        /// Property that enable to interact with Log In command.
        /// </summary>
        /// <returns>Log In command.</returns>
        public RelayCommand LogIn => logIn;
        /// <summary>
        /// Property that enable to interact with Sign Up command.
        /// </summary>
        /// <returns>Sign Up command.</returns>
        public RelayCommand SignUp => signUp;
        #endregion

        // CONSTRUCTORS
        /// <summary>
        /// Basic constructor without parameters.
        /// </summary>
        public SignUpVM()
        {
            #region Window Initialize
            registrationWindow = null;
            #endregion

            #region Commands Initialize
            //logIn = new RelayCommand(LogInMethod, IsNotAuthorized);
            //logOut = new RelayCommand(LogOutMethod, IsAuthorized);
            //signUp = new RelayCommand(SignUpMethod, IsNotAuthorized);
            #endregion
        }

        // METHODS
        #region Commands
        private void LogInMethod(object obj)
        {

        }

        private void SignUpMethod(object obj)
        {
  
        }
        #endregion

        #region Additional Methods
        private bool CheckRegistrateFields()
        {
            if (string.IsNullOrWhiteSpace(login))
            {
                ExecuteMessageWindow("Empty Login", "Login can not be empty!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                ExecuteMessageWindow("Empty Password", "Password can not be empty!");
                return false;
            }
            return true;
        }

        private void ExecuteMessageWindow(string headerText, string contentText)
        {
            new View.Dialogs.MessageBoxOk()
            {
                Header = headerText,
                Text = contentText
            }.ShowDialog();
        }
        #endregion

        #region Event Raising
        /// <summary>
        /// Method that invokes Property Change event
        /// </summary>
        /// <param name="e">Property Changed Event Args</param>
        protected void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }
        #endregion

    }
}
