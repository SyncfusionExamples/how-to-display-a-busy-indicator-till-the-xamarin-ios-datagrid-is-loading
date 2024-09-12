using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;


namespace SampleApp
{
    public class ViewModel
    {
        ModelRepository repository;
        public ObservableCollection<Model> Collection { get; set; }
        public ViewModel()
        {
            repository = new ModelRepository();
            Collection = new ObservableCollection<Model>();
            PopulateItems();
        }
        public void PopulateItems()
        {
            Collection = repository.GenerateItems();
        }
    }
}