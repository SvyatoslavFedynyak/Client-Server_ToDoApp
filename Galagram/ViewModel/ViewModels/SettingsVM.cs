using ViewModel.Commands;

using Models.Entities;
using View;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace ViewModel.ViewModels
{
    public class SettingsVM : INotifyPropertyChanged
    {
        // FIELDS
        private string nickname;
        private string password;
        private string newPassword;

        #region Windows
        View.User.Setting settingWindow;
        #endregion

        #region Commands
        private RelayCommand apply;
        private RelayCommand loadNewPhoto;
        #endregion

        // EVENTS
        /// <summary>
        /// Event that invokes when some propery changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        // PROPERTIES
        public User CurrentUser { get; private set; }
        public string Nickname
        {
            set
            {
                nickname = value;
            }
        }
        public string Password
        {
            set
            {
                password = value;
            }
        }
        public string NewPassword
        {
            set
            {
                newPassword = value;
            }
        }

        #region Commands
        /// <summary>
        /// Property that enable to interact with search command.
        /// </summary>
        /// <returns>Log In command.</returns>
        public RelayCommand Apply => apply;
        public RelayCommand LoadNewPhoto => loadNewPhoto;
        #endregion

        // CONSTRUCTORS
        /// <summary>
        /// Basic constructor without parameters.
        /// </summary>
        public SettingsVM()
        {
            #region Window Initialize
            settingWindow = null;
            #endregion

            #region Commands Initialize

            #endregion
        }

        // METHODS
        // METHODS
        #region Commands
        private void ApplyMethod(object obj)
        {

        }

        private void LoadNewPhotoMethod(object obj)
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
