
using UnityEngine;
using System.IO; 

public static class SaveManager
{
    public static string directory = "/SaveHighScores/";
    public static string fileName = "STLevel1Scores.txt"; 

    public static void Save(SpeedTapScoresLevel1 scores)
    {
        string dir = Application.persistentDataPath + directory;

        if (!Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
        }

        string json = JsonUtility.ToJson(scores);
        File.WriteAllText(dir + fileName, json);
    }

    public static SpeedTapScoresLevel1 Load()
    {
        string fullPath = Application.persistentDataPath + directory + fileName;
        SpeedTapScoresLevel1 s = new SpeedTapScoresLevel1(); 

        if (File.Exists(fullPath))
        {
            string json = File.ReadAllText(fullPath);
            s = JsonUtility.FromJson<SpeedTapScoresLevel1>(json);
        }
        else
        {
            // if file does not exist load default values into object 
            Debug.Log("Save file does not exist");
            s.highScore1 = 0f;
            s.highScore2 = 0f;
            s.highScore3 = 0f; 
        }
        return s; 
    }


    /* Warning redundant code */
    public static string fileName2 = "STLevel2Scores.txt";

    public static void Save2(SpeedTapScoresLevel2 scores)
    {
        string dir = Application.persistentDataPath + directory;

        if (!Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
        }

        string json = JsonUtility.ToJson(scores);
        File.WriteAllText(dir + fileName2, json);
    }

    public static SpeedTapScoresLevel2 Load2()
    {
        string fullPath = Application.persistentDataPath + directory + fileName2;
        SpeedTapScoresLevel2 s = new SpeedTapScoresLevel2();

        if (File.Exists(fullPath))
        {
            string json = File.ReadAllText(fullPath);
            s = JsonUtility.FromJson<SpeedTapScoresLevel2>(json);
        }
        else
        {
            // if file does not exist load default values into object 
            Debug.Log("Save file does not exist");
            s.highScore1 = 0f;
            s.highScore2 = 0f;
            s.highScore3 = 0f;
        }
        return s;
    }
}
