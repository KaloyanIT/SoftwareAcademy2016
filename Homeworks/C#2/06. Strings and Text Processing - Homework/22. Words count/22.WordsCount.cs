namespace WordsCount
{
    using System;
    using System.Text.RegularExpressions;
    using System.Linq;
    using System.Collections.Generic;

    //•	Write a program that reads a string from the console and lists all different words in the 
    //  string along with information how many times each word is found.

    class WordsCount
    {
        static void Main()
        {
            string text = "An diesem Freitag startet die Fußball-Bundesliga noch mal neu in die Saison. Der 13. Spieltag ist zugleich der erste: der erste Spieltag nach Paris. Auch der erste Spieltag nach Hannover. Hamburger SV gegen Borussia Dortmund, so lautet nun gewissermaßen das Eröffnungsspiel, das den Beginn eines neuen Fußballzeitalters markieren soll. Es ist das Zeitalter der größtmöglichen Stadionsicherheit.Mein Eindruck ist, dass der Fußball in Deutschland mit dem heutigen Tage in vielen Facetten eine andere Wende bekommen hat. Diesen Satz haben viele noch im Ohr. Ein sehr bleicher Liga-Präsident Reinhard Rauball hat ihn am Dienstagabend in Hannover auf der Pressekonferenz mit dem Bundes- und dem Landes-Innenminister gesagt.Gerade war das geplante Länderspiel der Nationalmannschaft gegen die Niederlande abgesagt worden, das ja ohnehin eher ein Symbol sein sollte als ein Fußballspiel nach den Terroranschlägen von Paris. Und nun war die Frage gewesen, ob die Bundesliga einfach so weiterspielen könne am nächsten Wochenende. Der Rauball-Satz klang nach: nein. Nach Innehalten. Aber es ist dann doch wieder ein Ja draus geworden. The show must go on.An diesem Freitag jedenfalls wird Rauball - auch als DFB-Interimspräsident und als BVB-Präsident - nach Hamburg fahren. Und dass vielleicht doch gar nicht alles ganz anders sein wird als vorher, sieht man an den lieb gewonnenen Kleinigkeiten. Zum Beispiel hat Uwe Seeler sein Kommen angekündigt. Wie eigentlich immer, wenn sein HSV spielt.Ja, logisch gehe ich ins Stadion, sagt die 79 Jahre alte Stürmer- Legende, wir dürfen uns vom Terror nicht in die Knie zwingen lassen. Wie er ins Stadion geht, hat Uwe Seeler allerdings auch offenbart: mit gemischten Gefühlen";
            string pattern = @"(?<words>\w+)";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);
            var words = new Dictionary<string, int>();
            foreach (var word in matches)
            {
                
                if (words.ContainsKey(word.ToString()) == false)
                {
                    words.Add(word.ToString(), 1);
                }
                else
                {
                    string s = word.ToString();
                    words[s] += 1;
                }
            }
            foreach (KeyValuePair<string, int> pair in words)
            {
                Console.WriteLine("{0} --> {1} times", pair.Key, pair.Value);
            }
        }
    }
}