using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Police : Killable
{
    public override void Killed(Player player)
    {
        player.incPolKills();
    }
}
