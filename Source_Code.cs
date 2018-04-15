using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Xml;
using System.Web;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using MaterialSkin;
using MaterialSkin.Controls;
using OpenWeatherMap;

namespace Eigene_KI
{
    public partial class Form1 : MaterialForm 
    {

        SpeechRecognitionEngine h = new SpeechRecognitionEngine();
        SpeechSynthesizer voice = new SpeechSynthesizer();

        Boolean hören = true; // für den Ruhemodus der KI

       

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        public void Form1_Load(object sender, EventArgs e)
        {

            Choices commands = new Choices();

            #region Die String Arreys für die Fragen an die KI
            String[] begrüßung = new String[] { "hallo", "na was geht", "tach auch", "hallo lis" ,"lis" ,"okey lis" };
            String[] wiegehts = new String[] { "wie geht es dir", "wie gehts", "was läuft", "wie gehts dir" };
            String[] danke = new String[] { "danke", "dankeschön", "vielen dank" };
            String[] kennst = new String[] { "kennst du den google assistent", "kennst du siri", };
            String[] gut = new string[] { "danke mir gehts auch gut", "mir gehts auch gut", "super danke" };
            String[] werbist = new String[] { "wer bist du", "was bist du", "was genau bist du", "wie heißt du", "wie ist dein Name" };
            String[] erschaffen = new String[] { "wer hat dich programmiert", "wer hat dich erschaffen", "wer ist dein Erschaffer", "wer ist dein Schöpfer" };
            String[] waskannst = new String[] { "was kannst du alles", "wozu bist du fähig", "was sind deine funktionen" };
            String[] programme = new String[] { "welche programme kannst du öffnen", "was kannst du öffnen", "welche programme genau kannst du öffnen", "was kannst du in wikipedia suchen" };
            String[] uhrzeit = new String[] { "wie spät ist es", "wie viel uhr ist es", "was sagt die Zeit" };
            String[] datum = new String[] { "welcher tag ist heute", "was für ein Tag haben wir heute" };
            String[] progöffnen = new String[] { "öffne Programme in C", "öffne programme in e","öffne spiel" };
            String[] wikipedia = new String[] { "was ist youtube", "was ist apple", "was ist google" };
            String[] witze = new string[] { "erzäh mir einen witz", "erzähl mir bitte einen witz", "kannst du mir einen witz erzählen", "sei mal witzig", "sei mal lustig", "hast du witze auf lager", "kennst du irgendwelche witze" };
            String[] ordner = new string[] {"wieviele ordner und dateien", "welche ordner und dateien"};
            String[] ruhemodus = new String[] { "spreche" , "sei still" };
            String[] verabschieden = new String[3] { "tschüss", "danke das wars schon", "bis nächstes mal lis" };
            String[] wetter = new string[] { "wie ist das wetter", "was kannst du mir zum wetter sagen" };

            #endregion

            #region Kommandos werden hinzugefügt ( Fragen an Lis)
            commands.Add(begrüßung);
            commands.Add(wiegehts); 
            commands.Add(danke);
            commands.Add(kennst);
            commands.Add(gut);
            commands.Add(werbist);
            commands.Add(erschaffen);
            commands.Add(waskannst);
            commands.Add(programme);
            commands.Add(uhrzeit);
            commands.Add(datum);
            commands.Add(progöffnen);
            commands.Add(wikipedia);
            commands.Add(witze);
            commands.Add(ordner);
            commands.Add(ruhemodus);
            commands.Add(verabschieden);
            commands.Add(wetter);

            #endregion


            GrammarBuilder grammarBuilder = new GrammarBuilder();
            grammarBuilder.Append(commands);

            Grammar grammar = new Grammar(grammarBuilder);

            h.LoadGrammar(grammar); // Recognition Engine läd damit auch wirklich die Grammatik
            h.SetInputToDefaultAudioDevice();
            h.SpeechRecognized += recEngine_SpeechRecognized;

            h.RecognizeAsync(RecognizeMode.Multiple); // Damit die KI mehrere Kommands hintereinander verstehen kann
            voice.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Teen);// Hier kann man die Sprecherstimme verändern/einstellen

