using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace B2B
{
    public partial class MainForm : Form
    {
        private HashSet<long> allFileNumbersFactorials;
        public MainForm()
        {
            InitializeComponent();
            AllFileNumbersFactorials= new HashSet<long>();
        }

        public HashSet<long> AllFileNumbersFactorials { get => allFileNumbersFactorials; set => allFileNumbersFactorials = value; }

        private void SelectFileBtnClick(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new();
            openFileDialog.InitialDirectory = "C:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string? filePath = openFileDialog.FileName;
                FilePathTxt.Text = filePath;
            }
        }

        private void GetWordAnagramsBtnClick(object sender, EventArgs e)
        {
            bool thisIsANumber = int.TryParse(WordTxt.Text, out _);
            if (thisIsANumber)
            {
                try
                {
                    var isInteger = int.TryParse(WordTxt.Text, out int userInput);
                    if (isInteger)
                    {
                        bool result = MathService.IsFactorial(userInput, AllFileNumbersFactorials);
                        MessageBox.Show(result == true ? string.Format( userInput + " Is a factorial of a number in uploded file" ) : "Sorry Provided Number Is Not A Factorial Of Any Number", "Output", MessageBoxButtons.OK);
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Please Enter A Valid Number", "Warning!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);

                }
            }
            else
            {
                List<string> listOfAnagrams = WordService.GetAnagramsOfWord(WordTxt.Text);
                _ = MessageBox.Show(string.Join(" - ", listOfAnagrams), "All Candidates Count : " + listOfAnagrams.Count);

            }
     
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private async void GetAnagramsBtnClick(object sender, EventArgs e)
        {
            try
            {
                var filePath = FilePathTxt.Text;
                long factorial;
                List<int> fileNumbers = new();
                List<string> fileContent = await AnagramService.FileReader(filePath);
                List<string> fileContentWords = AnagramService.FileContentSplitter(fileContent, out fileNumbers);
                AnagramService.IsAnagramOutput(AnagramService.anagramresult(fileContentWords));


                await Task.Run(() => {
                    foreach (var number in fileNumbers)
                    {
                        factorial = MathService.GetFactorial(number);
                        AllFileNumbersFactorials.Add(factorial);
                    }
                });
            }
            catch (Exception)
            {
              MessageBox.Show("Please Enter Valid File First", "Warning!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);

            }

        }

        private void WordLbl_Click(object sender, EventArgs e)
        {

        }

        private void WordTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}