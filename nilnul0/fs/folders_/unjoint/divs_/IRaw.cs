using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folders_.unjoint.divs_
{

	/// <summary>
	/// enumerate divs that is:
	///		- not dotLed
	///			-- excluding .git
	///		- excluding vsSln0prj nonsrc folders such as packages, bin, obj
	///		- for linked, if its target is
	///				enumerated, an error would be booked.
	///				otherwise enumerated.
	///				- to achieve this, we need to keep a record.
	/// </summary>
	interface IRaw { }
}
