using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Romens.HeBeiZhuiSuXml
{
    // 注意: 生成的代码可能至少需要 .NET Framework 4.5 或 .NET Core/Standard 2.0。
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "www.hebfdea.com")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "www.hebfdea.com", IsNullable = false)]
    public partial class SIGNATURE
    {
        /// <remarks/>
        public SIGNATUREOBJECT OBJECT { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "www.hebfdea.com")]
    public partial class SIGNATUREOBJECT
    {
        private SIGNATUREOBJECTPACKAGE pACKAGEField;

        /// <remarks/>
        public SIGNATUREOBJECTPACKAGE PACKAGE
        {
            get
            {
                return this.pACKAGEField;
            }
            set
            {
                this.pACKAGEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "www.hebfdea.com")]
    public partial class SIGNATUREOBJECTPACKAGE
    {
        private SIGNATUREOBJECTPACKAGEENVELOPINFO eNVELOPINFOField;

        private List<SIGNATUREOBJECTPACKAGEROWINFO> dATAINFOField;

        /// <remarks/>
        public SIGNATUREOBJECTPACKAGEENVELOPINFO ENVELOPINFO
        {
            get
            {
                return this.eNVELOPINFOField;
            }
            set
            {
                this.eNVELOPINFOField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ROWINFO", IsNullable = false)]
        public List<SIGNATUREOBJECTPACKAGEROWINFO> DATAINFO
        {
            get
            {
                return this.dATAINFOField;
            }
            set
            {
                this.dATAINFOField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "www.hebfdea.com")]
    public partial class SIGNATUREOBJECTPACKAGEENVELOPINFO
    {
        private string vERSIONField;

        private string mESSAGE_IDField;

        private string fILE_NAMEField;

        private string mESSAGE_TYPEField;

        private uint sENDER_IDField;

        private string sEND_TIMEField;

        private uint rECEIVER_IDField;

        private byte sOFTTYPEField;

        private string sENDERNAMEField;

        /// <remarks/>
        public string VERSION
        {
            get
            {
                return this.vERSIONField;
            }
            set
            {
                this.vERSIONField = value;
            }
        }

        /// <remarks/>
        public string MESSAGE_ID
        {
            get
            {
                return this.mESSAGE_IDField;
            }
            set
            {
                this.mESSAGE_IDField = value;
            }
        }

        /// <remarks/>
        public string FILE_NAME
        {
            get
            {
                return this.fILE_NAMEField;
            }
            set
            {
                this.fILE_NAMEField = value;
            }
        }

        /// <remarks/>
        public string MESSAGE_TYPE
        {
            get
            {
                return this.mESSAGE_TYPEField;
            }
            set
            {
                this.mESSAGE_TYPEField = value;
            }
        }

        /// <remarks/>
        public uint SENDER_ID
        {
            get
            {
                return this.sENDER_IDField;
            }
            set
            {
                this.sENDER_IDField = value;
            }
        }

        /// <remarks/>
        public string SEND_TIME
        {
            get
            {
                return this.sEND_TIMEField;
            }
            set
            {
                this.sEND_TIMEField = value;
            }
        }

        /// <remarks/>
        public uint RECEIVER_ID
        {
            get
            {
                return this.rECEIVER_IDField;
            }
            set
            {
                this.rECEIVER_IDField = value;
            }
        }

        /// <remarks/>
        public byte SOFTTYPE
        {
            get
            {
                return this.sOFTTYPEField;
            }
            set
            {
                this.sOFTTYPEField = value;
            }
        }

        /// <remarks/>
        public string SENDERNAME
        {
            get
            {
                return this.sENDERNAMEField;
            }
            set
            {
                this.sENDERNAMEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "www.hebfdea.com")]
    public partial class SIGNATUREOBJECTPACKAGEROWINFO
    {
        private string i_ITEM_CODEField;

        private uint yPPHField;

        private string vDATEField;

        private string pACKAGEField;

        private string uNITField;

        private decimal nUMField;

        private string jZ_DATEField;

        private string fPHField;

        private uint i_MER_CODEField;

        private string mER_NAMEField;

        private ulong mERA_CODEField;

        private byte bILL_TYPEField;

        /// <remarks/>
        public string I_ITEM_CODE
        {
            get
            {
                return this.i_ITEM_CODEField;
            }
            set
            {
                this.i_ITEM_CODEField = value;
            }
        }

        /// <remarks/>
        public uint YPPH
        {
            get
            {
                return this.yPPHField;
            }
            set
            {
                this.yPPHField = value;
            }
        }

        /// <remarks/>
        public string VDATE
        {
            get
            {
                return this.vDATEField;
            }
            set
            {
                this.vDATEField = value;
            }
        }

        /// <remarks/>
        public string PACKAGE
        {
            get
            {
                return this.pACKAGEField;
            }
            set
            {
                this.pACKAGEField = value;
            }
        }

        /// <remarks/>
        public string UNIT
        {
            get
            {
                return this.uNITField;
            }
            set
            {
                this.uNITField = value;
            }
        }

        /// <remarks/>
        public decimal NUM
        {
            get
            {
                return this.nUMField;
            }
            set
            {
                this.nUMField = value;
            }
        }

        /// <remarks/>
        public string JZ_DATE
        {
            get
            {
                return this.jZ_DATEField;
            }
            set
            {
                this.jZ_DATEField = value;
            }
        }

        /// <remarks/>
        public string FPH
        {
            get
            {
                return this.fPHField;
            }
            set
            {
                this.fPHField = value;
            }
        }

        /// <remarks/>
        public uint I_MER_CODE
        {
            get
            {
                return this.i_MER_CODEField;
            }
            set
            {
                this.i_MER_CODEField = value;
            }
        }

        /// <remarks/>
        public string MER_NAME
        {
            get
            {
                return this.mER_NAMEField;
            }
            set
            {
                this.mER_NAMEField = value;
            }
        }

        /// <remarks/>
        public ulong MERA_CODE
        {
            get
            {
                return this.mERA_CODEField;
            }
            set
            {
                this.mERA_CODEField = value;
            }
        }

        /// <remarks/>
        public byte BILL_TYPE
        {
            get
            {
                return this.bILL_TYPEField;
            }
            set
            {
                this.bILL_TYPEField = value;
            }
        }
    }
}