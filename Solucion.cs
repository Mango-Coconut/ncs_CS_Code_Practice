using System.Formats.Asn1;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

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

    public string[] Solution0714_3_OXQUIZ(string[] quiz) {
        string[] answer = new string[] {};
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
}