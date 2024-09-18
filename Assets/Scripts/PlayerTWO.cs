using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerTWO : MonoBehaviour
{


    [SerializeField] private TextMeshProUGUI PE;


    string Name = "Sunshine Sparkle";
    int Age = 26;
    string Race = "Unicorn";
    int PhysicalDamage = 35;
    int Armor = 10;
    int MagicDamage = 78;
    int MagicDefence = 60;
    float Speed = 50f;

    public void buttonpress()
    {
        PE.text = ("Name: " + Name + "\r\nAge: " + Age + "\r\nRace" + Race + "\r\nPhysicalDamage" + PhysicalDamage + "\r\nArmor" + Armor + "\r\nMagicDamage" + MagicDamage + "\r\nMagicDefense" + MagicDefence + "\r\nSpeed" + Speed);
    }

}



