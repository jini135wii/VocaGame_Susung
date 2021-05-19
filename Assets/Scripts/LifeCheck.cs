using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeCheck : MonoBehaviour
{
    public Image life1, life2, life3;
    public Text answerA, answerB, answerC, Qst;
    public static int a, b=-1, c=-1, cor;
    static List<string> Words = new List<string>(new string[]
        {
            "remote",
            "ancestral",
            "intensive",
            "authentic",
            "accomodation",
            "consist of",
            "springhare",
            "porcupine",
            "track",
            "equipment",
            "craft",
            "ostrich",
            "healer",
            "relieve",
            "tension",
            "transport"
        });
    static List<string> Meanings = new List<string>(new string[]
        {
            "멀리 떨어진, 외딴",
            "조상 대대로의",
            "집중적인",
            "진정한, 진짜인",
            "숙박 시설",
            "~으로 구성되다",
            "날쥐(쥐목 날쥐과의 포유류)",
            "호저(몸에 길고 뻣뻣한 가시털이 덮여 있는 동물)",
            "발자국",
            "장비",
            "공예품",
            "타조",
            "치료사",
            "완화하다",
            "긴장",
            "이송, 운송"
        });
    public static bool RoundChange = false;
    int preLife = CharJump.life;
/*    void Start()
    {
        voca = new Dictionary<int, string, string>();
    }*/
    void Start()
    {
        Debug.Log(Words.Count);
        Debug.Log(Meanings.Count);
        a = Random.Range(0, Words.Count);
        do
        {
            b = Random.Range(0, Words.Count);
        } while (b == a);
        do
        {
            c = Random.Range(0, Words.Count);
        } while (c == a || c == b);
        cor = Random.Range(0, 3);
        switch (cor)
        {
            case 0:
                Qst.text = Words[a];
                break;
            case 1:
                Qst.text = Words[b];
                break;
            case 2:
                Qst.text = Words[c];
                break;
        }
        answerA.text = "a. " + Meanings[a];
        answerB.text = "b. " + Meanings[b];
        answerC.text = "c. " + Meanings[c];
    }
    public static void nextRound()
    {
        a = Random.Range(0, Words.Count);
        do
        {
            b = Random.Range(0, Words.Count);
        } while (b == a);
        do
        {
            c = Random.Range(0, Words.Count);
        } while (c == a || c == b);

    }
    void Update()
    {
        if (preLife != CharJump.life)
        {
            switch (CharJump.life)
            {
                case 2:
                    life3.enabled = false;
                    break;
                case 1:
                    life2.enabled = false;
                    break;
                case 0:
                    life1.enabled = false;
                    break;
                default:
                    break;
            }
        }
        if(RoundChange)
        {
            cor = Random.Range(0, 3);
            switch (cor)
            {
                case 0:
                    Qst.text = Words[a];
                    break;
                case 1:
                    Qst.text = Words[b];
                    break;
                case 2:
                    Qst.text = Words[c];
                    break;
            }
            answerA.text = "a. " + Meanings[a];
            answerB.text = "b. " + Meanings[b];
            answerC.text = "c. " + Meanings[c];
            RoundChange = false;
        }
    }
}
