using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public enum UnitState
{
    Idle,
    Walk,
    Plow,
    Sow,
    Water,
    Harvester
}
    public enum Gender
{
    male,
    female
}
    
public class Worker : MonoBehaviour
{
    [SerializeField] private int id;

    public int ID { get { return id; } set { id = value; } }

    [SerializeField] private int charSkinID;

    public int CharSkinID { get { return charSkinID; } set { charSkinID = value; } }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
