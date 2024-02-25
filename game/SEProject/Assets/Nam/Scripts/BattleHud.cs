using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BattleHud : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI hpText;
    public int currentHp;
    public int maxHp;

    public void SetHud(CombatUnit unit)
    {
        nameText.text = unit.unitName;
        currentHp = unit.currentHp;
        hpText.text = unit.currentHp.ToString();
        maxHp = unit.maxHp;

    }
    public void SetHp(int hp)
    {
        if (hp < 0)
        {
            hp = 0;
        }
        currentHp = hp;
        hpText.text = currentHp.ToString();
    }
}
