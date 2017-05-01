using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFp
{
    public partial class AnswerForm : Form
    {
        public AnswerForm()
        {
            InitializeComponent();
        }

        public void printPlus(SortedSet<string> plusL)
        {
            nameOperationLabel.Text = "Cross";
            int i = 0;
            foreach (var str in plusL)
            {
                i += 2 + str.Length;
                answerTextBox.Text += str + ", ";
                if (i >= 40)
                {
                    i = 0;
                    answerTextBox.Text += Environment.NewLine;
                }
            }
            answerTextBox.Text = answerTextBox.Text.Substring(0, answerTextBox.Text.Length - 2);
        }

        public void printFirst(SortedSet<string> First, string line)
        {
            nameOperationLabel.Text = "First";
            answerTextBox.Text += "First( " + line + " ) = { ";
            int i = 14 + line.Length;
            foreach(var str in First)
            {
                i += 2 + str.Length;
                answerTextBox.Text += str + ", ";
                if (i >= 40)
                {
                    i = 0;
                    answerTextBox.Text += Environment.NewLine;
                }
            }
            if (answerTextBox.Text.Length > 14 + line.Length)
            {
                answerTextBox.Text = answerTextBox.Text.Substring(0, answerTextBox.Text.Length - 2) + " }";
            }
        }

        public void printFollow(SortedSet<string> Follow, string line)
        {
            nameOperationLabel.Text = "Follow";
            answerTextBox.Text += "Follow( " + line + " ) = { ";
            int i = 15 + line.Length;
            foreach (var str in Follow)
            {
                i += 2 + str.Length;
                answerTextBox.Text += str + ", ";
                if (i >= 40)
                {
                    i = 0;
                    answerTextBox.Text += Environment.NewLine;
                }
            }
            if (answerTextBox.Text.Length > 15 + line.Length)
            {
                answerTextBox.Text = answerTextBox.Text.Substring(0, answerTextBox.Text.Length - 2) + " }";
            }
        }
    }
}
