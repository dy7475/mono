//
// HostServices.cs
//
// Author:
//   Chris J Breisch (cjbreisch@altavista.net)
//
// (C) 2002 Chris J Breisch
//
namespace Microsoft.VisualBasic.CompilerServices {
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)] 
	[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Auto)] 
	sealed public class HostServices {
		// Declarations
		// Constructors
		// Properties
		public static Microsoft.VisualBasic.CompilerServices.IVbHost VBHost { get {return null;} set {} }
		// Methods
		// Events
	};
}
