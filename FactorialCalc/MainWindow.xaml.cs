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

namespace FactorialCalc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void xCalculateBtn_Click(object sender, RoutedEventArgs e)
        {

            Factorial();
            Permutations();
            Combinations();

        }

        public void Factorial()
        {
            double number = 0;
            int factorial = 1;
            Double.TryParse(xNumber.Text, out number);

            // Forumala to determine Factorial
            for (int x = 1; x <= number; x++)
            {
                factorial = factorial * x;
            }

            // Display Answer
            xResponeBlock.Text = ($"{number}! =");
            xResponeBlock.FontSize = 24;
            xAnswerBlock.Text = factorial.ToString();
        }


        public void Permutations()
        {
            
            Double N;
            Double n = 1;
            Double R;
            Double r = 1;
            Double perm;
            Double nr = 1;

            N = Convert.ToInt32(xNObjects.Text);
            R = Convert.ToInt32(xRSample.Text);

            for (int x = 1; x <= N; x++)
            {
                n = n * x;
            }

            for (int x = 1; x <= R; x++)
            {
                r = r * x;
            }

            for (int x = 1; x <= (N - R); x++)
            {
                nr = nr * x;
            }

            perm = n/nr;

            xPermutationAnswer.Text = Convert.ToString(perm);

        }

        public void Combinations()
        {
           
            Double N;
            Double n = 1;
            Double R;
            Double r = 1;
            Double perm;
            Double nr = 1;

            N = Convert.ToInt32(xNObjects.Text);
            R = Convert.ToInt32(xRSample.Text);

            for (int x = 1; x <= N; x++)
            {
                n = n * x;
            }

            for (int x = 1; x <= R; x++)
            {
                r = r * x;
            }

            for (int x = 1; x <= (N - R); x++)
            {
                nr = nr * x;
            }

            perm = n / (r * nr);

            xCombinationAnswer.Text = Convert.ToString(perm);

        }


        private void xExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
