namespace Synaptica.Services
{
    public class SessionService
    {
        // this may be tanken out or added to based off if we display user details
        public int? LoggedInUser { get; set; }

        public SessionService() {
            // TEMP: Hardcoded user session
            this.LoggedInUser = null;
        }

        public void SetLoggedInUser(int userId)
        {
            LoggedInUser = userId;
        }
    }
}
