using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Upgrade : MonoBehaviour
{
    public string abilityName;
    public SpriteRenderer abilityIcon;
    public int cost;

    [SerializeField]
    private TextMeshProUGUI itemNameInMenu;
    [SerializeField]
    private TextMeshProUGUI itemCostInMenu;

    public PlayerControl player;

    void Start()
    {
        player = GetComponent<PlayerControl>();
        itemNameInMenu.text = abilityName;
        itemCostInMenu.text = cost.ToString();
    }

    void Update()
    {
     //   
    }

    public virtual void ActivateAbility()
    {
        //overwrite me... probably just turn something on or off in player controller to keep thing easy.
    }
    
    //UI NEEDS TO TALK TO ME FOR WHAT TO DISPLAY
}
