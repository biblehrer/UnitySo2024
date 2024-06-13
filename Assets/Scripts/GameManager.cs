using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public enum GameStates {inTitle,inGame,paused};
    public GameStates state2 = GameStates.inTitle;
    public string state =  "inTitle";

    private float Counter = 0;


    // Start is called before the first frame update
    void Start()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);            
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (state == "inGame")
        {
            Counter += Time.deltaTime;
            if (Counter > 15)
            {
                SceneManager.LoadScene("Title");
                state =  "inTitle";
                state2 = GameStates.inTitle;
                Counter = 0;
            }
        }

        Input.GetKeyDown(KeyCode.Escape);
        //gameObject.activeSelf

    }

    public static void GoToGame()
    {
        SceneManager.LoadScene("Game");
        Instance.state =  "inGame";
        Instance.state2 = GameStates.inGame;
    }
}
