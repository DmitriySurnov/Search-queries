using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Poisk
{
    public partial class FormInformationSearch : System.Windows.Forms.Form
    {
        private int _position = 0;

        public FormInformationSearch()
        {
            InitializeComponent();
        }

        private void ErrorBox()
        {
            MessageBox.Show(
                   "Вы не ввели запрос для поиска",
                   "Ошибка",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            listBoxResult.Items.Clear();
            if (string.IsNullOrWhiteSpace(textBoxQueryString.Text))
            {
                ErrorBox();
                return;
            }
            Uri baseURI = new Uri("https://www.google.com");
            Uri newURI = new Uri(baseURI, "search?q=" + textBoxQueryString.Text.Replace(" ", "+"));
            HttpWebRequest reqw = (HttpWebRequest)HttpWebRequest.Create(newURI);
            reqw.UserAgent = "SimpleHostClient";
            HttpWebResponse resp = (HttpWebResponse)reqw.GetResponse(); //создаем объект отклика
            StreamReader sr = new StreamReader(resp.GetResponseStream(), Encoding.Default);
            //создаем поток для чтения отклика
            string htmlDocument = sr.ReadToEnd();
            for (int i = 0; i < 10; i++)
            {
                string resultingString = ParsingHTML(htmlDocument, "<h3", "</div>", '>');
                if (resultingString == "")
                    continue;
                listBoxResult.Items.Add(ParsingHTML(resultingString));
            }
            sr.Close();
        }

        private string ParsingHTML(string htmlDocument, string beginningOfLine, 
            string endOfLine, char symbolOfBeginningOfSubstring)
        {
            int strtIndex = htmlDocument.IndexOf(beginningOfLine, _position);
            if (strtIndex == -1)
                return "";
            int endIndex = htmlDocument.IndexOf(endOfLine, strtIndex);
            if (endIndex == -1) 
                return "";
            string resultingString = htmlDocument.Substring(strtIndex, endIndex - strtIndex);
            resultingString = resultingString.Remove(0, beginningOfLine.Length);
            _position = endIndex;
            resultingString = resultingString.Replace(";", "");
            resultingString = resultingString.Remove(0, resultingString.LastIndexOf(symbolOfBeginningOfSubstring) + 1);
            return resultingString;
        }

        private string ParsingHTML(string htmlDocument)
        {
            int strtIndex = htmlDocument.IndexOf("&#");
            if (strtIndex == -1)
                return htmlDocument;
            string Code = htmlDocument.Substring(strtIndex, 6);
            Code = Code.Replace("&#", "");
            int сharacterCode = int.Parse(Code);
            char symbol = (char)сharacterCode;
            Code = htmlDocument.Substring(strtIndex, 6);
            htmlDocument = htmlDocument.Replace(Code, symbol.ToString());
            return ParsingHTML(htmlDocument);
        }
    }
}
