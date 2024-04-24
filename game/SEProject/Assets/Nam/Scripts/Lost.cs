using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lost : State
{
    public Lost(BattleSystem battleSystem) : base(battleSystem)
    {
    }

    public override IEnumerator Start()
    {
        BattleSystem.dialogue.text = "You have lost!";
        BattleSystem.buttonManager.ClearButtons();
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(BattleSystem.previousScene);
    }
}
