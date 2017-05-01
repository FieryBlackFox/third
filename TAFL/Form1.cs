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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            string[] allStrings = inputTextBox.Text.Split(new char[2] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            SortedSet<string> L1 = new SortedSet<string>(allStrings[0].Split(new char[1] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            SortedSet<string> L2 = new SortedSet<string>(allStrings[1].Split(new char[1] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            int k = Convert.ToInt32(allStrings[2]);

            AnswerForm F = new AnswerForm();
            F.printPlus(getPlus(L1, L2, k));
            F.Show();
        }

        SortedSet<string> getPlus(SortedSet<string> L1, SortedSet<string> L2, int k)
        {
            SortedSet<string> sumL = new SortedSet<string>();
            string sumStr;
            foreach(var str1 in L1)
            {
                foreach(var str2 in L2)
                {
                    if (str1[str1.Length - 1] != 'e')
                    {
                        sumStr = str1 + str2;
                    }
                    else
                    {
                        sumStr = str1;
                    }
                    sumStr = sumStr.Length < k ? sumStr : sumStr.Substring(0, k);
                    sumL.Add(sumStr);
                }
            }
            return new SortedSet<string>(sumL);
        }

        private void FirstButton_Click(object sender, EventArgs e)
        {
            string[] allStrings = inputTextBox.Text.Split(new char[2] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            SortedSet<string> N = new SortedSet<string>(allStrings[0].Split(new char[1] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            SortedSet<string> T = new SortedSet<string>(allStrings[1].Split(new char[1] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            T.Add("e");
            int n = Convert.ToInt32(allStrings[2]);
            Dictionary<string, List<string>> P = new Dictionary<string, List<string>>();
            for (int i = 3; i < 3 + n; i++)
            {
                string s = allStrings[i][0].ToString();
                if (!P.ContainsKey(s))
                {
                    P[s] = new List<string>();
                }
                P[s].Add(allStrings[i].Substring(3));

            }

            int k = Convert.ToInt32(allStrings[n + 3]);
            string line = allStrings[n + 4];

            AnswerForm F = new AnswerForm();
            F.printFirst(getFirst(N, P, k, line, getGrammaFirst(T, N, P, k)), line);
            F.Show();
        }

        SortedSet<string> getFirst(SortedSet<string> N, Dictionary<string, List<string>> P, int k, string line, Dictionary<string, SortedSet<string>> gFirst)
        {
            int j = 1;
            SortedSet<string> plus = new SortedSet<string>();
            if (line.Length >= 1)
            {
                plus = new SortedSet<string>(gFirst[line[0].ToString()]);
            }
            while (j < line.Length)
            {
                plus = getPlus(plus, gFirst[line[j].ToString()], k);
                j++;
            }

            return new SortedSet<string>(plus);
        }

        Dictionary<string, SortedSet<string>> getGrammaFirst(SortedSet<string> T, SortedSet<string> N, Dictionary<string, List<string>> P, int k)
        {
            List<Dictionary<string, SortedSet<string>>> F = new List<Dictionary<string, SortedSet<string>>>();
            int ind = 0;

            F.Add(new Dictionary<string, SortedSet<string>>());
            addTerminal(T, ref F, ind);
            getF0(T, N, P, k, F);

            do
            {
                //Print(F[ind], ind);
                ind++;
                F.Add(new Dictionary<string, SortedSet<string>>());
                addTerminal(T, ref F, ind);

                foreach(var n in N)
                {
                    F[ind][n] = new SortedSet<string>(F[ind - 1][n]);
                    foreach(var p in P[n])
                    {
                        int i = 1;
                        SortedSet<string> plus = new SortedSet<string>();
                        if (p.Length >= 1) 
                        {
                            plus = new SortedSet<string>(F[ind - 1][p[0].ToString()]);
                        }

                        while(i < p.Length)
                        {
                            plus = getPlus(plus, F[ind - 1][p[i].ToString()], k);
                            i++;
                        }

                        foreach(var pl in plus)
                        {
                            F[ind][n].Add(pl);
                        }                          
                    }
                }

            } while (!isEqualsF(ind, F));

            return new Dictionary<string,SortedSet<string>>(F[ind]);
        }

        void addTerminal(SortedSet<string> T, ref  List<Dictionary<string, SortedSet<string>>> F, int ind)
        {
            foreach(var str in T)
            {
                F[ind][str] = new SortedSet<string>();
                F[ind][str].Add(str);
            }
        }

        void getF0(SortedSet<string> T, SortedSet<string> N, Dictionary<string, List<string>> P, int k, List<Dictionary<string, SortedSet<string>>> F)
        {
            foreach (var n in N)
            {
                F[0][n] = new SortedSet<string>();
                foreach (var p in P[n])
                {
                    int i = 0;
                    while (i < p.Length && T.Contains(p[i].ToString()))
                    {
                        i++;
                    }
                    if (i >= k)
                    {
                        F[0][n].Add(p.Substring(0, k));
                    }
                    else if ((i < k) && (p.Length == i))
                    {
                        F[0][n].Add(p);
                    }
                }
            }
        }

        bool isEqualsF(int ind, List<Dictionary<string, SortedSet<string>>> F)
        {
            foreach(var key in F[ind].Keys)
            {
                SortedSet<string> nset = new SortedSet<string>(F[ind - 1][key]);
                foreach(var str in F[ind][key])
                {
                    nset.Add(str);
                }
                if(nset.Count() != F[ind - 1][key].Count())
                {
                    return false;
                }
            }
            return true;
        }

        private void FollowButton_Click(object sender, EventArgs e)
        {
            string[] allStrings = inputTextBox.Text.Split(new char[2] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            SortedSet<string> N = new SortedSet<string>(allStrings[0].Split(new char[1] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            SortedSet<string> T = new SortedSet<string>(allStrings[1].Split(new char[1] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            T.Add("e");
            int n = Convert.ToInt32(allStrings[2]);
            Dictionary<string, List<string>> P = new Dictionary<string, List<string>>();
            for (int i = 3; i < 3 + n; i++)
            {
                string s = allStrings[i][0].ToString();
                if (!P.ContainsKey(s))
                {
                    P[s] = new List<string>();
                }
                P[s].Add(allStrings[i].Substring(3));

            }
            string start = allStrings[n + 3];
            int k = Convert.ToInt32(allStrings[n + 4]);
            string neterminal = allStrings[n + 5];

            Dictionary<string, SortedSet<string>> gFirst = getGrammaFirst(T, N, P, k);
            Dictionary<string, Dictionary<string, SortedSet<string>>> fi = getGrammaFi_follow(N, P, k, gFirst);

            SortedSet<string> Follow = new SortedSet<string>(fi[start][neterminal]);
            if(start == neterminal)
            {
                Follow.Add("e");
            }

            AnswerForm F = new AnswerForm();
            F.printFollow(Follow, neterminal);
            F.Show();
        }

        Dictionary<string, Dictionary<string, SortedSet<string>>> getGrammaFi_follow(SortedSet<string> N, Dictionary<string, List<string>> P, int k, Dictionary<string, SortedSet<string>> gFirst)
        {
            List<Dictionary<string, Dictionary<string, SortedSet<string>>>> fi = new List<Dictionary<string, Dictionary<string, SortedSet<string>>>>();
            fi.Add(new Dictionary<string, Dictionary<string, SortedSet<string>>>());
            int ind = 0;
            getFi0(ref fi, N, P, k, gFirst);

            do
            {
                ind++;
                fi.Add(new Dictionary<string, Dictionary<string, SortedSet<string>>>());

                foreach (var n1 in N)
                {
                    fi[ind][n1] = new Dictionary<string, SortedSet<string>>(fi[ind - 1][n1]);
                    foreach (var n2 in N)
                    {
                        foreach (var p in P[n1])
                        {
                            for (int i = 0; i < p.Length; i++)
                            {
                                string pi = p[i].ToString();
                                if (N.Contains(pi))
                                {
                                    string line = i < p.Length - 1 ? p.Substring(i + 1) : "";
                                    SortedSet<string> plus = getPlus(fi[ind - 1][pi][n2], getFirst(N, P, k, line, gFirst), k);
                                    foreach(var str in plus)
                                    {
                                        fi[ind][n1][n2].Add(str);
                                    }
                                }
                            }
                        }
                    }
                }

            } while (!isEqualsFi(ind, fi));

            return new Dictionary<string, Dictionary<string, SortedSet<string>>>(fi[ind]);
        }

        void getFi0(ref List<Dictionary<string, Dictionary<string, SortedSet<string>>>> fi, SortedSet<string> N, Dictionary<string, List<string>> P, int k, Dictionary<string, SortedSet<string>> gFirst)
        {
            foreach(var n1 in N)
            {
                fi[0][n1] = new Dictionary<string,SortedSet<string>>();
                foreach(var n2 in N)
                {
                    fi[0][n1][n2] = new SortedSet<string>();
                    foreach(var p in P[n1])
                    {
                        int i = 0;
                        while(i<p.Length && p[i].ToString() != n2)
                        {
                            i++;
                        }
                        if(i < p.Length - 1)
                        {
                            string w = p.Substring(i + 1);
                            foreach(var str in getFirst(N, P, k, w, gFirst))
                            {
                                fi[0][n1][n2].Add(str);
                            }
                        }
                    }
                }
            }
        }

        bool isEqualsFi(int ind, List<Dictionary<string, Dictionary<string, SortedSet<string>>>> fi)
        {
            foreach (var key1 in fi[ind].Keys)
            {
                foreach (var key2 in fi[ind][key1].Keys)
                {
                    SortedSet<string> nset = new SortedSet<string>(fi[ind - 1][key1][key2]);
                    foreach (var str in fi[ind][key1][key2])
                    {
                        nset.Add(str);
                    }
                    if (nset.Count() != fi[ind - 1][key1][key2].Count())
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            Help H = new Help();
            H.Show();
        }


    }
}
