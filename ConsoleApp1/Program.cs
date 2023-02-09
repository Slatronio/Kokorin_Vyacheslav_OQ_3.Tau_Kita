using System.ComponentModel.DataAnnotations;
using System.Globalization;

class Program
{
    static void Main()
    {
        string file = "rmrpiea srfaa tEo gveproo";
        string[] tau = file.Split();
        string[] human = new string[tau.Length];
        for (int i = 0; i < tau.Length; i++)
        {
            human[i] = "";
            int k = tau[i].Length;
            if (k % 2 == 0)
            {
                for (int j = 0; j < k; j++)
                {
                    if (tau[i].Length % 2 == 0)
                    {
                        human[i] += tau[i].Remove(tau[i].Length / 2 + 1, tau[i].Length / 2 - 1).Remove(0, tau[i].Length / 2);
                        tau[i] = tau[i].Remove(tau[i].Length / 2, 1);
                    }
                    else
                    {
                        human[i] += tau[i].Remove(tau[i].Length / 2 + 1, tau[i].Length / 2).Remove(0, tau[i].Length / 2);
                        tau[i] = tau[i].Remove(tau[i].Length / 2, 1);
                    }
                }
            }
            else
            {
                for (int j = 0; j < k; j++)
                {
                    if (tau[i].Length % 2 == 0)
                    {
                        human[i] += tau[i].Remove(tau[i].Length / 2, tau[i].Length / 2).Remove(0, tau[i].Length / 2 - 1);
                        tau[i] = tau[i].Remove(tau[i].Length / 2 - 1, 1);
                    }
                    else
                    {
                        human[i] += tau[i].Remove(tau[i].Length / 2 + 1, tau[i].Length / 2).Remove(0, tau[i].Length / 2);
                        tau[i] = tau[i].Remove(tau[i].Length / 2, 1);
                    }
                }
            }
        }
        int n = 0, m = 1;
        for (int i = 0; i < human.Length; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(human[human.Length / 2 + n] + " ");
                n++;
            }
            else
            {
                Console.Write(human[human.Length / 2 - m] + " ");
                m++;
            }
        }
    }
}