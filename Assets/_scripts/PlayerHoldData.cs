using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHoldData : MonoBehaviour {
	private string FILENAME = "Save.txt";
	// Use this for initialization
	public FileStream fs;
	//active/shown stats
	int hitpts, hearts, curScore, totalKills;
	//passive/hidden stats
	int civKills, crimKills, polKills, preyKills, predKills;
	public string filePath;

	void Start()
	{
		DontDestroyOnLoad(this);
		string contents = "";

		if(File.Exists(FILENAME))
		{
			fs = File.Open(FILENAME, FileMode.Open);
		}
		else
		{
			fs = File.Create(FILENAME);
			startSetUp();
			fillContentsAtStart(contents);
			File.WriteAllText(fs.Name, contents);
		}
		
	}
	public string fillContentsAtStart(string contents)
	{
		contents += "HP: " + hitpts + "\n";
		contents += "HEARTS: " + hearts + "\n";
		contents += "SCORE: " + curScore + "\n";
		contents += "TOTAL_KILLS: " + totalKills + "\n";
		contents += "CIVILIAN_KILLS: " + civKills + "\n";
		contents += "CRIMINAL_KILLS: " + crimKills + "\n";
		contents += "POLICE_KILLS: " + polKills + "\n";
		contents += "PREY_KILLS: " + preyKills + "\n";
		contents += "PREDATOR_KILLS: " + predKills + "\n";
		return contents;
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

	public void Quit()
	{
		string contents = File.ReadAllText(fs.Name);
		System.Console.WriteLine(contents);
	}

}
