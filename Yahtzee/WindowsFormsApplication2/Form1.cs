using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class gameYahtzee : Form
    {
        private List<int> dice;
        public int scoreOnes {get; set;}
        public int scoreTwos { get; set; }
        public int scoreThrees { get; set; }
        public int scoreFours { get; set; }
        public int scoreFives { get; set; }
        public int scoreSixes { get; set; }

        public int scoreThreeOfAKind { get; set; }
        public int scoreFourOfAKind { get; set; }
        public int scoreFullHouse { get; set; }
        public int scoreSmallStraight { get; set; }
        public int scoreLargeStraight { get; set; }
        public int scoreYahtzee { get; set; }
        public int scoreYahtzeeBonus { get; set; }
        public int scoreChance { get; set; }
        public int scoreTotal;

        private static readonly int NUMBER_OF_DICE = 5;
        private Random random = new Random();//random num generator between 1 and 6
        private int rollsDone=0; //num of rolls this turn
        private bool IsScored = false;//tells whether a score has been recorded for the current turn

        public void rollDice()
        {
            if ((rollsDone >= 3 && IsScored==true) || IsScored==true)
            {
                //resets all dice checkboxes at end of turn, and preps for next turn
                chkBoxDie1.Checked = false;
                chkBoxDie2.Checked = false;
                chkBoxDie3.Checked = false;
                chkBoxDie4.Checked = false;
                chkBoxDie5.Checked = false;
                IsScored = false;
                rollsDone = 1;
            }
            //if unchecked, rolls the die. checks all dice
                if (chkBoxDie1.Checked == false)
                {
                    dice[0] =roll();
                    labelDie1.Text = dice[0].ToString();
                }

                if (chkBoxDie2.Checked == false)
                {
                    dice[1] = roll();
                    labelDie2.Text = dice[1].ToString();
                }
                if (chkBoxDie3.Checked == false)
                {
                    dice[2] = roll();
                    labelDie3.Text = dice[2].ToString();
                }
                if (chkBoxDie4.Checked == false)
                {
                    dice[3] = roll();
                    labelDie4.Text = dice[3].ToString();
                }
                if (chkBoxDie5.Checked == false)
                {
                    dice[4] = roll();
                    labelDie5.Text = dice[4].ToString();
                }
            //enables or disables roll button    
            if (rollsDone>=3)
            {
                bttnRoll.Enabled = false;
            }
            else
            {
                bttnRoll.Enabled = true;
            }
            
            //increments rollsDone
            rollsDone++;
            return;
        }

        //does actual roll of dice
        public int roll()
        {
            //should be 0 or 1 for minimum number? and 6 or 7 for maximum number?
            //using six-sided dice
            return random.Next(1, 7); 
        }

        //scores and takes care of Ones points if selected
        private void bttnOnes_Click(object sender, EventArgs e)
        {
            if(dice[0]==1)
            {
                scoreOnes = scoreOnes + 1;
            }
            if (dice[1] == 1)
            {
                scoreOnes = scoreOnes + 1;
            }
            if (dice[2] == 1)
            {
                scoreOnes = scoreOnes + 1;
            }
            if (dice[3] == 1)
            {
                scoreOnes = scoreOnes + 1;
            }
            if (dice[4] == 1)
            {
                scoreOnes = scoreOnes + 1;
            }
            //sets local score
            labelOnes.Text = scoreOnes.ToString();
            //sets total score with new score added
            scoreTotal = scoreTotal + scoreOnes;
            //disables or enables appropriate buttons
            bttnOnes.Enabled = false;
            bttnRoll.Enabled = true;
            IsScored = true;
            labelTotalScore.Text = scoreTotal.ToString();
        }

        //takes care of twos score like ones
        private void bttnTwos_Click(object sender, EventArgs e)
        {
            if (dice[0] == 2)
            {
                scoreTwos = scoreTwos + 2;
            }
            if (dice[1] == 2)
            {
                scoreTwos = scoreTwos + 2;
            }
            if (dice[2] == 2)
            {
                scoreTwos = scoreTwos + 2;
            }
            if (dice[3] == 2)
            {
                scoreTwos = scoreTwos + 2;
            }
            if (dice[4] == 2)
            {
                scoreTwos = scoreTwos + 2;
            }
            labelTwos.Text = scoreTwos.ToString();
            scoreTotal = scoreTotal + scoreTwos;
            bttnTwos.Enabled = false;
            bttnRoll.Enabled = true;
            IsScored = true;
            labelTotalScore.Text = scoreTotal.ToString();
        }

        //takes care of threes score like ones
        private void bttnThrees_Click(object sender, EventArgs e)
        {
            if (dice[0] == 3)
            {
                scoreThrees = scoreThrees + 3;
            }
            if (dice[1] == 3)
            {
                scoreThrees = scoreThrees + 3;
            }
            if (dice[2] == 3)
            {
                scoreThrees = scoreThrees + 3;
            }
            if (dice[3] == 3)
            {
                scoreThrees = scoreThrees + 3;
            }
            if (dice[4] == 3)
            {
                scoreThrees = scoreThrees + 3;
            }
            labelThrees.Text = scoreThrees.ToString();
            scoreTotal = scoreTotal + scoreThrees;
            bttnThrees.Enabled = false;
            bttnRoll.Enabled = true;
            IsScored = true;
            labelTotalScore.Text = scoreTotal.ToString();
        }

        //takes care of fourss score like ones
        private void bttnFours_Click(object sender, EventArgs e)
        {
            if (dice[0] == 4)
            {
                scoreFours = scoreFours + 4;
            }
            if (dice[1] == 4)
            {
                scoreFours = scoreFours + 4;
            }
            if (dice[2] == 4)
            {
                scoreFours = scoreFours + 4;
            }
            if (dice[3] == 4)
            {
                scoreFours = scoreFours + 4;
            }
            if (dice[4] == 4)
            {
                scoreFours = scoreFours + 4;
            }
            labelFours.Text = scoreFours.ToString();
            scoreTotal = scoreTotal + scoreFours;
            bttnFours.Enabled = false;
            bttnRoll.Enabled = true;
            IsScored = true;
            labelTotalScore.Text = scoreTotal.ToString();
        }

        //takes care of fives score like ones
        private void bttnFives_Click(object sender, EventArgs e)
        {
            if (dice[0] == 5)
            {
                scoreFives = scoreFives + 5;
            }
            if (dice[1] == 5)
            {
                scoreFives = scoreFives + 5;
            }
            if (dice[2] == 5)
            {
                scoreFives = scoreFives + 5;
            }
            if (dice[3] == 5)
            {
                scoreFives = scoreFives + 5;
            }
            if (dice[4] == 5)
            {
                scoreFives = scoreFives + 5;
            }
            labelFives.Text = scoreFives.ToString();
            scoreTotal = scoreTotal + scoreFives;
            bttnFives.Enabled = false;
            bttnRoll.Enabled = true;
            IsScored = true;
            labelTotalScore.Text = scoreTotal.ToString();
        }

        //takes care of sixes score like ones
        private void bttnSixes_Click(object sender, EventArgs e)
        {
            if (dice[0] == 5)
            {
                scoreSixes = scoreSixes + 5;
            }
            if (dice[1] == 5)
            {
                scoreSixes = scoreSixes + 5;
            }
            if (dice[2] == 5)
            {
                scoreSixes = scoreSixes + 5;
            }
            if (dice[3] == 5)
            {
                scoreSixes = scoreSixes + 5;
            }
            if (dice[4] == 5)
            {
                scoreSixes = scoreSixes + 5;
            }
            labelSixes.Text = scoreSixes.ToString();
            scoreTotal = scoreTotal + scoreSixes;
            bttnSixes.Enabled = false;
            bttnRoll.Enabled = true;
            IsScored = true;
            labelTotalScore.Text = scoreTotal.ToString();
        }

        //handles roll button click
        private void bttnRoll_Click(object sender, EventArgs e)
        {
            rollDice();

            //updates all labels to show appropriate values
            labelDie1.Text = dice[0].ToString();
            labelDie2.Text = dice[1].ToString();
            labelDie3.Text = dice[2].ToString();
            labelDie4.Text = dice[3].ToString();
            labelDie5.Text = dice[4].ToString();
        }

        //starts new game and RESETS EVERYTHING!!!! 
        //This MUST BE DONE FOR GAMES TO WORK PROPERLY!!
        //IN CAPS FOR A REASON!!!
        private void bttnNewGame_Click(object sender, EventArgs e)
        {
            //resets scores and IsScored
            IsScored = false;
            scoreOnes = 0;
            scoreTwos = 0;
            scoreThrees = 0;
            scoreFours = 0;
            scoreFives = 0;
            scoreSixes = 0;
            scoreThreeOfAKind = 0;
            scoreFourOfAKind = 0;
            scoreSmallStraight = 0;
            scoreLargeStraight = 0;
            scoreFullHouse = 0;
            scoreYahtzee = 0;
            scoreYahtzeeBonus = 0;
            scoreChance = 0;
            scoreTotal = 0;
            //resets labels, clears dice list, creates or re-creates and rolls 5 dice 
            labelTotalScore.Text = scoreTotal.ToString();
            dice.Clear();
            for (int i = 0; i < 5; i++)
            {
                dice.Add(roll());
            }
            rollsDone = 1;
            //re-enables all appropriate buttons
            bttnChance.Enabled = true;
            bttnFives.Enabled = true;
            bttnFourOfAKind.Enabled = true;
            bttnFours.Enabled = true;
            bttnFullHouse.Enabled = true;
            bttnLargeStraight.Enabled = true;
            bttnOnes.Enabled = true;
            bttnRoll.Enabled = true;
            bttnSixes.Enabled = true;
            bttnSmallStraight.Enabled = true;
            bttnThreeOfAKind.Enabled = true;
            bttnThrees.Enabled = true;
            bttnTwos.Enabled = true;
            bttnYahtzee.Enabled = true;
            bttnYahtzeeBonus.Enabled = false;

            //clears labels for scores
            labelChance.Text = "";
            labelOnes.Text = "";
            labelTwos.Text = "";
            labelThrees.Text = "";
            labelFours.Text = "";
            labelFives.Text = "";
            labelSixes.Text = "";
            labelThreeOfAKind.Text = "";
            labelFourOfAKind.Text = "";
            labelFullHouse.Text = "";
            labelSmallStraight.Text = "";
            labelLargeStraight.Text = "";
            labelYahtzee.Text = "";
            labelYahtzeeBonus.Text = "";
            labelTotalScore.Text = "";
        }

        //holds conditions to check for small straight
        public bool checkForSmallStraight()
        {
            return ((dice.Contains( 1 ) && dice.Contains( 2 ) && dice.Contains( 3 )  && dice.Contains( 4 )) 
                ||(dice.Contains( 2 ) && dice.Contains( 3 )  && dice.Contains( 4 ) && dice.Contains( 5 ))
                || (dice.Contains( 3 )  && dice.Contains( 4 ) && dice.Contains( 5 ) && dice.Contains( 6 ))); 

        }

        //handles small straight scoring
        private void bttnSmallStraight_Click(object sender, EventArgs e)
        {
            bool IsSmallStraight = checkForSmallStraight();
            if(IsSmallStraight==true)
            {
                scoreSmallStraight = 30;
            }
            else
            {
                scoreSmallStraight = 0;
            }

            labelSmallStraight.Text = scoreSmallStraight.ToString();
            scoreTotal = scoreTotal + scoreSmallStraight;
            bttnSmallStraight.Enabled = false;
            bttnRoll.Enabled = true;
            IsScored = true;
            labelTotalScore.Text = scoreTotal.ToString();
        }

        //handles Large Straight Button
        private void bttnLargeStraight_Click(object sender, EventArgs e)
        {
            if(IsLargeStraight()==true)
            {
                scoreLargeStraight = 40;
            }
            else
            {
                scoreLargeStraight = 0;
            }

            labelLargeStraight.Text = scoreLargeStraight.ToString();
            scoreTotal = scoreTotal + scoreLargeStraight;
            bttnLargeStraight.Enabled = false;
            bttnRoll.Enabled = true;
            IsScored = true;
            labelTotalScore.Text = scoreTotal.ToString();
        }
        
        //tells if choice is a large straight
        public bool IsLargeStraight()
        {
            return ((dice.Contains(1) && dice.Contains(2) &&
                dice.Contains(3) && dice.Contains(4) && dice.Contains(5)) ||
                (dice.Contains(6) && dice.Contains(2) &&
                dice.Contains(3) && dice.Contains(4) && dice.Contains(5)));
        }

        //gets and returns sum off all the dice
        //used in several methods
        //DO NOT DELETE
        public int sumOfAllDice()
        {
            return (dice[0] + dice[1] + dice[2] + dice[3] + dice[4]);
        }

        //controls Chance Button
        private void bttnChance_Click(object sender, EventArgs e)
        {
            scoreChance = sumOfAllDice();
            labelChance.Text = scoreChance.ToString();
            scoreTotal = scoreTotal + scoreChance;
            bttnChance.Enabled = false;
            bttnRoll.Enabled = true;
            labelTotalScore.Text = scoreTotal.ToString();
            IsScored = true;
        }

        //checks for Yahtzee
        //used in yahtzee and yatzee bonus
        public bool IsYahtzee()
        {
            return (dice[0] == dice[1] && dice[1] == dice[2] &&
                dice[2] == dice[3] && dice[3] == dice[4]);
        }

        //handles Yahtzee Button
        private void bttnYahtzee_Click(object sender, EventArgs e)
        {
            if(IsYahtzee()==true)
            {
                scoreYahtzee = 50;
                //enable yahtzee bonus
                bttnYahtzeeBonus.Enabled = true;
            }
            else
            {
                scoreYahtzee = 0;
            }
            labelYahtzee.Text = scoreYahtzee.ToString();
            scoreTotal = scoreTotal + scoreYahtzee;
            bttnYahtzee.Enabled = false;
            bttnRoll.Enabled = true;
            labelTotalScore.Text = scoreTotal.ToString();
            IsScored = true;
        }
        //handles yahtzee bonus button
        private void bttnYahtzeeBonus_Click(object sender, EventArgs e)
        {
            if (IsYahtzee() == true)
            {
                scoreYahtzeeBonus = 100;
            }
            else
            {
                scoreYahtzeeBonus = 0;
            }
            labelYahtzeeBonus.Text = scoreYahtzeeBonus.ToString();
            scoreTotal = scoreTotal + scoreYahtzeeBonus;
            bttnYahtzeeBonus.Enabled = false;
            bttnRoll.Enabled = true;
            labelTotalScore.Text = scoreTotal.ToString();
            IsScored = true;
        }

        //checks if dice contain 3 of a kind using all possible combinations
        public bool IsThreeOfAKind()
        {
            return ((dice[0] == dice[1] && dice[1] == dice[2])
                || (dice[0] == dice[1] && dice[1] == dice[3])
                || (dice[0] == dice[1] && dice[1] == dice[4])
                || (dice[0] == dice[2] && dice[2] == dice[3])
                || (dice[0] == dice[2] && dice[2] == dice[4])
                || (dice[0] == dice[3] && dice[3] == dice[4])
                || (dice[1] == dice[2] && dice[2] == dice[3])
                || (dice[1] == dice[2] && dice[2] == dice[4])
                || (dice[1] == dice[3] && dice[3] == dice[4])
                || (dice[2] == dice[3] && dice[3] == dice[4]));
        }

        //checks if dice contain 4 of a kind using all possible combinations
        public bool IsFourOfAKind()
        {
            return ((dice[0] == dice[1] && dice[1] == dice[2] && dice[2] == dice[3])
                || (dice[0] == dice[1] && dice[1] == dice[2] && dice[2] == dice[4])
                || (dice[0] == dice[1] && dice[1] == dice[3] && dice[3] == dice[4])
                || (dice[0] == dice[2] && dice[2] == dice[3] && dice[3] == dice[4])
                || (dice[1] == dice[2] && dice[2] == dice[3] && dice[3] == dice[4]));
        }

        //checks if dice contain full house using all possible combinations,
        //using modified code from IsThreeOfAKind method
        public bool IsFullHouse()
        {
            return ((dice[0] == dice[1] && dice[1] == dice[2] && dice[3] == dice[4])
                || (dice[0] == dice[1] && dice[1] == dice[3] && dice[2] == dice[4])
                || (dice[0] == dice[1] && dice[1] == dice[4] && dice[2] == dice[3])
                || (dice[0] == dice[2] && dice[2] == dice[3] && dice[1] == dice[4])
                || (dice[0] == dice[2] && dice[2] == dice[4] && dice[1] == dice[3])
                || (dice[0] == dice[3] && dice[3] == dice[4] && dice[1] == dice[2])
                || (dice[1] == dice[2] && dice[2] == dice[3] && dice[0] == dice[4])
                || (dice[1] == dice[2] && dice[2] == dice[4] && dice[0] == dice[3])
                || (dice[1] == dice[3] && dice[3] == dice[4] && dice[0] == dice[2])
                || (dice[2] == dice[3] && dice[3] == dice[4] && dice[0] == dice[1]));
        }

        //handles 3 of a kind button click
        private void bttnThreeOfAKind_Click(object sender, EventArgs e)
        {
            if(IsThreeOfAKind()==true)
            {
                scoreThreeOfAKind = sumOfAllDice();
            }
            else
            {
                scoreThreeOfAKind = 0;
            }
            labelThreeOfAKind.Text = scoreThreeOfAKind.ToString();
            scoreTotal = scoreTotal + scoreThreeOfAKind;
            bttnThreeOfAKind.Enabled = false;
            bttnRoll.Enabled = true;
            labelTotalScore.Text = scoreTotal.ToString();
            IsScored = true;
        }

        //handles 4 of a kind button click
        private void bttnFourOfAKind_Click(object sender, EventArgs e)
        {
            if (IsFourOfAKind() == true)
            {
                scoreFourOfAKind = sumOfAllDice();
            }
            else
            {
                scoreFourOfAKind = 0;
            }
            labelFourOfAKind.Text = scoreFourOfAKind.ToString();
            scoreTotal = scoreTotal + scoreFourOfAKind;
            bttnFourOfAKind.Enabled = false;
            bttnRoll.Enabled = true;
            labelTotalScore.Text = scoreTotal.ToString();
            IsScored = true;
        }
        
        //handles full house button click
        private void bttnFullHouse_Click(object sender, EventArgs e)
        {
            if (IsFullHouse() == true)
            {
                scoreFullHouse = 25;
            }
            else
            {
                scoreFullHouse = 0;
            }
            labelFullHouse.Text = scoreFullHouse.ToString();
            scoreTotal = scoreTotal + scoreFullHouse;
            bttnFullHouse.Enabled = false;
            bttnRoll.Enabled = true;
            labelTotalScore.Text = scoreTotal.ToString();
            IsScored = true;
        }

        
    }
}
