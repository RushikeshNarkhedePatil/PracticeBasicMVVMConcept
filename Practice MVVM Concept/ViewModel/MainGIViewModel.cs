using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_MVVM_Concept.ViewModel
{
    internal class MainGIViewModel: BindableBase
    {
        public MainGIViewModel()
        {
            AddDataCommand = new DelegateCommand(AddData);
            ClearDataCommand = new DelegateCommand(ClearData);
            Information =new ObservableCollection<string>();
        }

        private void ClearData()
        {
            Information.Clear();
        }

        private void AddData()
        {
            Information.Add(FirstName);
            Information.Add(LastName);
            Information.Add(City);
            Information.Add(Pincode);
        }

        public DelegateCommand AddDataCommand { get; private set; }
        public DelegateCommand ClearDataCommand { get; private set; }

        private ObservableCollection<string> _Information;
        public ObservableCollection<string> Information
        {
            get { return _Information; }
            set
            {
                SetProperty(ref _Information, value);
            }
        }

        private string _City;
        private string _LastName;
        private string _FirstName;
        private string _Pincode;
        public string FirstName
        {
            get { return _FirstName; }
            set
            {
                SetProperty(ref _FirstName, value);
            }
        }

        public string LastName
        {
            get { return _LastName; }
            set
            {
                SetProperty(ref _LastName, value);
            }
        }

        public string City
        {
            get { return _City; }
            set
            {
                SetProperty(ref _City, value);
            }
        }

        public string Pincode
        {
            get { return _Pincode; }
            set
            {
                SetProperty(ref _Pincode, value);
            }
        }

    }
}
