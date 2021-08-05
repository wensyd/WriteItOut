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
    public partial class Quotes : Form
    {
        Int32 myIndex = 0;
        public Quotes()
        {
            InitializeComponent();
        }

        private void Quotes_Load(object sender, EventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {

            Home home = new Home();
            home.ShowDialog();
            this.Close();

        }

        private void QuoteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                quoteArray();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error; " + ex.ToString());
            }
            
        }

        public void quoteArray()
        {
            string[] quote = { "“Hope is important because it can make the present moment less difficult to bear. If we believe that tomorrow will be better, we can bear a hardship today.”– Thich Nhat Hanh",
                "“Our greatest glory is not in never falling, but in rising every time we fall. - Confucius",
                "“No matter what our journey holds - hope gives us the strength to dream, to carry on and to evolve.” - Official Poster, IRONMAN World Championships, 2013", "And so rock bottom became the solid foundation on which I rebuilt my life.”- J.K. Rowling",
                "“Most of the important things in the world have been accomplished by people who have kept on trying when there seemed to be no hope at all.”- Dale Carnegie",
                "“Most people are stronger than they know. They just forget to believe in it sometimes.”- Keith Scott",
                "“When life gives you a hundred reasons to cry, show life that you have a thousand reasons to smile.” - Unknown" ,
                "“Once you choose hope, anything's possible.”- Christopher Reeve",
                "“When one door of happiness closes, another opens; but often we look so long at the closed door that we do not see the one which has been opened for us.”- Anonymous",
                "“The darkest night is often the bridge to the brightest tomorrow.” - Jonathan Lockwood Huie",
                "“Doing what you like is freedom. Liking what you do is happiness.” – Frank Tyger",
                "“Don’t worry about failures, worry about the chances you miss when you don’t even try.”– Jack Canfield",
                "“Happiness is the art of never holding in your mind the memory of any unpleasant thing that has passed.” – Unknown",
                "“We don’t laugh because we’re happy – we’re happy because we laugh.” – William James",
                "“To be happy, we must not be too concerned with others.” – Albert Camus",
                "“Many of life’s failures are experienced by people who did not realize how close they were to success when they gave up.” – Thomas Edison",
                "“Your time is limited, so don’t waste it living someone else’s life.” – Steve Jobs",
                "“The greatest happiness of life is the conviction that we are loved; loved for ourselves, or rather, loved in spite of ourselves.”– Victor Hugo",
                "“Yesterday is history, tomorrow is a mystery, but today is a gift; that’s why it’s called The Present.”– Bil Keane",
                "“Just when the caterpillar thought its world was over, it became a butterfly.”– Unknown",
                "“Anyone who isn't confused really doesn't understand the situation.”- Edward R. Murrow",
                "“Confusion is a word we have invented for an order which is not understood.”– Henry Miller",
                "“When you finally accept that it’s OK not to have answers and it’s OK not to be perfect, you realize that feeling confused is a normal part of what it is to be a human being.”–  Winona Ryder",
                "“When I feel confused or depressed, I remember back to junior high and I silently repeat, ‘This, too, shall pass.”– Josh Groban",
                "“I’m gutted and feeling a bit lost, but I’m determined to get through it.” – Gareth Evans",
                "“Just remember – when you think all is lost, the future remains.”– Robert H. Goddard",
                "“Your intellect may be confused, but your emotions will never lie to you.”– John Gay",
                "“The most confused we ever get is when we’re trying to convince our heads of something our heart knows is a lie.” – Karen Marie Moning",
                "“If you are sure you understand everything that is going on, you are hopelessly confused.”– Walter F. Mondale",
};

            if (myIndex < quote.Length)
            {
                QuoteLbl.Text = quote[myIndex];
                myIndex++;
            }
            else
            {
                myIndex = 0;
            }
        }
    }

}

