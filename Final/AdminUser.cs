namespace Final
{
    public class AdminUser : User
    {
        public AdminUser(string name)
            : base(name, "admin")
        {
        }

        public override void OpenDashboard()
        {
            Admin adminForm = new Admin();
            adminForm.Show();
        }
    }
}
