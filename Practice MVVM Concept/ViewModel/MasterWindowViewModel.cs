using MySqlConnector;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_MVVM_Concept.ViewModel
{
    internal class MasterWindowViewModel : BindableBase
    {
        private string _title;
        private string _description;
        string conectionString = @"SERVER=127.0.0.1;Database=demo;Uid=root;Pwd=toor;";
        public DelegateCommand SaveCommand { get; private set; }
        public MasterWindowViewModel() 
        {
            SaveCommand = new DelegateCommand(SaveData);
        }

        private void SaveData()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(conectionString))
            {
                mysqlCon.Open();

                MySqlCommand mysqlCmd = new MySqlCommand("BookAddOrEdit", mysqlCon);
                mysqlCmd.CommandText = $"Insert into basicInfo(Name,Address) Values('{Title}','{Description}')";
                mysqlCmd.ExecuteNonQuery();
            }
        }

        public string Title
        {
            get { return _title; }
            set
            { 
                SetProperty(ref _title, value);
                //if(value!=null)
                //{
                //    Description = value;
                //}
            }
        }
        public string Description
        {
            get { return _description; }
            set
            {
                SetProperty(ref _description, value);
            }
        }
    }
}
