using ViewModel.Commands;

using Models.Entities;
using View;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace ViewModel.ViewModels
{
    public class QuestionVM : INotifyPropertyChanged
    {
        // FIELDS
        private string text;
        private Subject currentSubject;

        #region Windows
        View.User.AskQuestion askQuestionWindow;
        #endregion

        #region Commands
        private RelayCommand send;
        #endregion

        // EVENTS
        /// <summary>
        /// Event that invokes when some propery changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        // PROPERTIES
        public User currentUser { get; }
        public ObservableCollection<Subject> Subjects { get; }
        /// <summary>
        /// Propetry that enable to interract with current driver
        /// </summary>
        /// <returns>Current driver</returns>
        public Subject CurrentSubject
        {
            get
            {
                return currentSubject;
            }
            set
            {
                currentSubject = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(CurrentSubject)));
            }
        }
        public string Text
        {
            set
            {
                text = value;
            }
        }

        #region Commands
        /// <summary>
        /// Property that enable to interact with search command.
        /// </summary>
        /// <returns>Log In command.</returns>
        public RelayCommand Send => send;
        #endregion

        // CONSTRUCTORS
        /// <summary>
        /// Basic constructor without parameters.
        /// </summary>
        public QuestionVM()
        {
            #region Window Initialize
            askQuestionWindow = null;
            #endregion

            #region Commands Initialize

            #endregion
        }

        // METHODS
        #region Commands
        private void SendMethod(object obj)
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
