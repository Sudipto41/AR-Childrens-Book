/*==============================================================================
Copyright (c) 2017 PTC Inc. All Rights Reserved.

Copyright (c) 2010-2014 Qualcomm Connected Experiences, Inc.
All Rights Reserved.
Confidential and Proprietary - Protected under copyright and other laws.
==============================================================================*/

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Vuforia;



/// <summary>
/// A custom handler that implements the ITrackableEventHandler interface.
///
/// Changes made to this file could be overwritten when upgrading the Vuforia version.
/// When implementing custom event handler behavior, consider inheriting from this class instead.
/// </summary>
public class DefaultTrackableEventHandler : MonoBehaviour, ITrackableEventHandler
{
    #region PROTECTED_MEMBER_VARIABLES

    protected TrackableBehaviour mTrackableBehaviour;
    protected TrackableBehaviour.Status m_PreviousStatus;
    protected TrackableBehaviour.Status m_NewStatus;


    
   
    public GameObject a;
    public GameObject b;
    public GameObject c;
    public GameObject d;
    public GameObject e;
    public GameObject f;
    public GameObject g;
    public GameObject h;
    public GameObject i;
    public GameObject j;
    public GameObject k;
    public GameObject l;
    public GameObject m;
    public GameObject n;
    public GameObject o;
    public GameObject p;
    public GameObject q;
    public GameObject r;
    public GameObject s;
    public GameObject t;
    public GameObject u;
    public GameObject v;
    public GameObject w;
    public GameObject x;
    public GameObject y;
    public GameObject z;
    public GameObject Bangla1;
    public GameObject Bangla2;
    public GameObject Bangla3;
    public GameObject Bangla4;
    public GameObject Bangla5;
    public GameObject Bangla6;
    public GameObject Bangla7;
    public GameObject Bangla8;
    public GameObject Bangla9;
    public GameObject Bangla10;
    public GameObject Bangla11;
    public GameObject Bangla12;
    public GameObject Bangla13;
    public GameObject Bangla14;
    public GameObject Bangla15;
    public GameObject Bangla16;
    public GameObject Bangla17;
    public GameObject Bangla18;
    public GameObject Bangla19;
    public GameObject Bangla20;
    public GameObject Bangla21;
    public GameObject Bangla22;
    public GameObject Bangla23;
    public GameObject Bangla24;
    public GameObject Bangla25;
    public GameObject Bangla26;
    public GameObject Bangla27;
    public GameObject Bangla28;
    public GameObject Bangla29;
    public GameObject Bangla30;
    public GameObject Bangla31;
    public GameObject Bangla32;
    public GameObject Bangla33;
    public GameObject Bangla34;
    public GameObject Bangla35;
    public GameObject Bangla36;
    public GameObject Bangla37;
    public GameObject Bangla38;
    public GameObject Bangla39;
    public GameObject Bangla40;
    public GameObject Bangla41;
    public GameObject Bangla42;
    public GameObject Bangla43;
    public GameObject Bangla44;
    public GameObject Bangla45;
    public GameObject Bangla46;
    public GameObject Bangla47;
    public GameObject Bangla48;
    public GameObject Bangla49;
    public GameObject Bangla50;
    public GameObject Apple;
    public GameObject f2;
    public GameObject strawberry;
    public GameObject Banana;
    public GameObject Orange;

    public GameObject AppleEng;
    public GameObject f2Eng;
    public GameObject strawberryEng;
    public GameObject BananaEng;
    public GameObject OrangeEng;




    public Scene CurrentScene;


    #endregion // PROTECTED_MEMBER_VARIABLES

    #region UNITY_MONOBEHAVIOUR_METHODS


