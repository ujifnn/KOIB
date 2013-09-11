using System; 

using System.IO; 

using System.Runtime.InteropServices; 

 

 

namespace Croc.Bpc.GsScannerDriver.SIB2003 

{ 

	/// <summary> 

	/// ????????? ????????? ???????. 

	/// </summary> 

	[StructLayout(LayoutKind.Sequential)] 

	public struct ManufProps : IManufProps 

	{ 

		/// <summary> 

		/// ???????? ????? ??????? 

		/// </summary> 

		public int		common_serial_number; 

 

 

		/// <summary> 

		/// ?????? 1 

		/// </summary> 

		public short	r1; 

 

 

		/// <summary> 

		/// ??????? ??????????? CIS 

		/// </summary> 

		public short	lamps; 

 

 

		/// <summary> 

		/// ?????? 2 

		/// </summary> 

		public short	r2; 

 

 

		/// <summary> 

		/// ?????? 3 

		/// </summary> 

		public short	r3; 

 

 

		/// <summary> 

		/// ?????? 4 

		/// </summary> 

		public short	r4; 

 

 

		/// <summary> 


		/// ?????? 5 

		/// </summary> 

		public short	r5; 

 

 

		/// <summary> 

		/// ??????? ?????? ??? ??????? 0 

		/// </summary> 

		public short	adc_line0_b; 

 

 

		/// <summary> 

		/// ??????????? ???????? ??? ??????? 0 

		/// </summary> 

		public short	adc_line0_w; 

 

 

		/// <summary> 

		/// ?????? 6 

		/// </summary> 

		public short	r6; 

 

 

		/// <summary> 

		/// ?????????? 

		/// </summary> 

		public short	r7; 

 

 

		/// <summary> 

		/// ??????? ?????? ??? ??????? 1 

		/// </summary> 

		public short	adc_line1_b; 

 

 

		/// <summary> 

		/// ??????????? ???????? ??? ??????? 1 

		/// </summary> 

		public short	adc_line1_w; 

 

 

		/// <summary> 

		/// ????? ?????? ?????????? ?? ?????? ??? ?????????, ?? 

		/// </summary> 

		public short	marker_on_time; 

 

 

		/// <summary> 

		/// ??????????, ?????????? ?? ??????, ??? ?????????, ?? 

		/// </summary> 


		public short	marker_on_volt; 

 

 

		/// <summary> 

		/// ????? ?????? ?????????? ?? ?????? ??? ??????????, ?? 

		/// </summary> 

		public short	marker_off_time; 

 

 

		/// <summary> 

		/// ??????????, ?????????? ?? ??????, ??? ??????????, ?? 

		/// </summary> 

		public short	marker_off_volt; 

 

 

		/// <summary> 

		/// ????? ??????????? ?? ??????? 0 

		/// </summary> 

		public short	common_bg_bin_th0; 

 

 

		/// <summary> 

		/// ????? ??????????? ?? ??????? 1 

		/// </summary> 

		public short	common_bg_bin_th1; 

 

 

		/// <summary> 

		/// DPI ?? ??? X (??????? 0) 

		/// </summary> 

		public short	common_dpi_x0; 

 

 

		/// <summary> 

		/// DPI ?? ??? X (??????? 1) 

		/// </summary> 

		public short	common_dpi_x1; 

 

 

		/// <summary> 

		/// DPI ?? ??? Y (??????? 0) 

		/// </summary> 

		public short	common_dpi_y0; 

 

 

		/// <summary> 

		/// DPI ?? ??? Y (??????? 1) 

		/// </summary> 

		public short	common_dpi_y1; 

 


 
		/// <summary> 

		/// ?????????? ????? ??? ??????????? ??????? ????? 

		/// </summary> 

		public short	ActivePoints; 

 

 

		/// <summary> 

		/// ????? ??? ??????????? ??????? ????? 

		/// </summary> 

		public short	Porog; 

 

 

		/// <summary> 

		/// ?????????? ????? ????????? 

		/// </summary> 

		public short	shift_lines; 

 

 

		/// <summary> 

		/// ?????????? ????? ??? ?????? ????? 

		/// </summary> 

		public short	stepOnDrop; 

 

 

		/// <summary> 

		/// ????? ???? ??????? ??? ???????????? 

		/// </summary> 

		public short	mainSpeed; 

 

 

		/// <summary> 

		/// ?????????? ????? ??? ?????????? ????? 

		/// </summary> 

		public short	stepOnMarker; 

 

 

		/// <summary> 

		/// ????? ??????? ???? ?? ??????? ??????? (??? 2003 ???????) 

		/// </summary> 

		public short	gap0; 

 

 

		/// <summary> 

		/// ??????? ????? ?????? ?????????? ?? ?????? ??? ?????????, ?? 

		/// </summary> 

		public short	marker_on_long_time; 

 

 

		/// <summary> 


