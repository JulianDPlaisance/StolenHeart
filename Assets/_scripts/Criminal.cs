using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Criminal : Killable
{
    public override void Killed(Player player)
    {
        player.incCrimKills();
    }
}
