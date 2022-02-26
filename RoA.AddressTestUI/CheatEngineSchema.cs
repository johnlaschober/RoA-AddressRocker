using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RoA.AddressTestUI
{
	// using System.Xml.Serialization;
	// XmlSerializer serializer = new XmlSerializer(typeof(CheatTable));
	// using (StringReader reader = new StringReader(xml))
	// {
	//    var test = (CheatTable)serializer.Deserialize(reader);
	// }

	[XmlRoot(ElementName = "Offsets")]
	public class Offsets
	{

		[XmlElement(ElementName = "Offset")]
		public List<string> Offset { get; set; }
	}

	[XmlRoot(ElementName = "CheatEntry")]
	public class CheatEntry
	{

		[XmlElement(ElementName = "ID")]
		public int ID { get; set; }

		[XmlElement(ElementName = "Description")]
		public string Description { get; set; }

		[XmlElement(ElementName = "VariableType")]
		public string VariableType { get; set; }

		[XmlElement(ElementName = "Address")]
		public string Address { get; set; }

		[XmlElement(ElementName = "Offsets")]
		public Offsets Offsets { get; set; }
	}

	[XmlRoot(ElementName = "CheatEntries")]
	public class CheatEntries
	{

		[XmlElement(ElementName = "CheatEntry")]
		public List<CheatEntry> CheatEntry { get; set; }
	}

	[XmlRoot(ElementName = "CheatTable")]
	public class CheatTable
	{

		[XmlElement(ElementName = "CheatEntries")]
		public CheatEntries CheatEntries { get; set; }
	}
}
