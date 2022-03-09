using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BodyPart : MonoBehaviour
{
    public Image iconBrain;
    public Image iconHeart;

    // Start is called before the first frame update
    void Start()
    {
        iconBrain.color = new Color(1, 1, 1, 0.3f);
        iconHeart.color = new Color(1, 1, 1, 0.3f);
    }

    // Update is called once per frame

    void Update()
    {
        
    }

    public void OnBrainFound()
    {
        iconBrain.color = new Color(1, 1, 1, 1);
    }

    public void OnHeartFound()
    {
        iconHeart.color = new Color(1, 1, 1, 1);
    }
}