    void Awake()
    {
        a = GameObject.Find("A");
        b = GameObject.Find("B");
        c = GameObject.Find("C");
        d = GameObject.Find("D");
        e = GameObject.Find("E");
        f = GameObject.Find("F");
        g = GameObject.Find("G");
        h = GameObject.Find("H");
        i = GameObject.Find("I");
        j = GameObject.Find("J");
        k = GameObject.Find("K");
        l = GameObject.Find("L");
        m = GameObject.Find("M");
        n = GameObject.Find("N");
        o = GameObject.Find("O");
        p = GameObject.Find("P");
        q = GameObject.Find("Q");
        r = GameObject.Find("R");
        s = GameObject.Find("S");
        t = GameObject.Find("T");
        u = GameObject.Find("U");
        v = GameObject.Find("V");
        w = GameObject.Find("W");
        x = GameObject.Find("X");
        y = GameObject.Find("Y");
        z = GameObject.Find("Z");
        Bangla1 = GameObject.Find("1");
        Bangla2 = GameObject.Find("2");
        Bangla3 = GameObject.Find("3");
        Bangla4 = GameObject.Find("4");
        Bangla5 = GameObject.Find("5");
        Bangla6 = GameObject.Find("6");
        Bangla7 = GameObject.Find("7");
        Bangla8 = GameObject.Find("8");
        Bangla9 = GameObject.Find("9");
        Bangla10 = GameObject.Find("10");
        Bangla11 = GameObject.Find("11");
        Bangla12 = GameObject.Find("b1");
        Bangla13 = GameObject.Find("b2");
        Bangla14 = GameObject.Find("b3");
        Bangla15 = GameObject.Find("b4");
        Bangla16 = GameObject.Find("b5");
        Bangla17 = GameObject.Find("b6");
        Bangla18 = GameObject.Find("b7");
        Bangla19 = GameObject.Find("b8");
        Bangla20 = GameObject.Find("b9");
        Bangla21 = GameObject.Find("b10");
        Bangla22 = GameObject.Find("b11");
        Bangla23 = GameObject.Find("b12");
        Bangla24 = GameObject.Find("b13");
        Bangla25 = GameObject.Find("b14");
        Bangla26 = GameObject.Find("b15");
        Bangla27 = GameObject.Find("b16");
        Bangla28 = GameObject.Find("b17");
        Bangla29 = GameObject.Find("b18");
        Bangla30 = GameObject.Find("b19");
        Bangla31 = GameObject.Find("b20");
        Bangla32 = GameObject.Find("b21");
        Bangla33 = GameObject.Find("b22");
        Bangla34 = GameObject.Find("b23");
        Bangla35 = GameObject.Find("b24");
        Bangla36 = GameObject.Find("b25");
        Bangla37 = GameObject.Find("b26");
        Bangla38 = GameObject.Find("b27");
        Bangla39 = GameObject.Find("b28");
        Bangla40 = GameObject.Find("b29");
        Bangla41 = GameObject.Find("b30");
        Bangla42 = GameObject.Find("b31");
        Bangla43 = GameObject.Find("b32");
        Bangla44 = GameObject.Find("b33");
        Bangla45 = GameObject.Find("b34");
        Bangla46 = GameObject.Find("b35");
        Bangla47 = GameObject.Find("b36");
        Bangla48 = GameObject.Find("b37");
        Bangla49 = GameObject.Find("b38");
        Bangla50 = GameObject.Find("b39");
        Apple = GameObject.Find("Apple");
        Orange = GameObject.Find("Orange");
        strawberry = GameObject.Find("strawberry");
        Banana = GameObject.Find("Banana");
        f2 = GameObject.Find("mango");
        AppleEng = GameObject.Find("Apple");
        OrangeEng = GameObject.Find("Orange");
        strawberryEng = GameObject.Find("strawberry");
        BananaEng = GameObject.Find("Banana");
        f2Eng = GameObject.Find("mango");





    }
    void Update() {

        CurrentScene = SceneManager.GetActiveScene();


    }

    protected virtual void Start()
    {
       


        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
    }

    protected virtual void OnDestroy()
    {
        if (mTrackableBehaviour)
            mTrackableBehaviour.UnregisterTrackableEventHandler(this);
    }

    #endregion // UNITY_MONOBEHAVIOUR_METHODS

    #region PUBLIC_METHODS

