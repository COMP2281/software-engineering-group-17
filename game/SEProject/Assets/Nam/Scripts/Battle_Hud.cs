using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Battle_Hud : MonoBehaviour
{
    public TextMeshProUGUI name_text;
    public TextMeshProUGUI hp_text;
    public int current_hp;
    public int max_hp;

    public void Set_Hud(Combat_Unit unit)
    {
        name_text.text = unit.unit_name;
        current_hp = unit.current_hp;
        hp_text.text = unit.current_hp.ToString();
        max_hp = unit.max_hp;

    }
    public void Set_Hp(int hp)
    {
        current_hp = hp;
        hp_text.text = current_hp.ToString();
    }
}
