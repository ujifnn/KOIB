using System; 

using Croc.Core; 

using Croc.Bpc.Election.Voting; 

 

 

namespace Croc.Bpc.Election 

{ 

    /// <summary> 

    /// ????????? ?????????? ????????? ?????????? ??????? 

    /// </summary> 

    public interface IElectionManager : IStateSubsystem 

    { 

        /// <summary> 

        /// ??????? ????? ??????????? 

        /// </summary> 

        VotingMode CurrentVotingMode { get; set; } 

 

 

        #region ???????? ?????? 

 

 

        /// <summary> 

        /// ????? ??? 

        /// </summary> 

        int UIK { get; } 

 

 

        /// <summary> 

        /// ???????? ??????, ?? ??????? ?????????? ?????? 

        /// </summary> 

        SourceData SourceData { get; } 

 

 

		/// <summary> 

		/// ???????? ????????? ?? ???????? ?????? 

		/// </summary> 

		/// <returns>true - ????????? / false - ???</returns> 

		bool HasSourceData(); 

 

 

        /// <summary> 

        /// ???????? ????? ?????? ?????? ??????????? ?? ????????? 

        /// </summary> 

        /// <param name="mode">?????</param> 

        /// <returns>????? ??? TimeSpan.Zero, ???? ??? ?????????? ?????? ?? ?????? ????? ?? ?????????</returns> 

        TimeSpan GetDefaultVotingModeTime(VotingMode mode); 

 

 

        /// <summary> 

        /// ?????? ???? ???????? 


        /// </summary> 

        /// <param name="restored">???????, ??? ?????? ?? ???? ?????????????</param> 

        /// <returns> 

        /// true ? ???? Now ??????????? ????????? [???????????, ??????????? + (?? ????????????? ? 1 : 0) ],  

        ///       ??? Now ? ??????? ???? ?? ???????; 

        /// false ? ? ????????? ??????. 

        /// ?.?. ????? ? ???, ????? ??? ??????????????? ?? ???? ??????? ???????????? ?? 1 ???? ?????. 

        /// </returns> 

        bool IsElectionDayNow(bool restored); 

 

 

        /// <summary> 

        /// ????????? ????? ????? ? ?? 

        /// </summary> 

        /// <remarks> 

        /// ????? ????? ??????????? ? ???????????, ???????? ? ??????? 

        /// </remarks> 

        /// <param name="sourceDataFilePath">???? ? ????? ? ??</param> 

        /// <param name="uik">????? ???, ?????????? ?? ????? ?????</param> 

        /// <returns>true - ???? ? ?? ??????, false - ?? ??????</returns> 

        bool FindSourceDataFile(out string sourceDataFilePath, out int uik); 

 

 

        /// <summary> 

        /// ?????????? ?? 

        /// </summary> 

        /// <param name="sourceData">??</param> 

        /// <param name="uik">????? ???, ??????? ?????. ??</param> 

        void SetSourceData(SourceData sourceData, int uik); 

 

 

		/// <summary> 

		/// ????? ?? ????????? ?? 

		/// </summary> 

		/// <returns></returns> 

		bool NeedExecuteCheckExpressions { get; } 

 

 

		/// <summary> 

		/// ???????? ??? ???? ??? ?????? ?? 

		/// </summary> 

		/// <returns></returns> 

		string[] GetSourceDataSearchPaths(); 

 

 

        #endregion 

 

 

        #region ?????????? ??????????? 

 


 
        /// <summary> 

        /// ?????????? ??????????? 

        /// </summary> 

        VotingResults VotingResults { get; } 

 

 

        /// <summary> 

        /// ????????? ????????? ??????????? 

        /// </summary> 

        VotingResult LastVotingResult { get; } 

 

 

        /// <summary> 

        /// ???????? ????????? ????????? ??????????? 

        /// </summary> 

        void ResetLastVotingResult(); 

 

 

        /// <summary> 

        /// ?????????? ????????? ????????? ??????????? 

        /// </summary> 

        void SetLastVotingResult(VotingResult votingResult); 

 

 

        /// <summary> 

        /// ???????? ????????? ??????????? ?? ?????? ????????? 

        /// </summary> 

        void AddVotingResult( 

            VotingResult votingResult, 

            VotingMode votingMode, 

            int scannerSerialNumber); 

 

 

        #endregion 

 

 

        #region ?????????? ??????????? ??????????? 

 

 

        /// <summary> 

        /// ???????????? ??????????????? ???????? ? ???????????? ??????????? ?? ???? ??????? 

        /// </summary> 

        /// <remarks>???????? ??????????? ? ?????????? ? ?????? ????????? ???????, 

        /// ? ????? ??????????? ? ????????? ????</remarks> 

        void GeneratePreliminaryVotingResultProtocol(); 

 

 

        /// <summary> 

        /// ???????????? ???????? ? ???????????? ??????????? ?? ???????? ??????? 


        /// </summary> 

        /// <remarks>???????? ??????????? ? ?????????? ? ?????? ????????? ???????, 

        /// ? ????? ??????????? ? ????????? ????</remarks> 

        /// <param name="election">??????</param> 

        void GenerateVotingResultProtocol(Election.Voting.Election election); 

 

 

        /// <summary> 

        /// ????? ???? ? ????? ??? ?????????? ????????? ? ???????????? ??????????? 

        /// </summary> 

        /// <returns> 

        /// true - ???? ?????? ? ???????? ? ?????? ????????? ??????? 

        /// false - ???? ????? ?? ???????</returns> 

        bool FindFilePathToSaveVotingResultProtocol(); 

 

 

        /// <summary> 

        /// ????????? ???????? ? ???????????? ??????????? ? ????, ???? ???????? ??? ????? ????????? 

        /// </summary> 

        /// <returns> 

        /// true - ???????? ??????? ???????? 

        /// false - ?????? ??? ?????????? ????????? 

        /// </returns> 

        bool SaveVotingResultProtocol(); 

 

 

        #endregion 

    } 

}


