using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Formats.Asn1;
using System.Globalization;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Markup;

class Solution
{
    /// <summary>
    /// 두 수의 곱 구하기
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public int Solution07072(int num1, int num2)
    {
        int answer = num1 * num2;
        return answer;
    }

    /// <summary>
    /// 빼기 연산
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public int Solution0707(int num1, int num2)
    {
        int answer = 0;
        answer = num1 - num2;
        return answer;
    }

    /// <summary>
    /// 나머지 구하기
    /// 우엥엥우엥
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public int Solution0704(int num1, int num2)
    {
        int answer = 0;
        answer = num1 % num2;
        return answer;
    }

    /// <summary>
    /// 몫 구하기
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public int Solution0708(int num1, int num2)
    {
        return num1 / num2;
    }

    public int Solution0708_2(int num1, int num2)
    {
        int answer = 0;
        answer = (int)(((float)num1 / (float)num2) * 1000);
        return answer;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="num1"></param>
    /// <param name="num2"></param>
    /// <returns></returns>
    public int Solution0709(int num1, int num2)
    {
        return 0;
    }

    public int[] Solution0714(int[] numlist, int n)
    {

        List<int> answer = new List<int>();

        answer.Add(numlist[0]);
        bool isInserted = false;
        for (int i = 1; i < numlist.Length; i++)
        {
            isInserted = false;
            //새로 넣을 numlist[i]
            //새로 넣을 원소의 차이가 원래 있던 원소의 차이보다 작으면 그자리에 넣는다
            for (int j = 0; j < answer.Count; j++)
            {
                if (Math.Abs(numlist[i] - n) == Math.Abs(answer[j] - n) && numlist[i] > answer[j])
                {
                    answer.Insert(j, numlist[i]);
                    isInserted = true;
                    break;
                }
                else if (Math.Abs(numlist[i] - n) < Math.Abs(answer[j] - n))
                {
                    answer.Insert(j, numlist[i]);
                    isInserted = true;
                    break;
                }
            }
            if (isInserted == false)
                answer.Add(numlist[i]);
        }
        foreach (int a in answer)
        {
            Console.Write($"{a}, ");
        }

        return answer.ToArray();
    }

    public string Solution0714_2(string polynomial)
    {
        string answer = "";
        int x = 0;
        int n = 0;
        polynomial = polynomial.Replace("+ ", "");

        List<string> result = polynomial.Split(' ').ToList();
        foreach (string str in result)
        {
            if (str[str.Length - 1] == 'x')
            {
                if (str.Length == 1)
                    x++;
                else
                    x += int.Parse(str.TrimEnd('x'));
            }
            else
            {
                n += int.Parse(str);
            }
        }
        if (x != 0 && n != 0)
        {
            answer = $"{x}x + {n}";
        }
        else if (x != 0 && n == 0)
        {
            answer = $"{x}x";
        }
        else
        {
            answer = $"{n}";
        }
        return answer;
    }

    //OX퀴즈
    public string[] Solution0714_3(string[] quiz)
    {
        string[] answer = new string[] { };
        List<string> result;

        for (int i = 0; i < quiz.Length; i++)
        {
            string OX = "O";
            result = quiz[i].Split(' ').ToList();
            if (result[1].Equals('+'))
            {
                if (int.Parse(result[0]) + int.Parse(result[2]) != int.Parse(result[4]))
                {
                    OX = "X";
                }
            }
            else
            {
                if (int.Parse(result[0]) - int.Parse(result[2]) != int.Parse(result[4]))
                {
                    OX = "X";
                }
            }
            answer.Append(OX);
        }



        return answer;
    }

    //다음에 올 숫자
    public int Solution0715_1(int[] common)
    {
        bool isEquid = true;
        int answer = 0;
        int len = common.Length;

        int minus = common[len - 1] - common[len - 2];
        for (int i = common.Length - 2; i >= 1; i--)
        {
            //빼기가 같지 않으면 등차수열이 아님
            if (minus != common[i] - common[i - 1])
            {
                isEquid = false;
            }
        }

        //등차수열일 경우
        if (isEquid)
        {
            answer = common[len] + (common[len] - common[len - 1]);
        }
        else
        {
            answer = common[len] * (common[len] / common[len - 1]);
        }

        Console.WriteLine(isEquid);

        return answer;
    }

    //연속된 수의 합
    public int[] Solution0715_2(int num, int total)
    {
        int[] answer = new int[num];
        int midnum = 0;
        int firstnum = 0;

        midnum = total / num;
        firstnum = midnum - num / 2;
        if (num % 2 == 0)
        {
            firstnum++;
        }

        for (int i = 0; i < num; i++)
        {
            answer[i] = firstnum++;
        }

        return answer;
    }

    //안전지대
    public int Solution0715_3(int[,] board)
    {
        int answer = 0;
        int rows = board.GetLength(0);
        int cols = board.GetLength(1);
        int[,] danger = new int[rows, cols];


        //위험지역에 1 넣기
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (board[i, j] == 1)
                {
                    //참조오류 막기 위해서 위험구역으로 지정할 범위 제한
                    int minX = i - 1;
                    int maxX = i + 1;
                    int minY = j - 1;
                    int maxY = j + 1;
                    //가장 왼쪽에 지뢰
                    if (i == 0)
                        minX = i;
                    //가장 오른쪽에 지뢰
                    if (i == rows - 1)
                        maxX = i;
                    //가장 위쪽에 지뢰
                    if (j == 0)
                        minY = j;
                    //가장 아래쪽에 지뢰
                    if (j == cols - 1)
                        maxY = j;
                    //지정한 범위만큼 위험구역으로 변환
                    for (int k = minX; k <= maxX; k++)
                    {
                        for (int l = minY; l <= maxY; l++)
                        {
                            danger[k, l] = 1;
                        }
                    }
                }
            }
        }

