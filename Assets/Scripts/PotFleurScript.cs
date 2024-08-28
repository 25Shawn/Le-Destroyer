using UnityEngine;

public class PotFleur : MonoBehaviour
{
    [SerializeField]
    private GameObject potInitial;

    [SerializeField]
    private GameObject potBriser;


    public void OnCasser()
    {
        if (potInitial != null)
        {
            Destroy(potInitial.gameObject);

        }

        GameObject nouvelObjet = Instantiate(potBriser, transform);
    }
}
