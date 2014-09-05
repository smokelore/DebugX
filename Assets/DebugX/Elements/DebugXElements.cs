using UnityEngine;
using System.Collections;

namespace DebugX.Elements {
	[System.Serializable]
	public class DebugValue {
		[SerializeField]
		public string name = "debugvalue name";
		[SerializeField]
		public bool enabled;
		[SerializeField]
		public int intValue;

		public DebugValue(string name, int intValue) {
			this.name = name;
			this.intValue = intValue;
		}
	}

	[System.Serializable]
	public class Group {
		[SerializeField]
		public string name = "group name";
		[SerializeField]
		public int size { 
			get
			{
				return list.Length;
			} 
			set
			{
				list = new DebugValue[value];
			}
		}
		[SerializeField]
		public bool enabled;
		[SerializeField]
		public DebugValue[] list;

		public Group(string name) {
			this.name = name;
		}

		public Group(string name, DebugValue[] list) {
			this.name = name;
			this.list = list;
		}
	}

	[System.Serializable]
	public class Collection {
		[SerializeField]
		public int size { get; set; }
		[SerializeField]
		public Group[] list;
	}
}