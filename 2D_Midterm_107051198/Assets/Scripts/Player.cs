
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public GameObject final;
    public Text textCount;
    public int count;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "傳送門")
        {
            final.SetActive(true);
        }

        if (collision.tag == ("鯛魚燒"))
        {
            Destroy(collision.gameObject);
            count++;
            textCount.text = "鯛 魚 燒 數 量 : " + count;
        }
    }
    


}
