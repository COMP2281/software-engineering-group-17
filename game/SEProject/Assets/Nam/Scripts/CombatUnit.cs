using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatUnit : MonoBehaviour
{
    public string unitName = "Player";
    public int damage;
    public int currentHp;

    public bool TakeDamage(int dmg)
    {
        currentHp -= dmg;

        if (currentHp <= 0)
            return true;
        else
            return false;
        

    }
}