using UnityEngine;
using System.Collections;

public enum AgeType { Infant, Child, Adult, Senior};

public class Person : MonoBehaviour {

    public int money;
    public int age;
    public AgeType ageType;

    //temp to test simulation
    public int incomePerMonth;
    

	// Use this for initialization
	void Start (AgeType ageType) {
        this.ageType = ageType;

        switch (ageType) {
            case AgeType.Infant: {
                    incomePerMonth = 0;
                    break;
                }
            case AgeType.Child: {
                    incomePerMonth = 20;
                    break;
                }
            case AgeType.Adult: {
                    incomePerMonth = 5000;
                    break;
                }
            case AgeType.Senior: {
                    incomePerMonth = 500;
                    break;
                }
            default: {
                    throw new System.Exception("Person has no specified Age Type!");
                }
        }
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
