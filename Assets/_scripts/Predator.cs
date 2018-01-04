using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Predator : Killable
{
    public override void Killed(Player player)
    {
        player.incPredKills();
    }
}
