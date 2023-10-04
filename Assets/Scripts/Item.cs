using UnityEngine;
using UnityEngine.EventSystems;

public class Item : MonoBehaviour, IPointerClickHandler
{
    public ItemData ItemData;
    public float RotationSpeed = 20.0f;

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log(name + " Game ObjectClicked!" + "ID" + ItemData.ItemID + " price" + ItemData.ItemPrice);

        if (ItemData.IsDestroyable)
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        // place l'objet avec ses datas
        transform.position = ItemData.ItemPosition;
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(transform.position, Vector3.up, RotationSpeed * Time.deltaTime);
    }
}