        //안전지대의 수 구하기
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (danger[i, j] == 0)
                {
                    answer++;
                }
            }
        }

        return answer;
    }

    //겹치는 선분의 길이
    public int Solution0715_4(int[,] lines)
    {
        int[] line = new int[201]; // 커버: [-100, 100] → [0, 200]

        for (int i = 0; i < 3; i++)
        {
            int start = lines[i, 0];
            int end = lines[i, 1];

            for (int j = start; j < end; j++)
            {
                line[j + 100]++;
            }
        }

        return line.Count(x => x >= 2);
    }

    //평행
    public int Solution0715_5(int[,] dots)
    {
        //점 4개 있을 때 두 개의 선분이 가능한 경우의 수는
        //(1,2 & 3,4), (1,3 & 2,4), (1,4 & 2,3)

        //기울기 = dy/dx
        //(1,2) 기울기와 (3,4) 기울기 구하기
        float slope12 = (float)(dots[1, 1] - dots[0, 1]) / (dots[1, 0] - dots[0, 0]);
        float slope34 = (float)(dots[3, 1] - dots[2, 1]) / (dots[3, 0] - dots[2, 0]);

        //(1,3) 기울기와 (2,4) 기울기 구하기
        float slope13 = (float)(dots[2, 1] - dots[0, 1]) / (dots[2, 0] - dots[0, 0]);
        float slope24 = (float)(dots[3, 1] - dots[1, 1]) / (dots[3, 0] - dots[1, 0]);

        //(1,4) 기울기와 (2,3) 기울기 구하기
        float slope14 = (float)(dots[3, 1] - dots[0, 1]) / (dots[3, 0] - dots[0, 0]);
        float slope23 = (float)(dots[2, 1] - dots[1, 1]) / (dots[2, 0] - dots[1, 0]);


        //각각 기울기가 같은지(평행한지) 확인
        int answer = 0;
        if (Math.Abs(slope34 - slope12) < 1e-6)
        {
            answer = 1;
        }
        else if (Math.Abs(slope24 - slope13) < 1e-6)
        {
            answer = 1;
        }
        else if (Math.Abs(slope23 - slope14) < 1e-6)
        {
            answer = 1;
        }

        return answer;
    }

    //옹알이 (1)
    public int Solution0715_6(string[] babbling)
    {
        int answer = 0;
        List<string> words = new List<string>();
        words.Add("aya"); words.Add("ye"); words.Add("woo"); words.Add("ma");

        foreach (string str in babbling)
        {
            string temp = str;

            foreach (string word in words)
            {
                //Console.Write($"{temp} -> ");
                temp = temp.Replace(word, " ");

                if (temp.Replace(" ", string.Empty) == "")
                {
                    answer++;
                    //Console.WriteLine($"{temp}, {answer}");
                    break;
                }
            }
            //Console.WriteLine("");
        }
        return answer;
    }

    //길이에 따른 연산
    public int Solution0715_7(int[] num_list)
    {
        int answer = 0;

        if (num_list.Length >= 11)
        {
            answer = num_list.Sum();
        }
        else
        {
            answer = 1;
            foreach (int i in num_list)
            {
                answer *= i;
            }
        }

        return answer;
    }


    // 두 수의 연산값 비교하기
    public int Solution0716_1(int a, int b)
    {
        int answer = 0;

        int c;
        int.TryParse(a.ToString() + b.ToString(), out c);

        answer = Math.Max(c, 2 * a * b);

        Console.WriteLine(answer);
        return answer;
    }

    //주사위 3
    public int Solution250717(int a, int b, int c, int d)
    {
        int answer = 0;
        int equalNum = 1;
        int p = -1;
        int q = -1;
        int r = -1;
        int s = -1;
        //원본 숫자 리스트
        List<int> ints = new List<int>();
        //해당 원본 숫자의 갯수 리스트
        List<int> intsnum = new List<int>();

        ints.Add(a); ints.Add(b); ints.Add(c); ints.Add(d);
        intsnum.Add(a); intsnum.Add(b); intsnum.Add(c); intsnum.Add(d);

        //같은 숫자가 몇개나 있는지
        for (int i = 0; i < ints.Count; i++)
        {
            intsnum[i] = ints.Count(x => x == ints[i]);
            if (intsnum[i] == 4)
            {
                equalNum = 4;
            }
            else if (intsnum[i] == 3)
            {
                equalNum = 3;
            }
            else if (intsnum[i] == 2)
            {
                equalNum = 2;
            }
        }

        //p,q,r,s 구하고 answer 구하기

        //4개가 모두 같으면
        if (equalNum == 4)
        {
            answer = 1111 * a;
        }
        //3개만 같다면 3개는 p, 1개는 q
        else if (equalNum == 3)
        {
            for (int i = 0; i < ints.Count; i++)
            {
                if (intsnum[i] == 3)
                {
                    p = ints[i];
                }
                else if (intsnum[i] == 1)
                {
                    q = ints[i];
                }
            }
            answer = (10 * p + q) * (10 * p + q);
        }
        else if (equalNum == 2)
        {
            for (int i = 0; i < ints.Count; i++)
            {
                //한개짜리일때
                if (intsnum[i] == 1)
                {
                    //p는 냅두고 q먼저 넣음
                    if (q == -1)
                    {
                        q = ints[i];
                    }
                    //q가 이미 있다면 r
                    else if (q != -1)
                    {
                        r = ints[i];
                    }
                }
                //두개짜리면 일단 p
                else if (intsnum[i] == 2)
                {
                    //일단 첫번째건 p
                    if (p == -1)
                    {
                        p = ints[i];
                        Console.WriteLine($"p = -1, {p}, {q}");
                    }
                    //두번째건 q
                    else if (ints[i] != p)
                    {
                        q = ints[i];
                    }
                }
            }
            //두개 두개(p,q)일 경우
            if (r == -1)
            {
                answer = (p + q) * Math.Abs(p - q);
            }
            //두개 한개 한개(p,q,r일 경우)
            else if (r != -1)
            {
                answer = q * r;
            }
        }
        else if (equalNum == 1)
        {
            answer = Math.Min(Math.Min(a, b), Math.Min(c, d));
        }

        return answer;
    }

    //정수를 나선형으로 배치하기
    public int[,] Solution250717_2(int n)
    {
        int[,] answer = new int[n, n];
        int i = 1;
        string dir = "right";
        int row = 0;
        int col = 0;
        int rot = 0;

        answer[row, col] = 1;

        for (i = 1; i < n * n;)
        {
            if (dir == "right")
            {
                for (col += 1; col < n - rot; col++)
                {
                    answer[row, col] = i + 1;
                    i++;
                }
                col--;
                dir = "down";

            }
            if (dir == "down")
            {
                for (row += 1; row < n - rot; row++)
                {
                    answer[row, col] = i + 1;
                    i++;
                }
                row--;
                dir = "left";
            }
            else if (dir == "left")
            {
                for (col -= 1; col >= rot; col--)
                {
                    answer[row, col] = i + 1;
                    i++;
                }
                col++;
                dir = "up";
            }
            else if (dir == "up")
            {
                for (row -= 1; row > rot; row--)
                {
                    answer[row, col] = i + 1;
                    i++;
                }
                dir = "right";
                row++;
                rot++;
            }
        }

        foreach (int m in answer)
        {
            Console.Write($"{m}, ");
        }
        return answer;
    }

    // List<int> answer = new List<int>();
    
}


//using System.Collections.Generic;
//using System.Linq;
//using System.Text;