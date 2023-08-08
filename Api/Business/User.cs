public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }

    // Add other necessary methods here
    public void UpdateData(string address, string phoneNumber)
    {
        this.Address = address;
        this.PhoneNumber = phoneNumber;
    }
}