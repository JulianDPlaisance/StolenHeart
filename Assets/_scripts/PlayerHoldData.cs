using System;
using System.IO;
using UnityEngine;

public class PlayerHoldData : MonoBehaviour {
	private string FILENAME = "Save.txt";
	// Use this for initialization
	StreamWriter fw;
	StreamReader fr;
	FileStream fs;
	string[] contents = new string[9];
	//active/shown stats
	public int hitpts = 100, hearts = 0, curScore = 0, totalKills = 0;
	//passive/hidden stats
	public int civKills = 0, crimKills = 0, polKills = 0, preyKills = 0, predKills = 0;

	int[] OldStats = new int[9], NewStats = new int[9];

	void Start()
	{
		DontDestroyOnLoad(this);
		if (File.Exists(FILENAME))
		{
			fr = new StreamReader(File.Open(FILENAME, FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite));
			startSetUp(fr);
			fr.Close();
		}
		else
		{
			fw = new StreamWriter(File.Open(FILENAME, FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite));
			writeStuff(fw);
			fw.Close();
		}
	}
	public void FillContents()
	{
		contents[0] = "HEALTH: " + hitpts;
		contents[1] = "HEARTS: " + hearts;
		contents[2] = "SCORRE: " + curScore;
		contents[3] = "TLKILS: " + totalKills;
		contents[4] = "CIVKLS: " + civKills;
		contents[5] = "CRMKLS: " + crimKills;
		contents[6] = "POLKLS: " + polKills;
		contents[7] = "PRYKLS: " + preyKills;
		contents[8] = "PRDKLS: " + predKills;
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

	public void startSetUp(StreamReader reader)
	{
		for (int i = 0; i < 9; i++)
		{
			OldStats[i] = Int32.Parse(reader.ReadLine().Substring(7));
		}
		setHP(OldStats[0]);
		setHearts(OldStats[1]);
		setScore(OldStats[2]);
		setKills(OldStats[3]);
		setCivKills(OldStats[4]);
		setCrimKills(OldStats[5]);
		setPolKills(OldStats[6]);
		setPreyKills(OldStats[7]);
		setPredKills(OldStats[8]);
	}

	private void writeStuff(StreamWriter writer)
	{
		FillContents();
		for(int i = 0; i < 9; i++)
		{
			writer.WriteLine(contents[i]);
		}
	}

	private void OnApplicationQuit()
	{
		fw = new StreamWriter(File.Open(FILENAME, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite));
		writeStuff(fw);
		fw.Close();
	}
}
