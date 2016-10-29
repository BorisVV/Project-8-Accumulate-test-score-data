using System.Collections.Generic;
using System.Windows.Forms;

namespace AccumulateTestScoreData
{
    //this class is generated only for the List method and and the buttons.
    class ScoreListClass : Form
    {
        //This methos is used for unsorted button. 
        public static void UnsortedScores(List<int> unsortedScores)
        {
            string unsorted = "";
            for (int i = 0; i < unsortedScores.Count; i++)
            {
                unsorted += unsortedScores[i] + "\n";
            }
            if (unsortedScores.Count == 0) //Checks to see if list is empty, will display message.
            {
                MessageBox.Show("List is Empty", "Unsorted list of scores.");
            }
            else
                MessageBox.Show(unsorted, "Unsorted list of scores.");
        }

        //This method is used for sorted button.
        public static void SortedScores(List<int> sortedScores)
        {
            string sorted = "";
            for (int i = 0; i < sortedScores.Count; i++)
            {
                sorted += sortedScores[i] + "\n";
            }

            if (sortedScores.Count == 0)  //Checks to see if list is empty, will display message.
            {
                MessageBox.Show("List is Empty", "Unsorted list of scores.");
            }
            else
                MessageBox.Show(sorted, "Sorted list of scores.");
        }
    }
}
