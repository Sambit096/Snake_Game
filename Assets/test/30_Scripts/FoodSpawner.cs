using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour {

    public GameObject pizzaPrefab;
    public Material materialAfterCollision;
    public float minLimit = 1f, maxLimit = 5f;
    public float waitForSecondsAndDestroy = 0.0f;
    private IEnumerator Start()
    {
        yield return new WaitForSeconds(Random.Range(minLimit, maxLimit));
        SpawnAndDestroyPizza();
    }

    public void SpawnAndDestroyPizza()
    {
        Material parentMaterial = transform.parent.GetComponent<MeshRenderer>().material;
        if (this.transform.childCount != 0 || parentMaterial==materialAfterCollision) return;
        
         GameObject pizzaLabel= Instantiate(pizzaPrefab, this.transform.position,this.transform.rotation) as GameObject;
        pizzaLabel.transform.SetParent(this.transform);
        StartCoroutine(DestroyPizzaAfter(pizzaLabel.gameObject,waitForSecondsAndDestroy));
        
    }
    public IEnumerator DestroyPizzaAfter(GameObject _pizzaLabel,float _seconds)
    {
        yield return new WaitForSeconds(_seconds);
        DestroyPizza(_pizzaLabel);
            
    }

    public void DestroyPizza(GameObject obj)
    {
        Destroy(obj);
    }

   
}
