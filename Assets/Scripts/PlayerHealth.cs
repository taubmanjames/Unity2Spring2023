using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Cinemachine;

public class PlayerHealth : MonoBehaviour
{
    public Image healthBar;
    public float playerHealth;
    public float currentHealth;
    public PlayerController player;
    public CinemachineVirtualCamera cam;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = playerHealth;    
    }
    
    public void TakeDamage(float damage)
    {

        currentHealth -= damage;
        healthBar.fillAmount = currentHealth / playerHealth;
        if(currentHealth <= 0)
        {
            cam.enabled = false;
            player.gameOver = true;
            player.playerDead();
        }
    }
}
