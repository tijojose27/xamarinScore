using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace xamarinScore
{
    public partial class MainPage : ContentPage
    {
        int team1Score = 0;
        int team2Score = 0;

        public MainPage()
        {
            InitializeComponent();

            team1Points.Text = "0 Points";
            team2Points.Text = "0 Points";

            team1Goal.Clicked += Team1Goal_Clicked;
            team1Foul.Clicked += Team1Foul_Clicked;
            team2Foul.Clicked += Team2Foul_Clicked;
            team2Goal.Clicked +=Team2Goal_Clicked;
            resetBtn.Clicked+=ResetBtn_Clicked;
        }

        void ResetBtn_Clicked(object sender, EventArgs e)
        {
            team1Score = 0;
            team2Score = 0;
            updateTeamScore(team1Score, team1Points);
            updateTeamScore(team2Score, team2Points);
        }


        void Team2Goal_Clicked(object sender, EventArgs e)
        {
            increamentScore(ref team2Score);
            updateTeamScore(team2Score, team2Points);
        }


        void Team2Foul_Clicked(object sender, EventArgs e)
        {
            decreaseScore(ref team2Score);
            updateTeamScore(team2Score, team2Points);
        }


        void Team1Goal_Clicked(object sender, EventArgs e)
        {
            increamentScore(ref team1Score);
            updateTeamScore(team1Score, team1Points);
        }

        void Team1Foul_Clicked(object sender, EventArgs e)
        {
            if (team1Score > 0)
            {
                decreaseScore(ref team1Score);
                updateTeamScore(team1Score, team1Points);
            }
        }

        void updateTeamScore(int score, Label label){
            string score1 = "";
            if(score==1){
                score1 = score + " point";
            }else{
                score1 =  score + " points";
            }
            label.Text = score1;
        }


        void decreaseScore(ref int score)
        {
            if (score > 0)
            {
                score--;
            }
        }

        void increamentScore(ref int score)
        {
            score++;
        }

    }
}
