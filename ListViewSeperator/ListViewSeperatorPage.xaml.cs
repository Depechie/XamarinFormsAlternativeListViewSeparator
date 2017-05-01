using System.Collections.ObjectModel;
using ListViewSeparator.Models;
using ListViewSeparator.Services;
using Xamarin.Forms;

namespace ListViewSeparator
{
    public partial class ListViewSeparatorPage : ContentPage
    {
        private ObservableCollection<Person> _persons;
        public ObservableCollection<Person> Persons
        {
            get { return _persons; }
            set
            {
                _persons = value;
                OnPropertyChanged();
            }
        }

        public ListViewSeparatorPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            Persons = new ObservableCollection<Person>(DataService.GetPersons());
        }
    }
}