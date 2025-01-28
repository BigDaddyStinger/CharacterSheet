using System;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class CharacterSheet : MonoBehaviour
{
    [SerializeField] string characterName;
    [SerializeField] int profMod;
    [SerializeField] bool finesseWeapon;
    [SerializeField][Range(-5, 5)] int strengthMod;
    [SerializeField][Range(-5, 5)] int dexMod;
    int enemyAC;
    int diceRoll;
    int dexAttackPoints;
    int strengthAttackPoints;

    [ContextMenu("Fight")]

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        enemyAC = UnityEngine.Random.Range(1, 20);
        diceRoll = UnityEngine.Random.Range(1, 20);
        dexAttackPoints = diceRoll + dexMod;
        strengthAttackPoints = diceRoll + strengthMod;
        //Debug.Log("I'm A Princess");

        if (finesseWeapon == true)
        {
            if (dexMod > strengthMod)
            {
                Debug.Log(characterName + "'s hit modifier is " + (profMod + dexMod) + ".");
                Debug.Log("Enemy AC is " + enemyAC + ".");
                Debug.Log(characterName + " rolled a " + diceRoll + ".");

                if (diceRoll == 1)
                {
                    Debug.Log(characterName + " missed and fell down, losing a turn!");
                }
                else if (diceRoll == 20)
                {
                    Debug.Log(characterName + " hit the enemy so hard, they fell down and lost a turn!");
                }
                else if (dexAttackPoints > enemyAC)
                {
                    Debug.Log("Enemy is hit!");
                }
                else
                {
                    Debug.Log(characterName + " missed!");
                }
            }
            else
            {
                Debug.Log(characterName + "'s hit modifier is " + (profMod + strengthMod) + ".");
                Debug.Log("Enemy AC is " + enemyAC + ".");
                Debug.Log(characterName + " rolled a " + diceRoll + ".");

                if (diceRoll == 1)
                {
                    Debug.Log(characterName + " missed and fell down, losing a turn!");
                }
                else if (diceRoll == 20)
                {
                    Debug.Log(characterName + " hit the enemy so hard, they fell down and lost a turn!");
                }
                else if (strengthAttackPoints > enemyAC)
                {
                    Debug.Log("Enemy is hit!");
                }
                else
                {
                    Debug.Log(characterName + " missed!");
                }
            }

            
        }
        else
            {
                Debug.Log(characterName + "'s hit modifier is " + (profMod + strengthMod) + ".");
                Debug.Log("Enemy AC is " + enemyAC + ".");
                Debug.Log(characterName + " rolled a " + diceRoll + ".");

                if (diceRoll == 1)
                {
                    Debug.Log(characterName + " missed and fell down, losing a turn!");
                }
                else if (diceRoll == 20)
                {
                    Debug.Log(characterName + " hit the enemy so hard, they fell down and lost a turn!");
                }
                else if (strengthAttackPoints > enemyAC)
                {
                    Debug.Log("Enemy is hit!");
                }
                else
                {
                    Debug.Log(characterName + " missed!");
                }
            
        

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