            #region Anfangssatz
            Random t = new Random();
            String[] anfang = new String[] { "wie kann ich helfen", "nenne mir dein anliegen", "was kann ich für sie tun", "schaltest du mich auch mal wieder ein, was gibts", "was los diga" };
            say(anfang[t.Next(5)]); // Zum Ausprechen der KI, am Anfang
            #endregion



        }
        public void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
           



                #region Antwortvielfalt, die Antworten von Lis auf die Commands
                Random r = new Random();

                String[] begrüßung = new String[] { "ich bin da", "am start, was gibts", "hallo, schön von dir zu hören", "ja hallo...", "tach auch", "da bist du ja wieder", "Moin", };
                String[] wiegehts = new String[]  { "mir gehts gut und dir", "ich kann mich nicht beschweren", "ich bin eine Ki, gute Frage", "jetzt da du da bist wieder super","viel wichtiger, wie geht es dir"
                                                 , "schön das du fragst, es geht mir blendend" , "red nicht um den brei, was willst du"  };
                String[] danke = new String[] { "aber gerne doch", "für dich doch immer" };
                String[] google = new String[]    { "Ja na klar, aber die bekommt bald Konkurenz, wenn ich erstmal fertig programmiert bin", "dazu sage ich jetzt nichts" , "darüber möchte ich nicht reden "
                                                 , "wäre möglich, heißt das ich bin dir nicht mehr gut genug"};
                String[] siri = new String[] { "heikles thema, findest du nicht auch", "ja genau, da hab ich jetzt voll bock drüber zu reden", "wer kennt nicht apple", };
                String[] gut = new string[] { "das ist schön zu hören", "das freut mich aber für dich", "sehr gut, dann kannst du mir ja jetzt sagen, was du von mir willst" };
                String[] werbist = new String[]       { "Darf ich mich vorstellen, ich bin eine neue künstliche intelligenz namens LIS" , "Mein Name ist Lis und ich bin eine KI" , "Ich heiße Lis und bin dein asistent", "eine ki, namens lis",
                                                     "Einfach gesagt ´bin ich ein neuer asistent"};
                String[] erschaffen = new String[] { "Ich wurde von Kevin Bastian ins leben gerufen um dich zu unterstützen", "Das ist streng geheim... ", "Kevin Bastian",
                                                    "Ist doch egal, haupsacher ich funktioniere, oder" };

                String[] waskannst = new String[]       { "Ich bin noch recht neu, es kommen immer mehr funktionen dazu, momentan kann ich reden, Uhrzeit und Datum sagen und ein paar Programme öffnen, sowie bin ich ich schon begrenzt mit wikipedia verbunden",
                                                 "vieles, haha, nein spaß ich kann reden, uhrzeit und datum sagen und ein paar programme öffnen, sowie einige Fragen mit Hilfe von wikipedia beantworten", "frag mich das wenn ich aus der Alpha drausen bin nochmal",
                                                 "finde es doch einfach raus ", "zu wenig wenn du mich fragst, mein progammierer könnte sich ruhig mal mehr anstrengen" };

                String[] programme = new String[] { "Das Spiel Ark und Im C Laufwerk die Programme", };
                String[] uhrzeit = new String[] { DateTime.Now.ToString("HH:mm ")}; // Zeitansage
                String datum = DateTime.Now.ToString("d");                         // Datumsansage
                String[] wikipedia = new string[] { "okey, lass mich schnell suchen", "hier die ergebnisse meiner suche", "Ich kann dir bis jetzt nur alles über youtube apple und google sagen" };
                String[] witze = new String[] { "Wie nennt man einen übergewichtigen Vegetarier? - Biotonne" , "Los Pikatschu, Donnerblitz! Alter, hast du gerade meinen Hamster an die Steckdose geworfen?" , "Warum lässt eine Blondine die Milch fallen? – Weil sie nicht haltbar ist.",
                                             "Was hassen Fische? Antischuppenschampo" , "Was sagt ein Pirat, wenn er trockenes Gras sieht? - A Heu." , "Wie nennt man die Eier vom Pfarrer? Heiliger bimbam" ,
                                             "Wie schwer darf ein Furz sein? Null Gramm! Sonst ist es Scheiße!" , "Was haben Frauen und Handgranaten gemeinsam? Wenn du den Ring abziehst, ist dein Haus weg." , "Wie nennt man eine Demonstration von Veganern? Gemüseauflauf!!!" , "Ich wollte eine Musikschule neben einem Behindertenheim eröffnen doch der Slogen “Bongos für Monggos“ kam nicht so gut an.",
                                              "Warum dürfen Veganer kein Leitungswasser trinken? Weil es aus dem Hahn kommt." , "Warum wäscht eine Blondine ihr Shampoo? - weil draufsteht : Dusch das." };
                String[] verabschieden = new String[] { "Öffne mich bald wieder", "schön das ich dir helfen konnte", "bis nächstes mal, du opfer", "endlich kann ich chillen, tschau" };

