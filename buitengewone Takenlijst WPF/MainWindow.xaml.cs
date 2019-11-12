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

namespace buitengewone_Takenlijst_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Lists + variabelen voor de listindex.
        List<string> huidigeTaken = new List<string>();
        List<string> voltooideTaken = new List<string>();
        int huidigeTakenIndex = 0;

        //Variabelen voor het aantal taken + voltooide taken.
        int huidigeTakenCount;
        int voltooideTakenCount = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void toevoegenTaken()
        {
            string gebruikersInvoer = userInputTB.Text;

            if (selectDagCB.SelectedIndex == 0)
            {
                huidigeTaken.Add(gebruikersInvoer);
                lijstMaLB.Items.Add(huidigeTaken.ElementAt(huidigeTakenIndex));
                huidigeTakenIndex++;
                huidigeTakenCount++;
            }

            else if (selectDagCB.SelectedIndex == 1)
            {
                huidigeTaken.Add(gebruikersInvoer);
                lijstDiLB.Items.Add(huidigeTaken.ElementAt(huidigeTakenIndex));
                huidigeTakenIndex++;
                huidigeTakenCount++;
            }

            else if (selectDagCB.SelectedIndex == 2)
            {
                huidigeTaken.Add(gebruikersInvoer);
                lijstWoLB.Items.Add(huidigeTaken.ElementAt(huidigeTakenIndex));
                huidigeTakenIndex++;
                huidigeTakenCount++;
            }

            else if (selectDagCB.SelectedIndex == 3)
            {
                huidigeTaken.Add(gebruikersInvoer);
                lijstDoLB.Items.Add(huidigeTaken.ElementAt(huidigeTakenIndex));
                huidigeTakenIndex++;
                huidigeTakenCount++;
            }

            else if (selectDagCB.SelectedIndex == 4)
            {
                huidigeTaken.Add(gebruikersInvoer);
                lijstVrLB.Items.Add(huidigeTaken.ElementAt(huidigeTakenIndex));
                huidigeTakenIndex++;
                huidigeTakenCount++;
            }
            aantalTaakLB.Content = Convert.ToString(huidigeTakenCount);
        }

        private void taakToevoegBT_Click(object sender, RoutedEventArgs e)
        {
            toevoegenTaken();
        }
    }
}
