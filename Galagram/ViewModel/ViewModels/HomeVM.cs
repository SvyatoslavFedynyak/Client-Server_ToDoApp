using ViewModel.Commands;

using Models.Entities;
using Galagram;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace ViewModel.ViewModels
{
    public class HomeVM : INotifyPropertyChanged
    {
        // FIELDS
        #region Windows
        Galagram.User.MainWindow mainWindow;
        #endregion

        #region Commands
        private RelayCommand follow;
        private RelayCommand home;
        private RelayCommand following;
        private RelayCommand search;
        private RelayCommand addPhoto;
        private RelayCommand info;
        private RelayCommand settings;
        private RelayCommand exit;
        private RelayCommand openPhoto;
        private RelayCommand logOut;
        private RelayCommand followers;
        private RelayCommand selectPhoto;
        #endregion

        // EVENTS
        /// <summary>
        /// Event that invokes when some propery changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        // PROPERTIES
        public User Owner { get; }

        #region Commands
        public RelayCommand Exit => exit;
        public RelayCommand Home => home;
        /// <summary>
        /// Property that enable to interact with search command.
        /// </summary>
        /// <returns>Log In command.</returns>
        public RelayCommand Search => search;
        public RelayCommand AddPhoto => addPhoto;

        public RelayCommand Info => info;
        public RelayCommand Settings => settings;
        public RelayCommand LogOut => logOut;

        public RelayCommand Follow => follow;
        public RelayCommand Following => following;
        public RelayCommand Followers => followers;

        public RelayCommand OpenPhoto => openPhoto;
        public RelayCommand SelectPhoto => selectPhoto;
        #endregion

        // CONSTRUCTORS
        /// <summary>
        /// Basic constructor without parameters.
        /// </summary>
        public HomeVM()
        {
            #region Window Initialize
            mainWindow = null;
            #endregion

            #region Commands Initialize

            #endregion
        }

        // METHODS
        #region Commands
        private void FollowMethod(object obj)
        {

        }

        private void HomeMethod(object obj)
        {

        }

        private void FollowingMethod(object obj)
        {

        }
        private void SearchMethod(object obj)
        {

        }
        private void AddPhotoMethod(object obj)
        {

        }
        private void InfoMethod(object obj)
        {

        }
        private void SettingsMethod(object obj)
        {

        }
        private void ExitMethod(object obj)
        {

        }
        private void OpenPhotoMethod(object obj)
        {

        }
        private void LogOutMethod(object obj)
        {

        }
        private void FollowersMethod(object obj)
        {

        }
        private void SelectPhotoMethod(object obj)
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
