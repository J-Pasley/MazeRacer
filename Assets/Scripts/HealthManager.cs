using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{
    public int maxHealth = 3; // maximum health value
    public int currentHealth; // current health value
    public Image healthBar; // reference to the health bar UI element
	public AudioClip collisionSound;
    public string gameOverSceneName = "GameOver"; // name of the scene to load when game over occurs

    private int wallHits = 0; // number of wall collisions the player has had

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthBar();
    }

    // Update is called once per frame
    void Update()
    {
        // check if health has reached zero
        if (currentHealth <= 0)
        {
            // load the game over scene
            SceneManager.LoadScene("GameOver");
        }
    }

    // called when the player collides with a wall
    public void WallCollision()
    {
        wallHits++;

        // check if the player has hit a wall
        if (wallHits >= 1)
        {
            currentHealth--;
            wallHits = 0;
            UpdateHealthBar();
			
			// play sound effect
			AudioSource.PlayClipAtPoint(collisionSound, transform.position);
        }
    }

    // updates the health bar UI element
	void UpdateHealthBar()
	{
		float healthPercentage = (float)currentHealth / (float)maxHealth;
		healthBar.rectTransform.localScale = new Vector3(healthPercentage, 1, 1);
	}

}

