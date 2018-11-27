using System;
using Models.Entities;

namespace ViewModel.ViewModels
{
    public class SettingsVM
    {
        // PROPERTIES
        User CurrUser { get; }
        string NewPass
        {
            set
            {

            }
        }
        string OldPass { get; }
        string NickName { get; }

        // METHODS
        public void Apply()
        {
            throw new NotImplementedException();
        }
        public void LoadNewPhoto()
        {
            throw new NotImplementedException();
        }
    }
}
