using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AccumulateTestScoreData
{
    class MethodsClass
    {
   
        //lbl score total method.
        public static void ScoreTotal(Label lbl_ScoreTotal, int scoreTotal, int score)
        {   
            lbl_ScoreTotal.Text = scoreTotal.ToString();
        }

        //lbl avarage method.
        public static void Average(Label lbl_Average, int scoreTotal, int count)
        {
            lbl_Average.Text = (scoreTotal / count).ToString();
        }

        //This method clears all the txt's and lbl's that hold values in the main form.
        internal static void Txt_Lbl_Emptied(TextBox txt_Score, Label lbl_Average,
            Label lbl_ScoreCount, Label lbl_ScoreTotal, Label lbl_MaxScore, Label lbl_MinScore)
        {
            txt_Score.Text = String.Empty;
            lbl_Average.Text = String.Empty;
            lbl_ScoreCount.Text = String.Empty;
            lbl_ScoreTotal.Text = String.Empty;
            lbl_MaxScore.Text = String.Empty;
            lbl_MinScore.Text = String.Empty;
        }

        //This method clears all the variables that hold values in the main form.
        public static void ValuesToZero(List<int> unsortedScores, List<int> sortedScores)
        {
            unsortedScores.Clear();
            sortedScores.Clear();
        }

    }
}
