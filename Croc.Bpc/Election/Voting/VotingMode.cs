using System; 

using System.Collections.Generic; 

using System.Xml; 

using System.Xml.Schema; 

using System.Xml.Serialization; 

using System.IO; 

using System.Text; 

 

 

namespace Croc.Bpc.Election.Voting 

{ 

    /// <summary> 

    /// ?????? ??????????? 

    /// </summary> 

    [XmlType("Mode")] 

    public enum VotingMode : int 

    { 

        /// <summary> 

        /// ??????????? ?? ?????? 

        /// </summary> 

        None = 0, 

        /// <summary> 

        /// ????????? ??????????? 

        /// </summary> 

        /// <remarks>?? ????????????: ????????? ??? ????????????? ?? ??????? ??</remarks> 

        Ahead, 

        /// <summary> 

        /// ??????????? ? ???????? ?????? 

        /// </summary> 

        Test, 

        /// <summary> 

        /// ???????????? ??????????? 

        /// </summary> 

        Main, 

        /// <summary> 

        /// ?????????? ??????????? 

        /// </summary> 

        Portable, 

        /// <summary> 

        /// ?????????? ?????? 

        /// </summary> 

        /// <remarks>?? ????????????: ????????? ??? ????????????? ?? ??????? ??</remarks> 

        Results, 

    } 

}


