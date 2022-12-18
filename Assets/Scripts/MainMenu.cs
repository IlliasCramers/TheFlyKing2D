using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public Animator transition;

   public void PlayGame()
    {
        transition.SetTrigger("Trigger");
        StartCoroutine(LoadPlay());
    }

    public void QuitGame()
    {
        Application.Quit();
    }



    IEnumerator LoadPlay()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
