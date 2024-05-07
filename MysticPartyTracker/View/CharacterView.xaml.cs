namespace MysticPartyTracker.View;

public partial class CharacterView : ContentPage
{
	public CharacterView()
	{
		InitializeComponent();
	}

    private void ButtonAdd_Clicked(object sender, EventArgs e)
    {
		string nome = NameCharacter.ToString();

		string nivel =NameNivel.ToString();

		string classe = NameClasse.ToString();

		string race = NameRace.ToString();


        LabelCharacter.Text = $"{nome}";

		LabelRace.Text = race;

		LabelClasse.Text = classe;

		LabelNivel.Text = nivel;
    }
}