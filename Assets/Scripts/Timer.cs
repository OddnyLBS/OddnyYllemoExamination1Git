using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float timer = 30f;

    GameObject endCanvas;

    GameObject endTextObject;
    TextMeshProUGUI endText;

    GameObject timerObject;
    TextMeshProUGUI timerText;

    bool isDead = false;

    PlayerMovement playerMovement;

    void Start()
    {
        Time.timeScale = 1;

        endTextObject = GameObject.Find("EndText");
        endText = endTextObject.GetComponent<TextMeshProUGUI>();

        timerObject = GameObject.Find("TimerText");
        timerText = timerObject.GetComponent<TextMeshProUGUI>();

        endCanvas = GameObject.Find("EndCanvas");
        endCanvas.SetActive(false);

        playerMovement = FindFirstObjectByType<PlayerMovement>();
    }

    void Update()
    {
        isDead = playerMovement.isDead;

        timer -= Time.deltaTime;

        timerText.SetText("{0}", Mathf.Ceil(timer));

        if (timer <= 0)
        {
            Time.timeScale = 0;
            endCanvas.SetActive(true);
            timer = 0;
            endText.SetText("Time is Out!");
        }
        else if (isDead)
        {
            Time.timeScale = 0;
            endCanvas.SetActive(true);
            endText.SetText("You Died!");
        }
    }
}
