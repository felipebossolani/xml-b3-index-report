using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace xml_b3_index_report
{
	[XmlRoot(ElementName = "SchmeNm", Namespace = "urn:bvmf.052.01.xsd")]
	public class SchmeNm
	{
		[XmlElement(ElementName = "Prtry", Namespace = "urn:bvmf.052.01.xsd")]
		public string Prtry { get; set; }
	}

	[XmlRoot(ElementName = "Othr", Namespace = "urn:bvmf.052.01.xsd")]
	public class Othr
	{
		[XmlElement(ElementName = "Id", Namespace = "urn:bvmf.052.01.xsd")]
		public string Id { get; set; }
		[XmlElement(ElementName = "Issr", Namespace = "urn:bvmf.052.01.xsd")]
		public string Issr { get; set; }
		[XmlElement(ElementName = "SchmeNm", Namespace = "urn:bvmf.052.01.xsd")]
		public SchmeNm SchmeNm { get; set; }
	}

	[XmlRoot(ElementName = "OrgId", Namespace = "urn:bvmf.052.01.xsd")]
	public class OrgId
	{
		[XmlElement(ElementName = "Othr", Namespace = "urn:bvmf.052.01.xsd")]
		public Othr Othr { get; set; }
		[XmlElement(ElementName = "Id", Namespace = "urn:bvmf.052.01.xsd")]
		public Id Id { get; set; }
	}

	[XmlRoot(ElementName = "Id", Namespace = "urn:bvmf.052.01.xsd")]
	public class Id
	{
		[XmlElement(ElementName = "OrgId", Namespace = "urn:bvmf.052.01.xsd")]
		public OrgId OrgId { get; set; }
	}

	[XmlRoot(ElementName = "Fr", Namespace = "urn:bvmf.052.01.xsd")]
	public class Fr
	{
		[XmlElement(ElementName = "OrgId", Namespace = "urn:bvmf.052.01.xsd")]
		public OrgId OrgId { get; set; }
	}

	[XmlRoot(ElementName = "To", Namespace = "urn:bvmf.052.01.xsd")]
	public class To
	{
		[XmlElement(ElementName = "OrgId", Namespace = "urn:bvmf.052.01.xsd")]
		public OrgId OrgId { get; set; }
	}

	[XmlRoot(ElementName = "BizGrpDtls", Namespace = "urn:bvmf.052.01.xsd")]
	public class BizGrpDtls
	{
		[XmlElement(ElementName = "BizGrpIdr", Namespace = "urn:bvmf.052.01.xsd")]
		public string BizGrpIdr { get; set; }
		[XmlElement(ElementName = "TtlNbOfMsg", Namespace = "urn:bvmf.052.01.xsd")]
		public string TtlNbOfMsg { get; set; }
		[XmlElement(ElementName = "BizGrpTp", Namespace = "urn:bvmf.052.01.xsd")]
		public string BizGrpTp { get; set; }
		[XmlElement(ElementName = "CreDtAndTm", Namespace = "urn:bvmf.052.01.xsd")]
		public string CreDtAndTm { get; set; }
	}

	[XmlRoot(ElementName = "MsgTpDef", Namespace = "urn:bvmf.052.01.xsd")]
	public class MsgTpDef
	{
		[XmlElement(ElementName = "MsgDefIdr", Namespace = "urn:bvmf.052.01.xsd")]
		public string MsgDefIdr { get; set; }
		[XmlElement(ElementName = "NbOfMsg", Namespace = "urn:bvmf.052.01.xsd")]
		public string NbOfMsg { get; set; }
	}

	[XmlRoot(ElementName = "BizGrpDesc", Namespace = "urn:bvmf.052.01.xsd")]
	public class BizGrpDesc
	{
		[XmlElement(ElementName = "Fr", Namespace = "urn:bvmf.052.01.xsd")]
		public Fr Fr { get; set; }
		[XmlElement(ElementName = "To", Namespace = "urn:bvmf.052.01.xsd")]
		public To To { get; set; }
		[XmlElement(ElementName = "BizGrpDtls", Namespace = "urn:bvmf.052.01.xsd")]
		public BizGrpDtls BizGrpDtls { get; set; }
		[XmlElement(ElementName = "MsgTpDef", Namespace = "urn:bvmf.052.01.xsd")]
		public MsgTpDef MsgTpDef { get; set; }
	}

	[XmlRoot(ElementName = "SchmeNm", Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]
	public class SchmeNm2
	{
		[XmlElement(ElementName = "Prtry", Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]
		public string Prtry { get; set; }
	}

	[XmlRoot(ElementName = "Othr", Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]
	public class Othr2
	{
		[XmlElement(ElementName = "Id", Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]
		public string Id2 { get; set; }
		[XmlElement(ElementName = "SchmeNm", Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]
		public SchmeNm2 SchmeNm2 { get; set; }
		[XmlElement(ElementName = "Issr", Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]
		public string Issr { get; set; }
	}

	[XmlRoot(ElementName = "OrgId", Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]
	public class OrgId2
	{
		[XmlElement(ElementName = "Othr", Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]
		public Othr2 Othr2 { get; set; }
		[XmlElement(ElementName = "Id", Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]
		public Id2 Id2 { get; set; }
	}

	[XmlRoot(ElementName = "Id", Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]
	public class Id2
	{
		[XmlElement(ElementName = "OrgId", Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]
		public OrgId2 OrgId2 { get; set; }
	}

	[XmlRoot(ElementName = "Fr", Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]
	public class Fr2
	{
		[XmlElement(ElementName = "OrgId", Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]
		public OrgId OrgId { get; set; }
	}

	[XmlRoot(ElementName = "To", Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]
	public class To2
	{
		[XmlElement(ElementName = "OrgId", Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]
		public OrgId2 OrgId2 { get; set; }
	}

	[XmlRoot(ElementName = "AppHdr", Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]
	public class AppHdr
	{
		[XmlElement(ElementName = "BizMsgIdr", Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]
		public string BizMsgIdr { get; set; }
		[XmlElement(ElementName = "MsgDefIdr", Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]
		public string MsgDefIdr { get; set; }
		[XmlElement(ElementName = "CreDt", Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]
		public string CreDt { get; set; }
		[XmlElement(ElementName = "Fr", Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]
		public Fr2 Fr2 { get; set; }
		[XmlElement(ElementName = "To", Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]
		public To2 To2 { get; set; }
		[XmlAttribute(AttributeName = "xmlns")]
		public string Xmlns { get; set; }
		[XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Xsi { get; set; }
		[XmlAttribute(AttributeName = "schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string SchemaLocation { get; set; }
	}

	[XmlRoot(ElementName = "TradDt", Namespace = "urn:bvmf.218.01.xsd")]
	public class TradDt
	{
		[XmlElement(ElementName = "Dt", Namespace = "urn:bvmf.218.01.xsd")]
		public string Dt { get; set; }
	}

	[XmlRoot(ElementName = "SctyId", Namespace = "urn:bvmf.218.01.xsd")]
	public class SctyId
	{
		[XmlElement(ElementName = "TckrSymb", Namespace = "urn:bvmf.218.01.xsd")]
		public string TckrSymb { get; set; }
	}

	[XmlRoot(ElementName = "Tp", Namespace = "urn:bvmf.218.01.xsd")]
	public class Tp
	{
		[XmlElement(ElementName = "Prtry", Namespace = "urn:bvmf.218.01.xsd")]
		public string Prtry { get; set; }
	}

	[XmlRoot(ElementName = "OthrId", Namespace = "urn:bvmf.218.01.xsd")]
	public class OthrId
	{
		[XmlElement(ElementName = "Id", Namespace = "urn:bvmf.218.01.xsd")]
		public string Id3 { get; set; }
		[XmlElement(ElementName = "Tp", Namespace = "urn:bvmf.218.01.xsd")]
		public Tp Tp { get; set; }
	}

	[XmlRoot(ElementName = "PlcOfListg", Namespace = "urn:bvmf.218.01.xsd")]
	public class PlcOfListg
	{
		[XmlElement(ElementName = "MktIdrCd", Namespace = "urn:bvmf.218.01.xsd")]
		public string MktIdrCd { get; set; }
	}

	[XmlRoot(ElementName = "FinInstrmId", Namespace = "urn:bvmf.218.01.xsd")]
	public class FinInstrmId
	{
		[XmlElement(ElementName = "OthrId", Namespace = "urn:bvmf.218.01.xsd")]
		public OthrId OthrId { get; set; }
		[XmlElement(ElementName = "PlcOfListg", Namespace = "urn:bvmf.218.01.xsd")]
		public PlcOfListg PlcOfListg { get; set; }
	}

	[XmlRoot(ElementName = "OpngPric", Namespace = "urn:bvmf.218.01.xsd")]
	public class OpngPric
	{
		[XmlAttribute(AttributeName = "Ccy")]
		public string Ccy { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "MinPric", Namespace = "urn:bvmf.218.01.xsd")]
	public class MinPric
	{
		[XmlAttribute(AttributeName = "Ccy")]
		public string Ccy { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "MaxPric", Namespace = "urn:bvmf.218.01.xsd")]
	public class MaxPric
	{
		[XmlAttribute(AttributeName = "Ccy")]
		public string Ccy { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "TradAvrgPric", Namespace = "urn:bvmf.218.01.xsd")]
	public class TradAvrgPric
	{
		[XmlAttribute(AttributeName = "Ccy")]
		public string Ccy { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "PrvsDayClsgPric", Namespace = "urn:bvmf.218.01.xsd")]
	public class PrvsDayClsgPric
	{
		[XmlAttribute(AttributeName = "Ccy")]
		public string Ccy { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "ClsgPric", Namespace = "urn:bvmf.218.01.xsd")]
	public class ClsgPric
	{
		[XmlAttribute(AttributeName = "Ccy")]
		public string Ccy { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "IndxVal", Namespace = "urn:bvmf.218.01.xsd")]
	public class IndxVal
	{
		[XmlAttribute(AttributeName = "Ccy")]
		public string Ccy { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "SctyInf", Namespace = "urn:bvmf.218.01.xsd")]
	public class SctyInf
	{
		[XmlElement(ElementName = "SctyId", Namespace = "urn:bvmf.218.01.xsd")]
		public SctyId SctyId { get; set; }
		[XmlElement(ElementName = "FinInstrmId", Namespace = "urn:bvmf.218.01.xsd")]
		public FinInstrmId FinInstrmId { get; set; }
		[XmlElement(ElementName = "OpngPric", Namespace = "urn:bvmf.218.01.xsd")]
		public OpngPric OpngPric { get; set; }
		[XmlElement(ElementName = "MinPric", Namespace = "urn:bvmf.218.01.xsd")]
		public MinPric MinPric { get; set; }
		[XmlElement(ElementName = "MaxPric", Namespace = "urn:bvmf.218.01.xsd")]
		public MaxPric MaxPric { get; set; }
		[XmlElement(ElementName = "TradAvrgPric", Namespace = "urn:bvmf.218.01.xsd")]
		public TradAvrgPric TradAvrgPric { get; set; }
		[XmlElement(ElementName = "PrvsDayClsgPric", Namespace = "urn:bvmf.218.01.xsd")]
		public PrvsDayClsgPric PrvsDayClsgPric { get; set; }
		[XmlElement(ElementName = "ClsgPric", Namespace = "urn:bvmf.218.01.xsd")]
		public ClsgPric ClsgPric { get; set; }
		[XmlElement(ElementName = "IndxVal", Namespace = "urn:bvmf.218.01.xsd")]
		public IndxVal IndxVal { get; set; }
		[XmlElement(ElementName = "OscnVal", Namespace = "urn:bvmf.218.01.xsd")]
		public string OscnVal { get; set; }
	}

	[XmlRoot(ElementName = "SttlmVal", Namespace = "urn:bvmf.218.01.xsd")]
	public class SttlmVal
	{
		[XmlAttribute(AttributeName = "Ccy")]
		public string Ccy { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "IndxInf", Namespace = "urn:bvmf.218.01.xsd")]
	public class IndxInf
	{
		[XmlElement(ElementName = "SctyInf", Namespace = "urn:bvmf.218.01.xsd")]
		public SctyInf SctyInf { get; set; }
		[XmlElement(ElementName = "AsstDesc", Namespace = "urn:bvmf.218.01.xsd")]
		public string AsstDesc { get; set; }
		[XmlElement(ElementName = "SttlmVal", Namespace = "urn:bvmf.218.01.xsd")]
		public SttlmVal SttlmVal { get; set; }
		[XmlElement(ElementName = "RsngShrsNb", Namespace = "urn:bvmf.218.01.xsd")]
		public string RsngShrsNb { get; set; }
		[XmlElement(ElementName = "FlngShrsNb", Namespace = "urn:bvmf.218.01.xsd")]
		public string FlngShrsNb { get; set; }
		[XmlElement(ElementName = "StblShrsNb", Namespace = "urn:bvmf.218.01.xsd")]
		public string StblShrsNb { get; set; }
	}

	[XmlRoot(ElementName = "IOPVInf", Namespace = "urn:bvmf.218.01.xsd")]
	public class IOPVInf
	{
		[XmlElement(ElementName = "SctyId", Namespace = "urn:bvmf.218.01.xsd")]
		public SctyId SctyId { get; set; }
		[XmlElement(ElementName = "FinInstrmId", Namespace = "urn:bvmf.218.01.xsd")]
		public FinInstrmId FinInstrmId { get; set; }
		[XmlElement(ElementName = "OpngPric", Namespace = "urn:bvmf.218.01.xsd")]
		public OpngPric OpngPric { get; set; }
		[XmlElement(ElementName = "MinPric", Namespace = "urn:bvmf.218.01.xsd")]
		public MinPric MinPric { get; set; }
		[XmlElement(ElementName = "MaxPric", Namespace = "urn:bvmf.218.01.xsd")]
		public MaxPric MaxPric { get; set; }
		[XmlElement(ElementName = "TradAvrgPric", Namespace = "urn:bvmf.218.01.xsd")]
		public TradAvrgPric TradAvrgPric { get; set; }
		[XmlElement(ElementName = "PrvsDayClsgPric", Namespace = "urn:bvmf.218.01.xsd")]
		public PrvsDayClsgPric PrvsDayClsgPric { get; set; }
		[XmlElement(ElementName = "ClsgPric", Namespace = "urn:bvmf.218.01.xsd")]
		public ClsgPric ClsgPric { get; set; }
		[XmlElement(ElementName = "IndxVal", Namespace = "urn:bvmf.218.01.xsd")]
		public IndxVal IndxVal { get; set; }
		[XmlElement(ElementName = "OscnVal", Namespace = "urn:bvmf.218.01.xsd")]
		public string OscnVal { get; set; }
	}

	[XmlRoot(ElementName = "RefPric", Namespace = "urn:bvmf.218.01.xsd")]
	public class RefPric
	{
		[XmlAttribute(AttributeName = "Ccy")]
		public string Ccy { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "BDRInf", Namespace = "urn:bvmf.218.01.xsd")]
	public class BDRInf
	{
		[XmlElement(ElementName = "SctyId", Namespace = "urn:bvmf.218.01.xsd")]
		public SctyId SctyId { get; set; }
		[XmlElement(ElementName = "FinInstrmId", Namespace = "urn:bvmf.218.01.xsd")]
		public FinInstrmId FinInstrmId { get; set; }
		[XmlElement(ElementName = "RefPric", Namespace = "urn:bvmf.218.01.xsd")]
		public RefPric RefPric { get; set; }
	}

	[XmlRoot(ElementName = "IndxRpt", Namespace = "urn:bvmf.218.01.xsd")]
	public class IndxRpt
	{
		[XmlElement(ElementName = "TradDt", Namespace = "urn:bvmf.218.01.xsd")]
		public TradDt TradDt { get; set; }
		[XmlElement(ElementName = "IndxInf", Namespace = "urn:bvmf.218.01.xsd")]
		public List<IndxInf> IndxInf { get; set; }
		[XmlElement(ElementName = "IOPVInf", Namespace = "urn:bvmf.218.01.xsd")]
		public List<IOPVInf> IOPVInf { get; set; }
		[XmlElement(ElementName = "BDRInf", Namespace = "urn:bvmf.218.01.xsd")]
		public List<BDRInf> BDRInf { get; set; }
	}

	[XmlRoot(ElementName = "Document", Namespace = "urn:bvmf.218.01.xsd")]
	public class Document
	{
		[XmlElement(ElementName = "IndxRpt", Namespace = "urn:bvmf.218.01.xsd")]
		public IndxRpt IndxRpt { get; set; }
		[XmlAttribute(AttributeName = "xmlns")]
		public string Xmlns { get; set; }
	}

	[XmlRoot(ElementName = "BizGrp", Namespace = "urn:bvmf.052.01.xsd")]
	public class BizGrp
	{
		[XmlElement(ElementName = "AppHdr", Namespace = "urn:iso:std:iso:20022:tech:xsd:head.001.001.01")]
		public AppHdr AppHdr { get; set; }
		[XmlElement(ElementName = "Document", Namespace = "urn:bvmf.218.01.xsd")]
		public Document Document { get; set; }
	}

	[XmlRoot(ElementName = "Xchg", Namespace = "urn:bvmf.052.01.xsd")]
	public class Xchg
	{
		[XmlElement(ElementName = "BizGrpDesc", Namespace = "urn:bvmf.052.01.xsd")]
		public BizGrpDesc BizGrpDesc { get; set; }
		[XmlElement(ElementName = "BizGrp", Namespace = "urn:bvmf.052.01.xsd")]
		public BizGrp BizGrp { get; set; }
	}

	[XmlRoot(ElementName = "BizFileHdr", Namespace = "urn:bvmf.052.01.xsd")]
	public class BizFileHdr
	{
		[XmlElement(ElementName = "Xchg", Namespace = "urn:bvmf.052.01.xsd")]
		public Xchg Xchg { get; set; }
	}

	[XmlRoot(ElementName = "Document", Namespace = "urn:bvmf.052.01.xsd")]
	public class Document2
	{
		[XmlElement(ElementName = "BizFileHdr", Namespace = "urn:bvmf.052.01.xsd")]
		public BizFileHdr BizFileHdr { get; set; }
		[XmlAttribute(AttributeName = "schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
		public string SchemaLocation { get; set; }
		[XmlAttribute(AttributeName = "xmlns")]
		public string Xmlns { get; set; }
		[XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
		public string Xsi { get; set; }
	}

}
