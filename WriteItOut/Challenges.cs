using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WriteItOut
{
    public partial class Challenges : Form
    {
        Int32 myIndex = 0;
        public Challenges()
        {
            InitializeComponent();
        }

        private void Challenges_Load(object sender, EventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.ShowDialog();
            this.Close();
        }

        private void ChallengeBtn_Click(object sender, EventArgs e)
        {
            challengeArray();
        }

        public void challengeArray()
        {
            string[] MyChallenges =
            {
                "Establish a daily morning routine",
                "Watch a funny movie",
                "Avoid gossiping for 30 days",
                "Wake up 10 minutes earlier",
                "Social media detox for 24 hours or as long as you need",
                "Give someone a compliment",
                "Stop swearing for 30 days",
                "Drink more water today",
                "Go 30 days without watching Netflix",
                "Do a random act of kindness",
                "Meditate for 10 minutes every day for a week",
                "Compliment others for a whole month",
                "Stop shopping online and go to the store instead for 30 days",
                "Create a daily journal entry for all the things you are grateful for",
                "Take a 20-minute walk each day",
                "Meal prep for the week",
                "Read a novel before bed",
                "Stop complaining for 30 days",
                "Take 30 minutes a day to relax",
                "Find a new hobby and stick to it for a week",
                "Try something new! Step out of your comfort zone",
                "Take a week to have no tech devices in the mornings",
                "Capture a special photo each day for 30 days",
                "Make a positive music playlist and listen to it",
                "Practice Self-Affirmations once a day for 30 days.",
                "Try yoga for 30 days",
                "Avoid toxic people for 30 days",
                "Smile back at people who smile at you",
        };
            if (myIndex < MyChallenges.Length)
            {
                ChallengeLbl.Text = MyChallenges[myIndex];
                myIndex++;
            }
            else
            {
                myIndex = 0;
            }
        }
    }
}
