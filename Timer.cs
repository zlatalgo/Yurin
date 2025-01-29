using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEditor.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public int minutes;
    public float seconds;
    public TextMeshProUGUI timerText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        seconds -= Time.deltaTime;
        if (seconds <= 0)
        {
            if (minutes <= 0)
            {
                EditorSceneManager.LoadScene(EditorSceneManager.GetActiveScene().buildIndex);
            }
            else
            {
                minutes--;
                seconds += 59;
            }
        }
        int roundSeconds = Mathf.RoundToInt(seconds);
        timerText.text = minutes + ":" + roundSeconds;
    }
}
