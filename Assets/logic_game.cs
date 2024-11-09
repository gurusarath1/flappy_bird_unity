using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class logic_game : MonoBehaviour
{
    public Text textObj;
    public int current_score;

    public GameObject game_over_screen;

    [ContextMenu("Increase Score")]
    public void addScore() {

        current_score += 1;
        textObj.text = current_score.ToString();

    }

    public void restartButton()  {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    public void gameOver() {
        game_over_screen.SetActive(true);
    }


}
