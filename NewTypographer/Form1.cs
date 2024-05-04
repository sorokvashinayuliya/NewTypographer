using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NewTypographer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void typographyButton_Click(object sender, EventArgs e)
        {
            string inputText = inputRichTextBox.Text;
            inputText = ReplaceSymbols(inputText);
            string correctedText = RemoveExtraSpaces(inputText);
            string pointCorrectedText = ReplacePoint(correctedText);
            string mathSignsText = MathSigns(pointCorrectedText);
            string replaceThreeDotsWithEllipsisText = ReplaceThreeDotsWithEllipsis(mathSignsText);
            string mathSignsEqualText = MathSignsEqual(replaceThreeDotsWithEllipsisText);
            string removeSpaceAroundDotText = RemoveSpaceAroundDot(mathSignsEqualText);
            string removeSpaceAroundCommaText = RemoveSpaceAroundComma(removeSpaceAroundDotText);
            outputRichTextBox.Text = removeSpaceAroundCommaText;
        }
        public string RemoveExtraSpaces(string text)
        {
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string correctedText = string.Join(" ", words);
            return correctedText;
        }
        public string ReplaceSymbols(string text)
        {
            text = text.Replace("+-", "±");
            return text;
        }
        public string ReplaceThreeDotsWithEllipsis(string text)
        {
            return text.Replace("...", "…");
        }
        public string ReplacePoint(string text)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];
                char nextChar = (i < text.Length - 1) ? text[i + 1] : '\0';
                if (currentChar == '.' && char.IsLetter(nextChar))
                {
                    result.Append(". ");
                }
                if (currentChar == ',' && char.IsLetter(nextChar))
                {
                    result.Append(", ");
                }
                else
                {
                    result.Append(currentChar);
                }
            }
            return result.ToString();
        }
        
        public string MathSigns(string text)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];
                char nextChar = (i < text.Length - 1) ? text[i + 1] : '\0';
                if (currentChar == '-' && char.IsDigit(nextChar))
                {
                    result.Append(" - ");
                }
                else
                {
                    result.Append(currentChar);
                }
            }
            return result.ToString();
        }
 

        public string MathSignsEqual(string text)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                char currentChar = text[i];
                char nextChar = (i < text.Length - 1) ? text[i + 1] : '\0';
                if (currentChar == '=' && char.IsDigit(nextChar))
                {
                    result.Append(" = ");
                }
                else
                {
                    result.Append(currentChar);
                }
            }
            return result.ToString();
        }
        public string RemoveSpaceAroundDot(string text)
        {
            int dotIndex = text.IndexOf('.');
            if (dotIndex >= 0 && dotIndex < text.Length - 1)
            {
                char charBeforeDot = text[dotIndex - 1];
                char charAfterDot = text[dotIndex + 1];

                if (char.IsDigit(charBeforeDot) && char.IsDigit(charAfterDot))
                {
                    return text.Replace(" ", "");
                }
            }
            return text;
        }
        public string RemoveSpaceAroundComma(string text)
        {
            int dotIndex = text.IndexOf(',');
            if (dotIndex >= 0 && dotIndex < text.Length - 1)
            {
                char charBeforeDot = text[dotIndex - 1];
                char charAfterDot = text[dotIndex + 1];

                if (char.IsDigit(charBeforeDot) && char.IsDigit(charAfterDot))
                {
                    return text.Replace(" ", "");
                }
            }
            return text;
        }
    }
}
