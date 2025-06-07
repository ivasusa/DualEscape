using TMPro;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    
    void Start()
    {
        GameManagerr.Instance.onStateChanged += GameManagerr_onStateChanged;
    }

    private void GameManagerr_onStateChanged(object sender, System.EventArgs e)
    {
        if (GameManagerr.Instance.isGameOver())
        {
            Show();
        }
        else
        {
            Hide();
        }
    }

    private void Show()
    {
        gameObject.SetActive(true);
    }
    private void Hide()
    {
        gameObject.SetActive(false);
    }


}
