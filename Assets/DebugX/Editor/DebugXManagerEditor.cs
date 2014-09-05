using UnityEngine;
using UnityEditor;
using System.Collections;
using DebugX.Elements;

namespace DebugX {
	[CustomEditor(typeof(DebugXManager))]
	[CanEditMultipleObjects]
	public class DebugXManagerEditor : Editor {
		private int size;
		//private GameObject gameObject;

		public override void OnInspectorGUI () {
			//gameObject = Selection.activeGameObject;

			serializedObject.Update();
			// Debug.Log(collection);
			// size = EditorGUILayout.IntField("Size", size);
			// collection.list = new Group[size];

			SerializedProperty collectionSerial = serializedObject.FindProperty("collection");
			SerializedProperty collectionSize = collectionSerial.FindPropertyRelative("size");
			SerializedProperty collectionList = collectionSerial.FindPropertyRelative("list");
			//target.ElementsSize = 

			EditorCollection.Show(collectionSerial);

			/*for (int i = 0; i < collectionList.arraySize; i++) {
				SerializedProperty groupSerial =  collectionList.GetArrayElementAtIndex(i);
				SerializedProperty groupName = groupSerial.FindPropertyRelative("name");
				SerializedProperty groupSize = groupSerial.FindPropertyRelative("size");
				SerializedProperty groupList = groupSerial.FindPropertyRelative("list");

				EditorGUILayout.PropertyField(groupName);
				EditorGUILayout.PropertyField(groupSize);

				for (int j = 0; j < groupSerial.arraySize; j++) {
					SerializedProperty debugSerial =  groupList.GetArrayElementAtIndex(j);
					SerializedProperty debugName = debugSerial.FindPropertyRelative("name");
					SerializedProperty debugValue = debugSerial.FindPropertyRelative("intValue");

					EditorGUILayout.PropertyField(debugName);
				}
			}*/

			//EditorGUILayout.PropertyField(collectionSerial, true);

			serializedObject.ApplyModifiedProperties();
		}
	}
}