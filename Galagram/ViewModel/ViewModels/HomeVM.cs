using DataBaseControl.Services;
using ViewModel.Commands;
using Models.Entities;
using System.ComponentModel;
using System.Linq;

namespace ViewModel.ViewModels
{
    /// <summary>
    /// A class that bonds view and models and represents the logic of main window.
    /// </summary>
    public class HomeVM : INotifyPropertyChanged
    {
        // FIELDS
        private UnitOfWork unitOfWork;

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
        private RelayCommand selectedPhoto;
        #endregion

        // EVENTS
        /// <summary>
        /// Event that invokes when some propery changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        // PROPERTIES
        /// <summary>
        /// Property that enables to interact with current user.
        /// </summary>
        public User CurrentUser { get; }

        #region Commands
        /// <summary>
        /// Property that enables to interact with exit command.
        /// </summary>
        public RelayCommand Exit => exit;
        /// <summary>
        /// Property that enables to interact with home command.
        /// </summary>
        public RelayCommand Home => home;
        /// <summary>
        /// Property that enables to interact with search command.
        /// </summary>
        public RelayCommand Search => search;
        /// <summary>
        /// Property that enables to interact with adding photo command.
        /// </summary>
        public RelayCommand AddPhoto => addPhoto;

        /// <summary>
        /// Property that enables to interact with info command.
        /// </summary>
        public RelayCommand Info => info;
        /// <summary>
        /// Property that enables to interact with settings command.
        /// </summary>
        public RelayCommand Settings => settings;
        /// <summary>
        /// Property that enables to interact with log out command.
        /// </summary>
        public RelayCommand LogOut => logOut;

        /// <summary>
        /// Property that enables to interact with follow command.
        /// </summary>
        public RelayCommand Follow => follow;
        /// <summary>
        /// Property that enables to interact with following command.
        /// </summary>
        public RelayCommand Following => following;
        /// <summary>
        /// Property that enables to interact with followers command.
        /// </summary>
        public RelayCommand Followers => followers;

        /// <summary>
        /// Property that enables to interact with opening photo command.
        /// </summary>
        public RelayCommand OpenPhoto => openPhoto;
        /// <summary>
        /// Property that enables to interact with selected photo command.
        /// </summary>
        public RelayCommand SelectedPhoto => selectedPhoto;
        #endregion

        // CONSTRUCTORS
        /// <summary>
        /// Basic constructor without parameters.
        /// </summary>
        public HomeVM()
        {
            unitOfWork = new UnitOfWork();
            CurrentUser = null;

            #region Commands Initialize
            follow = new RelayCommand(FollowMethod);
            home = new RelayCommand(HomeMethod);
            following = new RelayCommand(FollowingMethod);
            search = new RelayCommand(SearchMethod);
            addPhoto = new RelayCommand(AddPhotoMethod);
            info = new RelayCommand(InfoMethod);
            settings = new RelayCommand(SettingsMethod);
            exit = new RelayCommand(ExitMethod);
            openPhoto = new RelayCommand(OpenPhotoMethod);
            logOut = new RelayCommand(LogOutMethod);
            followers = new RelayCommand(FollowersMethod);
            selectedPhoto = new RelayCommand(SelectedPhotoMethod);
            #endregion
        }

        /// <summary>
        /// Basic constructor with one parameter.
        /// </summary>
        public HomeVM(User user) : this()
        {
            CurrentUser = user;
        }

        // METHODS
        #region Commands
        private void FollowMethod(object obj)
        {
            new Galagram.User.Follow()
            {
                DataContext = new FollowerVM()
            }.Show();
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
            System.Windows.Application.Current.Shutdown();
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

        private void SelectedPhotoMethod(object obj)
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
