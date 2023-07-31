namespace ShellApp;

[QueryProperty(nameof(UserName),"userName")]
public partial class NewPage1 : ContentPage
{
    string _userName;
    public string UserName { get { return _userName; } set { _userName = value; lblUserName.Text = _userName; } }
    public NewPage1()
	{
		InitializeComponent();
	}
}