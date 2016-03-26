namespace LetterCount
{

    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;

    //•	Write a program that reads a string from the console and prints all different letters in the 
    //  string along with information how many times each letter is found.

    class LettersCount
    {
        static void Main()
        {
            string text = "An diesem Freitag startet die Fußball-Bundesliga noch mal neu in die Saison. Der 13. Spieltag ist zugleich der erste: der erste Spieltag nach Paris. Auch der erste Spieltag nach Hannover. Hamburger SV gegen Borussia Dortmund, so lautet nun gewissermaßen das Eröffnungsspiel, das den Beginn eines neuen Fußballzeitalters markieren soll. Es ist das Zeitalter der größtmöglichen Stadionsicherheit.Mein Eindruck ist, dass der Fußball in Deutschland mit dem heutigen Tage in vielen Facetten eine andere Wende bekommen hat. Diesen Satz haben viele noch im Ohr. Ein sehr bleicher Liga-Präsident Reinhard Rauball hat ihn am Dienstagabend in Hannover auf der Pressekonferenz mit dem Bundes- und dem Landes-Innenminister gesagt.Gerade war das geplante Länderspiel der Nationalmannschaft gegen die Niederlande abgesagt worden, das ja ohnehin eher ein Symbol sein sollte als ein Fußballspiel nach den Terroranschlägen von Paris. Und nun war die Frage gewesen, ob die Bundesliga einfach so weiterspielen könne am nächsten Wochenende. Der Rauball-Satz klang nach: nein. Nach Innehalten. Aber es ist dann doch wieder ein Ja draus geworden. The show must go on.An diesem Freitag jedenfalls wird Rauball - auch als DFB-Interimspräsident und als BVB-Präsident - nach Hamburg fahren. Und dass vielleicht doch gar nicht alles ganz anders sein wird als vorher, sieht man an den lieb gewonnenen Kleinigkeiten. Zum Beispiel hat Uwe Seeler sein Kommen angekündigt. Wie eigentlich immer, wenn sein HSV spielt.Ja, logisch gehe ich ins Stadion, sagt die 79 Jahre alte Stürmer- Legende, wir dürfen uns vom Terror nicht in die Knie zwingen lassen. Wie er ins Stadion geht, hat Uwe Seeler allerdings auch offenbart: mit gemischten Gefühlen";
            int[] unicode = new int[65536];
            
            foreach (var c in text)
            {
                unicode[c]++;
            }
            for (int i = 0; i < unicode.Length; i++)
            {
                if (i == 32)
                {
                    continue;
                }
                if (unicode[i] == 0)
                {
                    continue;
                }
                else
                {
                    
                    Console.WriteLine(Convert.ToChar(i) + " " + unicode[i]);
                }
            }
        }
    }
}