using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Pontuacao : MonoBehaviour
{
    float maisPonto;
    public TextMeshProUGUI ponto;
    // Update is called once per frame
    public void AddPoints()
    {
        maisPonto++;
        ponto.text = maisPonto.ToString();
    }

    void start()
    {
        ponto.text = "0";
    }
}
