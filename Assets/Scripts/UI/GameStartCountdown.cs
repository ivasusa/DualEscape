using TMPro;
using UnityEngine;

public class GameStartCountdown : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameManagerr.Instance.onStateChanged += GameManagerr_onStateChanged;
    }

    private void GameManagerr_onStateChanged(object sender, System.EventArgs e)
    {
        if (GameManagerr.Instance.isCountdownToStartActive())
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

    private void Update()
    {
        text.text = Mathf.Ceil(GameManagerr.Instance.GetCountdownToStartTimer()).ToString();
    }
}
