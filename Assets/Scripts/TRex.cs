using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class TRex : MonoBehaviour
{
    [SerializeField]
    private float vitesse;

    [SerializeField]
    private float vitesseRotation;

    private Vector2 deplacement;
    private float rotation;

    public void OnDeplacement(InputValue valeur)
    {
        deplacement = valeur.Get<Vector2>();
    }
    public void OnRotation(InputValue valeur)
    {
        rotation = valeur.Get<float>();
    }

    private void FixedUpdate()
    {
        if(deplacement.sqrMagnitude > 0)
        {
            Vector3 deplacementEffectif = (deplacement.y * transform.forward + deplacement.x * transform.right).normalized;
            transform.position += deplacementEffectif * vitesse * Time.deltaTime;

            transform.Rotate(Vector3.up, rotation * vitesseRotation * Time.deltaTime);


        }
        

    }

}
