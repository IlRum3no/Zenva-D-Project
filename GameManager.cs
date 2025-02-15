using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    public int score = 0;

    public int highScore = 0;

    void Awake(){
        if (instance == null){

            instance = this;

        } else if (instance != this){

            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    public void IncreaseScore(int amount){
        score += amount;

        print("New Score: " + score);

        if (score > highScore){
            print("New High Score: " + highScore);
        }
    }
}
