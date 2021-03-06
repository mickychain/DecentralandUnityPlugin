﻿using System;
using UnityEngine;
using System.Collections.Generic;

namespace Dcl
{
    [ExecuteInEditMode]
    public class DclSceneMeta : MonoBehaviour
    {
        [SerializeField]
        [HideInInspector]
        public List<ParcelCoordinates> parcels = new List<ParcelCoordinates>
    {
        new ParcelCoordinates(30, -15),
        new ParcelCoordinates(30, -16),
    };

        [SerializeField] [HideInInspector] public string exportPath;
        [SerializeField] [HideInInspector] public string ethAddress;
        [SerializeField] [HideInInspector] public string contactName;
        [SerializeField] [HideInInspector] public string email;

        public SceneToGlTFWiz sceneToGlTFWiz;

        private void Awake()
        {
            sceneToGlTFWiz = GetComponent<SceneToGlTFWiz>();
            if (!sceneToGlTFWiz) sceneToGlTFWiz = gameObject.AddComponent<SceneToGlTFWiz>();
        }

        private float nextTimeRefreshWarning = 0;
        private void Update()
        {
            if (Time.time > nextTimeRefreshWarning)
            {

                nextTimeRefreshWarning = Time.time + 2;
            }
        }

        void OnDrawGizmos()
        {
            if (parcels.Count > 0)
            {
                var baseParcel = parcels[0];
                //            Gizmos.color = new Color(0.7, 0);
                foreach (var parcel in parcels)
                {
                    var pos = new Vector3((parcel.x - baseParcel.x) * 10, 0, (parcel.y - baseParcel.y) * 10);
                    Gizmos.DrawCube(pos, new Vector3(10, 0f, 10));
                }
            }
        }


    }

    [Serializable]
    public struct ParcelCoordinates
    {
        public ParcelCoordinates(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int x;
        public int y;
    }

    public class SceneStatistics
    {
        public long triangleCount;
        public int entityCount;
        public int bodyCount;
        public float maxHeight;
    }
}