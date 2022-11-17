using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public GameObject[] levelUI;
    public Branch[] levels;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < levelUI.Length; i++)
        {
            int j = i;
            levelUI[i].GetComponent<Button>().onClick.AddListener(() => { Unlock(i); });
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Unlock(int id)
    {
        levelUI[id].transform.GetChild(1).gameobject.SetActive(false);
        for(int i = 0; i < levels[id].connectedLevels.Length; i++)
        {
            levelUI[i].transform.GetChild(1).gameobject.SetActive(false);
        }
    }
}
