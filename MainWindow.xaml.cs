/* Dominic Langowski
 * Feburay 11 2020
 * Learning how to use Strings */
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

namespace StringExample
{
    /// <summary>
    /// Run what button pressed, deals with strings
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void btnRun_Click(object sender, RoutedEventArgs e)
        {
            // Declare Variables and assign a valuye
            string student = "McTavish,Ian,123456";
            int positionOffFirstComma = -1;
            int positionOffSecondComma = -1;
            string firstName;
            string lastName;
            string studentNumber;
           

            lblOutput.Content = student;

            //Get the first name
            positionOffFirstComma = student.IndexOf(",");
            MessageBox.Show(positionOffFirstComma.ToString());    //For the first Comma


            positionOffSecondComma = student.IndexOf(",", positionOffFirstComma + 1);
            MessageBox.Show(positionOffSecondComma.ToString());  //For the second Comma

            firstName = student.Substring(positionOffFirstComma + 1,
                positionOffSecondComma - (positionOffFirstComma+1));
            lastName = student.Substring(0, positionOffFirstComma);     //get last name
            studentNumber = student.Substring(positionOffSecondComma + 1);  //get student number i
            MessageBox.Show(studentNumber);                                 //ii

            //MessageBox.Show(firstName);

            //Output

            lblOutput.Content = student + Environment.NewLine;
            lblOutput.Content += firstName + firstName;

            lblOutput.Content += lastName;

            lblOutput.Content += studentNumber + "@tldsb.me";






        }
    }
}
