using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseLogic : MonoBehaviour
{

    public GameObject finishScreen;
    public GameObject wasted;
    [HideInInspector] public static LoseLogic instance = null;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

    }

   

    public void OnLose() {
        StartCoroutine(LoseFlow());
       
    }

    IEnumerator LoseFlow() {
        finishScreen.SetActive(true);
        Time.timeScale = 0.1f;
        yield return new WaitForSeconds(0.2f);
        wasted.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);


    }
   
}
