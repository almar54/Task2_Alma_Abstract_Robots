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

namespace Robots_inc
{
    /// <summary>
    /// Interaction logic for UCworker.xaml
    /// </summary>
    public partial class UCworker : UserControl
    {
        public UCworker(Worker worker)
        {
            InitializeComponent();
            this.DataContext = worker; //binding✅
            lbID.Content = worker.GetIdNumber();
            lbBday.Content = worker.GetBirthDate().ToShortDateString();
            if (worker.GetBirthDate().Month.Equals(DateTime.Today.Month) && worker.GetBirthDate().Day.Equals(DateTime.Today.Day))
            {
                lbBday.Content += " 🎂🎈🥳🍾";
            }
            if (worker is GeneralManager)
            {
                lbRole.Content = "General Manager";
                brMain.Background = Brushes.LightBlue;
                this.Foreground = Brushes.White;
                lbRole.FontWeight = FontWeights.Bold;
            }
            else if (worker is OperationManager)
            {
                lbRole.Content = "Operational Manager";
                brMain.Background = Brushes.LightCoral;
                this.Foreground = Brushes.White;
                lbRole.FontWeight = FontWeights.Bold;
            }
            else
            {
                lbRole.Content = "Operational Worker";
                brMain.Background = Brushes.Beige;
                this.Foreground = Brushes.White;
                lbRole.FontWeight = FontWeights.Bold;
            }
        }
    }
}