    /// <summary>
    ///     Implementation of the ITrackableEventHandler function called when the
    ///     tracking state changes.
    /// </summary>
    public void OnTrackableStateChanged(
        TrackableBehaviour.Status previousStatus,
        TrackableBehaviour.Status newStatus)
    {
        m_PreviousStatus = previousStatus;
        m_NewStatus = newStatus;

        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " found");
            OnTrackingFound();
            
        }
        else if (previousStatus == TrackableBehaviour.Status.TRACKED &&
                 newStatus == TrackableBehaviour.Status.NO_POSE)
        {
            Debug.Log("Trackable " + mTrackableBehaviour.TrackableName + " lost");
            OnTrackingLost();
            
             }
        else
        {
            // For combo of previousStatus=UNKNOWN + newStatus=UNKNOWN|NOT_FOUND
            // Vuforia is starting, but tracking has not been lost or found yet
            // Call OnTrackingLost() to hide the augmentations
            OnTrackingLost();
        }
    }

    #endregion // PUBLIC_METHODS

    #region PROTECTED_METHODS

    protected virtual void OnTrackingFound()
    {
        var rendererComponents = GetComponentsInChildren<Renderer>(true);
        var colliderComponents = GetComponentsInChildren<Collider>(true);
        var canvasComponents = GetComponentsInChildren<Canvas>(true);

        // Enable rendering:
        foreach (var component in rendererComponents)
            component.enabled = true;

        // Enable colliders:
        foreach (var component in colliderComponents)
            component.enabled = true;

        // Enable canvas':
        foreach (var component in canvasComponents)
            component.enabled = true;

        

        if (mTrackableBehaviour.Trackable.Name == "A-001")
        {
            a.GetComponent<AudioSource>().Play ();
        }
        if (mTrackableBehaviour.Trackable.Name == "B-001")
        {
            b.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "C-002")
        {
            c.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "D1-001")
        {
            d.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "E-001")
        {
            e.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "F1-001")
        {
            f.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "G-001")
        {
            g.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "H-001")
        {
            h.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "I-001")
        {
            i.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "J-001")
        {
            j.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "K-001")
        {
            k.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "L-001")
        {
            l.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "M-001")
        {
            m.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "N-002")
        {
            n.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "O1-001")
        {
            o.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "P-001")
        {
            p.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "Q-001")
        {
            q.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "R-001")
        {
            r.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "S-001")
        {
            s.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "T-001")
        {
            t.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "U-001")
        {
            u.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "V1-001")
        {
            v.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "W-001")
        {
            w.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "X1-001")
        {
            x.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "Y1-001")
        {
            y.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "Z-001")
        {
            z.GetComponent<AudioSource>().Play();
        }

        if (mTrackableBehaviour.Trackable.Name == "A-1")
        {
            Bangla1.GetComponent<AudioSource>().Play();
        }

        if (mTrackableBehaviour.Trackable.Name == "A-2")
        {
            Bangla2.GetComponent<AudioSource>().Play();
        }
        
        if (mTrackableBehaviour.Trackable.Name == "A-3")
        {
            Bangla3.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "A-4")
        {
            Bangla4.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "A-5")
        {
            Bangla5.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "A-6")
        {
            Bangla6.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "A-7")
        {
            Bangla7.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "A-8")
        {
            Bangla8.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "A-9")
        {
            Bangla9.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "A-10")
        {
            Bangla10.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "A-11")
        {
            Bangla11.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "B-1")
        {
            Bangla12.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "B-2")
        {
            Bangla13.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "B-3")
        {
            Bangla14.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "B-4")
        {
            Bangla15.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "B-5")
        {
            Bangla16.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "B-6")
        {
            Bangla17.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "B-7")
        {
            Bangla18.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "B-8")
        {
            Bangla19.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "B-9")
        {
            Bangla20.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "B-10")
        {
            Bangla21.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "B-11")
        {
            Bangla22.GetComponent<AudioSource>().Play();
        }

    
        if (mTrackableBehaviour.Trackable.Name == "B-12")
        {
            Bangla23.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "B-13")
        {
            Bangla24.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "B-14")
        {
            Bangla25.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "B-15")
        {
            Bangla26.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "B-16")
        {
            Bangla27.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "B-17")
        {
            Bangla28.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "B-18")
        {
            Bangla29.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "B-19")
        {
            Bangla30.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "B-20")
        {
            Bangla31.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "B-21")
        {
            Bangla32.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "B-22")
        {
            Bangla33.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "B-23")
        {
            Bangla34.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "B-24")
        {
            Bangla35.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "B-25")
        {
            Bangla36.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "B-26")
        {
            Bangla37.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "B-27")
        {
            Bangla38.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "B-28")
        {
            Bangla39.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "B-29")
        {
            Bangla40.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "B-30")
        {
            Bangla41.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "B-31")
        {
            Bangla42.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "B-32")
        {
            Bangla43.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "B-33")
        {
            Bangla44.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "B-34")
        {
            Bangla45.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "B-35")
        {
            Bangla46.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "B-36")
        {
            Bangla47.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "B-37")
        {
            Bangla48.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "B-38")
        {
            Bangla49.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "B-39")
        {
            Bangla50.GetComponent<AudioSource>().Play();
        }



        if (mTrackableBehaviour.Trackable.Name == "f1")
        {
            strawberry.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "f2")
        {
            Banana.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "f3")
        {
            Orange.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "f4")
        {
            f2.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "f5")
        {
           Apple.GetComponent<AudioSource>().Play();
        }

        if (mTrackableBehaviour.Trackable.Name == "f1")
        {
            strawberryEng.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "f2")
        {
            BananaEng.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "f3")
        {
            OrangeEng.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "f4")
        {
            f2Eng.GetComponent<AudioSource>().Play();
        }
        if (mTrackableBehaviour.Trackable.Name == "f5")
        {
            AppleEng.GetComponent<AudioSource>().Play();
        }








    }

   

    protected virtual void OnTrackingLost()
    {
        var rendererComponents = GetComponentsInChildren<Renderer>(true);
        var colliderComponents = GetComponentsInChildren<Collider>(true);
        var canvasComponents = GetComponentsInChildren<Canvas>(true);

        // Disable rendering:
        foreach (var component in rendererComponents)
            component.enabled = false;

        // Disable colliders:
        foreach (var component in colliderComponents)
            component.enabled = false;

        // Disable canvas':
        foreach (var component in canvasComponents)
            component.enabled = false;

        if (CurrentScene.name == "EnglishAlpha")
        {
            a.GetComponent<AudioSource>().Stop();
            b.GetComponent<AudioSource>().Stop();
            c.GetComponent<AudioSource>().Stop();
            d.GetComponent<AudioSource>().Stop();
            e.GetComponent<AudioSource>().Stop();
            f.GetComponent<AudioSource>().Stop();
            g.GetComponent<AudioSource>().Stop();
            h.GetComponent<AudioSource>().Stop();
            i.GetComponent<AudioSource>().Stop();
            j.GetComponent<AudioSource>().Stop();
            k.GetComponent<AudioSource>().Stop();
            l.GetComponent<AudioSource>().Stop();
            m.GetComponent<AudioSource>().Stop();
            n.GetComponent<AudioSource>().Stop();
            o.GetComponent<AudioSource>().Stop();
            p.GetComponent<AudioSource>().Stop();
            q.GetComponent<AudioSource>().Stop();
            r.GetComponent<AudioSource>().Stop();
            s.GetComponent<AudioSource>().Stop();
            t.GetComponent<AudioSource>().Stop();
            u.GetComponent<AudioSource>().Stop();
            v.GetComponent<AudioSource>().Stop();
            w.GetComponent<AudioSource>().Stop();
            x.GetComponent<AudioSource>().Stop();
            y.GetComponent<AudioSource>().Stop();
            z.GetComponent<AudioSource>().Stop();
        }
        if (CurrentScene.name == "BanglaAlpha")
        {
            Bangla1.GetComponent<AudioSource>().Stop();
            Bangla1.GetComponent<AudioSource>().Stop();
            Bangla2.GetComponent<AudioSource>().Stop();
            Bangla3.GetComponent<AudioSource>().Stop();
            Bangla4.GetComponent<AudioSource>().Stop();
            Bangla5.GetComponent<AudioSource>().Stop();
            Bangla6.GetComponent<AudioSource>().Stop();
            Bangla7.GetComponent<AudioSource>().Stop();
            Bangla8.GetComponent<AudioSource>().Stop();
            Bangla9.GetComponent<AudioSource>().Stop();
            Bangla10.GetComponent<AudioSource>().Stop();
            Bangla11.GetComponent<AudioSource>().Stop();
            Bangla12.GetComponent<AudioSource>().Stop();
            Bangla13.GetComponent<AudioSource>().Stop();
            Bangla14.GetComponent<AudioSource>().Stop();
            Bangla15.GetComponent<AudioSource>().Stop();
            Bangla16.GetComponent<AudioSource>().Stop();
            Bangla17.GetComponent<AudioSource>().Stop();
            Bangla18.GetComponent<AudioSource>().Stop();
            Bangla19.GetComponent<AudioSource>().Stop();
            Bangla20.GetComponent<AudioSource>().Stop();
            Bangla21.GetComponent<AudioSource>().Stop();
            Bangla22.GetComponent<AudioSource>().Stop();
            Bangla23.GetComponent<AudioSource>().Stop();
            Bangla24.GetComponent<AudioSource>().Stop();
            Bangla25.GetComponent<AudioSource>().Stop();
            Bangla26.GetComponent<AudioSource>().Stop();
            Bangla27.GetComponent<AudioSource>().Stop();
            Bangla28.GetComponent<AudioSource>().Stop();
            Bangla29.GetComponent<AudioSource>().Stop();
            Bangla30.GetComponent<AudioSource>().Stop();
            Bangla31.GetComponent<AudioSource>().Stop();
            Bangla32.GetComponent<AudioSource>().Stop();
            Bangla33.GetComponent<AudioSource>().Stop();
            Bangla34.GetComponent<AudioSource>().Stop();
            Bangla35.GetComponent<AudioSource>().Stop();
            Bangla36.GetComponent<AudioSource>().Stop();
            Bangla37.GetComponent<AudioSource>().Stop();
            Bangla38.GetComponent<AudioSource>().Stop();
            Bangla39.GetComponent<AudioSource>().Stop();
            Bangla40.GetComponent<AudioSource>().Stop();
            Bangla41.GetComponent<AudioSource>().Stop();
            Bangla42.GetComponent<AudioSource>().Stop();
            Bangla43.GetComponent<AudioSource>().Stop();
            Bangla44.GetComponent<AudioSource>().Stop();
            Bangla45.GetComponent<AudioSource>().Stop();
            Bangla46.GetComponent<AudioSource>().Stop();
            Bangla47.GetComponent<AudioSource>().Stop();
            Bangla48.GetComponent<AudioSource>().Stop();
            Bangla49.GetComponent<AudioSource>().Stop();
            Bangla50.GetComponent<AudioSource>().Stop();
        }
        if (CurrentScene.name == "BanglaFruit")
        {
            strawberry.GetComponent<AudioSource>().Stop();
            f2.GetComponent<AudioSource>().Pause();
            Apple.GetComponent<AudioSource>().Stop();
            Orange.GetComponent<AudioSource>().Stop();
            Banana.GetComponent<AudioSource>().Stop();
        }
        if (CurrentScene.name == "EnglishFruit")
        {
            strawberryEng.GetComponent<AudioSource>().Stop();
            f2Eng.GetComponent<AudioSource>().Pause();
            AppleEng.GetComponent<AudioSource>().Stop();
            OrangeEng.GetComponent<AudioSource>().Stop();
            BananaEng.GetComponent<AudioSource>().Stop();
        }





    }

    #endregion // PROTECTED_METHODS
}
