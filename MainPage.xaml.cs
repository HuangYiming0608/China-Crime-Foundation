namespace China_Crime_Foundation
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        const int sum=8;
        string[] arr = { "€€£，毒瘤！", "€€£，狗！", "€€£，狗屎！", "€€£，狗屎都不如！", "€€£,f**k you!", "去**的€€£！", "€€£，大**！", "€€£，反革命！" };
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            CounterBtn.Text = arr[count%sum];

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
