using CommunityToolkit.Mvvm.ComponentModel;
using MysticPartyTracker.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MysticPartyTracker.DiceViewModels
{
    public partial class DiceViewModel : ObservableObject //deverá ter partial para observar o que tem na view
    {
        public DiceViewModel()  //construtor
        {
            RollCommand = new Command(Roll);
        }



        [ObservableProperty]
        public int _numberSides; //propriedade //so pode pegar se herdar

        [ObservableProperty]
        public int _quantity;

        [ObservableProperty]
        public int _total; //_ 0SERVE PARA SER NUMBER


        private ObservableCollection<int> _rolls = new ObservableCollection<int>();  //cria colecao de uma lista
        public ObservableCollection<int> Rolls
        {
            get { return _rolls; }
            set { _rolls = value; }
        }


        public ICommand RollCommand { get; } // vai pegar o comando do botao aqui

        public void Roll()
        {
            Rolls.Clear(); // para limpar a lista
            Total = 0;
            Dice dice = new Dice(NumberSides); //criando dado

            for(int i = 0; i < Quantity; i++) //rolando dado
            {
                int roll = dice.Roll();      //pegando rolar dado do model Dice
                Rolls.Add(roll);
                Total += roll;  //jogando resultado no total

            }
        }
        

    }
}
