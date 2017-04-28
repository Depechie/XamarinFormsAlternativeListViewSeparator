using System.Collections.ObjectModel;
using ListViewSeperator.Models;
using ListViewSeperator.Services;
using Xamarin.Forms;

namespace ListViewSeperator
{
    public partial class ListViewSeperatorPage : ContentPage
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

        public ListViewSeperatorPage()
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