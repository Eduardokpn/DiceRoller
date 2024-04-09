namespace DiceRoller
{
    public partial class MainPage : ContentPage
    {
        int valor = 0;

        public MainPage()
        {
            InitializeComponent();
            SlidesPicker.SelectedIndex = 0;
        }

 
        private void RollBtn_Clicked(System.Object sender, System.EventArgs e)
        {
            valor = Convert.ToInt32(SlidesPicker.SelectedItem);
            int valorSorteado = 0;
            valorSorteado = new Random().Next(1, valor +1);

            Result.Text = valorSorteado.ToString();

            
        }
    }

}
