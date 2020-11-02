using TMPro;
using UnityEngine;

public class CountdownTimerHandler : MonoBehaviour
{
    // Dependancies
    public GameObject endMenu;

    // Components
    private TMP_Text _countdownText;

    // Countdown
    private float _timer;
    private float _maxTimer = 120f;

    private void Awake()
    {
        _countdownText = gameObject.GetComponent<TMP_Text>();
        _timer = _maxTimer;
    }

    private void Update()
    {
        Countdown();
        CheckGameState();
    }

    private void Countdown()
    {
        _timer = Mathf.Clamp(_timer - (1 * Time.deltaTime), 0f, _maxTimer);
        _countdownText.text = _timer.ToString("#");
    }

    private void CheckGameState()
    {
        if (_timer <= 0)
        {
            Time.timeScale = 0f;
            endMenu.SetActive(true);
        }
    }
}
