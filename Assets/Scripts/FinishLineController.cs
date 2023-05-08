using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLineController : MonoBehaviour
{
    public CarController carController;
    public FinishLineUI finishLineUI;

    private bool hasFinished = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !hasFinished)
        {
            hasFinished = true;
            carController.enabled = false;
            finishLineUI.ShowSuccessMessage();
            StartCoroutine(LoadStartScreen());
        }
    }

    IEnumerator LoadStartScreen()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("StartScreen");
    }
}
