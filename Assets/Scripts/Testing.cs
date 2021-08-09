using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class Testing : MonoBehaviour {

    private Grid<bool> grid;

    private void Start() {
        grid = new Grid<bool>(20, 10, 8f, new Vector3(-50, -40));
    }

    private void Update() {
        //if (Input.GetMouseButtonDown(0)) {
        //    Vector3 position = UtilsClass.GetMouseWorldPosition();
        //    grid.AddValue(position, 100, 2, 15);
        //}
    }
}
