using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class MenuScript : MonoBehaviour
    {
        public void gameStart()
        {
            SceneManager.LoadScene("Level 1");
        }

        public void gameOptions()
        {
            SceneManager.LoadScene("Options");
        }

        public void gameHelp()
        {
            SceneManager.LoadScene("Help");
        }

        public void gameCredits()
        {
            SceneManager.LoadScene("Credits");
        
    }
        public void gameReturn()
        {
            SceneManager.LoadScene("Main Menu");
        
        }
        
    }
}