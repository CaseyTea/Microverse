// Jenni
using UnityEngine;

public class GameManager : MonoBehaviour {
    [SerializeField] private GameState currentState = GameState.None;
    [SerializeField] private GameObject startButton;
    [SerializeField] private GameObject exitToMenuButton;
    [SerializeField] private GameObject restartGame;

    public GameState CurrentState {
        get { return this.currentState; }
        set { this.currentState = value; }
    }

    // GameStates
    // Intro - directions with start button
    // Playing - playing the game loop
    // Game Over - display score, restart game and exit to menu buttons
    #region MonoBehavior

    private void Start() {
        Screen.autorotateToPortrait = false;
        Screen.autorotateToPortraitUpsideDown = false;
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        Debug.Log("Screen should be rotated");
        Subscribe();
        currentState = GameState.Intro;
        // Might want to move this stuff to its own method
        startButton.SetActive(true);
        exitToMenuButton.SetActive(false);
        restartGame.SetActive(false);
        // Show instructions?
        // Start Game Soundtrack
    }

    private void OnEnable() {
        Subscribe();
    }

    private void OnDisable() {
        Unsubscribe();
    }

    #endregion MonoBehavior

    #region Methods

    public void PlayGame() {
        currentState = GameState.Playing;
        startButton.SetActive(false);
        restartGame.SetActive(false);
        exitToMenuButton.SetActive(false);
    }

    public void EndGame() {
        currentState = GameState.GameOver;
        startButton.SetActive(false);
        exitToMenuButton.SetActive(true);
        restartGame.SetActive(true);
    }

    private void Subscribe() {
        Unsubscribe();
    }

    private void Unsubscribe() {
    }

    #endregion Methods
}