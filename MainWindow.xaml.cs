using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Builder;

namespace PR7
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Создаем экземпляр класса Builder из библиотеки
                Builders builder = new Builders();

                // Вызываем метод PasteWallpaper из библиотеки с тестовыми параметрами
                int rollsNeeded = builder.PasteWallpaper(
                    roomWidth: 5,
                    roomLength: 4,
                    roomHeight: 2.7,
                    windowWidth: 1.5,
                    windowHeight: 1.2,
                    doorWidth: 0.9,
                    doorHeight: 2.1,
                    rollWidth: 1
                );

                // Показываем результат пользователю
                MessageBox.Show($"Для оклейки комнаты потребуется: {rollsNeeded} рулонов обоев",
                                "Результат расчета",
                                MessageBoxButton.OK,
                                MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}",
                                "Ошибка",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
            }
        }
    }
}
