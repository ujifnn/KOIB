using System; 

using System.Collections.Generic; 

using System.Text; 

using Croc.Core; 

 

 

namespace Croc.Bpc.Printing.Reports.Templates 

{ 

    /// <summary> 

    /// ??????? ??????? ??? ???????????? ?????????? 

    /// </summary> 

    public abstract class BasePlainElement 

    { 

        /// <summary> 

        /// ???????????? ????????? ????? ????????? 

        /// </summary> 

        /// <param name="parser">?????? ?????????</param> 

        /// <returns>????????? ?????</returns> 

        public abstract Lines ConstructContent(ReportTemplateParser parser); 

    } 

}


