using DataBaseControl.Services;
using ViewModel.Commands;
using Models.Entities;
using System.ComponentModel;
using System.Linq;

namespace ViewModel.ViewModels
{
    /// <summary>
    /// A class that bond view and models and represents signing up and logging in logic.
    /// </summary>
    public class SignUpVM : INotifyPropertyChanged
    {
        // FIELDS
        private string nickname;
        private string password;
        private User currentUser;
        private UnitOfWork unitOfWork;

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
        /// Property that enable to interact with current user.
        /// </summary>
        /// <returns>Current user.</returns>
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
        public string Nickname
        {
            set
            {
                nickname = value;
            }
        }
        /// <summary>
        /// Property that enable to interact with user password.
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
            nickname = null;
            password = null;
            currentUser = null;
            unitOfWork = new UnitOfWork();

            #region Commands Initialize
            logIn = new RelayCommand(LogInMethod, IsNotAuthorized);
            signUp = new RelayCommand(SignUpMethod, IsNotAuthorized);
            #endregion
        }

        // METHODS
        #region Commands
        private void LogInMethod(object obj)
        {
            // checking
            if (CheckRegistrateFields())
            {
                // logic
                User userFromDb = null;
                bool logInRes = false;
                try
                {
                    userFromDb = unitOfWork.UserRepository
                        .Get(filter: user => user.NickName == nickname && user.Password == password).First();

                    logInRes = (userFromDb != null);
                }
                catch (System.IO.IOException ex)
                    when (ex is System.IO.FileNotFoundException || ex is System.IO.DirectoryNotFoundException)
                {
                    ExecuteMessageWindow("Error", "Log in operation is unavailable. Data file or database is missing.");
                    return;
                }

                if (logInRes)
                {
                    CurrentUser = userFromDb;
                    new View.User.MainWindow()
                    {
                        // send CurrentUser
                    }.Show();
                    // closing current window
                }
                else
                {
                    ExecuteMessageWindow("Account problem", "The name or password is incorrect.");
                }
            }
        }

        private void SignUpMethod(object obj)
        {
            // checking
            if (CheckRegistrateFields())
            {
                // logic
                User userFromDb = null;
                bool signUpRes = false;
                try
                {
                    userFromDb = unitOfWork.UserRepository
                        .Get(filter: user => user.NickName == nickname).First();

                    if (userFromDb == null)
                    {
                        userFromDb = new User()
                        {
                            NickName = nickname,
                            Password = password,
                            Album = new System.Collections.Generic.List<Photo>(),
                            Followers = new System.Collections.Generic.List<User>(),
                            Following = new System.Collections.Generic.List<User>(),
                            IsAdmin = false
                        };
                        unitOfWork.UserRepository.Insert(userFromDb);
                        unitOfWork.Save();
                        signUpRes = true;
                    }
                }
                catch (System.IO.IOException ex)
                    when (ex is System.IO.FileNotFoundException || ex is System.IO.DirectoryNotFoundException)
                {
                    ExecuteMessageWindow("Error", "Sign up operation is unavailable. Data file or database is missing");
                    return;
                }

                if (signUpRes)
                {
                    CurrentUser = userFromDb;
                    new View.User.MainWindow()
                    {
                        // send CurrentUser
                    }.Show();
                    // closing current window
                }
                else
                {
                    ExecuteMessageWindow("Account problem", "The name is incorrect.");
                }
            }
        }
        #endregion

        #region Restriction
        private bool IsNotAuthorized(object o)
        {
            return CurrentUser == null;
        }
        #endregion

        #region Additional Methods
        private bool CheckRegistrateFields()
        {
            if (string.IsNullOrWhiteSpace(nickname))
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
