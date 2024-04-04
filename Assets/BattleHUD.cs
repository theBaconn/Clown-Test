using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleHUD : MonoBehaviour
{
    public Text nameText;
    public Text currentHP;
    public Text maxHP;
    public Sprite enemySprite;

    public void SetHUD(PlayerScript combatant)
    {
        nameText.text = combatant.name;
        currentHP.text = combatant.currentHP.ToString();
        maxHP.text = combatant.maxHP.ToString();
    }

    public void SetHP(int hp)
    {
        
        currentHP.text = hp.ToString();
    }


}
