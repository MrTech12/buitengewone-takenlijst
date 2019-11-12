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
        int huidigeTakenIndex;

        //Variabelen voor het aantal taken + voltooide taken.
        int huidigeTakenCount;
        int voltooideTakenCount;

        public MainWindow()
        {
            InitializeComponent();
        }

        //Toevoegen van taken aan de 'huidigeTaken' List + weergeven in de dagen ListBox.
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

        //Taken verwijderen uit de ListBox + index verwijderen uit de 'huidigeTaken' List.
        private void verwijderenTaken()
        {
            if (lijstMaLB.SelectedIndex > -1)
            {
                huidigeTaken.RemoveAt(lijstMaLB.SelectedIndex);
                lijstMaLB.Items.Remove(lijstMaLB.SelectedItem);
                huidigeTakenIndex--;
                huidigeTakenCount--;
            }

            else if (lijstDiLB.SelectedIndex > -1)
            {
                huidigeTaken.RemoveAt(lijstDiLB.SelectedIndex);
                lijstDiLB.Items.Remove(lijstDiLB.SelectedItem);
                huidigeTakenIndex--;
                huidigeTakenCount--;
            }

            else if (lijstWoLB.SelectedIndex > -1)
            {
                huidigeTaken.RemoveAt(lijstWoLB.SelectedIndex);
                lijstWoLB.Items.Remove(lijstWoLB.SelectedItem);
                huidigeTakenIndex--;
                huidigeTakenCount--;
            }

            else if (lijstDoLB.SelectedIndex > -1)
            {
                huidigeTaken.RemoveAt(lijstDoLB.SelectedIndex);
                lijstDoLB.Items.Remove(lijstDoLB.SelectedItem);
                huidigeTakenIndex--;
                huidigeTakenCount--;
            }

            else if (lijstVrLB.SelectedIndex > -1)
            {
                huidigeTaken.RemoveAt(lijstVrLB.SelectedIndex);
                lijstVrLB.Items.Remove(lijstVrLB.SelectedItem);
                huidigeTakenIndex--;
                huidigeTakenCount--;
            }
            aantalTaakLB.Content = Convert.ToString(huidigeTakenCount);
        }

        //Taken voltooien + uit de listbox halen + toevoegen aan 'voltooideTaken' List.
        private void voltooiTaken()
        {
            if (lijstMaLB.SelectedIndex > -1)
            {
                voltooideTaken.Add(Convert.ToString(lijstMaLB.SelectedItem));
                lijstMaLB.Items.Remove(lijstMaLB.SelectedItem);
                huidigeTakenCount--;
                voltooideTakenCount++;
            }

            else if (lijstDiLB.SelectedIndex > -1)
            {
                voltooideTaken.Add(Convert.ToString(lijstDiLB.SelectedItem));
                lijstDiLB.Items.Remove(lijstDiLB.SelectedItem);
                huidigeTakenCount--;
                voltooideTakenCount++;
            }

            else if (lijstWoLB.SelectedIndex > -1)
            {
                voltooideTaken.Add(Convert.ToString(lijstWoLB.SelectedItem));
                lijstWoLB.Items.Remove(lijstWoLB.SelectedItem);
                huidigeTakenCount--;
                voltooideTakenCount++;
            }

            else if (lijstDoLB.SelectedIndex > -1)
            {
                voltooideTaken.Add(Convert.ToString(lijstDoLB.SelectedItem));
                lijstDoLB.Items.Remove(lijstDoLB.SelectedItem);
                huidigeTakenCount--;
                voltooideTakenCount++;
            }

            else if (lijstVrLB.SelectedIndex > -1)
            {
                voltooideTaken.Add(Convert.ToString(lijstVrLB.SelectedItem));
                lijstVrLB.Items.Remove(lijstVrLB.SelectedItem);
                huidigeTakenCount--;
                voltooideTakenCount++;
            }
            aantalTaakLB.Content = Convert.ToString(huidigeTakenCount);
            aantalVoltooiTaakLB.Content = Convert.ToString(voltooideTakenCount);
        }

        //Voltooide taken van de 'voltooideTaken' List tonen.
        private void toonAlleVoltooideTaken()
        {
            lijstVoltooiTakenLB.Items.Clear();

            //Foreach Loop om alle taken uit de 'voltooideTaken' List weer te geven.
            foreach (var afgevinkteTaken in voltooideTaken)
            {
                lijstVoltooiTakenLB.Items.Add(afgevinkteTaken);
            }

            //For Loop om alle taken uit de 'voltooideTaken' List weer te geven.
            /*
            for (int i = 0; i < voltooideTaken.Count; i++)
            {
                lijstVoltooiTakenLB.Items.Add(voltooideTaken.ElementAt(i));
            }
            */
        }

        private void taakToevoegBT_Click(object sender, RoutedEventArgs e)
        {
            toevoegenTaken();
        }

        private void taakAfvink_Click(object sender, RoutedEventArgs e)
        {
            voltooiTaken();
        }

        private void taakVerwijder_Click(object sender, RoutedEventArgs e)
        {
            verwijderenTaken();
        }

        private void toonVoltooiTaken_Click(object sender, RoutedEventArgs e)
        {
            toonAlleVoltooideTaken();
        }
    }
}
