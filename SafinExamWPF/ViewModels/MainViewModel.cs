using SafinExamWPF.Model;
using SafinExamWPF.ViewModels;
using SafinExamWPF.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SafinExamWPF
{
    public class MainViewModel : INotifyPropertyChanged
    {
        ListItemsView listView;
        DictionaryView dictionaryView;

        Page _currentPage;
        public Page CurrentPage
        {
            get => _currentPage;
            set
            {
                _currentPage = value;
                OnPropertyChanged();
            }
        }

        double _frameOpacity;
        public double FrameOpacity
        {
            get => _frameOpacity;
            set
            {
                _frameOpacity = value;
                OnPropertyChanged();
            }
        }

        RelayCommand _selectedPageCommand;
        public RelayCommand SelectedPageCommand
        {
            get => _selectedPageCommand ??
                (_selectedPageCommand = new RelayCommand((obj) =>
                {
                    if (obj != null)
                    {
                        switch (((ListViewItem)((ListView)obj).SelectedItem).Name)
                        {
                            case "ItemList":
                                SlowOpacity(listView);
                                break;
                            case "ItemDictionary":
                                SlowOpacity(dictionaryView);
                                break;
                            default:
                                break;
                        }
                    }
                }));
        }

        private async void SlowOpacity(Page page)
        {
            await Task.Factory.StartNew(() =>
            {
                for (double i = 1.0; i > 0; i -= 0.01)
                {
                    FrameOpacity = i;
                    Thread.Sleep(1);
                }
                CurrentPage = page;
                Thread.Sleep(100);
                for (double i = 0; i < 1.1; i += 0.01)
                {
                    FrameOpacity = i;
                    Thread.Sleep(1);
                }
            });
        }


        public MainViewModel()
        {
            listView = new ListItemsView();
            dictionaryView = new DictionaryView();

            SlowOpacity(listView);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}
