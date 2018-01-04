using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Civilian : Killable
{
    public override void Killed(Player player)
    {
        player.incCivKills();
    }

}
