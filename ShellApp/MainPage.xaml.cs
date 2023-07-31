namespace ShellApp;

public partial class MainPage : ContentPage
{


	public MainPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync($"{nameof (NewPage1)}?userName={EntUser.Text}");
    }
}

