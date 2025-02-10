using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.SceneManagement;

public class FinishLineController : MonoBehaviour
{
    private bool isPaused = false;

    public GameObject finishMenu;
    public TMP_Text winnerText; 

    private void OnTriggerEnter(Collider other)
    {
        if ((other.CompareTag("Player_1") || other.CompareTag("Player_2")) && !isPaused)
        {
            Debug.Log(other.tag);
            StartCoroutine(ShowFinishMenuAfterDelay(2f, other.tag));
        }
    }

    private IEnumerator ShowFinishMenuAfterDelay(float delay, string winnerTag)
    {
        yield return new WaitForSeconds(delay);
        Time.timeScale = 0;
        isPaused = true;

        finishMenu.SetActive(true);
        winnerText.text = winnerTag + " Wins!";
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ExitGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
}
