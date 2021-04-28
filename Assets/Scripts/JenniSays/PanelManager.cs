// Jenni
using UnityEngine;
namespace JenniSays {
    
    public class PanelManager : MonoBehaviour {

        [SerializeField] private GameObject intro;
        [SerializeField] private GameObject playing;
        [SerializeField] private GameObject gameOver;
      
        private void ChangePanel(GameState currentState) {
            if (currentState == GameState.Intro) {
                intro.SetActive(true);
                playing.SetActive(false);
                gameOver.SetActive(false);
            }
            if (currentState == GameState.Playing) {
                intro.SetActive(false);
                playing.SetActive(true);
                gameOver.SetActive(false);
            }
            if (currentState == GameState.GameOver) {
                intro.SetActive(false);
                playing.SetActive(false);
                gameOver.SetActive(true);
            }

        }
        
      
    }
}

