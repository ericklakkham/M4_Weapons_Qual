using System.Collections;
using System.Collections.Generic;
using Palmmedia.ReportGenerator.Core.Parser.Analysis;
using TMPro;
using UnityEditor.TestTools.CodeCoverage;
using UnityEngine;
using UnityEngine.UI;

public class Begin : MonoBehaviour
{
    public GameObject eTypeTarget;
    public GameObject fTypeTarget;

    public Transform target50MLeft;
    public Transform target50MRight;
    public Transform target100M;
    public Transform target150M;
    public Transform target200M;
    public Transform target250M;
    public Transform target300M;

    public Text display;

    bool sessionInProgress = false;
    GameObject [] target;
    Coroutine session;
    
    void Update()
    {
        if (Input.GetKeyUp (KeyCode.R) && !sessionInProgress)
        {
            session = StartCoroutine (StartSession ());
        }

        if (Input.GetKeyUp (KeyCode.C))
        {
            StopCoroutine (session);

            foreach (GameObject t in target)
            {
                Destroy (t);
            }

            sessionInProgress = false;
            display.text = string.Empty;
        }
    }

    IEnumerator StartSession ()
    {
        sessionInProgress = true;

        target = new GameObject [40];

        //Prepare
        for (int i = 5; i >= 1; i --)
        {
            display.text = i.ToString ();
            yield return new WaitForSeconds (1);
        }

        //Standing, Unsupported
        //Engagement 1
        display.text = "Standing, Unsupported";
        target [0] = Instantiate (fTypeTarget, target50MRight);
        yield return new WaitForSeconds (5);
        Destroy (target [0]);

        display.text = "Switch to Prone, Unsupported";
        yield return new WaitForSeconds (5);

        //Prone, Unsupported
        //Engagement 2
        display.text = "Prone, Unsupported";
        target [1] = Instantiate (eTypeTarget, target100M);
        yield return new WaitForSeconds (5);
        Destroy (target [1]);

        yield return new WaitForSeconds (3);

        //Engagement 3
        target [2] = Instantiate (eTypeTarget, target150M);
        yield return new WaitForSeconds (5);
        Destroy (target [2]);

        yield return new WaitForSeconds (3);

        //Engagement 4
        target [3] = Instantiate (eTypeTarget, target50MLeft);
        target [4] = Instantiate (eTypeTarget, target150M);
        target [5] = Instantiate (eTypeTarget, target200M);
        yield return new WaitForSeconds (12);
        Destroy (target [3]);
        Destroy (target [4]);
        Destroy (target [5]);

        yield return new WaitForSeconds (3);

        //Engagement 5
        target [6] = Instantiate (eTypeTarget, target150M);
        target [7] = Instantiate (eTypeTarget, target200M);
        target [8] = Instantiate (eTypeTarget, target250M);
        target [9] = Instantiate (eTypeTarget, target300M);
        yield return new WaitForSeconds (16);
        Destroy (target [6]);
        Destroy (target [7]);
        Destroy (target [8]);
        Destroy (target [9]);

        display.text = "Switch to Prone, Supported";
        yield return new WaitForSeconds (10);

        //Prone, Supported
        //Engagement 6
        display.text = "Prone, Supported";
        target [10] = Instantiate (eTypeTarget, target100M);
        yield return new WaitForSeconds (5);
        Destroy (target [10]);

        yield return new WaitForSeconds (3);

        //Engagement 7
        target [11] = Instantiate (eTypeTarget, target150M);
        target [12] = Instantiate (eTypeTarget, target300M);
        yield return new WaitForSeconds (8);
        Destroy (target [11]);
        Destroy (target [12]);

        yield return new WaitForSeconds (3);

        //Engagement 8
        target [13] = Instantiate (eTypeTarget, target200M);
        target [14] = Instantiate (eTypeTarget, target300M);
        yield return new WaitForSeconds (8);
        Destroy (target [13]);
        Destroy (target [14]);

        yield return new WaitForSeconds (3);

        //Engagement 9
        target [15] = Instantiate (eTypeTarget, target250M);
        target [16] = Instantiate (eTypeTarget, target300M);
        yield return new WaitForSeconds (8);
        Destroy (target [15]);
        Destroy (target [16]);

        yield return new WaitForSeconds (3);
        
        //Engagement 10
        target [17] = Instantiate (eTypeTarget, target150M);
        target [18] = Instantiate (eTypeTarget, target250M);
        target [19] = Instantiate (eTypeTarget, target300M);
        yield return new WaitForSeconds (12);
        Destroy (target [17]);
        Destroy (target [18]);
        Destroy (target [19]);

        display.text = "Switch to Kneeling, Supported";
        yield return new WaitForSeconds (10);
        
        //Kneeling, Supported
        //Engagement 11
        display.text = "Kneeling, Supported";
        target [20] = Instantiate (eTypeTarget, target50MLeft);
        target [21] = Instantiate (eTypeTarget, target100M);
        target [22] = Instantiate (eTypeTarget, target200M);
        yield return new WaitForSeconds (12);
        Destroy (target [20]);
        Destroy (target [21]);
        Destroy (target [22]);

        yield return new WaitForSeconds (3);
        
        //Engagement 12
        target [23] = Instantiate (fTypeTarget, target50MRight);
        target [24] = Instantiate (eTypeTarget, target200M);
        yield return new WaitForSeconds (8);
        Destroy (target [23]);
        Destroy (target [24]);

        yield return new WaitForSeconds (3);
        
        //Engagement 13
        target [25] = Instantiate (eTypeTarget, target150M);
        target [26] = Instantiate (eTypeTarget, target250M);
        yield return new WaitForSeconds (8);
        Destroy (target [25]);
        Destroy (target [26]);

        yield return new WaitForSeconds (3);

        //Engagement 14
        target [27] = Instantiate (eTypeTarget, target100M);
        target [28] = Instantiate (eTypeTarget, target150M);
        target [29] = Instantiate (eTypeTarget, target200M);
        yield return new WaitForSeconds (12);
        Destroy (target [27]);
        Destroy (target [28]);
        Destroy (target [29]);

        display.text = "Switch to Standing, Supported";
        yield return new WaitForSeconds (10);

        //Standing, Supported
        //Engagement 15
        display.text = "Standing, Supported";
        target [30] = Instantiate (eTypeTarget, target50MLeft);
        target [31] = Instantiate (eTypeTarget, target100M);
        yield return new WaitForSeconds (8);
        Destroy (target [30]);
        Destroy (target [31]);

        yield return new WaitForSeconds (3);

        //Engagement 16
        target [32] = Instantiate (eTypeTarget, target200M);
        target [33] = Instantiate (eTypeTarget, target250M);
        yield return new WaitForSeconds (8);
        Destroy (target [32]);
        Destroy (target [33]);

        yield return new WaitForSeconds (3);

        //Engagement 17
        target [34] = Instantiate (fTypeTarget, target50MRight);
        target [35] = Instantiate (eTypeTarget, target100M);
        target [36] = Instantiate (eTypeTarget, target150M);
        yield return new WaitForSeconds (12);
        Destroy (target [34]);
        Destroy (target [35]);
        Destroy (target [36]);

        yield return new WaitForSeconds (3);

        //Engagement 18
        target [37] = Instantiate (eTypeTarget, target100M);
        target [38] = Instantiate (eTypeTarget, target200M);
        target [39] = Instantiate (eTypeTarget, target250M);
        yield return new WaitForSeconds (12);
        Destroy (target [37]);
        Destroy (target [38]);
        Destroy (target [39]);

        display.text = string.Empty;

        sessionInProgress = false;
    }
}
