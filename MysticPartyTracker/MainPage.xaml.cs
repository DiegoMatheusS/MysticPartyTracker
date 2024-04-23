namespace MysticPartyTracker
{
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
                CounterBtn.Text = $"Corinthians tem  {count} Mundial";
            else
                CounterBtn.Text = $"Corinthians tem {count} Mundiais";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
