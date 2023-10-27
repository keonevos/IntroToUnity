using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float SpeedInMeterPerSecond = 6.0f;
    public float RotationSpeedInDegreePerSecond = 15.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // # Vous pouvez retrouver les axes dans les menus de Unity : Edit > Project Settings > Input Manager > Axes
        // il y a les axes 'Horizontal' et 'Vertical' pour le clavier ET la manette
        Vector3 lInputVector = new Vector3(Input.GetAxisRaw("Horizontal"), 0.0f, Input.GetAxisRaw("Vertical"));

        // # ici on normalize le vecteur pour avoir une vitesse constante dans toutes les directions
        Vector3 lDirection = lInputVector.normalized;

        // # Déplacement du Player
        // on récupère la position actuelle du Player et on lui ajoute la direction multipliée par la vitesse et le temps écoulé depuis la dernière frame
        transform.position = transform.position + (lDirection * SpeedInMeterPerSecond * Time.deltaTime);

        // même chose avec la notation +=
        //transform.position += lDirection * SpeedInMeterPerSecond * Time.deltaTime;

        // encore une alternative avec la fonction 'Translate' qui est disponible sur tous les GameObjects
        //transform.Translate(lDirection * SpeedInMeterPerSecond * Time.deltaTime);


        // # Rotation du Player        
        // On connait la direction du coup on peut entrer la valeur directement dans le forward vector qui est disponible sur tous les GameObjects

        // transform.forward = lDirection;

        // version smooth en utilisant une interpolation sphérique (Slerp => https://docs.unity3d.com/ScriptReference/Vector3.Slerp.html)
        transform.forward = Vector3.Slerp(transform.forward, lDirection, RotationSpeedInDegreePerSecond * Time.deltaTime);


    }
}
