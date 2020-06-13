using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Security.Permissions;
using System.Windows;

namespace SafinExamWPF.Model
{
    public class Box : INotifyPropertyChanged
    {
        private string _number;
        private int _width;
        private int _weight;
        private int _length;
        private event Action _megaEvent;

        /// <summary>
        /// Номер
        /// </summary>
        public string Number 
        { 
            get => _number;
            set
            {
                if (CheckNumber(value))
                {
                    _number = value;
                    OnPropertyChanged();
                }
                else
                {
                    MessageBox.Show("Вы ввели неккоректный формат номера");
                }
            }
        }

        /// <summary>
        /// Ширина
        /// </summary>
        public int Width
        {
            get => _width;
            set
            {
                _width = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Вес
        /// </summary>
        public int Weight
        {
            get => _weight;
            set
            {
                try
                {
                    if (value < 14)
                    {
                        throw new Exception("Вес меньше 14. Автоматический установлен минимально доступный вес!");
                    }
                    else if(value > 14)
                    {
                        _megaEvent?.Invoke();
                    }
                    _weight = value;
                    OnPropertyChanged();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    _weight = 14;
                }
            }
        }

        /// <summary>
        /// Длина
        /// </summary>
        public int Length
        {
            get => _length;
            set
            {
                _length = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Проверка корректности номера телефона
        /// </summary>
        /// <param name="number">Введенный номер телефона</param>
        /// <returns>True - корректно, False - неккоректно</returns>
        private bool CheckNumber(string number)
        {
            string strPattern1 = @"^([a-z]|[A-Z]){3}-([\d]){2}-([a-z]|[A-Z]){2}-([\d]){2}$";
            string strPattern2 = @"^([a-z]|[A-Z]){2}-([\d]){2}-([\d]){2}$";

            if (Regex.IsMatch(number, strPattern1) || Regex.IsMatch(number, strPattern2))
                return true;
            return false;
        }

        public Box(string number, int width, int weight, int lenght)
        {
            Number = number;
            Width = width;
            Weight = weight;
            Length = lenght;
        }

        public Box()
        {
            _megaEvent += Box__megaEvent;
        }

        private void Box__megaEvent()
        {
            MessageBox.Show("Масса больше 14!!!");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string prop = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}
