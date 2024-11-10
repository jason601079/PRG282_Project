using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Guna.UI2.WinForms;
using PRG282_Project.Business_Logic_Layer;


namespace PRG282_Project.Presentation_Layer.Applicant
{
    public partial class ApplicantQuiz : Form
    {
        private List<string> questions = new List<string>();
        private List<string> correctAnswers = new List<string>();
        private int currentQuestion = 0;
        private int score = 0;
        private Guna2Button questionBtn;
        private Guna2Button[] navButtons;
        private Guna2Button[] optionButtons;
        private Dictionary<int, (string SelectedAnswer, bool IsCorrect)> userAnswers = new Dictionary<int, (string, bool)>();
        private string filePath = @"Applicant.txt";
        private Applicant applicant; 
        public int currentApplicantID;
        private double percentageScore;



        public ApplicantQuiz(int applicantID)
        {
            InitializeComponent();
            LoadQuizContent();
            currentApplicantID = applicantID; 
        }

        private void ApplicantQuiz_Load(object sender, EventArgs e)
        {

        }

        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
            LoadQuizContent();
            CreateQuizControls();
            DisplayQuestion();
        }

        public void LoadQuizContent()
        {
            try
            {
                questions = new List<string>(File.ReadAllLines("_questions.txt"));
                correctAnswers = new List<string>(File.ReadAllLines("_answers.txt"));

                if (questions.Count != correctAnswers.Count)
                {
                    MessageBox.Show("Error: Mismatched questions and answers.");
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading quiz content: {ex.Message}");
            }
        }

        private void CreateQuizControls()
        {
            panel_Main_Middle.Controls.Remove(btnStartQuiz);

            questionBtn = new Guna2Button
            {
                Size = new Size(540, 60),
                Location = new Point(80, 150),
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                TextAlign = HorizontalAlignment.Center,

                FillColor = Color.LightGray,
                ForeColor = Color.White,

                DisabledState =
                {
                    FillColor = Color.FromArgb(32,52,84),
                    ForeColor = Color.White,
                    BorderColor = Color.Transparent
                },

                Enabled = false 
            };
            panel_Main_Middle.Controls.Add(questionBtn);

            optionButtons = new Guna2Button[4];
            for (int i = 0; i < 4; i++)
            {
                optionButtons[i] = new Guna2Button
                {
                    Size = new Size(400, 50),
                    Location = new Point(150, 255 + (i * 55)),
                    FillColor = Color.FromArgb(120, 141, 200),
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                    Tag = i + 1,
                    Cursor = Cursors.Hand,
                    TextAlign = HorizontalAlignment.Center,


                };

                optionButtons[i].Click += OptionButton_Click;
                panel_Main_Middle.Controls.Add(optionButtons[i]);
            }

            navButtons = new Guna2Button[2];
            for (int i = 0; i < 2; i++)
            {
                navButtons[i] = new Guna2Button
                {
                    Size = new Size(80, 50),
                    Location = new Point(50 + (i * 515), 420),
                    FillColor = Color.FromArgb(120, 141, 200),
                    Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                    Tag = i + 1,
                    Cursor = Cursors.Hand,
                    TextAlign = HorizontalAlignment.Center
                };


                if (i == 0)
                {
                    navButtons[i].Text = "Back";
                    navButtons[i].Click += btnBack_Click;
                }
                else
                {
                    navButtons[i].Text = "Forward";
                    navButtons[i].Click += btnNext_Click;
                }

                panel_Main_Middle.Controls.Add(navButtons[i]);
            }
        }

        private void DisplayQuestion()
        {
            if (currentQuestion < questions.Count)
            {
                string[] questionParts = questions[currentQuestion].Split('|');
                questionBtn.Text = questionParts[0];

                for (int i = 0; i < 4; i++)
                {
                    optionButtons[i].Text = questionParts[i + 1];
                    optionButtons[i].Enabled = true;
                    optionButtons[i].FillColor = Color.FromArgb(94, 148, 255);
                    optionButtons[i].DisabledState.FillColor = Color.FromArgb(94, 148, 255);
                    optionButtons[i].DisabledState.ForeColor = Color.White;
                }

                if (userAnswers.ContainsKey(currentQuestion))
                {
                    var (selectedAnswer, isCorrect) = userAnswers[currentQuestion];

                    foreach (var btn in optionButtons)
                    {
                        if (btn.Text == selectedAnswer)
                        {
                            btn.FillColor = isCorrect ? Color.FromArgb(39, 174, 96) : Color.FromArgb(231, 76, 60);
                            btn.DisabledState.FillColor = btn.FillColor;
                        }

                        if (!isCorrect && btn.Text == correctAnswers[currentQuestion])
                        {
                            btn.FillColor = Color.FromArgb(39, 174, 96);
                            btn.DisabledState.FillColor = Color.FromArgb(39, 174, 96);
                        }

                        btn.Enabled = false;
                    }
                }
            }
        }

        public void OptionButton_Click(object sender, EventArgs e)
        {
            Guna2Button clickedButton = (Guna2Button)sender;
            string selectedAnswer = clickedButton.Text;

            bool isCorrect = selectedAnswer == correctAnswers[currentQuestion];

            if (isCorrect)
            {
                score++;
                clickedButton.FillColor = Color.FromArgb(39, 174, 96);
                clickedButton.DisabledState.FillColor = Color.FromArgb(39, 174, 96);
            }
            else
            {
                clickedButton.FillColor = Color.FromArgb(231, 76, 60);
                clickedButton.DisabledState.FillColor = Color.FromArgb(231, 76, 60);

                foreach (var btn in optionButtons)
                {
                    if (btn.Text == correctAnswers[currentQuestion])
                    {
                        btn.FillColor = Color.FromArgb(39, 174, 96);
                        btn.DisabledState.FillColor = Color.FromArgb(39, 174, 96);
                        break;
                    }
                }
            }

            userAnswers[currentQuestion] = (selectedAnswer, isCorrect);

            foreach (var btn in optionButtons)
            {
                btn.Enabled = false;
            }

            if (userAnswers.Count == questions.Count)
            {
                
                FinishQuiz(currentApplicantID);
                DisplayPieChart();
            }
            

        }
        private void btnNext_Click(object sender, EventArgs e)
        {
         
            if (currentQuestion < questions.Count - 1)
            {
                currentQuestion++;
                DisplayQuestion();
            }
            else
            {
            
                if (userAnswers.Count < questions.Count)
                {
                    MessageBox.Show("Some questions are still unanswered. Use the navigation buttons to review and complete them.");
                }
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            if (currentQuestion > 0)
            {
                currentQuestion--;
                DisplayQuestion();
            }
        }

        public void FinishQuiz(int applicantID)
        {
            percentageScore = ((double)score / questions.Count) * 100; 
           
            if (applicantID > 0)
            {
                WriteApplicant(applicantID);
            }
            else
            {
                MessageBox.Show("Error: Invalid Applicant ID.");
            }
        }



        public void WriteApplicant(int applicantID)
        {
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Applicant.txt");
                if (File.Exists(filePath))
                {
                    var allLines = File.ReadAllLines(filePath).ToList();
                    for (int i = 0; i < allLines.Count; i++)
                    {
                        string[] parts = allLines[i].Split(',');
                        if (parts.Length > 0 && int.TryParse(parts[0], out int id) && id == applicantID)
                        {
                            // Create a List<string> to make manipulation easier
                            var partsList = parts.ToList();

                            // Format score with invariant culture
                            string formattedScore = percentageScore.ToString("F1", CultureInfo.InvariantCulture) + "%";

                            // Update or append the score
                            if (partsList.Count >= 8)
                            {
                                partsList[7] = formattedScore;
                            }
                            else
                            {
                                partsList.Add(formattedScore);
                            }

                            // Join back into a single line
                            allLines[i] = string.Join(",", partsList);
                            break;
                        }
                    }
                    File.WriteAllLines(filePath, allLines);
                }
                else
                {
                    MessageBox.Show("Applicant file not found!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error writing applicant percentage score: {ex.Message}");
            }
        }




        public string ReadApplicant(int applicantID)
        {
            try
            {

                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');

                        if (int.TryParse(parts[0], out int fileApplicantID))
                        {
                            if (fileApplicantID == applicantID)
                            {
                                return line; 
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Failed to parse ID from: {line}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

            MessageBox.Show("Applicant not found after reading all lines.");
            return null; 
        }




        private void DisplayPieChart()
        {

            panel_Main_Middle.Controls.Clear();

            Label label = new Label
            {
                Size = new Size(250, 65),
                Location = new Point(230, 120),
                BackColor = Color.FromArgb(30, 30, 30),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 16, FontStyle.Regular),
                Text = "Quiz Completed!\nResults:",
                TextAlign = ContentAlignment.MiddleCenter
            };

            Chart pieChart = new Chart
            {
                Size = new Size(250, 250),
                Location = new Point(230, 200),
                BackColor = Color.FromArgb(30, 30, 30)
            };


            ChartArea chartArea = new ChartArea
            {
                BackColor = Color.FromArgb(30, 30, 30),
                ShadowColor = Color.Black
            };
            pieChart.ChartAreas.Add(chartArea);


            Series series = new Series
            {
                Name = "Results",
                IsValueShownAsLabel = true,
                ChartType = SeriesChartType.Pie
            };


            series.Points.AddXY("Correct", score);
            series.Points.AddXY("Incorrect", questions.Count - score);

            series.Points[0].Color = Color.FromArgb(39, 174, 96);
            series.Points[1].Color = Color.FromArgb(231, 76, 60);


            pieChart.Series.Add(series);

            panel_Main_Middle.Controls.Add(label);
            panel_Main_Middle.Controls.Add(pieChart);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
            
            
        }
    }
}
