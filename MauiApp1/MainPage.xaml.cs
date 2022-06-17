namespace MauiApp1;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";
		
		SemanticScreenReader.Announce(CounterBtn.Text);
	}

	private async void popupBtn_Clicked(object sender, EventArgs e)
	{
		count++;
        CounterBtn.Text = $"Clicked {count} times";
		CounterBtn.WidthRequest = 500;
		input1.Focus();
		CounterBtn.Focus();
		img1.HeightRequest = 100;
		img1.WidthRequest = 100;

        //await DisplayAlert("This is the best ALERT", "How cool is MAUI technology!!", "OKKK!!");
        //string s = await DisplayPromptAsync("Title", "messgaaaaaaa");

        //string s2 = await DisplayActionSheet("Your hobbies", "cancel!!!", "destroy", "food", "water", "chess", "movie");
    }
}

