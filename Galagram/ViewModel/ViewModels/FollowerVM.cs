using ViewModel.Commands;

using Models.Entities;
using Galagram;
using System.ComponentModel;

namespace ViewModel.ViewModels
{
    public class FollowerVM : INotifyPropertyChanged
    {
        // FIELDS
        private User selectedFollower;
        private User[] followers;

        #region Windows
        Galagram.User.Follow followWindow;
        #endregion

        #region Commands
        private RelayCommand unfollow;
        #endregion

        // EVENTS
        /// <summary>
        /// Event that invokes when some propery changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        // PROPERTIES
        public User[] Followers
        {
            get
            {
                return followers;
            }
            set
            {
                followers = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Followers)));
            }
        }
        public User SelectedFollower
        {
            get
            {
                return selectedFollower;
            }
            set
            {
                selectedFollower = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(selectedFollower)));
            }
        }

        #region Commands
        /// <summary>
        /// Property that enable to interact with search command.
        /// </summary>
        /// <returns>Log In command.</returns>
        public RelayCommand Unfollow => unfollow;
        #endregion

        // CONSTRUCTORS
        /// <summary>
        /// Basic constructor without parameters.
        /// </summary>
        public FollowerVM()
        {
            #region Window Initialize
            followWindow = null;
            #endregion

            #region Commands Initialize

            #endregion
        }

        // METHODS
        #region Commands
        private void UnfollowMethod(object obj)
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
