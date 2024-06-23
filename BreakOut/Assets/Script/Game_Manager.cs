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
    public GameObject Bck_Par;
    bool IsGameOver;//ゲームオーバーになっているかを判定する
    bool IsGameClear;//ゲームクリアしたかを判定する

    void Update()
    {
        if(Ball != null && Ball.transform.position.y < -6)//ゲームオーバーになる条件
        {
            Destroy(Ball.gameObject);
            Ga_Txt.text = "Game Over";
            IsGameOver = true;
        }

        if(Bck_Par.transform.childCount == 0)
        {   
            Time.timeScale = 0;
            Ga_Txt.text = "Game Clear";
            IsGameClear = true;
        }

        if((IsGameOver || IsGameClear) && Input.GetKeyDown(KeyCode.Space)) 
        {
            SceneManager.LoadScene("Game_Play_Scene");
            Time.timeScale = 1;
        }
    }
}