namespace Final 
{
    public class FarmerUser : User
    {
        public FarmerUser(string name)
            : base(name, "farmer")
        {
        }

        public override void OpenDashboard()
        {
            Farmer farmerForm = new Farmer();
            farmerForm.Show();
        }
    }
}
