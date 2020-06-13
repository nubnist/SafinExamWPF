using SafinExamWPF.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SafinExamWPF.ViewModels
{
    public class DictionaryViewModel : INotifyPropertyChanged
    {
        private Dictionary<string, Box> _boxes;
        private string _number;
        private int _width;
        private int _weight;
        private int _length;
        private string _searchNumber;
        private Box _currentBox;

        /// <summary>
        /// Номер для поиска
        /// </summary>
        public string SearchNumber
        {
            get => _searchNumber;
            set
            {
                _searchNumber = value;
                OnPropertyChanged();
            }
        }

        public string Number
        {
            get => _number;
            set
            {
                _number = value;
                _currentBox.Number = value;
                OnPropertyChanged();
            }
        }

        public int Width
        {
            get => _width;
            set
            {
                _width = value;
                _currentBox.Width = value;
                OnPropertyChanged();
            }
        }

        public int Weight
        {
            get => _weight;
            set
            {
                _weight = value;
                _currentBox.Weight = value;
                OnPropertyChanged();
            }
        }

        public int Length
        {
            get => _length;
            set
            {
                _length = value;
                _currentBox.Length = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Словарь коробок
        /// </summary>
        public Dictionary<string, Box> Boxes
        {
            get => _boxes;
            set
            {
                _boxes = value;
                OnPropertyChanged();
            }
        }

        private RelayCommand _searchBoxCommand;
        public RelayCommand SearchBoxCommand
        {
            get => _searchBoxCommand ??
                (new RelayCommand((obj) => 
                {
                    if (Boxes.TryGetValue(SearchNumber, out _currentBox))
                    {
                        Number = _currentBox.Number;
                        Width = _currentBox.Width;
                        Weight = _currentBox.Weight;
                        Length = _currentBox.Length;
                    }
                }));
        }

        public DictionaryViewModel()
        {
            _currentBox = new Box();
            _boxes = new Dictionary<string, Box>();
            foreach (var item in ListItemsViewModel.Boxes)
            {
                Boxes.Add(item.Number, item);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string prop = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}
