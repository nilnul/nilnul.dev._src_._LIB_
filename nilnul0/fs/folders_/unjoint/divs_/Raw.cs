using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folders_.unjoint.divs_
{
	/// <summary>
	/// get modules
	/// </summary>
	public  class Raw
	{

		private nilnul.fs.folders_._unjoint.Io _io;

		public nilnul.fs.folders_._unjoint.Io io
		{
			get { return _io; }
			set { _io = value; }
		}
		public Raw( _unjoint.Io io)
		{
			_io = io;
		}

		public IEnumerable<string> addresses(
			
		) {

			return io.destinySrc.Values.SelectMany(
				f=> new _unjoint.item.InsideRaws(io).addresses_ofAddress(f.ToString())
			);
		}


	}
}
