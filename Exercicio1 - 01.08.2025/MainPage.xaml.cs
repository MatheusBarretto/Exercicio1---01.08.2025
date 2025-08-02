namespace Exercicio1___01._08._2025
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnAddClicked(object? sender, EventArgs e)
        {
            int n1 = Convert.ToInt16(txtV1.Text);
            int n2 = Convert.ToInt16(txtV2.Text);
            int result = n1 + n2;
            DisplayAlert("Alert", Convert.ToString(result), "OK");
        }
        private void OnSubClicked(object? sender, EventArgs e)
        {
            int n1 = Convert.ToInt16(txtV1.Text);
            int n2 = Convert.ToInt16(txtV2.Text);
            int result = n1 - n2;
            DisplayAlert("Alert", Convert.ToString(result), "OK");
        }
        private void OnMultClicked(object? sender, EventArgs e)
        {
            int n1 = Convert.ToInt16(txtV1.Text);
            int n2 = Convert.ToInt16(txtV2.Text);
            int result = n1 * n2;
            DisplayAlert("Alert", Convert.ToString(result), "OK");
        }
        private void OnDivClicked(object? sender, EventArgs e)
        {
            int n1 = Convert.ToInt16(txtV1.Text);
            int n2 = Convert.ToInt16(txtV2.Text);
            int result = n1 / n2;
            DisplayAlert("Alert", Convert.ToString(result), "OK");
        }
    }
}
