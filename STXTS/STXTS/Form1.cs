using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Speech.Recognition;
using System.Runtime.InteropServices;

namespace STXTS
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {            
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txattachment.Text = openFileDialog1.FileName.ToString();
            }
        }
        static SpeechRecognitionEngine sp_email;
        static SpeechRecognitionEngine commands;
        static SpeechRecognitionEngine sp_reciever;
        static SpeechRecognitionEngine sp_subject;
        static SpeechRecognitionEngine sp_password;
        static SpeechRecognitionEngine sp_body;
        
        static Grammar Mycommands()
        {
            
            string[] actions = new string[] { "about","start listening email","send message","start listening password", "start listening subject", "start listening reciever", "start listening body" };
            GrammarBuilder gb = new GrammarBuilder(new Choices(actions));
            gb.Culture = new System.Globalization.CultureInfo("en-GB");
            Grammar g = new Grammar(gb);
            return (g);
        }
        static Grammar email_G()
        {

            string[] actions = new string[] { "akshay","yadav","stop listening email","@","gmail","com",".","c","0","o","m" };
            GrammarBuilder emailb = new GrammarBuilder(new Choices(actions));
            Grammar email = new Grammar(emailb);
            return (email);
        }
        static Grammar subject_G()
        {

            string[] actions = new string[] { "a", "A", "b", "B", "c", "C", "d", "D", "e", "E", "f", "F", "g", "G", "h", "H", "i", "I", "j", "J", "k", "K", "l", "L", "m", "M", "n", "N", "o", "O", "p", "P", "q", "Q", "r", "R", "s", "S", "t", "T", "u", "U", "v", "V", "x", "X", "y", "Y", "z", "Z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "!", "@", "#", "$", "%", "&", "*", "_", ".", ",", "-", "+", "=", "/", "?", ";", ":","stop listening subject" };
            GrammarBuilder subjectb = new GrammarBuilder(new Choices(actions));
            subjectb.Culture = new System.Globalization.CultureInfo("en-GB");
            Grammar subject = new Grammar(subjectb);
            return (subject);
        }
        static Grammar reciever_G()
        {

            string[] actions = new string[] { "kamesh","yadav","k","y","stop listening reciever","@","gmail.com", ".", "c", "0", "o", "m", "delete character", "erase whole line" };
            GrammarBuilder recieverb = new GrammarBuilder(new Choices(actions));
            Grammar reciever = new Grammar(recieverb);
            return (reciever);
        }
        static Grammar password_G()
        {

            string[] actions = new string[] { "stop listening password", "a","A","b","B","c","C","d","D","e","E","f","F","g","G","h","H","i","I","j","J","k","K","l","L","m","M","n","N","o","O","p","P","q","Q","r","R","s","S","t","T","u","U","v","V","x","X","y","Y","z","Z","0","1","2","3","4","5","6","7","8","9","10","!","@","#","$","%","&","*","_",".",",","-","+","=","/","?",";",":"};
            GrammarBuilder psswrdb = new GrammarBuilder(new Choices(actions));
            Grammar psswrd = new Grammar(psswrdb);
            return (psswrd);
        }

        private void sp_email_SpeechRecognized(object ob, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Text != "stop listening email")
            {
                
                    txuser_email.Text += e.Result.Text;
               
            }
            
            else
            {
                command_box.Text += e.Result.Text;
                sp_email.RecognizeAsyncStop();
                sp_email.UnloadAllGrammars();
                comm_Click(ob, e);

            }

        }
        private void sp_body_SpeechRecognized(object ob, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Text != "stop listening body")
            {

                txbody.Text += e.Result.Text;

            }

            else
            {
                command_box.Text += e.Result.Text;
                sp_email.RecognizeAsyncStop();
                sp_email.UnloadAllGrammars();
                comm_Click(ob, e);

            }
        }
        private void sp_reciever_SpeechRecognized(object ob, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Text != "stop listening reciever")
            {
                txreciever.Text += e.Result.Text;
             }

            else
            {
                command_box.Text += e.Result.Text;
                sp_reciever.RecognizeAsyncStop();
                sp_reciever.UnloadAllGrammars();
                comm_Click(ob, e);

            }

        }
        private void sp_password_SpeechRecognized(object ob, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Text != "stop listening password")
            {
                txpassword.Text += e.Result.Text;
            }
            else
            {
                command_box.Text += e.Result.Text;
                sp_password.RecognizeAsyncStop();
                sp_password.UnloadAllGrammars();
                comm_Click(ob, e);

            }

        }
        private void sp_subject_SpeechRecognized(object ob, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Text != "stop listening subject")
            {
                txsubject.Text += e.Result.Text;
            }
            else
            {
                command_box.Text += e.Result.Text;
                sp_subject.RecognizeAsyncStop();
                sp_subject.UnloadAllGrammars();
                comm_Click(ob, e);

            }

        }

        private void commands_SpeechRecognized(object ob, SpeechRecognizedEventArgs e)
        {
            command_box.Text += e.Result.Text;
            if (e.Result.Text == "start listening email")
            {
                commands.RecognizeAsyncStop();
                commands.UnloadAllGrammars();
                email_speech(ob, e);
            }
            else if (e.Result.Text == "start listening password")
            {
                commands.RecognizeAsyncStop();
                commands.UnloadAllGrammars();
                password_speech(ob, e);
            }
            else if (e.Result.Text == "start listening reciever")
            {
                commands.RecognizeAsyncStop();
                commands.UnloadAllGrammars();
                reciever_speech(ob, e);
            }
            else if (e.Result.Text == "start listening subject")
            {
                commands.RecognizeAsyncStop();
                commands.UnloadAllGrammars();
                subject_speech(ob, e);
            }
            else if (e.Result.Text == "start listening body")
            {
                commands.RecognizeAsyncStop();
                commands.UnloadAllGrammars();
                body_speech(ob, e);
            }
            else if (e.Result.Text == "send message")
            {
                btnsend_Click(ob, e);
            }
            else if (e.Result.Text == "about")
            {
                about(ob, e);
            }
        }

        private void about(object sender, EventArgs e)
        {   
            MessageBox.Show("developed by AKSHAY YADAV");
        }
        private void txuser_email_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                MailMessage message = new MailMessage();
                message.From = new MailAddress(txuser_email.Text);
                message.To.Add(txreciever.Text);
                message.Body = body.Text;
                message.Subject = txsubject.Text;
                client.UseDefaultCredentials = false;
                client.EnableSsl = true;
                if (txattachment.Text != "")
                {
                    message.Attachments.Add(new Attachment(txattachment.Text));
                }
                client.Credentials = new System.Net.NetworkCredential(txuser_email.Text, txpassword.Text);
                client.Send(message);
                message = null;
                MessageBox.Show("message sent");

            }

            catch (Exception s)
            {
                MessageBox.Show("failed to send message");
            }
        }

        private void email_speech(object sender, EventArgs e)
        {
            sp_email = new SpeechRecognitionEngine();
            sp_email.SetInputToDefaultAudioDevice();
            Grammar email = email_G();
            sp_email.LoadGrammar(email);
            sp_email.RecognizeAsync(RecognizeMode.Multiple);
            sp_email.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(sp_email_SpeechRecognized);
        }
        private void body_speech(object sender, EventArgs e)
        {
            sp_body = new SpeechRecognitionEngine();
            sp_body.SetInputToDefaultAudioDevice();
            Grammar body = new DictationGrammar();
            sp_body.LoadGrammar(new DictationGrammar());
            sp_body.RecognizeAsync(RecognizeMode.Multiple);
            sp_body.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(sp_body_SpeechRecognized);
        }
        private void subject_speech(object sender, EventArgs e)
        {
            sp_subject = new SpeechRecognitionEngine();
            sp_subject.SetInputToDefaultAudioDevice();
            Grammar subject = subject_G();
            sp_subject.LoadGrammar(subject);
            sp_subject.RecognizeAsync(RecognizeMode.Multiple);
            sp_subject.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(sp_subject_SpeechRecognized);
        }
        private void reciever_speech(object sender, EventArgs e)
        {
            sp_reciever = new SpeechRecognitionEngine();
            sp_reciever.SetInputToDefaultAudioDevice();
            Grammar reciever = reciever_G();
            sp_reciever.LoadGrammar(reciever);
            sp_reciever.RecognizeAsync(RecognizeMode.Multiple);
            sp_reciever.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(sp_reciever_SpeechRecognized);
        }
        private void password_speech(object sender, EventArgs e)
        {
            sp_password = new SpeechRecognitionEngine();
            sp_password.SetInputToDefaultAudioDevice();
            Grammar email = password_G();
            sp_password.LoadGrammar(email);
            sp_password.RecognizeAsync(RecognizeMode.Multiple);
            sp_password.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(sp_password_SpeechRecognized);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
       
        
        private void comm_Click(object sender, EventArgs e)
        {
           
            commands = new SpeechRecognitionEngine();
            commands.SetInputToDefaultAudioDevice();
            Grammar g = Mycommands();
            commands.LoadGrammar(g);
            commands.RecognizeAsync(RecognizeMode.Multiple);
            commands.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(commands_SpeechRecognized);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
