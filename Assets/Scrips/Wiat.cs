using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wiat : MonoBehaviour
{
    public float wait_time = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitBumper());
    }

    IEnumerator WaitBumper()
    {
        yield return new WaitForSeconds(wait_time);
        SceneManager.LoadScene(1);
    }
}
