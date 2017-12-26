using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class AnimSpriteSet
{
    public string AnimationName;
    public Sprite[] Anim_Sprites;
}
//Holding player data for just the current level
public class Player : MonoBehaviour {
    //active/shown stats
    public int hitpts, hearts, curScore, totalKills;
    //passive/hidden stats
    public int civKills, crimKills, polKills, preyKills, predKills;

    public AnimSpriteSet AnimSpriteSet;

    public GameObject plyrData;
    // Use this for initialization
    public void Awake()
    {
        AnimSpriteSet.AnimationName = "Idle;";
        plyrData = GameObject.FindGameObjectWithTag("Data");
        startSetUp(plyrData.GetComponent<PlayerHoldData>());

    }

    //Functions for getting individual stats
    public int getHP()
    {
        return hitpts;
    }
    public int getHearts()
    {
        return hearts;
    }
    public int getCurrentScore()
    {
        return curScore;
    }
    public int getTotalKills()
    {
        return totalKills;
    }
    public int getCivKills()
    {
        return civKills;
    }
    public int getCrimKills()
    {
        return crimKills;
    }
    public int getPolKills()
    {
        return polKills;
    }
    public int getPreyKills()
    {
        return preyKills;
    }
    public int getPredKills()
    {
        return predKills;
    }



    //Functions for setting individual stats
    public void setHP(int hps)
    {
        hitpts = hps;
    }
    public void setHearts(int hearty)
    {
        hearts = hearty;
    }
    public void setScore(int score)
    {
        curScore = score;
    }
    public void setKills(int kills)
    {
        totalKills = kills;
    }
    public void setCivKills(int kills)
    {
        civKills = kills;
    }
    public void setCrimKills(int kills)
    {
        crimKills = kills;
    }
    public void setPolKills(int kills)
    {
        polKills = kills;
    }
    public void setPreyKills(int kills)
    {
        preyKills = kills;
    }
    public void setPredKills(int kills)
    {
        predKills = kills;
    }

    //Functions for adding to or incrementing individual stats
    public void addHP(int hps)
    {
        hitpts += hps;
    }
    public void incHearts()
    {
        hearts++;
    }
    public void decHearts()
    {
        hearts--;
    }
    public void addScore(int score)
    {
        curScore += score;
    }
    public void incKills()
    {
        totalKills++;
    }
    public void incCivKills()
    {
        civKills++;
    }
    public void incCrimKills()
    {
        crimKills++;
    }
    public void incPolKills()
    {
        polKills++;
    }
    public void incPreyKills()
    {
        preyKills++;
    }
    public void incPredKills()
    {
        predKills++;
    }

    public void startSetUp()
    {
        setHP(100);
        setHearts(0);
        setScore(0);
        setKills(0);
        setCivKills(0);
        setCrimKills(0);
        setPolKills(0);
        setPreyKills(0);
        setPredKills(0);
    }

    public void startSetUp(PlayerHoldData data)
    {
        setHP(data.getHP());
        setHearts(data.getHearts());
        setScore(data.getCurrentScore());
        setKills(data.getTotalKills());
        setCivKills(data.getCivKills());
        setCrimKills(data.getCrimKills());
        setPolKills(data.getPolKills());
        setPreyKills(data.getPreyKills());
        setPredKills(data.getPredKills());
    }

    public void startSetUp(int HP, int Hearts, int Score)
    {
        setHP(HP);
        setHearts(Hearts);
        setScore(Score);
        setKills(0);
        setCivKills(0);
        setCrimKills(0);
        setPolKills(0);
        setPreyKills(0);
        setPredKills(0);
    }

    public void startSetUp(int HP, int Hearts, int Score, int totalKills, int Civ, int Crim, int Pol, int Prey, int Pred)
    {
        setHP(HP);
        setHearts(Hearts);
        setScore(Score);
        setKills(totalKills);
        setCivKills(Civ);
        setCrimKills(Crim);
        setPolKills(Pol);
        setPreyKills(Prey);
        setPredKills(Pred);
    }


}
