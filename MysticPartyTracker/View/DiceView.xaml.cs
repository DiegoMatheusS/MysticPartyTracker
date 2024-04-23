using MysticPartyTracker.Models;

namespace MysticPartyTracker.View;

public partial class DiceView : ContentPage
{
	public DiceView()
	{
		InitializeComponent();
        SidesPicker.SelectedIndex = 0;
        SidesPickerSecond.SelectedIndex = 0;
    }
	private void RollBtn_Clicked(object sender, EventArgs e)
	{
        //Instanciação de um novo objeto dice do tipoc Dice, atraves do construtor Dice()
        int sidesNumnber = Convert.ToInt32(SidesPicker.SelectedItem);
        Dice dice = new Dice(sidesNumnber);
        ResultLabel.Text = Convert.ToString(dice.Side());

        try
        {
            int numberSiders = (int)SidesPicker.SelectedItem;
            int quantity = (int)SidesPickerSecond.SelectedItem;

            Dice side = new(numberSiders);

            string finalResult = "";
            int total = 0;
            for (int i = 0; i < quantity; i++)
            {
                int roll = dice.Side();
                total +=
            }
        }

    }
}