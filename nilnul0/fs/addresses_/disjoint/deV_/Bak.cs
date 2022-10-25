﻿using nilnul.fs.address_.shields_;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace nilnul.fs.addresses_.disjoint.deV_
{
	/// <summary>
	/// given srcs that is disjoint addresses(including both spears and shields), clean bin and obj dir in vs proj.
	/// </summary>
	public  class Clean
	{
		/// <summary>
		/// we extract nondisjoint folders, which is destinyDisjoint (with regards to their destiny that is nonlink, the collection is disjoint).
		/// </summary>
		private nilnul.fs.addresses_.disjoint.deV_._bak.Io _cfg;
		public nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg
		{
			get { return _cfg; }
			set { _cfg = value; }
		}

		public Clean(nilnul.fs.addresses_.disjoint.deV_._bak.Io cfg)
		{
			_cfg = cfg;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="_shieldsDisjoint">
		/// disjoint
		/// </param>
		public  void _Bak(
			IEnumerable<string> _shieldsDisjoint
			
		)
		{
			var cancel = cfg.cancel;
			string shieldsTxt = nilnul.fs.address.str._PhraseX.Phrase(_shieldsDisjoint);
			Trace.TraceWarning($"begin {shieldsTxt}...");
			if (cancel.IsCancellationRequested)
			{
				Trace.TraceWarning($"cancelled {shieldsTxt}...");

				return;
			}

			//Trace.Indent();
		
			try
			{
				foreach (string src in _shieldsDisjoint)
				{
					cancel.ThrowIfCancellationRequested();

					new nilnul.fs.addresses_._disjoint.item.deV_.Bak(cfg).vod_ofAddress(src);
				}
			}
			finally
			{
				//Trace.Unindent();

			}

			//throw new NotImplementedException();
		}

		public void _bak_assumeDisjoint(List<AddressI> addressIs)
		{
			_Bak(
				addressIs.Select(a => a.ToString())
			);
		}

		public  void _ShuffleAndBak(
			IEnumerable<string> _shieldsDisjoint
			
		)

			
		{
			//shall be shuffled and shown in UI lest the UI is inconsisitent with the order in action.
			_Bak(
				/*nilnul.obj.str.op_.unary_._ShuffleX.Op*/
				(_shieldsDisjoint)
				
			);

		}

		public  void _Bak( Disjoint disjoint)
		{
			_Bak( disjoint.toOriginal().Select(x => x.ToString()));

			//throw new NotImplementedException();
		}


		

	}
}
