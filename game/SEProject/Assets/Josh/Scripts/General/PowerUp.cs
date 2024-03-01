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
        GM.gmInstance.GotItem1();
        powerUp.SetActive(false);
        player.canMove = true;
    }

    public void Hp()
    {
        GM.gmInstance.AddHP(hPUp);
        GM.gmInstance.GotItem1();
        powerUp.SetActive(false);
        player.canMove = true;
    }
}
