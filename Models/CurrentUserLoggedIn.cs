namespace BlazorTest100.Models
{
    public class CurrentUserLoggedIn
    {
        public UserEntity? _userData { get; set; }
        public UserProfileEntity? _userProfileData { get; set; }
        public async Task<UserEntity> GetMyObjectAsync()
        {
            if (_userData == null)
            {
                // If the object hasn't been created yet, create it here
                _userData = await CreateMyObjectAsync();
            }

            return _userData;
        }
        public async Task<UserProfileEntity> GetMyObjectAsyncTwo()
        {
            if (_userProfileData == null)
            {
                // If the object hasn't been created yet, create it here
                _userProfileData = await CreateMyObjectAsyncTwo();
            }

            return _userProfileData;
        }
        private async Task<UserEntity> CreateMyObjectAsync()
        {
            // Create the object here
            var userEntity = new UserEntity();

            // Perform any necessary initialization

            return userEntity;
        }
        private async Task<UserProfileEntity> CreateMyObjectAsyncTwo()
        {
            // Create the object here
            var userProfileEntity = new UserProfileEntity();

            // Perform any necessary initialization

            return userProfileEntity;
        }
        //public event Action OnStateChange;
        //public void SetCurrentUserData(UserEntity userData)
        //{
        //    this._userData = userData;
        //    NotifyStateChanged();
        //}
        //private void NotifyStateChanged() => OnStateChange?.InvokeAsync();

    }
}
