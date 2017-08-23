using System;

namespace XhElementManageTool
{
    public class ElementStruct
    {
        //元件的结构体
        public struct Element
        {
            public string eNo{ get; set; }
            public string eName{ get; set; }
            public string eType{ get; set; }
            public string eFacturer{ get; set; }
            public string eModel{ get; set; }
            public string ePackage{ get; set; }
            public string  ePrice{ get; set; }
            public string eCount{ get; set; }
            public string eCreateDate{ get; set; }
            public string eModifDate{ get; set; }
            public string ePosition{ get; set; }
            public string eOtherInfo{ get; set; }

            public Element(string eNo, string eName, string eType, string eFacturer, string eModel, string ePackage, string ePrice, string eCount, string eCreateDate, string eModifDate, string ePosition, string eOtherInfo)
            {
                this.eNo = eNo;
                this.eName = eName;
                this.eType = eType;
                this.eFacturer = eFacturer;
                this.eModel = eModel;
                this.ePackage = ePackage;
                this.ePrice = ePrice;
                this.eCount = eCount;
                this.eCreateDate = eCreateDate;
                this.eModifDate = eModifDate;
                this.ePosition = ePosition;
                this.eOtherInfo = eOtherInfo;
            }
        }
    }
}