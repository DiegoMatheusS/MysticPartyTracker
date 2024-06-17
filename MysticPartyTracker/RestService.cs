using MysticPartyTracker.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MysticPartyTracker
{
    class RestService
    {
        HttpClient _client;
        JsonSerializerOptions _serializerOptions;

        public ObservableCollection<Result> Count { get; set; }

        public RestService()
        {
            Count = null;
            _client = new HttpClient();//instaciei  _client
            _serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true,

            };
         }
        public async Task<ObservableCollection<Result>> GetSpellsAsync()//Tarefa = 'Task'// É uma lista que devolve 
        {
            Uri uri = new Uri("https://www.dnd5eapi.co/api/spells");// onde vou buscar informação "endereço" 'URL'

            try
            {
                HttpResponseMessage response = await _client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    Count = JsonSerializer.Deserialize<ObservableCollection<Result>>(content, _serializerOptions);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            return Count ?? [];
        }
    }
 }

