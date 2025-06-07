using TMPro;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    [SerializeField] private GameManagerr gm;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private int Coin = 0;

    public TextMeshProUGUI coinText;

    public void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Coins") {
            gm.settime(3f);
            Coin++;
            coinText.text = "Coins: " + Coin.ToString();
            Debug.Log(Coin);
            Destroy(other.gameObject);
        }
    }
}
