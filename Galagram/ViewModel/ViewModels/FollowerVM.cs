using System;
using Models.Entities;

namespace ViewModel.ViewModels
{
    class FollowerVM
    {
        // PROPERTIES
        User SelectedFollower { get; set; }
        User[] Users { get; set; }

        // METHODS
        public void Unfollow()
        {
            throw new NotImplementedException();
        }

    }
}
