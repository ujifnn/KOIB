using System; 

using System.Xml.Serialization; 

 

 

namespace Croc.Bpc.Election.Voting 

{ 

	/// <summary> 

	/// ????????? ??????? ?????? ?????? 

	/// </summary> 

    [Serializable, XmlType("ModeTime")] 

    public class ModeTime 

	{ 

        /// <summary> 

        /// ????? ??????????? 

        /// </summary> 

        [XmlAttribute] 

        public VotingMode mode; 

 

 

        /// <summary> 

        /// ??? ?????? ?????? 

        /// </summary> 

        [XmlAttribute] 

        public int hour; 

 

 

        /// <summary> 

        /// ?????? ?????? ?????? 

        /// </summary> 

        [XmlAttribute] 

        public int minute; 

 

 

		/// <summary> 

		/// ????????? ????????? ????????????? ??????? 

		/// </summary> 

		public override string ToString() 

		{ 

			return	"[mode=" + mode.ToString() +  

					",hour=" + hour.ToString() +  

					",minute=" + minute.ToString() + "]"; 

		} 

 

 

        /// <summary> 

        /// ???????????? ????????????? ???????? 

        /// </summary> 

        public static ModeTime MaxValue 

        { 

            get 


            { 

                return new ModeTime() 

                { 

                    hour = int.MaxValue, 

                    minute = int.MaxValue 

                }; 

            } 

        } 

 

 

        /// <summary> 

        /// ????? ???-?? ????? = hour * 60 + minute 

        /// </summary> 

        public int TotalMinutes 

        { 

            get 

            { 

                return hour * 60 + minute; 

            } 

        } 

    } 

}


