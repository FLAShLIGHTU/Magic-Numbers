using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
  public void LoadGuessNumber()
  {
    SceneManager.LoadScene("GuessNumber");
  }

  public void LoadStepsNumber()
  {
    SceneManager.LoadScene("StepsNumber");
  }
  
  public void LoadStartScene()
  {
    SceneManager.LoadScene("StartScene");
  }

  public void LoadGuessNumberGame()
  {
    SceneManager.LoadScene(("GuessNumberGame"));
  }

  public void AppQuit()
  {
    Application.Quit();
  }
  
}
