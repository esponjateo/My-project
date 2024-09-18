using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class PlayerOne : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI Output;
    string Name = "Max";
    int Age = 18;
    string Race = "Demon";
    int PhysicalDamage = 35;
    int Armor = 70;
    int MagicDamage = 56;
    int MagicResistance = 28;
    float Speed = 160.25f;

    public void ButtonPress()
    {
        Output.text = ("Name: " + Name + "\r\nAge: " + Age + "\r\nRace: " + Race + "\r\nPhysicalDamage: " + PhysicalDamage + "\r\nArmor: " + Armor + "\r\nMagicDamage: " + MagicDamage + "\r\nMagicResistance: " + MagicResistance + "\r\nSpeed: " + Speed);
    }






}
