using ViewModel.Commands;

using Models.Entities;
using Galagram;
using System.ComponentModel;

namespace ViewModel.ViewModels
{
    public class SearchVM : INotifyPropertyChanged
    {
        // FIELDS
        private string data;
        private User selectedUser;
        public User[] users;

        #region Windows
        Galagram.User.Search searchWindow;
        #endregion

        #region Commands
        private RelayCommand search;
        #endregion

        // EVENTS
        /// <summary>
        /// Event that invokes when some propery changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        // PROPERTIES
        public User[] Users
        {
            get
            {
                return users;
            }
            set
            {
                users = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Users)));
            }
        }
        /// <summary>
        /// Propetry that enable to interract with current driver
        /// </summary>
        /// <returns>Current driver</returns>
        public User SelectedUser
        {
            get
            {
                return selectedUser;
            }
            set
            {
                selectedUser = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(SelectedUser)));
            }
        }
        public string Data
        {
            set
            {
                data = value;
            }
        }

        #region Commands
        /// <summary>
        /// Property that enable to interact with search command.
        /// </summary>
        /// <returns>Log In command.</returns>
        public RelayCommand Search => search;
        #endregion

        // CONSTRUCTORS
        /// <summary>
        /// Basic constructor without parameters.
        /// </summary>
        public SearchVM()
        {
            #region Window Initialize
            searchWindow = null;
            #endregion

            #region Commands Initialize

            #endregion
        }

        // METHODS
        #region Commands
        private void SearchMethod(object obj)
        {

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
