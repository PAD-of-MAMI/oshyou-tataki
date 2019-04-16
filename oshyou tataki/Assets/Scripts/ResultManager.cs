using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;
using System;

public class ResultManager : MonoBehaviour
{
    public Text highScoreLabel;

    // Start is called before the first frame update
    public void Start()
    {
        //ハイスコア表示
        highScoreLabel.text = "High Score : " + PlayerPrefs.GetInt("HighScore") + "m";
    }

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        /*if ("ButtonBack" == )
        {
            //ボタンを押したら0.1秒後タイトルへ
            Invoke("GoBackTitle", 0.1f);
        }*/
    }

    //タイトルシーンに戻る
    public void GoBackTitle(){
        SceneManager.LoadScene("TitleScene");
    }

}
