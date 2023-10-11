using UnityEngine;
using UnityEngine.EventSystems;


[SelectionBase]
public class Item : MonoBehaviour, IPointerClickHandler
{
    public ItemData ItemData;
    public ParticleSystem ParticleSystem;
    public float RotationSpeed = 20.0f;

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log(name + " Game ObjectClicked!" + "ID" + ItemData.ItemID + " price" + ItemData.ItemPrice);

        if (ItemData.IsDestroyable)
        {
            Destroy(gameObject);
            Instantiate(ParticleSystem, transform.position, Quaternion.identity);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        // place l'objet en utilisant la data de l'objet
        transform.position = ItemData.ItemPosition;
        
        //Mesh myMesh = Instantiate(ItemData.ItemMeshFilter);
        //GetComponent<MeshFilter>().sharedMesh = myMesh;
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(transform.position, Vector3.up, RotationSpeed * Time.deltaTime);
    }
}
