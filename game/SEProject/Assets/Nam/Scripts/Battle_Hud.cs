using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Battle_Hud : MonoBehaviour
{
    public Text name_text;
    public int current_hp;
    public int max_hp;

    public void Set_Hud(Combat_Unit unit)
    {
        name_text.text = unit.unit_name;
        current_hp = unit.current_hp;
        max_hp = unit.max_hp;
    }
    public void Set_Hp(int hp)
    {
        current_hp = hp;
    }
}