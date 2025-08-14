using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.srcs_.xpn_
{
	/// <summary>
	/// the <see cref=" nilnul.fs.location._TgtX"/>(the target of the link, or the address itself if it's not a link)s donot cross each other-that is no src is in another.
	/// srcs might be a collection of disjoint addresses; but when run, we need to check whether their targets cross; so this is a runtime exception; between different runs, targets might change and exception might disapear in a subsequent run;
	/// </summary>
	///

	[Serializable]
	public class JointException : Exception
		,
		srcs_.IXpn
	{
		public JointException() { }
		public JointException(string message) : base(message) { }
		public JointException(string message, Exception inner) : base(message, inner) { }
		protected JointException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
	}
	
}