		/// ????? ?????? ?????????? ?? ?????? ??? ????????, ?? 

		/// </summary> 

		public short	marker_off_long_time; 

 

 

		/// <summary> 

		/// ????? ???? ??????? ??? ?????????? 

		/// </summary> 

		public short	markerSpeed;  

 

 

		/// <summary> 

		/// ????? ??????? ???? ?? ?????? ??????? (??? 2003 ???????) 

		/// </summary> 

		public short	gap1; 

 

 

		/// <summary> 

		/// ??????????, ?????????? ?? ??????, ??? ????????, ?? 

		/// </summary> 

		public short	marker_park_volt; 

 

 

		/// <summary> 

		/// ????? ??????? ??? ??????????? ???????????, % 

		/// </summary> 

		public short	percentForDirt; 

 

 

		/// <summary> 

		/// ?????????? ????? ??? ??????????? ??????????? 

		/// </summary> 

		public short	linesForDirt;  

 

 

		/// <summary> 

		/// ??????????, ?????????? ?? ??????, ??? ????????? ?????, ?? 

		/// </summary> 

		public short	marker_hold_volt; 

 

 

		/// <summary> 

		/// ????? ?????? ?????????? ?? ?????? ??? ????????? ?????, ?? 

		/// </summary> 

		public short	marker_hold_time; 

 

 

		/// <summary> 

		/// ????? ??????????? ???????? ????? (????? ??????) 

		/// </summary> 


		public short	doubleSheetLevelL; 

 

 

		/// <summary> 

		/// ????????? ??????????? ???????? ????? 

		/// </summary> 

		public short	doubleSheetParam; 

 

 

		/// <summary> 

		/// ????? ??????????? ???????? ????? (?????? ??????) 

		/// </summary> 

		public short	doubleSheetLevelR; 

 

 

		/// <summary> 

		/// ?????? 10 - 14 

		/// </summary> 

		[MarshalAs(UnmanagedType.ByValArray, SizeConst=5)] 

		short[]	reserv; 

 

 

		/// <summary> 

		/// ????????? ????????? ??????? 

		/// </summary> 

		/// <param name="data">?????????? ?? ????????? ???????? ??????</param> 

		public ManufProps( byte[] data ) 

		{ 

			BinaryReader br = new System.IO.BinaryReader( new MemoryStream( data ) ); 

			common_serial_number = br.ReadInt32(); 

			r1 = br.ReadInt16(); 

			lamps = br.ReadInt16(); 

			r2 = br.ReadInt16(); 

			r3 = br.ReadInt16(); 

			r4 = br.ReadInt16(); 

			r5 = br.ReadInt16(); 

			adc_line0_b = br.ReadInt16(); 

			adc_line0_w = br.ReadInt16(); 

			r6 = br.ReadInt16(); 

			r7 = br.ReadInt16(); 

			adc_line1_b = br.ReadInt16(); 

			adc_line1_w = br.ReadInt16(); 

			marker_on_time = br.ReadInt16(); 

			marker_on_volt = br.ReadInt16(); 

			marker_off_time = br.ReadInt16(); 

			marker_off_volt = br.ReadInt16(); 

			common_bg_bin_th0 = br.ReadInt16(); 

			common_bg_bin_th1 = br.ReadInt16(); 

			common_dpi_x0 = br.ReadInt16(); 

			common_dpi_x1 = br.ReadInt16(); 


			common_dpi_y0 = br.ReadInt16(); 

			common_dpi_y1 = br.ReadInt16(); 

			ActivePoints = br.ReadInt16(); 

			Porog = br.ReadInt16(); 

			shift_lines = br.ReadInt16(); 

			stepOnDrop = br.ReadInt16(); 

			mainSpeed = br.ReadInt16(); 

			stepOnMarker = br.ReadInt16(); 

			gap0 = br.ReadInt16(); 

			marker_on_long_time = br.ReadInt16(); 

			marker_off_long_time = br.ReadInt16(); 

			markerSpeed = br.ReadInt16(); 

			gap1 = br.ReadInt16(); 

			marker_park_volt = br.ReadInt16(); 

			percentForDirt = br.ReadInt16(); 

			linesForDirt = br.ReadInt16(); 

			marker_hold_volt = br.ReadInt16(); 

			marker_hold_time = br.ReadInt16(); 

			doubleSheetLevelL = br.ReadInt16(); 

			doubleSheetParam = br.ReadInt16(); 

			doubleSheetLevelR = br.ReadInt16(); 

			reserv = new short[5]; 

			for ( int i = 0; i < reserv.Length; i++ ) 

			{ 

				reserv[i] = br.ReadInt16(); 

			} 

		} 

 

 

        /// <inheritdoc/> 

        public int SerialNumber 

	    { 

            get { return common_serial_number; } 

	    } 

 

 

        /// <inheritdoc/> 

        public short ShiftLines 

	    { 

	        get { return shift_lines; } 

	    } 

	} 

}


