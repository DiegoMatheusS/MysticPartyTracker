using CommunityToolkit.Mvvm.ComponentModel;
using MysticPartyTracker.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Input;


namespace MysticPartyTracker.ViewModels
{
    public partial class SpellsViewModel : ObservableObject
    {

        private readonly RestService _restService;

        [ObservableProperty]
        private ObservableCollection<Result> _results = new ObservableCollection<Result>();


        public SpellsViewModel()
        {
            _restService = new RestService();
            CreateSpellsCommand = new Command(async () => await GetSpellsAsync());
 
        }

        
           
        public ICommand CreateSpellsCommand { get; } // pegar comando do botao


        public async Task GetSpellsAsync()
        {
            Results = await _restService.GetSpellsAsync();
        }

    }
}