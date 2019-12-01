using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Color2 : MonoBehaviour
{ public GameObject NextColor;

    public GameObject pLost;
    public string nextScene;
    public GameObject colBlock;
    public GameObject mainblock;
    public Vector3[] positions;
    private GameObject block;
    private GameObject[] blocks = new GameObject[4];

    private int rand, count;
    [HideInInspector]
    public bool next, lose;
    // Use this for initialization
    void Start()
    {
        next = false;
        lose = false;
        rand = Random.Range(0, positions.Length);
        for (int i = 0; i < positions.Length; i++)
        {
            blocks[i] = Instantiate(colBlock, positions[i], Quaternion.identity) as GameObject;
            if (rand == i)
                block = blocks[i];
        }

         SetColorToOneBlockFromComponentTextColorAndSetRandomColorToOther();
    }
    private void Awake()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (lose)
            pLost.SetActive(true);
        if (next && !lose)
            NextColor.SetActive(true);

    }
    void SetColorToOneBlockFromComponentTextColorAndSetRandomColorToOther()
    {
        GameObject targetBlock = blocks[Random.Range(0, blocks.Length)];

        Text myText = GetComponent<Text>();
        Renderer targetRenderer = targetBlock.GetComponent<Renderer>();



        foreach (var block in blocks)
        {
            if (block == targetBlock) continue;

            // Color color = new Color(Random.value, Random.value, Random.value);
            float h = Random.value;
            float s = 1f;
            float v = 1f;   
            block.GetComponent<Renderer>().material.color = Color.HSVToRGB(h, s, v);
        }
        
        
    }
  
}
