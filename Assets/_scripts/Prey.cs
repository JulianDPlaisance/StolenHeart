using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prey : Killable
{
    public override void Killed(Player player)
    {
        player.incPreyKills();
    }
}
