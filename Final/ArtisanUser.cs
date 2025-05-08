namespace Final
{
    public class ArtisanUser : User
    {
        public ArtisanUser(string name)
            : base(name, "artisan")
        {
        }

        public override void OpenDashboard()
        {
            Artisan artisanForm = new Artisan();
            artisanForm.Show();
        }
    }
}
