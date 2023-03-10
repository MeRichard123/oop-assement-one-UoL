using System.Collections.Generic;
using CMP1903M_A01_2223;

namespace Testings
{
    public class Utils
    {
        public static string FormatReadableCard(Card card)
        {
            return $"{card.Suit}{card.Value}/";
        }

        public static string FormatReadableCards(List<Card> cards)
        {
            string output = "";

            foreach (Card card in cards)
            {
                output += FormatReadableCard(card);
            }

            return output;
        }

        public static string GetExpectedOuput(int testNumber)
        {
            string[] expectedOutputs = {
                "Clubs1/Hearts1/Clubs2/Hearts2/Clubs3/Hearts3/Clubs4/Hearts4/Clubs5/Hearts5/Clubs6/Hearts6/Clubs7/Hearts7/Clubs8/Hearts8/Clubs9/Hearts9/Clubs10/Hearts10/Clubs11/Hearts11/Clubs12/Hearts12/Clubs13/Hearts13/Diamonds1/Spades1/Diamonds2/Spades2/Diamonds3/Spades3/Diamonds4/Spades4/Diamonds5/Spades5/Diamonds6/Spades6/Diamonds7/Spades7/Diamonds8/Spades8/Diamonds9/Spades9/Diamonds10/Spades10/Diamonds11/Spades11/Diamonds12/Spades12/Diamonds13/Spades13/",
                "Hearts12/Hearts13/Clubs2/Clubs3/Clubs4/Spades1/Clubs6/Clubs7/Clubs8/Spades2/Clubs10/Clubs11/Spades3/Clubs13/Diamonds1/Diamonds2/Spades4/Diamonds4/Diamonds5/Diamonds6/Spades5/Diamonds8/Diamonds9/Spades6/Diamonds11/Diamonds12/Diamonds13/Spades7/Hearts2/Hearts3/Hearts4/Spades8/Hearts6/Hearts7/Spades9/Hearts9/Hearts10/Hearts11/Spades10/Clubs5/Clubs9/Clubs12/Spades11/Diamonds7/Diamonds10/Spades12/Hearts5/Hearts8/Clubs1/Spades13/Hearts1/Diamonds3/",
                "Clubs1/Clubs2/Clubs3/Clubs4/Clubs5/Clubs6/Clubs7/Clubs8/Clubs9/Clubs10/Clubs11/Clubs12/Clubs13/Diamonds1/Diamonds2/Diamonds3/Diamonds4/Diamonds5/Diamonds6/Diamonds7/Diamonds8/Diamonds9/Diamonds10/Diamonds11/Diamonds12/Diamonds13/Hearts1/Hearts2/Hearts3/Hearts4/Hearts5/Hearts6/Hearts7/Hearts8/Hearts9/Hearts10/Hearts11/Hearts12/Hearts13/Spades1/Spades2/Spades3/Spades4/Spades5/Spades6/Spades7/Spades8/Spades9/Spades10/Spades11/Spades12/Spades13/",
                "Clubs2/",
                "Hearts12/",
                "Clubs2/",
                "Clubs6/Hearts6/Clubs7/Hearts7/Clubs8/Hearts8/Clubs9/Hearts9/Clubs10/Hearts10/",
                "Hearts12/Hearts13/Clubs2/Clubs3/Clubs4/Spades1/Clubs6/Clubs7/Clubs8/Spades2/",
                "Clubs1/Clubs2/Clubs3/Clubs4/Clubs5/Clubs6/Clubs7/Clubs8/Clubs9/Clubs10/"
            };

            return expectedOutputs[testNumber - 1];
        }
    }
}
