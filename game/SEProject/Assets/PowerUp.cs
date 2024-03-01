using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public int attackUp;
    public int hPUp;
    public GameObject powerUp;

    public PlayerScript player;
    public void Attack()
    {
        GM.gmInstance.AddAttackDamage(attackUp);
        powerUp.SetActive(false);
        player.canMove = true;
    }

    public void Hp()
    {
        GM.gmInstance.AddHP(hPUp);
        powerUp.SetActive(false);
        player.canMove = true;
    }
}
