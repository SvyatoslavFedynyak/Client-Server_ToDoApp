using ViewModel.Commands;

using Models.Entities;
using Galagram;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace ViewModel.ViewModels
{
    public class PhotoVM : INotifyPropertyChanged
    {
        // FIELDS
        private Comment selectedComment;
        private Comment[] comments;

        #region Windows
        Galagram.User.PhotoInside photoWindow;
        #endregion

        #region Commands
        private RelayCommand writeComment;
        private RelayCommand likeDislikePhoto;
        private RelayCommand deleteComment;
        private RelayCommand likeDislikeComment;
        #endregion

        // EVENTS
        /// <summary>
        /// Event that invokes when some propery changed.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        // PROPERTIES
        public string Photo
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }
        public string Comment
        {
            set
            {
                throw new System.NotImplementedException();
            }
        }
        public int LikesAmount
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }
        public int DislikeAmount
        {
            get
            {
                throw new System.NotImplementedException();
            }
        }
        public Comment[] Comments
        {
            get
            {
                return comments;
            }
            set
            {
                comments = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(Comments)));
            }
        }
        public Comment SelectedComment
        {
            get
            {
                return selectedComment;
            }
            set
            {
                selectedComment = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(SelectedComment)));
            }
        }

        #region Commands
        /// <summary>
        /// Property that enable to interact with search command.
        /// </summary>
        /// <returns>Log In command.</returns>
        public RelayCommand WriteComment => writeComment;
        public RelayCommand LikeDislikePhoto => likeDislikePhoto;
        public RelayCommand DeleteComment => deleteComment;
        public RelayCommand LikeDislikeComment => likeDislikeComment;
        #endregion

        // CONSTRUCTORS
        /// <summary>
        /// Basic constructor without parameters.
        /// </summary>
        public PhotoVM()
        {
            #region Window Initialize
            photoWindow = null;
            #endregion

            #region Commands Initialize

            #endregion
        }

        // METHODS
        #region Commands
        private void WriteCommentMethod(object obj)
        {

        }

        private void LikeDislikePhotoMethod(object obj)
        {

        }

        private void DeleteCommentMethod(object obj)
        {

        }

        private void LikeDislikeCommentMethod(object obj)
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
