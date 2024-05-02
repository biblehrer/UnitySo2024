using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Hud : MonoBehaviour
{
    public TMP_Text scoreText;
    public static int score = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text ="Score: " +score;
    }
}
