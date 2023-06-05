using UnityEngine;

public class GameManager : MonoBehaviour
{
	private bool isGamePaused = true;
	public AudioSource backgroundMusic;

	void Start()
	{
		// Set the initial timescale to 0 to pause the game
		Time.timeScale = 0f;

		// Pause the background music at the start
		backgroundMusic.Pause();
	}

	void Update()
	{
		if (isGamePaused && Input.GetKeyDown(KeyCode.Space))
		{
			// Resume the game by setting timescale to 1
			Time.timeScale = 1f;
			isGamePaused = false;

			// Play the background music
			backgroundMusic.Play();
		}
	}
}