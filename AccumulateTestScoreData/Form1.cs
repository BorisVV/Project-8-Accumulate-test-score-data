/*
 * BorisV
 * ITEC 2505-01 Visual C#.NET Programming
 * Project 8-1:  Accumulate test score data 
 * With Enhancement*******
 * October 25, 2016
 */

using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace AccumulateTestScoreData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //This variables are for to store data outside the methods.

        //private static int newMin = 0;
        private static int score = 0;
        private static int count = 0;
        private static int scoreTotal = 0;

        //There two List var because the one will always sort and would not go back to unsorted once sorted.
        private static List<int> unsortedScores = new List<int>();  //This is to make the array list and store the scores.
        private static List<int> sortedScores = new List<int>(); //This stores the scores to later sort them.

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (IsValid()) //If the data is valid th App continues, else it will show a message.
            {
                            
                score = Convert.ToInt32(txt_Score.Text);

                count++;  //Keeps adding the number of time a new number is added.

                scoreTotal += score;



                //Total score method
                MethodsClass.ScoreTotal(lbl_ScoreTotal, scoreTotal, score);

                //Average score method, //sum of scoreTotal is divided by the new count total number.
                MethodsClass.Average(lbl_Average, scoreTotal, count);


                unsortedScores.Add(score);  //This line adds the new score to the ArrayList and stores it.
                sortedScores.Add(score); //This adds to the list to sort.

                lbl_ScoreCount.Text = count.ToString(); //This display the count of scores that have been entered.

                sortedScores.Sort(); //The list is sorted to keep track of the min and max numbers.

                //Everytime a new score is entered the lables display their respective data out for Min and Max.
                lbl_MinScore.Text = sortedScores[0].ToString();
                lbl_MaxScore.Text = sortedScores[sortedScores.Count - 1].ToString();

                txt_Score.Focus(); //Set focus back to score box.
                txt_Score.Text = String.Empty; //Sets the score box back to empty.l
            }
        }

        //Methods that checks for data validation
        private bool IsValid()
        {
            return
            ValidationClass.IsPresent_Int32_OutRange(txt_Score, "score");
        }


        //Clear all entries.
        private void btn_ClearScores_Click(object sender, EventArgs e)
        {
            //Clears all the entries in the txt and lbl boxes.
            MethodsClass.ValuesToZero(unsortedScores, sortedScores);
            score = 0;
            count = 0;
            scoreTotal = 0;
            MethodsClass.Txt_Lbl_Emptied(txt_Score, lbl_Average, lbl_ScoreCount, lbl_ScoreTotal,
                lbl_MaxScore, lbl_MinScore);

            txt_Score.Focus();
        }


        //The unsorted button calls the method in the ScoreListClass class to order the list.
        private void btn_UnsortedList_Click(object sender, EventArgs e)
        {
            ScoreListClass.UnsortedScores(unsortedScores);
        }

        //The sorted button calls the method in the ScoreListClass class to order the list.
        private void btn_SortedScores_Click(object sender, EventArgs e)
        {
            sortedScores.Sort();
            ScoreListClass.SortedScores(sortedScores);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {           //Display a message with a 'yes' and a 'no' button.
            DialogResult result = MessageBox.Show("Are you sure? \nClick 'yes' to Exit. \nClick 'no' to return.", "Exit",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //End of public partial class Form1 : Form
    }
} 
