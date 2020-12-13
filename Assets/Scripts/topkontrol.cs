using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class topkontrol : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody fizik;
    public int hiz;
    int sayac = 0;
    public int toplanilacakObjeSayisi;
    public Text sayacText;
    public Text oyunBittiText;
   
    void Start()
    {
        fizik = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float yatay = Input.GetAxisRaw("Horizontal");
        float dikey = Input.GetAxisRaw("Vertical");

        Vector3 vec = new Vector3(yatay, 0, dikey);

        fizik.AddForce(vec*hiz);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Kristal")
        {
            other.gameObject.SetActive(false);
            
            sayac++;
            sayacText.text = "Skor=" + sayac;

            if (sayac == toplanilacakObjeSayisi)
            {
                StartCoroutine(NextLevel());
;            }
            
        }
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Duvarlar")
        {
            sayac--;
            sayacText.text = "Skor=" + sayac;
            Debug.Log("çarptı");
        }
    }
    IEnumerator NextLevel()
    {
        oyunBittiText.text = "BRAVO!!!";
        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(2);
        
    }
    void Endgame()
    {
        Application.Quit();
    }
    
}
