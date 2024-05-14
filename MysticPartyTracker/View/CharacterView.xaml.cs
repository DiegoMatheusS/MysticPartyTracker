using MysticPartyTracker.Models;
using MysticPartyTracker.ViewModels;
using System.Xml.Linq;

namespace MysticPartyTracker.View;

public partial class CharacterView : ContentPage
{
	public CharacterView()
	{
		InitializeComponent();
        BindingContext = new CharacterViewModel();
    }

}