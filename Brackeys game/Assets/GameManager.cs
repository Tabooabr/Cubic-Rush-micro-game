using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    bool gameEnded;

    public float restartdelay = 1f;

    public GameObject completeLevelui;
    public void EndGame()
    {
        if (gameEnded == false)
        {

            gameEnded = true;
            Debug.Log("GAME OVER");

            //restart game
            Invoke("Restart", restartdelay); //invoke is used to call a method with a delay.
            
        }
    }

    public void CompleteLevel()
    {
        completeLevelui.SetActive(true);
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // OMG i understand this *_* Load a scene:(get the current scene's name)
    }
}
