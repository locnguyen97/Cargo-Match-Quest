using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLevel : MonoBehaviour
{
    public List<GameObject> listSlot;
    [SerializeField] private Transform parentListObjSlot;
    
    public List<GameObject> listPlayer;
    [SerializeField] private Transform parentListPlayer;
    private bool canCheck = true;
    public void Start()
    {
        canCheck = true;
        
        foreach (Transform tr in parentListObjSlot)
        {
            listSlot.Add(tr.gameObject);
        }
        foreach (Transform tr in parentListPlayer)
        {
            listPlayer.Add(tr.gameObject);
        }
    }

    private int count = 0;

    public void RemoveObject()
    {
        count++;
        if (count == listSlot.Count)
        {
            GameManager.Instance.CheckLevelUp();
            canCheck = false;
        }
    }
}
