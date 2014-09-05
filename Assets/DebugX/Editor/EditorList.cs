using UnityEditor;
using UnityEngine;

namespace DebugX {
	public static class EditorCollection {
		public static void Show (SerializedProperty collection) {
			//EditorGUILayout.PropertyField(collection);
		
			//if (collection.isExpanded) {
				SerializedProperty collectionList = collection.FindPropertyRelative("list");
				SerializedProperty collectionSize = collectionList.FindPropertyRelative("Array.size");
				EditorGUILayout.PropertyField(collectionSize);
				for (int i = 0; i < collectionList.arraySize; i++) {
					EditorGUI.indentLevel += 1;
					SerializedProperty group = collectionList.GetArrayElementAtIndex(i);
					SerializedProperty groupList = group.FindPropertyRelative("list");
					SerializedProperty groupName = group.FindPropertyRelative("name");
					SerializedProperty groupSize = groupList.FindPropertyRelative("Array.size");
					SerializedProperty groupEnabled = group.FindPropertyRelative("enabled");
					
					groupList.isExpanded = EditorGUILayout.Foldout(groupList.isExpanded, (groupName.stringValue == "") ? "groupname" : groupName.stringValue);
					if (groupList.isExpanded) {
						EditorGUILayout.Space();
					}
					EditorGUI.indentLevel -= 1;
				}
			//}
		}
	}
}