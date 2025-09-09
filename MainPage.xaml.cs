namespace tp01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async Task AnimateButton(Button button)
        {
            var originalColor = button.BackgroundColor;
            button.BackgroundColor = Color.FromArgb("#555");

            await button.ScaleTo(0.96, 80, Easing.CubicOut);
            await button.ScaleTo(1, 80, Easing.CubicIn);

            button.BackgroundColor = originalColor;
        }



        private async void OnLimparClicked(object sender, EventArgs e)
        {
            await AnimateButton((Button)sender);

            entryID.Text = string.Empty;
            entryPass.Text = string.Empty;
            entryID.Focus();
        }

        private async void OnLogarClicked(object sender, EventArgs e)
        {
            await AnimateButton((Button)sender);

            string id = entryID.Text?.Trim();
            string pass = entryPass.Text?.Trim();

            if (id == "admin" && pass == "senha@dmin")
            {
                await DisplayAlert("Sucesso", "Logou com sucesso!", "OK");
            }
            else
            {
                await DisplayAlert("Erro", "Login não autorizado.", "OK");
            }
        }

        private async void OnCredClicked(object sender, EventArgs e)
        {
            await AnimateButton((Button)sender);

            string autores = "CRIADO POR CAUÃ BARROS E EDUARDO MIRANDA";
            await DisplayAlert("Créditos", autores, "OK");
        }
    }
}
