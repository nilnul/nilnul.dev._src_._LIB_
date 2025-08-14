using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.src.division
{
	/// <summary>
	/// take <see cref="dev.ISrc1"/> as base, and then in each sln, we can referefence divisions in other sln by a relPath which takes the src as base.
	/// </summary>
	/// <remarks>
	/// due to the comments of the dir name, including the commented subsrc dir, the relPath might be not working in FileExplorer; but we can make it work by our sdk, such as nilnul.dev.Test, where we can pindown a prj by its nomina;
	/// </remarks>
	/// 
	internal class AsPath
	{
	}
}
