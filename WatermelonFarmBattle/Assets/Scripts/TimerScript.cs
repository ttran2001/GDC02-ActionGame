using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{

    Image timer;
    public float max = 10f;
    float remainingTime;
    

    // Start is called before the first frame update
    void Start()
    {
        timer = GetComponent<Image> ();
        remainingTime = max;
    }

    // Update is called once per frame
    void Update()
    {
        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
            timer.fillAmount = remainingTime / max;
        }
        if (remainingTime == 0)
        {
            SceneManager.LoadScene("EndScene");
        }
    }
}
