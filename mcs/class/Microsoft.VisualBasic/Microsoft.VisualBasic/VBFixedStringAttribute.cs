//
// VBFixedStringAttribute.cs
//
// Author:
//   Chris J Breisch (cjbreisch@altavista.net)
//
// (C) 2002 Chris J Breisch
//
namespace Microsoft.VisualBasic {
	[System.AttributeUsageAttribute(System.AttributeTargets.Field)] 
	[System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Auto)] 
	sealed public class VBFixedStringAttribute : System.Attribute {
		// Declarations
		// Constructors
		VBFixedStringAttribute(System.Int32 Length) {}
		// Properties
		public System.Int32 Length { get {return 0;} }
		// Methods
		// Events
	};
}
