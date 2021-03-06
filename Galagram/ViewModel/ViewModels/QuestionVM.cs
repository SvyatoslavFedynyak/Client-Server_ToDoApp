using ViewModel.Commands;

using Models.Entities;
using Galagram;
using System.ComponentModel;

namespace ViewModel.ViewModels
{
    public class QuestionVM : INotifyPropertyChanged
    {
        // FIELDS
        private string text;
        private Subject selectedSubject;

        #region Windows
        Galagram.User.AskQuestion askQuestionWindow;
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
        public User CurrentUser { get; }
        public Subject[] Subjects { get; }
        /// <summary>
        /// Propetry that enable to interract with current driver
        /// </summary>
        /// <returns>Current driver</returns>
        public Subject SelectedSubject
        {
            get
            {
                return selectedSubject;
            }
            set
            {
                selectedSubject = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(SelectedSubject)));
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
