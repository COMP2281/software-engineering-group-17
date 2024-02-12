using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat_Unit : MonoBehaviour
{
    public string unit_name;
    public int damage;
    public int max_hp;
    public int current_hp;

    public bool Take_Damage(int dmg)
    {
        current_hp -= dmg;

        if (current_hp <= 0)
            return true;
        else
            return false;
        

    }
}
