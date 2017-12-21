using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHoldData : MonoBehaviour {

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad(this);
	}

	//active/shown stats
	int hitpts, hearts, curScore, totalKills;
	//passive/hidden stats
	int civKills, crimKills, polKills, preyKills, predKills;


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


	//Functions for incrementing individual stats
	public void addHP(int hps)
	{
		hitpts += hps;
	}
	public void addHearts(int hearty)
	{
		hearts += hearty;
	}
	public void addScore(int score)
	{
		curScore += score;
	}
	public void addKills(int kills)
	{
		totalKills += kills;
	}
	public void addCivKills(int kills)
	{
		civKills += kills;
	}
	public void addCrimKills(int kills)
	{
		crimKills += kills;
	}
	public void addPolKills(int kills)
	{
		polKills += kills;
	}
	public void addPreyKills(int kills)
	{
		preyKills += kills;
	}
	public void addPredKills(int kills)
	{
		predKills += kills;
	}

}
