using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folders_.unjoint.divs_.raw_
{
	/// <summary>
	/// get modules
	/// </summary>
	public  class Module
	{

		private nilnul.fs.folders_._unjoint.Io _io;

		public nilnul.fs.folders_._unjoint.Io io
		{
			get { return _io; }
			set { _io = value; }
		}
		public Module( _unjoint.Io io)
		{
			_io = io;
		}

		public IEnumerable<string> insideModules(
			
		) {

			return io.destinySrc.Values.SelectMany(
				f=> new _unjoint.item.InsideModules(io).addresses_ofAddress(f.ToString())
			);
		}
		//public IEnumerable<string> insideModules(
		//	nilnul.fs.folders.be_.destinyDisjoint.vow.Ee unjoint
		//) {

		//	return unjoint.ee.SelectMany(
		//		f=> new _unjoint.item.InsideModules(io).addresses_ofAddress(f.ToString())
		//	);
		//}


		//public IEnumerable<string> insideModules(
		//	IEnumerable<string> unjoint
		//) {

		//	return insideModules( new folders.be_.destinyDisjoint.vow.Ee(
		//		unjoint.Select(a=> nilnul.fs.Folder.FroAddress(a))
		//	));
		//}

		//public IEnumerable<string> insideModules(
		//	params string[] unjoint
		//) {

		//	return insideModules(
		//		(IEnumerable<string>) unjoint
		//	);
		//}


	}
}
