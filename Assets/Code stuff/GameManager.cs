using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 2f;
    public GameObject CompleteLevelUI;
    public void CompleteLevel ()
    {

        CompleteLevelUI.SetActive(true);

    }

       public void EndGame()

        {

        if (gameHasEnded == false)
        {
        gameHasEnded = true;
        Debug.Log("GAME OVER");
          Invoke("Restart", restartDelay);
        }
        
    }

    void Restart ()
    {
        SceneManager.LoadScene("level 1");

    }

}
