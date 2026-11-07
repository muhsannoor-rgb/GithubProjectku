using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    public void Button_Exit()
    {
        Application.Quit();
        Debug.Log("Mulai Game");
    }

    public void BattleMode()
    {
        SceneManager.LoadScene("BattleMode");
    }

        public void ConcertMode()
    {
        SceneManager.LoadScene("ConcertMode");
    }

        public void AboutGame()
    {
        SceneManager.LoadScene("AboutGame");
    }

        public void AboutDevelopers()
    {
        SceneManager.LoadScene("AboutDevelopers");
    }

        public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

        public void MainUtama()
    {
        SceneManager.LoadScene("MainUtama");
    }

        public void ScanBattleARScreen()
    {
        SceneManager.LoadScene("ScanBattleARScreen");
    }

            public void ScanConcertARScerens()
    {
        SceneManager.LoadScene("ScanConcertARScerens");
    }

            public void OpeningGame()
    {
        SceneManager.LoadScene("OpeningGame");
    }
}