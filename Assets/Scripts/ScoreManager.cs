using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

    public int currentlevel = 0;
    public int[] levelScoreThresholds;
    public int score = 0;

    public delegate void LevelChangedEvent(int newlevel);
    public event LevelChangedEvent LevelChanged;

    private void OnGUI()
    {
        GUILayout.Label("Score: " + score);
    }

    private void Update()
    {
        if (score > levelScoreThresholds[currentlevel])
        {
            currentlevel += 1;

            LevelChanged(currentlevel);
        }
    }

    #region SingletonAndAwake
    private static ScoreManager instance = null;
    public static ScoreManager Instance
    {
        get { return instance; }
    }

    private void Awake()
    {
        if (instance != null && instance != this)

        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
        gameObject.name = "$ScoreManager";
    }
    #endregion
}
