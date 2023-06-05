using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class JoeyScript : MonoBehaviour
{
	public Rigidbody2D rigidBody;
	public SpriteRenderer spriteRenderer;
	public Sprite deadSprite;
	public AudioSource audioSource;
	public BackgroundSoundScript backgroundSound;
	public AudioClip deathSound;

	public float flapStrength;
	public LogicScript logic;
	public bool joeyIsAlive = true;

	// Start is called before the first frame update
	void Start()
	{
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space) && joeyIsAlive)
		{
			rigidBody.velocity = Vector2.up * flapStrength;
		} 
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{

		if (joeyIsAlive)
		{
			joeyIsAlive = false;
			backgroundSound.stopSound();
			spriteRenderer.sprite = deadSprite;
			audioSource.PlayOneShot(deathSound);
			logic.gameOver();
		}
	}
}
