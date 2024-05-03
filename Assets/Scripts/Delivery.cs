using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Delivery : MonoBehaviour
{
   [SerializeField] float packageDestroyTime = 0.5f;
   [SerializeField] Color32 hasPackageColor = new Color32(1, 1, 1, 1);
   [SerializeField] Color32 noPackageColor = new Color32(1, 1, 1, 1);

   SpriteRenderer spriteRenderer;

   void Start()
   {
      spriteRenderer = GetComponent<SpriteRenderer>();
   }


   bool hasPackage;
void OnCollisionEnter2D(Collision2D other)
{
   Debug.Log("Car Collides");
  

}

void OnTriggerEnter2D(Collider2D other)
{
   if(other.tag == "Package" && !hasPackage)
   {
      Debug.Log("Package picked");
      hasPackage = true;
      spriteRenderer.color = hasPackageColor;
      Destroy(other.gameObject, packageDestroyTime);

   }

   if(other.tag == "Customer" && hasPackage)
   {
       Debug.Log("Package has delivered");
       hasPackage = false;
       spriteRenderer.color = noPackageColor;
   }

  
}

}