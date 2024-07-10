using static yoshiaki_is_god.Form1;

namespace yoshiaki_is_god
{
    public partial class Form1 : Form
    {
        List<Quiz> Quizes = new List<Quiz>();
        int QuizIndex = 0; // 現在のクイズ
        int player1 = 0;
        String player1Click = "ture";
        public class Quiz
        {
            public Quiz(string question, string[] choices, string answer)
            {
                Question = question;
                Choices = choices;
                Answer = answer;
            }

            public string Question = "";
            public string[] Choices = null;
            public string Answer = "";
        }
        public Form1()
        {
            InitializeComponent();

            InitQuizes();

            if (Quizes.Count > 0)
                ShowQuiz(0);

            SetClickEventHandlers();

            EnableButtons();
        }
        void InitQuizes()
        {
            Quizes.Add(new Quiz("清野オサムの本名はどれか？", new string[] { "正文", "オサム", "修史", "真史" }, "オサム"));
            Quizes.Add(new Quiz("薬師如来像は1.418 ｍ,日光菩薩像は1.694 ｍ月光菩薩像は？", new string[] { "1.726m", "1.759m", "1.739m", "1.768m" }, "1.739m"));
            Quizes.Add(new Quiz("メロドラマの「メロ」の元々の意味は？", new string[] { "歌", "思い出", "浮気", "キス" }, "歌"));
            Quizes.Add(new Quiz("スウィーツでモンブランの「モン」フランス語の意味は？", new string[] { "果実", "山", "海", "雪" }, "山"));
            Quizes.Add(new Quiz("慣用句「鶴の一声」の前につくのは「○の千声」？", new string[] { "はと", "きじ", "すずめ", "からす" }, "すずめ"));
            Quizes.Add(new Quiz("メロドラマの「メロ」の元々の意味は？", new string[] { "歌", "思い出", "浮気", "キス" }, "歌"));
            Quizes.Add(new Quiz("スウィーツでモンブランの「モン」フランス語の意味は？", new string[] { "果実", "山", "海", "雪" }, "山"));
            Quizes.Add(new Quiz("慣用句「鶴の一声」の前につくのは「○の千声」？", new string[] { "はと", "きじ", "すずめ", "からす" }, "すずめ"));
            Quizes.Add(new Quiz("メロドラマの「メロ」の元々の意味は？", new string[] { "歌", "思い出", "浮気", "キス" }, "歌"));
            Quizes.Add(new Quiz("スウィーツでモンブランの「モン」フランス語の意味は？", new string[] { "果実", "山", "海", "雪" }, "山"));
            Quizes.Add(new Quiz("慣用句「鶴の一声」の前につくのは「○の千声」？", new string[] { "はと", "きじ", "すずめ", "からす" }, "すずめ"));
            Quizes.Add(new Quiz("メロドラマの「メロ」の元々の意味は？", new string[] { "歌", "思い出", "浮気", "キス" }, "歌"));
            Quizes.Add(new Quiz("スウィーツでモンブランの「モン」フランス語の意味は？", new string[] { "果実", "山", "海", "雪" }, "山"));
            Quizes.Add(new Quiz("慣用句「鶴の一声」の前につくのは「○の千声」？", new string[] { "はと", "きじ", "すずめ", "からす" }, "すずめ"));
            Quizes.Add(new Quiz("メロドラマの「メロ」の元々の意味は？", new string[] { "歌", "思い出", "浮気", "キス" }, "歌"));
            Quizes.Add(new Quiz("スウィーツでモンブランの「モン」フランス語の意味は？", new string[] { "果実", "山", "海", "雪" }, "山"));
            Quizes.Add(new Quiz("慣用句「鶴の一声」の前につくのは「○の千声」？", new string[] { "はと", "きじ", "すずめ", "からす" }, "すずめ"));
            Quizes.Add(new Quiz("メロドラマの「メロ」の元々の意味は？", new string[] { "歌", "思い出", "浮気", "キス" }, "歌"));
            Quizes.Add(new Quiz("スウィーツでモンブランの「モン」フランス語の意味は？", new string[] { "果実", "山", "海", "雪" }, "山"));
            Quizes.Add(new Quiz("慣用句「鶴の一声」の前につくのは「○の千声」？", new string[] { "はと", "きじ", "すずめ", "からす" }, "すずめ"));
            Quizes.Add(new Quiz("メロドラマの「メロ」の元々の意味は？", new string[] { "歌", "思い出", "浮気", "キス" }, "歌"));
            Quizes.Add(new Quiz("スウィーツでモンブランの「モン」フランス語の意味は？", new string[] { "果実", "山", "海", "雪" }, "山"));
            Quizes.Add(new Quiz("慣用句「鶴の一声」の前につくのは「○の千声」？", new string[] { "はと", "きじ", "すずめ", "からす" }, "すずめ"));
            Quizes.Add(new Quiz("メロドラマの「メロ」の元々の意味は？", new string[] { "歌", "思い出", "浮気", "キス" }, "歌"));
            Quizes.Add(new Quiz("スウィーツでモンブランの「モン」フランス語の意味は？", new string[] { "果実", "山", "海", "雪" }, "山"));
            Quizes.Add(new Quiz("慣用句「鶴の一声」の前につくのは「○の千声」？", new string[] { "はと", "きじ", "すずめ", "からす" }, "すずめ"));
            Quizes.Add(new Quiz("メロドラマの「メロ」の元々の意味は？", new string[] { "歌", "思い出", "浮気", "キス" }, "歌"));
            Quizes.Add(new Quiz("スウィーツでモンブランの「モン」フランス語の意味は？", new string[] { "果実", "山", "海", "雪" }, "山"));
<<<<<<< HEAD
=======

>>>>>>> origin/main
            Quizes.Add(new Quiz("慣用句「鶴の一声」の前につくのは「○の千声」？", new string[] { "はと", "osamu", "すずめ", "からす" }, "すずめ"));
            Quizes.Add(new Quiz("メロドラマの「メロ」の元々の意味は？", new string[] { "歌", "思い出", "浮気", "osamu" }, "歌"));
            Quizes.Add(new Quiz("メロドラマの「メロ」の元々の意味は？", new string[] { "歌", "思い出", "浮気", "osamu" }, "歌"));

            Quizes.Add(new Quiz("慣用句「鶴の一声」の前につくのは「○の千声」？", new string[] { "はと", "きじ", "すずめ", "からす" }, "すずめ"));
            Quizes.Add(new Quiz("メロドラマの「メロ」の元々の意味は？", new string[] { "歌", "思い出", "浮気", "キス" }, "歌"));
            Quizes.Add(new Quiz("清野オサムの本名はどれか？", new string[] { "正文", "オサム", "修史", "真史" }, "オサム"));
<<<<<<< HEAD
=======

>>>>>>> origin/main
        }
        void ShowQuiz(int i)
        {
            Quiz quiz = Quizes[i];
            LabelsUnVisible();
            labelQuestion.Text = quiz.Question;

            if (quiz.Choices.Length >= 1 && quiz.Choices[0] != "")
            {
                labelChoices1.Text = quiz.Choices[0];
                labelChoices1.Visible = true;
            }
            if (quiz.Choices.Length >= 2 && quiz.Choices[1] != "")
            {
                labelChoices2.Text = quiz.Choices[1];
                labelChoices2.Visible = true;
            }
            if (quiz.Choices.Length >= 3 && quiz.Choices[2] != "")
            {
                labelChoices3.Text = quiz.Choices[2];
                labelChoices3.Visible = true;
            }
            if (quiz.Choices.Length >= 4 && quiz.Choices[3] != "")
            {
                labelChoices4.Text = quiz.Choices[3];
                labelChoices4.Visible = true;
            }
        }

