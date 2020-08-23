namespace Common.Helpers
{
    using Xamarin.Essentials;

    public static class Settings
    {
        private const string token = "token";
        private const string userEmail = "userEmail";
        private const string userPassword = "userPassword";
        private const string isRemember = "isRemember";
        private const string username = "userName";
        private const string userid = "userId";
        private const string userimage = "UserImage";
        private static readonly string stringDefault = string.Empty;
        private static readonly bool boolDefault = false;

        public static string UserName
        {
            get => Preferences.Get(username, stringDefault);
            set => Preferences.Set(username, value);
        }

        public static string UserImage
        {
            get => Preferences.Get(userimage, stringDefault);
            set => Preferences.Set(userimage, value);
        }

        public static int UserId
        {
            get => Preferences.Get(userid, 0);
            set => Preferences.Set(userid, value);
        }

        public static string Token
        {
            get => Preferences.Get(token, stringDefault);
            set => Preferences.Set(token, value);
        }

        public static string UserEmail
        {
            get => Preferences.Get(userEmail, stringDefault);
            set => Preferences.Set(userEmail, value);
        }

        public static string UserPassword
        {
            get => Preferences.Get(userPassword, stringDefault);
            set => Preferences.Set(userPassword, value);
        }

        public static bool IsRemember
        {
            get => Preferences.Get(isRemember, boolDefault);
            set => Preferences.Set(isRemember, value);
        }
    }


}
