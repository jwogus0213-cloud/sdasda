using UnityEngine;

public class PlayerLevel : MonoBehaviour
{
    public int level = 1;
    public int curretXp = 0;
    public int xpToNextLevel = 5;
    public AutoShooter autoShooter;

    public void AddXp(int amount)
    {
        curretXp += amount;

        Debug.Log("XP: " + curretXp + " / " + xpToNextLevel );

        if(curretXp <= xpToNextLevel)
        {
            LevelUp();
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