        void LabelsUnVisible()
        {
            labelChoices1.Visible = false;
            labelChoices2.Visible = false;
            labelChoices3.Visible = false;
            labelChoices4.Visible = false;
        }
        void SetClickEventHandlers()
        {
            labelChoices1.Click += LabelChoices_Click;
            labelChoices2.Click += LabelChoices_Click;
            labelChoices3.Click += LabelChoices_Click;
            labelChoices4.Click += LabelChoices_Click;
        }
        private void LabelChoices_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            if (((labelChoices1.Visible == true) || (labelChoices2.Visible == true) || (labelChoices3.Visible == true) || (labelChoices4.Visible == true)) && (Judg(QuizIndex, label.Text) && (player1Click == "false")))
            {
                player1++;
                label5.Text = player1.ToString();
            }
            if (((labelChoices1.Visible == true) || (labelChoices2.Visible == true) || (labelChoices3.Visible == true) || (labelChoices4.Visible == true)) && (Judg(QuizIndex, label.Text)==false) && (player1Click == "false"))
            {
                player1--;
                label5.Text = player1.ToString();
            }

            labelResult.ForeColor = Color.White;
            if (Judg(QuizIndex, label.Text))
            {
                labelResult.BackColor = Color.Red;
                labelResult.Text = "正解！";
            }
            else
            {
                labelResult.BackColor = Color.Black;
                labelResult.Text = "残念！";
            }
            labelResult.Visible = true;
        }
        bool Judg(int i, string choice)
        {
            if (Quizes[i].Answer == choice)
                return true;
            else
                return false;
        }
        void EnableButtons()
        {
            if (QuizIndex > 0)
                buttonPrev.Enabled = true;
            else
                buttonPrev.Enabled = false;

            if (QuizIndex < Quizes.Count - 1)
                buttonNext.Enabled = true;
            else
                buttonNext.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (0 < QuizIndex)
            {
                QuizIndex--;
                ShowQuiz(QuizIndex);
            }

            EnableButtons();

            // 前の問題が表示されるので、これまで表示されていた問題の結果は非表示にする
            labelResult.Visible = false;
        }

        private void buttonNext_Click_1(object sender, EventArgs e)
        {
            if (QuizIndex < Quizes.Count - 1)
            {
                QuizIndex++;
                ShowQuiz(QuizIndex);
            }
            EnableButtons();

            // 次の問題が表示されるので、これまで表示されていた問題の結果は非表示にする
            labelResult.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void labelChoices1_Click(object sender, EventArgs e)
        {
            player1Click = "false";
        }

        private void labelChoices2_Click(object sender, EventArgs e)
        {
            player1Click = "false";
        }

        private void labelChoices3_Click(object sender, EventArgs e)
        {
            player1Click = "false";
        }

        private void labelChoices4_Click(object sender, EventArgs e)
        {
            player1Click = "false";
        }
    }
}