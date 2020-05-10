using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Xml.Linq;


namespace KimMilyoner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        XElement xQuestions = new XElement("Questions");
        IEnumerable<XElement> xquestion;
        int totalQuestions = 0;
        int currentQuestion = 0;
        int currectAnswer = 0;
        string successMessage = string.Empty;
        string failMessage = string.Empty;
        bool bloadQuestion = false;
        int secondremaining = 30;

        private void Form1_Load(object sender, EventArgs e)
        {
            var qFile = Settings1.Default.ResourceDirectory + "\\QuestionsB.xml";
            xQuestions = XElement.Load(qFile);
            currentQuestion = 0;
            xquestion = from question in xQuestions.Elements("Question")
                        select question;
            totalQuestions = xquestion.Count();

            loadQuestion();
        }

        private void loadQuestion()
        {
            try
            {
                var curQuesion = xquestion.ElementAt(currentQuestion);
                labelQuestionNo.Text = string.Format("Question {0}/{1}", currentQuestion + 1, totalQuestions);
                labelQustion.Text = curQuesion.Attribute("question").Value;
                if (!string.IsNullOrEmpty(curQuesion.Attribute("photo").Value))
                {
                    var photo = Settings1.Default.ResourceDirectory + string.Format("\\{0}", curQuesion.Attribute("photo").Value);

                }
                else
                successMessage = curQuesion.Attribute("success").Value;
                failMessage = curQuesion.Attribute("fail").Value;
                var xanswer = from question in curQuesion.Elements("answers").Elements("answer")
                              select question;
                for (int i = 0; i < 4; i++)
                {
                    var controlName = string.Format("checkBox{0}", i + 1);
                    groupBox1.Controls[controlName].Text = (char)(65 + i) + ". " + xanswer.ElementAt(i).Value;
                    groupBox1.Controls[controlName].Visible = true;
                    groupBox1.Controls[controlName].ForeColor = Color.Black;
                    if (xanswer.ElementAt(i).Attributes().Count() > 0)
                        currectAnswer = i;
                }
                foreach (CheckBox chkbox in groupBox1.Controls)
                {
                    chkbox.Checked = false;
                }
            }
            catch
            {
                currentQuestion = 0;
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            foreach (CheckBox chkbox in groupBox1.Controls)
            {
                if (chkbox.Name != (sender as CheckBox).Name)
                {
                    chkbox.Checked = false;
                }

            }
        }

        private void showResult(string htmlSource)
        {
            if (this.webBrowser1.Document == null)
            {
                this.webBrowser1.DocumentText = htmlSource;
            }
            else
            {
                this.webBrowser1.Document.OpenNew(true);
                this.webBrowser1.Document.Write(htmlSource);
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            bloadQuestion = false;
            var selectedQuestion = -1;
            foreach (CheckBox chkbox in groupBox1.Controls)
            {
                if (chkbox.Checked)
                    selectedQuestion = Convert.ToInt32(chkbox.Name.Substring(8));


            }
            if (selectedQuestion != -1)
            {


                if (correctAnswer(selectedQuestion))
                {



                    SoundPlayer simpleSound = new SoundPlayer(Settings1.Default.Soundfiles + "\\applause3.wav");
                    simpleSound.Play();
                    labelResult.Text = "Correct";
                    labelResult.ForeColor = Color.Green;

                    showResult(string.Format("<img src='{1}\\congrats.jpg'/><br/><h1  style='color:black'>{0}</h1>", successMessage, Settings1.Default.Soundfiles));

                    currentQuestion++;
                    if (currentQuestion >= totalQuestions)
                    {


                    }
                    else
                    {
                        bloadQuestion = true;
                    }

                }
                else
                {
                    labelResult.Text = "Incorrect";
                    labelResult.ForeColor = Color.Red;


                    showResult(string.Format("<img src='{1}\\sorry.jpg'/><br/><h1  style='color:black'>{0}</h1>", failMessage, Settings1.Default.Soundfiles));

                    SoundPlayer simpleSound = new SoundPlayer(Settings1.Default.Soundfiles + "\\explosion_x.wav");
                    simpleSound.Play();
                }
             //   groupBox2.Visible = true;

            }
            else
            {

            }
        }
     
        private bool correctAnswer(int selectedAnswer)
        {
            if (currectAnswer + 1 == selectedAnswer)
            {
                var controlName = string.Format("checkBox{0}", selectedAnswer);
                groupBox1.Controls[controlName].ForeColor = Color.Green;


                return true;
            }
            else
            {
                var controlName = string.Format("checkBox{0}", selectedAnswer);
                groupBox1.Controls[controlName].ForeColor = Color.Red;
                return false;
            }



        }

        private void button5050_Click(object sender, EventArgs e)
        {
            var incorrectAnswers = new List<int>();
            foreach (CheckBox chkbox in groupBox1.Controls)
            {

                var selectedQuestion = Convert.ToInt32(chkbox.Name.Substring(8));
                if (selectedQuestion != currectAnswer + 1)
                {
                    incorrectAnswers.Add(selectedQuestion);
                }
            }
            var randomidx = new Random().Next(0, 2);
            var randomincorrect = incorrectAnswers[randomidx];
            foreach (CheckBox chkbox in groupBox1.Controls)
            {
                chkbox.Visible = false;
                var selectedQuestion = Convert.ToInt32(chkbox.Name.Substring(8));
                if (selectedQuestion == currectAnswer + 1 || selectedQuestion == randomincorrect)
                {
                    chkbox.Visible = true;

                }
            }
            button5050.Enabled = false;
            secondremaining += 15;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            secondremaining--;

            if (secondremaining <= -1)
            {
                timer1.Enabled = false;
                SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\tada.wav");
                simpleSound.Play();
                MessageBox.Show("Süreniz doldu");
            }
            else
            {
                showTimeRemaining();
            }

        }

        private void showTimeRemaining()
        {
            System.Windows.Forms.Application.DoEvents();
            labelResult.Text = secondremaining.ToString();

            showResult("second(s) remaining");
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\Speech Off.wav");
            simpleSound.Play();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Next question, unnecesary on clicks.
            //if (currentQuestion < (totalQuestions - 1))
            //    currentQuestion++;
            //loadQuestion();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bloadQuestion = false;
            var selectedQuestion = -1;
            foreach (CheckBox chkbox in groupBox1.Controls)
            {
                if (chkbox.Checked)
                    selectedQuestion = Convert.ToInt32(chkbox.Name.Substring(8));


            }
            if (selectedQuestion != -1)
            {


                if (correctAnswer(selectedQuestion))
                {


                    timer1.Enabled = false;
                    SoundPlayer simpleSound = new SoundPlayer(Settings1.Default.Soundfiles + "\\applause3.wav");
                    simpleSound.Play();
                    labelResult.Text = "Correct";
                    labelResult.ForeColor = Color.Green;
                    

                    showResult(string.Format("<img src='{1}\\congrats.jpg'/><br/><h1  style='color:black'>{0}</h1>", successMessage, Settings1.Default.Soundfiles));
                    System.Threading.Thread.Sleep(2000);


                    if (currentQuestion < (totalQuestions - 1))
                        currentQuestion++;
                    labelResult.ForeColor = Color.Black;
                    loadQuestion();
                    secondremaining = 30;
                    timer1.Enabled = true;
                    if (currentQuestion >= totalQuestions)
                    {
    
                    }
                    else
                    {
                        bloadQuestion = true;
                    }

                }
                else
                {
                    labelResult.Text = "Incorrect";
                    labelResult.ForeColor = Color.Red;
                    timer1.Enabled = false;

                    showResult(string.Format("<img src='{1}\\sorry.jpg'/><br/><h1  style='color:black'>{0}</h1>", failMessage, Settings1.Default.Soundfiles));

                    SoundPlayer simpleSound = new SoundPlayer(Settings1.Default.Soundfiles + "\\explosion_x.wav");
                    simpleSound.Play();
                    labelResult.Text = "Yanlış cevap";
                    System.Threading.Thread.Sleep(2000);
                    Application.Exit();
                }

            }
            else
            {

            }
        }

        private void tanidiaSor_Click(object sender, EventArgs e)
        {
            secondremaining += 15;
            timer1.Enabled = true; ;
            showTimeRemaining();
            tanidiaSor.Enabled = false;
        }
    }
}
