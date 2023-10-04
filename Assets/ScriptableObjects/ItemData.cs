using UnityEngine;

[CreateAssetMenu(fileName = "ItemData", menuName = "ScriptableObjects/ItemData", order = 1)]
public class ItemData : ScriptableObject
{
    public enum ERarity
    {
        Common,
        Rare,
        Epic,
        Legendary
    }

    // Default values
    public int ItemID = -1;
    public float ItemPrice = 0.0f;
    public string ItemName = "Default ItemName";
    public bool IsDestroyable = false;
    public ERarity Rarity = ERarity.Common;
    public Vector3 ItemPosition = new Vector3(0.0f, 0.0f, 0.0f);
}
