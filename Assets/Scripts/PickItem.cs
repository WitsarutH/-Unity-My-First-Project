using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PickItem : MonoBehaviour
{
    private int score = 0;
    public Text scoreText;
    private AudioSource audioSource;
    public AudioClip pickSound;
    public AudioClip winSound;
    private int itemCount;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        itemCount = GameObject.FindGameObjectsWithTag("Item").Length;
        scoreText.text = "Score = " + score.ToString() + " / " + itemCount.ToString();

    }

    /*private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Item"))
        {
            Destroy(collision.gameObject);
        }
    }*/
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag.Equals("Item"))
        {
            score += 1;
            Destroy(collision.gameObject);
            scoreText.text = "Score = " + score.ToString() + " / " + itemCount.ToString();
            if (score >= itemCount)
            {
                audioSource.PlayOneShot(winSound);
                StartCoroutine(NextLevel());
            }
            else
            {
                audioSource.PlayOneShot(pickSound);
            }
        }
    }
    IEnumerator NextLevel()
    {
        yield return new WaitForSeconds(3);
        if(SceneManager.Equals(SceneManager.GetActiveScene(),SceneManager.GetSceneByName("Level1")))
        {
            SceneManager.LoadScene("Level2");
        }else if(SceneManager.Equals(SceneManager.GetActiveScene(), SceneManager.GetSceneByName("Level2")))
        {
            SceneManager.LoadScene("Level3");
        }
    }
}