            #endregion

            #region Ruhemodus abrage
            string modus = e.Result.Text;

            if (modus == "spreche")
            {
                hören = true;
                say("okey");
            }
            if (modus == "sei still")
            {
                hören = false;
                say("okey");
            }

            #endregion
            if (hören == true) // Muss alles mit einbinden für den Modus
            { 

                switch (e.Result.Text)
                {

                    #region 1. Begrüßung

                    case "hallo":
                        say(begrüßung[r.Next(7)]);
                        break;
                    case "na was geht":
                        say(begrüßung[r.Next(7)]);
                        break;
                    case "tach auch":
                        say(begrüßung[r.Next(7)]);
                        break;
                    case "hallo lis":
                        say(begrüßung[r.Next(7)]);
                        break;
                    case "lis":
                        say(begrüßung[r.Next(2)]);
                        break;
                    case "okey lis":
                        say(begrüßung[r.Next(2)]);
                        break;


                    #endregion

                    #region 2. wie gehts 

                    case "wie geht es dir":
                        say(wiegehts[r.Next(7)]);
                        break;
                    case "wie gehts":
                        say(wiegehts[r.Next(7)]);
                        break;
                    case "wie gehts dir":
                        say(wiegehts[r.Next(7)]);
                        break;
                    case "was läuft":
                        say(wiegehts[r.Next(8)]);
                        break;


                    #region 4. danke

                    case "danke":
                        say(danke[r.Next(2)]);
                        break;
                    case "dankeschön":
                        say(danke[r.Next(2)]);
                        break;
                    case "vielen dank":
                        say(danke[r.Next(2)]);
                        break;

                    #endregion

                    #region 5 - 6. Kennst du
                    case "kennst du den google assistent":
                        say(google[r.Next(4)]);
                        break;
                    case "kennst du siri":
                        say(siri[r.Next(4)]);
                        break;
                    

                    #endregion

                    #region 7 gut 

                    case "danke mir gehts auch gut":
                        say(gut[r.Next(3)]);
                        break;
                    case "mir gehts auch gut":
                        say(gut[r.Next(3)]);
                        break;
                    case "super danke":
                        say(gut[r.Next(3)]);
                        break;
                    #endregion

                    #region 8 wer bist

                    case "wer bist du":
                        say(werbist[r.Next(5)]);
                        break;
                    case "was bist du":
                        say(werbist[r.Next(5)]);
                        break;
                    case "was genau bist du":
                        say(werbist[r.Next(5)]);
                        break;
                    case "wie heißt du":
                        say(werbist[r.Next(3)]);
                        break;
                    case "wie ist dein Name":
                        say(werbist[r.Next(3)]);
                        break;
                    #endregion

                    #region 9 erschaffen

                    case "wer hat dich programmiert":
                        say(erschaffen[r.Next(4)]);
                        break;
                    case "wer hat dich erschaffen":
                        say(erschaffen[r.Next(4)]);
                        break;
                    case "wer ist dein Erschaffer":
                        say(erschaffen[r.Next(4)]);
                        break;
                    case "wer ist dein Schöpfer":
                        say(erschaffen[r.Next(4)]);
                        break;
                    #endregion

                    #region 10 was kannst

                    case "was kannst du alles":
                        say(waskannst[r.Next(8)]);
                        break;
                    case "wozu bist du fähig":
                        say(waskannst[r.Next(8)]);
                        break;
                    case "was sind deine funktionen":
                        say(waskannst[r.Next(8)]);
                        break;
                    #endregion

                    #region 11 Programme

                    case "was kannst du öffnen":
                        say(programme[r.Next(1)]);
                        break;
                    case "welche programme kannst du öffnen":
                        say(programme[r.Next(1)]);
                        break;
                    case "welche programme genau kannst du öffnen":
                        say(programme[r.Next(1)]);
                        break;
                    case "was kannst du in wikipedia suchen":
                        say(wikipedia[1]);
                        break;
                    #endregion

                    #region 12 Uhrzeit

                    case "was sagt die Zeit":
                        say(uhrzeit[r.Next(2)]);
                        break;
                    case "wie spät ist es":
                        say(uhrzeit[r.Next(2)]);
                        break;
                    case "wie viel uhr ist es":
                        say(uhrzeit[r.Next(2)]);
                        break;
                    #endregion

                    #region 13.Datum

                    case "was für ein Tag haben wir heute":
                        say(datum);
                        break;
                    case "welcher tag ist heute":
                        say(datum);
                        break;
                    #endregion

                    #region 14. Wikipedia

                    case "was ist youtube":
                        say(wikipedia[r.Next(2)]);


                        WebClient client = new WebClient();

                        using (Stream stream = client.OpenRead("https://de.wikipedia.org/w/api.php?format=json&action=query&prop=extracts&explaintext=1&titles=YouTube"))
                        using (StreamReader reader = new StreamReader(stream))
                        {
                            JsonSerializer ser = new JsonSerializer();
                            Result result = ser.Deserialize<Result>(new JsonTextReader(reader));
                            foreach (Page page in result.query.pages.Values)
                                wiki_Info.Text = page.extract;
                            say(wiki_Info.Text); // Klappt leider mit SubString nicht zu kürzen
                        }

                        break;

                    case "was ist apple":
                        say(wikipedia[r.Next(2)]);


                        WebClient client2 = new WebClient();

                        using (Stream stream = client2.OpenRead("https://de.wikipedia.org/w/api.php?format=json&action=query&prop=extracts&explaintext=1&titles=Apple"))
                        using (StreamReader reader = new StreamReader(stream))
                        {
                            JsonSerializer ser = new JsonSerializer();
                            Result result = ser.Deserialize<Result>(new JsonTextReader(reader));
                            foreach (Page page in result.query.pages.Values)
                                wiki_Info.Text = page.extract;
                            say(wiki_Info.Text);
                        }
                        break;

                    case "was ist google":
                        say(wikipedia[r.Next(2)]);


                        WebClient client3 = new WebClient();

                        using (Stream stream = client3.OpenRead("https://de.wikipedia.org/w/api.php?format=json&action=query&prop=extracts&explaintext=1&titles=Google"))
                        using (StreamReader reader = new StreamReader(stream))
                        {
                            JsonSerializer ser = new JsonSerializer();
                            Result result = ser.Deserialize<Result>(new JsonTextReader(reader));
                            foreach (Page page in result.query.pages.Values)
                                wiki_Info.Text = page.extract;
                            say(wiki_Info.Text);
                        }
                        break;

                    #endregion

                    #region 15. Witze

                    case "erzäh mir einen witz":
                        say(witze[r.Next(12)]);
                        break;
                    case "kannst du mir einen witz erzählen":
                        say(witze[r.Next(12)]);
                        break;
                    case "sei mal witzig":
                        say(witze[r.Next(12)]);
                        break;
                    case "hast du witze auf lager":
                        say(witze[r.Next(12)]);
                        break;
                    case "kennst du irgendwelche witze":
                        say(witze[r.Next(12)]);
                        break;
                    case "erzähl mir bitte einen witz":
                        say(witze[r.Next(12)]);
                        break;
                    case "sei mal lustig":
                        say(witze[r.Next(12)]);
                        break;



                    #endregion

                    #region 16. Ordner auslesen

                    case "wieviele ordner und dateien": // Teil 1 für die Auslesung von Ordnern und Dateien

                        string pfad = Convert.ToString(webBrowser1.Url);
                        pfad = pfad.Substring(8);
                        var anzahlordner = Directory.GetDirectories(pfad).Length;
                        var anzahldaten = Directory.GetFiles(pfad).Length;

                        say("In dem ausgewählten Verzeichnis" + webBrowser1.DocumentTitle + "befinden sich" + anzahlordner + "Ordner und" + anzahldaten + "Dateien");

                        break;

                    case "welche ordner und dateien": // Teil 2

                        string pfad2 = Convert.ToString(webBrowser1.Url);
                        pfad = pfad2.Substring(8);

                        string[] ordnernamen = Directory.GetDirectories(pfad);

                        foreach (string name in ordnernamen)
                        {
                            FileInfo f = new FileInfo(name);
                            ordneransicht_txt.AppendText(f.Name + "\n");
                        }
                        say("In deinem verzeichnis existieren folgende ordner," + ordneransicht_txt.Text);

                        break;
                        
                         #region 17. Wetter

                    case "wie ist das wetter":

                        GetWeather();
                       
                    break;

                    #endregion


                    #endregion

                    #region Verabschieden

                    case "tschüss":
                        say(verabschieden[r.Next(4)]);
                        break;
                    case "danke das wars schon":
                        say(verabschieden[r.Next(4)]);
                        break;
                    case "bis nächstes mal lis":
                        say(verabschieden[r.Next(4)]);
                        break;
                    #endregion

                    #region Öffne Anwendungen

                    case "öffne spiel":
                        say("Ja gerne Ark wird geöffnet");
                        Process.Start(@"E:\Programme (x86)\Steam\steamapps\common\ARK\ShooterGame\Binaries\Win64\ShooterGame_BE.exe"); // Ist zuständig um Anwendungen zu öffnen 
                        break;
                    case "öffne Programme in C":
                        say("Die Programme im Laufwerk C werden geöffnet");
                        this.webBrowser1.Url = new Uri(String.Format("C:\\Program Files"));
                        break;
                    case "öffne programme in e":
                        say("Die Programme im laufwerk e werden geöffnet");
                        this.webBrowser1.Url = new Uri(String.Format("E:\\Programme"));
                        break;
                    case "öffne serien":
                        say("Hier sind deine Serien");
                        this.webBrowser1.Url = new Uri(String.Format("D:\\Serien und Filme\\Serien"));
                        break;
                    case "öffne filme":
                        say("Hier sind deine Filme");
                        this.webBrowser1.Url = new Uri(String.Format("D:\\Serien und Filme\\Filme"));
                        break;
                        #endregion

                        //Stringarrays zusammenfassen und dann aber nur einzelne Elemente daraus antworten lassen
                }
            }
        }


        #region Hilfsmethoden
        private void timer1_Tick(object sender, EventArgs e) // Methode für die Zeit und Datumsanzeige in der Form
        {
            lbl_time.Text = DateTime.Now.ToLongTimeString();
            lbl_date.Text = DateTime.Now.ToLongDateString();
        }

        public void say(String h) // Die Methode say ersetzt s.speakasync bei der Sprachausgabe
        {
            voice.SpeakAsync(h);
        }

        private void LIS_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public class Result
        {
            public Query query { get; set; }
        }

        public class Query
        {
            public Dictionary<String, Page> pages { get; set; }
        }
        public class Page
        {
            public String extract { get; set; }
        }



        private void öffnenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show(); // Anwendung wird einfach wieder Angezeigt
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Anwendung wird geschlossen mit Hilfe der "Form1_Move" Methode
        }



        private void Form1_Move(object sender, EventArgs e)
        { 
            if(this.WindowState == FormWindowState.Minimized) // Hilfe zur Minimierung der Form
        {
            this.Hide();
        }

       
        }
       

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }
        
        async void GetWeather()
        {
            var client = new OpenWeatherMapClient(""); // Hier muss man den eigenen API Key von GetWeatherMap.com eingeben, den man nach dem LogIn bekommt
            String ort = "Rastatt";
            var currentWeather = await client.CurrentWeather.GetByName(ort); // soll drauf warten auf die Antwort vom Client
         

            int Temperatur = Convert.ToInt16(currentWeather.Temperature.Value - 273.15); // Umrechung von Kelvin in Grad, da dies von CurrentWeather nicht in Celsius ausgegeben wird 

           
            say("die aktuelle Temperatur beträgt in: " + ort + Temperatur + "Grad Celsius");
        }

        #endregion
    }
}


// Weitere Enwicklung folgt...
