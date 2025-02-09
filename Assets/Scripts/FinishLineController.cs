using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class FinishLineController : MonoBehaviour
{
    private bool gamePaused = false;

    private void OnTriggerEnter(Collider other)
    {
        if ((other.CompareTag("Player_1") || other.CompareTag("Player_2")) && !gamePaused)
        {
            Debug.Log(other.tag);
            StartCoroutine(PauseGameAfterDelay(2f));
        }
    }

    private IEnumerator PauseGameAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        Time.timeScale = 0;
        gamePaused = true;
        SceneManager.LoadScene("MainMenu");
    }
}
