using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Game_Manager : MonoBehaviour
{   
    public GameObject Ball;
    public Text Ga_Txt;
    public GameObject Bck_par;
    bool IsGameOver;
    bool IsGameClear;

    void Update()
    {
        if(Ball != null && Ball.transform.position.y < -6)//ゲームオーバーになる条件
        {
            Destroy(Ball.gameObject);
            Ga_Txt.text = "Game Over";
            IsGameOver = true;
        }

        if(Bck_par.transform.childCount == 0)
        {   
            Time.timeScale = 0;
            Ga_Txt.text = "Game Clear";
            IsGameClear = true;
        }

        if((IsGameOver || IsGameClear) && Input.GetKey(KeyCode.Space)) 
        {
            SceneManager.LoadScene("Game_Play_Scene");
        }
    }
}
