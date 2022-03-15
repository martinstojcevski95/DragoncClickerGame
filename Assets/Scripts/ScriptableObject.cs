using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Dragon", menuName = "Dragons/Dragon", order = 1)]
public class DragonObject : ScriptableObject
{ 

    public string Name;
    public string Level;
    public float Energy;
    public float Income;
    public float Price;
    


}


[CreateAssetMenu(fileName = "Egg", menuName = "Eggs/Egg", order = 1)]
public class Eggs : ScriptableObject
{

    public string Name;
    public string Level;
    public float Energy;
    public float Income;
    public float Price;



}