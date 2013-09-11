using System; 

using System.Text; 

 

 

namespace Croc.Core.Utils.Text 

{ 

	/// <summary> 

	/// ?????? <see cref="StringBuilder"/> ??? ???????????? ??????. 

	/// ????????????  

	/// </summary> 

	public class TextBuilder 

	{ 

		private readonly StringBuilder m_builder; 

		private int m_indent; 

 

 

		public TextBuilder() : this(new StringBuilder()) 

		{ 

		} 

 

 

		public TextBuilder(StringBuilder builder) 

		{ 

			m_builder = builder; 

		} 

 

 

		/// <summary> 

		/// ????????? ???????? ? ??????? ???????. 

		/// </summary> 

		/// <param name="sValue">????????</param> 

		/// <returns>??????? ??????</returns> 

		public TextBuilder Append(String sValue) 

		{ 

			m_builder.Append(sValue); 

			return this; 

		} 

 

 

		/// <summary> 

		/// ????????? ????? ?????? ? ??????? ???????? ? ??????. 

		/// </summary> 

		/// <param name="sValue">????????</param> 

		/// <returns>??????? ??????</returns> 

		public TextBuilder BeginLine(String sValue) 

		{ 

			if (m_indent > 0) 

				m_builder.Append('\t', m_indent); 

			m_builder.Append(sValue); 

			return this; 


		} 

 

 

		/// <summary> 

		/// ????????? ???????? ? ??????? ??????. 

		/// </summary> 

		/// <param name="sValue">????????</param> 

		/// <returns>??????? ??????</returns> 

		public TextBuilder EndLine(String sValue) 

		{ 

			m_builder.Append(sValue); 

			m_builder.Append(Environment.NewLine); 

			return this; 

		} 

 

 

		/// <summary> 

		/// ????????? ????? ?????? ? ??????? ???????? ? ?????? ? ? ????????? ? ?????. 

		/// </summary> 

		/// <param name="sValue">????????</param> 

		/// <returns>??????? ??????</returns> 

		public TextBuilder Line(String sValue) 

		{ 

			if (m_indent > 0) 

				m_builder.Append('\t', m_indent); 

			m_builder.Append(sValue); 

			m_builder.Append(Environment.NewLine); 

			return this; 

		} 

 

 

		/// <summary> 

		/// ????????? ????? ?????? ? ??????? ???????? ? ?????? ? ????????? ? ?????. 

		/// </summary> 

		/// <param name="sValue">??????-??????</param> 

		/// <param name="arg0">???????? ?? ??????-??????</param> 

		/// <returns>??????? ??????</returns> 

		public TextBuilder FormatLine(String sValue, object arg0) 

		{ 

			if (m_indent > 0) 

				m_builder.Append('\t', m_indent); 

			m_builder.AppendFormat(sValue, arg0); 

			m_builder.Append(Environment.NewLine); 

			return this; 

		} 

 

 

		/// <summary> 

		/// ????????? ??????? ??????. 

		/// </summary> 


		/// <returns>??????? ??????</returns> 

		public TextBuilder EmptyLine() 

		{ 

			m_builder.Append(Environment.NewLine); 

			return this; 

		} 

 

 

		/// <summary> 

		/// ??????????? ??????? ??????. 

		/// </summary> 

		/// <returns>??????? ??????</returns> 

		public TextBuilder IncreaseIndent() 

		{ 

			++m_indent; 

			return this; 

		} 

 

 

		/// <summary> 

		/// ????????? ??????? ??????. 

		/// </summary> 

		/// <returns>??????? ??????</returns> 

		public TextBuilder DecreaseIndent() 

		{ 

			if (m_indent == 0) 

				throw new InvalidOperationException("??????? ?????? ??? ????? 0"); 

			--m_indent; 

 

 

			return this; 

		} 

 

 

		public override string ToString() 

		{ 

			return m_builder.ToString(); 

		} 

	} 

}


