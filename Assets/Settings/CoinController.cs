using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Pontuacao pontos = other.GetComponent<Pontuacao>();
            pontos.AddPoints();
            Destroy(this.gameObject);
        }
    }
}
