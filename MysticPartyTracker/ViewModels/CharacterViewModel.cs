using CommunityToolkit.Mvvm.ComponentModel;
using MysticPartyTracker.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MysticPartyTracker.ViewModels
{
    public partial class CharacterViewModel : ObservableObject //partial para observar o que tem na view
    {
        public CharacterViewModel() //construtor
        {
            
            CreateCharacterCommand = new Command(Add); // colocar o nome do metodo, para utilizar
        }

        [ObservableProperty] 
        public string _name;

        [ObservableProperty]
        public string _classe;

        [ObservableProperty]
        public int _nivel;

        [ObservableProperty]
        public string _race;

        private ObservableCollection<Character> _characters = new ObservableCollection<Character>();  //cria colecao de uma lista
        public ObservableCollection<Character> Characters
        {
            get { return _characters; }
            set { _characters = value; }
        }



        public ICommand CreateCharacterCommand { get; } //pegar comando do botao

        public void Add()
        {
            Character character = new Character(Name, Classe, Nivel, Race);
            _characters.Add(character);

            //_characters.Add(new Character(Name, Classe, Nivel, Race)); outro jeito de fazer
            
        }

    }
}
