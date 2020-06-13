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
    public class ListItemsViewModel : INotifyPropertyChanged
    {
        static private List<Box> _boxes;
        private List<Box> _currentBoxes;
        private int _sorterLenght;
        /// <summary>
        /// Коллекция коробок
        /// </summary>
        static public List<Box> Boxes
        {
            get => _boxes;
            set
            {
                _boxes = value;
            }
        }

        /// <summary>
        /// Длина для сортировки коробок
        /// </summary>
        public int SorterLenght
        {
            get => _sorterLenght;
            set
            {
                _sorterLenght = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Текущие коробки, которые установлены для таблицы
        /// </summary>
        public List<Box> CurrentBoxes
        {
            get => _currentBoxes;
            set
            {
                _currentBoxes = value;
                OnPropertyChanged();
            }
        }

        RelayCommand _filterCommand;
        /// <summary>
        /// Команда сортировки
        /// </summary>
        public RelayCommand FilterCommand
        {
            get => _filterCommand ??
                (_filterCommand = new RelayCommand((obj) =>
                {
                    FilterContacts();
                }));
        }


        RelayCommand _resetFilterCommand;
        /// <summary>
        /// Команда сброса сортировки
        /// </summary>
        public RelayCommand ResetFilterCommand
        {
            get => _resetFilterCommand ??
                (_resetFilterCommand = new RelayCommand((obj) =>
                {
                    CurrentBoxes = Boxes;
                }));
        }

        /// <summary>
        /// Фильтрует контакты по условиям
        /// </summary>
        private async void FilterContacts()
        {
            await Task.Factory.StartNew(() =>
            {
                List<Box> filterBoxes = new List<Box>();
                foreach (var item in Boxes)
                {
                    if (item.Length == SorterLenght)
                    {
                        filterBoxes.Add(item);
                    }
                }
                CurrentBoxes = filterBoxes;
            });
        }

        public ListItemsViewModel()
        {
            Boxes = new List<Box>();

            Boxes.Add(new Box { Number = "YY-21-21", Length=13, Width=40, Weight = 14});
            Boxes.Add(new Box { Number = "YY-22-21", Length = 13, Width = 90, Weight = 14 });
            Boxes.Add(new Box { Number = "YY-23-21", Length = 132, Width = 430, Weight = 14 });
            Boxes.Add(new Box { Number = "YY-24-21", Length = 13, Width = 420, Weight = 14 });
            Boxes.Add(new Box { Number = "YY-25-21", Length = 113, Width = 40, Weight = 14 });
            Boxes.Add(new Box { Number = "YSY-26-pa-21", Length = 413, Width = 740, Weight = 14 });

            CurrentBoxes = Boxes;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string prop = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}
