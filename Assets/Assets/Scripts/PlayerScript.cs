using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int currentHP;
    public int attack;
    public int baseAttack;
    public int defense;
    public int baseDefense;
    public string charName;
    public int maxHP;
    public int currentMP;
    public int maxMP;
    public int enemyTurnCount;


    public void TakeDamage(int damage)
    {
        if(damage < 0)
        {
            return;
        }
        else if(currentHP - damage < 0)
        {
            currentHP = 0;
        }
        else
        {
            currentHP = currentHP - damage;
        }
        
    }
}
