using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Battle_hud : MonoBehaviour
{
    public Text name_text;
    public int current_hp;
    public int max_hp;

    public void Set_hud(Combat_unit unit)
    {
        name_text.text = unit.unit_name;
        current_hp = unit.current_hp;
        max_hp = unit.max_hp;
    }
    public void Set_hp(int hp)
    {
        current_hp = hp;
    }
}
