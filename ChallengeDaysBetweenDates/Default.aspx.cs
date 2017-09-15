using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeDaysBetweenDates
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /*  - Personal Notes for Comprehension -
            *  
            *   This evaluation is completed via chaining multiple
            *   helper methods together. 
            *   IE: print: 1st selection of Calendar 1, 
            *   but subtract the 2nd selection from Calendar 2.
            *   Finish by getting the value for the total
            *   number of days, then convert this figure into
            *   a string and print.
            *   
            */


            // if first selection is greater than the second, 
            // print out that value between the two.
            if (firstCalendar.SelectedDate > secondCalendar.SelectedDate)
            {
                resultLabel.Text = firstCalendar.SelectedDate
                    .Subtract(secondCalendar.SelectedDate)
                    .TotalDays.ToString();
            // otherwise print out the value between the two selections
            // from the 2nd selection to the 1st.
            } else {
                resultLabel.Text = secondCalendar.SelectedDate
                    .Subtract(firstCalendar.SelectedDate)
                    .TotalDays.ToString();
            }
        }
    }
}