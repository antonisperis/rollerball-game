/**
 * Author: Steve Kateros
 * 
 * Sumvoules: Tha ta katafere ;)
 **/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HY150ExampleScript : MonoBehaviour {

    // Edw Dilwste oles tis metavlites sas
    // An oi metavlites einai global tote tha emfanizontai kai ston editor sas (pithanws sti deksia stili)
    private int variableOne;
    public float variableTwo;

    /// <summary>
    /// Edw tha arxikopoieitai tis metavlites sas. Auti i sunartisei kaleitai apo tin Unity
    /// automata mia fora mono stin arxi tou Game sas (me to pou patisete play)
    /// </summary>
	void Start () {
        variableOne = 0;
        variableTwo = 2.4f;	
	}

    /// <summary>
    /// Auti i sunartisi kaleite sunexeia apo tin Unity se kathe Frame tou Game sas
    /// </summary>
    void Update () {
        // Gia na anagnwrisete pote patithike ena koumpi apo to Script sas, xreiazeste to parakatw kwdika:
        // (Gia na deite poia koumpia einai diathesima aplws otan grapsete to keyword tis Unity "KeyCode"
        // k patisete meta teleia "." tha sas vgoun sto Visual Studio ta diathesima koumpia)
        if (Input.GetKeyDown(KeyCode.Return))
            print("Patithike to Enter toses fores ws twra: " + (++variableOne));

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Se opoio simeio tou kwdika sas xreiazeste na kleisete tin efaromogi sas xrisimopoiiste auto
            // to kwdika (tis parakatw 5 grammes)
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
        }

        // Gia na metakineite to antikeimeno stin skini
        transform.Translate(0.2f, 0, 0.1f); // Me tin seira emfanisis oi aksones X, Y, Z

        // Gia na peristrefete to antikeimeno stin skini
        transform.Rotate(0, 5f, 0); // Me tin seira emfanisis oi aksones X, Y, Z
    }

    /// <summary>
    /// Auti i sunartisi kaleitai apo tin Unity otan sto antikeimeno sas exete
    /// Collider (Box Collider, Capsule Collider, Sphere Collider) ston opoio isxuei
    /// i "maza" tou antikeimenou diladi Den exete epilegmeno to: "Is Triggered"
    /// 
    /// Tha kalestei i sunartisi otan to antikeimeno sto opoio exoume valei to script auto
    /// tha erthei se epafi me ena allo antikeimeno
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter(Collision collision)
    {
        // Gia na vreite to onoma tou antikeimenou pou sugkroustike me auto edw to sugkekrimeno
        // I print ektupwnei sto Console tis Unity (deite to pdf gia to pou einai to Console)
        print(collision.gameObject.name);
        
        Debug.Log("Enallaktikos tropos gia print sto Console tis Unity");
    }

    /// <summary>
    /// Auti i sunartisi kaleitai apo tin Unity otan sto antikeimeno sas exete
    /// Collider (Box Collider, Capsule Collider, Sphere Collider) ston opoio Den isxuei
    /// i "maza" tou antikeimenou diladi exete epilegmeno to: "Is Triggered"
    /// 
    /// Tha kalestei i sunartisi otan to antikeimeno sto opoio exoume valei to script auto
    /// tha erthei se epafi me ena allo antikeimeno (an to exete ulopoiisei swsta to antikeimeno
    /// tha perasei apo mesa tou san na itan "fantasma")
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name);

        // Gia na katastrepsete ena antikeimeno
        // Sti sugkekrimeni periptwsi katastrefoume to antikeimeno pou exei panw tou to script auto
        Destroy(this.gameObject);
    }
}
