using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class PlayerHealth : HealthComponent
{
    public override void KillCharacter()
    {
        base.KillCharacter();

        SceneManager.LoadScene("GameOver");
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Zombie"))
        {
            ApplyDamage(10);
        }
    }

}
