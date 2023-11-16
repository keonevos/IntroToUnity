using Cinemachine;
using UnityEngine;
using Cinemachine;
using UnityEngine.EventSystems;


[SelectionBase]
public class Pickup : MonoBehaviour
{
    public ItemData ItemData;
    public ParticleSystem ParticleSystem;
    public float RotationSpeed = 20.0f;
    public GameObject ItemPrefb;
<<<<<<< Updated upstream
    public CinemachineVirtualCamera VirtualCamera;
=======
    public CinemachineVirtualCamera RefCameraFix;
    public int m_Priority = 10;
>>>>>>> Stashed changes

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(name + " Game ObjectClicked!" + "ID" + ItemData.ItemID + " price" + ItemData.ItemPrice);
        RefCameraFix.enabled = false;

        if (ItemData.IsDestroyable)
        {
            Destroy(gameObject);
            Instantiate(ParticleSystem, transform.position, Quaternion.identity);
<<<<<<< Updated upstream

            VirtualCamera.enabled = false;
=======
            RefCameraFix.enabled = true;
            RefCameraFix.m_Priority = 30;
>>>>>>> Stashed changes
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
        ItemPrefb.transform.RotateAround(transform.position, Vector3.up, RotationSpeed * Time.deltaTime);
    }
}
